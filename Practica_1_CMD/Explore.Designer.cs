namespace Practica_1_CMD
{
    partial class Explore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explore));
            this.ilArchivos = new System.Windows.Forms.ImageList(this.components);
            this.lvArchivos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ilArchivos
            // 
            this.ilArchivos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilArchivos.ImageSize = new System.Drawing.Size(32, 32);
            this.ilArchivos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvArchivos
            // 
            this.lvArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvArchivos.LargeImageList = this.ilArchivos;
            this.lvArchivos.Location = new System.Drawing.Point(0, 0);
            this.lvArchivos.Name = "lvArchivos";
            this.lvArchivos.Size = new System.Drawing.Size(620, 351);
            this.lvArchivos.TabIndex = 0;
            this.lvArchivos.UseCompatibleStateImageBehavior = false;
            this.lvArchivos.SelectedIndexChanged += new System.EventHandler(this.lvArchivos_SelectedIndexChanged);
            // 
            // Explore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 351);
            this.Controls.Add(this.lvArchivos);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Explore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador";
            this.Load += new System.EventHandler(this.Explore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilArchivos;
        private System.Windows.Forms.ListView lvArchivos;
    }
}