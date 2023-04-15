using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string currentPath = Directory.GetCurrentDirectory() + "\\Metin.txt";
            FileStream fs;

            if (!File.Exists(currentPath))
            {
                 fs = new FileStream(currentPath, FileMode.Create);
            }
            else
            {
                //fs = new FileStream(currentPath, FileMode.Append);
                fs = new FileStream(currentPath, FileMode.Open);
            }

            /*fs.WriteByte(1);
            fs.WriteByte(2);
            fs.WriteByte(1);
            fs.WriteByte(7);*/

            //string str = "HelloWord";
            //byte[] strByt =  Encoding.ASCII.GetBytes(str);


            //fs.Write(strByt,2,5);
            //fs.Close();

            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write("Hello \n");
            //sw.Write("Word \n");
            //sw.Close();

            StreamReader sr = new StreamReader(fs);
            string strRead =  sr.ReadToEnd();
            sr.Close();



        }
    }
}
