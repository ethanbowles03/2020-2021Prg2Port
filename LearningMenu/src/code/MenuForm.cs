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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            showItems();
        }

        private void showItems()
        {

            String[] name = new String[100];
            String[] size = new String[100];
            String[] kind = new String[100];
            String[] addon = new String[100];
            String[] state = new String[100];

            for (int i = 0; i < 100; i++)
            {
                XmlDocument items = new XmlDocument();
                int fileCount = i + 1;
                items.Load(@ClassGlobals.RunningPath + "Resources\\Inventory\\inv" + fileCount + ".xml");
                foreach (XmlNode node in items.DocumentElement)
                {
                    String index = node.Attributes[0].InnerText;
                    if (index == "State")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            state[i] = child.InnerText;
                        }
                    }
                    if (index == "Name")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            name[i] = child.InnerText;
                        }
                    }
                    if (index == "Kind")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            kind[i] = child.InnerText;
                        }
                    }
                    if (index == "Add")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            addon[i] = child.InnerText;
                        }
                    }
                    if (index == "Size")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            size[i] = child.InnerText;
                        }
                    }
                }
            }

            Button[] addOrderBtn = new Button[1000];
            for (int j = 0; j < 100; j++)
            {
                addOrderBtn[j] = new Button();
            }

            for (int i = 0; i < 100; i++)
            {

                if (state[i].Equals("TRUE"))
                {
                    Panel userPanel = new Panel();
                    userPanel.BackColor = Color.White;
                    userPanel.Location = new Point(75, 80 + (175 * i));
                    userPanel.Size = new Size(175, 200);
                    userPanel.BringToFront();

                    Panel linePanel = new Panel();
                    linePanel.BackColor = Color.LightGray;
                    linePanel.Location = new Point(15, 150);
                    linePanel.Size = new Size(145, 5);
                    linePanel.BringToFront();
                    userPanel.Controls.Add(linePanel);


                    addOrderBtn[i].Size = new Size(175, 45);
                    addOrderBtn[i].Name = (i+1).ToString();
                    addOrderBtn[i].BackColor = Color.White;
                    addOrderBtn[i].Location = new Point(0, 155);
                    addOrderBtn[i].Text = "ADD TO SELECTION";
                    addOrderBtn[i].FlatAppearance.BorderSize = 0;
                    addOrderBtn[i].FlatStyle = FlatStyle.Flat;
                    addOrderBtn[i].Click += new System.EventHandler(orderBtn_Click);
                    userPanel.Controls.Add(addOrderBtn[i]);

                    Label userName = new Label();
                    double length = name[i].Length;
                    userName.Size = new Size(175, 40);

                    if (length >= 7 && length <= 15)
                    {
                        length = length - 7;
                        length *= 1.5;
                        double newFontSize = 25 - length;
                        userName.Location = new Point(10, 65);
                        int finalFont = Convert.ToInt32(newFontSize);
                        userName.Font = new Font("Microsoft Sans Serif", finalFont, FontStyle.Regular);
                    }
                    else
                    {
                        userName.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Regular);
                        userName.Location = new Point(95- (13 * Convert.ToInt32(length)), 65);
                    }

                    userName.Name = "menulabel";
                    userName.ForeColor = Color.Black;
                    userName.Text = name[i];
                    userPanel.Controls.Add(userName);

                    flowLayoutPanelMenu.Controls.Add(userPanel);
                }

            }//End of for loop
        }

        private void orderBtn_Click(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            ClassGlobals.ORDER_NUM = Convert.ToInt32(btn.Name);
            AddToOrderForm addOrder = new AddToOrderForm();
            addOrder.ShowDialog();
        }

        private void MenuForm_Paint(object sender, PaintEventArgs e)
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
    }
}
