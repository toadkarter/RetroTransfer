namespace RetroTransferUI
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
            this.helloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloWorld
            // 
            this.helloWorld.Location = new System.Drawing.Point(277, 129);
            this.helloWorld.Name = "helloWorld";
            this.helloWorld.Size = new System.Drawing.Size(257, 143);
            this.helloWorld.TabIndex = 0;
            this.helloWorld.Text = "Click Me!";
            this.helloWorld.UseVisualStyleBackColor = true;
            this.helloWorld.Click += new System.EventHandler(this.helloWorld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloWorld;
    }
}

