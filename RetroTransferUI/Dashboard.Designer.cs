namespace RetroTransferUI
{
    partial class Dashboard
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
            this.romDisplayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.configButton = new System.Windows.Forms.Button();
            this.headerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // romDisplayContainer
            // 
            this.romDisplayContainer.AllowDrop = true;
            this.romDisplayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.romDisplayContainer.AutoScroll = true;
            this.romDisplayContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.romDisplayContainer.Location = new System.Drawing.Point(70, 134);
            this.romDisplayContainer.Name = "romDisplayContainer";
            this.romDisplayContainer.Size = new System.Drawing.Size(425, 206);
            this.romDisplayContainer.TabIndex = 4;
            this.romDisplayContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragDrop);
            this.romDisplayContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragEnter);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(294, 376);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(147, 41);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send!";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(153, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Currently Selected:";
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(95, 366);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(153, 60);
            this.configButton.TabIndex = 9;
            this.configButton.Text = "Raspberry Pi Configuration";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.headerText.Location = new System.Drawing.Point(28, 33);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(720, 28);
            this.headerText.TabIndex = 10;
            this.headerText.Text = "PLEASE CONFIGURE RASPBERRY PI BEFORE PROCEEDING";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(859, 442);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.romDisplayContainer);
            this.Name = "Dashboard";
            this.Text = "RetroTransfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel romDisplayContainer;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Label headerText;
    }
}

