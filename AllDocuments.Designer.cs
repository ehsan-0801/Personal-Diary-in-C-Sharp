namespace DiaryMaker
{
    partial class AllDocuments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.ModifyingGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EventnoTextBox = new System.Windows.Forms.TextBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackDcButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.ModifyingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.GridColor = System.Drawing.Color.Black;
            this.EventDataGridView.Location = new System.Drawing.Point(374, 0);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.ReadOnly = true;
            this.EventDataGridView.RowHeadersWidth = 51;
            this.EventDataGridView.RowTemplate.Height = 24;
            this.EventDataGridView.Size = new System.Drawing.Size(494, 141);
            this.EventDataGridView.TabIndex = 0;
            // 
            // ModifyingGroupBox
            // 
            this.ModifyingGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ModifyingGroupBox.Controls.Add(this.UpdateButton);
            this.ModifyingGroupBox.Controls.Add(this.EventnoTextBox);
            this.ModifyingGroupBox.Controls.Add(this.EventLabel);
            this.ModifyingGroupBox.Controls.Add(this.DeleteButton);
            this.ModifyingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ModifyingGroupBox.Name = "ModifyingGroupBox";
            this.ModifyingGroupBox.Size = new System.Drawing.Size(314, 192);
            this.ModifyingGroupBox.TabIndex = 1;
            this.ModifyingGroupBox.TabStop = false;
            this.ModifyingGroupBox.Text = "Modify";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gray;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Location = new System.Drawing.Point(111, 94);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EventnoTextBox
            // 
            this.EventnoTextBox.Location = new System.Drawing.Point(111, 38);
            this.EventnoTextBox.Name = "EventnoTextBox";
            this.EventnoTextBox.Size = new System.Drawing.Size(181, 22);
            this.EventnoTextBox.TabIndex = 10;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.BackColor = System.Drawing.Color.Gray;
            this.EventLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventLabel.Location = new System.Drawing.Point(6, 43);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(74, 17);
            this.EventLabel.TabIndex = 10;
            this.EventLabel.Text = "Event No :";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Location = new System.Drawing.Point(217, 94);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackDcButton
            // 
            this.BackDcButton.BackColor = System.Drawing.Color.Red;
            this.BackDcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackDcButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackDcButton.ForeColor = System.Drawing.Color.Black;
            this.BackDcButton.Location = new System.Drawing.Point(739, 584);
            this.BackDcButton.Name = "BackDcButton";
            this.BackDcButton.Size = new System.Drawing.Size(118, 56);
            this.BackDcButton.TabIndex = 9;
            this.BackDcButton.Text = "Log Out";
            this.BackDcButton.UseVisualStyleBackColor = false;
            this.BackDcButton.Click += new System.EventHandler(this.BackDcButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.BackColor = System.Drawing.Color.Gray;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateButton.Location = new System.Drawing.Point(12, 267);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(143, 81);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create Another";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AllDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(869, 652);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BackDcButton);
            this.Controls.Add(this.ModifyingGroupBox);
            this.Controls.Add(this.EventDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AllDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllDocuments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllDocuments_FormClosing);
            this.Load += new System.EventHandler(this.AllDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ModifyingGroupBox.ResumeLayout(false);
            this.ModifyingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.GroupBox ModifyingGroupBox;
        private System.Windows.Forms.Button BackDcButton;
        private System.Windows.Forms.TextBox EventnoTextBox;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CreateButton;
    }
}