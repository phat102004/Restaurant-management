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
using System.Configuration;
using System.Data.Common;
namespace Restaurant_management.User_control
{
    public partial class UC_Order : UserControl
    {
        SqlCommand boLenh;
        DataSet duLieu;
        SqlDataAdapter boDocGhi;
        SqlConnection ketNoi;
        public UC_Order()
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
            Color borderColor = Color.FromArgb(203, 213, 225);

            // ============================================
            // NỀN USERCONTROL VÀ PANEL
            // ============================================

            BackColor = contentBg;

            panel5.BackColor = contentBg;
            panel6.BackColor = Color.White;
            panel_UC_Order.BackColor = contentBg;
            panel2.BackColor = contentBg;

            // Giữ nguyên splitter, chỉ đổi màu
            splitter1.BackColor = borderColor;

            // ============================================
            // NHÓM THÔNG TIN ĐẶT MÓN
            // ============================================

            groupBox1.BackColor = Color.White;
            groupBox1.ForeColor = primaryBlue;
            groupBox1.Text = "  THÔNG TIN ĐẶT MÓN  ";
            groupBox1.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            // ============================================
            // NHÓM CHỨC NĂNG
            // ============================================

            groupBox2.BackColor = Color.White;
            groupBox2.ForeColor = primaryBlue;
            groupBox2.Text = "  XỬ LÝ ĐƠN HÀNG  ";
            groupBox2.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            // ============================================
            // LABELS
            // ============================================

            Label[] labels =
            {
        label3,
        label4,
        label5,
        label6
    };

            foreach (Label label in labels)
            {
                label.BackColor = Color.White;
                label.ForeColor = darkBlue;
                label.Font = new Font(
                    "Segoe UI", 9F, FontStyle.Regular);
            }

            // ============================================
            // COMBOBOX
            // ============================================

            ComboBox[] comboBoxes =
            {
        cbxTenMon,
        cbxTenBan,
        cbxTenLoai
    };

            foreach (ComboBox combo in comboBoxes)
            {
                combo.BackColor = paleBlue;
                combo.ForeColor = darkBlue;
                combo.FlatStyle = FlatStyle.Flat;

                // Không thay đổi Location hoặc Size
            }

            // ============================================
            // SỐ LƯỢNG
            // ============================================

            txtSoLuong.BackColor = paleBlue;
            txtSoLuong.ForeColor = darkBlue;
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;

            // ============================================
            // NÚT THÊM MÓN
            // ============================================

            BtnThemMon.BackColor = primaryBlue;
            BtnThemMon.ForeColor = Color.White;
            BtnThemMon.Cursor = Cursors.Hand;
            BtnThemMon.FlatStyle = FlatStyle.Flat;
            BtnThemMon.FlatAppearance.BorderSize = 0;
            BtnThemMon.FlatAppearance.MouseOverBackColor = brightBlue;
            BtnThemMon.FlatAppearance.MouseDownBackColor = darkBlue;
            BtnThemMon.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            BtnThemMon.UseVisualStyleBackColor = false;

            // ============================================
            // NÚT BÁO CHẾ BIẾN
            // ============================================

            BtnCheBien.BackColor = Color.FromArgb(29, 78, 216);
            BtnCheBien.ForeColor = Color.White;
            BtnCheBien.Cursor = Cursors.Hand;
            BtnCheBien.FlatStyle = FlatStyle.Flat;
            BtnCheBien.FlatAppearance.BorderSize = 0;
            BtnCheBien.FlatAppearance.MouseOverBackColor = brightBlue;
            BtnCheBien.FlatAppearance.MouseDownBackColor = darkBlue;
            BtnCheBien.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            BtnCheBien.UseVisualStyleBackColor = false;

            // ============================================
            // NÚT THOÁT
            // ============================================

            BtnThoat.BackColor = Color.FromArgb(226, 232, 240);
            BtnThoat.ForeColor = darkBlue;
            BtnThoat.Cursor = Cursors.Hand;
            BtnThoat.FlatStyle = FlatStyle.Flat;
            BtnThoat.FlatAppearance.BorderSize = 0;
            BtnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);
            BtnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(249, 190, 190);
            BtnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnThoat.Text = "×";
            BtnThoat.UseVisualStyleBackColor = false;

            // ============================================
            // BẢNG DANH SÁCH MÓN ĐÃ ĐẶT
            // ============================================

