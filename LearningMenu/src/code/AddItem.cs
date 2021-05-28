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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String[] sizeOptions = new String[11];
            String[] kindOptions = new String[21];
            String[] addonOptions = new string[31];
            String name = nameBox.Text;

            //Gets the values form the text boxes and saves them into corresponding arrays
            sizeOptions[1] = textBox1.Text;
            sizeOptions[2] = textBox2.Text;
            sizeOptions[3] = textBox3.Text;
            sizeOptions[4] = textBox4.Text;
            sizeOptions[5] = textBox5.Text;
            sizeOptions[6] = textBox6.Text;
            sizeOptions[7] = textBox7.Text;
            sizeOptions[8] = textBox8.Text;
            sizeOptions[9] = textBox9.Text;
            sizeOptions[10] = textBox10.Text;

            kindOptions[1] = textBox11.Text;
            kindOptions[2] = textBox12.Text;
            kindOptions[3] = textBox13.Text;
            kindOptions[4] = textBox14.Text;
            kindOptions[5] = textBox15.Text;
            kindOptions[6] = textBox16.Text;
            kindOptions[7] = textBox17.Text;
            kindOptions[8] = textBox18.Text;
            kindOptions[9] = textBox19.Text;
            kindOptions[10] = textBox20.Text;
            kindOptions[11] = textBox21.Text;
            kindOptions[12] = textBox22.Text;
            kindOptions[13] = textBox23.Text;
            kindOptions[14] = textBox24.Text;
            kindOptions[15] = textBox25.Text;
            kindOptions[16] = textBox26.Text;
            kindOptions[17] = textBox27.Text;
            kindOptions[18] = textBox28.Text;
            kindOptions[19] = textBox29.Text;
            kindOptions[20] = textBox30.Text;

            addonOptions[1] = textBox60.Text;
            addonOptions[2] = textBox59.Text;
            addonOptions[3] = textBox58.Text;
            addonOptions[4] = textBox57.Text;
            addonOptions[5] = textBox56.Text;
            addonOptions[6] = textBox55.Text;
            addonOptions[7] = textBox54.Text;
            addonOptions[8] = textBox53.Text;
            addonOptions[9] = textBox52.Text;
            addonOptions[10] = textBox51.Text;
            addonOptions[11] = textBox50.Text;
            addonOptions[12] = textBox49.Text;
            addonOptions[13] = textBox48.Text;
            addonOptions[14] = textBox47.Text;
            addonOptions[15] = textBox46.Text;
            addonOptions[16] = textBox45.Text;
            addonOptions[17] = textBox44.Text;
            addonOptions[18] = textBox43.Text;
            addonOptions[19] = textBox42.Text;
            addonOptions[20] = textBox41.Text;
            addonOptions[21] = textBox40.Text;
            addonOptions[22] = textBox39.Text;
            addonOptions[23] = textBox38.Text;
            addonOptions[24] = textBox37.Text;
            addonOptions[25] = textBox36.Text;
            addonOptions[26] = textBox35.Text;
            addonOptions[27] = textBox34.Text;
            addonOptions[28] = textBox33.Text;
            addonOptions[29] = textBox32.Text;
            addonOptions[30] = textBox31.Text;

            sizeOptions[0] = "";
            kindOptions[0] = "";
            addonOptions[0] = "";

            //Finds the count of blanks in each place and saves them as int
            int blankSizeCount = 0;
            int blankKindCount = 0;
            int blankAddonCount = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!sizeOptions[i].Equals(""))
                {
                    blankSizeCount++;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (!kindOptions[i].Equals(""))
                {
                    blankKindCount++;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                if (!addonOptions[i].Equals(""))
                {
                    blankAddonCount++;
                }
            }

            sizeOptions[0] = blankSizeCount.ToString();
            kindOptions[0] = blankKindCount.ToString();
            addonOptions[0] = blankAddonCount.ToString();


            //Finds the first file which is isnt in use and saves the data into the correct places
            XmlDocument items = new XmlDocument();
            String state = "";
            String[] size = new String[11];
            String[] kind = new String[21];
            String[] addon = new String[31];
            bool stop = false;
            for (int i = 0; i < 100; i++)
            {
                if (stop)
                {
                    break;
                }
                int valPlace = 0;
                items.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + (i+1).ToString() + ".xml");
                foreach (XmlNode node in items.DocumentElement)
                {
                    valPlace = 0;
                    String index = node.Attributes[0].InnerText;
                    if (index == "State")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            state = child.InnerText;
                        }
                    }
                }

                if (state.Equals("FALSE"))
                {
                    stop = true;
                    items.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + (i + 1).ToString() + ".xml");
                    foreach (XmlNode node in items.DocumentElement)
                    {
                        valPlace = 0;
                        String index = node.Attributes[0].InnerText;
                        if (index == "State")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = "TRUE";
                            }
                        }
                        if (index == "Name")
                        {
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = name;
                            }
                        }
                        if (index == "Kind")
                        {
                            valPlace = 0;
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = blankKindCount.ToString();
                                child.InnerText = kindOptions[valPlace];
                                valPlace++;
                            }
                        }
                        if (index == "Add")
                        {
                            valPlace = 0;
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = blankAddonCount.ToString();
                                child.InnerText = addonOptions[valPlace];
                                valPlace++;
                            }
                        }
                        if (index == "Size")
                        {
                            valPlace = 0;
                            foreach (XmlNode child in node.ChildNodes)
                            {
                                child.InnerText = blankSizeCount.ToString();
                                child.InnerText = sizeOptions[valPlace];
                                valPlace++;
                            }
                        }
                    }
                    
                }

                items.Save(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\inv" + (i + 1).ToString() + ".xml");

                items.Load(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\activeItemCount.xml");
                String count = "";
                foreach (XmlNode node in items.DocumentElement)
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

                int sCount = Convert.ToInt32(count);
                sCount = sCount + 1;
                foreach (XmlNode node in items.DocumentElement)
                {
                    String index = node.Attributes[0].InnerText;
                    if (index == "Count")
                    {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            child.InnerText = sCount.ToString();
                        }
                    }
                }
                items.Save(@ClassGlobals.RunningPath + "Resources\\\\Inventory\\\\activeItemCount.xml");

            }
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void addonLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
