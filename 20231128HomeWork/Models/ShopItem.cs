using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Models
{
    internal class ShopItem
    {
        public ShopItem(string name, string description, List<Tag> tag, double price, DateTime expiration)
        {
            this.Name = name;
            this.Description = description;
            this.Tag = tag;
            this.Price = price;
            this.Expiration = expiration;
        }
        public ShopItem(string name, double price, int qnt)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = qnt;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Tag> Tag = new List<Tag>();
        public double Price { get; set; }
        public DateTime Expiration { get; set; }

        public int Quantity { get; set; }

        public String JoinList()
        {
            String tags = "";
            foreach (var item in Tag)
            {
                tags += item + "- ";
            }
            return tags;
        }
        public override String ToString()
        {
            return $"Name: {Name}, Description: {Description}, Tags: {JoinList()}, Price: {Price}, Expiration {Expiration}, Qauntity: {Quantity} \n";
        }
    }
}
