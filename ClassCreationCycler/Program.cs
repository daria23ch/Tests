using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreationCycler
{
    class Cycler
    {
        private List<Object> cyclers = new List<Object>();

        public Cycler(List<Object> lists)
        {
            this.cyclers = lists;
        }

        public void GetNext(int n)
        {
            if (n<cyclers.Count)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(cyclers[i]);
                }
            }
            else
            {
                do
                {
                    foreach (var i in cyclers)
                    {
                        Console.WriteLine(i);
                    }
                    n -= cyclers.Count;
                } while (n >= cyclers.Count);

                if (n < cyclers.Count && n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(cyclers[i]);
                    }
                }
            }
           
        }
        
    }
    class Program
    {
         
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Object> cyc = new List<Object>() { 1,2,4,5,6};
            var cyclers = new Cycler(cyc);
            cyclers.GetNext(n);       
        }
    }
    
}
