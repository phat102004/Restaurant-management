namespace Restaurant_management.User_control
{
    partial class UC_Order
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
            cbxTenMon = new ComboBox();
            BtnThemMon = new Button();
            BtnCheBien = new Button();
            panel5 = new Panel();
            BtnThoat = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbxTenBan = new ComboBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbxTenLoai = new ComboBox();
            splitter1 = new Splitter();
            panel6 = new Panel();
            Dgv_Oder = new DataGridView();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            panel_UC_Order = new Panel();
            panel2 = new Panel();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Oder).BeginInit();
            panel_UC_Order.SuspendLayout();
            SuspendLayout();
            // 
            // cbxTenMon
            // 
            cbxTenMon.Font = new Font("Tahoma", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTenMon.FormattingEnabled = true;
            cbxTenMon.Location = new Point(596, 48);
            cbxTenMon.Name = "cbxTenMon";
            cbxTenMon.Size = new Size(251, 33);
            cbxTenMon.TabIndex = 2;
            // 
            // BtnThemMon
            // 
            BtnThemMon.BackColor = Color.IndianRed;
            BtnThemMon.Cursor = Cursors.Hand;
            BtnThemMon.FlatStyle = FlatStyle.Flat;
            BtnThemMon.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnThemMon.ForeColor = Color.White;
            BtnThemMon.Location = new Point(311, 38);
            BtnThemMon.Name = "BtnThemMon";
            BtnThemMon.Size = new Size(251, 62);
            BtnThemMon.TabIndex = 4;
            BtnThemMon.Text = "Thêm món";
            BtnThemMon.UseVisualStyleBackColor = false;
            BtnThemMon.Click += BtnThemMon_Click;
            // 
            // BtnCheBien
            // 
            BtnCheBien.BackColor = Color.IndianRed;
            BtnCheBien.Cursor = Cursors.Hand;
            BtnCheBien.FlatStyle = FlatStyle.Flat;
            BtnCheBien.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnCheBien.ForeColor = Color.White;
            BtnCheBien.Location = new Point(63, 38);
            BtnCheBien.Name = "BtnCheBien";
            BtnCheBien.Size = new Size(251, 62);
            BtnCheBien.TabIndex = 9;
            BtnCheBien.Text = "Báo chế biên";
            BtnCheBien.UseVisualStyleBackColor = false;
            BtnCheBien.Click += BtnCheBien_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(BtnThoat);
            panel5.Controls.Add(groupBox2);
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(splitter1);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(17, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1413, 873);
            panel5.TabIndex = 0;
            // 
            // BtnThoat
            // 
            BtnThoat.BackColor = Color.IndianRed;
            BtnThoat.Cursor = Cursors.Hand;
            BtnThoat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnThoat.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            BtnThoat.FlatStyle = FlatStyle.Flat;
            BtnThoat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnThoat.ForeColor = Color.White;
            BtnThoat.Location = new Point(1346, 3);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(52, 47);
            BtnThoat.TabIndex = 16;
            BtnThoat.Text = "x";
            BtnThoat.UseVisualStyleBackColor = false;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnThemMon);
            groupBox2.Controls.Add(BtnCheBien);
            groupBox2.Location = new Point(335, 693);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(618, 127);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbxTenBan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbxTenMon);
            groupBox1.Controls.Add(cbxTenLoai);
            groupBox1.Location = new Point(145, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 156);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(475, 95);
            label6.Name = "label6";
            label6.Size = new Size(61, 29);
            label6.TabIndex = 13;
            label6.Text = "Bàn:";
            // 
            // cbxTenBan
            // 
            cbxTenBan.FormattingEnabled = true;
            cbxTenBan.Location = new Point(596, 90);
            cbxTenBan.Name = "cbxTenBan";
            cbxTenBan.Size = new Size(251, 40);
            cbxTenBan.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(475, 48);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 0;
            label3.Text = "Tên món:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(152, 87);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(73, 39);
            txtSoLuong.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(39, 95);
            label4.Name = "label4";
            label4.Size = new Size(115, 29);
            label4.TabIndex = 0;
            label4.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(39, 48);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 0;
            label5.Text = "Tên loại:";
            // 
            // cbxTenLoai
            // 
            cbxTenLoai.Font = new Font("Tahoma", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTenLoai.FormattingEnabled = true;
            cbxTenLoai.Location = new Point(152, 48);
            cbxTenLoai.Name = "cbxTenLoai";
            cbxTenLoai.Size = new Size(251, 33);
            cbxTenLoai.TabIndex = 2;
            cbxTenLoai.SelectedIndexChanged += CbxTenLoai_SelectedIndexChanged;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.ActiveCaptionText;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(5, 873);
            splitter1.TabIndex = 10;
            splitter1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Dgv_Oder);
            panel6.Location = new Point(145, 183);
            panel6.Name = "panel6";
            panel6.Size = new Size(1049, 486);
            panel6.TabIndex = 5;
            // 
            // Dgv_Oder
            // 
            Dgv_Oder.AllowUserToAddRows = false;
            Dgv_Oder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Oder.Columns.AddRange(new DataGridViewColumn[] { TenMon, SoLuong, TenBan });
            Dgv_Oder.Location = new Point(48, 32);
            Dgv_Oder.Name = "Dgv_Oder";
            Dgv_Oder.RowHeadersVisible = false;
            Dgv_Oder.RowHeadersWidth = 82;
            Dgv_Oder.Size = new Size(973, 427);
            Dgv_Oder.TabIndex = 0;
            Dgv_Oder.CellContentClick += Dgv_Oder_CellContentClick;
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
            SoLuong.Width = 300;
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên bàn";
            TenBan.MinimumWidth = 10;
            TenBan.Name = "TenBan";
            TenBan.Width = 270;
            // 
            // panel_UC_Order
            // 
            panel_UC_Order.BackColor = Color.White;
            panel_UC_Order.Controls.Add(panel2);
            panel_UC_Order.Location = new Point(3, 3);
            panel_UC_Order.Name = "panel_UC_Order";
            panel_UC_Order.Size = new Size(1427, 861);
            panel_UC_Order.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 875);
            panel2.TabIndex = 0;
            // 
            // UC_Order
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel_UC_Order);
            Name = "UC_Order";
            Size = new Size(1430, 876);
            Load += UC_Menu_Load;
            panel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_Oder).EndInit();
            panel_UC_Order.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbxTenMon;
        private Button BtnThemMon;
        private Panel panel5;
        private Panel panel6;
        private Panel panel_UC_Order;
        private DataGridView Dgv_Oder;
        private Splitter splitter1;
        private Button BtnCheBien;
        private Label label4;
        private Label label3;
        private ComboBox cbxTenLoai;
        private Label label5;
        private TextBox txtSoLuong;
        private Panel panel2;
        private Label label6;
        private ComboBox cbxTenBan;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button BtnThoat;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenBan;
    }
}
