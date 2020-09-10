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
<<<<<<< HEAD

=======
>>>>>>> master
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
<<<<<<< HEAD

        public String FileIndex_OnListChange(StringBuilder strB,List<string> index,List<string> Describe)
        {
            strB.Clear();
            for (int i = 0; i < index.Count; i++)
            {
                strB.AppendLine(index[i] + "：" + Describe[i]);
            }
            return strB.ToString();
        }
=======
>>>>>>> master
    }

    class FileIndex
    {
<<<<<<< HEAD
        private delegate void ListChange();
        private event ListChange OnListChange;
        private List<string> ObserveStr = new List<string>();
        private List<string> StrDescribe = new List<string>();
        public FileIndex()
        {
            StrB = new StringBuilder();
            strIndex = new List<string>();
            strDescribe = new List<string>();
        }

      


        private void ListValueChange()
        {
            OnListChange?.Invoke();
        }

        public List<string> strIndex  { get; set; }
        public List<string> strDescribe { get; set; }

        public StringBuilder StrB { get; set; }

=======
        public FileIndex()
        {
            strIndex = new List<string>();
            strDescribe = new List<string>();
        }
        public List<string> strIndex { get; set; }
        public List<string> strDescribe { get; set; }

>>>>>>> master
    }
}
