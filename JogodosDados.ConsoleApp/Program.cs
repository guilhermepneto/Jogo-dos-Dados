namespace JogodosDados.ConsoleApp;

using JogodosDados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Jogador.posicao = 0;
            Computador.posicao = 0;

            while (true)
            {
                //Rodada jogador
                Jogador.ExecutarRodada();

                if (Jogador.GanhouPartida())
                    break;

                //Rodada do PC
                Computador.ExecutarRodada();

                if (Computador.GanhouPartida())
                    break;
            }
            Console.WriteLine("--------------------------------------");
            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}





