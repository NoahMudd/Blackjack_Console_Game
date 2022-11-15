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
            
            int selectedOption = Int32.Parse(Console.ReadLine());
            if (selectedOption != 9 && selectedOption != 1)
            {
                Console.WriteLine("Invalid input. Try agin.");
                selectedOption = Int32.Parse(Console.ReadLine());
            }

            return selectedOption;
        }

    }
}
