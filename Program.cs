using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    class Program
    {
        static void Main()
        {
            var atm = new ATM();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create Card");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine();
                Console.Write("Please make a selection: ");

                var input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-----------------");

                switch (input)
                {
                    case 1:
                        atm.CreateATMCard();
                        break;
                    case 2:
                        atm.WithDraw();
                        break;
                }
            }
        }
    }

}
