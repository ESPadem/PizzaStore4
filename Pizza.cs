using System;

namespace PizzaStore4
{
    class Pizza
    {
        //properties = globale variabler og gør sig gældende for hele klassen//
        private string name;
        private string topping;
        private int price;

        //constructors//
        public Pizza(string name, string topping, int price)
        {
            //this. bruger man til at referere til den globale variable//
            this.name = name;
            this.topping = topping;
            this.price = price;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetTopping(string topping)
        {
            this.topping = topping;
        }
        public string GetTopping()
        {
            return topping;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public int GetPrice()
        {
            return price;
        }
        //ToString metode//
        public override string ToString()
        {
            return "\npizza: " + this.name + "\n" + "topping: " + this.topping;
        }
    }
}