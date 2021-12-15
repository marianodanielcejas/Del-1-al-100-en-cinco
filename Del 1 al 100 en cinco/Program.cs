using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_1_al_100_en_cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 1;
            int Num2 = 100;
            while(Num1 <= Num2)
            {
                Console.WriteLine("{0}", Num1);
                if (Num1 == 1)
                {
                    Num1 = Num1 + 4;
                }
                else
                {
                    Num1 = Num1 + 5;
                }
            }
            Console.Read();
        }
    }
}
