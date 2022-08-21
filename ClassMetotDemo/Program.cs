using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            {
                customer1.CustomerId = Guid.NewGuid();
                customer1.CustomerName = "Umutcan";
                customer1.CustomerSurname = "Tufan";
            }

            Customer customer2 = new Customer();
            {
                customer2.CustomerId = Guid.NewGuid();
                customer2.CustomerName = "Tunahan";
                customer2.CustomerSurname = "Tufan";
            }

            Customer customer3 = new Customer();
            {
                customer3.CustomerId = Guid.NewGuid();
                customer3.CustomerName = "Can";
                customer3.CustomerSurname = "Tufan";
            }


            Customer customer4 = new Customer();
            {
                customer4.CustomerId = Guid.NewGuid();
                customer4.CustomerName = "Demir";
                customer4.CustomerSurname = "Tufan";
            }

            Customer customer5 = new Customer();
            {
                customer5.CustomerId = Guid.NewGuid();
                customer5.CustomerName = "Derin";
                customer5.CustomerSurname = "Tufan";
            }






            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4,customer5 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri ID: " + customer.CustomerId);
                Console.WriteLine("Müşteri Adı: " + customer.CustomerName);
                Console.WriteLine("Müşteri Soyadi: " + customer.CustomerSurname);
                Console.WriteLine("--------");
            }

            Console.WriteLine("Müşteriler Listelenmiştir.");
            Console.WriteLine("--------");




            CustomerManager customerManager = new CustomerManager();
            {
                customerManager.AddCustomer(customer1);
                customerManager.DeleteCustomer(customer2);
                customerManager.ChangeCustomer(customer3);


            }

            Console.WriteLine("Müşteri Güncel Liste: ");
            customerManager.ListingCustomer(customers);
            Console.ReadLine();



        }
    }
}
