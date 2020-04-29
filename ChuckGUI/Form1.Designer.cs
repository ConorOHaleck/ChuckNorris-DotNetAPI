namespace ChuckGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.cateBox = new System.Windows.Forms.ListBox();
            this.jokeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Joke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cateBox
            // 
            this.cateBox.FormattingEnabled = true;
            this.cateBox.ItemHeight = 20;
            this.cateBox.Location = new System.Drawing.Point(160, 201);
            this.cateBox.Name = "cateBox";
            this.cateBox.Size = new System.Drawing.Size(113, 124);
            this.cateBox.TabIndex = 1;
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(40, 69);
            this.jokeBox.Multiline = true;
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(356, 116);
            this.jokeBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 348);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.cateBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox cateBox;
        private System.Windows.Forms.TextBox jokeBox;
    }
}

