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
    public partial class UC_Ingredient : UserControl
    {
        SqlCommand boLenh;
        SqlDataAdapter docGhi;
        DataSet duLieu;
        SqlConnection ketNoi;
        public UC_Ingredient()
        {
            boLenh = new SqlCommand();
            ketNoi = new SqlConnection();
            docGhi = new SqlDataAdapter();
            duLieu = new DataSet();
            InitializeComponent();
        }
        private void Load_Data()
        {
            string sql = (@"SELECT TenNL, SoLuong, DonVi, ID_NCC , Gia, NgayHetHan FROM NguyenLieu");
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            Dgv_NguyenLieu.DataSource = duLieu.Tables[0];
        }

        private void Load_NCC()
        {
            string sql = (@"SELECT * FROM NhaCungCap");
            docGhi = new SqlDataAdapter(sql, ketNoi);
            duLieu = new DataSet();
            docGhi.Fill(duLieu);

            Dgv_NhaCC.DataSource = duLieu.Tables[0];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UC_Ingredient_Load(object sender, EventArgs e)
        {
            string ChuoiKN = @"Data Source=LAPTOP-MK554FA4;Initial Catalog=DoAn;Integrated Security=True;Trust Server Certificate=True";
            ketNoi = new SqlConnection(ChuoiKN);
            Load_Data();
            Load_NCC();
        }
        private void Re_Load()
        {
            TxtTen_NL.Text = null;
            TxtSoLuong.Text = null;
            TxtDonVi.Text = null;
            TxtID_NCC.Text = null;
            TxtGia.Text = null;
            DtpNHH.Text= null;
        }
        private void Dgv_NhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID_NCC.Text = Dgv_NhaCC.CurrentRow.Cells[0].Value.ToString();
            TxtTenNCC.Text = Dgv_NhaCC.CurrentRow.Cells[1].Value.ToString();
        }

        private void Dgv_NguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTen_NL.Text = Dgv_NguyenLieu.CurrentRow?.Cells[0].Value?.ToString() ?? "";
            TxtSoLuong.Text = Dgv_NguyenLieu.CurrentRow?.Cells[1].Value?.ToString() ?? "";
            TxtDonVi.Text = Dgv_NguyenLieu.CurrentRow?.Cells[2].Value?.ToString() ?? "";
            TxtID_NCC.Text = Dgv_NguyenLieu.CurrentRow?.Cells[3].Value?.ToString() ?? "";
            TxtGia.Text = Dgv_NguyenLieu.CurrentRow?.Cells[4].Value?.ToString() ?? "";
            DtpNHH.Value = DateTime.TryParse(Dgv_NguyenLieu.CurrentRow?.Cells[5].Value?.ToString(), out DateTime ngayHetHan) ? ngayHetHan : DateTime.Now;
        }

        private void BtnThem_NL_Click(object sender, EventArgs e)
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
                    string Them = string.Format("insert into NguyenLieu(TenNL, SoLuong, DonVi, ID_NCC, Gia,NgayHetHan) values (N'{0}','{1}',N'{2}','{3}','{4}','{5}')", TxtTen_NL.Text.Trim(), TxtSoLuong.Text.Trim(), TxtDonVi.Text.Trim(), TxtID_NCC.Text.Trim(),TxtGia.Text.Trim(),DtpNHH.Value);
                    boLenh = new SqlCommand(Them, ketNoi);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                        Load_NCC();
                        Re_Load();
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

        private void BtnReload_Click(object sender, EventArgs e)
        {
            TxtTen_NL.Clear();
            TxtSoLuong.Clear();
            TxtDonVi.Clear();
            TxtID_NCC.Clear();
            TxtGia.Clear();
            DtpNHH.Text = null;
        }

        private void BtnXoa_NL_Click(object sender, EventArgs e)
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
                    string sqlXoa = "Delete from NguyenLieu where TenNL = @TenNL";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@TenNL", TxtTen_NL.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                        Re_Load();
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

        private void BtnSua_NL_Click(object sender, EventArgs e)
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
                    string Sua = "update NguyenLieu set SoLuong = @SoLuong, DonVi = @DonVi, ID_NCC = @ID_NCC, Gia =@Gia, NgayHetHan =@NgayHetHan where TenNL = @TenNL";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@TenNL", TxtTen_NL.Text);
                    boLenh.Parameters.AddWithValue("@SoLuong", TxtSoLuong.Text);
                    boLenh.Parameters.AddWithValue("@DonVi", TxtDonVi.Text);
                    boLenh.Parameters.AddWithValue("@ID_NCC", TxtID_NCC.Text);
                    boLenh.Parameters.AddWithValue("@Gia", TxtGia.Text);
                    boLenh.Parameters.AddWithValue("@NgayHetHan", DtpNHH.Value);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data();
                        Re_Load();
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

        private void BtnThem_NCC_Click(object sender, EventArgs e)
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
                    string Them = string.Format(@"SET IDENTITY_INSERT NhaCungCap ON;
                                                  INSERT INTO NhaCungCap(ID_NCC, TenNCC) VALUES ({0}, N'{1}');
                                                  SET IDENTITY_INSERT NhaCungCap OFF;",
                    TxtID_NCC.Text.Trim(), TxtTenNCC.Text.Trim());
                    boLenh = new SqlCommand(Them, ketNoi);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_NCC();
                        Load_Data();
                        TxtTenNCC.Clear();
                        TxtID_NCC.Clear();
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

        private void BtnXoa_NCC_Click(object sender, EventArgs e)
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
                    string sqlXoa = "Delete from NhaCungCap where ID_NCC = @ID_NCC";
                    boLenh = new SqlCommand(sqlXoa, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NCC", TxtID_NCC.Text);
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_NCC();
                        Load_Data();
                        TxtTenNCC.Clear();
                        TxtID_NCC.Clear();
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

        private void BtmSua_NCC_Click(object sender, EventArgs e)
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
                    string Sua = "update NhaCungCap set TenNCC = @TenCC where ID_NCC = @ID_NCC";
                    boLenh = new SqlCommand(Sua, ketNoi);
                    boLenh.Parameters.AddWithValue("@ID_NCC", TxtID_NCC.Text.Trim());
                    boLenh.Parameters.AddWithValue("@TenCC", TxtTenNCC.Text.Trim());
                    int kq = boLenh.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_NCC();
                        Load_Data();
                        TxtTenNCC.Clear();
                        TxtID_NCC.Clear();
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

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string TK = TxtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Ingredient_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM NguyenLieu where TenNL like '%" + TK + "%'";
                docGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                Dgv_NguyenLieu.DataSource = duLieu.Tables[0];
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TK = TxtTimKiem.Text.Trim();
            if (TK == "")
            {
                UC_Ingredient_Load(sender, e);
            }
            else
            {
                string sqlTim = "SELECT * FROM NguyenLieu where TenNL like '%" + TK + "%'";
                docGhi = new SqlDataAdapter(sqlTim, ketNoi);
                duLieu = new DataSet();
                docGhi.Fill(duLieu);
                Dgv_NguyenLieu.DataSource = duLieu.Tables[0];
            }
        }
    }
}
