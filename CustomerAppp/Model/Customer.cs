using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerAppp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CountOrder { get; set; }
        
        public Customer(int id, string name, string email) //:this()
        {
            Id = id;
            Name = name;
            Email = email;
            //_countCustomer = countCustomer;
            StateHolders.CountStateHolders++;
        }


        public Customer(int id, string name, string email, int orders) : this(id, name, email)
            {
                CountOrder =orders;
            }
        public string ShowCustomer()
        {
            return $"Id :{Id} \n NAme : {Name} \n Email :{Email}";
        }
        public  static string GetCustomerNameWithMaxOrder(Customer[]customer) 
        {
            int maxOrder = customer[0].CountOrder;
            string name=string.Empty;
            for (int i = 1; i < customer.Length; i++)
            {
                if (customer[i].CountOrder > maxOrder)
                { 
                    maxOrder = customer[i].CountOrder;
                    name = customer[i].Name;
                }
            }
            return name;
        }
        public static Customer GetCustomerNameWithMinOrder(Customer[] customers)
        { 
            int minOrder = customers[0].CountOrder;
            Customer c = null;
            for (int i = 1;i < customers.Length;i++) 
                {
                if (customers[i].CountOrder<minOrder)
                    {
                        minOrder = customers[i].CountOrder;
                        c = customers[i];
                    }
                }
            return c;
        }
    }
}



//private static int _countCustomer = 0;
//public static int CountCustomer 
//{
//    get
//    { 
//        return _countCustomer;
//    } 
//}

//static Customer()
//{
//    Console.WriteLine("this is a static constructor");
//}
//public Customer()
//{
//    Console.WriteLine("this is a Default Constructor");
//    _countCustomer++;
//}