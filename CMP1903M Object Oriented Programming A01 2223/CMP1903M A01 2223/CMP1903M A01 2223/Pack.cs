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
            
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    pack.Add(new Card(j, i));
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle) 
            {

                case 1:
                    Console.WriteLine("Fisher-Yates Shuffle: \n");
                    pack = Shuffle.FisherYates(pack);
                    break;
                case 2:
                        Console.WriteLine("Riffle Shuffle: \n");
                        pack = Shuffle.Riffle(pack);
                        break;
                case 3:
                        Console.WriteLine("No Shuffle: \n");
                        break;
                default:
                    Console.WriteLine("ERROR, that is not a valid option.\n");
                    return false;
            }
            return true;
        }
        public static Card deal()
        {
            //Deals one card
            Card card = pack[0];
            pack.RemoveAt(0);
            return card;

        }
        public static List<Card> dealCards(int amount)
        {
            //Deals the number of cards specified by 'amount'
            Card[] cards = new Card[amount];

            for (int i = 0; i < amount; i++)
            {
                cards[i] = deal();
            }
            return cards.ToList();
        }
    }
}
