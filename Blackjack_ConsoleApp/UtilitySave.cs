using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class UtilitySave
    {
        public static int ReturnToMainMenu()
        {
            
            int singlePlayerSelectedOption = Int32.Parse(Console.ReadLine());
            if (singlePlayerSelectedOption != 2 && singlePlayerSelectedOption != 1)
            {
                Console.WriteLine("Invalid input. Try agin.");
                singlePlayerSelectedOption = Int32.Parse(Console.ReadLine());
            }

            return singlePlayerSelectedOption;
        }

    }
}
