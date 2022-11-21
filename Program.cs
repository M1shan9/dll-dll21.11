using FunctionFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
   Global func = new Global();
   
   func.HelloWorld("Misha");
   Console.WriteLine("");
   
   func.Hobbies("Swimming");
   Console.WriteLine("");
   Console.WriteLine($"In ten years you will be - {func.AgeToFive(18)} ");
   Console.WriteLine("");
   Console.WriteLine($"twenty five + fifteen will be: - {func.GetSum("")}  ");

   Console.WriteLine("");
   Console.WriteLine($"the price list is - {func.Price(200)} ");

   Console.WriteLine("");
   Console.WriteLine($"the division is equal to: {func.division(36,2)}");
   Console.ReadLine();
  }
    }
}
