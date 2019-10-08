using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file_name = File.ReadAllLines("1.txt");
            Console.WriteLine(file_name[2]);
            string str = file_name[2];
            string nstr = string.Reverse(str.ToArray);
            Console.WriteLine(nstr);
            Console.ReadLine();


        }
    }
}
