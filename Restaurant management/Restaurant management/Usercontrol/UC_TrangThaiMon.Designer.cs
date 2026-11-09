namespace Restaurant_management.User_control
{
    partial class UC_TrangThaiMon
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
            DgvTinhTrangMon = new DataGridView();
            txtSoLuong = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtTenMon = new TextBox();
            TxtTenBan = new TextBox();
            label1 = new Label();
            BtnHoanThanh = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtTT = new TextBox();
            btnThoat = new Button();
            MaTrangThai = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvTinhTrangMon).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvTinhTrangMon
            // 
            DgvTinhTrangMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTinhTrangMon.Columns.AddRange(new DataGridViewColumn[] { MaTrangThai, TenMon, SoLuong, TenBan, TinhTrang });
            DgvTinhTrangMon.Location = new Point(3, 339);
            DgvTinhTrangMon.Name = "DgvTinhTrangMon";
            DgvTinhTrangMon.RowHeadersWidth = 82;
            DgvTinhTrangMon.Size = new Size(1413, 536);
            DgvTinhTrangMon.TabIndex = 0;
            DgvTinhTrangMon.CellContentClick += DgvTinhTrangMon_CellContentClick;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(225, 113);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(91, 39);
            txtSoLuong.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(68, 118);
            label6.Name = "label6";
            label6.Size = new Size(107, 29);
            label6.TabIndex = 16;
            label6.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 120);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 15;
            label3.Text = "Tên món";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(651, 117);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(386, 39);
            txtTenMon.TabIndex = 14;
            // 
            // TxtTenBan
            // 
            TxtTenBan.Location = new Point(651, 46);
            TxtTenBan.Name = "TxtTenBan";
            TxtTenBan.Size = new Size(386, 39);
            TxtTenBan.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 15;
            label1.Text = "Tên bàn";
            // 
            // BtnHoanThanh
            // 
            BtnHoanThanh.BackColor = Color.IndianRed;
            BtnHoanThanh.Cursor = Cursors.Hand;
            BtnHoanThanh.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnHoanThanh.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            BtnHoanThanh.FlatStyle = FlatStyle.Flat;
            BtnHoanThanh.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnHoanThanh.ForeColor = Color.White;
            BtnHoanThanh.Location = new Point(477, 253);
            BtnHoanThanh.Name = "BtnHoanThanh";
            BtnHoanThanh.Size = new Size(386, 66);
            BtnHoanThanh.TabIndex = 18;
            BtnHoanThanh.Text = "Hoàn thành";
            BtnHoanThanh.UseVisualStyleBackColor = false;
            BtnHoanThanh.Click += BtnHoanThanh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTT);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtTenBan);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenMon);
            groupBox1.Location = new Point(110, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 218);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 53);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 15;
            label2.Text = "ID_TrangThai";
            // 
            // txtTT
            // 
            txtTT.Location = new Point(225, 49);
            txtTT.Name = "txtTT";
            txtTT.Size = new Size(280, 39);
            txtTT.TabIndex = 14;
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
            btnThoat.Location = new Point(1361, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // MaTrangThai
            // 
            MaTrangThai.DataPropertyName = "MaTrangThai";
            MaTrangThai.HeaderText = "Mã trạng thái";
            MaTrangThai.MinimumWidth = 10;
            MaTrangThai.Name = "MaTrangThai";
            MaTrangThai.Width = 210;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món";
            TenMon.MinimumWidth = 10;
            TenMon.Name = "TenMon";
            TenMon.Width = 400;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 200;
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên bàn";
            TenBan.MinimumWidth = 10;
            TenBan.Name = "TenBan";
            TenBan.Width = 300;
            // 
            // TinhTrang
            // 
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 10;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.Width = 300;
            // 
            // UC_TrangThaiMon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(BtnHoanThanh);
            Controls.Add(DgvTinhTrangMon);
            Name = "UC_TrangThaiMon";
            Size = new Size(1416, 875);
            Load += UC_TrangThaiBan_Load;
            ((System.ComponentModel.ISupportInitialize)DgvTinhTrangMon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvTinhTrangMon;
        private TextBox txtSoLuong;
        private Label label6;
        private Label label3;
        private TextBox txtTenMon;
        private TextBox TxtTenBan;
        private Label label1;
        private Button BtnHoanThanh;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Label label2;
        private TextBox txtTT;
        private DataGridViewTextBoxColumn MaTrangThai;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}
