using System;

namespace jogo_da_forca
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] valores = new string[10];
            valores[0] = "futebol";
            valores[1] = "basquete";
            valores[2] = "surf";
            valores[3] = "natacao";
            valores[4] = "volei";
            valores[5] = "atletismo";
            valores[6] = "ciclismo";
            valores[7] = "skate";
            valores[8] = "handebol";
            valores[9] = "basebol";

            Random rand = new Random();
            int indice = rand.Next(0,10);

            string valorGeradoIA = valores[indice];

            char chuteDoJogador; 
            int tentativas = 0;
            char[] palavraAux = new char[valorGeradoIA.Length];


            for (int i = 0; i < valorGeradoIA.Length; i++)
            {
                palavraAux[i] = '*';
            }

            while(tentativas < 6)
            {
                Console.WriteLine("Estou pensando em um esporte! Chute uma letra!");

                Console.WriteLine(palavraAux);

                chuteDoJogador = Console.ReadLine()[0]; 

                for(int i = 0; i < valorGeradoIA.Length; i++)
                {
                    if(chuteDoJogador == valorGeradoIA[i] && chuteDoJogador != palavraAux[i])
                    {
                        palavraAux[i] = chuteDoJogador;
                        tentativas --;
                    }

                }
                tentativas++;

                if(checaVitoria())
                {
                    tentativas = 6;
                    Console.WriteLine(palavraAux);
                }

            }
            for(int i = 0; i < palavraAux.Length; i++)
            {
                if(palavraAux[i] == '*')
                {
                    Console.WriteLine("Que pena, você perdeu"!);
                    return;
                }
                
            }
            Console.WriteLine("Parabéns, você ganhou!");

            bool checaVitoria()
            {
                for(int i = 0; i < palavraAux.Length; i++)
                {
                    if(palavraAux[i] == '*')
                    {
                        return false;
                    }
                    
                }
                return true;
            }

        }

    }
}
