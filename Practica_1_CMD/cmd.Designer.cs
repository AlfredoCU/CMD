namespace Practica_1_CMD
{
    partial class Cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cmd));
            this.rtbConsola = new System.Windows.Forms.RichTextBox();
            this.fdFormato = new System.Windows.Forms.FontDialog();
            this.cdColorFC = new System.Windows.Forms.ColorDialog();
            this.TsmiColorF = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorC = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFormato = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAcercaCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCMD = new System.Windows.Forms.MenuStrip();
            this.tsmiExpo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiACMD = new System.Windows.Forms.ToolStripMenuItem();
            this.msCMD.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsola
            // 
            this.rtbConsola.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbConsola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsola.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsola.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbConsola.Location = new System.Drawing.Point(0, 26);
            this.rtbConsola.Name = "rtbConsola";
            this.rtbConsola.Size = new System.Drawing.Size(746, 417);
            this.rtbConsola.TabIndex = 4;
            this.rtbConsola.Text = "";
            this.rtbConsola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbConsola_KeyDown);
            // 
            // TsmiColorF
            // 
            this.TsmiColorF.Name = "TsmiColorF";
            this.TsmiColorF.Size = new System.Drawing.Size(32, 19);
            // 
            // TsmiColorC
            // 
            this.TsmiColorC.Name = "TsmiColorC";
            this.TsmiColorC.Size = new System.Drawing.Size(32, 19);
            // 
            // TsmiFormato
            // 
            this.TsmiFormato.Name = "TsmiFormato";
            this.TsmiFormato.Size = new System.Drawing.Size(32, 19);
            // 
            // TsmiInfo
            // 
            this.TsmiInfo.Name = "TsmiInfo";
            this.TsmiInfo.Size = new System.Drawing.Size(32, 19);
            // 
            // TsmiAcercaCMD
            // 
            this.TsmiAcercaCMD.Name = "TsmiAcercaCMD";
            this.TsmiAcercaCMD.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(156, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCMD
            // 
            this.msCMD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msCMD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExpo,
            this.tsmiPre,
            this.tsmiA});
            this.msCMD.Location = new System.Drawing.Point(0, 0);
            this.msCMD.Name = "msCMD";
            this.msCMD.Size = new System.Drawing.Size(746, 26);
            this.msCMD.TabIndex = 6;
            this.msCMD.Text = "Menu CMD";
            // 
            // tsmiExpo
            // 
            this.tsmiExpo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExpo.Image")));
            this.tsmiExpo.Name = "tsmiExpo";
            this.tsmiExpo.Size = new System.Drawing.Size(112, 22);
            this.tsmiExpo.Text = "Explorador";
            this.tsmiExpo.Click += new System.EventHandler(this.tsmiExpo_Click);
            // 
            // tsmiPre
            // 
            this.tsmiPre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCF,
            this.tsmiCC,
            this.tsmiF});
            this.tsmiPre.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPre.Image")));
            this.tsmiPre.Name = "tsmiPre";
            this.tsmiPre.Size = new System.Drawing.Size(125, 22);
            this.tsmiPre.Text = "Preferencias";
            // 
            // tsmiCF
            // 
            this.tsmiCF.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCF.Image")));
            this.tsmiCF.Name = "tsmiCF";
            this.tsmiCF.Size = new System.Drawing.Size(194, 22);
            this.tsmiCF.Text = "Color de fuente";
            this.tsmiCF.Click += new System.EventHandler(this.tsmiCF_Click);
            // 
            // tsmiCC
            // 
            this.tsmiCC.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCC.Image")));
            this.tsmiCC.Name = "tsmiCC";
            this.tsmiCC.Size = new System.Drawing.Size(194, 22);
            this.tsmiCC.Text = "Color de consola";
            this.tsmiCC.Click += new System.EventHandler(this.tsmiCC_Click);
            // 
            // tsmiF
            // 
            this.tsmiF.Image = ((System.Drawing.Image)(resources.GetObject("tsmiF.Image")));
            this.tsmiF.Name = "tsmiF";
            this.tsmiF.Size = new System.Drawing.Size(194, 22);
            this.tsmiF.Text = "Formato";
            this.tsmiF.Click += new System.EventHandler(this.tsmiF_Click);
            // 
            // tsmiA
            // 
            this.tsmiA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInf,
            this.tsmiACMD});
            this.tsmiA.Image = ((System.Drawing.Image)(resources.GetObject("tsmiA.Image")));
            this.tsmiA.Name = "tsmiA";
            this.tsmiA.Size = new System.Drawing.Size(108, 22);
            this.tsmiA.Text = "Acerca de";
            // 
            // tsmiInf
            // 
            this.tsmiInf.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInf.Image")));
            this.tsmiInf.Name = "tsmiInf";
            this.tsmiInf.Size = new System.Drawing.Size(189, 22);
            this.tsmiInf.Text = "Información";
            this.tsmiInf.Click += new System.EventHandler(this.tsmiInf_Click);
            // 
            // tsmiACMD
            // 
            this.tsmiACMD.Image = ((System.Drawing.Image)(resources.GetObject("tsmiACMD.Image")));
            this.tsmiACMD.Name = "tsmiACMD";
            this.tsmiACMD.Size = new System.Drawing.Size(189, 22);
            this.tsmiACMD.Text = "Acerca de CMD";
            this.tsmiACMD.Click += new System.EventHandler(this.tsmiACMD_Click);
            // 
            // Cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(746, 443);
            this.Controls.Add(this.rtbConsola);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.msCMD);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÍmbolo del sistema (CMD)";
            this.Load += new System.EventHandler(this.Cmd_Load);
            this.msCMD.ResumeLayout(false);
            this.msCMD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsola;
        private System.Windows.Forms.FontDialog fdFormato;
        private System.Windows.Forms.ColorDialog cdColorFC;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorF;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorC;
        private System.Windows.Forms.ToolStripMenuItem TsmiFormato;
        private System.Windows.Forms.ToolStripMenuItem TsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem TsmiAcercaCMD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip msCMD;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPre;
        private System.Windows.Forms.ToolStripMenuItem tsmiCF;
        private System.Windows.Forms.ToolStripMenuItem tsmiCC;
        private System.Windows.Forms.ToolStripMenuItem tsmiF;
        private System.Windows.Forms.ToolStripMenuItem tsmiA;
        private System.Windows.Forms.ToolStripMenuItem tsmiInf;
        private System.Windows.Forms.ToolStripMenuItem tsmiACMD;
    }
}