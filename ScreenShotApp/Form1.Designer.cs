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
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(192, 61);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(125, 27);
            this.textBoxTest.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.chooseFolderBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Screen Shot App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseFolderBTN;
        private TextBox textBoxDisplay;
        private TextBox textBoxTest;
        private Button button2;
    }
}