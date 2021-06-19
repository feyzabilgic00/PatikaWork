using System;

namespace enum_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Pazar);
            Console.WriteLine((int)Days.Cumartesi);

            int temparature = 32;
            if (temparature <= (int)WeatherForecast.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha sıcak olmasını bekleyelim");
            }
            else if (temparature >= (int)WeatherForecast.SoHot)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (temparature >= (int)WeatherForecast.Normal && temparature < (int)WeatherForecast.SoHot)
            {
                Console.WriteLine("Haydi dışarı çıkalım!");
            }
        }
    }
    enum Days
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }
    enum WeatherForecast
    {
        Cold = 5,
        Normal = 20,
        Hot = 25,
        SoHot = 30
    }
}
