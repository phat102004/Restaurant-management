namespace Restaurant_management.User_control
{
    partial class UC_Ingredient
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
            btnThoat = new Button();
            panel1 = new Panel();
            Dgv_NhaCC = new DataGridView();
            IDNCC = new DataGridViewTextBoxColumn();
            TenNCC = new DataGridViewTextBoxColumn();
            Dgv_NguyenLieu = new DataGridView();
            TenNL = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            ID_NCC = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnTimKiem = new Button();
            label4 = new Label();
            label3 = new Label();
            TxtDonVi = new TextBox();
            label2 = new Label();
            TxtID_NCC = new TextBox();
            TxtTen_NL = new TextBox();
            TxtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            TxtTenNCC = new TextBox();
            groupBox2 = new GroupBox();
            DtpNHH = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            TxtGia = new TextBox();
            label1 = new Label();
            TxtSoLuong = new TextBox();
            groupBox4 = new GroupBox();
            BtnSua_NL = new Button();
            BtnThem_NL = new Button();
            BtnXoa_NL = new Button();
            groupBox3 = new GroupBox();
            BtmSua_NCC = new Button();
            BtnThem_NCC = new Button();
            BtnXoa_NCC = new Button();
            BtnReload = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_NhaCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_NguyenLieu).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1361, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Dgv_NhaCC);
            panel1.Location = new Point(3, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 520);
            panel1.TabIndex = 2;
            // 
            // Dgv_NhaCC
            // 
            Dgv_NhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_NhaCC.Columns.AddRange(new DataGridViewColumn[] { IDNCC, TenNCC });
            Dgv_NhaCC.Location = new Point(0, 0);
            Dgv_NhaCC.Name = "Dgv_NhaCC";
            Dgv_NhaCC.RowHeadersWidth = 82;
            Dgv_NhaCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_NhaCC.Size = new Size(517, 517);
            Dgv_NhaCC.TabIndex = 0;
            Dgv_NhaCC.CellContentClick += Dgv_NhaCC_CellContentClick;
            // 
            // IDNCC
            // 
            IDNCC.DataPropertyName = "ID_NCC";
            IDNCC.HeaderText = "ID_NCC";
            IDNCC.MinimumWidth = 10;
            IDNCC.Name = "IDNCC";
            IDNCC.Width = 80;
            // 
            // TenNCC
            // 
            TenNCC.DataPropertyName = "TenNCC";
            TenNCC.HeaderText = "Tên";
            TenNCC.MinimumWidth = 10;
            TenNCC.Name = "TenNCC";
            TenNCC.Width = 350;
            // 
            // Dgv_NguyenLieu
            // 
            Dgv_NguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_NguyenLieu.Columns.AddRange(new DataGridViewColumn[] { TenNL, SoLuong, DonVi, ID_NCC, Gia, NgayHetHan });
            Dgv_NguyenLieu.Location = new Point(0, 0);
            Dgv_NguyenLieu.Name = "Dgv_NguyenLieu";
            Dgv_NguyenLieu.RowHeadersWidth = 82;
            Dgv_NguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_NguyenLieu.Size = new Size(861, 517);
            Dgv_NguyenLieu.TabIndex = 1;
            Dgv_NguyenLieu.CellContentClick += Dgv_NguyenLieu_CellContentClick;
            // 
            // TenNL
            // 
            TenNL.DataPropertyName = "TenNL";
            TenNL.HeaderText = "Tên";
            TenNL.MinimumWidth = 10;
            TenNL.Name = "TenNL";
            TenNL.Width = 200;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 200;
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 10;
            DonVi.Name = "DonVi";
            DonVi.Width = 200;
            // 
            // ID_NCC
            // 
            ID_NCC.DataPropertyName = "ID_NCC";
            ID_NCC.HeaderText = "ID_NCC";
            ID_NCC.MinimumWidth = 10;
            ID_NCC.Name = "ID_NCC";
            ID_NCC.Width = 200;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá ";
            Gia.MinimumWidth = 10;
            Gia.Name = "Gia";
            Gia.Width = 200;
            // 
            // NgayHetHan
            // 
            NgayHetHan.DataPropertyName = "NgayHetHan";
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.MinimumWidth = 10;
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.Width = 200;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dgv_NguyenLieu);
            panel2.Location = new Point(552, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 520);
            panel2.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.IndianRed;
            btnTimKiem.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1137, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 71);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 24;
            label4.Text = "Đơn vị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 35);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 25;
            label3.Text = "ID NCC";
            // 
            // TxtDonVi
            // 
            TxtDonVi.Location = new Point(209, 71);
            TxtDonVi.Name = "TxtDonVi";
            TxtDonVi.Size = new Size(75, 39);
            TxtDonVi.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 31);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 26;
            label2.Text = "Tên NL";
            // 
            // TxtID_NCC
            // 
            TxtID_NCC.Location = new Point(144, 32);
            TxtID_NCC.Name = "TxtID_NCC";
            TxtID_NCC.Size = new Size(343, 39);
            TxtID_NCC.TabIndex = 19;
            // 
            // TxtTen_NL
            // 
            TxtTen_NL.Location = new Point(209, 32);
            TxtTen_NL.Name = "TxtTen_NL";
            TxtTen_NL.Size = new Size(307, 39);
            TxtTen_NL.TabIndex = 20;
            // 
            // TxtTimKiem
            // 
            TxtTimKiem.Location = new Point(748, 39);
            TxtTimKiem.Name = "TxtTimKiem";
            TxtTimKiem.Size = new Size(383, 39);
            TxtTimKiem.TabIndex = 21;
            TxtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtTenNCC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtID_NCC);
            groupBox1.Location = new Point(610, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 151);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 92);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 25;
            label5.Text = "Tên NCC";
            // 
            // TxtTenNCC
            // 
            TxtTenNCC.Location = new Point(144, 89);
            TxtTenNCC.Name = "TxtTenNCC";
            TxtTenNCC.Size = new Size(343, 39);
            TxtTenNCC.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DtpNHH);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtGia);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtSoLuong);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtTen_NL);
            groupBox2.Controls.Add(TxtDonVi);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(70, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 256);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // DtpNHH
            // 
            DtpNHH.Format = DateTimePickerFormat.Short;
            DtpNHH.Location = new Point(209, 191);
            DtpNHH.Name = "DtpNHH";
            DtpNHH.Size = new Size(307, 39);
            DtpNHH.TabIndex = 27;
            DtpNHH.Value = new DateTime(2025, 4, 2, 1, 1, 33, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 191);
            label7.Name = "label7";
            label7.Size = new Size(159, 32);
            label7.TabIndex = 26;
            label7.Text = "Ngày hết hạn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 152);
            label6.Name = "label6";
            label6.Size = new Size(48, 32);
            label6.TabIndex = 26;
            label6.Text = "Giá";
            // 
            // TxtGia
            // 
            TxtGia.Location = new Point(209, 149);
            TxtGia.Name = "TxtGia";
            TxtGia.Size = new Size(307, 39);
            TxtGia.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 113);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 26;
            label1.Text = "Số lượng";
            // 
            // TxtSoLuong
            // 
            TxtSoLuong.Location = new Point(209, 110);
            TxtSoLuong.Name = "TxtSoLuong";
            TxtSoLuong.Size = new Size(307, 39);
            TxtSoLuong.TabIndex = 20;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnSua_NL);
            groupBox4.Controls.Add(BtnThem_NL);
            groupBox4.Controls.Add(BtnXoa_NL);
            groupBox4.Location = new Point(750, 253);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(507, 99);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            // 
            // BtnSua_NL
            // 
            BtnSua_NL.BackColor = Color.IndianRed;
            BtnSua_NL.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnSua_NL.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtnSua_NL.FlatStyle = FlatStyle.Flat;
            BtnSua_NL.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnSua_NL.ForeColor = Color.White;
            BtnSua_NL.Location = new Point(181, 38);
            BtnSua_NL.Name = "BtnSua_NL";
            BtnSua_NL.Size = new Size(150, 46);
            BtnSua_NL.TabIndex = 28;
            BtnSua_NL.Text = "Sửa";
            BtnSua_NL.UseVisualStyleBackColor = false;
            BtnSua_NL.Click += BtnSua_NL_Click;
            // 
            // BtnThem_NL
            // 
            BtnThem_NL.BackColor = Color.IndianRed;
            BtnThem_NL.Cursor = Cursors.Hand;
            BtnThem_NL.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnThem_NL.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtnThem_NL.FlatStyle = FlatStyle.Flat;
            BtnThem_NL.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnThem_NL.ForeColor = Color.White;
            BtnThem_NL.Location = new Point(13, 38);
            BtnThem_NL.Name = "BtnThem_NL";
            BtnThem_NL.Size = new Size(150, 46);
            BtnThem_NL.TabIndex = 28;
            BtnThem_NL.Text = "Thêm";
            BtnThem_NL.UseVisualStyleBackColor = false;
            BtnThem_NL.Click += BtnThem_NL_Click;
            // 
            // BtnXoa_NL
            // 
            BtnXoa_NL.BackColor = Color.IndianRed;
            BtnXoa_NL.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnXoa_NL.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtnXoa_NL.FlatStyle = FlatStyle.Flat;
            BtnXoa_NL.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnXoa_NL.ForeColor = Color.White;
            BtnXoa_NL.Location = new Point(343, 38);
            BtnXoa_NL.Name = "BtnXoa_NL";
            BtnXoa_NL.Size = new Size(150, 46);
            BtnXoa_NL.TabIndex = 28;
            BtnXoa_NL.Text = "Xóa";
            BtnXoa_NL.UseVisualStyleBackColor = false;
            BtnXoa_NL.Click += BtnXoa_NL_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtmSua_NCC);
            groupBox3.Controls.Add(BtnThem_NCC);
            groupBox3.Controls.Add(BtnXoa_NCC);
            groupBox3.Location = new Point(13, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(507, 99);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // BtmSua_NCC
            // 
            BtmSua_NCC.BackColor = Color.IndianRed;
            BtmSua_NCC.Cursor = Cursors.Hand;
            BtmSua_NCC.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtmSua_NCC.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtmSua_NCC.FlatStyle = FlatStyle.Flat;
            BtmSua_NCC.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtmSua_NCC.ForeColor = Color.White;
            BtmSua_NCC.Location = new Point(174, 38);
            BtmSua_NCC.Name = "BtmSua_NCC";
            BtmSua_NCC.Size = new Size(150, 46);
            BtmSua_NCC.TabIndex = 28;
            BtmSua_NCC.Text = "Sửa";
            BtmSua_NCC.UseVisualStyleBackColor = false;
            BtmSua_NCC.Click += BtmSua_NCC_Click;
            // 
            // BtnThem_NCC
            // 
            BtnThem_NCC.BackColor = Color.IndianRed;
            BtnThem_NCC.Cursor = Cursors.Hand;
            BtnThem_NCC.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnThem_NCC.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            BtnThem_NCC.FlatStyle = FlatStyle.Flat;
            BtnThem_NCC.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnThem_NCC.ForeColor = Color.White;
            BtnThem_NCC.Location = new Point(6, 38);
            BtnThem_NCC.Name = "BtnThem_NCC";
            BtnThem_NCC.Size = new Size(150, 46);
            BtnThem_NCC.TabIndex = 28;
            BtnThem_NCC.Text = "Thêm";
            BtnThem_NCC.UseVisualStyleBackColor = false;
            BtnThem_NCC.Click += BtnThem_NCC_Click;
            // 
            // BtnXoa_NCC
            // 
            BtnXoa_NCC.BackColor = Color.IndianRed;
            BtnXoa_NCC.Cursor = Cursors.Hand;
            BtnXoa_NCC.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnXoa_NCC.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtnXoa_NCC.FlatStyle = FlatStyle.Flat;
            BtnXoa_NCC.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnXoa_NCC.ForeColor = Color.White;
            BtnXoa_NCC.Location = new Point(336, 38);
            BtnXoa_NCC.Name = "BtnXoa_NCC";
            BtnXoa_NCC.Size = new Size(150, 46);
            BtnXoa_NCC.TabIndex = 28;
            BtnXoa_NCC.Text = "Xóa";
            BtnXoa_NCC.UseVisualStyleBackColor = false;
            BtnXoa_NCC.Click += BtnXoa_NCC_Click;
            // 
            // BtnReload
            // 
            BtnReload.BackColor = Color.IndianRed;
            BtnReload.Cursor = Cursors.Hand;
            BtnReload.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnReload.FlatAppearance.CheckedBackColor = Color.IndianRed;
            BtnReload.FlatStyle = FlatStyle.Flat;
            BtnReload.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnReload.ForeColor = Color.White;
            BtnReload.Location = new Point(594, 291);
            BtnReload.Name = "BtnReload";
            BtnReload.Size = new Size(150, 46);
            BtnReload.TabIndex = 28;
            BtnReload.Text = "Làm mới";
            BtnReload.UseVisualStyleBackColor = false;
            BtnReload.Click += BtnReload_Click;
            // 
            // UC_Ingredient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(BtnReload);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(TxtTimKiem);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Cursor = Cursors.Hand;
            Name = "UC_Ingredient";
            Size = new Size(1416, 875);
            Load += UC_Ingredient_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_NhaCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_NguyenLieu).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Panel panel1;
        private DataGridView Dgv_NhaCC;
        private DataGridView Dgv_NguyenLieu;
        private Panel panel2;
        private Button btnTimKiem;
        private Label label4;
        private Label label3;
        private TextBox TxtDonVi;
        private Label label2;
        private TextBox TxtID_NCC;
        private TextBox TxtTen_NL;
        private TextBox TxtTimKiem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox TxtSoLuong;
        private GroupBox groupBox4;
        private Button BtnSua_NL;
        private Button BtnThem_NL;
        private Button BtnXoa_NL;
        private GroupBox groupBox3;
        private Button BtmSua_NCC;
        private Button BtnThem_NCC;
        private Button BtnXoa_NCC;
        private Label label5;
        private TextBox TxtTenNCC;
        private Button BtnReload;
        private Label label7;
        private Label label6;
        private TextBox TxtGia;
        private DateTimePicker DtpNHH;
        private DataGridViewTextBoxColumn TenNL;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn ID_NCC;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn NgayHetHan;
        private DataGridViewTextBoxColumn IDNCC;
        private DataGridViewTextBoxColumn TenNCC;
    }
}