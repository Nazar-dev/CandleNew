using CandleNew.Classes;
using CandleNew.Classes.Logic;
using CandleNew.Prices;
using Logic.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandleNew.Forms
{
    public partial class TubeForm : Form
    {

        private PriceForTube tube = new PriceForTube();
        private Koef koef = new Koef();
        private Squere squere = new Squere();
        private Dollar dollar = new Dollar();
        public TubeForm()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            var price = tube.PricesForTube[comboBox3.Text] * dollar.ReturnDollar() * koef.Koefs[comboBox2.Text];

            var prices = squere.SquereTube(price, Convert.ToDouble(textBox1.Text));

            SetPrice(prices);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Винекла помилка,\nПеревірте правильність набору полів!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            var price = tube.PricesForTube[comboBox1.Text] * dollar.ReturnDollar() * koef.Koefs[comboBox2.Text];

            var prices = squere.SquereTube(price, Convert.ToDouble(textBox1.Text));

            SetPrice(prices);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Винекла помилка,\nПеревірте правильність набору полів!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var price = tube.PricesForTube[comboBox4.Text] * dollar.ReturnDollar() * koef.Koefs[comboBox2.Text];

            var prices = squere.SquereTube(price, Convert.ToDouble(textBox1.Text));

            SetPrice(prices);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Винекла помилка,\nПеревірте правильність набору полів!");
            }
        }
        private void SetPrice(List<double> prices)
        {
            textBox5.Text = Math.Round(prices[0], 2).ToString();
            textBox4.Text = Math.Round(prices[1], 2).ToString();
            textBox3.Text = Math.Round(prices[2], 2).ToString();
            textBox2.Text = Math.Round(prices[3], 2).ToString();
        }
    }
}
