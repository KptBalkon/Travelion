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

    public partial class Form1 : Form
    {
        public static Form1 _Form1;

        public List<TrackBar> TrackBars = new List<TrackBar>();
        public List<Country> Countries = new List<Country>();
        public List<CheckBox> CheckBoxes = new List<CheckBox>();
        public List<Country> TargetCountries = new List<Country>();

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;

            //Zmiana typu charta na poziome bary
            chart_Wyniki.Series["Zdobyte Punkty"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;

            chart_Wyniki.Series["Zdobyte Punkty"].IsValueShownAsLabel = true;

            //Uzupełnienie listy Barów
            TrackBars.Add(trackBar_Imprezy); TrackBars.Add(trackBar_Widoki); TrackBars.Add(trackBar_Jedzenie); TrackBars.Add(trackBar_Pobyt); TrackBars.Add(trackBar_Cena); TrackBars.Add(trackBar_Cywilizacja); TrackBars.Add(trackBar_Muzea);
            //Uzupełnianie listy Checkboxów
            CheckBoxes.Add(checkBox_Africa); CheckBoxes.Add(checkBox_Asia); CheckBoxes.Add(checkBox_NAmerica); CheckBoxes.Add(checkBox_SAmerica); CheckBoxes.Add(checkBox_Australia); CheckBoxes.Add(checkBox_Europe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTop5();

     
        }

        public void CalculateTop5()
        {
            chart_Wyniki.Series["Zdobyte Punkty"].Points.Clear();

            List<int> User_Multipliers = new List<int>();
            List<string> Chosen_Continents = new List<string>();
            List<Country> Temp_Countries = Countries.Select(country => new Country(country.Name, country.Continent, country.multipliers, country.flightcode)).ToList(); // kopiujemy wszystkie kraje na nową liste by móc je usuwać (AHAAHAHAHAH!)
            int amount_of_top_countries = 5;

            foreach (CheckBox checkbox in CheckBoxes)         // Zebranie tagów zaznaczonych przez użytkownika
            {
                if (checkbox.Checked == true)
                {
                    Chosen_Continents.Add(checkbox.Text);
                }
            }

            if (Chosen_Continents.Count == 0)                       // Sprawdzenie, czy wybrano jakieś kontynenty
            {
                MessageBox.Show("Nie wybrano żadnych kontynentów!");
                Form1._Form1.button2.Enabled = false; // zakazujemy liczenia lotów dla nieistniejących krajów
            }
            else
            {
                Form1._Form1.button2.Enabled = true; // pozwalamy na policzenie lotów
                for (int i = Temp_Countries.Count - 1; i > -1; i--)                         //Usuwanie z klona listy krajów które nie odpowiadają tagom
                {   
                    if ((Chosen_Continents.Contains(Temp_Countries[i].Continent))==false)
                    {
                        Temp_Countries.RemoveAt(i);
                    }
                }

                foreach (TrackBar _trackbar in TrackBars)       // Zebranie wyników podanych przez naszego dzielnego usera. Sprostajmy im.
                {
                    User_Multipliers.Add(_trackbar.Value);
                }

                foreach (Country country in Temp_Countries)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        country.points += country.multipliers[i] * User_Multipliers[i];     //Przydzielenie punktów dla każdego kraju
                    }
                }

                List<Country> SortedCountries = Temp_Countries.OrderByDescending(o => o.points).ToList(); // Zapytanie Linq, sortowanie malejąco wg punktów
                TargetCountries = SortedCountries;

                if (SortedCountries.Count < 5) { amount_of_top_countries = SortedCountries.Count; }

                for (int i = 0; i < amount_of_top_countries; i++)
                {
                    if (true)
                    {
                        chart_Wyniki.Series["Zdobyte Punkty"].Points.Add(SortedCountries[i].points);
                        chart_Wyniki.Series["Zdobyte Punkty"].Points[i].Label = (SortedCountries[i].Name + ": " + SortedCountries[i].points.ToString() + " punktów");
                    }
                }

            }


        }

        private void checkBox_All_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_All.Checked == true)
            {
                foreach (CheckBox checkbox in CheckBoxes)
                {
                    checkbox.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox checkbox in CheckBoxes)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Przejscie do formularza z wynikami
        {
            Form2 secondForm = new Form2(); // Tworzymy za każdym razem nową. Wciśnięcie "X" usuwa nam ten obiekt (tak O_o)
            secondForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)  // Przejście do edytora krajów
        {
            Form3 thirdForm = new Form3(); // Tworzymy za każdym razem nową. Wciśnięcie "X" usuwa nam ten obiekt (tak O_o)
            thirdForm.Show();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Travelion\n\nProgram do planowania podroży międzykrajowych\n\nCopyright KptBalkon 2017", "O Programie");
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }

    public class Country
    {
        public int points = 0;
        public int[] multipliers = new int[7];
        public string Name = "";
        public string Continent = "";
        public string flightcode = "";

        public Country (string _name, string _flightcode, string _continent, int _points_Imprezy, int _points_Widoki, int _points_Jedzenie, int _points_Pobyt, int _points_Cena, int _points_Cywilizacja, int _points_Muzea)
        {
            Name = _name;
            multipliers[0] = _points_Imprezy;
            multipliers[1] = _points_Widoki;
            multipliers[2] = _points_Jedzenie;
            multipliers[3] = _points_Pobyt;
            multipliers[4] = _points_Cena;
            multipliers[5] = _points_Cywilizacja;
            multipliers[6] = _points_Muzea;
            Continent = _continent;
            flightcode = _flightcode;
            Form1._Form1.Countries.Add(this);   // Dorzucenie stworzonego kraju do tablicy wszystkich krajów
        }

        public Country (string _name, string _continent, int[] _multipliers, string _flightcode)
        {
            Name = _name;
            Continent = _continent;
            multipliers = _multipliers;
            flightcode = _flightcode;
        }
        public Country()
        {
        }
    }

}