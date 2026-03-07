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
namespace Restaurant_management.User_control
{
    public partial class UC_TrangThaiMon : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        SqlConnection ketNoi;
        DataSet duLieu;
        public UC_TrangThaiMon()
        {
            boLenh = new SqlCommand();
            docGhi = new SqlDataAdapter();
            ketNoi = new SqlConnection();
            duLieu = new DataSet();
            InitializeComponent();
        }

        private void LoadData()
        {
            string sqlTTM = ("SELECT MaTrangThai, TenMon, SoLuong, TenBan, TinhTrang FROM TrangThai");
            docGhi = new SqlDataAdapter(sqlTTM, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            DgvTinhTrangMon.DataSource = duLieu.Tables[0];
        }

        private void DgvTinhTrangMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTT.Text = DgvTinhTrangMon.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = DgvTinhTrangMon.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = DgvTinhTrangMon.CurrentRow.Cells[2].Value.ToString();
            TxtTenBan.Text = DgvTinhTrangMon.CurrentRow.Cells[3].Value.ToString();
        }

        private void UC_TrangThaiBan_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            LoadData();
        }

        private void Re_Load()
        {
            txtTenMon.Clear();
            txtSoLuong.Clear();
            txtTT.Clear();
            TxtTenBan.Clear();
        }
        private void BtnHoanThanh_Click(object sender, EventArgs e)
        {
            if (DgvTinhTrangMon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để hoàn thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị của cột MaTrangThai từ DataGridView
            DataGridViewRow selectedRow = DgvTinhTrangMon.CurrentRow;
            if (selectedRow.Cells["MaTrangThai"].Value == null || !int.TryParse(selectedRow.Cells["MaTrangThai"].Value.ToString(), out int maTrangThai))
            {
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenMon = selectedRow.Cells["TenMon"].Value?.ToString() ?? string.Empty;

            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }

                // Xóa theo MaTrangThai để đảm bảo chỉ xóa đúng bản ghi được chọn
                string sqlXoa = @"DELETE FROM TrangThai WHERE MaTrangThai = @MaTrangThai";
                using (SqlCommand command = new SqlCommand(sqlXoa, ketNoi))
                {
                    command.Parameters.AddWithValue("@MaTrangThai", maTrangThai);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Xóa dòng tương ứng trên DataGridView
                        DgvTinhTrangMon.Rows.Remove(selectedRow);

                        MessageBox.Show($"Món ăn '{tenMon}' đã được giao thành công và xóa khỏi danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Re_Load();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
