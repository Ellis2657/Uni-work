using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static public class Shuffle
    {

        static public List<Card> FisherYates(List<Card> deck)
        {
            Random random = new Random();

            for (int n = deck.Count - 1; n >= 0; n--)
            {
                int x = random.Next(n + 1);
                Card temp = deck[n];
                deck[n] = deck[x];
                deck[x] = temp;
            }
            return deck;
        }

        static public List<Card> Riffle(List<Card> deck, int iterate = 156)
        {
            Random rand = new Random();
            Card card;

            for (int i = 0; i < iterate; i++)
            {
                int x = rand.Next(0, deck.Count);
                int y = x;

                while (x == y)
                {
                    y = rand.Next(0, deck.Count);
                }
                card = deck[x];
                deck[x] = deck[y];
                deck[y] = card;
                
            }
            return deck;


        }
        
            

        }



    
}
