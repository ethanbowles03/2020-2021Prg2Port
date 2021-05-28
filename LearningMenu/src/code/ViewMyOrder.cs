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
    public partial class ViewMyOrder : Form
    {
        private String userName = "";
        private String date = "";
        private String time = "";
        public ViewMyOrder()
        {
            InitializeComponent();
            showOrderdetails();
        }

        private void finishOrder_Click(object sender, EventArgs e)
        {
            userName = customerNameBox.Text;
            date = dateBox.Text;
            time = timeBox.Text;
            String state = "FINISHED";
            XmlDocument items = new XmlDocument();
            items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
            foreach (XmlNode node in items.DocumentElement)
            {
                String index = node.Attributes[0].InnerText;
                if (index == "State")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = state;
                    }
                }
                if (index == "Name")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = userName;
                    }
                }
                if (index == "Date")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = date + " - " + time;
                    }
                }
            }
            items.Save(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
            this.Close();
        }

        private void showOrderdetails()
        {
            //String state = "";
            String[] item = new String[30];
            XmlDocument items = new XmlDocument();

            items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
            foreach (XmlNode node in items.DocumentElement)
            {
                String index = node.Attributes[0].InnerText;
                if (index == "Name")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        userName = child.InnerText;
                    }
                }
                if (index == "Date")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        date = child.InnerText;
                    }

                }
            }
            customerNameBox.Text = userName;
            dateBox.Text = date;

            for (int i = 0; i < 30; i++)
            {
                item[i] = "";
            }

            for (int i = 0; i < 30; i++)
            {
                items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
                foreach (XmlNode node in items.DocumentElement)
                {
                    String index = node.Attributes[0].InnerText;
                    if (index == "Item" + (i + 1).ToString())
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            item[i] = child.InnerText;
                        }
                    }
                }
            }

            Button[] deleteOrder = new Button[30];

            for (int i = 0; i < 30; i++)
            {
                if (item[i].Equals(""))
                {

                }
                else
                {
                    Panel itemPanel = new Panel();
                    itemPanel.BackColor = Color.White;
                    itemPanel.Size = new Size(750, 100);
                    itemPanel.BringToFront();


                    Label nameLabel = new Label();
                    nameLabel.Size = new Size(600, 100);
                    nameLabel.Location = new Point(0, 0);
                    nameLabel.BorderStyle = BorderStyle.None;
                    nameLabel.TextAlign = ContentAlignment.MiddleLeft;
                    nameLabel.Text = item[i];
                    nameLabel.ForeColor = Color.Black;
                    nameLabel.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                    itemPanel.Controls.Add(nameLabel);

                    Label dateTimeLabel = new Label();
                    dateTimeLabel.Size = new Size(150, 50);
                    dateTimeLabel.Location = new Point(600, 0);
                    dateTimeLabel.BorderStyle = BorderStyle.None;
                    dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
                    dateTimeLabel.Text = date;
                    dateTimeLabel.ForeColor = Color.LightGray;
                    dateTimeLabel.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                    itemPanel.Controls.Add(dateTimeLabel);

                    deleteOrder[i] = new Button();
                    deleteOrder[i].Size = new Size(65,25);
                    deleteOrder[i].Location = new Point(685,75);
                    deleteOrder[i].BackColor = Color.White;
                    deleteOrder[i].Name = i.ToString();
                    deleteOrder[i].Text = "DELETE";
                    deleteOrder[i].Click += new System.EventHandler(deleteOrder_Click);
                    itemPanel.Controls.Add(deleteOrder[i]);

                    flowLayoutPanel1.Controls.Add(itemPanel);
                }
            }
        }
        private void deleteOrder_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("You clicked character [" + btn.Name + "]");
            int itemNumber = Convert.ToInt32(btn.Name) + 1;

            XmlDocument items = new XmlDocument();
            items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
            foreach (XmlNode node in items.DocumentElement)
            {
                String index = node.Attributes[0].InnerText;
                if (index == "Item" + itemNumber.ToString())
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = "";
                    }
                }
            }
            items.Save(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + ClassGlobals.ORDER_ID + ".xml");
            this.Close();
        }
    }
}
