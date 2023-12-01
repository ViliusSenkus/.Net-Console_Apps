using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20231128HomeWork.Interfaces
{
    internal interface IShopItemService
    {
        public void Add(string name, double price);
        public void Remove(string name);
        public double Balance();
        public void TopUp(double ammount);
        public void Buy();
        public void DisplayItems();
    }
}
