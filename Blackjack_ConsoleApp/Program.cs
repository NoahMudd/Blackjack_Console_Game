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
                    Console.WriteLine("Your hand: ");
                   
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
                    
                    //displays hand card faces

                    for (int i = 0; i < player1CardsList.Count; i++)
                    {
                        Console.WriteLine(player1CardsList[i].cardFaceDealt);
                    }
                    
                    
                    //adds player's cards together then displays them
                    int handTotal = player1CardsList[0].cardValueDealt + player1CardsList[1].cardValueDealt;
                    Console.WriteLine("Hand total: " + handTotal);

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

                            //displays hand card faces

                            for (int i = 0; i < player1CardsList.Count; i++)
                            {
                                Console.WriteLine(player1CardsList[i].cardFaceDealt);
                            }

                            //adds player's new cards together then displays them
                            
                                handTotal = player1CardsList.Sum(x => x.cardValueDealt);


                                //handTotal = handTotal + player1CardsList[i].cardValueDealt;
                                Console.WriteLine("Hand total: " + handTotal);

                            UtilityDealer.DidYouBust(handTotal);

                            if (handTotal < 21)
                            {
                                Console.WriteLine("Do you want to hit again? Y or N");
                                hitOrPass = Console.ReadLine();
                                hitOrPassToLower = hitOrPass.ToLower();
                            }
                            

                         }
                    } 
                    
                    
                    
                    
                    
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

                    Console.WriteLine("Dealers hand: ");
                    
                    for (int i = 0; i < dealerCardsList.Count; i++)
                    {
                        Console.WriteLine(dealerCardsList[i].cardFaceDealt + " " + dealerCardsList[i].cardValueDealt);
                    }


                    int dealerHandTotal = dealerCardsList[0].cardValueDealt + dealerCardsList[1].cardValueDealt;
                    Console.WriteLine("Dealer hand total: " + dealerHandTotal);





                    

                    
                    
                    //string playerCardOne = UtilityDealer.DealCards();
                    //string playerCardTwo = UtilityDealer.DealCards();

                    //Console.WriteLine(playerCardOne);
                    //Console.WriteLine(playerCardTwo);

                    Console.ReadLine();
                    
                    
                    break;
            
            }
            

        }
        
    }
}


