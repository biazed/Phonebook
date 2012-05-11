using System;
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
            XDocument reader = XDocument.Load("xmlfile.xml");

            string name = reader.Element("name").Value;
            MessageBox.Show(name);
            //reader.Descendants("persons");
                
            /*
             public class Tutorial
                {
                  public string Author { get; set; }
                  public string Title { get; set; }
                  public DateTime Date { get; set; }
                }
            
             * .......
             
                   List<Person> persons =
                  (from tutorial in xmlDoc.Descendants("persons")
                   where tutorial.Element("name").Value == inName;
                   select new person
                   {
                     Name = tutorial.Element("name").Value,
                     Number = tutorial.Element("number").Value,
                   }).ToList<Person>();
            
            */
            return output;
         
        }
    }
}

/*
case XmlNodeType.Element: // The node is an element.
if (reader.Name == "name")
    Console.Write("Name: ");
if (reader.Name == "number")
    Console.Write("Number: ");
break;
 */