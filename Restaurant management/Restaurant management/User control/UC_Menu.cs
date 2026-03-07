using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Restaurant_management.User_control
{
    public partial class UC_Menu : UserControl
    {
        SqlCommand boLenh;

        DataSet duLieu;

        DataAdapter boDocGhi;

        SqlConnection ketNoi;
        public UC_Menu()
        {
            boLenh = new SqlCommand();
            duLieu = new DataSet();
            boDocGhi = new SqlDataAdapter();
            ketNoi = new SqlConnection();
            InitializeComponent();
        }

        private void load_DM()
        {
            string sqlDM = "select * from LoaiMonAn";
            if (ketNoi.State != ConnectionState.Open)
            {
                ketNoi.Open();
            }
            boDocGhi = new SqlDataAdapter(sqlDM, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxDanhMuc.DataSource = duLieu.Tables[0];
            cbxDanhMuc.DisplayMember = "ID_LoaiMonAn";
            cbxDanhMuc.ValueMember = "ID_LoaiMonAn";
        }

        private void load_Data()
        {
            string sqlData = ("Select * from ThucDon");
            boDocGhi = new SqlDataAdapter(sqlData, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            dgvThucDon.DataSource = duLieu.Tables[0];
            dgvThucDon.Columns["ThanhTien"].Visible = false;
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            load_Data();
            load_DM();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvThucDon.Columns["ThanhTien"].Visible = false;
            txtIdFood.Text = dgvThucDon.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgvThucDon.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dgvThucDon.CurrentRow.Cells[2].Value.ToString();
            txtMoTa.Text = dgvThucDon.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = dgvThucDon.CurrentRow.Cells[4].Value.ToString();
            cbxDanhMuc.Text = dgvThucDon.CurrentRow.Cells[6].Value.ToString();
        }


        private void label6_Click(object sender, EventArgs e)
        {

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
                    string Them = string.Format("insert into ThucDon values (N'{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}')", txtIdFood.Text, txtTenMon.Text, txtGia.Text, txtMoTa.Text, txtSoLuong.Text, txtSoLuong.Text, cbxDanhMuc.Text);
                    boLenh = new SqlCommand(Them, ketNoi);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();
                        txtIdFood.Text = null;
                        txtTenMon.Text = null;
                        txtGia.Text = null;
                        txtMoTa.Text = null;
                        txtSoLuong.Text = null;
                        cbxDanhMuc.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sqlXoa = "Delete from ThucDon where ID_MonAn = @ID_MonAn";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_MonAn", txtIdFood.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();
                        txtIdFood.Text = null;
                        txtTenMon.Text = null;
                        txtGia.Text = null;
                        txtMoTa.Text = null;
                        txtSoLuong.Text = null;
                        cbxDanhMuc.Text = null;
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
                    string Sua = "update ThucDon set TenMon =@TenMon, Gia = @Gia, MoTa = @MoTa, SoLuong = @SoLuong, ID_LoaiMonAn=@ID_LoaiMonAn where ID_MonAn = @ID_MonAn";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_MonAn", txtIdFood.Text);
                    boLenh.Parameters.AddWithValue("@TenMon", txtTenMon.Text);
                    boLenh.Parameters.AddWithValue("@Gia", txtGia.Text);
                    boLenh.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                    boLenh.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    boLenh.Parameters.AddWithValue("@ID_LoaiMonAn", cbxDanhMuc.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();
                        txtIdFood.Text = null;
                        txtTenMon.Text = null;
                        txtGia.Text = null;
                        txtMoTa.Text = null;
                        txtSoLuong.Text = null;
                        cbxDanhMuc.Text = null;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string TK = txtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Menu_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM ThucDon where TenMon like '%" + TK + "%'";
                boDocGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                boDocGhi.Fill(duLieu);
                dgvThucDon.DataSource = duLieu.Tables[0];
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TK = txtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Menu_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM ThucDon where TenMon like '%" + TK + "%'";
                boDocGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                boDocGhi.Fill(duLieu);
                dgvThucDon.DataSource = duLieu.Tables[0];
            }
        }
    }
}
