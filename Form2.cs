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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            browseFlights(Form1._Form1.TargetCountries[0]); // ładujemy pierwszy kraj do przeglądarki

            try
            {
                button1.Text = ("Loty do: " + Form1._Form1.TargetCountries[0].Name);
                button1.Enabled = true;
                button2.Text = ("Loty do: " + Form1._Form1.TargetCountries[1].Name);
                button2.Enabled = true;
                button3.Text = ("Loty do: " + Form1._Form1.TargetCountries[2].Name);
                button3.Enabled = true;
                button4.Text = ("Loty do: " + Form1._Form1.TargetCountries[3].Name);
                button4.Enabled = true;
                button5.Text = ("Loty do: " + Form1._Form1.TargetCountries[4].Name);
                button5.Enabled = true;
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browseFlights(Form1._Form1.TargetCountries[0]);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            browseFlights(Form1._Form1.TargetCountries[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browseFlights(Form1._Form1.TargetCountries[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            browseFlights(Form1._Form1.TargetCountries[3]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            browseFlights(Form1._Form1.TargetCountries[4]);
        }

        private void browseFlights(Country targetCountry)
        {
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://www.google.pl/flights/#search;f=WAW");
            queryaddress.Append(";t=");
            queryaddress.Append(targetCountry.flightcode);
            webBrowser1.Navigate(queryaddress.ToString());
        }
    }
}
