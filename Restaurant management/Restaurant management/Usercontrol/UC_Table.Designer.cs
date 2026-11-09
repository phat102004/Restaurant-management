namespace Restaurant_management.User_control
{
    partial class UC_Table
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
            btnTimKiem = new Button();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            panel1 = new Panel();
            dgvBan = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            btnThoat = new Button();
            splitter1 = new Splitter();
            label4 = new Label();
            txtTrangThai = new TextBox();
            txtTenBan = new TextBox();
            txtIDBan = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.IndianRed;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1171, 44);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 176);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 3;
            label3.Text = "Tên bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 120);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 3;
            label2.Text = "ID_Bàn";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(782, 48);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(383, 39);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBan);
            panel1.Location = new Point(3, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(1410, 390);
            panel1.TabIndex = 2;
            // 
            // dgvBan
            // 
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Location = new Point(0, 0);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 82;
            dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBan.Size = new Size(1410, 387);
            dgvBan.TabIndex = 0;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.IndianRed;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnSua.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(838, 302);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 72);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnXoa.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(652, 302);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 72);
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
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(453, 302);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 72);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTrangThai);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTenBan);
            panel3.Controls.Add(txtIDBan);
            panel3.Controls.Add(txtTimKiem);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1413, 415);
            panel3.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1358, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ActiveCaptionText;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 415);
            splitter1.TabIndex = 14;
            splitter1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 235);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(568, 232);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(63, 39);
            txtTrangThai.TabIndex = 2;
            txtTrangThai.Text = " 0";
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(568, 176);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(343, 39);
            txtTenBan.TabIndex = 2;
            // 
            // txtIDBan
            // 
            txtIDBan.Location = new Point(568, 117);
            txtIDBan.Name = "txtIDBan";
            txtIDBan.Size = new Size(343, 39);
            txtIDBan.TabIndex = 2;
            // 
            // UC_Table
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_Table";
            Size = new Size(1416, 875);
            Load += UC_Table_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTimKiem;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTimKiem;
        private Panel panel1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvBan;
        private Panel panel3;
        private Splitter splitter1;
        private TextBox txtTenBan;
        private TextBox txtIDBan;
        private TextBox txtTrangThai;
        private Button btnThoat;
    }
}
