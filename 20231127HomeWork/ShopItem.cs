using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231127HomeWork
{
    internal class ShopItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public List<String> Tag = new List<String>();
        public Double Price { get; set; }
        public DateTime Expiration { get; set; }


        public String JoinList() 
        {
            String tags = "";
            foreach(var item in Tag) { 
                tags += item + ", ";
            }
            return tags;
        }
        public override String ToString()
        {
            return $"Name: {Name}, Description: {Description}, Tags: {JoinList()}, Price: {Price}, Expiration {Expiration} \n";
        }
    }
}
