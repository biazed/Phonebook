using System;
using System.Xml;
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
                XmlTextReader reader = new XmlTextReader("./xmlfile.xml");
                reader.Read();

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Text: //Display the text in each element.
                            if (reader.Value == inName[0] + " " + inName[1] || reader.Value == inName[1] + " " + inName[0])
                            {
                                output[0] = reader.Value;
                                output[1] = reader.Value;
                                //MessageBox.Show(output[0]+ " " +output[1] + " " +reader.Value);
                                MessageBox.Show(reader.NodeType.ToString());
                                MessageBox.Show(reader.Value);
                            }
                            break;
                            reader.Read();
                            MessageBox.Show(reader.Value);
                            /*
                        case XmlNodeType.Element:
                            if (reader.Name == "number")
                            {
                                MessageBox.Show();
                            }
                            break;*/
                            //return output;
                            
                    }  // ~ Switch ENDS
                }  // ~ While ENDS
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