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
                customer1.CustomerID=Guid.NewGuid();
                customer1.CustomerName = "Umutcan";
                customer1.CustomerSurname = "Tufan";
            }

            Customer customer2 = new Customer();
            {
                customer2.CustomerID = Guid.NewGuid();
                customer2.CustomerName = "Tunahan";
                customer2.CustomerSurname = "Tufan";
            }

            Customer customer3 = new Customer();
            {
                customer3.CustomerID = Guid.NewGuid();
                customer3.CustomerName = "Can";
                customer3.CustomerSurname = "Tufan";
            }


            Customer customer4 = new Customer();
            {
                customer4.CustomerID = Guid.NewGuid();
                customer4.CustomerName = "Demir";
                customer4.CustomerSurname = "Tufan";
            }

            Customer customer5 = new Customer();
            {
                customer5.CustomerID = Guid.NewGuid();
                customer5.CustomerName = "Derin";
                customer5.CustomerSurname = "Tufan";
            }






            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4,customer5 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri ID: " + customer.CustomerID);
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

            //List<string> Customers = new List<string>();

            //Console.WriteLine(Customers[0]);

            Console.WriteLine("Müşteri Güncel Liste: ");
            customerManager.ListingCustomer(customers);
            Console.ReadLine();



        }
    }
}
