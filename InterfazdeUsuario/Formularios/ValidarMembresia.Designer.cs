namespace InterfazdeUsuario.Formularios
{
    partial class ValidarMembresia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.cmbMonto = new System.Windows.Forms.ComboBox();
            this.cmbDuracion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.tbFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistarMembresia = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.panelMain.Controls.Add(this.cmbMonto);
            this.panelMain.Controls.Add(this.cmbDuracion);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.tbReferencia);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.dtpFechaPago);
            this.panelMain.Controls.Add(this.tbFactura);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.btnRegistarMembresia);
            this.panelMain.Location = new System.Drawing.Point(329, 76);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(861, 630);
            this.panelMain.TabIndex = 1;
            // 
            // cmbMonto
            // 
            this.cmbMonto.FormattingEnabled = true;
            this.cmbMonto.Location = new System.Drawing.Point(412, 160);
            this.cmbMonto.Name = "cmbMonto";
            this.cmbMonto.Size = new System.Drawing.Size(324, 24);
            this.cmbMonto.TabIndex = 1;
            this.cmbMonto.SelectedIndexChanged += new System.EventHandler(this.cmbMonto_SelectedIndexChanged);
            // 
            // cmbDuracion
            // 
            this.cmbDuracion.FormattingEnabled = true;
            this.cmbDuracion.Location = new System.Drawing.Point(412, 232);
            this.cmbDuracion.Name = "cmbDuracion";
            this.cmbDuracion.Size = new System.Drawing.Size(324, 24);
            this.cmbDuracion.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(405, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 27);
            this.label10.TabIndex = 62;
            this.label10.Text = "Monto Pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(406, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 27);
            this.label7.TabIndex = 60;
            this.label7.Text = "Duración de membresía";
            // 
            // tbReferencia
            // 
            this.tbReferencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReferencia.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReferencia.ForeColor = System.Drawing.Color.Black;
            this.tbReferencia.Location = new System.Drawing.Point(47, 220);
            this.tbReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(325, 32);
            this.tbReferencia.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 27);
            this.label9.TabIndex = 58;
            this.label9.Text = "Referencia";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(46, 287);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(326, 22);
            this.dtpFechaPago.TabIndex = 4;
            // 
            // tbFactura
            // 
            this.tbFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFactura.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFactura.ForeColor = System.Drawing.Color.Black;
            this.tbFactura.Location = new System.Drawing.Point(44, 156);
            this.tbFactura.Margin = new System.Windows.Forms.Padding(4);
            this.tbFactura.Name = "tbFactura";
            this.tbFactura.Size = new System.Drawing.Size(325, 32);
            this.tbFactura.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 27);
            this.label8.TabIndex = 55;
            this.label8.Text = "Ingresar N° Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 38;
            // 
            // btnRegistarMembresia
            // 
            this.btnRegistarMembresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.btnRegistarMembresia.FlatAppearance.BorderSize = 0;
            this.btnRegistarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarMembresia.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnRegistarMembresia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistarMembresia.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnRegistarMembresia.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegistarMembresia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistarMembresia.IconSize = 30;
            this.btnRegistarMembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistarMembresia.Location = new System.Drawing.Point(231, 406);
            this.btnRegistarMembresia.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistarMembresia.Name = "btnRegistarMembresia";
            this.btnRegistarMembresia.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnRegistarMembresia.Size = new System.Drawing.Size(326, 45);
            this.btnRegistarMembresia.TabIndex = 5;
            this.btnRegistarMembresia.Text = "Registrar Membresía";
            this.btnRegistarMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistarMembresia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistarMembresia.UseVisualStyleBackColor = false;
            this.btnRegistarMembresia.Click += new System.EventHandler(this.btnRegistarMembresia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(124)))), ((int)(((byte)(184)))));
            this.panel1.BackgroundImage = global::InterfazdeUsuario.Properties.Resources.Red_and_Blue_Vintage_Modern_minimal_Gym_and_Fitness_Logo__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 632);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 76);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1125, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar membresia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidarMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ValidarMembresia";
            this.Size = new System.Drawing.Size(1190, 706);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnRegistarMembresia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMonto;
        private System.Windows.Forms.ComboBox cmbDuracion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }

  #endregion
    
}
