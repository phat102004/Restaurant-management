namespace Restaurant_management
{
    partial class FormAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            panelContainer = new Panel();
            btnThoat = new Button();
            panel2 = new Panel();
            BtnDangXuat = new Button();
            BtnAccount = new Button();
            pictureBox2 = new PictureBox();
            BtnIngredient = new Button();
            btnRevenue = new Button();
            btnEmployee = new Button();
            btnBill = new Button();
            btnFood = new Button();
            btnTable = new Button();
            btnHome = new Button();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContainer);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1862, 875);
            panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(btnThoat);
            panelContainer.Dock = DockStyle.Right;
            panelContainer.Location = new Point(446, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1416, 875);
            panelContainer.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Tahoma", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(1364, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(52, 47);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "x";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(BtnDangXuat);
            panel2.Controls.Add(BtnAccount);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BtnIngredient);
            panel2.Controls.Add(btnRevenue);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnBill);
            panel2.Controls.Add(btnFood);
            panel2.Controls.Add(btnTable);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 875);
            panel2.TabIndex = 3;
            // 
            // BtnDangXuat
            // 
            BtnDangXuat.BackColor = Color.Gray;
            BtnDangXuat.Font = new Font("Algerian", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDangXuat.Location = new Point(-3, 800);
            BtnDangXuat.Name = "BtnDangXuat";
            BtnDangXuat.Size = new Size(445, 65);
            BtnDangXuat.TabIndex = 11;
            BtnDangXuat.Text = "Đăng xuất";
            BtnDangXuat.UseVisualStyleBackColor = false;
            BtnDangXuat.Click += BtnDangXuat_Click;
            // 
            // BtnAccount
            // 
            BtnAccount.BackColor = Color.IndianRed;
            BtnAccount.Cursor = Cursors.Hand;
            BtnAccount.FlatAppearance.BorderSize = 0;
            BtnAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            BtnAccount.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnAccount.FlatStyle = FlatStyle.Flat;
            BtnAccount.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            BtnAccount.ForeColor = Color.White;
            BtnAccount.Location = new Point(-2, 626);
            BtnAccount.Name = "BtnAccount";
            BtnAccount.Size = new Size(442, 52);
            BtnAccount.TabIndex = 10;
            BtnAccount.Text = "Tài khoản";
            BtnAccount.UseVisualStyleBackColor = false;
            BtnAccount.Click += BtnAccount_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(439, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BtnIngredient
            // 
            BtnIngredient.BackColor = Color.IndianRed;
            BtnIngredient.Cursor = Cursors.Hand;
            BtnIngredient.FlatAppearance.BorderSize = 0;
            BtnIngredient.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            BtnIngredient.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BtnIngredient.FlatStyle = FlatStyle.Flat;
            BtnIngredient.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            BtnIngredient.ForeColor = Color.White;
            BtnIngredient.Location = new Point(-3, 568);
            BtnIngredient.Name = "BtnIngredient";
            BtnIngredient.Size = new Size(442, 52);
            BtnIngredient.TabIndex = 9;
            BtnIngredient.Text = "Nguyên liệu";
            BtnIngredient.UseVisualStyleBackColor = false;
            BtnIngredient.Click += BtnIngredient_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = Color.IndianRed;
            btnRevenue.Cursor = Cursors.Hand;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnRevenue.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnRevenue.ForeColor = Color.White;
            btnRevenue.Location = new Point(-3, 510);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(442, 52);
            btnRevenue.TabIndex = 6;
            btnRevenue.Text = "Doanh thu";
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.IndianRed;
            btnEmployee.Cursor = Cursors.Hand;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnEmployee.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(-3, 452);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(442, 52);
            btnEmployee.TabIndex = 5;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.IndianRed;
            btnBill.Cursor = Cursors.Hand;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnBill.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnBill.ForeColor = Color.White;
            btnBill.Location = new Point(-2, 394);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(442, 52);
            btnBill.TabIndex = 4;
            btnBill.Text = "Thanh toán";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // btnFood
            // 
            btnFood.BackColor = Color.IndianRed;
            btnFood.Cursor = Cursors.Hand;
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnFood.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnFood.ForeColor = Color.White;
            btnFood.Location = new Point(-3, 278);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(442, 52);
            btnFood.TabIndex = 2;
            btnFood.Text = "Thực đơn";
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += btnFood_Click;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.IndianRed;
            btnTable.Cursor = Cursors.Hand;
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnTable.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnTable.ForeColor = Color.White;
            btnTable.Location = new Point(-2, 336);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(442, 52);
            btnTable.TabIndex = 3;
            btnTable.Text = "Bàn";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.IndianRed;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnHome.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Algerian", 10.875F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(-3, 220);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(442, 52);
            btnHome.TabIndex = 1;
            btnHome.Text = "Trạng thái món";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1865, 877);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            panel1.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnIngredient;
        private Button btnRevenue;
        private Button btnEmployee;
        private Button btnBill;
        private Button btnTable;
        private Panel panelContainer;
        private PictureBox pictureBox2;
        private Button btnFood;
        private Button BtnAccount;
        private Button btnThoat;
        private Button BtnDangXuat;
        private Button btnHome;
    }
}