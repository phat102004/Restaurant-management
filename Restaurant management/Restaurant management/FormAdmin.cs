using Restaurant_management.User_control;
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
using Restaurant_management.Usercontrol;
namespace Restaurant_management
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            // Đổi tên nút Home thành Tổng quan
            btnHome.Text = "   Tổng quan";

            // Tạo nút riêng cho chức năng Trạng thái món
            CreateTrangThaiMonButton();

            // Mở Dashboard khi Admin đăng nhập
            UC_Dashboard dashboard = new();
            AddUserControl(dashboard);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new();
            AddUserControl(dashboard);
        }


        private void CreateTrangThaiMonButton()
        {
            Button btnTrangThaiMon = new Button();

            btnTrangThaiMon.Name = "btnTrangThaiMon";
            btnTrangThaiMon.Text = "   Trạng thái món";

            btnTrangThaiMon.Size = new Size(412, 52);
            btnTrangThaiMon.Location = new Point(15, 684);

            btnTrangThaiMon.BackColor =
                Color.FromArgb(30, 64, 175);

            btnTrangThaiMon.ForeColor = Color.White;
            btnTrangThaiMon.Font =
                new Font("Segoe UI", 11F);

            btnTrangThaiMon.FlatStyle = FlatStyle.Flat;
            btnTrangThaiMon.FlatAppearance.BorderSize = 0;

            btnTrangThaiMon.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(37, 99, 235);

            btnTrangThaiMon.TextAlign =
                ContentAlignment.MiddleLeft;

            btnTrangThaiMon.Cursor = Cursors.Hand;

            btnTrangThaiMon.Click += (sender, e) =>
            {
                UC_TrangThaiMon uc = new();
                AddUserControl(uc);
            };

            panel2.Controls.Add(btnTrangThaiMon);
            btnTrangThaiMon.BringToFront();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            UC_Order uC = new();
            AddUserControl(uC);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            UC_Menu uC = new();
            AddUserControl(uC);
        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            UC_Bill uC = new();
            AddUserControl((uC));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            UC_Revenue uC = new();
            AddUserControl(uC);
        }

        private void BtnIngredient_Click(object sender, EventArgs e)
        {
            UC_Ingredient uC = new();
            AddUserControl(uC);
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            UC_Account uC = new();
            AddUserControl(uC);
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            UC_Chef uC = new();
            AddUserControl((uC));
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            UC_Table uC = new();
            AddUserControl((uC));
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UC_Employee uC = new();
            AddUserControl((uC));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FornDangNhap fornDangNhap = new FornDangNhap();
                fornDangNhap.Show();
            }
            else
            {
                this.Show();
            }
        }
    }
}
