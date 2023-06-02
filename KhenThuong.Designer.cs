namespace WindowsFormsApp1
{
    partial class KhenThuong
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_makhenthuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_tenkhenthuong = new System.Windows.Forms.TextBox();
            this.txt_CapBac = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.txt_Thoigian = new System.Windows.Forms.DateTimePicker();
            this.lbNgCap = new System.Windows.Forms.Label();
            this.lbCapBac = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbMHV = new System.Windows.Forms.Label();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_khenthuong = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_TK = new System.Windows.Forms.Button();
            this.txt_TimKiem_HV = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhenthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhenthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khenthuong)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.txt_makhenthuong);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_hoten);
            this.groupBox3.Controls.Add(this.txt_tenkhenthuong);
            this.groupBox3.Controls.Add(this.txt_CapBac);
            this.groupBox3.Controls.Add(this.txt_Lop);
            this.groupBox3.Controls.Add(this.lbLop);
            this.groupBox3.Controls.Add(this.txt_Thoigian);
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
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khen thưởng Học viên";
            // 
            // txt_makhenthuong
            // 
            this.txt_makhenthuong.Enabled = false;
            this.txt_makhenthuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhenthuong.Location = new System.Drawing.Point(205, 258);
            this.txt_makhenthuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_makhenthuong.MaxLength = 50;
            this.txt_makhenthuong.Name = "txt_makhenthuong";
            this.txt_makhenthuong.Size = new System.Drawing.Size(252, 32);
            this.txt_makhenthuong.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã khen thưởng:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(203, 94);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(252, 32);
            this.txt_hoten.TabIndex = 30;
            // 
            // txt_tenkhenthuong
            // 
            this.txt_tenkhenthuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkhenthuong.Location = new System.Drawing.Point(205, 312);
            this.txt_tenkhenthuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenkhenthuong.MaxLength = 50;
            this.txt_tenkhenthuong.Name = "txt_tenkhenthuong";
            this.txt_tenkhenthuong.Size = new System.Drawing.Size(252, 32);
            this.txt_tenkhenthuong.TabIndex = 29;
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
            // txt_Thoigian
            // 
            this.txt_Thoigian.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Thoigian.Location = new System.Drawing.Point(205, 371);
            this.txt_Thoigian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Thoigian.Name = "txt_Thoigian";
            this.txt_Thoigian.Size = new System.Drawing.Size(252, 32);
            this.txt_Thoigian.TabIndex = 20;
            this.txt_Thoigian.Value = new System.DateTime(2023, 5, 12, 9, 56, 26, 0);
            // 
            // lbNgCap
            // 
            this.lbNgCap.AutoSize = true;
            this.lbNgCap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNgCap.Location = new System.Drawing.Point(14, 371);
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
            this.label21.Location = new System.Drawing.Point(13, 318);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 19);
            this.label21.TabIndex = 15;
            this.label21.Text = "Tên khen thưởng:";
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
            this.txt_Ma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(203, 44);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(252, 32);
            this.txt_Ma.TabIndex = 0;
            this.txt_Ma.TextChanged += new System.EventHandler(this.txt_Ma_TextChanged);
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
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
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
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
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
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgv_khenthuong);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(892, 548);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học viên:";
            // 
            // dgv_khenthuong
            // 
            this.dgv_khenthuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khenthuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.TenHV,
            this.CapBac,
            this.Lop,
            this.tenkhenthuong,
            this.thoigian,
            this.makhenthuong});
            this.dgv_khenthuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_khenthuong.Location = new System.Drawing.Point(3, 19);
            this.dgv_khenthuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_khenthuong.Name = "dgv_khenthuong";
            this.dgv_khenthuong.RowHeadersWidth = 51;
            this.dgv_khenthuong.Size = new System.Drawing.Size(886, 525);
            this.dgv_khenthuong.TabIndex = 2;
            this.dgv_khenthuong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_khenthuong_CellMouseClick);
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
            this.groupBox1.Size = new System.Drawing.Size(635, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm học viên được khen thưởng:";
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
            this.button_TK.Click += new System.EventHandler(this.button_TK_Click);
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
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
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
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác";
            // 
            // MaHV
            // 
            this.MaHV.DataPropertyName = "Mahv";
            this.MaHV.HeaderText = "Mã HV";
            this.MaHV.MinimumWidth = 6;
            this.MaHV.Name = "MaHV";
            this.MaHV.Width = 125;
            // 
            // TenHV
            // 
            this.TenHV.DataPropertyName = "Tenhv";
            this.TenHV.HeaderText = "Tên HV";
            this.TenHV.MinimumWidth = 6;
            this.TenHV.Name = "TenHV";
            this.TenHV.Width = 150;
            // 
            // CapBac
            // 
            this.CapBac.DataPropertyName = "Quanham";
            this.CapBac.HeaderText = "Cấp bậc";
            this.CapBac.MinimumWidth = 6;
            this.CapBac.Name = "CapBac";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "TenLCN";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 125;
            // 
            // tenkhenthuong
            // 
            this.tenkhenthuong.DataPropertyName = "Khenthuong";
            this.tenkhenthuong.HeaderText = "Tên Khen thưởng";
            this.tenkhenthuong.MinimumWidth = 6;
            this.tenkhenthuong.Name = "tenkhenthuong";
            this.tenkhenthuong.Width = 125;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "Thoigian";
            this.thoigian.HeaderText = "Thời gian";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.Width = 125;
            // 
            // makhenthuong
            // 
            this.makhenthuong.DataPropertyName = "Makhenthuong";
            this.makhenthuong.HeaderText = "Mã khen thưởng";
            this.makhenthuong.MinimumWidth = 6;
            this.makhenthuong.Name = "makhenthuong";
            this.makhenthuong.Width = 125;
            // 
            // KhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 705);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhenThuong";
            this.Text = "KhenThuong";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khenthuong)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox txt_CapBac;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.DateTimePicker txt_Thoigian;
        private System.Windows.Forms.Label lbNgCap;
        private System.Windows.Forms.Label lbCapBac;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbMHV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_khenthuong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_TK;
        private System.Windows.Forms.TextBox txt_TimKiem_HV;
        private System.Windows.Forms.TextBox txt_tenkhenthuong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_makhenthuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhenthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhenthuong;
    }
}