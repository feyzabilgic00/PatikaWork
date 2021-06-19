using System;

namespace arrays_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] numberArray={23,12,4,86,72,3,11,17};            
            Console.WriteLine("**** Sırasız Dizi ******");
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("**** Sıralı Dizi ******");
            Array.Sort(numberArray);
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }

            //Clear
            Console.WriteLine("**** Array Clear ******");
            //Sayı dizisi elemanlarını kullaarak 2.indexten
            //itibaren 2 tane elemanı 0 lar.
            Array.Clear(numberArray,2,2);
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }

            //Reverse
            Console.WriteLine("**** Array Reverse ******");
            Array.Reverse(numberArray);
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }

            //Indexof
            Console.WriteLine("**** Array Indexof ******");
            var result=Array.IndexOf(numberArray,23);
            Console.WriteLine(result);

            //Resize
            Console.WriteLine("**** Array Resize ******");
            Array.Resize(ref numberArray,9);
            numberArray[8]=99;
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
