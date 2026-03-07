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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            // 
            // panelTables
            // 
            panelTables.Location = new Point(0, 0);
            panelTables.Name = "panelTables";
            panelTables.Size = new Size(652, 872);
            panelTables.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Columns.AddRange(new DataGridViewColumn[] { TenMon, SoLuong, Gia, ThanhTien, NgayTao });
            dgv_HoaDon.Location = new Point(11, 162);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 82;
            dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HoaDon.Size = new Size(707, 527);
            dgv_HoaDon.TabIndex = 1;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên món";
            TenMon.MinimumWidth = 10;
            TenMon.Name = "TenMon";
            TenMon.Width = 200;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 10;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 200;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 10;
            Gia.Name = "Gia";
            Gia.Width = 200;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 10;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 200;
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
            NgayTao.HeaderText = "Ngày tạo";
            NgayTao.MinimumWidth = 10;
            NgayTao.Name = "NgayTao";
            NgayTao.Visible = false;
            NgayTao.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 85);
            label2.Name = "label2";
            label2.Size = new Size(597, 59);
            label2.TabIndex = 7;
            label2.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThoat.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(674, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(255, 192, 192);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btnThanhToan.FlatAppearance.CheckedBackColor = Color.IndianRed;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(239, 775);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(275, 63);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.ControlDark;
            txtTongTien.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(239, 711);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(275, 46);
            txtTongTien.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 710);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 3;
            label1.Text = "Tổng tiền";
            // 
            // UC_Bill
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
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

        #endregion

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
