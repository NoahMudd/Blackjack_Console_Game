using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class UtilityDealer
    {
        public object cardFace { get; set; }
        public int cardValue { get; set; }

        //public enum CardFace
        //   {
        //     Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        //} 

        
        public static List<DealtCards> DealFirstCards()
        {
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



            return player1CardsList;
        }
        
        
        
        
        public static int RandomCardRoll()
        {
            Random rnd = new Random();
            var cardRoll = rnd.Next(2, 15);

            return cardRoll;
        }
        
        
        public static string DealCardFace(int cardRoll)
        {

            string cardFace;


            

            if (cardRoll == 11)
            {
                cardFace = "Jack";
            }
            else if (cardRoll == 12)
            {
                cardFace = "Queen";
            }
            else if (cardRoll == 13)
            {
                cardFace = "King";
            }
            else if (cardRoll == 14)
            {
                cardFace = "Ace";
            }
            else
            {
                cardFace = cardRoll.ToString();
            }





            return cardFace;

        }

         static public int DealCardValue(int cardRoll)
        {

            int cardValue;

            if (cardRoll < 11)
            {
                cardValue = cardRoll;
            }

            else if (cardRoll == 11)
            {
                cardValue = 10;
            }
            else if (cardRoll == 12)
            {
                cardValue = 10;
            }
            else if (cardRoll == 13)
            {
                cardValue = 10;
            }
            else
            {
                cardValue = 11;
            }


            return cardValue;
        }

            
        
        public static void DidYouBust(int handTotal)
        {
            if(handTotal > 21)
            {
                Console.WriteLine("You busted.");
            }

        }

        public static List<DealtCards> AceElevenToOne(int handTotal, List<DealtCards> player1CardsList)
        {
            while (handTotal > 21 && player1CardsList.Any(card => card.cardValueDealt == 11))
            {
                var i = player1CardsList.FirstOrDefault(card => card.cardValueDealt == 11);
                i.cardValueDealt = 1;

                handTotal = player1CardsList.Sum(x => x.cardValueDealt);
            }
        
            return player1CardsList;
        }

        public static void DisplayHandAndTotal(List<DealtCards> player1CardsList, int handTotal)
        {
            Console.WriteLine("Your hand: ");
            for (int i = 0; i < player1CardsList.Count; i++)
            {
                Console.WriteLine(player1CardsList[i].cardFaceDealt);
            }
            Console.WriteLine("Hand total: " + handTotal);
        }
       










    }
}


