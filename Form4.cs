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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Show("Kody lotnisk podaj w formacie IATA. Przykładowo: \"LIN, BGY\" ", textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                Country country = new Country(textBox1.Text, textBox2.Text, comboBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value, (int)numericUpDown7.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaj poprawne wartości!");
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            numericUpDown2.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown3_Enter(object sender, EventArgs e)
        {
            numericUpDown3.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown4_Enter(object sender, EventArgs e)
        {
            numericUpDown4.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown5_Enter(object sender, EventArgs e)
        {
            numericUpDown5.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown6_Enter(object sender, EventArgs e)
        {
            numericUpDown6.Select(0, 1); //Zaznacz znaki od 0 do 1
        }
        private void numericUpDown7_Enter(object sender, EventArgs e)
        {
            numericUpDown7.Select(0, 1); //Zaznacz znaki od 0 do 1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
