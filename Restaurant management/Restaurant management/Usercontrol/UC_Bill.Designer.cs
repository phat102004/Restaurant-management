namespace Restaurant_management.User_control
{
    partial class UC_Bill
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


        private void InitializeComponent()
        {
            panelTables = new Panel();
            button1 = new Button();
            dgv_HoaDon = new DataGridView();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            btnThoat = new Button();
            btnThanhToan = new Button();
            txtTongTien = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // =============================================
            // BẢNG MÀU MODERN BLUE
            // =============================================

            Color primaryBlue = Color.FromArgb(30, 64, 175);
            Color brightBlue = Color.FromArgb(37, 99, 235);
            Color darkBlue = Color.FromArgb(16, 42, 67);
            Color contentBg = Color.FromArgb(241, 245, 249);
            Color borderColor = Color.FromArgb(203, 213, 225);
            Color textColor = Color.FromArgb(51, 65, 85);

            // =============================================
            // PANEL DANH SÁCH BÀN
            // GIỮ NGUYÊN KÍCH THƯỚC VÀ VỊ TRÍ
            // =============================================

            panelTables.BackColor = Color.White;
            panelTables.Location = new Point(0, 0);
            panelTables.Name = "panelTables";
            panelTables.Size = new Size(652, 872);
            panelTables.TabIndex = 0;

            // =============================================
            // BUTTON1 - GIỮ NGUYÊN CONTROL
            // =============================================

            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;

            // =============================================
            // CỘT DATAGRIDVIEW - GIỮ NGUYÊN BINDING
            // =============================================

            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món";
            TenMon.MinimumWidth = 10;
            TenMon.Name = "TenMon";
            TenMon.Width = 200;

            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 200;

            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 10;
            Gia.Name = "Gia";
            Gia.Width = 200;

            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 10;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 200;

            NgayTao.DataPropertyName = "NgayTao";
            NgayTao.HeaderText = "Ngày tạo";
            NgayTao.MinimumWidth = 10;
            NgayTao.Name = "NgayTao";
            NgayTao.Visible = false;
            NgayTao.Width = 200;

            // =============================================
            // DATAGRIDVIEW HÓA ĐƠN
            // =============================================

            dgv_HoaDon.BackgroundColor = Color.White;
            dgv_HoaDon.BorderStyle = BorderStyle.None;
            dgv_HoaDon.GridColor = borderColor;

            dgv_HoaDon.EnableHeadersVisualStyles = false;
            dgv_HoaDon.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_HoaDon.ColumnHeadersHeight = 50;

            dgv_HoaDon.ColumnHeadersDefaultCellStyle.BackColor = primaryBlue;
            dgv_HoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_HoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv_HoaDon.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgv_HoaDon.DefaultCellStyle.BackColor = Color.White;
            dgv_HoaDon.DefaultCellStyle.ForeColor = darkBlue;
            dgv_HoaDon.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);
            dgv_HoaDon.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);
            dgv_HoaDon.DefaultCellStyle.SelectionForeColor = darkBlue;
            dgv_HoaDon.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);

            dgv_HoaDon.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgv_HoaDon.RowTemplate.Height = 42;
            dgv_HoaDon.RowHeadersWidth = 82;
            dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_HoaDon.Columns.AddRange(new DataGridViewColumn[]
            {
        TenMon,
        SoLuong,
        Gia,
        ThanhTien,
        NgayTao
            });

            dgv_HoaDon.Location = new Point(11, 162);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.Size = new Size(707, 527);
            dgv_HoaDon.TabIndex = 1;

            // =============================================
            // PANEL HÓA ĐƠN
            // GIỮ NGUYÊN 729 x 869
            // =============================================

            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnThanhToan);
            panel1.Controls.Add(txtTongTien);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgv_HoaDon);
            panel1.Location = new Point(684, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 869);
            panel1.TabIndex = 2;

            // =============================================
            // TIÊU ĐỀ THANH TOÁN
            // =============================================

            label2.AutoSize = false;
            label2.BackColor = Color.White;
            label2.Font = new Font(
                "Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = primaryBlue;
            label2.Location = new Point(65, 70);
            label2.Name = "label2";
            label2.Size = new Size(615, 75);
            label2.TabIndex = 7;
            label2.Text = "THANH TOÁN HÓA ĐƠN";
            label2.TextAlign = ContentAlignment.MiddleCenter;

            // =============================================
            // NÚT THOÁT
            // =============================================

            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.CheckedBackColor =
                Color.FromArgb(254, 202, 202);
            btnThoat.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(185, 28, 28);
            btnThoat.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(254, 202, 202);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font(
                "Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = textColor;
            btnThoat.Location = new Point(674, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "×";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;

            // =============================================
            // NÚT THANH TOÁN
            // =============================================

            btnThanhToan.BackColor = brightBlue;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.CheckedBackColor = primaryBlue;
            btnThanhToan.FlatAppearance.MouseDownBackColor = primaryBlue;
            btnThanhToan.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(59, 130, 246);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(239, 775);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(275, 63);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;

            // =============================================
            // Ô TỔNG TIỀN - GIỮ READONLY
            // =============================================

            txtTongTien.BackColor = Color.FromArgb(239, 246, 255);
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.ForeColor = primaryBlue;
            txtTongTien.Location = new Point(239, 711);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(275, 46);
            txtTongTien.TabIndex = 4;
            txtTongTien.TextAlign = HorizontalAlignment.Right;

            // =============================================
            // LABEL TỔNG TIỀN
            // =============================================

            label1.AutoSize = true;
            label1.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = darkBlue;
            label1.Location = new Point(77, 710);
            label1.Name = "label1";
            label1.TabIndex = 3;
            label1.Text = "Tổng tiền";

            // =============================================
            // UC BILL - GIỮ NGUYÊN 1416 x 875
            // =============================================

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = contentBg;

            Controls.Add(panel1);
            Controls.Add(panelTables);

            Name = "UC_Bill";
            Size = new Size(1416, 875);
            Load += Bill_Load;

            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        private Panel panelTables;
        private Button button1;
        private DataGridView dgv_HoaDon;
        private Panel panel1;
        private TextBox txtTongTien;
        private Label label1;
        private Button btnThanhToan;
        private Button btnThoat;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn NgayTao;
        private Label label2;
    }
}
