using System;
using System.Xml;
using System.Xml.Linq;
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
            string[] names;
            name = nameBox.Text;
            number = numberBox.Text;
            names = parser(name);
            string[] response = check(names);
            nameBox.Text = response[0];
            numberBox.Text = response[1];
            
        }

        //Method to parse names
        private string[] parser(string input)
        {
            string[] output = input.Split(' ');
            return output;
        }

        private string[] check(string[] inName)
        {
            string[] output = new string[2];
            output[0] = null;
            
                 // Load the document.
        XmlDocument doc = new XmlDocument();
        doc.Load("xmlfile.xml");

        XmlNodeList nodes = doc.SelectNodes("//persons");
        MessageBox.Show("" + nodes[0]);
            foreach (XmlNode node in nodes) 
            {
                MessageBox.Show(node.InnerText);
            }
        
            
            return output;
         
        }
    }
}