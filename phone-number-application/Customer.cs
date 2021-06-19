using System;
using System.Collections.Generic;
using System.Linq;

namespace phone_number_application
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        List<Customer> customerlist;
        public List<Customer> CustomerGetAll()
        {
            customerlist = new List<Customer>
            {
                new Customer{Name="Feyza",Surname="Bilgiç",TelephoneNumber="05324578487"},
                new Customer{Name="Cahide",Surname="Sara",TelephoneNumber="05324578487"},
                new Customer{Name="Naime",Surname="Sara",TelephoneNumber="05324578487"},
                new Customer{Name="Züleyha",Surname="Gencer",TelephoneNumber="05324578487"},
                new Customer{Name="Fatma",Surname="Kuyun",TelephoneNumber="05324578487"},
            };
            foreach (var customer in customerlist)
            {
                Console.WriteLine(" İsim: {0}\n Soyisim: {1}\n Telefon Numarası: {2}\n", customer.Name, customer.Surname, customer.TelephoneNumber);
            };
            return customerlist;
        }
        public void CustomerAdd()
        {
            Console.WriteLine("Lütfen isim giriniz             : {0}");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          : {0}");
            string surName = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz : {0}");
            string phoneNumber = Console.ReadLine();
            Customer customer = new Customer
            {
                Name = name,
                Surname = surName,
                TelephoneNumber = phoneNumber
            };
            customerlist.Add(customer);
        }
        public void CustomerNotFound(int number)
        {
            if (number == 1)
            {
                Environment.Exit(0);
            }
            else if (number == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Yalnızca 1 ve ya 2 değerini girebilirsiniz!");
            }
        }
        public void CustomerDelete(string nameSurname)
        {
            Customer customerToDelete = customerlist.SingleOrDefault(c => c.Name == nameSurname && c.Surname == nameSurname);
            if (customerToDelete != null)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    customerlist.Remove(customerToDelete);
                    Console.WriteLine("Kisi silinmiştir");
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Kişiyi silmekten vazgeçtiniz");
                }
                else
                {
                    Console.WriteLine("Sadece 'y' ya da 'n' yazabilirsiniz");
                }
            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                int num = int.Parse(Console.ReadLine());
                CustomerNotFound(num);
            }
        }
        public void CustomerUpdaate(Customer customer)
        {
        
            Customer customerToUpdate = customerlist.SingleOrDefault(c=>c.Name==customer.Name && c.Surname==customer.Surname);
            Console.WriteLine("İsim: " + customer.Name);
            Console.WriteLine("Soyisim: " + customer.Surname);
            Console.WriteLine("Telefon Numarası: " + customer.TelephoneNumber);
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.TelephoneNumber = customer.TelephoneNumber;            
           
        }
          public void Search(string value,List<Customer> list)
        {
             foreach (var item in list)
             {
                 if(item.Name.Contains(value) || item.Surname.Contains(value) || item.TelephoneNumber.Contains(value))
                    {
                       Console.WriteLine(" Arama Sonuçlarınız: \n**********************************************");
                       Console.WriteLine("isim:    {0}",item.Name);
                       Console.WriteLine("Soyisim: {0}",item.Surname);
                       Console.WriteLine("Telefon: {0}",item.TelephoneNumber);
                       Console.WriteLine("-");
                    }
                  else
                  {
                       Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                       int SoughtValue = int.Parse(Console.ReadLine());
                       CustomerNotFound(SoughtValue);
                  }
             }
        }
    }
}
