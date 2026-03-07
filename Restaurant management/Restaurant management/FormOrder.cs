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

namespace Restaurant_management
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            UC_Order uC = new();
            AddUserControl(uC); 
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UC_Order uC = new UC_Order();
            AddUserControl((uC));
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            UC_Bill uC = new UC_Bill();
            AddUserControl((uC));
        }

        private void BtnTrangThaiMon_Click(object sender, EventArgs e)
        {
            UC_TrangThaiMon uC = new UC_TrangThaiMon();
            AddUserControl(uC);
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
