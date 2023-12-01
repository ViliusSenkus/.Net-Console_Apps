using _20231128HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Services
{
    internal class FileService : IFileService
    {
        public void ReadFile()
        {
            File.ReadAllText(@"C:/Users/v.senkus/Desktop/Cart.txt");
        }

        public void WriteToFile(List<string> data)
        {
            File.AppendAllLines(@"C:/Users/v.senkus/Desktop/Cart.txt", data); ;
        }
    }
}
