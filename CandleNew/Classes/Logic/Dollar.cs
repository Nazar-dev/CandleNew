using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CandleNew.Classes
{
    class  Dollar
    {
        public static double dolar { get; set; }
        private static void getDollar()
        {
            var myClient = new WebClient();
            Console.WriteLine("\n\n\n\n\n");
            var responce = myClient.DownloadString("http://www.floatrates.com/daily/usd.json");

            var rate = JObject.Parse(responce)["uah"].Value<double>("rate");

            dolar = rate;
        }
        public double ReturnDollar()
        {
            getDollar();
            return dolar;
        }
    }
    class Todo
    {
       public string code { get; set; }
        public double rate { get; set; }
    }
}
