using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char tempVariable='0';
            int count= 0;
            string stringer = Console.ReadLine();
            string result = "";
            char[] mass = stringer.ToCharArray();
            char[] number = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < number.Length; i++)
            {
                
                for (int j = 0; j < mass.Length; j++)
                {
                    
                    if (mass[j]==number[i])
                    {
                        count++;
                        tempVariable = number[i];
                    }
                }
                if (count != 0)
                {
                    result += tempVariable + ": " + count.ToString() + " | ";
                }
                count = 0;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }    
    }
}
