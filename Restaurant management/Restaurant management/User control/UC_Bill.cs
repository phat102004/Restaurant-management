using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static Restaurant_management.TenNV;
namespace Restaurant_management.User_control
{
    public partial class UC_Bill : UserControl
    {

        SqlCommand boLenh;
        SqlConnection ketNoi;
        
        public UC_Bill()
        {
            InitializeComponent();
            ketNoi = new SqlConnection();
            boLenh = new SqlCommand();
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            CreateButton();
            TinhTongTien();
        }
        string selectedTableName = "";


        private void CreateButton()
        {
            string query = @"SELECT b.TenBan, b.TrangThai, (SELECT COUNT(*) FROM HoaDonTam WHERE HoaDonTam.ID_Ban = b.ID_Ban) AS SoLuongMonAn
                            FROM Ban b;";
            int x = 10, y = 10, margin = 10;

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                boLenh = new SqlCommand(query, ketNoi);
                SqlDataReader reader = boLenh.ExecuteReader();
                panelTables.Controls.Clear();

                while (reader.Read())
                {
                    string tenBan = reader["TenBan"].ToString() ?? "Chưa đặt tên";
                    int trangThai = Convert.ToInt32(reader["TrangThai"]);
                    int soLuongMonAn = Convert.ToInt32(reader["SoLuongMonAn"]);

                    Button btnTable = new Button
                    {
                        Width = 150,
                        Height = 120,
                        Text = tenBan,
                        Tag = tenBan,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Location = new Point(x, y),
                        Name = $"btn_{tenBan.Replace(" ", "_")}",
                        BackColor = (trangThai == 1) ? Color.Red : Color.Green
                        
                    };

                    x += btnTable.Width + margin;
                    if (x + btnTable.Width > panelTables.Width)
                    {
                        x = 10;
                        y += btnTable.Height + margin;
                    }

                    btnTable.Click += BtnTable_Click;
                    panelTables.Controls.Add(btnTable);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bàn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
            }
        }
        private HashSet<string> banDaThanhToan = new HashSet<string>();


