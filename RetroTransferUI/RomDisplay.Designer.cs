namespace RetroTransferUI
{
    partial class RomDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.platformsList = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.romName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // platformsList
            // 
            this.platformsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.platformsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.platformsList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(15)))));
            this.platformsList.FormattingEnabled = true;
            this.platformsList.Location = new System.Drawing.Point(179, 18);
            this.platformsList.Name = "platformsList";
            this.platformsList.Size = new System.Drawing.Size(121, 20);
            this.platformsList.TabIndex = 1;
            this.platformsList.SelectedIndexChanged += new System.EventHandler(this.PlatformList_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.deleteButton.Location = new System.Drawing.Point(306, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(20, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // romName
            // 
            this.romName.AutoEllipsis = true;
            this.romName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.romName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.romName.Location = new System.Drawing.Point(13, 22);
            this.romName.Margin = new System.Windows.Forms.Padding(3);
            this.romName.Name = "romName";
            this.romName.Size = new System.Drawing.Size(160, 13);
            this.romName.TabIndex = 8;
            this.romName.Text = "ROM FILE NAME";
            // 
            // RomDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(141)))));
            this.Controls.Add(this.romName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.platformsList);
            this.Name = "RomDisplay";
            this.Size = new System.Drawing.Size(343, 57);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox platformsList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label romName;
    }
}
