namespace InterfazdeUsuario
{
    partial class FrmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerConsejos = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnMiembros = new FontAwesome.Sharp.IconButton();
            this.PanelEnmedio = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.btnAyuda);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnMiembros);
            this.pnlMenu.Controls.Add(this.PnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(344, 1055);
            this.pnlMenu.TabIndex = 3;
            // 
            // PnlLogo
            // 
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PnlLogo.Size = new System.Drawing.Size(344, 267);
            this.PnlLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(344, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 80);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1559, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a GymTrack -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(344, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 10);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InterfazdeUsuario.Properties.Resources.logo_uam_2;
            this.pictureBox3.Location = new System.Drawing.Point(3, 861);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnAbout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 50;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 600);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbout.Size = new System.Drawing.Size(344, 111);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "Acerca de Gymtrack";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 50;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 489);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAyuda.Size = new System.Drawing.Size(344, 111);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 50;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 378);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdmin.Size = new System.Drawing.Size(344, 111);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnMiembros
            // 
            this.btnMiembros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiembros.FlatAppearance.BorderSize = 0;
            this.btnMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiembros.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiembros.ForeColor = System.Drawing.Color.White;
            this.btnMiembros.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnMiembros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            this.btnMiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMiembros.IconSize = 50;
            this.btnMiembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.Location = new System.Drawing.Point(0, 267);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMiembros.Size = new System.Drawing.Size(344, 111);
            this.btnMiembros.TabIndex = 1;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMiembros.UseVisualStyleBackColor = true;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // PanelEnmedio
            // 
            this.PanelEnmedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.PanelEnmedio.BackgroundImage = global::InterfazdeUsuario.Properties.Resources.Red_and_Blue_Vintage_Modern_minimal_Gym_and_Fitness_Logo__1_;
            this.PanelEnmedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelEnmedio.Location = new System.Drawing.Point(344, 86);
            this.PanelEnmedio.Name = "PanelEnmedio";
            this.PanelEnmedio.Size = new System.Drawing.Size(1571, 969);
            this.PanelEnmedio.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1915, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.PanelEnmedio);
            this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnMiembros;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelEnmedio;
        private System.Windows.Forms.Timer timerConsejos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

