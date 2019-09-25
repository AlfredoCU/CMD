namespace Practica_1_CMD
{
    partial class Bateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bateria));
            this.pbBateria = new System.Windows.Forms.PictureBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBateria)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBateria
            // 
            this.pbBateria.Image = ((System.Drawing.Image)(resources.GetObject("pbBateria.Image")));
            this.pbBateria.Location = new System.Drawing.Point(12, 12);
            this.pbBateria.Name = "pbBateria";
            this.pbBateria.Size = new System.Drawing.Size(68, 76);
            this.pbBateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBateria.TabIndex = 0;
            this.pbBateria.TabStop = false;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(86, 12);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(275, 76);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // Bateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 100);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.pbBateria);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Bateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batería";
            ((System.ComponentModel.ISupportInitialize)(this.pbBateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBateria;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}