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
            this.rtbConsola = new System.Windows.Forms.RichTextBox();
            this.gbConsola = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.TsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmExplorador = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHerr = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiPre = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorF = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorC = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFor = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.fdFormato = new System.Windows.Forms.FontDialog();
            this.cdColorFC = new System.Windows.Forms.ColorDialog();
            this.gbConsola.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsola
            // 
            this.rtbConsola.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbConsola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsola.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbConsola.Location = new System.Drawing.Point(3, 22);
            this.rtbConsola.Name = "rtbConsola";
            this.rtbConsola.Size = new System.Drawing.Size(752, 471);
            this.rtbConsola.TabIndex = 0;
            this.rtbConsola.Text = "";
            this.rtbConsola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbConsola_KeyDown);
            // 
            // gbConsola
            // 
            this.gbConsola.Controls.Add(this.rtbConsola);
            this.gbConsola.Location = new System.Drawing.Point(12, 28);
            this.gbConsola.Name = "gbConsola";
            this.gbConsola.Size = new System.Drawing.Size(758, 496);
            this.gbConsola.TabIndex = 1;
            this.gbConsola.TabStop = false;
            this.gbConsola.Text = "Consola";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiArchivo,
            this.verToolStripMenuItem,
            this.TsmiHerr,
            this.TsmiAcerca});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(782, 25);
            this.msPrincipal.TabIndex = 2;
            this.msPrincipal.Text = "MenuPrincipal";
            // 
            // TsmiArchivo
            // 
            this.TsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmExplorador,
            this.TsmiInfo,
            this.TsmiSalir});
            this.TsmiArchivo.Image = ((System.Drawing.Image)(resources.GetObject("TsmiArchivo.Image")));
            this.TsmiArchivo.Name = "TsmiArchivo";
            this.TsmiArchivo.Size = new System.Drawing.Size(84, 21);
            this.TsmiArchivo.Text = "Archivo";
            // 
            // TsmExplorador
            // 
            this.TsmExplorador.Image = ((System.Drawing.Image)(resources.GetObject("TsmExplorador.Image")));
            this.TsmExplorador.Name = "TsmExplorador";
            this.TsmExplorador.Size = new System.Drawing.Size(152, 22);
            this.TsmExplorador.Text = "Explorador";
            this.TsmExplorador.Click += new System.EventHandler(this.TsmiExplorador_Click);
            // 
            // TsmiInfo
            // 
            this.TsmiInfo.Image = ((System.Drawing.Image)(resources.GetObject("TsmiInfo.Image")));
            this.TsmiInfo.Name = "TsmiInfo";
            this.TsmiInfo.Size = new System.Drawing.Size(152, 22);
            this.TsmiInfo.Text = "Información";
            this.TsmiInfo.Click += new System.EventHandler(this.TsmiInfo_Click);
            // 
            // TsmiSalir
            // 
            this.TsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("TsmiSalir.Image")));
            this.TsmiSalir.Name = "TsmiSalir";
            this.TsmiSalir.Size = new System.Drawing.Size(152, 22);
            this.TsmiSalir.Text = "Salir";
            this.TsmiSalir.Click += new System.EventHandler(this.TsmiSalir_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiDocumentos});
            this.verToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verToolStripMenuItem.Image")));
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // TsmiDocumentos
            // 
            this.TsmiDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("TsmiDocumentos.Image")));
            this.TsmiDocumentos.Name = "TsmiDocumentos";
            this.TsmiDocumentos.Size = new System.Drawing.Size(160, 22);
            this.TsmiDocumentos.Text = "Documentos";
            this.TsmiDocumentos.Click += new System.EventHandler(this.TsmiDocumentos_Click);
            // 
            // TsmiHerr
            // 
            this.TsmiHerr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiPre});
            this.TsmiHerr.Image = ((System.Drawing.Image)(resources.GetObject("TsmiHerr.Image")));
            this.TsmiHerr.Name = "TsmiHerr";
            this.TsmiHerr.Size = new System.Drawing.Size(124, 21);
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
            this.TsmiPre.Size = new System.Drawing.Size(159, 22);
            this.TsmiPre.Text = "Preferencias";
            // 
            // TsmiColorF
            // 
            this.TsmiColorF.Image = ((System.Drawing.Image)(resources.GetObject("TsmiColorF.Image")));
            this.TsmiColorF.Name = "TsmiColorF";
            this.TsmiColorF.Size = new System.Drawing.Size(186, 22);
            this.TsmiColorF.Text = "Color de fuente";
            this.TsmiColorF.Click += new System.EventHandler(this.TsmiColorF_Click);
            // 
            // TsmiColorC
            // 
            this.TsmiColorC.Image = ((System.Drawing.Image)(resources.GetObject("TsmiColorC.Image")));
            this.TsmiColorC.Name = "TsmiColorC";
            this.TsmiColorC.Size = new System.Drawing.Size(186, 22);
            this.TsmiColorC.Text = "Color de consola";
            this.TsmiColorC.Click += new System.EventHandler(this.TsmiColorC_Click);
            // 
            // TsmiFor
            // 
            this.TsmiFor.Image = ((System.Drawing.Image)(resources.GetObject("TsmiFor.Image")));
            this.TsmiFor.Name = "TsmiFor";
            this.TsmiFor.Size = new System.Drawing.Size(186, 22);
            this.TsmiFor.Text = "Formato";
            this.TsmiFor.Click += new System.EventHandler(this.TsmiFor_Click);
            // 
            // TsmiAcerca
            // 
            this.TsmiAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCMD});
            this.TsmiAcerca.Image = ((System.Drawing.Image)(resources.GetObject("TsmiAcerca.Image")));
            this.TsmiAcerca.Name = "TsmiAcerca";
            this.TsmiAcerca.Size = new System.Drawing.Size(102, 21);
            this.TsmiAcerca.Text = "Acerca de";
            // 
            // TsmiCMD
            // 
            this.TsmiCMD.Image = ((System.Drawing.Image)(resources.GetObject("TsmiCMD.Image")));
            this.TsmiCMD.Name = "TsmiCMD";
            this.TsmiCMD.Size = new System.Drawing.Size(182, 22);
            this.TsmiCMD.Text = "Acerca del CMD";
            this.TsmiCMD.Click += new System.EventHandler(this.TsmiCMD_Click);
            // 
            // cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 536);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.gbConsola);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "cmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Símbolo del sistema (CMD)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cmd_FormClosed);
            this.Load += new System.EventHandler(this.cmd_Load);
            this.gbConsola.ResumeLayout(false);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsola;
        private System.Windows.Forms.GroupBox gbConsola;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem TsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem TsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem TsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem TsmiHerr;
        private System.Windows.Forms.ToolStripMenuItem TsmiPre;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorF;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorC;
        private System.Windows.Forms.ToolStripMenuItem TsmiFor;
        private System.Windows.Forms.ToolStripMenuItem TsmiAcerca;
        private System.Windows.Forms.ToolStripMenuItem TsmiCMD;
        private System.Windows.Forms.FontDialog fdFormato;
        private System.Windows.Forms.ColorDialog cdColorFC;
        private System.Windows.Forms.ToolStripMenuItem TsmExplorador;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiDocumentos;
    }
}

