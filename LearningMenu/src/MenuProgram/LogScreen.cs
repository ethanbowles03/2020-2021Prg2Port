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
    public partial class LogScreen : Form
    {
        private String userName = "";
        private String date = "";
        public LogScreen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            showOrderdetails();
        }

        private void showOrderdetails()
        {
            String state = "";
            String[] item = new String[30];
            XmlDocument items = new XmlDocument();
            for (int i = 0; i < 100; i++)
            {
                items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + (i + 1).ToString() + ".xml");
                foreach (XmlNode node in items.DocumentElement)
                {
                    String index = node.Attributes[0].InnerText;
                    if (index == "State")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            state = child.InnerText;
                        }
                    }
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

                if (state.Equals("FINISHED"))
                {
                    Button[] deleteOrder = new Button[100];
                    Button[] viewOrder = new Button[100];
                    Panel itemPanel = new Panel();
                    itemPanel.BackColor = Color.White;
                    itemPanel.Size = new Size(780, 100);
                    itemPanel.BringToFront();


                    Label nameLabel = new Label();
                    nameLabel.Size = new Size(600, 45);
                    nameLabel.Location = new Point(0, 0);
                    nameLabel.BorderStyle = BorderStyle.None;
                    nameLabel.TextAlign = ContentAlignment.MiddleLeft;
                    nameLabel.Text = userName;
                    nameLabel.ForeColor = Color.Black;
                    nameLabel.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                    itemPanel.Controls.Add(nameLabel);

                    Label dateTimeLabel = new Label();
                    dateTimeLabel.Size = new Size(150, 50);
                    dateTimeLabel.Location = new Point(630, 0);
                    dateTimeLabel.BorderStyle = BorderStyle.None;
                    dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
                    dateTimeLabel.Text = date;
                    dateTimeLabel.ForeColor = Color.LightGray;
                    dateTimeLabel.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                    itemPanel.Controls.Add(dateTimeLabel);

                    deleteOrder[i] = new Button();
                    deleteOrder[i].Size = new Size(65, 25);
                    deleteOrder[i].Location = new Point(715, 75);
                    deleteOrder[i].BackColor = Color.White;
                    deleteOrder[i].Name = i.ToString();
                    deleteOrder[i].Text = "DELETE";
                    deleteOrder[i].Click += new System.EventHandler(deleteOrder_Click);
                    itemPanel.Controls.Add(deleteOrder[i]);

                    viewOrder[i] = new Button();
                    viewOrder[i].Size = new Size(65, 25);
                    viewOrder[i].Location = new Point(640, 75);
                    viewOrder[i].BackColor = Color.White;
                    viewOrder[i].Name = i.ToString();
                    viewOrder[i].Text = "VIEW";
                    viewOrder[i].Click += new System.EventHandler(viewOrder_Click);
                    itemPanel.Controls.Add(viewOrder[i]);

                    flowLayoutPanelMenu.Controls.Add(itemPanel);
                }
            }
        }

        private void deleteOrder_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            int itemNumber = Convert.ToInt32(btn.Name) + 1;

            XmlDocument items = new XmlDocument();
            items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + itemNumber + ".xml");
            foreach (XmlNode node in items.DocumentElement)
            {
                String index = node.Attributes[0].InnerText;
                if (index == "State")
                {
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        child.InnerText = "FALSE";
                    }
                }
            }
            items.Save(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + itemNumber + ".xml");
            this.Close();
        }

        private void viewOrder_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            int itemNumber = Convert.ToInt32(btn.Name) + 1;

            ClassGlobals.ORDER_ID = itemNumber;
            ViewMyOrder vmo = new ViewMyOrder();
            vmo.ShowDialog();
        }
    }
}
