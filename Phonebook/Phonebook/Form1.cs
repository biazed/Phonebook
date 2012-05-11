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

        XmlNodeList nodes = doc.SelectNodes("/persons/person/name");
            
            foreach (XmlNode node in nodes) 
            {
                MessageBox.Show(node.InnerText);
            }
        
            /*


             xmlattrc = xmlnode[i].Attributes;
            if (int.Parse(xmlattrc[0].Value) == empid)
            {
                

                

                xmlnode[i].ChildNodes[0].InnerText = fname;//ChildNodes[0] is First Name
                xmlnode[i].ChildNodes[1].InnerText = lname;
                xmlnode[i].ChildNodes[2].InnerText = age;
                doc.Save(xmlFile);// The New Data is Saved in the XML file by replacing old data for that particular employee.
            }
        }
            */

            /*
            //XmlTextReader reader = new XmlTextReader("xmlfile.xml");
            XmlDocument document = new XmlDocument();
            document.Load("xmlfile.");
            document.
                */
            /*
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if(reader.Name == inName[0] + " " + inName[1] || reader.Name == inName[1] + " " + inName[0])
                           
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }*/
	        
            //output[1] = " ";
            //MessageBox.Show(output[1]);
            return output;
         
        }
    }
}