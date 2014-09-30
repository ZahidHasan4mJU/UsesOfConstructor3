using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApplication
{
    public partial class PersonsAppsForm : Form
    {
        public PersonsAppsForm()
        {
            InitializeComponent();
        }

        private Persons p;
        private Persons p2;
        private void fullButton_Click(object sender, EventArgs e)
        {
            p = new Persons(firstTextBox.Text, middleTextBox.Text, lastTextBox.Text);
            p2 = new Persons(firstTextBox.Text, lastTextBox.Text);
           //p.FirstName = firstTextBox.Text;
            //p.SecondName = middleTextBox.Text;
            //p.LastName = lastTextBox.Text;

            fullTextBox.Text = p.getFullName();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            
            reverseTextBox.Text = p.getReverseName();
        }
    }
}
