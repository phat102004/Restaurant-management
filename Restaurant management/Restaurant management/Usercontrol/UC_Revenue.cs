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
using ClosedXML.Excel;
namespace Restaurant_management.User_control

{
    public partial class UC_Revenue : UserControl
    {
        SqlCommand boLenh;
        SqlConnection ketNoi;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        public UC_Revenue()
        {
            boLenh = new SqlCommand();
            ketNoi = new SqlConnection();
            duLieu = new DataSet();
            docGhi = new SqlDataAdapter();
            InitializeComponent();
            ApplyModernBlueTheme();
        }


        private void ApplyModernBlueTheme()
        {
            // ============================================
            // BẢNG MÀU MODERN BLUE
            // ============================================

            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkBlue = Color.FromArgb(16, 42, 67);
            Color contentBg = Color.FromArgb(241, 245, 249);
            Color paleBlue = Color.FromArgb(239, 246, 255);
            Color borderColor = Color.FromArgb(203, 213, 225);

            // ============================================
            // NỀN USERCONTROL
            // ============================================

            BackColor = contentBg;

            panel1.BackColor = contentBg;
            panel2.BackColor = Color.White;

            // ============================================
            // NHÓM LỌC THEO NGÀY
            // ============================================

            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = primaryBlue;
            groupBox1.Font = new Font(
                "Segoe UI", 10.5F, FontStyle.Bold);
            groupBox1.Text = "  TỪ NGÀY  ";

            groupBox2.BackColor = Color.White;
            groupBox2.ForeColor = primaryBlue;
            groupBox2.Font = new Font(
                "Segoe UI", 10.5F, FontStyle.Bold);
            groupBox2.Text = "  ĐẾN NGÀY  ";

            // ============================================
            // DATE TIME PICKER
            // ============================================

            dateTimePickerfrom.CalendarMonthBackground = Color.White;
            dateTimePickerfrom.CalendarForeColor = darkBlue;
            dateTimePickerfrom.CalendarTitleBackColor = primaryBlue;
            dateTimePickerfrom.CalendarTitleForeColor = Color.White;
            dateTimePickerfrom.Font = new Font("Segoe UI", 10F);
            dateTimePickerfrom.Format = DateTimePickerFormat.Short;

            dateTimePickerto.CalendarMonthBackground = Color.White;
            dateTimePickerto.CalendarForeColor = darkBlue;
            dateTimePickerto.CalendarTitleBackColor = primaryBlue;
            dateTimePickerto.CalendarTitleForeColor = Color.White;
            dateTimePickerto.Font = new Font("Segoe UI", 10F);
            dateTimePickerto.Format = DateTimePickerFormat.Short;

            // ============================================
            // LABEL ĐẾN
            // ============================================

            label1.ForeColor = primaryBlue;
            label1.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);

            // ============================================
            // NÚT CẬP NHẬT
            // ============================================

            BtnCapNhat.BackColor = primaryBlue;
            BtnCapNhat.ForeColor = Color.White;
            BtnCapNhat.Cursor = Cursors.Hand;
            BtnCapNhat.FlatStyle = FlatStyle.Flat;
            BtnCapNhat.FlatAppearance.BorderSize = 0;
            BtnCapNhat.FlatAppearance.MouseOverBackColor = brightBlue;
            BtnCapNhat.FlatAppearance.MouseDownBackColor = darkBlue;
            BtnCapNhat.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            BtnCapNhat.UseVisualStyleBackColor = false;

            // ============================================
            // NÚT XUẤT EXCEL
            // ============================================

            BtnXuaEC.BackColor = Color.FromArgb(29, 78, 216);
            BtnXuaEC.ForeColor = Color.White;
            BtnXuaEC.Cursor = Cursors.Hand;
            BtnXuaEC.FlatStyle = FlatStyle.Flat;
            BtnXuaEC.FlatAppearance.BorderSize = 0;
            BtnXuaEC.FlatAppearance.MouseOverBackColor = brightBlue;
            BtnXuaEC.FlatAppearance.MouseDownBackColor = darkBlue;
            BtnXuaEC.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            BtnXuaEC.UseVisualStyleBackColor = false;

            // ============================================
            // NÚT THOÁT
            // ============================================

            BtnThoat.BackColor = Color.FromArgb(226, 232, 240);
            BtnThoat.ForeColor = darkBlue;
            BtnThoat.Cursor = Cursors.Hand;
            BtnThoat.FlatStyle = FlatStyle.Flat;
            BtnThoat.FlatAppearance.BorderSize = 0;
            BtnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);
            BtnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(249, 190, 190);
            BtnThoat.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            BtnThoat.Text = "×";
            BtnThoat.UseVisualStyleBackColor = false;

            // ============================================
            // BẢNG THỐNG KÊ DOANH THU
            // ============================================

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = borderColor;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Tiêu đề bảng
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Nội dung bảng
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = darkBlue;
            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            // Dòng đang được chọn
            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                darkBlue;

            // Xen kẽ màu dòng
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            // Giữ nguyên các cột và cách chọn dòng
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }


        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                string query = @"SELECT TenBan, CAST(NgayTao AS DATE) AS NgayTao, SUM(ThanhTien) AS ThanhTien
                                 FROM DoanhThu 
                                 WHERE NgayTao BETWEEN @NgayBatDau AND @NgayKetThuc
                                 GROUP BY TenBan, CAST(NgayTao AS DATE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NgayBatDau", dateTimePickerfrom.Value.Date);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", dateTimePickerto.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnXuaEC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
                {
                    MessageBox.Show("Không có dữ liệu doanh thu để xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fileName = $"DoanhThu_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = fileName
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook workbook = new XLWorkbook()) // Đã thêm thư viện ClosedXML
                            {
                                DataTable dt = new DataTable();

                                // Thêm cột vào DataTable
                                foreach (DataGridViewColumn column in dataGridView1.Columns)
                                {
                                    dt.Columns.Add(column.HeaderText);
                                }

                                // Thêm dòng vào DataTable
                                decimal totalAmount = 0;
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        DataRow dataRow = dt.NewRow();
                                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                        {
                                            string cellValue = row.Cells[j].Value?.ToString().Trim();
                                            dataRow[j] = cellValue;

                                            // Tính tổng tiền
                                            if (dataGridView1.Columns[j].HeaderText.Contains("Thành tiền")) // Xác định cột "Thành tiền"
                                            {
                                                string cleanedValue = cellValue?.Replace(",", "").Replace(".", "").Trim();
                                                if (decimal.TryParse(cleanedValue, out decimal value))
                                                {
                                                    totalAmount += value;
                                                }
                                            }
                                        }
                                        dt.Rows.Add(dataRow);
                                    }
                                }

                                // Thêm dòng tổng tiền vào cuối bảng
                                DataRow totalRow = dt.NewRow();
                                totalRow[0] = "Tổng cộng:"; // Cột đầu tiên
                                totalRow[dt.Columns.Count - 1] = totalAmount.ToString("N0") + " VNĐ"; // Cột cuối cùng (Thành tiền)
                                dt.Rows.Add(totalRow);

                                // Xuất DataTable ra Excel
                                var worksheet = workbook.Worksheets.Add(dt, "DoanhThu");

                                // Định dạng dòng tổng cộng
                                int totalRowIndex = dt.Rows.Count; // Dòng cuối cùng
                                worksheet.Row(totalRowIndex + 1).Style.Font.Bold = true;
                                worksheet.Row(totalRowIndex + 1).Style.Font.FontColor = XLColor.Red;

                                // Lưu file Excel
                                workbook.SaveAs(sfd.FileName);
                            }

                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
