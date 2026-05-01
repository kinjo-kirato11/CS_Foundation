using Microsoft.VisualBasic.FileIO;
using Ex_04_05;
using System.Collections.Generic;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Ex_04_05;

static class Program
{
    static void Main(string[] args)
    {
        List<string> datas = new List<string>();

        while (true)
        {
            Console.Write("書き込むデータを入力してください->");
            string? input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }
            datas.Add(input);
        }

        string fileName = "exercise05.txt";
        TextFileAccessor accessor = new TextFileAccessor();

        accessor.Write(fileName,datas);
        accessor.ReadAndPrint(fileName);

    }
}
