using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class UtilityBets
    {
        public int playerBet;

        public int playerBetReturn;
    
    //public static int BetIntake(int playerBet, bool winOrLose)
       // {

       // }
    
    public static List<Player> DidPlayerWin(int handTotal, int dealerHandTotal, List<Player>player1Profile)
        {
            if (handTotal > dealerHandTotal && handTotal <= 21)
            {
                Console.WriteLine("Congrats, you won!");
                int playerWinnings = player1Profile[0].playerBet + player1Profile[0].playerBet;
                int playerNewChipCount = player1Profile[0].chipCount + playerWinnings;
                player1Profile[0].chipCount = playerNewChipCount;
            }
            else if (handTotal == 21)
            {
                Console.WriteLine("Congrats, you won!");
                int playerWinnings = player1Profile[0].playerBet + player1Profile[0].playerBet;
                int playerNewChipCount = player1Profile[0].chipCount + playerWinnings;
                player1Profile[0].chipCount = playerNewChipCount;
            }
            else if (handTotal == dealerHandTotal && handTotal < 21)
            {
                Console.WriteLine("You tied the dealer! Your bet is returned.");
                int playerNewChipCount = player1Profile[0].chipCount + player1Profile[0].playerBet;
                player1Profile[0].chipCount = playerNewChipCount;
            }
            else if (handTotal <= 21 && dealerHandTotal > 21)
            {
                Console.WriteLine("The dealer busted, you won!");
                int playerWinnings = player1Profile[0].playerBet + player1Profile[0].playerBet;
                int playerNewChipCount = player1Profile[0].chipCount + playerWinnings;
                player1Profile[0].chipCount = playerNewChipCount;
            }

            else
            {
                Console.WriteLine("You lost!");
            }



            return player1Profile;
            
            
        }
    
        public static List<Player> TakePlayerBet(List<Player> player1Profile, int player1Chips)
        {
            Console.WriteLine("What would you like to bet?");
            Console.WriteLine("You have: " + player1Profile[0].chipCount);
            Console.WriteLine("Enter numerial input less than or equal to your current chips: ");
            int playerBet = Int32.Parse(Console.ReadLine());
            while(playerBet > player1Profile[0].chipCount || playerBet <= 0)
            {
                Console.WriteLine("Invalid bet amount. Try again: ");
                playerBet = Int32.Parse(Console.ReadLine());
            }
            int newChipCount = player1Profile[0].chipCount - playerBet;
            player1Profile[0].chipCount = newChipCount;
            player1Profile[0].playerBet = playerBet;
            return player1Profile;
        }
    
    
    
        public static int IsChipCountZero(List<Player> player1Profile)
        {
            if (player1Profile[0].chipCount == 0)
            {
                //Console.Clear();
                Console.WriteLine("You  are out of chips. Returning to main menu.");
                int singlePlayerSelectedOption = 2;
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                return singlePlayerSelectedOption;
            }
            else
            {
                int singlePlayerSelectedOption = 9;
                return singlePlayerSelectedOption;
            }

        }
    
    
    }
}
