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


        //public enum CardFace
        //   {
        //     Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
        //} 

        public static string DealCards()
        {

            string cardFace;
            

        Random rnd = new Random();
                var cardRoll = rnd.Next(2, 15);

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

            //Console.WriteLine(cardFace);

                return cardFace;

            
        }
    public void playerHits()
        {
            Random rnd = new Random();
            int cardHit = rnd.Next(2, 15);
        }
    }

}
//most cards a player can have is 11 individual cards
//putting cards delt into a list