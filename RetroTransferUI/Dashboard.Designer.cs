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
            this.sendButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ipAddressField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.retropieDirectoryField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // romDisplayContainer
            // 
            this.romDisplayContainer.AllowDrop = true;
            this.romDisplayContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.romDisplayContainer.AutoScroll = true;
            this.romDisplayContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.romDisplayContainer.Location = new System.Drawing.Point(36, 35);
            this.romDisplayContainer.Name = "romDisplayContainer";
            this.romDisplayContainer.Size = new System.Drawing.Size(339, 247);
            this.romDisplayContainer.TabIndex = 4;
            this.romDisplayContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragDrop);
            this.romDisplayContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.RomDisplayContainer_DragEnter);
            this.romDisplayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.romDisplayContainer_Paint);
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendButton.Depth = 0;
            this.sendButton.Location = new System.Drawing.Point(178, 311);
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
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-1, 59);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(447, 44);
            this.materialTabSelector2.TabIndex = 16;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 109);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(434, 401);
            this.materialTabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.romDisplayContainer);
            this.tabPage1.Controls.Add(this.sendButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Controls.Add(this.retropieDirectoryField);
            this.tabPage2.Controls.Add(this.passwordField);
            this.tabPage2.Controls.Add(this.usernameField);
            this.tabPage2.Controls.Add(this.ipAddressField);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
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
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
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
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
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
            this.passwordField.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(437, 510);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector2);
            this.Name = "Dashboard";
            this.Text = "RetroTransfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel romDisplayContainer;
        private MaterialSkin.Controls.MaterialFlatButton sendButton;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordField;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameField;
        private MaterialSkin.Controls.MaterialSingleLineTextField ipAddressField;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField retropieDirectoryField;
    }
}

