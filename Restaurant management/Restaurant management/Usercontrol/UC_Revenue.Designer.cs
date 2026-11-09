namespace Restaurant_management.User_control
{
    partial class UC_Revenue
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
            dateTimePickerfrom = new DateTimePicker();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            BtnThoat = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dateTimePickerto = new DateTimePicker();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            BtnCapNhat = new Button();
            BtnXuaEC = new Button();
            TenBan = new DataGridViewTextBoxColumn();
            NgayTao = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerfrom
            // 
            dateTimePickerfrom.Format = DateTimePickerFormat.Short;
            dateTimePickerfrom.Location = new Point(35, 38);
            dateTimePickerfrom.Name = "dateTimePickerfrom";
            dateTimePickerfrom.Size = new Size(415, 39);
            dateTimePickerfrom.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerfrom);
            groupBox1.Location = new Point(108, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnThoat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1416, 228);
            panel1.TabIndex = 0;
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
            BtnThoat.Location = new Point(1361, 3);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(52, 47);
            BtnThoat.TabIndex = 17;
            BtnThoat.Text = "x";
            BtnThoat.UseVisualStyleBackColor = false;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(632, 109);
            label1.Name = "label1";
            label1.Size = new Size(77, 45);
            label1.TabIndex = 2;
            label1.Text = "Đến";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerto);
            groupBox2.Location = new Point(759, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dateTimePickerto
            // 
            dateTimePickerto.Format = DateTimePickerFormat.Short;
            dateTimePickerto.Location = new Point(35, 38);
            dateTimePickerto.Name = "dateTimePickerto";
            dateTimePickerto.Size = new Size(415, 39);
            dateTimePickerto.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1416, 581);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenBan, NgayTao, ThanhTien });
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1416, 539);
            dataGridView1.TabIndex = 0;
            // 
            // BtnCapNhat
            // 
            BtnCapNhat.BackColor = Color.IndianRed;
            BtnCapNhat.Cursor = Cursors.Hand;
            BtnCapNhat.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnCapNhat.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption;
            BtnCapNhat.FlatStyle = FlatStyle.Flat;
            BtnCapNhat.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnCapNhat.ForeColor = Color.White;
            BtnCapNhat.Location = new Point(1017, 232);
            BtnCapNhat.Name = "BtnCapNhat";
            BtnCapNhat.Size = new Size(227, 59);
            BtnCapNhat.TabIndex = 2;
            BtnCapNhat.Text = "Cập nhật";
            BtnCapNhat.UseVisualStyleBackColor = false;
            BtnCapNhat.Click += BtnCapNhat_Click;
            // 
            // BtnXuaEC
            // 
            BtnXuaEC.BackColor = Color.IndianRed;
            BtnXuaEC.Cursor = Cursors.Hand;
            BtnXuaEC.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            BtnXuaEC.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption;
            BtnXuaEC.FlatStyle = FlatStyle.Flat;
            BtnXuaEC.Font = new Font("Algerian", 10.125F, FontStyle.Bold);
            BtnXuaEC.ForeColor = Color.White;
            BtnXuaEC.Location = new Point(784, 232);
            BtnXuaEC.Name = "BtnXuaEC";
            BtnXuaEC.Size = new Size(227, 59);
            BtnXuaEC.TabIndex = 3;
            BtnXuaEC.Text = "Xuất excel";
            BtnXuaEC.UseVisualStyleBackColor = false;
            BtnXuaEC.Click += BtnXuaEC_Click;
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên bàn";
            TenBan.MinimumWidth = 10;
            TenBan.Name = "TenBan";
            TenBan.Width = 400;
            // 
            // NgayTao
            // 
            NgayTao.DataPropertyName = "NgayTao";
            NgayTao.HeaderText = "Ngày tạo";
            NgayTao.MinimumWidth = 10;
            NgayTao.Name = "NgayTao";
            NgayTao.Width = 400;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 10;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.Width = 500;
            // 
            // UC_Revenue
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BtnXuaEC);
            Controls.Add(BtnCapNhat);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Revenue";
            Size = new Size(1416, 875);
            Load += UC_Revenue_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerfrom;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerto;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button BtnCapNhat;
        private Button BtnThoat;
        private Button BtnXuaEC;
        private DataGridViewTextBoxColumn TenBan;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}
