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
            Console.WriteLine("Press 9 and hit Enter to return to main menu");
            int selectedOption = Int32.Parse(Console.ReadLine());
            if (selectedOption != 9)
            {
                Console.WriteLine("Invalid input. Try agin.");
                selectedOption = Int32.Parse(Console.ReadLine());
            }

            return selectedOption;
        }

    }
}
