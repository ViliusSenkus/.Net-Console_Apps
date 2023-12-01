using _20231128HomeWork.Interfaces;
using _20231128HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Services
{
    internal class ShopItemService : IShopItemService
    {
        private List<ShopItem> allItems { get; set; } = new List<ShopItem>();

        public void MakeShoppingItemsList()
        {
            foreach (string line in File.ReadAllLines(@"C:/Users/v.senkus/Desktop/Shop.txt"))
            {
                string[] parts = line.Split(", ");
                string name = (parts[0].Split(": "))[1];
                double price = double.Parse((parts[1].Split(": "))[1]);
                int qnt = int.Parse((parts[2].Split(": "))[1]);
                ShopItem shopItem = new ShopItem(name, price, qnt);
                allItems.Add(shopItem);
            }
        }

        public void Add(string name, double price)
        {
            
        }

        public double Balance()
        {
            throw new NotImplementedException();
        }

        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void DisplayItems()
        {
            Console.WriteLine("Turimu prekiu sarasas: \n");
            allItems.ForEach(item =>
            {
                Console.WriteLine(item.ToString());
            });
        }

        public void Remove(string name)
        {
            throw new NotImplementedException();
        }

        public void TopUp(double ammount)
        {
            throw new NotImplementedException();
        }
    }
}
