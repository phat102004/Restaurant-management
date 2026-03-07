using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Restaurant_management.User_control
{
    public partial class UC_Chef : UserControl
    {
        SqlConnection ketNoi;
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        public UC_Chef()
        {
            InitializeComponent();
            ketNoi = new SqlConnection();
            boLenh = new SqlCommand();
            docGhi = new SqlDataAdapter();
            duLieu = new DataSet();
        }

        private void load_Data()
        {
            string sql = @"SELECT TenMon, SoLuong, TenBan FROM HoaDonTam";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            dgvChef.DataSource = duLieu.Tables[0];
        }

        private void UC_Chef_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            load_Data();
        }

        private void dgvChef_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenMon.Text = dgvChef.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvChef.CurrentRow.Cells[1].Value.ToString();
            txtTenBan.Text = dgvChef.CurrentRow.Cells[2].Value.ToString();
        }



        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dgvChef.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataGridViewRow Row = dgvChef.SelectedRows[0];

                string tenMon = Row.Cells["TenMon"].Value?.ToString() ?? "";
                int soLuong = Convert.ToInt32(Row.Cells["SoLuong"].Value ?? 0);
                string tenBan = Row.Cells["TenBan"].Value?.ToString() ?? "";

                DialogResult result = MessageBox.Show($"Bạn có chắc muốn hoàn thành món ăn '{tenMon}' tại bàn '{tenBan}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string queryUpdateTinhTrang = @"UPDATE TrangThai 
                                                SET TinhTrang = 'Hoàn thành' 
                                                WHERE TenMon = @TenMon AND TenBan = @TenBan";

                        using (SqlCommand cmd = new SqlCommand(queryUpdateTinhTrang, ketNoi))
                        {
                            if (ketNoi.State != ConnectionState.Open)
                            {
                                ketNoi.Open();
                            }
                            cmd.Parameters.AddWithValue("@TenMon", tenMon);
                            cmd.Parameters.AddWithValue("@TenBan", tenBan);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Món ăn '{tenMon}' tại bàn '{tenBan}' đã được hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvChef.Rows.RemoveAt(Row.Index);
                        txtTenMon.Clear();
                        txtSoLuong.Clear();
                        txtTenBan.Clear();
                        string query = "DELETE FROM HoaDonTam WHERE TenMon = @TenMon AND TenBan = @TenBan";
                        SqlCommand command = new SqlCommand(query, ketNoi);
                        command.Parameters.AddWithValue("@TenMon", tenMon);
                        command.Parameters.AddWithValue("@TenBan", tenBan);
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật trạng thái món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thao tác hoàn thành món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