            Dgv_Oder.BackgroundColor = Color.White;
            Dgv_Oder.BorderStyle = BorderStyle.None;
            Dgv_Oder.GridColor = borderColor;

            Dgv_Oder.EnableHeadersVisualStyles = false;

            Dgv_Oder.ColumnHeadersDefaultCellStyle.BackColor =
                primaryBlue;

            Dgv_Oder.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            Dgv_Oder.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            Dgv_Oder.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            Dgv_Oder.DefaultCellStyle.BackColor = Color.White;
            Dgv_Oder.DefaultCellStyle.ForeColor = darkBlue;
            Dgv_Oder.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);

            Dgv_Oder.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            Dgv_Oder.DefaultCellStyle.SelectionForeColor =
                darkBlue;

            Dgv_Oder.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            Dgv_Oder.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Giữ nguyên:
            // - AllowUserToAddRows = false
            // - RowHeadersVisible = false
            // - Các cột TenMon, SoLuong, TenBan
            // - Các DataPropertyName
            // - Các sự kiện Click / Load
            // - Toàn bộ kích thước và vị trí
        }


        private void Load_Ban()
        {
            string sqlBan = "select * from Ban";
            boDocGhi = new SqlDataAdapter(sqlBan, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenBan.DataSource = duLieu.Tables[0];

            cbxTenBan.DisplayMember = "TenBan";
            cbxTenBan.ValueMember = "TenBan";
        }

        private void Load_LoaiMonAn()
        {
            string sqlLoaiMA = ("SELECT * FROM LoaiMonAn");
            boDocGhi = new SqlDataAdapter(sqlLoaiMA, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenLoai.DataSource = duLieu.Tables[0];
            cbxTenLoai.DisplayMember = "TenLoai";
            cbxTenLoai.ValueMember = "TenLoai";
            cbxTenMon.Enabled = true;
        }

        private void Load_TenMonTM()
        {
            string sqlKV = ("Select TenMon from ThucDon where ID_LoaiMonAn = 'L03'");

            if (ketNoi.State != ConnectionState.Open)
            {
                ketNoi.Open();
            }
            boDocGhi = new SqlDataAdapter(sqlKV, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenMon.DataSource = duLieu.Tables[0];
            cbxTenMon.DisplayMember = "TenMon";
            cbxTenMon.ValueMember = "TenMon";
            cbxTenMon.Enabled = true;
        }


        private void Load_TenMonNuoc()
        {
            string sqlKV = ("Select TenMon from ThucDon where ID_LoaiMonAn = 'L04'");

            if (ketNoi.State != ConnectionState.Open)
            {
                ketNoi.Open();
            }
            boDocGhi = new SqlDataAdapter(sqlKV, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenMon.DataSource = duLieu.Tables[0];
            cbxTenMon.DisplayMember = "TenMon";
            cbxTenMon.ValueMember = "TenMon";
            cbxTenMon.Enabled = true;
        }
        private void Load_TenMonKV()
        {
            string sqlKV = ("Select TenMon from ThucDon where ID_LoaiMonAn = 'L01'");
            if (ketNoi.State != ConnectionState.Open)
            {
                ketNoi.Open();
            }
            boDocGhi = new SqlDataAdapter(sqlKV, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenMon.DataSource = duLieu.Tables[0];
            cbxTenMon.DisplayMember = "TenMon";
            cbxTenMon.ValueMember = "TenMon";
            cbxTenMon.Enabled = true;
        }
        private void Load_TenMonChinh()
        {
            string sqlKV = ("Select TenMon from ThucDon where ID_LoaiMonAn = 'L02'");

            if (ketNoi.State != ConnectionState.Open)
            {
                ketNoi.Open();
            }
            boDocGhi = new SqlDataAdapter(sqlKV, ketNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);
            cbxTenMon.DataSource = duLieu.Tables[0];
            cbxTenMon.DisplayMember = "TenMon";
            cbxTenMon.ValueMember = "TenMon";
            cbxTenMon.Enabled = true;
        }

        private void Dgv_Oder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxTenMon.Text = Dgv_Oder.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = Dgv_Oder.CurrentRow.Cells[1].Value.ToString();
            cbxTenBan.Text = Dgv_Oder.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnThemMon_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    string tenMon = cbxTenMon.Text;
                    int soLuong = int.Parse(txtSoLuong.Text);
                    string tenBan = cbxTenBan.Text;
                    DataGridViewRow? rowToUpdate = null;
                    foreach (DataGridViewRow row in Dgv_Oder.Rows)
                    {
                        if (row.Cells["TenMon"].Value != null && row.Cells["TenMon"].Value.ToString() == tenMon)
                        {
                            rowToUpdate = row;
                        }
                    }

                    if (rowToUpdate != null)
                    {
                        int soLuongHienTai = Convert.ToInt32(rowToUpdate.Cells["SoLuong"].Value);
                        rowToUpdate.Cells["SoLuong"].Value = soLuongHienTai + soLuong;
                    }
                    else
                    {
                        Dgv_Oder.Rows.Add(tenMon, soLuong, tenBan);
                    }

                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm món: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CbxTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoai = cbxTenLoai.Text;
            if (tenLoai == "Món chính")
            {
                Load_TenMonChinh();
            }
            if (tenLoai == "Khai vị")
            {
                Load_TenMonKV();
            }
            if (tenLoai == "Tráng miệng")
            {
                Load_TenMonTM();
            }
            if (tenLoai == "Món nước")
            {
                Load_TenMonNuoc();
            }
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(chuoiKN);
            Load_LoaiMonAn();
            Load_Ban();
        }

        private void BtnCheBien_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ketNoi.State != ConnectionState.Open)
                {
                    ketNoi.Open();
                }   

                int messbox = 0;

                foreach (DataGridViewRow row in Dgv_Oder.Rows)
                {
                    if (row.Cells["TenMon"].Value != null && row.Cells["SoLuong"].Value != null && row.Cells["TenBan"].Value != null)
                    {
                        string tenMon = row.Cells["TenMon"].Value?.ToString() ?? string.Empty;
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        string tenBan = row.Cells["TenBan"].Value?.ToString() ?? string.Empty;
                        string queryGetGia = "SELECT Gia FROM ThucDon WHERE TenMon = @TenMon";
                        boLenh = new SqlCommand(queryGetGia, ketNoi);
                        boLenh.Parameters.AddWithValue("@TenMon", tenMon);

                        object giaObj = boLenh.ExecuteScalar();
                        if (giaObj == null)
                        {
                            MessageBox.Show($"Không tìm thấy giá cho món '{tenMon}' trong bảng ThucDon.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        decimal gia = Convert.ToDecimal(giaObj);
                        string queryInsert = "INSERT INTO HoaDonTam (TenMon, SoLuong, Gia, TenBan, ID_Ban) SELECT @TenMon, @SoLuong, @Gia, @TenBan, b.ID_Ban FROM Ban b WHERE b.TenBan = @TenBan";
                        boLenh = new SqlCommand(queryInsert, ketNoi);
                        boLenh.Parameters.AddWithValue("@TenMon", tenMon);
                        boLenh.Parameters.AddWithValue("@SoLuong", soLuong);
                        boLenh.Parameters.AddWithValue("@Gia", gia);
                        boLenh.Parameters.AddWithValue("@TenBan", tenBan);
                        boLenh.ExecuteNonQuery();
                        messbox++;
                    }
                }
                string sqlHD = @"INSERT INTO HoaDon (TenMon, Gia, SoLuong, TenBan, ThanhTien)
                                 SELECT TenMon, Gia, SoLuong, TenBan, SoLuong * Gia
                                 FROM HoaDonTam";
                boLenh = new SqlCommand(sqlHD, ketNoi);
                boLenh.ExecuteNonQuery();

                string sqlTrangThaiMon = @"INSERT INTO TrangThai (TenMon, SoLuong, TenBan)
                                           SELECT TenMon, SoLuong, TenBan
                                           FROM HoaDonTam";
                boLenh = new SqlCommand(sqlTrangThaiMon, ketNoi);
                boLenh.ExecuteNonQuery();
                string sqlUpdateTrangThaiBan = @"UPDATE Ban 
                                         SET TrangThai = 1 
                                         WHERE ID_Ban IN 
                                         (SELECT ID_Ban FROM HoaDonTam)";
                boLenh = new SqlCommand(sqlUpdateTrangThaiBan, ketNoi);
                boLenh.ExecuteNonQuery();
                
                if (messbox > 0)
                {
                    MessageBox.Show("Dữ liệu đã được chuyển đến bếp chế biến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dgv_Oder.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ketNoi.State == ConnectionState.Open)
                {
                    ketNoi.Close();
                }
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

