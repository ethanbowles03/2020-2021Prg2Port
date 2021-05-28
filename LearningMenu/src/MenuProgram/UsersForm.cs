using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MenuProgramEB
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            String count = "";
            

            XmlDocument users  = new XmlDocument();
            users.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\UserCount.xml");

            foreach (XmlNode node in users.DocumentElement)
            {
                String index = node.Attributes[0].InnerText;
                if (index == "Count")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        count = child.InnerText;
                    }
                }
            }

            int sCount = Int16.Parse(count);

            String[] name = new String[sCount];
            String[] priv = new String[sCount];
            String[] username = new String[sCount];
            String[] password = new String[sCount];
            String[] state = new String[sCount];

            for (int i = 1; i <= sCount; i++)
            {
                XmlDocument user = new XmlDocument();
                user.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + i + ".xml");
                foreach (XmlNode node in user.DocumentElement)
                {
                    String index = node.Attributes[0].InnerText;
                    if (index == "State")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            state[i - 1] = child.InnerText;
                        }
                    }
                    if (index == "Name")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            name[i - 1] = child.InnerText;
                        }
                    }
                    if (index == "Privilage")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            priv[i -1] = child.InnerText;
                        }
                    }
                    if (index == "Username")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            username[i - 1] = child.InnerText;
                        }
                    }
                    if (index == "Password")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            password[i - 1] = child.InnerText;
                        }
                    }
                }
            }
            for (int i = 0; i < sCount; i++)
            {
                if (state[i].Equals("TRUE"))
                {
                    Panel userPanel = new Panel();
                    userPanel.BackColor = Color.White;
                    userPanel.Location = new Point(75, 80 + (175 * i));
                    userPanel.Size = new Size(750,125);
                    userPanel.BringToFront();

                    PictureBox pictureBoxUser = new PictureBox();
                    pictureBoxUser.Location = new Point(-5, -10);
                    pictureBoxUser.Name = "pictureBoxUser";
                    pictureBoxUser.Size = new Size(150, 150);
                    pictureBoxUser.BackColor = Color. White;
                    pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxUser.Image = Image.FromFile(@ClassGlobals.RunningPath + "Resources\\\\UserNamIcon.png");
                    userPanel.Controls.Add(pictureBoxUser);

                    Label userName = new Label();
                    userName.Location = new Point(140,30);
                    userName.Name = "UserLabel";
                    userName.Size = new Size(800,40);
                    userName.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    userName.ForeColor = Color.DimGray;
                    userName.Text = name[i];
                    userPanel.Controls.Add(userName);

                    Label privName = new Label();
                    privName.Location = new Point(140, 70);
                    privName.Name = "PrivLabel";
                    privName.Size = new Size(300, 30);
                    privName.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                    privName.ForeColor = Color.DarkGray;
                    if (priv[i].Equals("Admin"))
                    {
                        privName.Text = priv[i];
                    }
                    else
                    {
                        privName.Text = "Student";
                    }
                    
                    userPanel.Controls.Add(privName);

                    flowLayoutPanel1.Controls.Add(userPanel);
                } 
            }
        }

        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.SolidBrush fillWhite = new System.Drawing.SolidBrush(Color.White);
            System.Drawing.SolidBrush fillBlack = new System.Drawing.SolidBrush(Color.Black);

            Rectangle back = new Rectangle(0, 0, 2158, 55);
            Rectangle sep1 = new Rectangle(0, 0, 2158, 3);
            Rectangle sep2 = new Rectangle(0, 55, 2158, 3);

            g.FillRectangle(fillWhite, back);
            g.FillRectangle(fillBlack, sep1);
            g.FillRectangle(fillBlack, sep2);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UserEditForm edit = new UserEditForm();
            edit.ShowDialog();
            this.Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            this.Update();
        }

    }
}
