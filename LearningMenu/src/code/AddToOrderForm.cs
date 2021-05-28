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
    public partial class AddToOrderForm : Form
    {
        private int orderFormID = 1;
        private String[] name = new String[1000];
        private String[] size = new String[1000];
        private String[] kind = new String[1000];
        private String[] addon = new String[1000];
        private String[] state = new String[1000];
        //private int nameValue = 0;
        private int kindValue = 0;
        private int addonValue = 0;
        private int sizeValue = 0;
        //private int stateValue = 0;
        private int permY = 0;
        //private int permX = 0;
        private RadioButton[] siZeOptionButtons;
        private CheckBox[] kindOptionButtons;
        private CheckBox[] addonOptionButtons;
        private String nameKind = "0";
        public AddToOrderForm()
        {
            InitializeComponent();
            getFormName();
            getFormDetails();
            printDetailsOnScreen();
        }

        public void getFormName()
        {
            orderFormID = ClassGlobals.ORDER_NUM;
        }

        public void getFormDetails()
        {
            int valPlace = 0;
            XmlDocument items = new XmlDocument();
            items.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + orderFormID + ".xml");
            foreach (XmlNode node in items.DocumentElement)
            {
                valPlace = 0;
                String index = node.Attributes[0].InnerText;
                if (index == "State")
                {
                    valPlace = 0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        state[valPlace] = child.InnerText;
                        valPlace++;
                    }
                }
                if (index == "Name")
                {
                    valPlace = 0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        name[valPlace] = child.InnerText;
                        valPlace++;
                    }
                }
                if (index == "Kind")
                {
                    valPlace = 0;
                    kindValue = 0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        kind[valPlace] = child.InnerText;
                        if (kind[valPlace].Equals(""))
                        {

                        }
                        else
                        {
                            kindValue++;
                        }
                        valPlace++;
                    }
                }
                if (index == "Add")
                {
                    valPlace = 0;
                    addonValue = 0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        addon[valPlace] = child.InnerText;
                        if (addon[valPlace].Equals(""))
                        {

                        }
                        else
                        {
                            addonValue++;
                        }
                        valPlace++;
                    }
                }
                if (index == "Size")
                {
                    valPlace = 0;
                    sizeValue = 0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        size[valPlace] = child.InnerText;
                        if (size[valPlace].Equals(""))
                        {

                        }
                        else
                        {
                            sizeValue++;
                        }
                        valPlace++;
                    }
                }
            }
        }

        public void printDetailsOnScreen()
        {
            //Displays the name of the item on the order screen
            Label nameLabel = new Label();
            nameLabel.Size = new Size(150,50);
            nameLabel.Location = new Point(20, 20);
            nameLabel.BorderStyle = BorderStyle.FixedSingle;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Text = name[0];
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
            panel1.Controls.Add(nameLabel);

            //Displays the size title and all of the options on the screen as a radio buttons
            Label sizeLabel = new Label();
            sizeLabel.Size = new Size(100, 34);
            sizeLabel.Location = new Point(20, 80);
            sizeLabel.BorderStyle = BorderStyle.None;
            sizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            sizeLabel.Text = "Difficulty:";
            sizeLabel.ForeColor = Color.White;
            sizeLabel.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            panel1.Controls.Add(sizeLabel);

            siZeOptionButtons = new RadioButton[sizeValue - 1];
            for (int i = 0; i < sizeValue -1; i++)
            {
                int val = i + 1;
                int yCord = 80;
                permY = 80;
                int xCord = 150 + (130 * i);
                if (i > 4)
                {
                    permY = 125;
                    yCord += 45;
                    xCord = 150 + (130 * (i - 5));
                }
                siZeOptionButtons[i] = new RadioButton();
                siZeOptionButtons[i].Size = new Size(120, 34);
                siZeOptionButtons[i].Location = new Point(xCord, yCord);
                siZeOptionButtons[i].TextAlign = ContentAlignment.MiddleLeft;
                siZeOptionButtons[i].Text = size[val];
                siZeOptionButtons[i].Name = val.ToString();
                siZeOptionButtons[i].ForeColor = Color.White;
                int font = 15;
                if (addon[val].Length >= 8)
                {
                    font = font - (kind[val].Length - 7);
                }
                siZeOptionButtons[i].Font = new Font("Microsoft Sans Serif", font, FontStyle.Bold);
                panel1.Controls.Add(siZeOptionButtons[i]);
            }

            Label kindLabel = new Label();
            kindLabel.Size = new Size(100, 34);
            kindLabel.Location = new Point(20, permY + 65);
            kindLabel.BorderStyle = BorderStyle.None;
            kindLabel.TextAlign = ContentAlignment.MiddleCenter;
            kindLabel.Text = "Class:";
            kindLabel.ForeColor = Color.White;
            kindLabel.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            panel1.Controls.Add(kindLabel);
            int oldY = permY;

            permY += 65;

            kindOptionButtons = new CheckBox[kindValue - 1];
            for (int i = 0; i < kindValue - 1; i++)
            {
                int val = i + 1;
                int xCord = 0;
                xCord = 150 + (130 * i);
                if (i > 4 && i <= 9)
                {
                    permY = oldY + 110;
                    xCord = 150 + (130 * (i - 5));
                }
                if (i > 9 && i <= 14)
                {
                    permY = oldY + 155;
                    xCord = 150 + (130 * (i - 10));
                }
                if (i > 14 && i <= 19)
                {
                    permY = oldY + 200;
                    xCord = 150 + (130 * (i - 15));
                }
                kindOptionButtons[i] = new CheckBox();
                kindOptionButtons[i].Size = new Size(120, 34);
                kindOptionButtons[i].Location = new Point(xCord, permY);
                kindOptionButtons[i].TextAlign = ContentAlignment.MiddleLeft;
                kindOptionButtons[i].Text = kind[val];
                kindOptionButtons[i].Name = val.ToString();
                kindOptionButtons[i].ForeColor = Color.White;
                int font = 15;
                if (kind[val].Length >= 8)
                {
                    font = font - (kind[val].Length - 7);
                }
                kindOptionButtons[i].Font = new Font("Microsoft Sans Serif", font, FontStyle.Bold);
                kindOptionButtons[i].Name = i.ToString();
                kindOptionButtons[i].CheckedChanged += new EventHandler(kindOptionButtons_CheckedChanged);
                panel1.Controls.Add(kindOptionButtons[i]);
            }

            Label addOnLabel = new Label();
            addOnLabel.Size = new Size(100, 34);
            addOnLabel.Location = new Point(20, permY + 65);
            addOnLabel.BorderStyle = BorderStyle.None;
            addOnLabel.TextAlign = ContentAlignment.MiddleCenter;
            addOnLabel.Text = "Extras:";
            addOnLabel.ForeColor = Color.White;
            addOnLabel.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            panel1.Controls.Add(addOnLabel);
            oldY = permY;

            permY += 65;
            addonOptionButtons = new CheckBox[addonValue - 1];
            int loopCount = 0;
            int location = 0;
            for (int i = 0; i < addonValue - 1; i++)
            {
                int val = i + 1;
                int xCord = 0;
                xCord = 150 + (130 * location);
                if (loopCount == 5)
                {
                    permY += 45;
                    location = 0;
                    loopCount = 0;
                }
                xCord = 150 + (130 * location);
                addonOptionButtons[i] = new CheckBox();
                addonOptionButtons[i].Size = new Size(120, 34);
                addonOptionButtons[i].Location = new Point(xCord, permY);
                addonOptionButtons[i].TextAlign = ContentAlignment.MiddleLeft;
                addonOptionButtons[i].Text = addon[val];
                addonOptionButtons[i].Name = val.ToString();
                addonOptionButtons[i].ForeColor = Color.White;
                int font = 15;
                if (addon[val].Length >= 8)
                {
                    font = font - (kind[val].Length - 7);
                }
                addonOptionButtons[i].Font = new Font("Microsoft Sans Serif", font, FontStyle.Bold);
                panel1.Controls.Add(addonOptionButtons[i]);
                location++;
                loopCount++;
            }

            //Adds the save button
            Button saveButton = new Button();
            saveButton.Location = new Point(710,permY + 40);
            saveButton.Text = "SAVE";
            saveButton.Size = new Size(100, 50);
            saveButton.BackColor = Color.White;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Click += new System.EventHandler(saveButton_Click);
            panel1.Controls.Add(saveButton);



            //Sets the size of the window
            this.Size = new Size(820, permY + 150);
            panel1.Size = new Size(820, permY + 150);
            this.MaximumSize = new Size(850, permY + 150);
            this.MinimumSize = new Size(850, permY + 150);
        }

        private void saveButton_Click(Object sender, System.EventArgs e)
        {
            String sizeName = "";
            String typeName = "";
            String[] addonNames = new String[addonValue];
            for (int i = 0; i < sizeValue - 1; i++)
            {
                bool isChecked = siZeOptionButtons[i].Checked;
                if (isChecked)
                {
                    sizeName = siZeOptionButtons[i].Text;
                }
            }

            for (int i = 0; i < kindValue - 1; i++)
            {
                bool isChecked = kindOptionButtons[i].Checked;
                if (isChecked)
                {
                    typeName = kindOptionButtons[i].Text;
                }
            }

            for (int i = 0; i < addonValue - 1; i++)
            {
                addonNames[i] = "";
                bool isChecked = addonOptionButtons[i].Checked;
                if (isChecked)
                {
                    addonNames[i] = addonOptionButtons[i].Text;
                }
            }

            String combindedAddOns = "-";
            for (int i = 0; i < addonValue - 1; i++)
            {
                if (addonNames[i].Equals(""))
                {

                }
                else
                {
                    combindedAddOns = combindedAddOns + addonNames[i] + "-";
                }
            }

            String finalCombo = sizeName + ", " + typeName + " " + name[0] + ", with" + combindedAddOns;

            String state = "";
           //String innerText = "";
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
                }
                if (state.Equals("TRUE"))
                {
                    bool stop = false;
                    for (int j = 0; j < 30; j++)
                    {
                        if (stop)
                        {
                            continue;
                        }
                        items.Load(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + (i + 1).ToString() + ".xml");
                        foreach (XmlNode node in items.DocumentElement)
                        {
                            String index = node.Attributes[0].InnerText;
                            if (index == "Item" + (j + 1).ToString())
                            {
                                foreach (XmlNode child in node.ChildNodes)
                                {
                                    if (child.InnerText.Equals(""))
                                    {
                                        child.InnerText = finalCombo;
                                        stop = true;
                                    }
                                    else
                                    {
                             
                                    }
                                }
                            }
                        }
                        items.Save(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + (i + 1).ToString() + ".xml");items.Save(@ClassGlobals.RunningPath + "Resources\\\\Orders\\\\Order" + (i + 1).ToString() + ".xml");
                    }
                }
            }
            this.Close();
        }

        private void kindOptionButtons_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kindValue - 1; i++)
            {
                if (kindOptionButtons[i].Checked)
                {
                    int index = Convert.ToInt32(nameKind);
                    kindOptionButtons[index].Checked = false;
                    nameKind = kindOptionButtons[i].Name; 

                }
            }
        }
    }
}
