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
    public partial class UC_Employee : UserControl
    {
        SqlConnection ketNoi;
        SqlCommand boLenh;
        DataSet duLieu;
        SqlDataAdapter docGhi;
        public UC_Employee()
        {
            InitializeComponent();
            ApplyModernBlueTheme();
            ketNoi = new SqlConnection();
            boLenh = new SqlCommand();
            docGhi = new SqlDataAdapter();
            duLieu = new DataSet();
        }

        private void load_Data()
        {
            string data = @"Select ID_NhanVien, nv.HoTenNV, nv.SoDienThoai, nv.DiaChi, cv.TenChucVu, nv.CaLam
                            from NhanVien nv 
                            join ChucVu cv on cv.ID_ChucVu = nv.ID_ChucVu";
            boLenh = new SqlCommand(data, ketNoi);
            docGhi = new SqlDataAdapter(boLenh);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            dgvNV.DataSource = duLieu.Tables[0];
        }


        private void ApplyModernBlueTheme()
        {
            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkBlue = Color.FromArgb(16, 42, 67);
            Color contentBg = Color.FromArgb(241, 245, 249);
            Color paleBlue = Color.FromArgb(239, 246, 255);
            Color dangerRed = Color.FromArgb(185, 28, 28);

            // Nền
            BackColor = contentBg;
            panel3.BackColor = contentBg;
            panel_Employee.BackColor = Color.White;

            // Nhóm thông tin
            groupBox1.BackColor = Color.White;
            groupBox2.BackColor = Color.White;

            groupBox1.ForeColor = primaryBlue;
            groupBox2.ForeColor = primaryBlue;

            groupBox1.Font = new Font(
                "Segoe UI", 10.5F, FontStyle.Bold);

            groupBox2.Font = new Font(
                "Segoe UI", 10.5F, FontStyle.Bold);

            // Nhãn
            Label[] labels =
            {
        label2, label4, label6,
        label3, label5, label8
    };

            foreach (Label label in labels)
            {
                label.ForeColor = darkBlue;
                label.Font = new Font("Segoe UI", 10F);
            }

            // Ô nhập
            TextBox[] textBoxes =
            {
        txtID_NV, txtSDT, txtDiaChi,
        txtHoTen, TxtCaLam, txtTimKiem
    };

            foreach (TextBox textbox in textBoxes)
            {
                textbox.BackColor = paleBlue;
                textbox.ForeColor = darkBlue;
                textbox.BorderStyle = BorderStyle.FixedSingle;
            }

            cbxTenCV.BackColor = paleBlue;
            cbxTenCV.ForeColor = darkBlue;

            // Nút chức năng
            Button[] buttons =
            {
        btnThem, btnSua, btnXoa, btnTimKiem
    };

            foreach (Button button in buttons)
            {
                button.BackColor = primaryBlue;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = brightBlue;
                button.FlatAppearance.MouseDownBackColor = darkBlue;
                button.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold);
                button.Cursor = Cursors.Hand;
                button.UseVisualStyleBackColor = false;
            }

            // Nút xóa
            btnXoa.BackColor = dangerRed;
            btnXoa.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(220, 38, 38);

            // Nút thoát
            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.ForeColor = darkBlue;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Text = "×";

            // Bảng nhân viên
            dgvNV.BackgroundColor = Color.White;
            dgvNV.BorderStyle = BorderStyle.None;
            dgvNV.EnableHeadersVisualStyles = false;

            dgvNV.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;
            dgvNV.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvNV.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvNV.DefaultCellStyle.ForeColor = darkBlue;
            dgvNV.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);
            dgvNV.DefaultCellStyle.SelectionForeColor = darkBlue;

            dgvNV.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);
        }


        private void load_CbxTenCV()
        {
            string data = "select * from ChucVu";
            docGhi = new SqlDataAdapter(data, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);
            cbxTenCV.DataSource = duLieu.Tables[0];

            cbxTenCV.DisplayMember = "TenChucVu";
            cbxTenCV.ValueMember = "TenChucVu";
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            load_Data();
            load_CbxTenCV();
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
                    string Them = (@"INSERT INTO NhanVien (ID_NhanVien, HoTenNV, SoDienThoai, DiaChi, ID_ChucVu, CaLam)
                                     SELECT @ID_NhanVien, @HoTenNV, @SoDienThoai, @DiaChi, ID_ChucVu, @CaLam
                                     FROM ChucVu
                                     WHERE TenChucVu = @TenChucVu");
                    boLenh = new SqlCommand(Them, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NhanVien", txtID_NV.Text);
                    boLenh.Parameters.AddWithValue("@HoTenNV", txtHoTen.Text);
                    boLenh.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    boLenh.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    boLenh.Parameters.AddWithValue("@TenChucVu", cbxTenCV.Text);
                    boLenh.Parameters.AddWithValue("@CaLam", TxtCaLam.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();

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
                    string sqlXoa = "Delete from NhanVien where ID_NhanVien = @ID_NhanVien";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NhanVien", txtID_NV.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();

                    }
                }
            }
            catch
            {
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Data();
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
                    string Sua = @"UPDATE NhanVien
                                   SET HoTenNV = @HoTenNV, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, 
                                   ID_ChucVu = (SELECT ID_ChucVu FROM ChucVu WHERE TenChucVu = @TenChucVu), CaLam =@CaLam
                                   WHERE ID_NhanVien = @ID_NhanVien";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    // Gán giá trị cho các tham số
                    boLenh.Parameters.AddWithValue("@ID_NhanVien", txtID_NV.Text);
                    boLenh.Parameters.AddWithValue("@HoTenNV", txtHoTen.Text);
                    boLenh.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    boLenh.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    boLenh.Parameters.AddWithValue("@TenChucVu", cbxTenCV.Text);
                    boLenh.Parameters.AddWithValue("@CaLam", TxtCaLam.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Data();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_Data();
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
                UC_Employee_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM NhanVien where HoTenNV like '%" + TK + "%'";
                docGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                dgvNV.DataSource = duLieu.Tables[0];
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TK = txtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Employee_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM NhanVien where HoTenNV like '%" + TK + "%'";
                docGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                dgvNV.DataSource = duLieu.Tables[0];
            }
        }

        private void dgvNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID_NV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtSDT.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtHoTen.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            cbxTenCV.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            TxtCaLam.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
