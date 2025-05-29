using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Multiple(5,20);
  
            Console.ReadLine();
        }
        //عدد دوم مضربی از عدد اول هست یا خیر
        public static bool Multiple(int number1, int number2)
        {
            if (number2 % number1 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
