namespace Practica_1_CMD
{
    partial class cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmd));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.TsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDescargar = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiExplorador = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHerr = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiPre = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorF = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorC = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFor = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMP = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMPMusica = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.fdFormato = new System.Windows.Forms.FontDialog();
            this.cdColorFC = new System.Windows.Forms.ColorDialog();
            this.tcSistema = new System.Windows.Forms.TabControl();
            this.tpEscritorio = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpConsola = new System.Windows.Forms.TabPage();
            this.rtbConsola = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.Timer(this.components);
            this.pbBateria = new System.Windows.Forms.ProgressBar();
            this.lblBateria = new System.Windows.Forms.Label();
            this.lblBateriaTxt = new System.Windows.Forms.Label();
            this.msPrincipal.SuspendLayout();
            this.tcSistema.SuspendLayout();
            this.tpEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpConsola.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiInicio});
            this.msPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msPrincipal.Location = new System.Drawing.Point(0, 598);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1081, 26);
            this.msPrincipal.TabIndex = 2;
            this.msPrincipal.Text = "MenuPrincipal";
            // 
            // TsmiInicio
            // 
            this.TsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiArchivos,
            this.cMDToolStripMenuItem,
            this.TsmiMP,
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
            // cMDToolStripMenuItem
            // 
            this.cMDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiExplorador,
            this.TsmiHerr,
            this.TsmiAcerca});
            this.cMDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cMDToolStripMenuItem.Image")));
            this.cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            this.cMDToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cMDToolStripMenuItem.Text = "CMD";
            // 
            // TsmiExplorador
            // 
            this.TsmiExplorador.Image = ((System.Drawing.Image)(resources.GetObject("TsmiExplorador.Image")));
            this.TsmiExplorador.Name = "TsmiExplorador";
            this.TsmiExplorador.Size = new System.Drawing.Size(170, 22);
            this.TsmiExplorador.Text = "Explorador";
            this.TsmiExplorador.Click += new System.EventHandler(this.TsmiExplorador_Click);
            // 
            // TsmiHerr
            // 
            this.TsmiHerr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiPre});
            this.TsmiHerr.Image = ((System.Drawing.Image)(resources.GetObject("TsmiHerr.Image")));
            this.TsmiHerr.Name = "TsmiHerr";
            this.TsmiHerr.Size = new System.Drawing.Size(170, 22);
            this.TsmiHerr.Text = "Herramientas";
            // 
            // TsmiPre
            // 
            this.TsmiPre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiColorF,
            this.TsmiColorC,
            this.TsmiFor});
            this.TsmiPre.Image = ((System.Drawing.Image)(resources.GetObject("TsmiPre.Image")));
            this.TsmiPre.Name = "TsmiPre";
            this.TsmiPre.Size = new System.Drawing.Size(165, 22);
            this.TsmiPre.Text = "Preferencias";
            // 
            // TsmiColorF
            // 
            this.TsmiColorF.Image = ((System.Drawing.Image)(resources.GetObject("TsmiColorF.Image")));
            this.TsmiColorF.Name = "TsmiColorF";
            this.TsmiColorF.Size = new System.Drawing.Size(194, 22);
            this.TsmiColorF.Text = "Color de fuente";
            this.TsmiColorF.Click += new System.EventHandler(this.TsmiColorF_Click);
            // 
            // TsmiColorC
            // 
            this.TsmiColorC.Image = ((System.Drawing.Image)(resources.GetObject("TsmiColorC.Image")));
            this.TsmiColorC.Name = "TsmiColorC";
            this.TsmiColorC.Size = new System.Drawing.Size(194, 22);
            this.TsmiColorC.Text = "Color de consola";
            this.TsmiColorC.Click += new System.EventHandler(this.TsmiColorC_Click);
            // 
            // TsmiFor
            // 
            this.TsmiFor.Image = ((System.Drawing.Image)(resources.GetObject("TsmiFor.Image")));
            this.TsmiFor.Name = "TsmiFor";
            this.TsmiFor.Size = new System.Drawing.Size(194, 22);
            this.TsmiFor.Text = "Formato";
            this.TsmiFor.Click += new System.EventHandler(this.TsmiFor_Click);
            // 
            // TsmiAcerca
            // 
            this.TsmiAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiInfo,
            this.TsmiCMD});
            this.TsmiAcerca.Image = ((System.Drawing.Image)(resources.GetObject("TsmiAcerca.Image")));
            this.TsmiAcerca.Name = "TsmiAcerca";
            this.TsmiAcerca.Size = new System.Drawing.Size(170, 22);
            this.TsmiAcerca.Text = "Acerca de";
            // 
            // TsmiInfo
            // 
            this.TsmiInfo.Image = ((System.Drawing.Image)(resources.GetObject("TsmiInfo.Image")));
            this.TsmiInfo.Name = "TsmiInfo";
            this.TsmiInfo.Size = new System.Drawing.Size(192, 22);
            this.TsmiInfo.Text = "Información";
            this.TsmiInfo.Click += new System.EventHandler(this.TsmiInfo_Click);
            // 
            // TsmiCMD
            // 
            this.TsmiCMD.Image = ((System.Drawing.Image)(resources.GetObject("TsmiCMD.Image")));
            this.TsmiCMD.Name = "TsmiCMD";
            this.TsmiCMD.Size = new System.Drawing.Size(192, 22);
            this.TsmiCMD.Text = "Acerca del CMD";
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
            this.TsmiMPMusica.Size = new System.Drawing.Size(126, 22);
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
            // tcSistema
            // 
            this.tcSistema.Controls.Add(this.tpEscritorio);
            this.tcSistema.Controls.Add(this.tpConsola);
            this.tcSistema.Location = new System.Drawing.Point(12, 12);
            this.tcSistema.Name = "tcSistema";
            this.tcSistema.SelectedIndex = 0;
            this.tcSistema.Size = new System.Drawing.Size(1057, 584);
            this.tcSistema.TabIndex = 1;
            // 
            // tpEscritorio
            // 
            this.tpEscritorio.Controls.Add(this.pictureBox1);
            this.tpEscritorio.Location = new System.Drawing.Point(4, 27);
            this.tpEscritorio.Name = "tpEscritorio";
            this.tpEscritorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpEscritorio.Size = new System.Drawing.Size(1049, 553);
            this.tpEscritorio.TabIndex = 0;
            this.tpEscritorio.Text = "Escritorio";
            this.tpEscritorio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1043, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpConsola
            // 
            this.tpConsola.Controls.Add(this.rtbConsola);
            this.tpConsola.Location = new System.Drawing.Point(4, 27);
            this.tpConsola.Name = "tpConsola";
            this.tpConsola.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsola.Size = new System.Drawing.Size(1049, 553);
            this.tpConsola.TabIndex = 1;
            this.tpConsola.Text = "Consola";
            this.tpConsola.UseVisualStyleBackColor = true;
            // 
            // rtbConsola
            // 
            this.rtbConsola.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbConsola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsola.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbConsola.Location = new System.Drawing.Point(3, 3);
            this.rtbConsola.Name = "rtbConsola";
            this.rtbConsola.Size = new System.Drawing.Size(1043, 547);
            this.rtbConsola.TabIndex = 3;
            this.rtbConsola.Text = "";
            this.rtbConsola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbConsola_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(881, 603);
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
            this.pbBateria.Location = new System.Drawing.Point(738, 598);
            this.pbBateria.Name = "pbBateria";
            this.pbBateria.Size = new System.Drawing.Size(82, 23);
            this.pbBateria.TabIndex = 3;
            // 
            // lblBateria
            // 
            this.lblBateria.AutoSize = true;
            this.lblBateria.BackColor = System.Drawing.Color.Transparent;
            this.lblBateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBateria.ForeColor = System.Drawing.Color.Black;
            this.lblBateria.Location = new System.Drawing.Point(826, 603);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(49, 18);
            this.lblBateria.TabIndex = 4;
            this.lblBateria.Text = "100%";
            // 
            // lblBateriaTxt
            // 
            this.lblBateriaTxt.AutoSize = true;
            this.lblBateriaTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblBateriaTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBateriaTxt.ForeColor = System.Drawing.Color.Black;
            this.lblBateriaTxt.Location = new System.Drawing.Point(670, 603);
            this.lblBateriaTxt.Name = "lblBateriaTxt";
            this.lblBateriaTxt.Size = new System.Drawing.Size(62, 18);
            this.lblBateriaTxt.TabIndex = 5;
            this.lblBateriaTxt.Text = "Batería:";
            // 
            // cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 624);
            this.Controls.Add(this.lblBateriaTxt);
            this.Controls.Add(this.lblBateria);
            this.Controls.Add(this.pbBateria);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tcSistema);
            this.Controls.Add(this.msPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "cmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Operativo (Windows 10)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cmd_FormClosed);
            this.Load += new System.EventHandler(this.cmd_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tcSistema.ResumeLayout(false);
            this.tpEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpConsola.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem TsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem TsmiSalir;
        private System.Windows.Forms.FontDialog fdFormato;
        private System.Windows.Forms.ColorDialog cdColorFC;
        private System.Windows.Forms.TabControl tcSistema;
        private System.Windows.Forms.TabPage tpEscritorio;
        private System.Windows.Forms.TabPage tpConsola;
        private System.Windows.Forms.RichTextBox rtbConsola;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tDate;
        private System.Windows.Forms.ToolStripMenuItem TsmiArchivos;
        private System.Windows.Forms.ToolStripMenuItem TsmiDocumentos;
        private System.Windows.Forms.ToolStripMenuItem cMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiExplorador;
        private System.Windows.Forms.ToolStripMenuItem TsmiHerr;
        private System.Windows.Forms.ToolStripMenuItem TsmiAcerca;
        private System.Windows.Forms.ToolStripMenuItem TsmiPre;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorF;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorC;
        private System.Windows.Forms.ToolStripMenuItem TsmiFor;
        private System.Windows.Forms.ToolStripMenuItem TsmiCMD;
        private System.Windows.Forms.ToolStripMenuItem TsmiSistema;
        private System.Windows.Forms.ToolStripMenuItem TsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiBat;
        private System.Windows.Forms.ProgressBar pbBateria;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.Label lblBateriaTxt;
        private System.Windows.Forms.ToolStripMenuItem TsmiMP;
        private System.Windows.Forms.ToolStripMenuItem TsmiMPMusica;
        private System.Windows.Forms.ToolStripMenuItem TsmiDescargar;
    }
}

