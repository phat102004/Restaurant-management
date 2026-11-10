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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblGridTitle = new Label();
            dgvBan = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnThoat = new Button();
            infoCard = new Panel();
            lblSection = new Label();
            label4 = new Label();
            txtIDBan = new TextBox();
            txtTenBan = new TextBox();
            txtTrangThai = new TextBox();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            panel3.SuspendLayout();
            infoCard.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(465, 64);
            label3.Name = "label3";
            label3.Size = new Size(109, 37);
            label3.TabIndex = 2;
            label3.Text = "Tên bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 1;
            label2.Text = "Mã bàn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblGridTitle);
            panel1.Controls.Add(dgvBan);
            panel1.Location = new Point(30, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 405);
            panel1.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblGridTitle.Location = new Point(20, 12);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(290, 45);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "DANH SÁCH BÀN";
            // 
            // dgvBan
            // 
            dgvBan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBan.BackgroundColor = Color.White;
            dgvBan.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 64, 175);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBan.ColumnHeadersHeight = 48;
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBan.EnableHeadersVisualStyles = false;
            dgvBan.GridColor = Color.FromArgb(203, 213, 225);
            dgvBan.Location = new Point(20, 55);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 45;
            dgvBan.RowTemplate.Height = 45;
            dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBan.Size = new Size(1310, 330);
            dgvBan.TabIndex = 0;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(37, 99, 235);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(630, 155);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 48);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa bàn";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(185, 28, 28);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(805, 155);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 48);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa bàn";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(30, 64, 175);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(455, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 48);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm bàn";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(241, 245, 249);
            panel3.Controls.Add(lblTitle);
            panel3.Controls.Add(lblSubtitle);
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(infoCard);
            panel3.Controls.Add(splitter1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1416, 420);
            panel3.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(32, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(395, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ BÀN";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(32, 88);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(622, 37);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Quản lý thông tin và trạng thái bàn trong nhà hàng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(15, 23, 42);
            btnThoat.Location = new Point(1330, 22);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(50, 46);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "×";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // infoCard
            // 
            infoCard.BackColor = Color.White;
            infoCard.Controls.Add(lblSection);
            infoCard.Controls.Add(label2);
            infoCard.Controls.Add(label3);
            infoCard.Controls.Add(label4);
            infoCard.Controls.Add(txtIDBan);
            infoCard.Controls.Add(txtTenBan);
            infoCard.Controls.Add(txtTrangThai);
            infoCard.Controls.Add(btnThem);
            infoCard.Controls.Add(btnSua);
            infoCard.Controls.Add(btnXoa);
            infoCard.Location = new Point(30, 147);
            infoCard.Name = "infoCard";
            infoCard.Size = new Size(1350, 252);
            infoCard.TabIndex = 4;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSection.ForeColor = Color.FromArgb(30, 64, 175);
            lblSection.Location = new Point(24, 15);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(259, 41);
            lblSection.TabIndex = 0;
            lblSection.Text = "THÔNG TIN BÀN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(28, 153);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // txtIDBan
            // 
            txtIDBan.BackColor = Color.FromArgb(239, 246, 255);
            txtIDBan.BorderStyle = BorderStyle.FixedSingle;
            txtIDBan.Font = new Font("Segoe UI", 11F);
            txtIDBan.Location = new Point(163, 58);
            txtIDBan.Name = "txtIDBan";
            txtIDBan.Size = new Size(265, 47);
            txtIDBan.TabIndex = 2;
            // 
            // txtTenBan
            // 
            txtTenBan.BackColor = Color.FromArgb(239, 246, 255);
            txtTenBan.BorderStyle = BorderStyle.FixedSingle;
            txtTenBan.Font = new Font("Segoe UI", 11F);
            txtTenBan.Location = new Point(580, 58);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(300, 47);
            txtTenBan.TabIndex = 2;
            // 
            // txtTrangThai
            // 
            txtTrangThai.BackColor = Color.FromArgb(239, 246, 255);
            txtTrangThai.BorderStyle = BorderStyle.FixedSingle;
            txtTrangThai.Font = new Font("Segoe UI", 11F);
            txtTrangThai.Location = new Point(163, 149);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(120, 47);
            txtTrangThai.TabIndex = 2;
            txtTrangThai.Text = " 0";
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(203, 213, 225);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 420);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            splitter1.Visible = false;
            // 
            // UC_Table
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_Table";
            Size = new Size(1416, 875);
            Load += UC_Table_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            infoCard.ResumeLayout(false);
            infoCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
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
        private Label lblGridTitle;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel infoCard;
        private Label lblSection;
    }
}
