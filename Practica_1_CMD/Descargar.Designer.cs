namespace Practica_1_CMD
{
    partial class Descargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descargar));
            this.gbURL = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.gbProgreso = new System.Windows.Forms.GroupBox();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.gbURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbProgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbURL
            // 
            this.gbURL.Controls.Add(this.pictureBox1);
            this.gbURL.Controls.Add(this.btnDescargar);
            this.gbURL.Controls.Add(this.txtURL);
            this.gbURL.Location = new System.Drawing.Point(12, 12);
            this.gbURL.Name = "gbURL";
            this.gbURL.Size = new System.Drawing.Size(435, 111);
            this.gbURL.TabIndex = 0;
            this.gbURL.TabStop = false;
            this.gbURL.Text = "URL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(6, 57);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(318, 40);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(6, 25);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(318, 26);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(6, 25);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(366, 36);
            this.pbProgreso.TabIndex = 1;
            // 
            // gbProgreso
            // 
            this.gbProgreso.Controls.Add(this.lblProgreso);
            this.gbProgreso.Controls.Add(this.pbProgreso);
            this.gbProgreso.Location = new System.Drawing.Point(12, 129);
            this.gbProgreso.Name = "gbProgreso";
            this.gbProgreso.Size = new System.Drawing.Size(435, 79);
            this.gbProgreso.TabIndex = 2;
            this.gbProgreso.TabStop = false;
            this.gbProgreso.Text = "Progreso";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(387, 34);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(31, 18);
            this.lblProgreso.TabIndex = 2;
            this.lblProgreso.Text = "0%";
            // 
            // Descargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(459, 215);
            this.Controls.Add(this.gbProgreso);
            this.Controls.Add(this.gbURL);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Descargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargar archivos";
            this.Load += new System.EventHandler(this.Descargar_Load);
            this.gbURL.ResumeLayout(false);
            this.gbURL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbProgreso.ResumeLayout(false);
            this.gbProgreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbURL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.GroupBox gbProgreso;
        private System.Windows.Forms.Label lblProgreso;
    }
}