using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardOne;
            int cardTwo;

            
            
            Console.WriteLine("BlackJack Game");
            Console.WriteLine("--------------");
            Console.WriteLine(" 1. Single Player");
            Console.WriteLine(" 2. Multiplayer");
            Console.WriteLine(" 3. Rules");
            Console.WriteLine(" 4. Leaderboard");
            Console.WriteLine(" 5. Quit");

            Console.WriteLine("Type numeral and hit enter to select option");
            var selectedOption = Int32.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Dealer: What is your name?");
                    string player1Name = Console.ReadLine();
                    Console.WriteLine("Dealer: Welcome to the table, " + player1Name + "!");

                    //UtilityDealer.DealCards();


                    string playerCardOne = UtilityDealer.DealCards();
                    string playerCardTwo = UtilityDealer.DealCards();

                    Console.WriteLine(playerCardOne);
                    Console.WriteLine(playerCardTwo);

                    Console.ReadLine();
                    
                    
                    break;
            
            }
            

        }
        
    }
}


