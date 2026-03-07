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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
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
            // 
            // BtnTrangThaiMon
            // 
            BtnTrangThaiMon.BackColor = Color.IndianRed;
            BtnTrangThaiMon.FlatStyle = FlatStyle.Flat;
            BtnTrangThaiMon.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTrangThaiMon.ForeColor = Color.White;
            BtnTrangThaiMon.Location = new Point(1, 278);
            BtnTrangThaiMon.Name = "BtnTrangThaiMon";
            BtnTrangThaiMon.Size = new Size(442, 52);
            BtnTrangThaiMon.TabIndex = 2;
            BtnTrangThaiMon.Text = "Trạng thái món";
            BtnTrangThaiMon.UseVisualStyleBackColor = false;
            BtnTrangThaiMon.Click += BtnTrangThaiMon_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // BtnDangXuat
            // 
            BtnDangXuat.BackColor = Color.Gray;
            BtnDangXuat.Cursor = Cursors.Hand;
            BtnDangXuat.FlatStyle = FlatStyle.Flat;
            BtnDangXuat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDangXuat.ForeColor = Color.White;
            BtnDangXuat.Location = new Point(-3, 809);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(442, 65);
            BtnDangXuat.TabIndex = 4;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.IndianRed;
            btnBill.Cursor = Cursors.Hand;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnBill.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnBill.ForeColor = SystemColors.ButtonHighlight;
            btnBill.Location = new Point(1, 336);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(442, 52);
            btnBill.TabIndex = 3;
            btnBill.Text = "Thanh toán";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.IndianRed;
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnOrder.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(1, 220);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(442, 52);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Đặt món";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1865, 877);
            panel1.TabIndex = 1;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(btnThoat);
            panelContainer.Dock = DockStyle.Right;
            panelContainer.Location = new Point(449, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1416, 877);
            panelContainer.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.PaleTurquoise;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(1345, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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