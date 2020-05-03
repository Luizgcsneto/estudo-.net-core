using System;


namespace GameTOP
{
    public class JogoFoda
    {
        public readonly  IJogador _jogadorA;
        public readonly  IJogador _jogadorB;

        public readonly IJogador _jogadorC; 
        public JogoFoda(IJogador jogadorA, IJogador jogadorB, IJogador jogadorC)
        {
           _jogadorA  = jogadorA;
           _jogadorB  = jogadorB;
           _jogadorC  = jogadorC;
        }

        public void iniciarJogo()
        {
          
          Console.WriteLine(_jogadorA.Chuta());
          Console.WriteLine(_jogadorA.Corre());
          Console.WriteLine(_jogadorA.Passe());

          Console.Write("\n Próximo \n");
          
          Console.WriteLine(_jogadorB.Chuta());
          Console.WriteLine(_jogadorB.Corre());
          Console.WriteLine(_jogadorB.Passe());
          
           Console.Write("\n Próximo \n");

          Console.WriteLine(_jogadorC.Chuta());
          Console.WriteLine(_jogadorC.Corre());
          Console.WriteLine(_jogadorC.Passe());


        }
    
    }
}