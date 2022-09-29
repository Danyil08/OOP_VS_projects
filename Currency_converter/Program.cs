using System;

namespace Currency_converter
{
    class Program
    {
        class Converter
        {
            public Converter (decimal USD_to_UAH, decimal EUR_to_UAH)
            {
                this.USD_to_UAH = USD_to_UAH;
                this.EUR_to_UAH = EUR_to_UAH;
                if (!(USD_to_UAH > 0) || !(EUR_to_UAH > 0))
                {
                    Console.WriteLine("Недопустимий курс валют");
                }
            }
            private decimal USD_to_UAH, EUR_to_UAH;
            double from_USD_to_UAH(double USD)
            {
                return Convert.ToDouble(USD * Convert.ToDouble(USD_to_UAH));
            }
            double from_EUR_to_UAH(double EUR)
            {
                return Convert.ToDouble(EUR * Convert.ToDouble(EUR_to_UAH));
            }
            double from_UAH_to_USD(double UAH)
            {
                return Convert.ToDouble(UAH / Convert.ToDouble(USD_to_UAH));
            }
            double from_UAH_to_EUR(double UAH)
            {
                return Convert.ToDouble(UAH / Convert.ToDouble(EUR_to_UAH));
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Converter converter = new Converter(Convert.ToDecimal(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
            }
            catch 
            {
                Console.WriteLine("Помилка введення десяткового цілого числа");
            }
        }
    }
}
