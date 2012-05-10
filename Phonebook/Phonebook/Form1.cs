using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class phonebook : Form
    {
        public phonebook()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name,number;
            name = nameBox.Text;
            number = numberBox.Text;
            string names[] = name.Split(' ');
            foreach (string word in names)
	        {
	          Console.WriteLine(word);
	        }
        }
    }
}
