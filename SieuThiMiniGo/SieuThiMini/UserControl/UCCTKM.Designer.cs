namespace SieuThiMini
{
    partial class UCCTKM
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_CTCTKM = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSua_CT = new System.Windows.Forms.Button();
            this.btnXoa_CT = new System.Windows.Forms.Button();
            this.btnThem_CT = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaCT_CT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.dgvCTKM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTCTKM)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvCTKM);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1227, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dgv_CTCTKM);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(665, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 763);
            this.panel1.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(451, 32);
            this.label15.TabIndex = 18;
            this.label15.Text = "Chi tiết chương trình khuyến mãi";
            // 
            // dgv_CTCTKM
            // 
            this.dgv_CTCTKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTCTKM.Location = new System.Drawing.Point(12, 402);
            this.dgv_CTCTKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_CTCTKM.Name = "dgv_CTCTKM";
            this.dgv_CTCTKM.RowHeadersWidth = 51;
            this.dgv_CTCTKM.RowTemplate.Height = 24;
            this.dgv_CTCTKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CTCTKM.Size = new System.Drawing.Size(506, 336);
            this.dgv_CTCTKM.TabIndex = 17;
            this.dgv_CTCTKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTCTKM_CellClick_1);
            this.dgv_CTCTKM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTCTKM_CellContentClick_1);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Cyan;
            this.groupBox6.Controls.Add(this.btnSua_CT);
            this.groupBox6.Controls.Add(this.btnXoa_CT);
            this.groupBox6.Controls.Add(this.btnThem_CT);
            this.groupBox6.Location = new System.Drawing.Point(12, 249);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(506, 106);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tác Vụ";
            // 
            // btnSua_CT
            // 
            this.btnSua_CT.Image = global::SieuThiMini.Properties.Resources.update1;
            this.btnSua_CT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_CT.Location = new System.Drawing.Point(367, 30);
            this.btnSua_CT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua_CT.Name = "btnSua_CT";
            this.btnSua_CT.Size = new System.Drawing.Size(113, 48);
            this.btnSua_CT.TabIndex = 10;
            this.btnSua_CT.Text = "Sửa";
            this.btnSua_CT.UseVisualStyleBackColor = true;
            this.btnSua_CT.Click += new System.EventHandler(this.btnSua_CT_Click);
            // 
            // btnXoa_CT
            // 
            this.btnXoa_CT.Image = global::SieuThiMini.Properties.Resources.delete1;
            this.btnXoa_CT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_CT.Location = new System.Drawing.Point(201, 30);
            this.btnXoa_CT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa_CT.Name = "btnXoa_CT";
            this.btnXoa_CT.Size = new System.Drawing.Size(115, 48);
            this.btnXoa_CT.TabIndex = 11;
            this.btnXoa_CT.Text = "Xóa";
            this.btnXoa_CT.UseVisualStyleBackColor = true;
            this.btnXoa_CT.Click += new System.EventHandler(this.btnXoa_CT_Click);
            // 
            // btnThem_CT
            // 
            this.btnThem_CT.Image = global::SieuThiMini.Properties.Resources.add11;
            this.btnThem_CT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_CT.Location = new System.Drawing.Point(29, 30);
            this.btnThem_CT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem_CT.Name = "btnThem_CT";
            this.btnThem_CT.Size = new System.Drawing.Size(125, 48);
            this.btnThem_CT.TabIndex = 8;
            this.btnThem_CT.Text = "Thêm";
            this.btnThem_CT.UseVisualStyleBackColor = true;
            this.btnThem_CT.Click += new System.EventHandler(this.btnThem_CT_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtMaCT_CT);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtPhanTram);
            this.groupBox5.Location = new System.Drawing.Point(3, 89);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(515, 153);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin CT_Chương Trình Khuyến Mãi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã chương trình";
            // 
            // txtMaCT_CT
            // 
            this.txtMaCT_CT.Location = new System.Drawing.Point(229, 30);
            this.txtMaCT_CT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCT_CT.Name = "txtMaCT_CT";
            this.txtMaCT_CT.Size = new System.Drawing.Size(206, 27);
            this.txtMaCT_CT.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "% khuyến mãi";
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(229, 85);
            this.txtPhanTram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(206, 27);
            this.txtPhanTram.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(3, 343);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(636, 86);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác Vụ";
            // 
            // button1
            // 
            this.button1.Image = global::SieuThiMini.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(507, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 52);
            this.button1.TabIndex = 31;
            this.button1.Text = "Thoát";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::SieuThiMini.Properties.Resources.add2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(46, 19);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 52);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::SieuThiMini.Properties.Resources.service;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(210, 19);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 52);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::SieuThiMini.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(364, 19);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 58);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtNgayBatDau);
            this.groupBox1.Controls.Add(this.dtNgayKetThuc);
            this.groupBox1.Controls.Add(this.txtTenCT);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(5, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(634, 209);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chương Trình Khuyến Mãi";
            // 
            // btnKH
            // 
            this.btnKH.Location = new System.Drawing.Point(339, 155);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(62, 32);
            this.btnKH.TabIndex = 35;
            this.btnKH.Text = "...";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã chương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày kết thúc";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(152, 160);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(166, 27);
            this.txtMaKH.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên chương trình";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(469, 34);
            this.dtNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(135, 27);
            this.dtNgayBatDau.TabIndex = 22;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(469, 99);
            this.dtNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(135, 27);
            this.dtNgayKetThuc.TabIndex = 23;
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(152, 99);
            this.txtTenCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(166, 27);
            this.txtTenCT.TabIndex = 25;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(152, 36);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(166, 27);
            this.txtMaCT.TabIndex = 24;
            // 
            // dgvCTKM
            // 
            this.dgvCTKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTKM.Location = new System.Drawing.Point(5, 454);
            this.dgvCTKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTKM.Name = "dgvCTKM";
            this.dgvCTKM.RowHeadersWidth = 51;
            this.dgvCTKM.RowTemplate.Height = 24;
            this.dgvCTKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTKM.Size = new System.Drawing.Size(634, 284);
            this.dgvCTKM.TabIndex = 31;
            this.dgvCTKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTKM_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông tin chương trình khuyến mãi";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1235, 801);
            this.tabControl1.TabIndex = 0;
            // 
            // UCCTKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCTKM";
            this.Size = new System.Drawing.Size(1236, 801);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTCTKM)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_CTCTKM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSua_CT;
        private System.Windows.Forms.Button btnXoa_CT;
        private System.Windows.Forms.Button btnThem_CT;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaCT_CT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.DataGridView dgvCTKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKH;
    }
}
