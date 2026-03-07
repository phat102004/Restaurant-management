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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBep));
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
            btnThoat.Location = new Point(1364, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnDangXuat);
            panel2.Controls.Add(btnChef);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 877);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // BtnDangXuat
            // 
            BtnDangXuat.BackColor = Color.Gray;
            BtnDangXuat.Cursor = Cursors.Hand;
            BtnDangXuat.FlatStyle = FlatStyle.Flat;
            BtnDangXuat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDangXuat.ForeColor = Color.White;
            BtnDangXuat.Location = new Point(0, 809);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(442, 65);
            BtnDangXuat.TabIndex = 2;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;
            // 
            // btnChef
            // 
            btnChef.BackColor = Color.IndianRed;
            btnChef.Cursor = Cursors.Hand;
            btnChef.FlatAppearance.BorderSize = 0;
            btnChef.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnChef.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnChef.FlatStyle = FlatStyle.Flat;
            btnChef.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnChef.ForeColor = SystemColors.ButtonHighlight;
            btnChef.Location = new Point(3, 220);
            btnChef.Name = "btnChef";
            btnChef.Size = new Size(442, 76);
            btnChef.TabIndex = 1;
            btnChef.Text = "Bếp";
            btnChef.UseVisualStyleBackColor = false;
            btnChef.Click += btnChef_Click;
            // 
            // FormBep
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
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