using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore4
{
    class Store
    {
        public Store()
        {

        }
        //public void: print ikke ud, men brug den senere til start metode i Program.cs//
        public void Start()
        {
           Customer c1 = new Customer(1, "adem", "slagelse", "espadem@outlook.dk", 81167227);
           Customer c2 = new Customer(2, "ibrahim", "kokkedal", "iboBacha@outlook.dk", 71178228);
           Customer c3 = new Customer(3, "samil", "slagelse", "samilbatir@outlook.dk", 91196226);

           Pizza p1 = new Pizza("Margaritha", "green olives", 49);
           Pizza p2 = new Pizza("Vesuvio", "bacon", 55);
           Pizza p3 = new Pizza("Milano", "mozzarella", 59);

           Order o1 = new Order(1, true, "mastercard", "order succesfull", p1, c1);
           Order o2 = new Order(2, true, "visa dancard", "order succesfull", p2, c2);
           Order o3 = new Order(3, true, "american express", "order successfull", p3, c3);

           Console.WriteLine(o1.ToString());
           Console.WriteLine("\n" + o2.ToString());
           Console.WriteLine("\n" + o3.ToString());
        }
    }
}