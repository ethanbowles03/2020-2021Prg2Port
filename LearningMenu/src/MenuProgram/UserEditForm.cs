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
    public partial class UserEditForm : Form
    {
        private bool priv = false;
        private String val = "";
        private int[] count = new int[5];
        public UserEditForm()
        {
            InitializeComponent();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            String[] comboArray = setArray();
            for (int i = 0; i < 5; i++)
            {
                if (comboArray[i].Equals(""))
                {

                }
                else
                {
                    comboBox1.Items.Add(comboArray[i]);
                }
            }
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
            String pastUser = val;
            String newPriv = "";
            if (priv == true)
            {
                newPriv = "Admin";
            }
            else
            {
                newPriv = "Normal";
            }
            int userNum = checkVal(val);
            XmlDocument userInfo = new XmlDocument();
            userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + userNum +".xml");
            foreach (XmlNode node in userInfo.DocumentElement)
            {
                String name = node.Attributes[0].InnerText;
                if (name == "Name")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = account;
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
                if (name == "Privilage")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = newPriv;
                    }
                }
            }
            userInfo.Save(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + userNum + ".xml");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            val = comboBox1.Text;
        }

        private String[] setArray()
        {
            String state = "";
            String[] arr = new String[5];
            XmlDocument userInfo = new XmlDocument();
            for (int i = 0; i < 5; i++)
            {
                int num = i + 1;
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + num + ".xml");
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
                    count[i] = num;
                    userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + num + ".xml");
                    foreach (XmlNode node in userInfo.DocumentElement)
                    {
                        String name = node.Attributes[0].InnerText;
                        if (name == "Name")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                arr[i] = child.InnerText;
                            }
                        }
                    }
                }
                else
                {
                    arr[i] = "";
                }
            }
            return arr;
        }

        private int checkVal(String acc)
        {
            XmlDocument userInfo = new XmlDocument();

            String accountName = "";
            int ret = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = i + 1;
                
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + num + ".xml");
                foreach (XmlNode node in userInfo.DocumentElement)
                {
                    String name = node.Attributes[0].InnerText;
                    if (name == "Name")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            accountName = child.InnerText;
                        }
                    }
                }
                if (acc.Equals(accountName))
                {
                    ret = num;
                }
            }
            return ret;
        }
    }
}
