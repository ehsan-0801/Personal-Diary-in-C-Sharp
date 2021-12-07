namespace DiaryMaker
{
    partial class Update
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateBackButton = new System.Windows.Forms.Button();
            this.UpdateTextBox = new System.Windows.Forms.TextBox();
            this.MainDiaryPanel = new System.Windows.Forms.Panel();
            this.UpdateImportaneLabel = new System.Windows.Forms.Label();
            this.UpdateImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateUploadButton = new System.Windows.Forms.Button();
            this.UpdateUploadPictureBox = new System.Windows.Forms.PictureBox();
            this.MainDiaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Location = new System.Drawing.Point(407, 25);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker.TabIndex = 14;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.BackColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(734, 599);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 37);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateBackButton
            // 
            this.UpdateBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBackButton.BackColor = System.Drawing.Color.Red;
            this.UpdateBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBackButton.Location = new System.Drawing.Point(6, 599);
            this.UpdateBackButton.Name = "UpdateBackButton";
            this.UpdateBackButton.Size = new System.Drawing.Size(85, 37);
            this.UpdateBackButton.TabIndex = 12;
            this.UpdateBackButton.Text = "Back";
            this.UpdateBackButton.UseVisualStyleBackColor = false;
            this.UpdateBackButton.Click += new System.EventHandler(this.UpdateBackButton_Click);
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTextBox.Location = new System.Drawing.Point(6, 52);
            this.UpdateTextBox.Multiline = true;
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.Size = new System.Drawing.Size(601, 541);
            this.UpdateTextBox.TabIndex = 11;
            this.UpdateTextBox.TextChanged += new System.EventHandler(this.UpdateTextBox_TextChanged);
            // 
            // MainDiaryPanel
            // 
            this.MainDiaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDiaryPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.MainDiaryPanel.Controls.Add(this.UpdateImportaneLabel);
            this.MainDiaryPanel.Controls.Add(this.UpdateImportanceComboBox);
            this.MainDiaryPanel.Controls.Add(this.UpdateUploadButton);
            this.MainDiaryPanel.Controls.Add(this.UpdateUploadPictureBox);
            this.MainDiaryPanel.Location = new System.Drawing.Point(624, 16);
            this.MainDiaryPanel.Name = "MainDiaryPanel";
            this.MainDiaryPanel.Size = new System.Drawing.Size(239, 577);
            this.MainDiaryPanel.TabIndex = 10;
            // 
            // UpdateImportaneLabel
            // 
            this.UpdateImportaneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateImportaneLabel.AutoSize = true;
            this.UpdateImportaneLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateImportaneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateImportaneLabel.Location = new System.Drawing.Point(3, 374);
            this.UpdateImportaneLabel.Name = "UpdateImportaneLabel";
            this.UpdateImportaneLabel.Size = new System.Drawing.Size(91, 19);
            this.UpdateImportaneLabel.TabIndex = 5;
            this.UpdateImportaneLabel.Text = "Importance";
            // 
            // UpdateImportanceComboBox
            // 
            this.UpdateImportanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateImportanceComboBox.FormattingEnabled = true;
            this.UpdateImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.UpdateImportanceComboBox.Location = new System.Drawing.Point(115, 367);
            this.UpdateImportanceComboBox.Name = "UpdateImportanceComboBox";
            this.UpdateImportanceComboBox.Size = new System.Drawing.Size(121, 24);
            this.UpdateImportanceComboBox.TabIndex = 4;
            // 
            // UpdateUploadButton
            // 
            this.UpdateUploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateUploadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateUploadButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUploadButton.Location = new System.Drawing.Point(85, 288);
            this.UpdateUploadButton.Name = "UpdateUploadButton";
            this.UpdateUploadButton.Size = new System.Drawing.Size(110, 51);
            this.UpdateUploadButton.TabIndex = 3;
            this.UpdateUploadButton.Text = "UPLOAD";
            this.UpdateUploadButton.UseVisualStyleBackColor = false;
            this.UpdateUploadButton.Click += new System.EventHandler(this.UpdateUploadButton_Click);
            // 
            // UpdateUploadPictureBox
            // 
            this.UpdateUploadPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateUploadPictureBox.BackColor = System.Drawing.Color.White;
            this.UpdateUploadPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateUploadPictureBox.Location = new System.Drawing.Point(12, 12);
            this.UpdateUploadPictureBox.Name = "UpdateUploadPictureBox";
            this.UpdateUploadPictureBox.Size = new System.Drawing.Size(215, 221);
            this.UpdateUploadPictureBox.TabIndex = 2;
            this.UpdateUploadPictureBox.TabStop = false;
            this.UpdateUploadPictureBox.Click += new System.EventHandler(this.UpdateUploadPictureBox_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 652);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.UpdateBackButton);
            this.Controls.Add(this.UpdateTextBox);
            this.Controls.Add(this.MainDiaryPanel);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_FormClosing);
            this.Load += new System.EventHandler(this.Update_Load);
            this.MainDiaryPanel.ResumeLayout(false);
            this.MainDiaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateUploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UpdateBackButton;
        private System.Windows.Forms.TextBox UpdateTextBox;
        private System.Windows.Forms.Panel MainDiaryPanel;
        private System.Windows.Forms.Label UpdateImportaneLabel;
        private System.Windows.Forms.ComboBox UpdateImportanceComboBox;
        private System.Windows.Forms.Button UpdateUploadButton;
        private System.Windows.Forms.PictureBox UpdateUploadPictureBox;
    }
}