using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuProgramEB
{
    public partial class MenuButtonsStudent : Form
    {
        public MenuButtonsStudent()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            MyOrder mo = new MyOrder();
            mo.ShowDialog();
        }
    }
}
