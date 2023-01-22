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
            this.chooseFolderBTN = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseFolderBTN
            // 
            this.chooseFolderBTN.Location = new System.Drawing.Point(249, 199);
            this.chooseFolderBTN.Name = "chooseFolderBTN";
            this.chooseFolderBTN.Size = new System.Drawing.Size(131, 29);
            this.chooseFolderBTN.TabIndex = 0;
            this.chooseFolderBTN.Text = "Choose a folder";
            this.chooseFolderBTN.UseVisualStyleBackColor = true;
            this.chooseFolderBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(41, 192);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(125, 27);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.chooseFolderBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseFolderBTN;
        private TextBox textBoxDisplay;
    }
}