namespace MenuProgramEB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignInIcon = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.UserNameIcon = new System.Windows.Forms.PictureBox();
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1390, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 552);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignInIcon
            // 
            this.SignInIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInIcon.BackColor = System.Drawing.Color.Transparent;
            this.SignInIcon.Image = ((System.Drawing.Image)(resources.GetObject("SignInIcon.Image")));
            this.SignInIcon.Location = new System.Drawing.Point(311, 75);
            this.SignInIcon.MaximumSize = new System.Drawing.Size(237, 198);
            this.SignInIcon.MinimumSize = new System.Drawing.Size(237, 198);
            this.SignInIcon.Name = "SignInIcon";
            this.SignInIcon.Size = new System.Drawing.Size(237, 198);
            this.SignInIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignInIcon.TabIndex = 2;
            this.SignInIcon.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.Font = new System.Drawing.Font("Arial", 20F);
            this.submitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.submitButton.Location = new System.Drawing.Point(-34, 743);
            this.submitButton.Margin = new System.Windows.Forms.Padding(0);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(909, 207);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Login";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserNameIcon
            // 
            this.UserNameIcon.BackColor = System.Drawing.Color.Transparent;
            this.UserNameIcon.Image = global::MenuProgramEB.Properties.Resources.UserNamIcon;
            this.UserNameIcon.Location = new System.Drawing.Point(93, 375);
            this.UserNameIcon.Name = "UserNameIcon";
            this.UserNameIcon.Size = new System.Drawing.Size(112, 104);
            this.UserNameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserNameIcon.TabIndex = 4;
            this.UserNameIcon.TabStop = false;
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIcon.Image = global::MenuProgramEB.Properties.Resources.PaswordIcon;
            this.PasswordIcon.Location = new System.Drawing.Point(93, 568);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(112, 79);
            this.PasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordIcon.TabIndex = 5;
            this.PasswordIcon.TabStop = false;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.White;
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.UserNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UserNameTextBox.Location = new System.Drawing.Point(235, 403);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(458, 54);
            this.UserNameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(235, 583);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(458, 54);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MenuProgramEB.Properties.Resources.green_teal_blue_fade_prints;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 888);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordIcon);
            this.Controls.Add(this.UserNameIcon);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignInIcon);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MaximumSize = new System.Drawing.Size(875, 976);
            this.MinimumSize = new System.Drawing.Size(875, 976);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SignInIcon;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox UserNameIcon;
        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
    }
}