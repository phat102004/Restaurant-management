namespace Restaurant_management
{
    partial class FornDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornDangNhap));
            panel3 = new Panel();
            Btn_Thoat = new Button();
            groupBox1 = new GroupBox();
            txtDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            Tx = new Label();
            label1 = new Label();
            btnDangNhap = new Button();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(Btn_Thoat);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(btnDangNhap);
            panel3.Location = new Point(570, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 621);
            panel3.TabIndex = 5;
            // 
            // Btn_Thoat
            // 
            Btn_Thoat.BackColor = Color.IndianRed;
            Btn_Thoat.Cursor = Cursors.Hand;
            Btn_Thoat.FlatStyle = FlatStyle.Flat;
            Btn_Thoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Thoat.ForeColor = Color.White;
            Btn_Thoat.Location = new Point(35, 393);
            Btn_Thoat.Name = "Btn_Thoat";
            Btn_Thoat.Size = new Size(213, 62);
            Btn_Thoat.TabIndex = 4;
            Btn_Thoat.Text = "Thoát";
            Btn_Thoat.UseVisualStyleBackColor = false;
            Btn_Thoat.Click += Btn_Thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(Tx);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 216);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(188, 56);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(276, 39);
            txtDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(188, 148);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(276, 39);
            txtMatKhau.TabIndex = 2;
            // 
            // Tx
            // 
            Tx.AutoSize = true;
            Tx.Location = new Point(8, 151);
            Tx.Name = "Tx";
            Tx.Size = new Size(115, 32);
            Tx.TabIndex = 2;
            Tx.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 59);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.IndianRed;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(254, 393);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(213, 62);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 621);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 28);
            label4.Name = "label4";
            label4.Size = new Size(468, 54);
            label4.TabIndex = 6;
            label4.Text = "Quản lý nhà hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 515);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FornDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 621);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FornDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FornDangNhap";
            Load += FornDangNhap_Load;
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnDangNhap;
        private Label Tx;
        private Label label1;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button Btn_Thoat;
    }
}