namespace WindowsFormsApp1
{
    partial class DieuLenh
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
            this.button_them = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_KQKT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBHYT = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cmb_hoten_HV = new System.Windows.Forms.ComboBox();
            this.txt_CapBac = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.txt_thoigian = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_TK = new System.Windows.Forms.Button();
            this.txt_TimKiem_HV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbNgCap = new System.Windows.Forms.Label();
            this.lbCapBac = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbMHV = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_them.Image = global::WindowsFormsApp1.Properties.Resources.apple_logo_24;
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(12, 57);
            this.button_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 48);
            this.button_them.TabIndex = 24;
            this.button_them.Text = "Thêm";
            this.button_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kết quả kiểm tra";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 125;
            // 
            // CapBac
            // 
            this.CapBac.HeaderText = "Cấp bậc";
            this.CapBac.MinimumWidth = 6;
            this.CapBac.Name = "CapBac";
            this.CapBac.Width = 50;
            // 
            // TenHV
            // 
            this.TenHV.HeaderText = "Tên HV";
            this.TenHV.MinimumWidth = 6;
            this.TenHV.Name = "TenHV";
            this.TenHV.Width = 150;
            // 
            // MaHV
            // 
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.MinimumWidth = 6;
            this.MaHV.Name = "MaHV";
            this.MaHV.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // cmb_KQKT
            // 
            this.cmb_KQKT.FormattingEnabled = true;
            this.cmb_KQKT.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Đạt",
            "Không đạt",
            ""});
            this.cmb_KQKT.Location = new System.Drawing.Point(203, 262);
            this.cmb_KQKT.Name = "cmb_KQKT";
            this.cmb_KQKT.Size = new System.Drawing.Size(250, 32);
            this.cmb_KQKT.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvBHYT);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(892, 548);
            this.groupBox2.TabIndex = 34;
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
            this.Lop,
            this.Column1,
            this.Column2});
            this.dgvBHYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBHYT.Location = new System.Drawing.Point(3, 19);
            this.dgvBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBHYT.Name = "dgvBHYT";
            this.dgvBHYT.RowHeadersVisible = false;
            this.dgvBHYT.RowHeadersWidth = 51;
            this.dgvBHYT.Size = new System.Drawing.Size(886, 525);
            this.dgvBHYT.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thời gian kiểm tra";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
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
            // cmb_hoten_HV
            // 
            this.cmb_hoten_HV.FormattingEnabled = true;
            this.cmb_hoten_HV.Location = new System.Drawing.Point(205, 94);
            this.cmb_hoten_HV.Name = "cmb_hoten_HV";
            this.cmb_hoten_HV.Size = new System.Drawing.Size(250, 32);
            this.cmb_hoten_HV.TabIndex = 28;
            // 
            // txt_CapBac
            // 
            this.txt_CapBac.Enabled = false;
            this.txt_CapBac.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CapBac.Location = new System.Drawing.Point(205, 199);
            this.txt_CapBac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CapBac.MaxLength = 50;
            this.txt_CapBac.Name = "txt_CapBac";
            this.txt_CapBac.Size = new System.Drawing.Size(252, 32);
            this.txt_CapBac.TabIndex = 23;
            // 
            // txt_Lop
            // 
            this.txt_Lop.Enabled = false;
            this.txt_Lop.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lop.Location = new System.Drawing.Point(204, 143);
            this.txt_Lop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Lop.MaxLength = 50;
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(252, 32);
            this.txt_Lop.TabIndex = 23;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLop.Location = new System.Drawing.Point(15, 149);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(47, 19);
            this.lbLop.TabIndex = 22;
            this.lbLop.Text = "Lớp:";
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_thoigian.Location = new System.Drawing.Point(205, 318);
            this.txt_thoigian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(252, 32);
            this.txt_thoigian.TabIndex = 20;
            this.txt_thoigian.Value = new System.DateTime(2023, 5, 12, 9, 56, 26, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox4.Controls.Add(this.button_sua);
            this.groupBox4.Controls.Add(this.button_them);
            this.groupBox4.Controls.Add(this.button_xoa);
            this.groupBox4.Controls.Add(this.button_Thoat);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(996, 497);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(523, 134);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // button_sua
            // 
            this.button_sua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_sua.Location = new System.Drawing.Point(140, 57);
            this.button_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(101, 48);
            this.button_sua.TabIndex = 26;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = false;
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_xoa.Location = new System.Drawing.Point(260, 60);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(101, 44);
            this.button_xoa.TabIndex = 25;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            // 
            // button_Thoat
            // 
            this.button_Thoat.BackColor = System.Drawing.Color.Red;
            this.button_Thoat.Location = new System.Drawing.Point(384, 58);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(104, 44);
            this.button_Thoat.TabIndex = 27;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            // 
            // button_TK
            // 
            this.button_TK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TK.Location = new System.Drawing.Point(423, 27);
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
            this.txt_TimKiem_HV.Location = new System.Drawing.Point(27, 34);
            this.txt_TimKiem_HV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem_HV.Name = "txt_TimKiem_HV";
            this.txt_TimKiem_HV.Size = new System.Drawing.Size(364, 32);
            this.txt_TimKiem_HV.TabIndex = 0;
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
            this.groupBox1.Size = new System.Drawing.Size(635, 103);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.cmb_KQKT);
            this.groupBox3.Controls.Add(this.cmb_hoten_HV);
            this.groupBox3.Controls.Add(this.txt_CapBac);
            this.groupBox3.Controls.Add(this.txt_Lop);
            this.groupBox3.Controls.Add(this.lbLop);
            this.groupBox3.Controls.Add(this.txt_thoigian);
            this.groupBox3.Controls.Add(this.lbNgCap);
            this.groupBox3.Controls.Add(this.lbCapBac);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lbHT);
            this.groupBox3.Controls.Add(this.txt_Ma);
            this.groupBox3.Controls.Add(this.lbMHV);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(996, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(523, 433);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin kiểm tra điều lệnh Học viên:";
            // 
            // lbNgCap
            // 
            this.lbNgCap.AutoSize = true;
            this.lbNgCap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNgCap.Location = new System.Drawing.Point(14, 318);
            this.lbNgCap.Name = "lbNgCap";
            this.lbNgCap.Size = new System.Drawing.Size(89, 19);
            this.lbNgCap.TabIndex = 19;
            this.lbNgCap.Text = "Thời gian:";
            // 
            // lbCapBac
            // 
            this.lbCapBac.AutoSize = true;
            this.lbCapBac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapBac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCapBac.Location = new System.Drawing.Point(13, 205);
            this.lbCapBac.Name = "lbCapBac";
            this.lbCapBac.Size = new System.Drawing.Size(79, 19);
            this.lbCapBac.TabIndex = 16;
            this.lbCapBac.Text = "Cấp bậc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(13, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 19);
            this.label21.TabIndex = 15;
            this.label21.Text = "Kết quả kiểm tra:";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHT.Location = new System.Drawing.Point(15, 100);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(67, 19);
            this.lbHT.TabIndex = 5;
            this.lbHT.Text = "Họ tên:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Enabled = false;
            this.txt_Ma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(203, 44);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(252, 32);
            this.txt_Ma.TabIndex = 0;
            // 
            // lbMHV
            // 
            this.lbMHV.AutoSize = true;
            this.lbMHV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbMHV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMHV.Location = new System.Drawing.Point(15, 50);
            this.lbMHV.Name = "lbMHV";
            this.lbMHV.Size = new System.Drawing.Size(108, 19);
            this.lbMHV.TabIndex = 5;
            this.lbMHV.Text = "Mã học viên:";
            // 
            // DieuLenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 705);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "DieuLenh";
            this.Text = "DieuLenh";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHYT)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.ComboBox cmb_KQKT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox cmb_hoten_HV;
        private System.Windows.Forms.TextBox txt_CapBac;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.DateTimePicker txt_thoigian;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_TK;
        private System.Windows.Forms.TextBox txt_TimKiem_HV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbNgCap;
        private System.Windows.Forms.Label lbCapBac;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbMHV;
    }
}