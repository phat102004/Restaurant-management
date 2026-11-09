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
            ApplyModernBlueTheme();
        }


        private void ApplyModernBlueTheme()
        {
            // ============================================
            // 1. BẢNG MÀU MODERN BLUE
            // ============================================

            Color navy = Color.FromArgb(16, 42, 67);
            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkText = Color.FromArgb(51, 65, 85);
            Color paleBlue = Color.FromArgb(239, 246, 255);
            Color softGray = Color.FromArgb(226, 232, 240);

            // ============================================
            // 2. FORM ĐĂNG NHẬP
            // ============================================

            BackColor = Color.White;

            // Giữ nguyên:
            // ClientSize = 1030 x 621
            // FormBorderStyle = None
            // StartPosition = CenterScreen
            // AcceptButton = btnDangNhap

            // ============================================
            // 3. PANEL BÊN TRÁI
            // ============================================

            panel2.BackColor = navy;

            // ============================================
            // 4. LOGO NHÀ HÀNG
            // ============================================

            pictureBox1.BackColor = navy;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // Không sửa Image, Size hoặc Location
            // Logo vẫn lấy từ resources gốc.

            // ============================================
            // 5. TIÊU ĐỀ NHÀ HÀNG
            // ============================================

            label4.BackColor = navy;
            label4.ForeColor = Color.White;
            label4.Font = new Font(
                "Segoe UI", 18F, FontStyle.Bold);

            label4.Text = "QUẢN LÝ NHÀ HÀNG";

            // ============================================
            // 6. PANEL ĐĂNG NHẬP BÊN PHẢI
            // ============================================

            panel3.BackColor = Color.White;

            // ============================================
            // 7. GROUPBOX TÀI KHOẢN
            // ============================================

            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = primaryBlue;
            groupBox1.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            groupBox1.Text = "  THÔNG TIN ĐĂNG NHẬP  ";

            // ============================================
            // 8. CÁC LABEL
            // ============================================

            label1.ForeColor = darkText;
            label1.BackColor = Color.White;
            label1.Font = new Font(
                "Segoe UI", 10F, FontStyle.Regular);

            Tx.ForeColor = darkText;
            Tx.BackColor = Color.White;
            Tx.Font = new Font(
                "Segoe UI", 10F, FontStyle.Regular);

            // ============================================
            // 9. Ô TÊN ĐĂNG NHẬP
            // ============================================

            txtDangNhap.BackColor = paleBlue;
            txtDangNhap.ForeColor = navy;
            txtDangNhap.BorderStyle = BorderStyle.FixedSingle;

            // Giữ nguyên kích thước và vị trí của TextBox

            // ============================================
            // 10. Ô MẬT KHẨU
            // ============================================

            txtMatKhau.BackColor = paleBlue;
            txtMatKhau.ForeColor = navy;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;

            // Giữ nguyên PasswordChar = '*'
            // Không thay đổi chức năng nhập mật khẩu.

            // ============================================
            // 11. NÚT ĐĂNG NHẬP
            // ============================================

            btnDangNhap.BackColor = primaryBlue;
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Cursor = Cursors.Hand;

            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.FlatAppearance.BorderSize = 0;

            btnDangNhap.FlatAppearance.MouseOverBackColor =
                brightBlue;

            btnDangNhap.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(29, 78, 216);

            btnDangNhap.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            btnDangNhap.UseVisualStyleBackColor = false;

            // ============================================
            // 12. NÚT THOÁT
            // ============================================

            Btn_Thoat.BackColor = softGray;
            Btn_Thoat.ForeColor = darkText;
            Btn_Thoat.Cursor = Cursors.Hand;

            Btn_Thoat.FlatStyle = FlatStyle.Flat;
            Btn_Thoat.FlatAppearance.BorderSize = 0;

            Btn_Thoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(203, 213, 225);

            Btn_Thoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(148, 163, 184);

            Btn_Thoat.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            Btn_Thoat.UseVisualStyleBackColor = false;

            // ============================================
            // 13. GIỮ NGUYÊN LOGIC
            // ============================================

            // Không thay đổi:
            // - btnDangNhap_Click
            // - Btn_Thoat_Click
            // - FornDangNhap_Load
            // - PasswordChar
            // - AcceptButton
            // - Kết nối SQL Server
            // - Size, Location, Dock hoặc Anchor
        }


        public static class Global
        {
            public static string CurrentUserName { get; set; } // Tên đăng nhập
            public static string CurrentEmployeeName { get; set; } // Tên đầy đủ của nhân viên
        }
        private void FornDangNhap_Load(object sender, EventArgs e)
        {
            string sql = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
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
