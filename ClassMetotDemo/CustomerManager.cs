using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerName + " " + musteri.CustomerSurname + " isimli kişi " + musteri.CustomerId + " numaralı Id ile sisteme eklenmiştir." );
        }



        public void DeleteCustomer(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerName + " " + musteri.CustomerSurname + " isimli kişi " + musteri.CustomerId + " numaralı Id ile sistemden silinmiştir.");

        }

        public void ChangeCustomer(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerName + " " + musteri.CustomerSurname + " isimli kişi " + musteri.CustomerId + " numaralı Id ile sistem de bilgileri  düzenlenmiştir.");

        }

        public void ListingCustomer(Customer[] musteri)
        {
            foreach (Customer Musterilerimiz in musteri)

            {
                Console.WriteLine("Müşteri Adı Soyad:  " + Musterilerimiz.CustomerName + " " + Musterilerimiz.CustomerSurname);
            }
        }



    }
}
