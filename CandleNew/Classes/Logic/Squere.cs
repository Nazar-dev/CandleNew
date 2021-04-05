using CandleNew.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandleNew.Classes.Logic
{
    class Squere
    {
        public List<double> SquereTube(double finnalPrice,double Squere)
        {

/*            String a = jTextField1.getText();*/
            /*            if (S == 0)
                        {
                            jLabel45.setText("Введіть мп");
                        }*/
            double S = Squere * finnalPrice;
            double Spdv = (double)(S * 1.2);
            double S2 = (double)(S * 0.4 + S);
            double Spdv2 = (double)(S2 * 1.2);

            Console.WriteLine(finnalPrice.ToString(),Squere.ToString());


            return  new List<double> { S, Spdv, S2, Spdv2 };
        }
    }
}
