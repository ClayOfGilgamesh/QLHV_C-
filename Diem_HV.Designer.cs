namespace WindowsFormsApp1
{
    partial class Diem_HV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBHYT = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_TK = new System.Windows.Forms.Button();
            this.txt_TimKiem_HV = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.button_CapNhatDiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_CapBac = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbCapBac = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbMHV = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtGV_GioLam = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_GioLam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvBHYT);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(490, 548);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học viên:";
            // 
            // dgvBHYT
            // 
            this.dgvBHYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHV,
            this.TenHV,
            this.CapBac,
            this.Lop});
            this.dgvBHYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBHYT.Location = new System.Drawing.Point(3, 19);
            this.dgvBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBHYT.Name = "dgvBHYT";
            this.dgvBHYT.RowHeadersVisible = false;
            this.dgvBHYT.RowHeadersWidth = 51;
            this.dgvBHYT.Size = new System.Drawing.Size(484, 525);
            this.dgvBHYT.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // MaHV
            // 
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.MinimumWidth = 6;
            this.MaHV.Name = "MaHV";
            this.MaHV.Width = 125;
            // 
            // TenHV
            // 
            this.TenHV.HeaderText = "Tên HV";
            this.TenHV.MinimumWidth = 6;
            this.TenHV.Name = "TenHV";
            this.TenHV.Width = 150;
            // 
            // CapBac
            // 
            this.CapBac.HeaderText = "Cấp bậc";
            this.CapBac.MinimumWidth = 6;
            this.CapBac.Name = "CapBac";
            this.CapBac.Width = 50;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 125;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, -145);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(1013, 113);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(488, 69);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(175, 30);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Nhà cung cấp";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(271, 69);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(180, 30);
            this.checkBox5.TabIndex = 2;
            this.checkBox5.Text = "Tên sản phẩm";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(75, 69);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(169, 30);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Mã sản phẩm";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(39, 25);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(713, 32);
            this.textBox9.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button_TK);
            this.groupBox1.Controls.Add(this.txt_TimKiem_HV);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(490, 103);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm học viên:";
            // 
            // button_TK
            // 
            this.button_TK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TK.Location = new System.Drawing.Point(319, 40);
            this.button_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_TK.Name = "button_TK";
            this.button_TK.Size = new System.Drawing.Size(163, 46);
            this.button_TK.TabIndex = 7;
            this.button_TK.Text = "Tìm kiếm";
            this.button_TK.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem_HV
            // 
            this.txt_TimKiem_HV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem_HV.Location = new System.Drawing.Point(8, 46);
            this.txt_TimKiem_HV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_HV.Name = "txt_TimKiem_HV";
            this.txt_TimKiem_HV.Size = new System.Drawing.Size(304, 32);
            this.txt_TimKiem_HV.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txt_DiemTB);
            this.groupBox3.Controls.Add(this.button_CapNhatDiem);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.txt_CapBac);
            this.groupBox3.Controls.Add(this.txt_Lop);
            this.groupBox3.Controls.Add(this.lbLop);
            this.groupBox3.Controls.Add(this.lbCapBac);
            this.groupBox3.Controls.Add(this.lbHT);
            this.groupBox3.Controls.Add(this.txt_Ma);
            this.groupBox3.Controls.Add(this.lbMHV);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(526, 156);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(437, 532);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin Học viên:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(325, 463);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 48);
            this.button3.TabIndex = 40;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 318);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 32);
            this.textBox1.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 48);
            this.button1.TabIndex = 38;
            this.button1.Text = "Xóa ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemTB.Location = new System.Drawing.Point(182, 378);
            this.txt_DiemTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiemTB.MaxLength = 50;
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(219, 32);
            this.txt_DiemTB.TabIndex = 37;
            // 
            // button_CapNhatDiem
            // 
            this.button_CapNhatDiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_CapNhatDiem.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhatDiem.Location = new System.Drawing.Point(107, 463);
            this.button_CapNhatDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CapNhatDiem.Name = "button_CapNhatDiem";
            this.button_CapNhatDiem.Size = new System.Drawing.Size(107, 48);
            this.button_CapNhatDiem.TabIndex = 35;
            this.button_CapNhatDiem.Text = "Cập nhật";
            this.button_CapNhatDiem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Học kỳ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(33, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Điểm TB:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 32);
            this.textBox2.TabIndex = 24;
            // 
            // txt_CapBac
            // 
            this.txt_CapBac.Enabled = false;
            this.txt_CapBac.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CapBac.Location = new System.Drawing.Point(184, 255);
            this.txt_CapBac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CapBac.MaxLength = 50;
            this.txt_CapBac.Name = "txt_CapBac";
            this.txt_CapBac.Size = new System.Drawing.Size(217, 32);
            this.txt_CapBac.TabIndex = 23;
            // 
            // txt_Lop
            // 
            this.txt_Lop.Enabled = false;
            this.txt_Lop.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lop.Location = new System.Drawing.Point(183, 199);
            this.txt_Lop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Lop.MaxLength = 50;
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(218, 32);
            this.txt_Lop.TabIndex = 23;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLop.Location = new System.Drawing.Point(34, 205);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(47, 19);
            this.lbLop.TabIndex = 22;
            this.lbLop.Text = "Lớp:";
            // 
            // lbCapBac
            // 
            this.lbCapBac.AutoSize = true;
            this.lbCapBac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapBac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCapBac.Location = new System.Drawing.Point(32, 261);
            this.lbCapBac.Name = "lbCapBac";
            this.lbCapBac.Size = new System.Drawing.Size(79, 19);
            this.lbCapBac.TabIndex = 16;
            this.lbCapBac.Text = "Cấp bậc:";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHT.Location = new System.Drawing.Point(34, 156);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(67, 19);
            this.lbHT.TabIndex = 5;
            this.lbHT.Text = "Họ tên:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Enabled = false;
            this.txt_Ma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(182, 100);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(219, 32);
            this.txt_Ma.TabIndex = 0;
            // 
            // lbMHV
            // 
            this.lbMHV.AutoSize = true;
            this.lbMHV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbMHV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMHV.Location = new System.Drawing.Point(34, 106);
            this.lbMHV.Name = "lbMHV";
            this.lbMHV.Size = new System.Drawing.Size(108, 19);
            this.lbMHV.TabIndex = 5;
            this.lbMHV.Text = "Mã học viên:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtGV_GioLam);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(970, 80);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(545, 608);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi tiết Điểm:";
            // 
            // dtGV_GioLam
            // 
            this.dtGV_GioLam.AllowUserToAddRows = false;
            this.dtGV_GioLam.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGV_GioLam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV_GioLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_GioLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.d,
            this.Column1,
            this.Column12});
            this.dtGV_GioLam.Location = new System.Drawing.Point(8, 23);
            this.dtGV_GioLam.Margin = new System.Windows.Forms.Padding(4);
            this.dtGV_GioLam.Name = "dtGV_GioLam";
            this.dtGV_GioLam.RowHeadersWidth = 51;
            this.dtGV_GioLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_GioLam.Size = new System.Drawing.Size(521, 575);
            this.dtGV_GioLam.TabIndex = 13;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Học kỳ";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 120;
            // 
            // d
            // 
            this.d.HeaderText = "Năm ";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NGAY_LAM";
            this.Column12.HeaderText = "Điểm trung bình";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Diem_HV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 705);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Diem_HV";
            this.Text = "Diem";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_GioLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBHYT;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_TK;
        private System.Windows.Forms.TextBox txt_TimKiem_HV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_CapBac;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbCapBac;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbMHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtGV_GioLam;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Button button_CapNhatDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}