namespace InterfazdeUsuario.Formularios
{
    partial class FrmPrincipalAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnl_ContenidoAdmin = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnEntradas = new FontAwesome.Sharp.IconButton();
            this.btnGestionarmemresias = new FontAwesome.Sharp.IconButton();
            this.Btn_PerfilAdmin = new FontAwesome.Sharp.IconButton();
            this.Btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btn_minisize);
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal de Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnEntradas);
            this.panel2.Controls.Add(this.btnGestionarmemresias);
            this.panel2.Controls.Add(this.Btn_PerfilAdmin);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 715);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.lblCorreo);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.lblAdmin);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 92);
            this.panel3.TabIndex = 0;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(63, 58);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(56, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(63, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(40, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Name";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdmin.Location = new System.Drawing.Point(63, 21);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(112, 17);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Administrador";
            // 
            // pnl_ContenidoAdmin
            // 
            this.pnl_ContenidoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.pnl_ContenidoAdmin.BackgroundImage = global::InterfazdeUsuario.Properties.Resources.Red_and_Blue_Vintage_Modern_minimal_Gym_and_Fitness_Logo__1_;
            this.pnl_ContenidoAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_ContenidoAdmin.Location = new System.Drawing.Point(266, 42);
            this.pnl_ContenidoAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ContenidoAdmin.Name = "pnl_ContenidoAdmin";
            this.pnl_ContenidoAdmin.Size = new System.Drawing.Size(1266, 715);
            this.pnl_ContenidoAdmin.TabIndex = 2;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 30;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 356);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnReportes.Size = new System.Drawing.Size(267, 91);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Generar Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnEntradas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntradas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnEntradas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEntradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntradas.IconSize = 30;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Location = new System.Drawing.Point(0, 268);
            this.btnEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnEntradas.Size = new System.Drawing.Size(267, 88);
            this.btnEntradas.TabIndex = 5;
            this.btnEntradas.Text = "Gestionar Usuario";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnGestionarmemresias
            // 
            this.btnGestionarmemresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarmemresias.FlatAppearance.BorderSize = 0;
            this.btnGestionarmemresias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarmemresias.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnGestionarmemresias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarmemresias.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.btnGestionarmemresias.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarmemresias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarmemresias.IconSize = 30;
            this.btnGestionarmemresias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarmemresias.Location = new System.Drawing.Point(0, 180);
            this.btnGestionarmemresias.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionarmemresias.Name = "btnGestionarmemresias";
            this.btnGestionarmemresias.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnGestionarmemresias.Size = new System.Drawing.Size(267, 88);
            this.btnGestionarmemresias.TabIndex = 3;
            this.btnGestionarmemresias.Text = "Gestionar Membresías";
            this.btnGestionarmemresias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarmemresias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarmemresias.UseVisualStyleBackColor = true;
            this.btnGestionarmemresias.Click += new System.EventHandler(this.btnGestionarmemresias_Click);
            // 
            // Btn_PerfilAdmin
            // 
            this.Btn_PerfilAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_PerfilAdmin.FlatAppearance.BorderSize = 0;
            this.Btn_PerfilAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfilAdmin.Font = new System.Drawing.Font("Consolas", 12F);
            this.Btn_PerfilAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_PerfilAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_PerfilAdmin.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_PerfilAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_PerfilAdmin.IconSize = 30;
            this.Btn_PerfilAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PerfilAdmin.Location = new System.Drawing.Point(0, 92);
            this.Btn_PerfilAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PerfilAdmin.Name = "Btn_PerfilAdmin";
            this.Btn_PerfilAdmin.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_PerfilAdmin.Size = new System.Drawing.Size(267, 88);
            this.Btn_PerfilAdmin.TabIndex = 1;
            this.Btn_PerfilAdmin.Text = "Perfil";
            this.Btn_PerfilAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PerfilAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_PerfilAdmin.UseVisualStyleBackColor = true;
            this.Btn_PerfilAdmin.Click += new System.EventHandler(this.Btn_PerfilAdmin_Click);
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_LogOut.FlatAppearance.BorderSize = 0;
            this.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LogOut.Font = new System.Drawing.Font("Consolas", 8F);
            this.Btn_LogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.Btn_LogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_LogOut.IconSize = 30;
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 671);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(267, 44);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 92);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(1616, 4);
            this.btn_minisize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(20, 18);
            this.btn_minisize.TabIndex = 18;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_Salir.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(1644, 4);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(20, 18);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1533, 757);
            this.Controls.Add(this.pnl_ContenidoAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipalAdmin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAdmin;
        private FontAwesome.Sharp.IconButton Btn_PerfilAdmin;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private FontAwesome.Sharp.IconButton btnGestionarmemresias;
        private System.Windows.Forms.Panel pnl_ContenidoAdmin;
        private FontAwesome.Sharp.IconButton btnEntradas;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}