namespace Restaurant_management.User_control
{
    partial class UC_Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            DgvAccount = new DataGridView();
            ID_NhanVien = new DataGridViewTextBoxColumn();
            TenNguoiDN = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            DgvAcc = new DataGridView();
            BtnThem = new Button();
            groupBox1 = new GroupBox();
            CbxID_NV = new ComboBox();
            CbxTenNV = new ComboBox();
            CbxChucVu = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            TxtMatKhau = new TextBox();
            TxtTenDN = new TextBox();
            label4 = new Label();
            a = new Label();
            BtnSua = new Button();
            BtnXoa = new Button();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvAcc).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 126);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvAccount);
            panel1.Location = new Point(3, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 436);
            panel1.TabIndex = 7;
            // 
            // DgvAccount
            // 
            DgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAccount.Columns.AddRange(new DataGridViewColumn[] { ID_NhanVien, TenNguoiDN, TenDangNhap, MatKhau, TenChucVu });
            DgvAccount.Location = new Point(-3, 3);
            DgvAccount.Name = "DgvAccount";
            DgvAccount.RowHeadersWidth = 82;
            DgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAccount.Size = new Size(1413, 433);
            DgvAccount.TabIndex = 0;
            DgvAccount.CellContentClick += DgvAccount_CellContentClick;
            // 
            // ID_NhanVien
            // 
            ID_NhanVien.DataPropertyName = "ID_NhanVien";
            ID_NhanVien.HeaderText = "ID_NhanVien";
            ID_NhanVien.MinimumWidth = 10;
            ID_NhanVien.Name = "ID_NhanVien";
            ID_NhanVien.Width = 200;
            // 
            // TenNguoiDN
            // 
            TenNguoiDN.DataPropertyName = "TenNguoiDN";
            TenNguoiDN.HeaderText = "Họ tên";
            TenNguoiDN.MinimumWidth = 10;
            TenNguoiDN.Name = "TenNguoiDN";
            TenNguoiDN.Width = 200;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tài khoản";
            TenDangNhap.MinimumWidth = 10;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Width = 200;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "Mật khẩu";
            MatKhau.MinimumWidth = 10;
            MatKhau.Name = "MatKhau";
            MatKhau.Width = 200;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên chức vụ";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.Width = 200;
            // 
            // DgvAcc
            // 
            DgvAcc.ColumnHeadersHeight = 46;
            DgvAcc.Location = new Point(0, 0);
            DgvAcc.Name = "DgvAcc";
            DgvAcc.RowHeadersWidth = 82;
            DgvAcc.Size = new Size(240, 150);
            DgvAcc.TabIndex = 0;
            // 
            // BtnThem
            // 
            BtnThem.BackColor = Color.IndianRed;
            BtnThem.Cursor = Cursors.Hand;
            BtnThem.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            BtnThem.FlatStyle = FlatStyle.Flat;
            BtnThem.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnThem.ForeColor = Color.White;
            BtnThem.Location = new Point(73, 38);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(150, 67);
            BtnThem.TabIndex = 4;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxID_NV);
            groupBox1.Controls.Add(CbxTenNV);
            groupBox1.Controls.Add(CbxChucVu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 259);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // CbxID_NV
            // 
            CbxID_NV.FormattingEnabled = true;
            CbxID_NV.Location = new Point(193, 66);
            CbxID_NV.Name = "CbxID_NV";
            CbxID_NV.Size = new Size(297, 40);
            CbxID_NV.TabIndex = 2;
            // 
            // CbxTenNV
            // 
            CbxTenNV.FormattingEnabled = true;
            CbxTenNV.Location = new Point(193, 123);
            CbxTenNV.Name = "CbxTenNV";
            CbxTenNV.Size = new Size(297, 40);
            CbxTenNV.TabIndex = 2;
            // 
            // CbxChucVu
            // 
            CbxChucVu.FormattingEnabled = true;
            CbxChucVu.Location = new Point(193, 181);
            CbxChucVu.Name = "CbxChucVu";
            CbxChucVu.Size = new Size(297, 40);
            CbxChucVu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 181);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 69);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 1;
            label3.Text = "ID_NV";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtMatKhau);
            groupBox2.Controls.Add(TxtTenDN);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(a);
            groupBox2.Location = new Point(731, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(624, 259);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản";
            // 
            // TxtMatKhau
            // 
            TxtMatKhau.Location = new Point(184, 136);
            TxtMatKhau.Name = "TxtMatKhau";
            TxtMatKhau.Size = new Size(297, 39);
            TxtMatKhau.TabIndex = 0;
            // 
            // TxtTenDN
            // 
            TxtTenDN.Location = new Point(184, 74);
            TxtTenDN.Name = "TxtTenDN";
            TxtTenDN.Size = new Size(297, 39);
            TxtTenDN.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 139);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(48, 77);
            a.Name = "a";
            a.Size = new Size(94, 32);
            a.TabIndex = 1;
            a.Text = "Tên ĐN";
            // 
            // BtnSua
            // 
            BtnSua.BackColor = Color.IndianRed;
            BtnSua.Cursor = Cursors.Hand;
            BtnSua.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            BtnSua.FlatStyle = FlatStyle.Flat;
            BtnSua.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnSua.ForeColor = Color.White;
            BtnSua.Location = new Point(246, 38);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(150, 67);
            BtnSua.TabIndex = 4;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = false;
            BtnSua.Click += BtnSua_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.BackColor = Color.IndianRed;
            BtnXoa.Cursor = Cursors.Hand;
            BtnXoa.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            BtnXoa.FlatStyle = FlatStyle.Flat;
            BtnXoa.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnXoa.ForeColor = Color.White;
            BtnXoa.Location = new Point(415, 38);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(150, 67);
            BtnXoa.TabIndex = 4;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = false;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(BtnThem);
            groupBox3.Controls.Add(BtnSua);
            groupBox3.Controls.Add(BtnXoa);
            groupBox3.Location = new Point(380, 279);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(654, 138);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.ImeMode = ImeMode.NoControl;
            btnThoat.Location = new Point(1361, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnThoat);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "UC_Account";
            Size = new Size(1416, 875);
            Load += UC_Account_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvAcc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView DgvAcc;
        private Button BtnThem;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox TxtMatKhau;
        private TextBox TxtTenDN;
        private Label label4;
        private Label a;
        private Button BtnSua;
        private Button BtnXoa;
        private DataGridView DgvAccount;
        private Label label3;
        private DataGridViewTextBoxColumn ID_NhanVien;
        private DataGridViewTextBoxColumn TenNguoiDN;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn TenChucVu;
        private ComboBox CbxChucVu;
        private ComboBox CbxID_NV;
        private ComboBox CbxTenNV;
        private GroupBox groupBox3;
        private Button btnThoat;
    }
}
