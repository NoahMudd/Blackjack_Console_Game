using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class AboutGame
    {
        public static int DisplayAbout()
        {
            {
                   
                Console.WriteLine("Blackjack Console Game");
                Console.WriteLine("Blackjack is a card game where the goal is to get");
                Console.WriteLine("closer to 21 than the dealer, without going over.");
                Console.WriteLine("You'll place a bet before your cards are dealt.");
                Console.WriteLine("Next, you'll recieve two cards. You can either 'hit'");
                Console.WriteLine("or 'stand' to either receive another card, or pass.");
                Console.WriteLine("The dealer will then do the same, revealing the winner.");
                Console.WriteLine("at the end.");
                Console.WriteLine("");
                Console.WriteLine("Other Considerations");
                Console.WriteLine("-If you beat the dealer you win back double what you bet.");
                Console.WriteLine("-If your card total is exactly 21 you immediately win.");
                Console.WriteLine("-If you tie the dealer it's a 'push', your bet is returned.");
                
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Press 2 and hit Enter to return to main menu");
                int selectedOption = UtilitySave.ReturnToMainMenu();
                return selectedOption;
            }

        }
    }
}
