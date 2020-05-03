using System;
using GameTOP;

namespace GameTop.lib
{
    public class Jogador1 : IJogador
    {
        public readonly String _nome;
        public Jogador1(string nome)
        {
            _nome = nome;
        }
       
        public String Chuta()
        {
            return $"{_nome} deu um chutou";
        }

          public String Corre()
        {
             return $"{_nome} está correndo";
        }

          public String Passe()
        {
            return $"{_nome} deu um passe";
        }

    }
}