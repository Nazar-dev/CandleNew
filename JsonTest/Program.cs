using System;
using System.Collections.Generic;
using System.IO;
using CandleNew.Classes.JsonParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string json =
                File.ReadAllText(
                    @"templateJson1.json");

            var rate=JObject.Parse(json)["eur"].Value<decimal>("rate");
            
            Console.WriteLine(rate);
            
            //List<KantorData> deserializeObject = JsonConvert.DeserializeObject<List<KantorData>>(json);

            //deserializeObject.ForEach(Console.WriteLine);
        }
    }
}