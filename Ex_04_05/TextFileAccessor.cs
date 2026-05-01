using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Ex_04_05;

namespace Ex_04_05
{
    public class TextFileAccessor
    {
        public void Write(string fileName, List<string> datas)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string data in datas)
                {
                    sw.WriteLine(data);
                }
            }
            Console.WriteLine("ファイルにデータを書き込みました。");
        }
        public void ReadAndPrint(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }


            }
            Console.WriteLine("ファイルのデータを読み取りました。");

        }
    }
}