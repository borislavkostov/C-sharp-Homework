using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            for (int card = 2; card < 15; card++)
            {
                for (int color = 0; color < 4; color++)
                {
                    switch (card)
                    {
                        case 2: Console.Write("2"); break;
                        case 3: Console.Write("3"); break;
                        case 4: Console.Write("4"); break;
                        case 5: Console.Write("5"); break;
                        case 6: Console.Write("6"); break;
                        case 7: Console.Write("7"); break;
                        case 8: Console.Write("8"); break;
                        case 9: Console.Write("9"); break;
                        case 10: Console.Write("10"); break;
                        case 11: Console.Write("J"); break;
                        case 12: Console.Write("Q"); break;
                        case 13: Console.Write("K"); break;
                        case 14: Console.Write("A"); break;
                    }
                    switch (color)
                    {
                        case 0: Console.WriteLine('♠'); break;
                        case 1: Console.WriteLine('♥'); break;
                        case 2: Console.WriteLine('♣'); break;
                        case 3: Console.WriteLine('♦'); break;

                    }
                    Console.SetCursorPosition(position, color + 1);
                }
                position += 4;
                Console.SetCursorPosition(position, 0);
            }
        }
    }
}

