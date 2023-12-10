using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersReader
{
    internal class FilesReader
    {
        public string dir {  get; set; }
        FileInfo[] files { get; set; }

        public void FileInfo[] GetFiles()
        {

            List<string> fullFilesData = new List<string>();

            foreach (FileInfo file in filesData)
            {
                string fileName = Path.GetFileName(file.FullName);
                long fileSize = file.Length;
                string filePath = Path.GetFullPath(file.FullName);

                fullFilesData.Add("Name: " + fileName +
                                            ", Size: " + fileSize +
                                            ", Path: " + filePath);
            }
        }
}
}
