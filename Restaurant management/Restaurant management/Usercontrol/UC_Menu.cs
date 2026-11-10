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
            ApplyModernBlueTheme();
        }


        private void ApplyModernBlueTheme()
        {
            // ============================================
            // BẢNG MÀU MODERN BLUE
            // ============================================

            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkBlue = Color.FromArgb(16, 42, 67);
            Color contentBg = Color.FromArgb(241, 245, 249);
            Color paleBlue = Color.FromArgb(239, 246, 255);
            Color dangerRed = Color.FromArgb(185, 28, 28);
            Color borderColor = Color.FromArgb(203, 213, 225);

            // ============================================
            // NỀN USERCONTROL VÀ PANEL
            // ============================================

            BackColor = contentBg;

            panel1.BackColor = contentBg;
            panel3.BackColor = contentBg;

            // ============================================
            // CÁC NHÓM THÔNG TIN
            // ============================================

            GroupBox[] groups =
            {
        groupBox1,
        groupBox2,
        groupBox3
    };

            foreach (GroupBox group in groups)
            {
                group.BackColor = Color.White;
                group.ForeColor = primaryBlue;
                group.Font = new Font(
                    "Segoe UI", 10.5F, FontStyle.Bold);
            }

            groupBox1.Text = "  CHỨC NĂNG  ";
            groupBox2.Text = "  THÔNG TIN MÓN ĂN  ";
            groupBox3.Text = "  CHI TIẾT MÓN ĂN  ";

            // ============================================
            // LABELS
            // ============================================

            Label[] labels =
            {
        label2, label3, label4,
        label5, label8
    };

            foreach (Label label in labels)
            {
                label.ForeColor = darkBlue;
                label.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Regular);
            }

            // ============================================
            // TEXTBOX
            // ============================================

            TextBox[] textBoxes =
            {
        txtIdFood,
        txtTenMon,
        txtSoLuong,
        txtMoTa,
        txtGia,
        txtTimKiem
    };

            foreach (TextBox textbox in textBoxes)
            {
                textbox.BackColor = paleBlue;
                textbox.ForeColor = darkBlue;
                textbox.BorderStyle = BorderStyle.FixedSingle;
            }

            // ============================================
            // COMBOBOX DANH MỤC
            // ============================================

            cbxDanhMuc.BackColor = paleBlue;
            cbxDanhMuc.ForeColor = darkBlue;
            cbxDanhMuc.FlatStyle = FlatStyle.Flat;

            // ============================================
            // NÚT THÊM - SỬA - TÌM KIẾM
            // ============================================

            Button[] buttons =
            {
        btnThem,
        btnSua,
        btnTimKiem
    };

            foreach (Button button in buttons)
            {
                button.BackColor = primaryBlue;
                button.ForeColor = Color.White;
                button.Cursor = Cursors.Hand;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = brightBlue;
                button.FlatAppearance.MouseDownBackColor = darkBlue;
                button.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold);
                button.UseVisualStyleBackColor = false;
            }

            // ============================================
            // NÚT XÓA
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
            // NÚT THOÁT
            // ============================================

            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.ForeColor = darkBlue;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);
            btnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(249, 190, 190);
            btnThoat.Text = "×";

            // ============================================
            // BẢNG THỰC ĐƠN
            // ============================================

            dgvThucDon.BackgroundColor = Color.White;
            dgvThucDon.BorderStyle = BorderStyle.None;
            dgvThucDon.GridColor = borderColor;
            dgvThucDon.EnableHeadersVisualStyles = false;

            dgvThucDon.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;

            dgvThucDon.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvThucDon.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvThucDon.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvThucDon.DefaultCellStyle.BackColor = Color.White;
            dgvThucDon.DefaultCellStyle.ForeColor = darkBlue;
            dgvThucDon.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            dgvThucDon.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgvThucDon.DefaultCellStyle.SelectionForeColor =
                darkBlue;

            dgvThucDon.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvThucDon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
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
            cbxDanhMuc.DisplayMember = "TenLoai";
            cbxDanhMuc.ValueMember = "ID_LoaiMonAn";
        }


        private void load_Data()
        {
            string sqlData = @"
        SELECT
            td.ID_MonAn,
            td.TenMon,
            td.Gia,
            td.MoTa,
            td.SoLuong,
            td.ThanhTien,
            lma.TenLoai,
            td.ID_LoaiMonAn
        FROM ThucDon td
        LEFT JOIN LoaiMonAn lma
            ON td.ID_LoaiMonAn = lma.ID_LoaiMonAn";

            using (SqlDataAdapter adapter =
                new SqlDataAdapter(sqlData, ketNoi))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvThucDon.DataSource = dt;
            }

            if (dgvThucDon.Columns.Contains("TenLoai"))
            {
                dgvThucDon.Columns["TenLoai"].HeaderText =
                    "Loại món ăn";
            }

            if (dgvThucDon.Columns.Contains("ID_LoaiMonAn"))
            {
                dgvThucDon.Columns["ID_LoaiMonAn"].Visible =
                    false;
            }

            if (dgvThucDon.Columns.Contains("ThanhTien"))
            {
                dgvThucDon.Columns["ThanhTien"].Visible = false;
            }

            if (dgvThucDon.Columns.Contains("Gia"))
            {
                dgvThucDon.Columns["Gia"].DefaultCellStyle.Format =
                    "N0";
            }
        }


        private void UC_Menu_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            load_Data();
            load_DM();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvThucDon_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvThucDon.Rows[e.RowIndex];

            txtIdFood.Text =
                row.Cells["ID_MonAn"].Value?.ToString();

            txtTenMon.Text =
                row.Cells["TenMon"].Value?.ToString();

            txtGia.Text =
                row.Cells["Gia"].Value?.ToString();

            txtMoTa.Text =
                row.Cells["MoTa"].Value?.ToString();

            txtSoLuong.Text =
                row.Cells["SoLuong"].Value?.ToString();

            // Gán ID làm giá trị, ComboBox tự hiển thị tên
            object loaiMonID =
                row.Cells["ID_LoaiMonAn"].Value;

            if (loaiMonID != null &&
                loaiMonID != DBNull.Value)
            {
                cbxDanhMuc.SelectedValue =
                    loaiMonID.ToString();
            }
            else
            {
                cbxDanhMuc.SelectedIndex = -1;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu nhập
            string maMon = txtIdFood.Text.Trim();
            string tenMon = txtTenMon.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrWhiteSpace(maMon) ||
                string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã món ăn và tên món ăn.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra giá tiền
            if (!decimal.TryParse(txtGia.Text.Trim(), out decimal gia)
                || gia < 0)
            {
                MessageBox.Show(
                    "Giá món ăn không hợp lệ.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra số lượng
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên lớn hơn 0.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 4. Kiểm tra danh mục
            if (cbxDanhMuc.SelectedIndex < 0 ||
                cbxDanhMuc.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại món ăn.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string maLoaiMon =
                cbxDanhMuc.SelectedValue.ToString();

            // 5. Xác nhận thao tác
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thêm món ăn này?",
                "Xác nhận thêm món",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // 6. Thực hiện INSERT
            try
            {
                string sql = @"
            INSERT INTO ThucDon
            (
                ID_MonAn,
                TenMon,
                Gia,
                MoTa,
                SoLuong,
                ThanhTien,
                ID_LoaiMonAn
            )
            VALUES
            (
                @ID_MonAn,
                @TenMon,
                @Gia,
                @MoTa,
                @SoLuong,
                @ThanhTien,
                @ID_LoaiMonAn
            )";

                using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                {
                    cmd.Parameters.AddWithValue(
                        "@ID_MonAn", maMon);

                    cmd.Parameters.AddWithValue(
                        "@TenMon", tenMon);

                    cmd.Parameters.AddWithValue(
                        "@Gia", gia);

                    cmd.Parameters.AddWithValue(
                        "@MoTa", moTa);

                    cmd.Parameters.AddWithValue(
                        "@SoLuong", soLuong);

                    cmd.Parameters.AddWithValue(
                        "@ThanhTien", gia * soLuong);

                    cmd.Parameters.AddWithValue(
                        "@ID_LoaiMonAn", maLoaiMon);

                    if (ketNoi.State != ConnectionState.Open)
                        ketNoi.Open();

                    int ketQua = cmd.ExecuteNonQuery();

                    if (ketQua > 0)
                    {
                        MessageBox.Show(
                            "Thêm món ăn thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        load_Data();

                        // Làm sạch dữ liệu nhập
                        txtIdFood.Clear();
                        txtTenMon.Clear();
                        txtGia.Clear();
                        txtMoTa.Clear();
                        txtSoLuong.Clear();

                        cbxDanhMuc.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Lỗi SQL ({ex.Number}): {ex.Message}",
                    "Thêm món ăn thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                    ketNoi.Close();
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
            string maMon = txtIdFood.Text.Trim();
            string tenMon = txtTenMon.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrWhiteSpace(maMon) ||
                string.IsNullOrWhiteSpace(tenMon))
            {
                MessageBox.Show(
                    "Vui lòng chọn món ăn cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGia.Text.Trim(), out decimal gia)
                || gia < 0)
            {
                MessageBox.Show("Giá món ăn không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            if (cbxDanhMuc.SelectedIndex < 0 ||
                cbxDanhMuc.SelectedValue == null ||
                cbxDanhMuc.SelectedValue is DataRowView)
            {
                MessageBox.Show("Vui lòng chọn loại món ăn.");
                return;
            }

            string maLoaiMon = cbxDanhMuc.SelectedValue.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa món ăn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            string sql = @"
        UPDATE dbo.ThucDon
        SET TenMon = @TenMon,
            Gia = @Gia,
            MoTa = @MoTa,
            SoLuong = @SoLuong,
            ThanhTien = @ThanhTien,
            ID_LoaiMonAn = @ID_LoaiMonAn
        WHERE ID_MonAn = @ID_MonAn";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                {
                    cmd.Parameters.AddWithValue("@ID_MonAn", maMon);
                    cmd.Parameters.AddWithValue("@TenMon", tenMon);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@MoTa", moTa);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@ThanhTien", gia * soLuong);
                    cmd.Parameters.AddWithValue("@ID_LoaiMonAn", maLoaiMon);

                    if (ketNoi.State != ConnectionState.Open)
                        ketNoi.Open();

                    int soDong = cmd.ExecuteNonQuery();

                    if (soDong > 0)
                    {
                        MessageBox.Show(
                            "Sửa món ăn thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        load_Data();

                        txtIdFood.Clear();
                        txtTenMon.Clear();
                        txtGia.Clear();
                        txtMoTa.Clear();
                        txtSoLuong.Clear();

                        cbxDanhMuc.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy món ăn có mã " + maMon,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Lỗi SQL ({ex.Number}): {ex.Message}",
                    "Sửa món ăn thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi != null &&
                    ketNoi.State == ConnectionState.Open)
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
