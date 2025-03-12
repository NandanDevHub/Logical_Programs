using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerPrograms
{
    class CountOf1S
    {
        public void CountOf1()
        {
            int x, count = 0;

            Console.WriteLine("Enter the Numbers: ");
            x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); 

            int [] y = new int [x];
            Console.WriteLine("Add the " + x + "numbers: ");
            for (int z = 0; z < x; z++)
            {
                y[z] = int.Parse(Console.ReadLine());
            }

            foreach (var o in y)
            {
                if (o==1)
                {
                    count++;
                }
            }

            Console.WriteLine(" The Number of 1's are: {0}", count);
            Console.ReadKey();
        }
    }
}
