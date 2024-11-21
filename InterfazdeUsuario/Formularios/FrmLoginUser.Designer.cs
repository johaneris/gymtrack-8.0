﻿namespace InterfazdeUsuario.Formularios
{
    partial class FrmLoginUser
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCifPasswordLogin = new MetroFramework.Controls.MetroTextBox();
            this.tbPasswordLogin = new MetroFramework.Controls.MetroTextBox();
            this.lbCif = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCambiarcContra2 = new System.Windows.Forms.LinkLabel();
            this.btnLoginUser = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 403);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(131, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿No tienes una cuenta?";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 38;
            this.btnCancelar.Location = new System.Drawing.Point(0, 2);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCancelar.Size = new System.Drawing.Size(74, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazdeUsuario.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(7, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lnkCambiarcContra2);
            this.panel2.Controls.Add(this.btnLoginUser);
            this.panel2.Location = new System.Drawing.Point(204, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 405);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.tbCifPasswordLogin);
            this.panel3.Controls.Add(this.tbPasswordLogin);
            this.panel3.Controls.Add(this.lbCif);
            this.panel3.Controls.Add(this.lbPassword);
            this.panel3.Location = new System.Drawing.Point(109, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 99);
            this.panel3.TabIndex = 23;
            // 
            // tbCifPasswordLogin
            // 
            // 
            // 
            // 
            this.tbCifPasswordLogin.CustomButton.Image = null;
            this.tbCifPasswordLogin.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.tbCifPasswordLogin.CustomButton.Name = "";
            this.tbCifPasswordLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCifPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCifPasswordLogin.CustomButton.TabIndex = 1;
            this.tbCifPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCifPasswordLogin.CustomButton.UseSelectable = true;
            this.tbCifPasswordLogin.CustomButton.Visible = false;
            this.tbCifPasswordLogin.Lines = new string[0];
            this.tbCifPasswordLogin.Location = new System.Drawing.Point(173, 60);
            this.tbCifPasswordLogin.MaxLength = 32767;
            this.tbCifPasswordLogin.Name = "tbCifPasswordLogin";
            this.tbCifPasswordLogin.PasswordChar = '\0';
            this.tbCifPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCifPasswordLogin.SelectedText = "";
            this.tbCifPasswordLogin.SelectionLength = 0;
            this.tbCifPasswordLogin.SelectionStart = 0;
            this.tbCifPasswordLogin.ShortcutsEnabled = true;
            this.tbCifPasswordLogin.Size = new System.Drawing.Size(187, 23);
            this.tbCifPasswordLogin.TabIndex = 18;
            this.tbCifPasswordLogin.UseSelectable = true;
            this.tbCifPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCifPasswordLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPasswordLogin
            // 
            // 
            // 
            // 
            this.tbPasswordLogin.CustomButton.Image = null;
            this.tbPasswordLogin.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.tbPasswordLogin.CustomButton.Name = "";
            this.tbPasswordLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPasswordLogin.CustomButton.TabIndex = 1;
            this.tbPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPasswordLogin.CustomButton.UseSelectable = true;
            this.tbPasswordLogin.CustomButton.Visible = false;
            this.tbPasswordLogin.Lines = new string[0];
            this.tbPasswordLogin.Location = new System.Drawing.Point(173, 13);
            this.tbPasswordLogin.MaxLength = 32767;
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '\0';
            this.tbPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPasswordLogin.SelectedText = "";
            this.tbPasswordLogin.SelectionLength = 0;
            this.tbPasswordLogin.SelectionStart = 0;
            this.tbPasswordLogin.ShortcutsEnabled = true;
            this.tbPasswordLogin.Size = new System.Drawing.Size(187, 23);
            this.tbPasswordLogin.TabIndex = 17;
            this.tbPasswordLogin.UseSelectable = true;
            this.tbPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPasswordLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbCif
            // 
            this.lbCif.AutoSize = true;
            this.lbCif.BackColor = System.Drawing.Color.Transparent;
            this.lbCif.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCif.ForeColor = System.Drawing.Color.White;
            this.lbCif.Location = new System.Drawing.Point(29, 59);
            this.lbCif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCif.Name = "lbCif";
            this.lbCif.Size = new System.Drawing.Size(142, 24);
            this.lbCif.TabIndex = 16;
            this.lbCif.Text = "CIF/Cédula:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(29, 13);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(142, 24);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Log In";
            // 
            // lnkCambiarcContra2
            // 
            this.lnkCambiarcContra2.AutoSize = true;
            this.lnkCambiarcContra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCambiarcContra2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkCambiarcContra2.Location = new System.Drawing.Point(233, 341);
            this.lnkCambiarcContra2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkCambiarcContra2.Name = "lnkCambiarcContra2";
            this.lnkCambiarcContra2.Size = new System.Drawing.Size(169, 15);
            this.lnkCambiarcContra2.TabIndex = 20;
            this.lnkCambiarcContra2.TabStop = true;
            this.lnkCambiarcContra2.Text = "¿Haz olvidado la contraseña?";
            this.lnkCambiarcContra2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCambiarcContra2_LinkClicked);
            // 
            // btnLoginUser
            // 
            this.btnLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnLoginUser.FlatAppearance.BorderSize = 0;
            this.btnLoginUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLoginUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnLoginUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnLoginUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginUser.IconSize = 38;
            this.btnLoginUser.Location = new System.Drawing.Point(94, 245);
            this.btnLoginUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginUser.Name = "btnLoginUser";
            this.btnLoginUser.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnLoginUser.Size = new System.Drawing.Size(430, 51);
            this.btnLoginUser.TabIndex = 19;
            this.btnLoginUser.Text = "       Iniciar Sesión";
            this.btnLoginUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginUser.UseVisualStyleBackColor = false;
            this.btnLoginUser.Click += new System.EventHandler(this.btnLoginUser_Click);
            // 
            // FrmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLoginUser";
            this.Text = "FrmLoginUser";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkCambiarcContra2;
        private FontAwesome.Sharp.IconButton btnLoginUser;
        private MetroFramework.Controls.MetroTextBox tbCifPasswordLogin;
        private MetroFramework.Controls.MetroTextBox tbPasswordLogin;
        private System.Windows.Forms.Label lbCif;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}