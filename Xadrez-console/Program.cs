using System;
using Xadrez_console.Tabuleiro;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posicao: "+p);
        }
    }
}
