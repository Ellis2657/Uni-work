using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static public class Shuffle
    {

        static public List<Card> FisherYates(List<Card> deck) // creates a shuffle list for the fisher yates method
        {
            Random random = new Random();

            for (int n = deck.Count - 1; n >= 0; n--)
            {
                int x = random.Next(n + 1); //Randomly chooses cards to swap
                Card temp = deck[n];
                deck[n] = deck[x]; //Index of card position gos up 
                deck[x] = temp;
            }
            return deck; //Returns shuffled deck
        }

        static public List<Card> Riffle(List<Card> deck, int iterate = 156) // creates a list that shuffles through iterations
        {
            Random rand = new Random();
            Card card;

            for (int i = 0; i < iterate; i++)
            {
                int x = rand.Next(0, deck.Count); //Iterates through the pack and swaps values
                int y = x;

                while (x == y) // avoids card duplicates
                {
                    y = rand.Next(0, deck.Count); // goes to the next card
                }
                card = deck[x]; //card = next card in iteration
                deck[x] = deck[y]; //duplicate check 
                deck[y] = card; //if not the same card, swap value of card
                
            }
            return deck;


        }
        
            

        }



    
}
