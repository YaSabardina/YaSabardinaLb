using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file_name = File.ReadAllLines("1.txt");
            Console.WriteLine(file_name[0]);
            Console.WriteLine("Введите символ который хотите удалить");//The character is lowercase.
            char w = (char)Console.Read();
            Console.WriteLine(file_name[0].Trim(new char[] { ' ', '.' }));
    
            Console.ReadKey();
        }
    }
    
   
}
