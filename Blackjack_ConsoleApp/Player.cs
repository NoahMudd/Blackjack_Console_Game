using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_ConsoleApp
{
    public class Player
    {
        public string playerName { get; set;}
        public int chipCount { get; set; }

        public int playerBet { get; set; }  
        
        public List<Player> playerList;
    }

}
