using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Travelion
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            foreach (Country country in Form1._Form1.Countries)
            {
                checkedListBox1.Items.Add(country.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";         // jak ma się nazywać nasze rozszerzenie w oknie otwierania
            saveFileDialog1.DefaultExt = "xml";                         //domyślne rozszerzenie
            saveFileDialog1.AddExtension = true;                        // domyślne dorzucanie rozszerzenia
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)        // Nakierowuję na plik za pomocą dialogu (Odpalam w ifie jak profesjonalista :3)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Country>));       //Tworzenie nowego serializera XML typu Country    
                TextWriter Filestream = new StreamWriter(saveFileDialog1.FileName);               // Małpka by anulować znak specjalny "\"
                xmlSerializer.Serialize(Filestream, Form1._Form1.Countries);                        //Używając serializatora writera serializujemy kraje :V
                Filestream.Close();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)                //Nakierowuję na plik za pomocą dialogu (Odpalam w ifie jak profesjonalista :3)
            {
                FileStream stream = File.OpenRead(openFileDialog1.FileName);         //Tworzymy strumień danych OpenRead otwierający nasz output file
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Country>)); //tworzymy sobie nowego serializera XML typu country
                Form1._Form1.Countries = (List<Country>)xmlSerializer.Deserialize(stream);      //Listę Countries zalewamy zdeserializowanym strumieniem danych :O
                stream.Close();
            }

            checkedListBox1.Items.Clear();

            foreach (Country country in Form1._Form1.Countries)
            {
                checkedListBox1.Items.Add(country.Name);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4(); // Tworzymy za każdym razem nową. Wciśnięcie "X" usuwa nam ten obiekt (tak O_o)
            fourthForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(string checkedCountry in checkedListBox1.CheckedItems)
            {
                for (int i = Form1._Form1.Countries.Count - 1; i > -1; i--)                         //Usuwanie z klona listy krajów które nie odpowiadają tagom
                {
                    if (checkedCountry == Form1._Form1.Countries[i].Name)
                    {
                        Form1._Form1.Countries.RemoveAt(i);
                    }
                }

            }


            checkedListBox1.Items.Clear();                                                          //Odświeżenie po skrobance
            foreach (Country country in Form1._Form1.Countries)
            {
                checkedListBox1.Items.Add(country.Name);
            }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (Country country in Form1._Form1.Countries)
            {
                checkedListBox1.Items.Add(country.Name);
            }
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1._Form1.Countries.Any())
            {
                Form1._Form1.button1.Enabled = true;
            }
            else
            {
                Form1._Form1.button1.Enabled = false;
                Form1._Form1.button2.Enabled = false;
            }
        }
    }
}
