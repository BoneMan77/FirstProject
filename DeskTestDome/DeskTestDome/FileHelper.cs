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
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            return sr.ReadToEnd();
        }

        public void Signaldescription(string path , List<string> SignalIndex, List<string> SigDescription )
        {
            SignalIndex.Clear();
            SigDescription.Clear();
            string line = string.Empty;
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            while ((line = sr.ReadLine())!=null)
            {
                string[] strArray = line.Split('：');
                SignalIndex.Add(strArray[0].Trim());
                SigDescription.Add(strArray[1].Trim());
            }
            sr.Close();
        }

        public void SingalContentAdd(string path,string Content)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(Content);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        public void SignalContentDelete(string path,string content)
        {

        }
    }

    class FileIndex
    {
        public FileIndex()
        {
            strIndex = new List<string>();
            strDescribe = new List<string>();
        }
        public List<string> strIndex { get; set; }
        public List<string> strDescribe { get; set; }

    }
}
