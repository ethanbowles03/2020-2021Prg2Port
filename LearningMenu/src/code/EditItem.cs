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
    public partial class EditItem : Form
    {
        private int[] count = new int[100];
        private String val = "";
        public EditItem()
        {
            InitializeComponent();
            loadDetails();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int userNum = checkVal(val);
            XmlDocument userInfo = new XmlDocument();
            userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + userNum + ".xml");
            foreach (XmlNode node in userInfo.DocumentElement)
            {
                String name = node.Attributes[0].InnerText;
                if (name == "State")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = "FALSE";
                    }
                }
            }
            userInfo.Save(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + userNum + ".xml");

            userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\activeItemCount.xml");
            foreach (XmlNode node in userInfo.DocumentElement)
            {
                String name = node.Attributes[0].InnerText;
                if (name == "Count")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        String count = child.InnerText;
                        int sCount = Convert.ToInt32(count);
                        sCount = sCount - 1;
                        child.InnerText = sCount.ToString();
                    }
                }
            }
            userInfo.Save(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\activeItemCount.xml");
            this.Close();
        }

        private void loadDetails()
        {

            String[] comboArray = setArray();
            for (int i = 0; i < 100; i++)
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

        private String[] setArray()
        {
            String state = "";
            String[] arr = new String[100];
            XmlDocument userInfo = new XmlDocument();
            for (int i = 0; i < 100; i++)
            {
                int num = i + 1;
                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + num + ".xml");
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
                    userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + num + ".xml");
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
            String state = "";
            int ret = 0;
            for (int i = 0; i < 100; i++)
            {
                int num = i + 1;

                userInfo.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + num + ".xml");
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
                    if (name == "State")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            state = child.InnerText;
                        }
                    }
                }
                if (acc.Equals(accountName) && state.Equals("TRUE"))
                {
                    ret = num;
                }
            }
            return ret;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            val = comboBox1.Text;
        }
    }
}
