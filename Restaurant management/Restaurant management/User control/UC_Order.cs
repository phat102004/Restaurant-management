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
            string chuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
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

