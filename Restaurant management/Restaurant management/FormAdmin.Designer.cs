namespace Restaurant_management
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));

            panel1 = new Panel();
            panelContainer = new Panel();
            btnThoat = new Button();
            panel2 = new Panel();
            BtnDangXuat = new Button();
            BtnAccount = new Button();
            pictureBox2 = new PictureBox();
            BtnIngredient = new Button();
            btnRevenue = new Button();
            btnEmployee = new Button();
            btnBill = new Button();
            btnFood = new Button();
            btnTable = new Button();
            btnHome = new Button();

            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            // =============================================
            // BẢNG MÀU MODERN BLUE
            // =============================================

            Color sidebarColor = Color.FromArgb(16, 42, 67);
            Color menuColor = Color.FromArgb(30, 64, 175);
            Color hoverColor = Color.FromArgb(37, 99, 235);
            Color pressedColor = Color.FromArgb(29, 78, 216);
            Color textColor = Color.FromArgb(241, 245, 249);
            Color contentColor = Color.FromArgb(241, 245, 249);

            // =============================================
            // PANEL CHÍNH - GIỮ NGUYÊN KÍCH THƯỚC
            // =============================================

            panel1.BackColor = contentColor;
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1862, 875);
            panel1.TabIndex = 0;

            // =============================================
            // PANEL CONTAINER - GIỮ 1416 x 875
            // =============================================

            panelContainer.BackColor = contentColor;
            panelContainer.Controls.Add(btnThoat);
            panelContainer.Dock = DockStyle.Right;
            panelContainer.Location = new Point(446, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1416, 875);
            panelContainer.TabIndex = 4;

            // =============================================
            // NÚT THOÁT
            // =============================================

            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(185, 28, 28);
            btnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font(
                "Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.FromArgb(51, 65, 85);
            btnThoat.Location = new Point(1357, 8);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(44, 42);
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.TabIndex = 0;
            btnThoat.Text = "×";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;

            // =============================================
            // SIDEBAR - GIỮ NGUYÊN RỘNG 442
            // =============================================

            panel2.BackColor = sidebarColor;
            panel2.Controls.Add(BtnDangXuat);
            panel2.Controls.Add(BtnAccount);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnIngredient);
            panel2.Controls.Add(btnRevenue);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnBill);
            panel2.Controls.Add(btnFood);
            panel2.Controls.Add(btnTable);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 875);
            panel2.TabIndex = 3;

            // =============================================
            // LOGO - GIỮ NGUYÊN RESOURCE
            // =============================================

            pictureBox2.BackColor = sidebarColor;
            pictureBox2.Image =
                (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;

            // =============================================
            // GIAO DIỆN MENU - CHỈ THAY STYLE
            // =============================================

            Button[] menuButtons =
            {
        btnHome,
        btnFood,
        btnTable,
        btnBill,
        btnEmployee,
        btnRevenue,
        BtnIngredient,
        BtnAccount
    };

            string[] menuTexts =
            {
        "Trạng thái món",
        "Thực đơn",
        "Bàn",
        "Thanh toán",
        "Nhân viên",
        "Doanh thu",
        "Nguyên liệu",
        "Tài khoản"
    };

            for (int i = 0; i < menuButtons.Length; i++)
            {
                Button button = menuButtons[i];

                button.BackColor = menuColor;
                button.ForeColor = textColor;
                button.Cursor = Cursors.Hand;

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = hoverColor;
                button.FlatAppearance.MouseDownBackColor = pressedColor;

                button.Font = new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular,
                    GraphicsUnit.Point
                );

                button.Text = "   " + menuTexts[i];
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.UseVisualStyleBackColor = false;

                button.Location = new Point(15, 220 + i * 58);
                button.Size = new Size(412, 52);
                button.TabIndex = i + 1;
            }

            // =============================================
            // GIỮ NGUYÊN CÁC SỰ KIỆN CLICK
            // =============================================

            btnHome.Name = "btnHome";
            btnHome.Click += btnHome_Click;

            btnFood.Name = "btnFood";
            btnFood.Click += btnFood_Click;

            btnTable.Name = "btnTable";
            btnTable.Click += btnTable_Click;

            btnBill.Name = "btnBill";
            btnBill.Click += btnBill_Click;

            btnEmployee.Name = "btnEmployee";
            btnEmployee.Click += btnEmployee_Click;

            btnRevenue.Name = "btnRevenue";
            btnRevenue.Click += btnRevenue_Click;

            BtnIngredient.Name = "BtnIngredient";
            BtnIngredient.Click += BtnIngredient_Click;

            BtnAccount.Name = "BtnAccount";
            BtnAccount.Click += BtnAccount_Click;

            // =============================================
            // NÚT ĐĂNG XUẤT
            // =============================================

            BtnDangXuat.BackColor = Color.FromArgb(30, 58, 138);
            BtnDangXuat.Cursor = Cursors.Hand;
            BtnDangXuat.FlatAppearance.BorderSize = 0;
            BtnDangXuat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(30, 64, 175);
            BtnDangXuat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(37, 99, 235);
            BtnDangXuat.FlatStyle = FlatStyle.Flat;
            BtnDangXuat.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDangXuat.ForeColor = Color.White;
            BtnDangXuat.Location = new Point(15, 800);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(412, 52);
            BtnDangXuat.TabIndex = 11;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;

            // =============================================
            // FORM ADMIN
            // =============================================

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = contentColor;
            ClientSize = new Size(1865, 877);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà hàng";
            Load += FormAdmin_Load;

            panel1.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnIngredient;
        private Button btnRevenue;
        private Button btnEmployee;
        private Button btnBill;
        private Button btnTable;
        private Panel panelContainer;
        private PictureBox pictureBox2;
        private Button btnFood;
        private Button BtnAccount;
        private Button btnThoat;
        private Button BtnDangXuat;
        private Button btnHome;
    }
}