namespace OneDriveAPI
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
            this.authoriseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authoriseButton
            // 
            this.authoriseButton.Location = new System.Drawing.Point(166, 55);
            this.authoriseButton.Name = "authoriseButton";
            this.authoriseButton.Size = new System.Drawing.Size(75, 23);
            this.authoriseButton.TabIndex = 0;
            this.authoriseButton.Text = "Auth";
            this.authoriseButton.UseVisualStyleBackColor = true;
            this.authoriseButton.Click += new System.EventHandler(this.authoriseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 233);
            this.Controls.Add(this.authoriseButton);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authoriseButton;
    }
}

