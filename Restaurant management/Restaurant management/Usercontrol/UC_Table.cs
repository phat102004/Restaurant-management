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
            ApplyModernBlueTheme();
        }


        private void ApplyModernBlueTheme()
        {
            // ============================================
            // 1. BẢNG MÀU MODERN BLUE
            // ============================================

            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkBlue = Color.FromArgb(16, 42, 67);
            Color contentBg = Color.FromArgb(241, 245, 249);
            Color paleBlue = Color.FromArgb(239, 246, 255);
            Color borderColor = Color.FromArgb(203, 213, 225);
            Color dangerRed = Color.FromArgb(185, 28, 28);

            // ============================================
            // 2. NỀN USERCONTROL VÀ PANEL
            // ============================================

            BackColor = contentBg;

            panel3.BackColor = contentBg;
            panel1.BackColor = Color.White;

            // Chỉ đổi màu thanh phân cách
            splitter1.BackColor = borderColor;

            // ============================================
            // 3. NHÃN THÔNG TIN BÀN
            // ============================================

            Label[] labels =
            {
        label2,
        label3,
        label4
    };

            foreach (Label label in labels)
            {
                label.ForeColor = darkBlue;
                label.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Regular);
            }

            // ============================================
            // 4. Ô NHẬP THÔNG TIN BÀN
            // ============================================

            TextBox[] textBoxes =
            {
        txtIDBan,
        txtTenBan,
        txtTrangThai
    };

            foreach (TextBox textbox in textBoxes)
            {
                textbox.BackColor = paleBlue;
                textbox.ForeColor = darkBlue;
                textbox.BorderStyle = BorderStyle.FixedSingle;
            }

            // Giữ nguyên trạng thái chỉ đọc
            txtTrangThai.ReadOnly = true;

            // Không thay đổi giá trị " 0" ban đầu
            // Không thay đổi các sự kiện TextChanged

            // ============================================
            // 5. NÚT THÊM VÀ SỬA
            // ============================================

            Button[] actionButtons =
            {
        btnThem,
        btnSua,
    };

            foreach (Button button in actionButtons)
            {
                button.BackColor = primaryBlue;
                button.ForeColor = Color.White;
                button.Cursor = Cursors.Hand;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                button.FlatAppearance.MouseOverBackColor =
                    brightBlue;

                button.FlatAppearance.MouseDownBackColor =
                    darkBlue;

                button.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold);

                button.UseVisualStyleBackColor = false;
            }

            // ============================================
            // 6. NÚT XÓA - MÀU ĐỎ
            // ============================================

            btnXoa.BackColor = dangerRed;
            btnXoa.ForeColor = Color.White;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;

            btnXoa.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(220, 38, 38);

            btnXoa.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(153, 27, 27);

            btnXoa.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            btnXoa.UseVisualStyleBackColor = false;

            // ============================================
            // 7. NÚT THOÁT
            // ============================================

            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.ForeColor = darkBlue;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;

            btnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);

            btnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(249, 190, 190);

            btnThoat.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);

            btnThoat.Text = "×";
            btnThoat.UseVisualStyleBackColor = false;

            // ============================================
            // 8. DATAGRIDVIEW DANH SÁCH BÀN
            // ============================================

            dgvBan.BackgroundColor = Color.White;
            dgvBan.BorderStyle = BorderStyle.None;
            dgvBan.GridColor = borderColor;

            // Bật màu header tùy chỉnh
            dgvBan.EnableHeadersVisualStyles = false;

            dgvBan.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;

            dgvBan.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvBan.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvBan.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Nội dung các dòng
            dgvBan.DefaultCellStyle.BackColor = Color.White;
            dgvBan.DefaultCellStyle.ForeColor = darkBlue;

            dgvBan.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            // Màu khi chọn dòng
            dgvBan.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgvBan.DefaultCellStyle.SelectionForeColor =
                darkBlue;

            // Dòng xen kẽ
            dgvBan.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            // Giữ nguyên chọn cả dòng
            dgvBan.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // ============================================
            // KHÔNG THAY ĐỔI:
            // - Size / Location / Dock / Anchor
            // - Tên các control
            // - Event Click / TextChanged / Load
            // - Trạng thái ReadOnly của txtTrangThai
            // - Dữ liệu và cấu trúc các cột dgvBan
            // ============================================
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
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
