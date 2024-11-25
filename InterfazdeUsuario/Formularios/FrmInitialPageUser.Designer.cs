namespace InterfazdeUsuario.Formularios
{
    partial class FrmInitialPageUser
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
            this.mnInitialPageUser = new System.Windows.Forms.MenuStrip();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInitialPageUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnInitialPageUser
            // 
            this.mnInitialPageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.mnInitialPageUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnInitialPageUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem,
            this.verHorariosToolStripMenuItem,
            this.ingresarDatosToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mnInitialPageUser.Location = new System.Drawing.Point(0, 0);
            this.mnInitialPageUser.Name = "mnInitialPageUser";
            this.mnInitialPageUser.Size = new System.Drawing.Size(1067, 74);
            this.mnInitialPageUser.TabIndex = 0;
            this.mnInitialPageUser.Text = "menuStrip1";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.correoToolStripMenuItem,
            this.cifToolStripMenuItem,
            this.contraseñaToolStripMenuItem});
            this.editarPerfilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarPerfilToolStripMenuItem.Image = global::InterfazdeUsuario.Properties.Resources.reporte;
            this.editarPerfilToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarPerfilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(142, 70);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.nombreToolStripMenuItem.Text = "Nombre";
            // 
            // correoToolStripMenuItem
            // 
            this.correoToolStripMenuItem.Name = "correoToolStripMenuItem";
            this.correoToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.correoToolStripMenuItem.Text = "Correo";
            // 
            // cifToolStripMenuItem
            // 
            this.cifToolStripMenuItem.Name = "cifToolStripMenuItem";
            this.cifToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.cifToolStripMenuItem.Text = "Cif";
            // 
            // contraseñaToolStripMenuItem
            // 
            this.contraseñaToolStripMenuItem.Name = "contraseñaToolStripMenuItem";
            this.contraseñaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.contraseñaToolStripMenuItem.Text = "Contraseña";
            // 
            // verHorariosToolStripMenuItem
            // 
            this.verHorariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verHorariosToolStripMenuItem.Image = global::InterfazdeUsuario.Properties.Resources._22;
            this.verHorariosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verHorariosToolStripMenuItem.Name = "verHorariosToolStripMenuItem";
            this.verHorariosToolStripMenuItem.Size = new System.Drawing.Size(125, 70);
            this.verHorariosToolStripMenuItem.Text = "Ver Horarios";
            // 
            // ingresarDatosToolStripMenuItem
            // 
            this.ingresarDatosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ingresarDatosToolStripMenuItem.Image = global::InterfazdeUsuario.Properties.Resources.basurita;
            this.ingresarDatosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ingresarDatosToolStripMenuItem.Name = "ingresarDatosToolStripMenuItem";
            this.ingresarDatosToolStripMenuItem.Size = new System.Drawing.Size(139, 70);
            this.ingresarDatosToolStripMenuItem.Text = "Ingresar Datos";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Image = global::InterfazdeUsuario.Properties.Resources.lupita;
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(96, 70);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // FrmInitialPageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mnInitialPageUser);
            this.MainMenuStrip = this.mnInitialPageUser;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInitialPageUser";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnInitialPageUser.ResumeLayout(false);
            this.mnInitialPageUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnInitialPageUser;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñaToolStripMenuItem;
    }
}