namespace RetroTransferUI
{
    partial class RomUploadForm
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
            this.romUploadThread = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dummyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // romUploadThread
            // 
            this.romUploadThread.WorkerReportsProgress = true;
            this.romUploadThread.WorkerSupportsCancellation = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(147, 133);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(265, 23);
            this.progressBar.TabIndex = 0;
            // 
            // dummyTextBox
            // 
            this.dummyTextBox.Location = new System.Drawing.Point(39, 84);
            this.dummyTextBox.Name = "dummyTextBox";
            this.dummyTextBox.Size = new System.Drawing.Size(482, 20);
            this.dummyTextBox.TabIndex = 1;
            // 
            // RomUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(546, 354);
            this.Controls.Add(this.dummyTextBox);
            this.Controls.Add(this.progressBar);
            this.Name = "RomUploadForm";
            this.Text = "RomUploadForm";
            this.Load += new System.EventHandler(this.RomUploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker romUploadThread;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox dummyTextBox;
    }
}