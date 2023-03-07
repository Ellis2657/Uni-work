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
            Pack pack = new Pack();
            Pack.shuffleCardPack(0);
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(3);
            Console.WriteLine(Pack.deal());
            Console.WriteLine(Pack.dealCards(5));
        }
    }
}
