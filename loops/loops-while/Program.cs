using System;

namespace loops_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak Console'dan girilen sayıya kadar(sayı dahil)
            //ortalama hesaplayıp Console'a yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz");
            int number=int.Parse(Console.ReadLine());
            int counter=1;
            int sum=0;
            while (counter<=number)
            {
                sum+=counter;
                counter++;
            }
            Console.WriteLine(sum/number);

            // a dan z ye kadar tüm hafleri Console yazdır.            
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine();
            Console.WriteLine("**** Foreach Döngüsü ***");
            string[] cars={"BMW","Ford","Toyota","Volvo"};
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
