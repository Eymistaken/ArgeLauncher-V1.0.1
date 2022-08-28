namespace ArgeLauncher
{
    partial class LoginScreen
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
            this.loginButton = new Guna.UI.WinForms.GunaGradientButton();
            this.textbox1 = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.loginButton.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.FocusedColor = System.Drawing.Color.Empty;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.Location = new System.Drawing.Point(23, 346);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.loginButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 6;
            this.loginButton.Size = new System.Drawing.Size(160, 30);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "L O G I N";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.Transparent;
            this.textbox1.BaseColor = System.Drawing.Color.White;
            this.textbox1.BorderColor = System.Drawing.Color.Silver;
            this.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.FocusedBaseColor = System.Drawing.Color.White;
            this.textbox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textbox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textbox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox1.Location = new System.Drawing.Point(23, 293);
            this.textbox1.Name = "textbox1";
            this.textbox1.PasswordChar = '\0';
            this.textbox1.Radius = 6;
            this.textbox1.SelectedText = "";
            this.textbox1.Size = new System.Drawing.Size(160, 30);
            this.textbox1.TabIndex = 2;
            this.textbox1.Text = "Username";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArgeLauncher.Properties.Resources.Ekran_görüntüsü_2022_08_28_161020;
            this.pictureBox1.Location = new System.Drawing.Point(221, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::ArgeLauncher.Properties.Resources.YGT;
            this.ClientSize = new System.Drawing.Size(713, 400);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.ShowIcon = false;
            this.Text = "Arge Launcher | Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton loginButton;
        private Guna.UI.WinForms.GunaTextBox textbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}