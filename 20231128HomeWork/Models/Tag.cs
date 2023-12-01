using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Models
{
    internal class Tag
    {

        static private int counter;
        public Tag(string Name) {
            this.Id = counter++;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
