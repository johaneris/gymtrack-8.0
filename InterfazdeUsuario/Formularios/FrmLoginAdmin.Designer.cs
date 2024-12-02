namespace InterfazdeUsuario.Formularios
{
    partial class FrmLoginAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUser = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbPassword = new MetroFramework.Controls.MetroTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel1.BackgroundImage = global::InterfazdeUsuario.Properties.Resources.Red_and_Blue_Vintage_Modern_minimal_Gym_and_Fitness_Logo__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.tbUser);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(247, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 503);
            this.panel2.TabIndex = 1;
            // 
            // tbUser
            // 
            // 
            // 
            // 
            this.tbUser.CustomButton.Image = null;
            this.tbUser.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.tbUser.CustomButton.Name = "";
            this.tbUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUser.CustomButton.TabIndex = 1;
            this.tbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUser.CustomButton.UseSelectable = true;
            this.tbUser.CustomButton.Visible = false;
            this.tbUser.Lines = new string[0];
            this.tbUser.Location = new System.Drawing.Point(270, 152);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(287, 23);
            this.tbUser.TabIndex = 3;
            this.tbUser.UseSelectable = true;
            this.tbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 38;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(109, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogin.Size = new System.Drawing.Size(478, 63);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.TbPassword);
            this.panel3.Location = new System.Drawing.Point(109, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 145);
            this.panel3.TabIndex = 7;
            // 
            // TbPassword
            // 
            // 
            // 
            // 
            this.TbPassword.CustomButton.Image = null;
            this.TbPassword.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.TbPassword.CustomButton.Name = "";
            this.TbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TbPassword.CustomButton.TabIndex = 1;
            this.TbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TbPassword.CustomButton.UseSelectable = true;
            this.TbPassword.CustomButton.Visible = false;
            this.TbPassword.Lines = new string[0];
            this.TbPassword.Location = new System.Drawing.Point(161, 82);
            this.TbPassword.MaxLength = 32767;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbPassword.SelectedText = "";
            this.TbPassword.SelectionLength = 0;
            this.TbPassword.SelectionStart = 0;
            this.TbPassword.ShortcutsEnabled = true;
            this.TbPassword.Size = new System.Drawing.Size(287, 23);
            this.TbPassword.TabIndex = 4;
            this.TbPassword.UseSelectable = true;
            this.TbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(247, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(689, 74);
            this.panel5.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log In";
            // 
            // FrmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::InterfazdeUsuario.Properties.Resources.Screenshot_2024_11_10_175550;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(936, 583);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResetPassword";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "AdminForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TbPassword;
        private MetroFramework.Controls.MetroTextBox tbUser;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}