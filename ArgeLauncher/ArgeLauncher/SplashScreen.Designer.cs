namespace ArgeLauncher
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Timer(this.components);
            this.loadingInfo = new System.Windows.Forms.Label();
            this.borderRadius = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(2, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 18);
            this.panel2.TabIndex = 1;
            // 
            // loading
            // 
            this.loading.Enabled = true;
            this.loading.Interval = 6;
            this.loading.Tick += new System.EventHandler(this.loading_Tick);
            // 
            // loadingInfo
            // 
            this.loadingInfo.AutoSize = true;
            this.loadingInfo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingInfo.ForeColor = System.Drawing.Color.White;
            this.loadingInfo.Location = new System.Drawing.Point(12, 303);
            this.loadingInfo.Name = "loadingInfo";
            this.loadingInfo.Size = new System.Drawing.Size(149, 15);
            this.loadingInfo.TabIndex = 2;
            this.loadingInfo.Text = "LAUNCHER YÜKLENİYOR...";
            // 
            // borderRadius
            // 
            this.borderRadius.TargetControl = this;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::ArgeLauncher.Properties.Resources.Adsız_tasarım;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(83, 47);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 3;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(299, 340);
            this.ControlBox = false;
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loadingInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer loading;
        private System.Windows.Forms.Label loadingInfo;
        private Guna.UI.WinForms.GunaElipse borderRadius;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}