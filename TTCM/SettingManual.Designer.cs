namespace TTCM
{
    partial class SettingManual
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
            this.lb_thanhpho = new System.Windows.Forms.Label();
            this.lb_nhietdo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_thanhpho
            // 
            this.lb_thanhpho.AutoSize = true;
            this.lb_thanhpho.Location = new System.Drawing.Point(106, 30);
            this.lb_thanhpho.Name = "lb_thanhpho";
            this.lb_thanhpho.Size = new System.Drawing.Size(72, 16);
            this.lb_thanhpho.TabIndex = 0;
            this.lb_thanhpho.Text = "Thành Phố";
            // 
            // lb_nhietdo
            // 
            this.lb_nhietdo.AutoSize = true;
            this.lb_nhietdo.Location = new System.Drawing.Point(109, 69);
            this.lb_nhietdo.Name = "lb_nhietdo";
            this.lb_nhietdo.Size = new System.Drawing.Size(16, 16);
            this.lb_nhietdo.TabIndex = 1;
            this.lb_nhietdo.Text = "C";
            // 
            // SettingManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.lb_nhietdo);
            this.Controls.Add(this.lb_thanhpho);
            this.Name = "SettingManual";
            this.Text = "SettingManual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thanhpho;
        private System.Windows.Forms.Label lb_nhietdo;
    }
}