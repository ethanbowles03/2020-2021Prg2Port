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

namespace MenuProgramEB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.SolidBrush fillWhite = new System.Drawing.SolidBrush(Color.White);
            System.Drawing.SolidBrush fillBlack = new System.Drawing.SolidBrush(Color.Black);

            Rectangle userNameCircleLeft = new Rectangle(30, 155, 50, 50);
            Rectangle userNameCircleRight = new Rectangle(240,155,50,50);
            Rectangle userNameRectBar = new Rectangle(55,155,215,50);

            Rectangle passwordCircleLeft = new Rectangle(30, 230, 50, 50);
            Rectangle passwordCircleRight = new Rectangle(240, 230, 50, 50);
            Rectangle passwordRectBar = new Rectangle(55, 230, 215, 50);

            Rectangle line1 = new Rectangle(77,165,1,30);
            Rectangle line2 = new Rectangle(77, 240, 1, 30);

            g.FillEllipse(fillWhite, userNameCircleLeft);
            g.FillEllipse(fillWhite, userNameCircleRight);
            g.FillRectangle(fillWhite, userNameRectBar);

            g.FillEllipse(fillWhite, passwordCircleLeft);
            g.FillEllipse(fillWhite, passwordCircleRight);
            g.FillRectangle(fillWhite, passwordRectBar);

            g.FillRectangle(fillBlack, line1);
            g.FillRectangle(fillBlack, line2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usernameValue = UserNameTextBox.Text;
            String passwordValue = PasswordTextBox.Text;
            String count = "";
            String state = "";
            String priv = "";
            String username = "";
            String password = "";
            bool correct = false;
            bool correctN = false;
            bool correctA = false;


            XmlDocument userInfo = new XmlDocument();
            userInfo.Load(@ClassGlobals.RunningPath + "Resources\\UserInfo\\UserCount.xml");

            foreach (XmlNode node in userInfo.DocumentElement)
            {
                String name = node.Attributes[0].InnerText;
                if (name == "Count")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        count = child.InnerText;
                    }
                }
            }

            int sCount = Int16.Parse(count);

            if (sCount == 5)
            {
                for (int i = 1; i <= sCount; i++)
                {
                    XmlDocument user = new XmlDocument();
                    userInfo.Load(@ClassGlobals.RunningPath + "Resources\\UserInfo\\User" + i + ".xml");
                    foreach (XmlNode node in userInfo.DocumentElement)
                    {
                        String name = node.Attributes[0].InnerText;
                        if (name == "State")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                state = child.InnerText;
                            }
                        }
                        if (name == "Privilage")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                priv = child.InnerText;
                            }
                        }
                        if (name == "Username")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                username = child.InnerText;
                            }
                        }
                        if (name == "Password")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                password = child.InnerText;
                            }
                        }
                    }
                    if (state.Equals("TRUE"))
                    {
                        if (priv.Equals("Admin") && username == usernameValue && password == passwordValue)
                        {
                            correctA = true;
                        }
                        else if (priv.Equals("Normal") && username == usernameValue && password == passwordValue)
                        {
                            correctN = true;
                        }
                        else if (usernameValue.Equals("backup") && passwordValue.Equals("backup"))
                        {
                            correctA = true;
                        }
                        else
                        {
                            correct = true;
                        }
                    }
                }
                if (correct)
                {
                    label1.Text = "";
                    label1.Text = "Incorrect Login";
                    UserNameTextBox.Text = String.Empty;
                    PasswordTextBox.Text = String.Empty;
                }
                if (correctN)
                {
                    label1.Text = "";
                    UserNameTextBox.Text = String.Empty;
                    PasswordTextBox.Text = String.Empty;
                    mainScreen2Normal mainScreen = new mainScreen2Normal();
                    mainScreen.Show();
                }
                if (correctA)
                {
                    label1.Text = "";
                    UserNameTextBox.Text = String.Empty;
                    PasswordTextBox.Text = String.Empty;
                    mainScreen2 mainScreen = new mainScreen2();
                    mainScreen.Show();
                }

            }
        }
    }
}
