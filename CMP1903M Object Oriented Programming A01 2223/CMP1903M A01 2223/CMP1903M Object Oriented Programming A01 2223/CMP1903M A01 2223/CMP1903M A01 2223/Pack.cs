using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();  

        public Pack()
        {
            //Initialise the card pack here
            
            for (int i = 1; i < 5; i++) // Values of the suit types
            {
                for (int j = 1; j < 14; j++) // Values of the value type
                {
                    pack.Add(new Card(j, i)); // Adds card to pack
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle) // Switch case
            {

                case 1:
                    Console.WriteLine("Fisher-Yates Shuffle: \n"); // Shuffles the deck Fisher-yates style
                    pack = Shuffle.FisherYates(pack);
                    break;
                case 2:
                        Console.WriteLine("Riffle Shuffle: \n"); // Shuffles the deck Riffle style
                        pack = Shuffle.Riffle(pack);
                        break;
                case 3:
                        Console.WriteLine("No Shuffle: \n"); // No shuffle type deck
                        break;
                default:
                    Console.WriteLine("ERROR, that is not a valid option.\n"); //Switch cases other than 1,2 and 3 are defaulted as an Error 
                    return false;
            }
            return true;
        }
        public static Card deal()
        {
            //Deals one card
            Card card = pack[0];
            pack.RemoveAt(0); // Removes card from list           
            return card;

        }
        public static List<Card> dealCards(int amount)
        {
            //Deals the number of cards specified by 'amount'
            Card[] cards = new Card[amount];

            for (int i = 0; i < amount; i++)
            {
                cards[i] = deal(); // Deals a specified amount of cards
            }
            return cards.ToList(); //After, returns cards back to list
        }

    }
}
