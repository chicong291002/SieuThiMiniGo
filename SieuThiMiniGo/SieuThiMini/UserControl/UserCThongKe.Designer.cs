namespace SieuThiMini.GUI
{
    partial class UserCThongKe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbThang = new System.Windows.Forms.RadioButton();
            this.rbQuy = new System.Windows.Forms.RadioButton();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuy4 = new System.Windows.Forms.TextBox();
            this.txtQuy3 = new System.Windows.Forms.TextBox();
            this.txtQuy2 = new System.Windows.Forms.TextBox();
            this.txtQuy1 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Aqua;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(61, 478);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Money";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1081, 246);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Thống Kê Hoá Đơn";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThang.Location = new System.Drawing.Point(373, 188);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(95, 29);
            this.rbThang.TabIndex = 4;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            this.rbThang.CheckedChanged += new System.EventHandler(this.rbThang_CheckedChanged);
            // 
            // rbQuy
            // 
            this.rbQuy.AutoSize = true;
            this.rbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuy.Location = new System.Drawing.Point(743, 188);
            this.rbQuy.Name = "rbQuy";
            this.rbQuy.Size = new System.Drawing.Size(73, 29);
            this.rbQuy.TabIndex = 5;
            this.rbQuy.TabStop = true;
            this.rbQuy.Text = "Quý";
            this.rbQuy.UseVisualStyleBackColor = true;
            this.rbQuy.CheckedChanged += new System.EventHandler(this.rbQuy_CheckedChanged);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbNam.Location = new System.Drawing.Point(569, 124);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(145, 24);
            this.cbNam.TabIndex = 3;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Location = new System.Drawing.Point(84, 241);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 48);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Tháng";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MistyRose;
            this.textBox2.Location = new System.Drawing.Point(164, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 48);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Tháng 1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MistyRose;
            this.textBox3.Location = new System.Drawing.Point(321, 241);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 48);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Tháng 3";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MistyRose;
            this.textBox4.Location = new System.Drawing.Point(241, 241);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 48);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Tháng 2";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MistyRose;
            this.textBox5.Location = new System.Drawing.Point(634, 241);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 48);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Tháng 7";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.MistyRose;
            this.textBox6.Location = new System.Drawing.Point(554, 241);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 48);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Tháng 6";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MistyRose;
            this.textBox7.Location = new System.Drawing.Point(477, 241);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 48);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Tháng 5";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MistyRose;
            this.textBox8.Location = new System.Drawing.Point(397, 241);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(80, 48);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Tháng 4";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.MistyRose;
            this.textBox10.Location = new System.Drawing.Point(1023, 241);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(80, 48);
            this.textBox10.TabIndex = 18;
            this.textBox10.Text = "Tháng 12";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.MistyRose;
            this.textBox11.Location = new System.Drawing.Point(946, 241);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(80, 48);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "Tháng 11";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.MistyRose;
            this.textBox12.Location = new System.Drawing.Point(866, 241);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(80, 48);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "Tháng 10";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.MistyRose;
            this.textBox13.Location = new System.Drawing.Point(790, 241);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(80, 48);
            this.textBox13.TabIndex = 15;
            this.textBox13.Text = "Tháng 9";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.MistyRose;
            this.textBox14.Location = new System.Drawing.Point(710, 241);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(80, 48);
            this.textBox14.TabIndex = 14;
            this.textBox14.Text = "Tháng 8";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt12
            // 
            this.txt12.Location = new System.Drawing.Point(1023, 285);
            this.txt12.Multiline = true;
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(80, 48);
            this.txt12.TabIndex = 32;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(946, 285);
            this.txt11.Multiline = true;
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(80, 48);
            this.txt11.TabIndex = 31;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(866, 285);
            this.txt10.Multiline = true;
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(80, 48);
            this.txt10.TabIndex = 30;
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(790, 285);
            this.txt9.Multiline = true;
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(80, 48);
            this.txt9.TabIndex = 29;
            this.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(710, 285);
            this.txt8.Multiline = true;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(80, 48);
            this.txt8.TabIndex = 28;
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(634, 285);
            this.txt7.Multiline = true;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(80, 48);
            this.txt7.TabIndex = 27;
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(554, 285);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(80, 48);
            this.txt6.TabIndex = 26;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(477, 285);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(80, 48);
            this.txt5.TabIndex = 25;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(397, 285);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(80, 48);
            this.txt4.TabIndex = 24;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(321, 285);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(80, 48);
            this.txt3.TabIndex = 23;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(241, 285);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(80, 48);
            this.txt2.TabIndex = 22;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(164, 285);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(80, 48);
            this.txt1.TabIndex = 21;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox28.Location = new System.Drawing.Point(84, 285);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(80, 48);
            this.textBox28.TabIndex = 20;
            this.textBox28.Text = "Tổng";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Red;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(851, 61);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(314, 66);
            this.textBox9.TabIndex = 33;
            this.textBox9.Text = "Tổng Thu";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTongThu
            // 
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.Location = new System.Drawing.Point(851, 124);
            this.txtTongThu.Multiline = true;
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(314, 66);
            this.txtTongThu.TabIndex = 35;
            this.txtTongThu.Text = " 0 VNĐ";
            this.txtTongThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Chọn Năm ";
            // 
            // txtQuy4
            // 
            this.txtQuy4.Location = new System.Drawing.Point(1023, 414);
            this.txtQuy4.Multiline = true;
            this.txtQuy4.Name = "txtQuy4";
            this.txtQuy4.Size = new System.Drawing.Size(80, 48);
            this.txtQuy4.TabIndex = 46;
            this.txtQuy4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuy3
            // 
            this.txtQuy3.Location = new System.Drawing.Point(947, 414);
            this.txtQuy3.Multiline = true;
            this.txtQuy3.Name = "txtQuy3";
            this.txtQuy3.Size = new System.Drawing.Size(80, 48);
            this.txtQuy3.TabIndex = 45;
            this.txtQuy3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuy2
            // 
            this.txtQuy2.Location = new System.Drawing.Point(867, 414);
            this.txtQuy2.Multiline = true;
            this.txtQuy2.Name = "txtQuy2";
            this.txtQuy2.Size = new System.Drawing.Size(80, 48);
            this.txtQuy2.TabIndex = 44;
            this.txtQuy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuy1
            // 
            this.txtQuy1.Location = new System.Drawing.Point(790, 414);
            this.txtQuy1.Multiline = true;
            this.txtQuy1.Name = "txtQuy1";
            this.txtQuy1.Size = new System.Drawing.Size(80, 48);
            this.txtQuy1.TabIndex = 43;
            this.txtQuy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox19.Location = new System.Drawing.Point(710, 414);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(80, 48);
            this.textBox19.TabIndex = 42;
            this.textBox19.Text = "Tổng";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.MistyRose;
            this.textBox20.Location = new System.Drawing.Point(1023, 370);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(80, 48);
            this.textBox20.TabIndex = 41;
            this.textBox20.Text = "Quý 4";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.MistyRose;
            this.textBox21.Location = new System.Drawing.Point(947, 370);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(80, 48);
            this.textBox21.TabIndex = 40;
            this.textBox21.Text = "Quý 3";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.MistyRose;
            this.textBox22.Location = new System.Drawing.Point(867, 370);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(80, 48);
            this.textBox22.TabIndex = 39;
            this.textBox22.Text = "Quý 2";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.MistyRose;
            this.textBox23.Location = new System.Drawing.Point(790, 370);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(80, 48);
            this.textBox23.TabIndex = 38;
            this.textBox23.Text = "Quý 1";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.MistyRose;
            this.textBox24.Location = new System.Drawing.Point(710, 370);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(80, 48);
            this.textBox24.TabIndex = 37;
            this.textBox24.Text = "Quý";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserCThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtQuy4);
            this.Controls.Add(this.txtQuy3);
            this.Controls.Add(this.txtQuy2);
            this.Controls.Add(this.txtQuy1);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbQuy);
            this.Controls.Add(this.rbThang);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "UserCThongKe";
            this.Size = new System.Drawing.Size(1223, 801);
            this.Load += new System.EventHandler(this.UserCThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rbThang;
        private System.Windows.Forms.RadioButton rbQuy;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuy4;
        private System.Windows.Forms.TextBox txtQuy3;
        private System.Windows.Forms.TextBox txtQuy2;
        private System.Windows.Forms.TextBox txtQuy1;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
    }
}
