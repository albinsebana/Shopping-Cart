using CustomerAppp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101, "Albin", "Albin@gmail.com",10);
            Customer c2 = new Customer(102, "Amal", "amal@gmail.com");


            Customer[] customers =
                {
                c1,
                c2,
                new Customer(103,"Albii","albii@gmail.com",22),
                new Customer(104,"Dillu","Dillu@gmail.com",12)
                };
            
            foreach (Customer customer in customers)
            { 
                Console.WriteLine(customer.ShowCustomer());
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("Customer with Maximum Orders : "+ Customer.GetCustomerNameWithMaxOrder(customers));
           
            Console.WriteLine("--------------------------------");
            Customer c = Customer.GetCustomerNameWithMinOrder(customers);
            Console.WriteLine("Customers With Minimum orders :\n "+ 
                c.ShowCustomer());




            Console.WriteLine("++++++++++++++++++++++++++++++++++++");

            int[] numbers = { 1, 2, 3, 4, 5 };

            //int index = Array.IndexOf(customers, c2);
            //Console.WriteLine(index);

            foreach (int number in numbers)
                Console.WriteLine(numbers[number-1]);


            int[] numbers2 = new int[4];
            numbers2[0]=1; 
            numbers2[1]=2;
            numbers2[2]=3;
            numbers2[3]=4;
            foreach (int number in numbers2)
                Console.WriteLine(numbers2[number - 1]);



            //Employee e1 = new Employee(1011,"akash","akash@gmail.com");
            //Employee e2 = new Employee(1012,"abhi","abhi@gmail.com");
            //Employee e3 = new Employee(1013, "abhinav", "abhinav@gmail.com");

            //Console.WriteLine(c1.ShowCustomer());
            //Console.WriteLine(c2.ShowCustomer());


            //Console.WriteLine("total customers are:" + Customer.CountCustomer);
            ////Console.WriteLine("total customers are:" + Customer.CountC());
            //Console.WriteLine("total Employees are:" + Employee.countEmployees);
            //Console.WriteLine("total StakeHolders are:" + StateHolders.CountStateHolders);
        }

    }
}
