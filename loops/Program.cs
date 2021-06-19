using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazır
            Console.Write("Lütfen bir sayı giriniz");
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamı
            int _single = 0;
            int _double = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    _double += i;
                }
                else
                    _single += i;
            }
            Console.WriteLine("Tek toplam:" + _single);
            Console.WriteLine("Çift toplam:" + _double);
            sum = _single + _double;
            Console.WriteLine(sum);

            //break,contiune
            Console.WriteLine("**** Break ****");
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("**** Continue ****");
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
