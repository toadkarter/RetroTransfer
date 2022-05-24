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
            this.sendButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.configurationTab = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.retropieDirectoryField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ipAddressField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.romDisplayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dropRomsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mainTabControl.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.configurationTab.SuspendLayout();
            this.romDisplayContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendButton.Depth = 0;
            this.sendButton.Location = new System.Drawing.Point(179, 318);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.Primary = false;
            this.sendButton.Size = new System.Drawing.Size(50, 36);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send!";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.mainTabControl;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-1, 59);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(447, 44);
            this.materialTabSelector2.TabIndex = 16;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTab);
            this.mainTabControl.Controls.Add(this.configurationTab);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(2, 109);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(434, 401);
            this.mainTabControl.TabIndex = 17;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.romDisplayContainer);
            this.mainTab.Controls.Add(this.sendButton);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(426, 375);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // configurationTab
            // 
            this.configurationTab.BackColor = System.Drawing.Color.White;
            this.configurationTab.Controls.Add(this.materialFlatButton1);
            this.configurationTab.Controls.Add(this.retropieDirectoryField);
            this.configurationTab.Controls.Add(this.passwordField);
            this.configurationTab.Controls.Add(this.usernameField);
            this.configurationTab.Controls.Add(this.ipAddressField);
            this.configurationTab.Controls.Add(this.materialLabel4);
            this.configurationTab.Controls.Add(this.materialLabel3);
            this.configurationTab.Controls.Add(this.materialLabel2);
            this.configurationTab.Controls.Add(this.materialLabel1);
            this.configurationTab.Location = new System.Drawing.Point(4, 22);
            this.configurationTab.Name = "configurationTab";
            this.configurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.configurationTab.Size = new System.Drawing.Size(426, 375);
            this.configurationTab.TabIndex = 1;
            this.configurationTab.Text = "Configuration";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(145, 278);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(133, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Save and Return";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.SaveAndReturnButton_Click);
            // 
            // retropieDirectoryField
            // 
            this.retropieDirectoryField.Depth = 0;
            this.retropieDirectoryField.Hint = "";
            this.retropieDirectoryField.Location = new System.Drawing.Point(145, 198);
            this.retropieDirectoryField.MouseState = MaterialSkin.MouseState.HOVER;
            this.retropieDirectoryField.Name = "retropieDirectoryField";
            this.retropieDirectoryField.PasswordChar = '\0';
            this.retropieDirectoryField.SelectedText = "";
            this.retropieDirectoryField.SelectionLength = 0;
            this.retropieDirectoryField.SelectionStart = 0;
            this.retropieDirectoryField.Size = new System.Drawing.Size(237, 23);
            this.retropieDirectoryField.TabIndex = 7;
            this.retropieDirectoryField.UseSystemPasswordChar = false;
            // 
            // passwordField
            // 
            this.passwordField.Depth = 0;
            this.passwordField.Hint = "";
            this.passwordField.Location = new System.Drawing.Point(147, 144);
            this.passwordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.Size = new System.Drawing.Size(237, 23);
            this.passwordField.TabIndex = 6;
            this.passwordField.UseSystemPasswordChar = false;
            // 
            // usernameField
            // 
            this.usernameField.Depth = 0;
            this.usernameField.Hint = "";
            this.usernameField.Location = new System.Drawing.Point(145, 94);
            this.usernameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.SelectedText = "";
            this.usernameField.SelectionLength = 0;
            this.usernameField.SelectionStart = 0;
            this.usernameField.Size = new System.Drawing.Size(237, 23);
            this.usernameField.TabIndex = 5;
            this.usernameField.UseSystemPasswordChar = false;
            // 
            // ipAddressField
            // 
            this.ipAddressField.Depth = 0;
            this.ipAddressField.Hint = "";
            this.ipAddressField.Location = new System.Drawing.Point(145, 47);
            this.ipAddressField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipAddressField.Name = "ipAddressField";
            this.ipAddressField.PasswordChar = '\0';
            this.ipAddressField.SelectedText = "";
            this.ipAddressField.SelectionLength = 0;
            this.ipAddressField.SelectionStart = 0;
            this.ipAddressField.Size = new System.Drawing.Size(237, 23);
            this.ipAddressField.TabIndex = 4;
            this.ipAddressField.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(50, 198);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(66, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "RetroPie";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(48, 98);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Username";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(46, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Host Name";
            // 
            // romDisplayContainer
            // 
            this.romDisplayContainer.AllowDrop = true;
            this.romDisplayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.romDisplayContainer.AutoScroll = true;
            this.romDisplayContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.romDisplayContainer.Controls.Add(this.dropRomsLabel);
            this.romDisplayContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.romDisplayContainer.Location = new System.Drawing.Point(29, 59);
            this.romDisplayContainer.Name = "romDisplayContainer";
            this.romDisplayContainer.Size = new System.Drawing.Size(363, 210);
            this.romDisplayContainer.TabIndex = 4;
            this.romDisplayContainer.WrapContents = false;
            this.romDisplayContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragDrop);
            this.romDisplayContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragEnter);
            this.romDisplayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.romDisplayContainer_Paint);
            // 
            // dropRomsLabel
            // 
            this.dropRomsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropRomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.dropRomsLabel.Depth = 0;
            this.dropRomsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.dropRomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dropRomsLabel.Location = new System.Drawing.Point(3, 0);
            this.dropRomsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dropRomsLabel.Name = "dropRomsLabel";
            this.dropRomsLabel.Size = new System.Drawing.Size(339, 235);
            this.dropRomsLabel.TabIndex = 15;
            this.dropRomsLabel.Text = "- Drop ROMS Here -";
            this.dropRomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(437, 510);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.materialTabSelector2);
            this.Name = "Dashboard";
            this.Text = "RetroTransfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.mainTabControl.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.configurationTab.ResumeLayout(false);
            this.configurationTab.PerformLayout();
            this.romDisplayContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton sendButton;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage configurationTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordField;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameField;
        private MaterialSkin.Controls.MaterialSingleLineTextField ipAddressField;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField retropieDirectoryField;
        private System.Windows.Forms.FlowLayoutPanel romDisplayContainer;
        private MaterialSkin.Controls.MaterialLabel dropRomsLabel;
    }
}

