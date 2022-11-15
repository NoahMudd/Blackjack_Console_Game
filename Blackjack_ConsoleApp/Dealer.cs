using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class Dealer
    {
        public string dealerName = ("Coolidge");

        public static List<DealtCards> DealerPlayChoice(int dealerHandTotal, List<DealtCards> dealerCardsList)
        {
            while (dealerHandTotal < 17)
            {

                {
                    var DealtCards = new DealtCards();
                    int cardRoll = UtilityDealer.RandomCardRoll();
                    string dealerCardFace = UtilityDealer.DealCardFace(cardRoll);
                    int dealerCardValue = UtilityDealer.DealCardValue(cardRoll);
                    DealtCards.cardFaceDealt = dealerCardFace;
                    DealtCards.cardValueDealt = dealerCardValue;
                    dealerCardsList.Add(DealtCards);
                    dealerHandTotal = dealerCardsList.Sum(x => x.cardValueDealt);
                    Dealer.DealerAceElevenToOne(dealerHandTotal, dealerCardsList);
                    dealerHandTotal = dealerCardsList.Sum(x => x.cardValueDealt);
                }
            }
            return dealerCardsList;
            
                
        }
        public static List<DealtCards> DealerAceElevenToOne(int dealerHandTotal, List<DealtCards> dealerCardsList)
        {
            while (dealerHandTotal > 21 && dealerCardsList.Any(card => card.cardValueDealt == 11))
            {
                var i = dealerCardsList.FirstOrDefault(card => card.cardValueDealt == 11);
                i.cardValueDealt = 1;

                dealerHandTotal = dealerCardsList.Sum(x => x.cardValueDealt);
            }

            return dealerCardsList;
        }


        public static List<DealtCards> DealerDealFirstCards()
        {
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

            return dealerCardsList;
        }
    
    
    }
}
