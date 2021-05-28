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
    public partial class UserAddForm : Form
    {
        private bool priv = false;
        public UserAddForm()
        {
            InitializeComponent();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            priv = true;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            priv = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            String username = UsernameText.Text;
            String newpass = NewPassText.Text;
            String account = Account.Text;
            int loop = 1;
            String newState = "TRUE";
            String privText = "";
            if(priv == true)
            {
                privText = "Admin";
            }
            else
            {
                privText = "Normal";
            }
            XmlDocument userInfo = new XmlDocument();
            while (loop != 6)
            {
                int newLoop = loop + 1;
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + newLoop + ".xml");
                String state = "";
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
                }
                if (state.Equals("TRUE"))
                {
                    loop++;
                }
                else
                {
                    foreach (XmlNode node in userInfo.DocumentElement)
                    {
                        String name = node.Attributes[0].Value;
                        if (name == "State")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = newState;
                            }
                        }
                        if (name == "Name")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = account;
                            }
                        }
                        if (name == "Privilage")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = privText;
                            }
                        }
                        if (name == "Username")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = username;
                            }
                        }
                        if (name == "Password")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = newpass;
                            }
                        }
                    }
                    userInfo.Save(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + newLoop + ".xml");
                    loop = 6;
                }
            }
            this.Close();
        }
    }
}
