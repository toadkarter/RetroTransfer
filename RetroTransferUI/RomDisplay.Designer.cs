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
            this.platformExtensions = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.romName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // platformExtensions
            // 
            this.platformExtensions.FormattingEnabled = true;
            this.platformExtensions.Location = new System.Drawing.Point(219, 18);
            this.platformExtensions.Name = "platformExtensions";
            this.platformExtensions.Size = new System.Drawing.Size(121, 21);
            this.platformExtensions.TabIndex = 1;
            this.platformExtensions.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(346, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(20, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // romName
            // 
            this.romName.AutoEllipsis = true;
            this.romName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.romName.Location = new System.Drawing.Point(13, 18);
            this.romName.Margin = new System.Windows.Forms.Padding(3);
            this.romName.Name = "romName";
            this.romName.Size = new System.Drawing.Size(200, 23);
            this.romName.TabIndex = 8;
            this.romName.Text = "ROM FILE NAME";
            this.romName.Click += new System.EventHandler(this.label2_Click);
            // 
            // RomDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.romName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.platformExtensions);
            this.Name = "RomDisplay";
            this.Size = new System.Drawing.Size(381, 57);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox platformExtensions;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label romName;
    }
}
