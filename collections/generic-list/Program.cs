using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //T=> object türündedir.
            List<int> numberList = new List<int>();
            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

            List<string> colorList=new List<string>();
            colorList.Add("Kırmızı");
            colorList.Add("Mavi");
            colorList.Add("Turuncu");
            colorList.Add("Sarı");
            colorList.Add("Yeşil");

            //Count
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numberList.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            numberList.ForEach(number=>Console.WriteLine(number));
            colorList.ForEach(color=>Console.WriteLine(color));

            //Listeden eleman çıkarma
            numberList.Remove(4);
            colorList.Remove("Yeşil");

            numberList.ForEach(number=>Console.WriteLine(number));
            colorList.ForEach(color=>Console.WriteLine(color));

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);

            numberList.ForEach(number=>Console.WriteLine(number));
            colorList.ForEach(color=>Console.WriteLine(color));

            //Liste içerisinde arama
            if (numberList.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }

            //Eleman ile index'e erişme
            Console.WriteLine(colorList.BinarySearch("Sarı"));

            //Diziyi List'e çevirme 
            string[] animals={"Kedi","Köpek","Kuş"};
            List<string> animalList=new List<string>(animals);

            //Listeyi nasıl temizleriz
            animalList.Clear();

            //List içerisinde nesne tutmak 
            List<Users> userList=new List<Users>
            {
                new Users{name="Feyza",surname="Bilgiç",age=27},
                new Users{name="Cahide",surname="Sara",age=26},
                new Users{name="Naime",surname="Sara",age=26},
            };
            foreach (var user in userList)
            {
                Console.WriteLine("{0} {1} {2}",user.name,user.surname,user.age);
            }  
        }
    }
    public class Users
    {
        public string name{get;set;}
        public string surname{get;set;}
        public int age{get;set;}
    }
}
