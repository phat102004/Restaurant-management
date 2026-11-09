namespace Restaurant_management
{
    partial class FormBep
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
                new System.ComponentModel.ComponentResourceManager(typeof(FormBep));

            panelContainer = new Panel();
            btnThoat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            BtnDangXuat = new Button();
            btnChef = new Button();

            panelContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            // =============================================
            // BẢNG MÀU MODERN BLUE - ĐỒNG BỘ FORM ADMIN
            // =============================================

            Color sidebarColor = Color.FromArgb(16, 42, 67);
            Color menuColor = Color.FromArgb(30, 64, 175);
            Color hoverColor = Color.FromArgb(37, 99, 235);
            Color pressedColor = Color.FromArgb(29, 78, 216);
            Color textColor = Color.FromArgb(241, 245, 249);
            Color contentColor = Color.FromArgb(241, 245, 249);

            // =============================================
            // PANEL CONTAINER - GIỮ NGUYÊN 1416 x 877
            // =============================================

            panelContainer.BackColor = contentColor;
            panelContainer.Controls.Add(btnThoat);
            panelContainer.Dock = DockStyle.Right;
            panelContainer.Location = new Point(449, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1416, 877);
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

            // Không thêm Click handler vì code gốc không có.

            // =============================================
            // PANEL CHÍNH
            // =============================================

            panel1.BackColor = contentColor;
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 877);
            panel1.TabIndex = 1;

            // =============================================
            // SIDEBAR - GIỮ NGUYÊN 442 x 877
            // =============================================

            panel2.BackColor = sidebarColor;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnDangXuat);
            panel2.Controls.Add(btnChef);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 877);
            panel2.TabIndex = 3;

            // =============================================
            // LOGO NHÀ HÀNG
            // =============================================

            pictureBox2.BackColor = sidebarColor;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;

            // =============================================
            // NÚT BẾP
            // =============================================

            btnChef.BackColor = menuColor;
            btnChef.Cursor = Cursors.Hand;
            btnChef.FlatAppearance.BorderSize = 0;
            btnChef.FlatAppearance.MouseDownBackColor = pressedColor;
            btnChef.FlatAppearance.MouseOverBackColor = hoverColor;
            btnChef.FlatStyle = FlatStyle.Flat;
            btnChef.Font = new Font(
                "Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChef.ForeColor = textColor;
            btnChef.Location = new Point(15, 220);
            btnChef.Name = "btnChef";
            btnChef.Size = new Size(412, 52);
            btnChef.TabIndex = 1;
            btnChef.Text = "   Bếp";
            btnChef.TextAlign = ContentAlignment.MiddleLeft;
            btnChef.UseVisualStyleBackColor = false;
            btnChef.Click += btnChef_Click;

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
            BtnDangXuat.Location = new Point(15, 809);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(412, 52);
            BtnDangXuat.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            BtnDangXuat.TabIndex = 2;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;

            // =============================================
            // FORM BẾP
            // =============================================

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = contentColor;
            ClientSize = new Size(1865, 877);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBep";

            panelContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelContainer;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
        private Button btnChef;
        private Button BtnDangXuat;
        private PictureBox pictureBox2;
    }
}