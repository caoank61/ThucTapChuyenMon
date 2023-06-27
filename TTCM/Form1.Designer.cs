namespace TTCM
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbshowpw = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtusn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshowpw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTCM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbshowpw
            // 
            this.pbshowpw.Image = global::TTCM.Properties.Resources.kisspng_computer_icons_eye_symbol_closed_eyes_5b15225f13fe02_6491661415281117110819;
            this.pbshowpw.Location = new System.Drawing.Point(643, 306);
            this.pbshowpw.Name = "pbshowpw";
            this.pbshowpw.Size = new System.Drawing.Size(22, 22);
            this.pbshowpw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshowpw.TabIndex = 12;
            this.pbshowpw.TabStop = false;
            this.pbshowpw.Click += new System.EventHandler(this.pbshowpw_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TTCM.Properties.Resources.kisspng_computer_icons_password_portable_network_graphics_password_icon_png_vector_clipart_psd_peoplepng_5d1a0c162a3bb6_448618291561988118173__1_;
            this.pictureBox3.Location = new System.Drawing.Point(345, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TTCM.Properties.Resources._Pngtree_user_login_or_authenticate_icon_5056093_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(345, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(180)))), ((int)(((byte)(224)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(455, 380);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(130, 30);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(396, 306);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(250, 22);
            this.txtpw.TabIndex = 8;
            // 
            // txtusn
            // 
            this.txtusn.Location = new System.Drawing.Point(396, 253);
            this.txtusn.Name = "txtusn";
            this.txtusn.Size = new System.Drawing.Size(250, 22);
            this.txtusn.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.pbshowpw);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtusn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbshowpw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbshowpw;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtusn;
    }
}

