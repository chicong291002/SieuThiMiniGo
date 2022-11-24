namespace SieuThiMini.GUI
{
    partial class QuenMatKhau
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btnHienThi
            // 
            this.btnHienThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHienThi.Image = global::SieuThiMini.Properties.Resources.confirm;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(145, 245);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(190, 48);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển Thị Mật Khẩu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(91, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông Tin Mật Khẩu";
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Image = global::SieuThiMini.Properties.Resources.exit;
            this.btnQuayVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayVe.Location = new System.Drawing.Point(340, 324);
            this.btnQuayVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(129, 49);
            this.btnQuayVe.TabIndex = 5;
            this.btnQuayVe.Text = "Quay Về";
            this.btnQuayVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(481, 384);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuayVe;
    }
}