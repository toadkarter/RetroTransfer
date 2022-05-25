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
            this.sendingText = new MaterialSkin.Controls.MaterialLabel();
            this.returnButton = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.sendingText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendingText.AutoEllipsis = true;
            this.sendingText.BackColor = System.Drawing.Color.Transparent;
            this.sendingText.Depth = 0;
            this.sendingText.Font = new System.Drawing.Font("Roboto", 11F);
            this.sendingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sendingText.Location = new System.Drawing.Point(43, 83);
            this.sendingText.MaximumSize = new System.Drawing.Size(343, 20);
            this.sendingText.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendingText.Name = "sendingText";
            this.sendingText.Size = new System.Drawing.Size(343, 20);
            this.sendingText.TabIndex = 12;
            this.sendingText.Text = "Trying to connect to Raspberry Pi...";
            this.sendingText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnButton
            // 
            this.returnButton.Depth = 0;
            this.returnButton.Enabled = false;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.Location = new System.Drawing.Point(178, 158);
            this.returnButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnButton.Name = "returnButton";
            this.returnButton.Primary = true;
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RomUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 220);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.sendingText);
            this.Controls.Add(this.progressBar);
            this.Name = "RomUploadForm";
            this.Text = "Transferring";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker romUploadThread;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel sendingText;
        private MaterialSkin.Controls.MaterialRaisedButton returnButton;
    }
}