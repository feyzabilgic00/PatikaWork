using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> users=new Dictionary<int, string>();
            users.Add(10,"Feyza Bilgiç");
            users.Add(12,"Cahide Sara");
            users.Add(18,"Naime Sara");
            users.Add(20,"Hatice Özbakır");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*** Elemanlara Erişim ***");            
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Ece Varol"));

            //Remove
            Console.WriteLine("*** Remove ***");
            users.Remove(12);
            foreach (var item in users)
            {
                Console.WriteLine(item.Value);
            }

            //Keys  
            Console.WriteLine("*** Keys ***");
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("*** Values ***");
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
