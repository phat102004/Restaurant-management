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
        }

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True"))
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
