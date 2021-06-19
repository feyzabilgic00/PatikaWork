using System;
using System.Collections.Generic;

namespace todo_appliction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            
            int number=Convert.ToInt32(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Board.BoardList();
                break;

                case 2:
                    Card.AddCard();
                break;

                case 3:
                Card.DeleteCard();
                break;

                case 4:
                Card.MoveCard();
                break;        
            }
            
        }
    }
}