        private void BtnTable_Click(object? sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn?.Tag != null)
            {
                selectedTableName = btn.Tag?.ToString() ?? "Không xác định";
                if (banDaThanhToan.Contains(selectedTableName))
                {
                    dgv_HoaDon.DataSource = null;
                    MessageBox.Show($"Bàn {selectedTableName} đã thanh toán, không thể hiển thị dữ liệu!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string query = @"SELECT TenMon, SoLuong, Gia, ThanhTien, GETDATE() AS NgayTao 
                         FROM HoaDon 
                         WHERE TenBan = @TenBan";
                try
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }

                    using (SqlCommand boLenh = new SqlCommand(query, ketNoi))
                    {
                        boLenh.Parameters.AddWithValue("@TenBan", selectedTableName);

                        DataTable tableData = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(boLenh))
                        {
                            adapter.Fill(tableData);
                        }

                        if (tableData.Rows.Count > 0)
                        {
                            dgv_HoaDon.DataSource = tableData;
                            TinhTongTien();
                        }
                        else
                        {
                            dgv_HoaDon.DataSource = null;
                            MessageBox.Show("Bàn trống, chưa có món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị dữ liệu bàn: " + ex.Message,
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ketNoi.State == ConnectionState.Open) ketNoi.Close();
                }
            }
        }
        private void TinhTongTien()
        {
            try
            {
                decimal tongTien = 0;

                foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                {
                    if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }

                txtTongTien.Text = $"{tongTien:#,##0 VNĐ}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tổng tiền: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string employeeName = GlobalData.CurrentEmployeeName;
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            string tableName = string.IsNullOrEmpty(selectedTableName) ? "HoaDon" : selectedTableName;
            string defaultFileName = $"HoaDon_{tableName}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            if (dgv_HoaDon.Rows.Count == 0 || dgv_HoaDon.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu doanh thu để xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Thoát khỏi hàm
            }
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                FileName = defaultFileName
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("HoaDon");

                        
                        ws.Cells["D1"].Value = $"Hóa đơn {selectedTableName}";
                        ws.Cells["D1"].Style.Font.Bold = true;
                        ws.Cells["D1"].Style.Font.Size = 20;
                        ws.Cells["D1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells["D1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        ws.Cells["D1:E1"].Merge = true;
                        ws.Cells["D1:E1"].Style.Border.BorderAround(ExcelBorderStyle.None);

                        
                        ws.Cells["E3"].Value = $"Nhân viên: {employeeName}";
                        ws.Cells["E3"].Style.Font.Bold = false;
                        ws.Cells["E3"].Style.Font.Size = 14;
                        ws.Cells["E3:F3"].Merge = true; 
                        ws.Cells["E3:F3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                        
                        ws.Cells["E3:F3"].Style.WrapText = false;

                        
                        ws.Column(5).Width = 100; 
                        ws.Column(6).Width = 100; 

                        int row = 4, col = 3;
                        foreach (DataGridViewColumn c in dgv_HoaDon.Columns)
                        {
                            if (c.HeaderText.ToLower().Contains("ngày tạo")) continue;

                            var cell = ws.Cells[row, col];
                            cell.Value = c.HeaderText;
                            cell.Style.Font.Bold = true;
                            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            cell.Style.WrapText = true;

                            ws.Column(col).Width = c.HeaderText.ToLower().Contains("số lượng") ? 12 : 18;
                            col++;
                        }

                        // Xuất dữ liệu từ DataGridView
                        row++;
                        foreach (DataGridViewRow r in dgv_HoaDon.Rows)
                        {
                            col = 3;
                            foreach (DataGridViewCell cell in r.Cells)
                            {
                                if (dgv_HoaDon.Columns[cell.ColumnIndex].HeaderText.ToLower().Contains("ngày tạo")) continue;

                                var target = ws.Cells[row, col];
                                target.Value = cell.Value;
                                target.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                target.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                                target.Style.WrapText = true;

                                // Định dạng giá tiền
                                if (dgv_HoaDon.Columns[cell.ColumnIndex].HeaderText.ToLower().Contains("giá") ||
                                    dgv_HoaDon.Columns[cell.ColumnIndex].HeaderText.ToLower().Contains("thành"))
                                {
                                    target.Style.Numberformat.Format = "#,##0 VNĐ";
                                }
                                col++;
                            }
                            row++;
                        }

                        // Tính tổng thành tiền
                        ws.Cells[row, 3].Value = "Tổng thành tiền:";
                        ws.Cells[row, 3].Style.Font.Bold = true;
                        ws.Cells[row, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                        ws.Cells[row, 6].Formula = $"SUM(F4:F{row - 1})";
                        ws.Cells[row, 6].Style.Font.Bold = true;
                        ws.Cells[row, 6].Style.Numberformat.Format = "#,##0 VNĐ";

                        // Lưu file
                        package.SaveAs(new FileInfo(sfd.FileName));
                    }

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 👉 Thêm bàn vào danh sách đã thanh toán
                    dgv_HoaDon.DataSource = null;
                    dgv_HoaDon.Rows.Clear();
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    try
                    {
                        // Chuyển dữ liệu từ HoaDon sang DoanhThu
                        string sqlInsertDoanhThu = @"INSERT INTO DoanhThu (TenMon, Gia, SoLuong, TenBan, ThanhTien, NgayTao)
                                                     SELECT TenMon, Gia, SoLuong, TenBan, SoLuong * Gia, GETDATE()
        F                                            from HoaDon WHERE TenBan = @TenBan";

                        using (SqlCommand cmdInsert = new SqlCommand(sqlInsertDoanhThu, ketNoi))
                        {
                            cmdInsert.Parameters.AddWithValue("@TenBan", selectedTableName);
                            cmdInsert.ExecuteNonQuery();
                        }
                        string updateBanQuery = "UPDATE Ban SET TrangThai = 0 WHERE TenBan = @TenBan";
                        using (SqlCommand cmdUpdate = new SqlCommand(updateBanQuery, ketNoi))
                        {
                            cmdUpdate.Parameters.Add("@TenBan", SqlDbType.NVarChar).Value = selectedTableName;
                            int rowsAffected = cmdUpdate.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Không thể cập nhật trạng thái bàn. Kiểm tra lại tên bàn hoặc kết nối cơ sở dữ liệu.",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        // Xóa dữ liệu hóa đơn của bàn đã thanh toán
                        string deleteQuery = "DELETE FROM HoaDon WHERE TenBan = @TenBan";
                        using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, ketNoi))
                        {
                            cmdDelete.Parameters.AddWithValue("@TenBan", selectedTableName);
                            cmdDelete.ExecuteNonQuery();
                        }


                        // Thêm bàn vào danh sách đã thanh toán (nếu chưa có)
                        if (!banDaThanhToan.Contains(selectedTableName))
                        {
                            banDaThanhToan.Add(selectedTableName);
                        }

                        // Làm mới giao diện danh sách bàn
                        CreateButton();

                        // Thay đổi giao diện nếu cần chuyển sang UserControl mới
                        if (this.Parent is Panel parentPanel)
                        {
                            parentPanel.Controls.Clear();
                            var newUserControl = new UC_Bill();
                            parentPanel.Controls.Add(newUserControl);
                            newUserControl.Dock = DockStyle.Fill;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi trong quá trình xử lý thanh toán: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (ketNoi.State == ConnectionState.Open)
                        {
                            ketNoi.Close();
                        }
                    }
                }
            }
        }
    }
}
