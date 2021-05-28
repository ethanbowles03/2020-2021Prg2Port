namespace MenuProgramEB
{
    partial class MenuButtons
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
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.White;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.viewButton.Location = new System.Drawing.Point(616, 13);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(191, 94);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "VIEW SELECTION";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addButton.Location = new System.Drawing.Point(10, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 94);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "ADD COURSE";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(310, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE COURSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(810, 119);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuButtons";
            this.Text = "UserButtons";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
    }
}