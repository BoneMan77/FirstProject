using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DeskTestDome
{
    class FileHelper
    {
        public string ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            return sr.ReadLine();
        }
    }
}
