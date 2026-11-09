namespace Restaurant_management
{
    partial class FormOrder
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
                new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));

            panel2 = new Panel();
            BtnTrangThaiMon = new Button();
            pictureBox2 = new PictureBox();
            BtnDangXuat = new Button();
            btnBill = new Button();
            btnOrder = new Button();
            panel1 = new Panel();
            panelContainer = new Panel();
            btnThoat = new Button();

            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
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
            // PANEL SIDEBAR - 442 x 877
            // =============================================

            panel2.BackColor = sidebarColor;
            panel2.Controls.Add(BtnTrangThaiMon);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnDangXuat);
            panel2.Controls.Add(btnBill);
            panel2.Controls.Add(btnOrder);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 877);
            panel2.TabIndex = 3;

            // =============================================
            // LOGO NHÀ HÀNG
            // =============================================

            pictureBox2.BackColor = sidebarColor;
            pictureBox2.Image =
                (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;

            // =============================================
            // NÚT ĐẶT MÓN
            // =============================================

            btnOrder.BackColor = menuColor;
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseDownBackColor = pressedColor;
            btnOrder.FlatAppearance.MouseOverBackColor = hoverColor;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font(
                "Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = textColor;
            btnOrder.Location = new Point(15, 220);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(412, 52);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "   Đặt món";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;

            // =============================================
            // NÚT TRẠNG THÁI MÓN
            // =============================================

            BtnTrangThaiMon.BackColor = menuColor;
            BtnTrangThaiMon.Cursor = Cursors.Hand;
            BtnTrangThaiMon.FlatAppearance.BorderSize = 0;
            BtnTrangThaiMon.FlatAppearance.MouseDownBackColor = pressedColor;
            BtnTrangThaiMon.FlatAppearance.MouseOverBackColor = hoverColor;
            BtnTrangThaiMon.FlatStyle = FlatStyle.Flat;
            BtnTrangThaiMon.Font = new Font(
                "Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTrangThaiMon.ForeColor = textColor;
            BtnTrangThaiMon.Location = new Point(15, 278);
            BtnTrangThaiMon.Name = "BtnTrangThaiMon";
            BtnTrangThaiMon.Size = new Size(412, 52);
            BtnTrangThaiMon.TabIndex = 2;
            BtnTrangThaiMon.Text = "   Trạng thái món";
            BtnTrangThaiMon.TextAlign = ContentAlignment.MiddleLeft;
            BtnTrangThaiMon.UseVisualStyleBackColor = false;
            BtnTrangThaiMon.Click += BtnTrangThaiMon_Click;

            // =============================================
            // NÚT THANH TOÁN
            // =============================================

            btnBill.BackColor = menuColor;
            btnBill.Cursor = Cursors.Hand;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatAppearance.MouseDownBackColor = pressedColor;
            btnBill.FlatAppearance.MouseOverBackColor = hoverColor;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font(
                "Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBill.ForeColor = textColor;
            btnBill.Location = new Point(15, 336);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(412, 52);
            btnBill.TabIndex = 3;
            btnBill.Text = "   Thanh toán";
            btnBill.TextAlign = ContentAlignment.MiddleLeft;
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;

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
            BtnDangXuat.Location = new Point(15, 797);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(412, 52);
            BtnDangXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnDangXuat.TabIndex = 4;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.TextAlign = ContentAlignment.MiddleCenter;
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;

            // =============================================
            // PANEL TỔNG - GIỮ NGUYÊN BỐ CỤC
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
            // PANEL CHỨA USERCONTROL - 1416 x 877
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

            // Giữ nguyên: code gốc không có Click cho btnThoat.

            // =============================================
            // FORM ORDER
            // =============================================

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = contentColor;
            ClientSize = new Size(1865, 877);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrder";

            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel panel2;
        private Button btnBill;
        private Button btnOrder;
        private Panel panel1;
        private Panel panelContainer;
        private Button btnThoat;
        private Button BtnDangXuat;
        private PictureBox pictureBox2;
        private Button BtnTrangThaiMon;
    }
}