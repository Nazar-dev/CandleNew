namespace CandleNew.Classes.JsonParser
{
    public class KantorData
    {
        public string code { get; set; }
        public string alphaCode { get; set; }
        public string numericCode { get; set; }
        public string name { get; set; }
        public string rate { get; set; }
        public string date { get; set; }
        public string inverseRate { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(code)}: {code}, {nameof(alphaCode)}: {alphaCode}, {nameof(numericCode)}: {numericCode}, {nameof(name)}: {name}, {nameof(rate)}: {rate}, {nameof(date)}: {date}, {nameof(inverseRate)}: {inverseRate}";
        }
    }
}