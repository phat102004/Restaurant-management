namespace Restaurant_management.User_control
{
    partial class UC_Employee
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
            panel3 = new Panel();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txtHoTen = new TextBox();
            TxtCaLam = new TextBox();
            label8 = new Label();
            cbxTenCV = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtSDT = new TextBox();
            txtID_NV = new TextBox();
            label2 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            label7 = new Label();
            txtTimKiem = new TextBox();
            panel_Employee = new Panel();
            dgvNV = new DataGridView();
            ID_NhanVien = new DataGridViewTextBoxColumn();
            HoTenNV = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenChucVu = new DataGridViewTextBoxColumn();
            CaLam = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtTimKiem);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1416, 407);
            panel3.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1361, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(TxtCaLam);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbxTenCV);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(703, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(651, 215);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 50);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 3;
            label3.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(228, 47);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(343, 39);
            txtHoTen.TabIndex = 2;
            // 
            // TxtCaLam
            // 
            TxtCaLam.Location = new Point(228, 151);
            TxtCaLam.Name = "TxtCaLam";
            TxtCaLam.Size = new Size(343, 39);
            TxtCaLam.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 154);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 3;
            label8.Text = "Ca làm";
            // 
            // cbxTenCV
            // 
            cbxTenCV.FormattingEnabled = true;
            cbxTenCV.Location = new Point(228, 98);
            cbxTenCV.Name = "cbxTenCV";
            cbxTenCV.Size = new Size(343, 40);
            cbxTenCV.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 101);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 3;
            label5.Text = "Chức vụ";
            label5.Click += label5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtID_NV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(50, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 215);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(151, 98);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(343, 39);
            txtSDT.TabIndex = 2;
            // 
            // txtID_NV
            // 
            txtID_NV.Location = new Point(151, 43);
            txtID_NV.Name = "txtID_NV";
            txtID_NV.Size = new Size(343, 39);
            txtID_NV.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 55);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 3;
            label2.Text = "ID_NV";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(151, 154);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(343, 39);
            txtDiaChi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 101);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 3;
            label4.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 157);
            label6.Name = "label6";
            label6.Size = new Size(87, 32);
            label6.TabIndex = 3;
            label6.Text = "Địa chỉ";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.IndianRed;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(800, 330);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 56);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(604, 330);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 56);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.IndianRed;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(415, 330);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 56);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.IndianRed;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(439, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 477);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(50, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(383, 39);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panel_Employee
            // 
            panel_Employee.Controls.Add(dgvNV);
            panel_Employee.Location = new Point(0, 413);
            panel_Employee.Name = "panel_Employee";
            panel_Employee.Size = new Size(1416, 462);
            panel_Employee.TabIndex = 6;
            // 
            // dgvNV
            // 
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { ID_NhanVien, HoTenNV, SoDienThoai, DiaChi, TenChucVu, CaLam });
            dgvNV.Dock = DockStyle.Top;
            dgvNV.Location = new Point(0, 0);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 82;
            dgvNV.Size = new Size(1416, 462);
            dgvNV.TabIndex = 0;
            dgvNV.CellContentClick += dgvNV_CellContentClick_1;
            // 
            // ID_NhanVien
            // 
            ID_NhanVien.DataPropertyName = "ID_NhanVien";
            ID_NhanVien.HeaderText = "ID_NhanVien";
            ID_NhanVien.MinimumWidth = 10;
            ID_NhanVien.Name = "ID_NhanVien";
            ID_NhanVien.Width = 200;
            // 
            // HoTenNV
            // 
            HoTenNV.DataPropertyName = "HoTenNV";
            HoTenNV.HeaderText = "Họ Tên";
            HoTenNV.MinimumWidth = 10;
            HoTenNV.Name = "HoTenNV";
            HoTenNV.Width = 300;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "SDT";
            SoDienThoai.MinimumWidth = 10;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Width = 250;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 10;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 400;
            // 
            // TenChucVu
            // 
            TenChucVu.DataPropertyName = "TenChucVu";
            TenChucVu.HeaderText = "Tên chức vụ";
            TenChucVu.MinimumWidth = 10;
            TenChucVu.Name = "TenChucVu";
            TenChucVu.Width = 200;
            // 
            // CaLam
            // 
            CaLam.DataPropertyName = "CaLam";
            CaLam.HeaderText = "Ca làm";
            CaLam.MinimumWidth = 10;
            CaLam.Name = "CaLam";
            CaLam.Width = 200;
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel_Employee);
            Controls.Add(panel3);
            Name = "UC_Employee";
            Size = new Size(1416, 875);
            Load += UC_Employee_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnTimKiem;
        private Label label3;
        private Label label7;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtID_NV;
        private TextBox txtTimKiem;
        private Label label5;
        private Label label4;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private ComboBox cbxTenCV;
        private Label label6;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label8;
        private TextBox TxtCaLam;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel_Employee;
        private Button btnThoat;
        private DataGridView dgvNV;
        private DataGridViewTextBoxColumn ID_NhanVien;
        private DataGridViewTextBoxColumn HoTenNV;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenChucVu;
        private DataGridViewTextBoxColumn CaLam;
    }
}