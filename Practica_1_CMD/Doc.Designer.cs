namespace Practica_1_CMD
{
    partial class Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc));
            this.scContenedores = new System.Windows.Forms.SplitContainer();
            this.stvArchivos = new GongSolutions.Shell.ShellTreeView();
            this.svArchivos = new GongSolutions.Shell.ShellView();
            ((System.ComponentModel.ISupportInitialize)(this.scContenedores)).BeginInit();
            this.scContenedores.Panel1.SuspendLayout();
            this.scContenedores.Panel2.SuspendLayout();
            this.scContenedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // scContenedores
            // 
            this.scContenedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContenedores.Location = new System.Drawing.Point(0, 0);
            this.scContenedores.Name = "scContenedores";
            // 
            // scContenedores.Panel1
            // 
            this.scContenedores.Panel1.Controls.Add(this.stvArchivos);
            // 
            // scContenedores.Panel2
            // 
            this.scContenedores.Panel2.Controls.Add(this.svArchivos);
            this.scContenedores.Size = new System.Drawing.Size(721, 375);
            this.scContenedores.SplitterDistance = 239;
            this.scContenedores.TabIndex = 0;
            // 
            // stvArchivos
            // 
            this.stvArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stvArchivos.Location = new System.Drawing.Point(0, 0);
            this.stvArchivos.Name = "stvArchivos";
            this.stvArchivos.ShellView = this.svArchivos;
            this.stvArchivos.Size = new System.Drawing.Size(239, 375);
            this.stvArchivos.TabIndex = 0;
            // 
            // svArchivos
            // 
            this.svArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svArchivos.Location = new System.Drawing.Point(0, 0);
            this.svArchivos.Name = "svArchivos";
            this.svArchivos.Size = new System.Drawing.Size(478, 375);
            this.svArchivos.StatusBar = null;
            this.svArchivos.TabIndex = 0;
            this.svArchivos.Text = "shellView1";
            // 
            // Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(721, 375);
            this.Controls.Add(this.scContenedores);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Doc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.scContenedores.Panel1.ResumeLayout(false);
            this.scContenedores.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContenedores)).EndInit();
            this.scContenedores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scContenedores;
        private GongSolutions.Shell.ShellTreeView stvArchivos;
        private GongSolutions.Shell.ShellView svArchivos;
    }
}