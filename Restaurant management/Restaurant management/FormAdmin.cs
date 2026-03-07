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
namespace Restaurant_management
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            UC_TrangThaiMon uC = new();
            AddUserControl(uC);
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
            UC_TrangThaiMon uC = new();
            AddUserControl(uC);
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
