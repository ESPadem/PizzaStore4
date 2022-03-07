using System;

namespace PizzaStore4
{
    class Customer
    {
        //properties = globale variabler og gør sig gældende for hele klassen//
        private int id;
        private string name;
        private string address;
        private string mail;
        private int phone;

        //constructors//
        public Customer(int id, string name, string address, string mail, int phone)
        {
            //this. bruger man til at referere til den globale variable//
            this.id = id;
            this.name = name;
            this.address = address;
            this.mail = mail;
            this.phone = phone;
        }
        public void SetID(int id)
        {
            this.id = id;
        }
        public int GetID()
        {
            return id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetMail(string mail)
        {
            this.mail = mail;
        }
        public string GetMail()
        {
            return mail;
        }
        public void SetPhone(int phone)
        {
            this.phone = phone;
        }
        public int GetPhone()
        {
            return phone;
        }
        //ToString metode//
        public override string ToString()
        {
            return "\ncustomer id: " + this.id + "\n" + "name: " + this.name + "\n" + "address: " + this.address + "\n" + "email: " + this.mail + "\n" + "phone: " + this.phone;
        }
    }
}