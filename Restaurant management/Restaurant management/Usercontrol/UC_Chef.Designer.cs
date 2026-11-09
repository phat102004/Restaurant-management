namespace Restaurant_management.User_control
{
    partial class UC_Chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chef));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnHoanThanh = new Button();
            dgvChef = new DataGridView();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtTenMon = new TextBox();
            txtSoLuong = new TextBox();
            txtTenBan = new TextBox();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvChef).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.BackColor = Color.FromArgb(37, 99, 235);
            btnHoanThanh.Cursor = Cursors.Hand;
            btnHoanThanh.FlatAppearance.BorderSize = 0;
            btnHoanThanh.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnHoanThanh.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            resources.ApplyResources(btnHoanThanh, "btnHoanThanh");
            btnHoanThanh.ForeColor = Color.White;
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.UseVisualStyleBackColor = false;
            btnHoanThanh.Click += btnHoanThanh_Click;
            // 
            // dgvChef
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvChef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChef.BackgroundColor = Color.White;
            dgvChef.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 64, 175);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChef.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChef.Columns.AddRange(new DataGridViewColumn[] { TenMon, SoLuong, TenBan });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 42, 67);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 42, 67);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChef.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChef.EnableHeadersVisualStyles = false;
            dgvChef.GridColor = Color.FromArgb(203, 213, 225);
            resources.ApplyResources(dgvChef, "dgvChef");
            dgvChef.Name = "dgvChef";
            dgvChef.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChef.CellContentClick += dgvChef_CellContentClick;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            resources.ApplyResources(TenMon, "TenMon");
            TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            resources.ApplyResources(SoLuong, "SoLuong");
            SoLuong.Name = "SoLuong";
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            resources.ApplyResources(TenBan, "TenBan");
            TenBan.Name = "TenBan";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvChef);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.White;
            label6.ForeColor = Color.FromArgb(51, 65, 85);
            label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(51, 65, 85);
            label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Name = "label2";
            // 
            // txtTenMon
            // 
            txtTenMon.BackColor = Color.FromArgb(239, 246, 255);
            txtTenMon.BorderStyle = BorderStyle.FixedSingle;
            txtTenMon.ForeColor = Color.FromArgb(16, 42, 67);
            resources.ApplyResources(txtTenMon, "txtTenMon");
            txtTenMon.Name = "txtTenMon";
            txtTenMon.ReadOnly = true;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BackColor = Color.FromArgb(239, 246, 255);
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.ForeColor = Color.FromArgb(16, 42, 67);
            resources.ApplyResources(txtSoLuong, "txtSoLuong");
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ReadOnly = true;
            // 
            // txtTenBan
            // 
            txtTenBan.BackColor = Color.FromArgb(239, 246, 255);
            txtTenBan.BorderStyle = BorderStyle.FixedSingle;
            txtTenBan.ForeColor = Color.FromArgb(16, 42, 67);
            resources.ApplyResources(txtTenBan, "txtTenBan");
            txtTenBan.Name = "txtTenBan";
            txtTenBan.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(226, 232, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(249, 190, 190);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 202, 202);
            resources.ApplyResources(btnThoat, "btnThoat");
            btnThoat.ForeColor = Color.FromArgb(51, 65, 85);
            btnThoat.Name = "btnThoat";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenMon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenBan);
            groupBox1.Controls.Add(label6);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = Color.FromArgb(30, 64, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // UC_Chef
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnHoanThanh);
            Controls.Add(panel1);
            Name = "UC_Chef";
            Load += UC_Chef_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChef).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private Button btnHoanThanh;
        private DataGridView dgvChef;
        private Panel panel1;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txtTenMon;
        private TextBox txtSoLuong;
        private TextBox txtTenBan;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TenBan;
        private Button btnThoat;
        private GroupBox groupBox1;
    }
}
