using System;

namespace PizzaStore4
{
    class Menucard
    {
        //properties = globale variabler og gør sig gældende for hele klassen//
        private string menu;

        //constructors//
        public Menucard(string menu)
        {
            //this. bruger man til at referere til den globale variable//
            this.menu = menu;
        }
        public void SetMenu(string menu)
        {
            this.menu = menu;
        }
        public string GetMenu()
        {
            return menu;
        }
        //ToString metode//
        public override string ToString()
        {
            return "menu: " + this.menu;
        }
    }
}

//IGNORER!
//private List<Pizza> pizzas = new List<Pizza>();
//ublic void AddPizzaToMenu(Pizza pizza)
//{
//    pizzas.Add(pizza);
//}
//public List<Pizza> GetPizzaMenu()
//{
//    return pizzas;
//}

//når jeg skal arbejde med List senere i semesteret.

//eller

//public double TotalPrice(List<Pizza> pizzas)
//{
//    double totalPrice = 0;
//    double taxes = 0.03;
//    foreach (Pizza p in pizzas)
//    {
//        totalPrice = totalPrice + taxes * p.GetPrice() + p.GetPrice();
//
//    }
//    return totalPrice + 40;

//Program.cs
//List<Pizza> pList = new List<Pizza>();
//pList.Add(p1);
//pList.Add(p2);
//pList.Add(p3);

//Menucard m = new Menucard();
//m.AddPizzaToMenu(p1);
//m.AddPizzaToMenu(p2);
//m.AddPizzaToMenu(p3);