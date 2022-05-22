namespace RetroTransferUI
{
    partial class RaspberryPiConfig
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.retropieDirectoryField = new System.Windows.Forms.TextBox();
            this.raspberryPiConfigTitleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(190)))));
            this.nameField.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.nameField.Location = new System.Drawing.Point(188, 93);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(186, 32);
            this.nameField.TabIndex = 0;
            this.nameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.hostNameLabel.Location = new System.Drawing.Point(51, 96);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(128, 24);
            this.hostNameLabel.TabIndex = 9;
            this.hostNameLabel.Text = "Host Name:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.userNameLabel.Location = new System.Drawing.Point(51, 141);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(121, 24);
            this.userNameLabel.TabIndex = 10;
            this.userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.passwordLabel.Location = new System.Drawing.Point(51, 185);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(117, 24);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(190)))));
            this.usernameField.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.usernameField.Location = new System.Drawing.Point(188, 138);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(186, 32);
            this.usernameField.TabIndex = 12;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(190)))));
            this.passwordField.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.passwordField.Location = new System.Drawing.Point(188, 182);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(186, 32);
            this.passwordField.TabIndex = 13;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save and Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(75, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "RetroPie Install Directory:";
            // 
            // retropieDirectoryField
            // 
            this.retropieDirectoryField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(190)))));
            this.retropieDirectoryField.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retropieDirectoryField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.retropieDirectoryField.Location = new System.Drawing.Point(36, 275);
            this.retropieDirectoryField.Name = "retropieDirectoryField";
            this.retropieDirectoryField.Size = new System.Drawing.Size(356, 32);
            this.retropieDirectoryField.TabIndex = 16;
            this.retropieDirectoryField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raspberryPiConfigTitleText
            // 
            this.raspberryPiConfigTitleText.AutoSize = true;
            this.raspberryPiConfigTitleText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raspberryPiConfigTitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(146)))));
            this.raspberryPiConfigTitleText.Location = new System.Drawing.Point(12, 25);
            this.raspberryPiConfigTitleText.Name = "raspberryPiConfigTitleText";
            this.raspberryPiConfigTitleText.Size = new System.Drawing.Size(400, 33);
            this.raspberryPiConfigTitleText.TabIndex = 17;
            this.raspberryPiConfigTitleText.Text = "Raspberry Pi Configuration";
            // 
            // RaspberryPiConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(418, 426);
            this.Controls.Add(this.raspberryPiConfigTitleText);
            this.Controls.Add(this.retropieDirectoryField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.nameField);
            this.Name = "RaspberryPiConfig";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox retropieDirectoryField;
        private System.Windows.Forms.Label raspberryPiConfigTitleText;
    }
}