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
    public partial class UserButtons : Form
    {
        private bool addCheck = false;
        private bool delCheck = false;
        public UserButtons()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UserEditForm edit = new UserEditForm();
            edit.ShowDialog();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool clear = checkAddError();
            if (clear == true)
            {
                MessageBox.Show("To many accounts!");
            }else
            {
                UserAddForm add = new UserAddForm();
                add.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool check =  checkDelError();
            if (delCheck == true)
            {
                MessageBox.Show("To must have at least one account!");
            }
            else
            {
                UserDeleteForm del = new UserDeleteForm();
                del.ShowDialog();
                
            }
        }

        private bool checkAddError()
        {
            int check = 0;
            XmlDocument userInfo = new XmlDocument();
            String state = "";
            for (int i = 0; i < 5; i++)
            {
                int userNum = i + 1;
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + userNum + ".xml");
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
                    check++;
                }
            }
            if (check == 5)
            {
                addCheck = true;
            }
            return addCheck;
        }

        private bool checkDelError()
        {
            int check = 0;
            XmlDocument userInfo = new XmlDocument();
            String state = "";
            for (int i = 0; i < 5; i++)
            {
                int userNum = i + 1;
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\UserInfo\\\\User" + userNum + ".xml");
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
                    check++;
                }
            }
            if (check == 1)
            {
                delCheck = true;
            }
            return delCheck;
        }
    }
}
