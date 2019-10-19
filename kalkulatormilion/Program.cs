using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulatormilion
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("0. Wyjscie");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. odejmowanie");
                Console.WriteLine("3. Mnozenie");
                Console.WriteLine("4. Kij Ci w oko :)");
               
                
                int menuOption = Convert.ToInt32(Console.ReadLine());


                if (menuOption == 0)
                    break;
              
            }
        }
    }
}
