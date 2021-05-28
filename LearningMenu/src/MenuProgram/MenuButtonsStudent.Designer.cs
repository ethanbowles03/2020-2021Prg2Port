namespace MenuProgramEB
{
    partial class MenuButtonsStudent
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
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.White;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.viewButton.Location = new System.Drawing.Point(607, 13);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(191, 94);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "VIEW SELECTION";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // MenuButtonsStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(810, 119);
            this.Controls.Add(this.viewButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuButtonsStudent";
            this.Text = "MenuButtonsStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewButton;
    }
}