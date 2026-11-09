namespace Restaurant_management.User_control
{
    partial class UC_Menu
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
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            txtMoTa = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbxDanhMuc = new ComboBox();
            txtGia = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label2 = new Label();
            txtIdFood = new TextBox();
            txtTenMon = new TextBox();
            txtSoLuong = new TextBox();
            label3 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            splitter1 = new Splitter();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            dgvThucDon = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvThucDon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1416, 879);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(txtTimKiem);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1416, 440);
            panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMoTa);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbxDanhMuc);
            groupBox3.Controls.Add(txtGia);
            groupBox3.Location = new Point(752, 101);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 211);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(188, 43);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(386, 39);
            txtMoTa.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 46);
            label8.Name = "label8";
            label8.Size = new Size(77, 32);
            label8.TabIndex = 3;
            label8.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 99);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 3;
            label4.Text = "Danh mục";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 158);
            label5.Name = "label5";
            label5.Size = new Size(48, 32);
            label5.TabIndex = 3;
            label5.Text = "Giá";
            // 
            // cbxDanhMuc
            // 
            cbxDanhMuc.FormattingEnabled = true;
            cbxDanhMuc.Location = new Point(188, 99);
            cbxDanhMuc.Name = "cbxDanhMuc";
            cbxDanhMuc.Size = new Size(387, 40);
            cbxDanhMuc.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(191, 162);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(384, 39);
            txtGia.TabIndex = 5;
            txtGia.TextChanged += txtGia_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtIdFood);
            groupBox2.Controls.Add(txtTenMon);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(9, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(695, 211);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 194);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 3;
            label2.Text = "ID_Food";
            // 
            // txtIdFood
            // 
            txtIdFood.BorderStyle = BorderStyle.FixedSingle;
            txtIdFood.Font = new Font("Segoe UI", 9F);
            txtIdFood.Location = new Point(252, 35);
            txtIdFood.Name = "txtIdFood";
            txtIdFood.Size = new Size(386, 39);
            txtIdFood.TabIndex = 2;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(252, 96);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(386, 39);
            txtTenMon.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(252, 158);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(99, 39);
            txtSoLuong.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 99);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 3;
            label3.Text = "Tên món";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Location = new Point(369, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 120);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnXoa.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnXoa.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnXoa.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(259, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.IndianRed;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThem.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnThem.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnThem.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(70, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.IndianRed;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnSua.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnSua.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSua.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(445, 38);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1324, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ActiveCaptionText;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 440);
            splitter1.TabIndex = 14;
            splitter1.TabStop = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.IndianRed;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnTimKiem.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnTimKiem.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(709, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(865, 40);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(387, 39);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvThucDon
            // 
            dgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThucDon.Location = new Point(12, 459);
            dgvThucDon.Name = "dgvThucDon";
            dgvThucDon.RowHeadersWidth = 82;
            dgvThucDon.Size = new Size(1344, 433);
            dgvThucDon.TabIndex = 0;
            dgvThucDon.CellContentClick += dgvThucDon_CellContentClick;
            // 
            // UC_Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UC_Menu";
            Size = new Size(1379, 879);
            Load += UC_Menu_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvThucDon;
        private TextBox txtGia;
        private ComboBox cbxDanhMuc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTimKiem;
        private TextBox txtIdFood;
        private Button btnThem;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtSoLuong;
        private Label label6;
        private Label label7;
        private TextBox txtTenMon;
        private Label label8;
        private TextBox txtMoTa;
        private Splitter splitter1;
        private Button btnThoat;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
    }
}
