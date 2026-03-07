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
    public partial class UC_Table : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public UC_Table()
        {
            InitializeComponent();
            ketNoi = new SqlConnection();
            boLenh = new SqlCommand();
            docGhi = new SqlDataAdapter();
            duLieu = new DataSet();
        }
        private void Load_Data()
        {
            string sql = "SELECT * FROM Ban";
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            dgvBan.DataSource = duLieu.Tables[0];
        }


        private void UC_Table_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
        }



        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBan.Text = dgvBan.CurrentRow.Cells[0].Value.ToString();
            txtTenBan.Text = dgvBan.CurrentRow.Cells[1].Value.ToString();
            txtTrangThai.Text = dgvBan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    string Them = string.Format("insert into Ban values ('{0}',N'{1}','{2}')", txtIDBan.Text, txtTenBan.Text, txtTrangThai.Text);
                    boLenh = new SqlCommand(Them, ketNoi);
                    int kq = boLenh.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    string sqlXoa = "Delete from Ban where ID_Ban = @ID_Ban";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_Ban", txtIDBan.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                    }
                }
            }
            catch
            {
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    if (ketNoi.State != ConnectionState.Open)
                    {
                        ketNoi.Open();
                    }
                    string Sua = "update Ban set TenBan =@TenBan, TrangThai = @TrangThai where ID_Ban = @ID_Ban";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_Ban", txtIDBan.Text);
                    boLenh.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                    boLenh.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TK = txtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Table_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM Ban where TenMon like '%" + TK + "%'";
                docGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                dgvBan.DataSource = duLieu.Tables[0];
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
