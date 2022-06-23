using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;
using Restaurant.Repository;

namespace Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.customerID = 1;
            customer.customerName = "Qaisar Khan";
            customer.customerPhone = "03478330705";
            customer.customerEmail = "qaisarkhan@gmail.com";
           

            Customer customer2 = new Customer();
            customer2.customerID = 2;
            customer2.customerName = "Noor Khan";
            customer.customerPhone = "03473518865";
            customer2.customerEmail = "noorkhanaf8@gmail.com";
           

            Customer customer3 = new Customer();
            customer3.customerID = 3;
            customer3.customerName = "M. Yar Khan";
            customer3.customerPhone = "03407330270";
            customer3.customerEmail = "myarkhan@gmail.com";
          
            List<Customer> list = new List<Customer>();
            

            list.Add(customer);
            list.Add(customer2);
            list.Add(customer3);


            RepositoryCustomers repositoryCustomers = new RepositoryCustomers();
            repositoryCustomers.Insert(list);

            List<Customer> list2 = new List<Customer>();
            list2 = repositoryCustomers.Get();


            foreach(Customer cust in list2)
            {
                Console.WriteLine("Customer ID is: {0}, his name is: {1}, his phone number is: {2}, and email is: {3}",cust.customerID,cust.customerName,cust.customerPhone,cust.customerEmail);
            }


            Console.ReadLine();

            
        }
    }
}
