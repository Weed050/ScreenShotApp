namespace ScreenShotApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chooseFolderBTN = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFolderBTN
            // 
            this.chooseFolderBTN.Location = new System.Drawing.Point(360, 192);
            this.chooseFolderBTN.Name = "chooseFolderBTN";
            this.chooseFolderBTN.Size = new System.Drawing.Size(131, 29);
            this.chooseFolderBTN.TabIndex = 0;
            this.chooseFolderBTN.Text = "Choose a folder";
            this.chooseFolderBTN.UseVisualStyleBackColor = true;
            this.chooseFolderBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(21, 192);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(160, 27);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.chooseFolderBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Screen Shot App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseFolderBTN;
        private TextBox textBoxDisplay;
        private PictureBox pictureBox1;
    }
}