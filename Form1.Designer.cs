namespace DiaryMaker
{
    partial class LoginForm
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
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.CreateNewOneLabel = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginGroupBox.Controls.Add(this.UserNameLabel);
            this.LoginGroupBox.Controls.Add(this.CreateNewOneLabel);
            this.LoginGroupBox.Controls.Add(this.SignUpbutton);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UsernameTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(64, 41);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(716, 554);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Enter += new System.EventHandler(this.LoginGroupBox_Enter);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(92, 57);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(114, 23);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "User Name:";
            // 
            // CreateNewOneLabel
            // 
            this.CreateNewOneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateNewOneLabel.AutoSize = true;
            this.CreateNewOneLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CreateNewOneLabel.Location = new System.Drawing.Point(188, 352);
            this.CreateNewOneLabel.Name = "CreateNewOneLabel";
            this.CreateNewOneLabel.Size = new System.Drawing.Size(170, 23);
            this.CreateNewOneLabel.TabIndex = 6;
            this.CreateNewOneLabel.Text = "Create New One :";
            this.CreateNewOneLabel.Click += new System.EventHandler(this.CreateNewOneLabel_Click);
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.ForeColor = System.Drawing.Color.Black;
            this.SignUpbutton.Location = new System.Drawing.Point(419, 331);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(110, 64);
            this.SignUpbutton.TabIndex = 5;
            this.SignUpbutton.Text = "SignUp";
            this.SignUpbutton.UseVisualStyleBackColor = false;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BackColor = System.Drawing.Color.Navy;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(419, 168);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(110, 64);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(223, 109);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(306, 30);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(92, 112);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(110, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password :";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(223, 50);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(306, 30);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(869, 652);
            this.Controls.Add(this.LoginGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label CreateNewOneLabel;
        private System.Windows.Forms.Label UserNameLabel;
    }
}

