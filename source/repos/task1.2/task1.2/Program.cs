using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи название файла");
            string[] textMass;
            string file_name = Console.ReadLine();
            Console.Write(File.ReadAllText(file_name));
            textMass = file_name.Split(' ');

            Console.WriteLine("words num:  " + file_name.Length);
            Console.ReadKey();
        }
    }
}
