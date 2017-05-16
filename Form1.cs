using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelion
{

    public partial class Form1 : Form
    {
        public static Form1 _Form1;
        public List<TrackBar> TrackBars = new List<TrackBar>();
        public List<Country> Countries = new List<Country>();

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;

            //Zmiana typu charta na poziome bary
            chart_Wyniki.Series["Zdobyte Punkty"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;

            chart_Wyniki.Series["Zdobyte Punkty"].IsValueShownAsLabel = true;

            //Uzupełnienie listy Barów
            TrackBars.Add(trackBar_Imprezy); TrackBars.Add(trackBar_Widoki); TrackBars.Add(trackBar_Jedzenie); TrackBars.Add(trackBar_Pobyt); TrackBars.Add(trackBar_Cena); TrackBars.Add(trackBar_Cywilizacja); TrackBars.Add(trackBar_Muzea);

            //Deklaracje kolejnych krajów razem z mnożnikami
            //W kolejności Imprezy, Widoki, Jedzenie, Pobyt, Cena, Cywilizacja, Muzea, skala 1-5
            Country portugal = new Country("Portugalia", 4, 4, 2, 4, 2, 4, 2);
            Country england = new Country("Anglia", 2, 2, 2, 2, 2, 4, 5);
            Country honolulu = new Country("Honolulu", 5, 4, 3, 5, 1, 1, 1);
            Country poland = new Country("Polska", 3, 2, 4, 5, 5, 1, 4);
            Country india = new Country("Indie", 4, 2, 1, 3, 5, 1, 2);
            Country france = new Country("Francja", 5, 4, 3, 1, 1, 5, 5);
            Country czech = new Country("Czechy", 4, 2, 5, 5, 4, 4, 3);
            Country russia = new Country("Rosja", 2, 3, 3, 2, 5, 2, 3);
            Country niger = new Country("Niger", 1, 3, 1, 1, 1, 1, 1);
            Country china = new Country("Chiny", 3, 5, 4, 3, 2, 4, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTop5();
        }

        public void CalculateTop5()
        {
            chart_Wyniki.Series["Zdobyte Punkty"].Points.Clear();

            List<int> User_Multipliers = new List<int>();

            foreach (Country country in Countries)
            {
                country.points = 0;
            }

            foreach (TrackBar _trackbar in TrackBars)       // Zebranie wyników podanych przez naszego dzielnego usera. Sprostajmy im.
            {
                User_Multipliers.Add(_trackbar.Value);
            }

           foreach (Country country in Countries)
            {
                for (int i=0; i < 7; i++)
                {
                    country.points += country.multipliers[i] * User_Multipliers[i];     //Przydzielenie punktów dla każdego kraju
                }
            }

            List<Country> SortedCountries = Countries.OrderByDescending(o => o.points).ToList(); // Zapytanie Linq, sortowanie malejąco wg punktów

            for (int i=0;i<5;i++)
            {
                chart_Wyniki.Series["Zdobyte Punkty"].Points.Add(SortedCountries[i].points);
                chart_Wyniki.Series["Zdobyte Punkty"].Points[i].Label = (SortedCountries[i].Name + ": " + SortedCountries[i].points.ToString() + " punktów");
                //W tym miejscu wpierdalamy to wszystko w charta głównego
            }

        }
    }

    public class Country
    {
        public int points = 0;
        public int[] multipliers = new int[7];
        public string Name = "";

        public Country (string _name, int _points_Imprezy, int _points_Widoki, int _points_Jedzenie, int _points_Pobyt, int _points_Cena, int _points_Cywilizacja, int _points_Muzea)
        {
            Name = _name;
            multipliers[0] = _points_Imprezy;
            multipliers[1] = _points_Widoki;
            multipliers[2] = _points_Jedzenie;
            multipliers[3] = _points_Pobyt;
            multipliers[4] = _points_Cena;
            multipliers[5] = _points_Cywilizacja;
            multipliers[6] = _points_Muzea;
            Form1._Form1.Countries.Add(this);   // Dorzucenie stworzonego kraju do tablicy wszystkich krajów
        }

    }

}