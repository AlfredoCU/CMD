namespace tetris_cs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button1 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.cbPausar = new System.Windows.Forms.CheckBox();
            this.wmpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbTetris = new System.Windows.Forms.PictureBox();
            this.shapePreview1 = new tetris_cs.ShapePreview();
            this.game = new tetris_cs.game();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapePreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(6, 124);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(89, 68);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Nuevo Juego";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Teal;
            this.lblScore.Location = new System.Drawing.Point(6, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 24);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "000000";
            // 
            // gbControl
            // 
            this.gbControl.BackColor = System.Drawing.Color.Black;
            this.gbControl.Controls.Add(this.cbPausar);
            this.gbControl.Controls.Add(this.wmpMusica);
            this.gbControl.Controls.Add(this.pbTetris);
            this.gbControl.Controls.Add(this.shapePreview1);
            this.gbControl.Controls.Add(this.Button1);
            this.gbControl.Controls.Add(this.lblScore);
            this.gbControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.ForeColor = System.Drawing.Color.Red;
            this.gbControl.Location = new System.Drawing.Point(220, 3);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(101, 337);
            this.gbControl.TabIndex = 8;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Puntuación";
            // 
            // cbPausar
            // 
            this.cbPausar.AutoSize = true;
            this.cbPausar.ForeColor = System.Drawing.Color.White;
            this.cbPausar.Location = new System.Drawing.Point(18, 198);
            this.cbPausar.Name = "cbPausar";
            this.cbPausar.Size = new System.Drawing.Size(77, 22);
            this.cbPausar.TabIndex = 10;
            this.cbPausar.Text = "Música";
            this.cbPausar.UseVisualStyleBackColor = true;
            this.cbPausar.CheckedChanged += new System.EventHandler(this.cbPausar_CheckedChanged);
            // 
            // wmpMusica
            // 
            this.wmpMusica.Enabled = true;
            this.wmpMusica.Location = new System.Drawing.Point(91, 326);
            this.wmpMusica.Name = "wmpMusica";
            this.wmpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusica.OcxState")));
            this.wmpMusica.Size = new System.Drawing.Size(10, 10);
            this.wmpMusica.TabIndex = 9;
            this.wmpMusica.Visible = false;
            // 
            // pbTetris
            // 
            this.pbTetris.Image = ((System.Drawing.Image)(resources.GetObject("pbTetris.Image")));
            this.pbTetris.Location = new System.Drawing.Point(6, 227);
            this.pbTetris.Name = "pbTetris";
            this.pbTetris.Size = new System.Drawing.Size(89, 93);
            this.pbTetris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTetris.TabIndex = 8;
            this.pbTetris.TabStop = false;
            // 
            // shapePreview1
            // 
            this.shapePreview1.AllowUserToAddRows = false;
            this.shapePreview1.AllowUserToDeleteRows = false;
            this.shapePreview1.AllowUserToResizeColumns = false;
            this.shapePreview1.AllowUserToResizeRows = false;
            this.shapePreview1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shapePreview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapePreview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapePreview1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shapePreview1.DefaultCellStyle = dataGridViewCellStyle1;
            this.shapePreview1.GridColor = System.Drawing.Color.Black;
            this.shapePreview1.Location = new System.Drawing.Point(21, 52);
            this.shapePreview1.Name = "shapePreview1";
            this.shapePreview1.RowHeadersVisible = false;
            this.shapePreview1.Size = new System.Drawing.Size(61, 66);
            this.shapePreview1.TabIndex = 0;
            // 
            // game
            // 
            this.game.AllowUserToAddRows = false;
            this.game.AllowUserToDeleteRows = false;
            this.game.AllowUserToResizeColumns = false;
            this.game.AllowUserToResizeRows = false;
            this.game.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.game.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.game.DefaultCellStyle = dataGridViewCellStyle2;
            this.game.GridColor = System.Drawing.Color.Black;
            this.game.Location = new System.Drawing.Point(12, 12);
            this.game.Name = "game";
            this.game.RowHeadersVisible = false;
            this.game.Size = new System.Drawing.Size(202, 327);
            this.game.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(335, 352);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.game);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapePreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label lblScore;
        private ShapePreview shapePreview1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.PictureBox pbTetris;
        private game game;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusica;
        private System.Windows.Forms.CheckBox cbPausar;
    }
}

