using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_management.TenNV;
namespace Restaurant_management
{
    public partial class FornDangNhap : Form
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public string ChucVuNguoiDung { get; set; }
        public FornDangNhap()
        {
            boLenh = new SqlCommand();
            docGhi = new SqlDataAdapter();
            duLieu = new DataSet();
            ketNoi = new SqlConnection();
            InitializeComponent();
        }

        public static class Global
        {
            public static string CurrentUserName { get; set; } // Tên đăng nhập
            public static string CurrentEmployeeName { get; set; } // Tên đầy đủ của nhân viên
        }
        private void FornDangNhap_Load(object sender, EventArgs e)
        {
            string sql = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(sql);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

    if (ketNoi.State != ConnectionState.Open)
    {
        ketNoi.Open();
    }

    try
    {
        string query = @"SELECT qlq.TenNguoiDN, cv.TenChucVu
                         FROM QuanLyQuyen qlq
                         JOIN ChucVu cv ON qlq.ID_ChucVu = cv.ID_ChucVu
                         WHERE qlq.TenDangNhap = @tenDangNhap AND qlq.MatKhau = @matKhau";
                         
        using (SqlCommand boLenh = new SqlCommand(query, ketNoi))
        {
            boLenh.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
            boLenh.Parameters.AddWithValue("@matKhau", matKhau);

                    using (SqlDataReader reader = boLenh.ExecuteReader())
            {
                        if (reader.Read())
                        {
                            string tenNhanVien = reader["TenNguoiDN"].ToString(); // Lấy tên nhân viên từ database
                            string chucVu = reader["TenChucVu"].ToString();

                            GlobalData.CurrentEmployeeName = tenNhanVien; // Lưu tên nhân viên vào GlobalData
                            Global.CurrentUserName = tenDangNhap;

                            MessageBox.Show($"Đăng nhập thành công! Chức vụ: {chucVu}");
                            if (chucVu == "Quản lý")
                            {
                                FormAdmin formQL = new FormAdmin();
                                formQL.Show();
                            }
                            else if (chucVu == "Bếp trưởng")
                            {
                                FormBep formBep = new FormBep();
                                formBep.Show();
                            }
                            else if (chucVu == "Order")
                            {
                                FormOrder formOrder = new FormOrder();
                                formOrder.Show();
                            }
                            this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        if (ketNoi.State == ConnectionState.Open)
        {
            ketNoi.Close();
        }
    }
        }


        private void chkMatKhau_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
