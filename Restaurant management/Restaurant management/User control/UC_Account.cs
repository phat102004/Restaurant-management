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
using OfficeOpenXml.ConditionalFormatting.Contracts;
namespace Restaurant_management.User_control
{
    public partial class UC_Account : UserControl
    {
        SqlConnection ketNoi;
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        public UC_Account()
        {
            ketNoi = new SqlConnection();
            boLenh = new SqlCommand();
            duLieu = new DataSet();
            docGhi = new SqlDataAdapter();
            InitializeComponent();
        }
        private void LoadNV()
        {
            String SqlNV = "SELECT * FROM NhanVien";
            docGhi = new SqlDataAdapter(SqlNV, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            CbxTenNV.DataSource = duLieu.Tables[0];
            CbxTenNV.DisplayMember = "HoTenNV";
            CbxTenNV.ValueMember = "HoTenNV";

            CbxID_NV.DataSource = duLieu.Tables[0];
            CbxID_NV.DisplayMember = "ID_NhanVien";
            CbxID_NV.ValueMember = "ID_NhanVien";
        }


        private void LoadCV()
        {
            string SqlCV = "SELECT * FROM ChucVu";
            docGhi = new SqlDataAdapter(SqlCV, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            CbxChucVu.DataSource = duLieu.Tables[0];
            CbxChucVu.DisplayMember = "TenChucVu";
            CbxChucVu.ValueMember = "TenChucVu";
        }
        private void Load_Data()
        {
            string SqlAcc = @" SELECT NV.ID_NhanVien, QLQ.TenNguoiDN, QLQ.TenDangNhap, QLQ.MatKhau, 
                                      CV.TenChucVu
                                      FROM QuanLyQuyen QLQ
                                      INNER JOIN NhanVien NV ON QLQ.ID_NhanVien = NV.ID_NhanVien
                                      INNER JOIN ChucVu CV ON QLQ.ID_ChucVu = CV.ID_ChucVu";
            docGhi = new SqlDataAdapter(SqlAcc, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            DgvAccount.DataSource = duLieu.Tables[0];
        }
        private void UC_Account_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_Data();
            LoadCV();
            LoadNV();
        }

        private void BtnThem_Click(object sender, EventArgs e)
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
                    string Them = @"INSERT INTO QuanLyQuyen (ID_NhanVien, TenNguoiDN, TenDangNhap, MatKhau, ID_ChucVu)
                                        SELECT @ID_NhanVien, @TenNguoiDN, @TenDangNhap, @MatKhau, ID_ChucVu
                                        FROM ChucVu
                                        WHERE TenChucVu = @TenChucVu;";
                    boLenh = new SqlCommand(Them, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NhanVien", CbxID_NV.Text);
                    boLenh.Parameters.AddWithValue("@TenNguoiDN", CbxTenNV.Text);
                    boLenh.Parameters.AddWithValue("@TenDangNhap", TxtTenDN.Text);
                    boLenh.Parameters.AddWithValue("@MatKhau", TxtMatKhau.Text);
                    boLenh.Parameters.AddWithValue("@TenChucVu", CbxChucVu.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin nhân viên đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
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
                    string sqlXoa = "Delete from QuanLyQuyen where TenNguoiDN = @TenNguoiDN";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@TenNguoiDN", CbxTenNV.Text);
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

        private void BtnSua_Click(object sender, EventArgs e)
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
                    string Sua = @"UPDATE QuanLyQuyen
                                   SET TenDangNhap =@TenDangNhap, MatKhau= @MatKhau
                                   WHERE ID_NhanVien = @ID_NhanVien";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NhanVien", CbxID_NV.Text);
                    boLenh.Parameters.AddWithValue("@TenDangNhap", TxtTenDN.Text);
                    boLenh.Parameters.AddWithValue("@MatKhau", TxtMatKhau.Text);
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

        private void DgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CbxID_NV.Text = DgvAccount.CurrentRow.Cells[0].Value?.ToString();
            CbxTenNV.Text = DgvAccount.CurrentRow.Cells[1].Value?.ToString();
            TxtTenDN.Text = DgvAccount.CurrentRow.Cells[2].Value?.ToString();
            TxtMatKhau.Text = DgvAccount.CurrentRow.Cells[3].Value?.ToString();
            CbxChucVu.Text = DgvAccount.CurrentRow.Cells[4].Value?.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
