using System;
using GameTOP;

namespace GameTop.lib
{
    public class Jogador2 : IJogador
    {

        public String Chuta()
        {
         return "MESSI está chutando";
        }
        public String Corre()
        {
           return "MESSI está Correndo";
        }

        public String Passe()
        {
           return "MESSI está passando";
        }
    }
}