using System;
using System.Collections.Generic;

namespace phone_number_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                string strReadKey = Console.ReadKey().KeyChar.ToString();
                int.TryParse(strReadKey, out number);

                switch (number)
                {
                    case 1:
                        customer.CustomerAdd();
                        break;
                    case 2:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        string nameSurname = Console.ReadLine();
                        customer.CustomerDelete(nameSurname);
                        break;
                    case 3:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string customerToUpdate = Console.ReadLine();                    
                    foreach (var item in customer.CustomerGetAll())
                    {
                        if (item.Name == customerToUpdate || item.Surname == customerToUpdate)
                        {
                            customer.CustomerUpdaate(item);
                            break;
                        }
                        else{
                            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                            int value = int.Parse(Console.ReadLine());
                            customer.CustomerNotFound(value);
                        }
                    }
                        break;
                    case 4:
                        customer.CustomerGetAll();
                        break;
                    case 5:
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
                    int soughtValue = int.Parse(Console.ReadLine());

                    if(soughtValue == 1)
                    {
                       Console.WriteLine("Aramak istediğiniz ismi ve ya soyismi girin: ");
                       string nameSurnameValue = Console.ReadLine();
                       customer.Search(nameSurnameValue,customer.CustomerGetAll());

                    }
                    else if(soughtValue == 2)
                    {
                       Console.WriteLine("Aramak istediğiniz telefon numarasını girin: ");
                       string phoneNumberValue = Console.ReadLine();
                       customer.Search(phoneNumberValue,customer.CustomerGetAll());
                    }
                    else{
                        Console.WriteLine("Yalnızca 1 ya da 2 girebilirizsiniz");
                    }
                        break;
                    default:
                        Console.WriteLine("Lütfen 1-5 arasında bir seçim yapınız");
                        break;

                }
            }
        }
    }
}
