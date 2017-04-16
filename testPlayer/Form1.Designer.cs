namespace testPlayer
{
    partial class DisplayForm
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
            this.pictureBoxForDisplay = new System.Windows.Forms.PictureBox();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForDisplay
            // 
            this.pictureBoxForDisplay.Location = new System.Drawing.Point(156, 48);
            this.pictureBoxForDisplay.Name = "pictureBoxForDisplay";
            this.pictureBoxForDisplay.Size = new System.Drawing.Size(741, 450);
            this.pictureBoxForDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxForDisplay.TabIndex = 1;
            this.pictureBoxForDisplay.TabStop = false;
            this.pictureBoxForDisplay.Click += new System.EventHandler(this.pictureBoxForDisplay_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(226, 12);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(430, 20);
            this.URLTextBox.TabIndex = 2;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(671, 9);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 574);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.pictureBoxForDisplay);
            this.Name = "DisplayForm";
            this.Text = "ScreenSharingDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForDisplay;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button PlayButton;
    }
}

