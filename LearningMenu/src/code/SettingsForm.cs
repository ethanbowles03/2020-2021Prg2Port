using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuProgramEB
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Size = new Size(500, 565);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            RoundButton buttonInventory = new RoundButton();
            buttonInventory.Text = "Inventory";
            buttonInventory.Font = new Font("Arial", 25);
            buttonInventory.BackColor = Color.White;
            EventHandler myHandlerInventory = new EventHandler(buttonInventory_Click);
            buttonInventory.Click += myHandlerInventory;
            buttonInventory.Size = new System.Drawing.Size(400, 75);
            buttonInventory.Location = new System.Drawing.Point(50, 80);
            this.Controls.Add(buttonInventory);

            RoundButton buttonUsers = new RoundButton();
            buttonUsers.Text = "Users";
            buttonUsers.Font = new Font("Arial", 25);
            buttonUsers.BackColor = Color.White;
            EventHandler myHandlerUsers = new EventHandler(buttonUsers_Click);
            buttonUsers.Click += myHandlerUsers;
            buttonUsers.Size = new System.Drawing.Size(400, 75);
            buttonUsers.Location = new System.Drawing.Point(50, 180);
            this.Controls.Add(buttonUsers);

            RoundButton buttonExport = new RoundButton();
            buttonExport.Text = "Export Logs";
            buttonExport.Font = new Font("Arial", 25);
            buttonExport.BackColor = Color.White;
            EventHandler myHandlerExport = new EventHandler(buttonExport_Click);
            buttonExport.Click += myHandlerExport;
            buttonExport.Size = new System.Drawing.Size(400, 75);
            buttonExport.Location = new System.Drawing.Point(50, 280);
            this.Controls.Add(buttonExport);

            RoundButton buttonClear = new RoundButton();
            buttonClear.Text = "Clear Logs";
            buttonClear.Font = new Font("Arial", 25);
            buttonClear.BackColor = Color.White;
            EventHandler myHandlerClear = new EventHandler(buttonClear_Click);
            buttonClear.Click += myHandlerClear;
            buttonClear.Size = new System.Drawing.Size(400, 75);
            buttonClear.Location = new System.Drawing.Point(50, 380);
            this.Controls.Add(buttonClear);
        }

        private void buttonInventory_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, System.EventArgs e)
        {
            UsersForm users = new UsersForm();
            users.Show();
        }

        private void buttonExport_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.SolidBrush fillWhite = new System.Drawing.SolidBrush(Color.White);
            System.Drawing.SolidBrush fillBlack = new System.Drawing.SolidBrush(Color.Black);

            Rectangle back = new Rectangle(0, 0, 520, 55);
            Rectangle sep1 = new Rectangle(0, 0, 520, 3);
            Rectangle sep2 = new Rectangle(0, 55, 520, 3);

            g.FillRectangle(fillWhite, back);
            g.FillRectangle(fillBlack, sep1);
            g.FillRectangle(fillBlack, sep2);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
