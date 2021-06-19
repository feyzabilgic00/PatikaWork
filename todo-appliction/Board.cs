using System;
using System.Collections.Generic;

namespace todo_appliction
{
    public class Board
    {
        public static List<Card> Todo { get; set; }
        public static List<Card> InProgress { get; set; }
        public static List<Card> Done { get; set; }

        public static List<Card> DefaultToDo()
        {
            return new List<Card>(){
                new Card("Başlık : 1","İçerik : 1",1,Size.L),
                new Card("Başlık : 2","İçerik : 2",2,Size.S),

            };
        }

        public static List<Card> DefaultInProgress()
        {
            return new List<Card>(){
                new Card("Başlık : 3","İçerik : 3",3,Size.XL),
                new Card("Başlık : 4","İçerik : 4",4,Size.XS)

            };
        }
        public static List<Card> DefaultDone()
        {
            return new List<Card>(){
                
            };
        }
        public static void BoardList()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");

            if (DefaultToDo().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in DefaultToDo())
            {
                Console.WriteLine("Başlık      :{0}", item.Title);
                Console.WriteLine("İçerik      :{0}", item.Content);
                Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                Console.WriteLine("Büyüklük    :{0}", item.Size);
                Console.WriteLine("-");
            }
            }
            Console.WriteLine();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (DefaultInProgress().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in DefaultInProgress())
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (DefaultDone().Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in DefaultDone())
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }

        }
    }
}