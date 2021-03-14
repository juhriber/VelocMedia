using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            int tempo;
            int velocidade;

            Console.Write("Digite seu Valor Distancia: ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Digite seu Valor Tempo: ");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("\n");

            velocidade = distancia / tempo;
            Console.WriteLine("Sua Velocidade Média é = {0} m/s", velocidade);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
