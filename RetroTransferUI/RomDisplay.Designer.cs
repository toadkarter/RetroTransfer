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
            this.romName = new System.Windows.Forms.Label();
            this.platformExtensions = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // romName
            // 
            this.romName.AutoSize = true;
            this.romName.Location = new System.Drawing.Point(17, 21);
            this.romName.Name = "romName";
            this.romName.Size = new System.Drawing.Size(35, 13);
            this.romName.TabIndex = 0;
            this.romName.Text = "label1";
            this.romName.Click += new System.EventHandler(this.label1_Click);
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
            // 
            // RomDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.platformExtensions);
            this.Controls.Add(this.romName);
            this.Name = "RomDisplay";
            this.Size = new System.Drawing.Size(381, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label romName;
        private System.Windows.Forms.ComboBox platformExtensions;
        private System.Windows.Forms.Button deleteButton;
    }
}
