using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace semestralka01
{
    [XmlInclude(typeof(Food)), XmlInclude(typeof(Beer)), XmlInclude(typeof(Wine)), XmlInclude(typeof(Delivery))]
    public abstract class Order
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Order (string name, int price,int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public Order()
        {

        }
    }
    public class Food : Order
    {
        public int Kcal { get; set; }

        public Food(string name, int price, int quantity, int kcal) : base(name,price,quantity)
        {
            this.Kcal = kcal;
        }

        public Food()
        {

        }
    }

    public class Beer : Order
    {
        public string Type { get; set; }
        public string Alcohol { get; set; }

        public Beer(string name, int price, int quantity, string type, string alcohol) : base(name, price, quantity)
        {
            this.Type = type;
            this.Alcohol = alcohol;

        }

        public Beer()
        {

        }
    }

    public class Wine : Order
    {
        public string Type { get; set; }
        public string Alcohol { get; set; }

        public Wine(string name, int price, int quantity, string type, string alcohol) : base(name, price, quantity)
        {
            this.Type = type;
            this.Alcohol = alcohol;
        }

        public Wine()
        {

        }
    }

    public class Delivery : Order
    {
        public string Type { get; set; }
        public string Alcohol { get; set; }
        public string Adress   { get; set; }

        public Delivery(string name, int price, int quantity, string type, string alcohol, string adress) : base(name, price,quantity)
        {
            this.Type = type;
            this.Alcohol = alcohol;
            this.Adress = adress;

        }

        public Delivery()
        {

        }
    }
}
