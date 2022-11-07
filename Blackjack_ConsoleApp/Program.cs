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
            
            int selectedOption = 1;
            
            while (selectedOption != 9)
            {
                
                Console.Clear();
                Console.WriteLine("BlackJack Game");
                Console.WriteLine("--------------");
                Console.WriteLine(" 1. Single Player");
                Console.WriteLine(" 2. About Game");
                Console.WriteLine(" 3. Leaderboard");
                Console.WriteLine(" 4. Quit");

                Console.WriteLine("Type numeral and hit enter to select option");
                selectedOption = Int32.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    
                    case 1:
                           Console.Clear();
                           Console.WriteLine("Dealer: What is your name?");
                           string player1Name = Console.ReadLine();
                           int player1Chips = 500;
                        Console.Clear();   
                        Console.WriteLine("Dealer: Welcome to the table, " + player1Name + "!");
                        int singlePlayerSelectedOption = 0;
                        while (singlePlayerSelectedOption != 2)
                        {
                            
                            
                            Console.WriteLine("You have " + player1Chips + " chips");
                            Console.WriteLine("Your hand: ");

                            var player1Profile = new List<Player>();
                            var Player = new Player();
                            Player.playerName = player1Name;
                            Player.chipCount = player1Chips;
                            player1Profile.Add(Player);

                            //deals cards to player
                            var player1CardsList = new List<DealtCards>();
                            for (int i = 0; i < 2; i++)
                            {
                                var DealtCards = new DealtCards();
                                int cardRoll = UtilityDealer.RandomCardRoll();
                                string playerCardFace = UtilityDealer.DealCardFace(cardRoll);
                                int playerCardValue = UtilityDealer.DealCardValue(cardRoll);
                                DealtCards.cardFaceDealt = playerCardFace;
                                DealtCards.cardValueDealt = playerCardValue;
                                player1CardsList.Add(DealtCards);
                            }
                            int handTotal = player1CardsList[0].cardValueDealt + player1CardsList[1].cardValueDealt;

                            UtilityDealer.AceElevenToOne(handTotal, player1CardsList);


                            //displays hand card faces
                            for (int i = 0; i < player1CardsList.Count; i++)
                            {
                                Console.WriteLine(player1CardsList[i].cardFaceDealt);
                            }

                            Console.WriteLine("Hand total: " + handTotal);

                            //deals for the dealer
                            var dealerCardsList = new List<DealtCards>();
                            for (int i = 0; i < 2; i++)
                            {
                                var DealtCards = new DealtCards();
                                int cardRoll = UtilityDealer.RandomCardRoll();
                                string dealerCardFace = UtilityDealer.DealCardFace(cardRoll);
                                int dealerCardValue = UtilityDealer.DealCardValue(cardRoll);
                                DealtCards.cardFaceDealt = dealerCardFace;
                                DealtCards.cardValueDealt = dealerCardValue;
                                dealerCardsList.Add(DealtCards);
                            }

                            int dealerHandTotal = dealerCardsList[0].cardValueDealt + dealerCardsList[1].cardValueDealt;

                            Dealer.DealerAceElevenToOne(dealerHandTotal, dealerCardsList);

                            Console.WriteLine("Dealers up card: ");
                            Console.WriteLine(dealerCardsList[1].cardFaceDealt);


                            //temp

                            //Console.WriteLine("Dealer hand total: " + dealerHandTotal);




                            if (handTotal < 21)
                            {
                                Console.WriteLine("Do you want to hit? Y or N");
                                var hitOrPass = Console.ReadLine();
                                var hitOrPassToLower = hitOrPass.ToLower();

                                while (handTotal < 21 && hitOrPassToLower == "y")
                                {
                                    var DealtCards = new DealtCards();
                                    int cardRoll = UtilityDealer.RandomCardRoll();
                                    string playerCardFace = UtilityDealer.DealCardFace(cardRoll);
                                    int playerCardValue = UtilityDealer.DealCardValue(cardRoll);
                                    DealtCards.cardFaceDealt = playerCardFace;
                                    DealtCards.cardValueDealt = playerCardValue;
                                    player1CardsList.Add(DealtCards);

                                    Console.Clear();
                                    //displays hand card faces

                                    for (int i = 0; i < player1CardsList.Count; i++)
                                    {
                                        Console.WriteLine(player1CardsList[i].cardFaceDealt);
                                    }

                                    //adds player's new cards together then displays them

                                    handTotal = player1CardsList.Sum(x => x.cardValueDealt);
                                    UtilityDealer.AceElevenToOne(handTotal, player1CardsList);
                                    handTotal = player1CardsList.Sum(x => x.cardValueDealt);

                                    Console.WriteLine("Hand total: " + handTotal);
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Dealer's up card: " + dealerCardsList[1].cardFaceDealt);
                                    
                                    UtilityDealer.DidYouBust(handTotal);

                                    if (handTotal < 21)
                                    {
                                        Console.WriteLine("Do you want to hit again? Y or N");
                                        hitOrPass = Console.ReadLine();
                                        hitOrPassToLower = hitOrPass.ToLower();
                                    }


                                }
                            }

                            Dealer.DealerPlayChoice(dealerHandTotal, dealerCardsList);

                            dealerHandTotal = dealerCardsList.Sum(x => x.cardValueDealt);



                            Console.WriteLine("Dealer hand total: " + dealerHandTotal);

                            UtilityBets.DidPlayerWin(handTotal, dealerHandTotal);
                            
                            Console.WriteLine("Press 1 to play again or 9 to return to the main menu");
                            singlePlayerSelectedOption = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            if (singlePlayerSelectedOption != 1)
                            {
                                singlePlayerSelectedOption = 2;
                                UtilitySave.ReturnToMainMenu();
                            }
                            
                        }
                        

                       break;

                    case 2:
                        Console.Clear();
                        AboutGame.DisplayAbout();

                        break;


                    case 4:
                        Environment.Exit(0);


                        break;
                }
            }
            
        
        }
        
    }
}


