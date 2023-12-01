using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Interfaces
{
    internal interface IFileService
    {
        public void WriteToFile(List<string> data);
        public void ReadFile();
    }
}
