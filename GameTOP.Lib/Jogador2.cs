using System;
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador  
    {
            public readonly string _Nome;

            public Jogador2(string nome)
            {
                _Nome = nome;
            }
            public string Chuta()
            {
                return $"{_Nome} está chutando \n";
            }

            public string Corre()
            {
                return $"{_Nome} está Correndo \n";
            }

            public string Passe()
            {
                return $"{_Nome} está passando \n";
            }
    }
}