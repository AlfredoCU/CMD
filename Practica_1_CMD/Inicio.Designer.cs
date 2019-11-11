namespace Practica_1_CMD
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.TsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDescargar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMP = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMPMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.Timer(this.components);
            this.pbBateria = new System.Windows.Forms.ProgressBar();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblBateriaTxt = new System.Windows.Forms.Label();
            this.TsmiJuegos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTetris = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiInicio});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msPrincipal.Location = new System.Drawing.Point(0, 645);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1345, 26);
            this.msPrincipal.TabIndex = 2;
            this.msPrincipal.Text = "MenuPrincipal";
            // 
            // TsmiInicio
            // 
            this.TsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiArchivos,
            this.TsmiJuegos,
            this.TsmiMP,
            this.TsmiCMD,
            this.TsmiSistema,
            this.tsmiBat,
            this.TsmiSalir});
            this.TsmiInicio.Image = ((System.Drawing.Image)(resources.GetObject("TsmiInicio.Image")));
            this.TsmiInicio.Name = "TsmiInicio";
            this.TsmiInicio.Size = new System.Drawing.Size(72, 22);
            this.TsmiInicio.Text = "Inicio";
            // 
            // TsmiArchivos
            // 
            this.TsmiArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiDocumentos,
            this.TsmiDescargar});
            this.TsmiArchivos.Image = ((System.Drawing.Image)(resources.GetObject("TsmiArchivos.Image")));
            this.TsmiArchivos.Name = "TsmiArchivos";
            this.TsmiArchivos.Size = new System.Drawing.Size(168, 22);
            this.TsmiArchivos.Text = "Archivos";
            // 
            // TsmiDocumentos
            // 
            this.TsmiDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("TsmiDocumentos.Image")));
            this.TsmiDocumentos.Name = "TsmiDocumentos";
            this.TsmiDocumentos.Size = new System.Drawing.Size(164, 22);
            this.TsmiDocumentos.Text = "Documentos";
            this.TsmiDocumentos.Click += new System.EventHandler(this.TsmiDocumentos_Click);
            // 
            // TsmiDescargar
            // 
            this.TsmiDescargar.Image = ((System.Drawing.Image)(resources.GetObject("TsmiDescargar.Image")));
            this.TsmiDescargar.Name = "TsmiDescargar";
            this.TsmiDescargar.Size = new System.Drawing.Size(164, 22);
            this.TsmiDescargar.Text = "Descargar";
            this.TsmiDescargar.Click += new System.EventHandler(this.TsmiDescargar_Click);
            // 
            // TsmiCMD
            // 
            this.TsmiCMD.Image = ((System.Drawing.Image)(resources.GetObject("TsmiCMD.Image")));
            this.TsmiCMD.Name = "TsmiCMD";
            this.TsmiCMD.Size = new System.Drawing.Size(168, 22);
            this.TsmiCMD.Text = "CMD";
            this.TsmiCMD.Click += new System.EventHandler(this.TsmiCMD_Click);
            // 
            // TsmiMP
            // 
            this.TsmiMP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiMPMusica});
            this.TsmiMP.Image = ((System.Drawing.Image)(resources.GetObject("TsmiMP.Image")));
            this.TsmiMP.Name = "TsmiMP";
            this.TsmiMP.Size = new System.Drawing.Size(168, 22);
            this.TsmiMP.Text = "Media Player";
            // 
            // TsmiMPMusica
            // 
            this.TsmiMPMusica.Image = ((System.Drawing.Image)(resources.GetObject("TsmiMPMusica.Image")));
            this.TsmiMPMusica.Name = "TsmiMPMusica";
            this.TsmiMPMusica.Size = new System.Drawing.Size(152, 22);
            this.TsmiMPMusica.Text = "Música";
            this.TsmiMPMusica.Click += new System.EventHandler(this.TsmiMPMusica_Click);
            // 
            // TsmiSistema
            // 
            this.TsmiSistema.Image = ((System.Drawing.Image)(resources.GetObject("TsmiSistema.Image")));
            this.TsmiSistema.Name = "TsmiSistema";
            this.TsmiSistema.Size = new System.Drawing.Size(168, 22);
            this.TsmiSistema.Text = "Sistema";
            this.TsmiSistema.Click += new System.EventHandler(this.TsmiSistema_Click);
            // 
            // tsmiBat
            // 
            this.tsmiBat.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBat.Image")));
            this.tsmiBat.Name = "tsmiBat";
            this.tsmiBat.Size = new System.Drawing.Size(168, 22);
            this.tsmiBat.Text = "Batería";
            this.tsmiBat.Click += new System.EventHandler(this.tsmiBat_Click);
            // 
            // TsmiSalir
            // 
            this.TsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("TsmiSalir.Image")));
            this.TsmiSalir.Name = "TsmiSalir";
            this.TsmiSalir.Size = new System.Drawing.Size(168, 22);
            this.TsmiSalir.Text = "Salir";
            this.TsmiSalir.Click += new System.EventHandler(this.TsmiSalir_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1137, 648);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // tDate
            // 
            this.tDate.Tick += new System.EventHandler(this.tDate_Tick);
            // 
            // pbBateria
            // 
            this.pbBateria.Location = new System.Drawing.Point(994, 645);
            this.pbBateria.Name = "pbBateria";
            this.pbBateria.Size = new System.Drawing.Size(82, 23);
            this.pbBateria.TabIndex = 3;
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.BackColor = System.Drawing.Color.White;
            this.lblBateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBateria.ForeColor = System.Drawing.Color.Black;
            this.lblBateria.Location = new System.Drawing.Point(1082, 648);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(49, 18);
            this.lblBateria.TabIndex = 4;
            this.lblBateria.Text = "100%";
            // 
            // lblBateriaTxt
            // 
            this.lblBateriaTxt.AutoSize = true;
            this.lblBateriaTxt.BackColor = System.Drawing.Color.White;
            this.lblBateriaTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBateriaTxt.ForeColor = System.Drawing.Color.Black;
            this.lblBateriaTxt.Location = new System.Drawing.Point(926, 648);
            this.lblBateriaTxt.Name = "lblBateriaTxt";
            this.lblBateriaTxt.Size = new System.Drawing.Size(62, 18);
            this.lblBateriaTxt.TabIndex = 5;
            this.lblBateriaTxt.Text = "Batería:";
            // 
            // TsmiJuegos
            // 
            this.TsmiJuegos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiTetris});
            this.TsmiJuegos.Image = ((System.Drawing.Image)(resources.GetObject("TsmiJuegos.Image")));
            this.TsmiJuegos.Name = "TsmiJuegos";
            this.TsmiJuegos.Size = new System.Drawing.Size(168, 22);
            this.TsmiJuegos.Text = "Juegos";
            // 
            // TsmiTetris
            // 
            this.TsmiTetris.Image = ((System.Drawing.Image)(resources.GetObject("TsmiTetris.Image")));
            this.TsmiTetris.Name = "TsmiTetris";
            this.TsmiTetris.Size = new System.Drawing.Size(152, 22);
            this.TsmiTetris.Text = "Tetris";
            this.TsmiTetris.Click += new System.EventHandler(this.TsmiTetris_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1345, 671);
            this.Controls.Add(this.lblBateriaTxt);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.pbBateria);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.msPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Operativo (Windows 10)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cmd_FormClosed);
            this.Load += new System.EventHandler(this.cmd_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem TsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem TsmiSalir;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tDate;
        private System.Windows.Forms.ToolStripMenuItem TsmiArchivos;
        private System.Windows.Forms.ToolStripMenuItem TsmiDocumentos;
        private System.Windows.Forms.ToolStripMenuItem TsmiCMD;
        private System.Windows.Forms.ToolStripMenuItem TsmiSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmiBat;
        private System.Windows.Forms.ProgressBar pbBateria;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblBateriaTxt;
        private System.Windows.Forms.ToolStripMenuItem TsmiMP;
        private System.Windows.Forms.ToolStripMenuItem TsmiMPMusica;
        private System.Windows.Forms.ToolStripMenuItem TsmiDescargar;
        private System.Windows.Forms.ToolStripMenuItem TsmiJuegos;
        private System.Windows.Forms.ToolStripMenuItem TsmiTetris;
    }
}

