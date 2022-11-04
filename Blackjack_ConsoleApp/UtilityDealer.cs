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
        
        
        //static public int CardTotal(int cardValueDealt)
        //{
           // int handTotal;
            //for (int i = 0; i < player1CardsList.Count; i++)
            //{

            //}
            //player1CardsList.cardValueDealt

                
        
    
    
    
    
    
    
    
    }
}
//most cards a player can have is 11 individual cards
//putting cards delt into a list

//List<string> list = new List<string>();
//list.Add(cardFace);
//bool stringIntToInt = list.Contains("2", "3", "4", "5", "6", "7", "8", "9", "10");