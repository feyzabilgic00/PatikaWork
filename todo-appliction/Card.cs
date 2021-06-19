using System;

namespace todo_appliction
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PersonId { get; set; }
        public Size Size { get; set; }
        public Card()
        {
            
        }
        public Card(string title,string content,int personId,Size size)
        {
            Title=title;
            Content=content;
            PersonId=personId;
            Size=size;
        }        
         public static void AddCard()   
        {
            TeamMember teamMember=new TeamMember();
            Card card = new Card();

            Console.WriteLine("Başlık Giriniz                                  :");
            card.Title = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz                                  :");
            card.Content = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            card.Size = (Size)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi ID Giriniz                                  :");
            card.PersonId = int.Parse(Console.ReadLine());
            int temp = 0;

            foreach (var item in teamMember.GetTeamMembers())
            {
                if (item.Id == card.PersonId)
                {
                    temp++;
                    Board.DefaultToDo().Add(card);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Hatalı giriş. Girilen ID'ye ait bir kullanıcı bulunamadı.");
            }
            else
            {
                Console.WriteLine("Kart ekleme gerçekleştirildi.");
            }
        }
         public static void DeleteCard()    
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            int temp = 0;

            foreach (var item in Board.DefaultToDo())
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.DefaultToDo().Remove(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }
            foreach (var item in Board.DefaultInProgress())
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.DefaultInProgress().Remove(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }
            foreach (var item in Board.DefaultDone())
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.DefaultDone().Remove(item);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                    break;
                }
            }
        }
        public static void MoveCard()
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("**************************************");

            int temp = 0;
            if (temp == 0)
            {
                foreach (var item in Board.DefaultDone())
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        SelectRow();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                        }
                        else if (selected == 2)
                        {
                            Board.DefaultInProgress().Add(item);
                            Board.DefaultToDo().Remove(item);
                        }
                        else if (selected == 3)
                        {
                            Board.DefaultDone().Add(item);
                            Board.DefaultToDo().Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.DefaultInProgress())
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :InProgress");

                        SelectRow();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.DefaultToDo().Add(item);
                            Board.DefaultInProgress().Remove(item);
                        }
                        else if (selected == 2)
                        {

                        }
                        else if (selected == 3)
                        {
                            Board.DefaultDone().Add(item);
                            Board.DefaultInProgress().Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.DefaultDone())
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.PersonId);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        SelectRow();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.DefaultToDo().Add(item);
                            Board.DefaultDone().Remove(item);
                        }
                        else if (selected == 2)
                        {
                            Board.DefaultInProgress().Add(item);
                            Board.DefaultDone().Remove(item);
                        }
                        else if (selected == 3)
                        {
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
        }
         public static void SelectRow()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }
    }
}