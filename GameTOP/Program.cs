using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo1 = new JogoFODA(
               new Jogador1("Ronaldo"), 
               new Jogador2("Zidane"));
           jogo1.IniciarJogo();
        }       

    }
}
