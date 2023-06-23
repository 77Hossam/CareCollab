namespace DrPanel.UserControls
{
    partial class OCR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTaregt = new System.Windows.Forms.PictureBox();
            this.btnTxtConverted = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTaregt)).BeginInit();
            this.SuspendLayout();
            // 
            // picTaregt
            // 
            this.picTaregt.Location = new System.Drawing.Point(46, 77);
            this.picTaregt.Name = "picTaregt";
            this.picTaregt.Size = new System.Drawing.Size(403, 596);
            this.picTaregt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTaregt.TabIndex = 1;
            this.picTaregt.TabStop = false;
            this.picTaregt.Click += new System.EventHandler(this.picTaregt_Click);
            // 
            // btnTxtConverted
            // 
            this.btnTxtConverted.Location = new System.Drawing.Point(484, 77);
            this.btnTxtConverted.Name = "btnTxtConverted";
            this.btnTxtConverted.Size = new System.Drawing.Size(385, 596);
            this.btnTxtConverted.TabIndex = 129;
            this.btnTxtConverted.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.btnConvert.Location = new System.Drawing.Point(369, 723);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(216, 65);
            this.btnConvert.TabIndex = 130;
            this.btnConvert.Text = "Convert to Text";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // OCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnTxtConverted);
            this.Controls.Add(this.picTaregt);
            this.Name = "OCR";
            this.Size = new System.Drawing.Size(916, 821);
            this.Load += new System.EventHandler(this.OCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTaregt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTaregt;
        private System.Windows.Forms.RichTextBox btnTxtConverted;
        private System.Windows.Forms.Button btnConvert;
    }
}
