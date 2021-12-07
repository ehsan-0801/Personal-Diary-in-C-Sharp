namespace DiaryMaker
{
    partial class MainDairy
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
            this.MainDiaryPanel = new System.Windows.Forms.Panel();
            this.ImportaneLabel = new System.Windows.Forms.Label();
            this.ImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.UploadPictureBox = new System.Windows.Forms.PictureBox();
            this.MainDiaryTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChooseDateLabel = new System.Windows.Forms.Label();
            this.MainDiaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDiaryPanel
            // 
            this.MainDiaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDiaryPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.MainDiaryPanel.Controls.Add(this.ImportaneLabel);
            this.MainDiaryPanel.Controls.Add(this.ImportanceComboBox);
            this.MainDiaryPanel.Controls.Add(this.UploadButton);
            this.MainDiaryPanel.Controls.Add(this.UploadPictureBox);
            this.MainDiaryPanel.Location = new System.Drawing.Point(630, 3);
            this.MainDiaryPanel.Name = "MainDiaryPanel";
            this.MainDiaryPanel.Size = new System.Drawing.Size(239, 577);
            this.MainDiaryPanel.TabIndex = 0;
            this.MainDiaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ImportaneLabel
            // 
            this.ImportaneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportaneLabel.AutoSize = true;
            this.ImportaneLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportaneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImportaneLabel.Location = new System.Drawing.Point(3, 374);
            this.ImportaneLabel.Name = "ImportaneLabel";
            this.ImportaneLabel.Size = new System.Drawing.Size(91, 19);
            this.ImportaneLabel.TabIndex = 5;
            this.ImportaneLabel.Text = "Importance";
            this.ImportaneLabel.Click += new System.EventHandler(this.ImportaneLabel_Click);
            // 
            // ImportanceComboBox
            // 
            this.ImportanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportanceComboBox.FormattingEnabled = true;
            this.ImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.ImportanceComboBox.Location = new System.Drawing.Point(115, 367);
            this.ImportanceComboBox.Name = "ImportanceComboBox";
            this.ImportanceComboBox.Size = new System.Drawing.Size(121, 24);
            this.ImportanceComboBox.TabIndex = 4;
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.Location = new System.Drawing.Point(85, 288);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(110, 51);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "UPLOAD";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadPictureBox.BackColor = System.Drawing.Color.White;
            this.UploadPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadPictureBox.Location = new System.Drawing.Point(12, 12);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(215, 221);
            this.UploadPictureBox.TabIndex = 2;
            this.UploadPictureBox.TabStop = false;
            this.UploadPictureBox.Click += new System.EventHandler(this.UploadpictureBox_Click);
            // 
            // MainDiaryTextBox
            // 
            this.MainDiaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDiaryTextBox.Location = new System.Drawing.Point(12, 39);
            this.MainDiaryTextBox.Multiline = true;
            this.MainDiaryTextBox.Name = "MainDiaryTextBox";
            this.MainDiaryTextBox.Size = new System.Drawing.Size(601, 541);
            this.MainDiaryTextBox.TabIndex = 1;
            this.MainDiaryTextBox.TextChanged += new System.EventHandler(this.MainDiaryTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Location = new System.Drawing.Point(12, 586);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 37);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.DarkGray;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(740, 586);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 37);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Location = new System.Drawing.Point(413, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker.TabIndex = 8;
            // 
            // ChooseDateLabel
            // 
            this.ChooseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseDateLabel.AutoSize = true;
            this.ChooseDateLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseDateLabel.Location = new System.Drawing.Point(282, 12);
            this.ChooseDateLabel.Name = "ChooseDateLabel";
            this.ChooseDateLabel.Size = new System.Drawing.Size(109, 19);
            this.ChooseDateLabel.TabIndex = 9;
            this.ChooseDateLabel.Text = "Choose Date:";
            // 
            // MainDairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(869, 652);
            this.Controls.Add(this.ChooseDateLabel);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainDiaryTextBox);
            this.Controls.Add(this.MainDiaryPanel);
            this.Name = "MainDairy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dairy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDairy_FormClosing);
            this.Load += new System.EventHandler(this.MainDairy_Load);
            this.MainDiaryPanel.ResumeLayout(false);
            this.MainDiaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainDiaryPanel;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox UploadPictureBox;
        private System.Windows.Forms.TextBox MainDiaryTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox ImportanceComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label ImportaneLabel;
        private System.Windows.Forms.Label ChooseDateLabel;
    }
}