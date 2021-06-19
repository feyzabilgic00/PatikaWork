using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors=new string[5];
            string[] animals={"Kedi","Köpek","Kuş","Maymun"};
            int[] array;
            array=new int[5];

            //Dizilere değer atama ve değişim
            colors[0]="Mavi";
            Console.WriteLine(animals[0]);
            array[3]=10;
            Console.WriteLine(array[3]);
            Console.WriteLine(colors[0]);

            //Döngüler ile dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını alan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz!");
            int arrayLength=int.Parse(Console.ReadLine());
            int[] number=new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz",i+1);
                number[i]=int.Parse(Console.ReadLine());
            }
            int sum=0;
            foreach (var num in number)
            {
                sum+=num;                
            }
            Console.WriteLine("ortalama:"+sum/arrayLength);
        }
    }
}
