using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public static class Testing
    {
        public static void Test()
        {
            Pack pack = new Pack(); // Creates an object to access methods from pack
            Pack.shuffleCardPack(0);// Not a valid input, will output error message (Error handling)
            Pack.shuffleCardPack(1);// Shuffles the cards using the Fisher yates method from class Shuffle
            Pack.shuffleCardPack(2);// Shuffles the cards using the Riffle shuffle
            Pack.shuffleCardPack(3);// No shuffle method
            Console.WriteLine(Pack.deal());// Deals a singular card
            Console.WriteLine(Pack.pack[1].ToString());
            Console.WriteLine(Pack.dealCards(5));// Deals multiple cards
        }
    }
}
