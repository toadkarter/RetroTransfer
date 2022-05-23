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
            this.sendingText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // romUploadThread
            // 
            this.romUploadThread.WorkerReportsProgress = true;
            this.romUploadThread.WorkerSupportsCancellation = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(43, 114);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(343, 23);
            this.progressBar.TabIndex = 0;
            // 
            // sendingText
            // 
            this.sendingText.AutoEllipsis = true;
            this.sendingText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.sendingText.Location = new System.Drawing.Point(43, 83);
            this.sendingText.Name = "sendingText";
            this.sendingText.Size = new System.Drawing.Size(343, 28);
            this.sendingText.TabIndex = 9;
            this.sendingText.Text = "SENDING";
            this.sendingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "TRANSFERRING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.Enabled = false;
            this.returnButton.Location = new System.Drawing.Point(176, 166);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RomUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(424, 220);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendingText);
            this.Controls.Add(this.progressBar);
            this.Name = "RomUploadForm";
            this.Text = "RomUploadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker romUploadThread;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label sendingText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
    }
}