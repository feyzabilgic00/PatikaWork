using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list=new ArrayList();
            list.Add("Feyza");
            list.Add(2);
            list.Add(true);
            list.Add('F');

            //içerisinideki verilere erişim
            Console.WriteLine(list[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("**** Add Range *****");
            string[] colors={"Kırmızı","Sarı","Yeşil"};
            List<int> numbers=new List<int>(){3,7,92,5};
            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort 
            Console.WriteLine("*** Sort ***");
            List<int> numberList2=new List<int>(){15,3,89,1,6,87,34};
            numberList2.Sort();
            foreach (var item in numberList2)
            {
                Console.WriteLine(item);
            }
            
            //Binary Search
            Console.WriteLine("*** Binary Search ***");
            Console.WriteLine(numberList2.BinarySearch(6));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            numberList2.Reverse();
            foreach (var item in numberList2)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("*** Clear ***");
            numberList2.Clear();
            foreach (var item in numberList2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
