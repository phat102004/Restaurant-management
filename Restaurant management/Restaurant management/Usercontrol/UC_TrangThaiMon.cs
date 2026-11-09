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

            // ============================================
            // 2. NỀN USERCONTROL
            // ============================================

            BackColor = contentBg;

            // ============================================
            // 3. NHÓM THÔNG TIN TRẠNG THÁI MÓN
            // ============================================

            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = primaryBlue;
            groupBox1.Text = "  THÔNG TIN TRẠNG THÁI MÓN  ";

            groupBox1.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            // ============================================
            // 4. CÁC LABEL
            // ============================================

            Label[] labels =
            {
        label1,
        label2,
        label3,
        label6
    };

            foreach (Label label in labels)
            {
                label.BackColor = Color.White;
                label.ForeColor = darkBlue;

                label.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Regular);
            }

            // ============================================
            // 5. CÁC Ô NHẬP THÔNG TIN MÓN
            // ============================================

            TextBox[] textBoxes =
            {
        txtTT,
        txtSoLuong,
        txtTenMon,
        TxtTenBan
    };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.BackColor = paleBlue;
                textBox.ForeColor = darkBlue;
                textBox.BorderStyle = BorderStyle.FixedSingle;

                // Không thay đổi Location, Size hay ReadOnly.
            }

            // ============================================
            // 6. NÚT HOÀN THÀNH
            // ============================================

            BtnHoanThanh.BackColor = primaryBlue;
            BtnHoanThanh.ForeColor = Color.White;
            BtnHoanThanh.Cursor = Cursors.Hand;
            BtnHoanThanh.FlatStyle = FlatStyle.Flat;
            BtnHoanThanh.FlatAppearance.BorderSize = 0;

            BtnHoanThanh.FlatAppearance.MouseOverBackColor =
                brightBlue;

            BtnHoanThanh.FlatAppearance.MouseDownBackColor =
                darkBlue;

            BtnHoanThanh.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);

            BtnHoanThanh.UseVisualStyleBackColor = false;

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
            // 8. DATAGRIDVIEW TRẠNG THÁI MÓN
            // ============================================

            DgvTinhTrangMon.BackgroundColor = Color.White;
            DgvTinhTrangMon.BorderStyle = BorderStyle.None;
            DgvTinhTrangMon.GridColor = borderColor;

            // Cho phép hiển thị màu tiêu đề tùy chỉnh
            DgvTinhTrangMon.EnableHeadersVisualStyles = false;

            // Tiêu đề bảng
            DgvTinhTrangMon.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;

            DgvTinhTrangMon.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            DgvTinhTrangMon.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            DgvTinhTrangMon.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Nội dung bảng
            DgvTinhTrangMon.DefaultCellStyle.BackColor =
                Color.White;

            DgvTinhTrangMon.DefaultCellStyle.ForeColor =
                darkBlue;

            DgvTinhTrangMon.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            // Màu khi chọn dòng
            DgvTinhTrangMon.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            DgvTinhTrangMon.DefaultCellStyle.SelectionForeColor =
                darkBlue;

            // Các dòng xen kẽ
            DgvTinhTrangMon.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            // ============================================
            // 9. GIỮ NGUYÊN CHỨC NĂNG
            // ============================================

            // Không thay đổi:
            // - Size / Location / Dock / Anchor
            // - Tên control
            // - DataPropertyName của các cột
            // - BtnHoanThanh_Click
            // - btnThoat_Click
            // - DgvTinhTrangMon_CellContentClick
            // - UC_TrangThaiBan_Load
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
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
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
