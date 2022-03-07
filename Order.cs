using System;

namespace PizzaStore4
{
    class Order
    {
        //properties = globale variabler og gør sig gældende for hele klassen//
        private int id;
        private bool deliver;
        private string payment;
        private string confirmation;
        private double totalPrice;
        private Pizza pizza;
        private Customer customer;

        //constructors//
        public Order(int id, bool deliver, string payment, string confirmation, Pizza pizza, Customer customer)
        {
            //this. bruger man til at referere til den globale variable//
            this.id = id;
            this.deliver = deliver;
            this.payment = payment;
            this.confirmation = confirmation;
            this.pizza = pizza;
            this.customer = customer;
            TotalPrice(this.pizza.GetPrice());
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }
        public void SetDeliver(bool deliver)
        {
            this.deliver = deliver;
        }
        public bool GetDelivery()
        {
            return deliver;
        }
        public void SetPayment(string payment)
        {
            this.payment = payment;
        }
        public string GetPayment()
        {
            return payment;
        }
        public void SetConfirmation(string confirmation)
        {
            this.confirmation = confirmation;
        }
        public string GetConfirmation()
        {
            return confirmation;
        }
        public Customer GetCustomer()
        {
            return customer;
        }
        //totalpris funktion start//
        public void TotalPrice(double price)
        {
            double totalPrice = price + 40;
            double taxes = 0.03 * price;
            this.totalPrice = totalPrice + taxes;
        }
        public double GetTotalPrice()
        {
            return this.totalPrice;
        }
        //totalpris funktion slut//
        //ToString metode//
        public override string ToString()
        {
            return "order number: " + this.id + "\n" + "deliver: " + this.deliver + "\n" + "payment: " + this.payment + "\n" + "order status: " + this.confirmation + this.customer.ToString() + this.pizza.ToString() + "\ntotal price incl. delivery and tax: " + this.totalPrice + " kr.";
        }
    }
}