namespace Practica_1_CMD
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.scOrganizacion = new System.Windows.Forms.SplitContainer();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbMusica = new System.Windows.Forms.ListBox();
            this.wmpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbMusica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scOrganizacion)).BeginInit();
            this.scOrganizacion.Panel1.SuspendLayout();
            this.scOrganizacion.Panel2.SuspendLayout();
            this.scOrganizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // scOrganizacion
            // 
            this.scOrganizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOrganizacion.Location = new System.Drawing.Point(0, 0);
            this.scOrganizacion.Name = "scOrganizacion";
            // 
            // scOrganizacion.Panel1
            // 
            this.scOrganizacion.Panel1.Controls.Add(this.pbMusica);
            this.scOrganizacion.Panel1.Controls.Add(this.btnAgregar);
            this.scOrganizacion.Panel1.Controls.Add(this.lbMusica);
            // 
            // scOrganizacion.Panel2
            // 
            this.scOrganizacion.Panel2.Controls.Add(this.wmpMusica);
            this.scOrganizacion.Size = new System.Drawing.Size(874, 503);
            this.scOrganizacion.SplitterDistance = 291;
            this.scOrganizacion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(118, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Buscar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbMusica
            // 
            this.lbMusica.FormattingEnabled = true;
            this.lbMusica.ItemHeight = 18;
            this.lbMusica.Location = new System.Drawing.Point(12, 91);
            this.lbMusica.Name = "lbMusica";
            this.lbMusica.Size = new System.Drawing.Size(274, 400);
            this.lbMusica.TabIndex = 1;
            this.lbMusica.SelectedIndexChanged += new System.EventHandler(this.lbMusica_SelectedIndexChanged);
            // 
            // wmpMusica
            // 
            this.wmpMusica.Enabled = true;
            this.wmpMusica.Location = new System.Drawing.Point(-3, 0);
            this.wmpMusica.Name = "wmpMusica";
            this.wmpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusica.OcxState")));
            this.wmpMusica.Size = new System.Drawing.Size(582, 503);
            this.wmpMusica.TabIndex = 0;
            // 
            // pbMusica
            // 
            this.pbMusica.Image = ((System.Drawing.Image)(resources.GetObject("pbMusica.Image")));
            this.pbMusica.Location = new System.Drawing.Point(12, 12);
            this.pbMusica.Name = "pbMusica";
            this.pbMusica.Size = new System.Drawing.Size(85, 64);
            this.pbMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusica.TabIndex = 1;
            this.pbMusica.TabStop = false;
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(874, 503);
            this.Controls.Add(this.scOrganizacion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Reproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de Música";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reproductor_FormClosed);
            this.scOrganizacion.Panel1.ResumeLayout(false);
            this.scOrganizacion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOrganizacion)).EndInit();
            this.scOrganizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scOrganizacion;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusica;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbMusica;
        private System.Windows.Forms.PictureBox pbMusica;
    }
}