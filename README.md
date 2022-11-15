# Blackjack_Console_Game Over View
  This is a console application that allows the user to play blackjack against an AI dealer. The player is able to place bets and accumulate winnings within a game session. The game session ends when the user exits to the main menu, closes the console app, or runs out of chips. Instruction on how to play is found within the main menu.
## How the Game Works
  The coding of the game is nested within a while loop to allow the user to return to the main menu at the end of a turn, or at anytime while viewing the rules and leaderboard. 
  When a new game is started, a list is generated for the players name and their starting chips. Cards are then dealt to the player and dealer. This is done by generating a random number between 2 and 14, and assigning a card face and value to the number rolled. This, in turn, is assigned to a list associated with the player or dealer. The card values within a list are added together to give a card total for both parties. If either party receives additional cards, a LINQ method is used to find the new total card value. During the players turn, if the players hand total is less than 21 they are asked if they would like to recieve an additional card. They will continue to be asked until they decline, or their hand total equals or exceeds 21. If the player's hand totals more than 21 at anytime a message appears that they've busted and lost. 
  Once the player has decided to keep their current hand the dealer decides how they will play theirs. This is done the same way it is done in casinos. If their hand total is less than or equal to 16 they will recieve another card. Else, they will keep their current hand
  In blackjack, an ace card can be equal to an 11 or a 1. To accommodate this, a LINQ query is performed if a hand total exceeds 21. It looks for a card value equal to 11 in a list, and sets it equal to 1.