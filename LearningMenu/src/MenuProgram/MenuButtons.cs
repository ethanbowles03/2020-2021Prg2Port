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
    public partial class MenuButtons : Form
    {
        public MenuButtons()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MyOrder mo = new MyOrder();
            mo.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItem ai = new AddItem();
            ai.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditItem ei = new EditItem();
            ei.ShowDialog();
        }
    }
}
