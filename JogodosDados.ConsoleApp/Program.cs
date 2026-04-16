namespace JogodosDados.ConsoleApp;

using JogodosDados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            int pospc = 0;

            while (true)
            {
                //Rodada jogador
                Jogador.ExecutarRodada();

                if (Jogador.GanhouPartida())
                    break;

                //Rodada do PC
                pospc = Computador.ExecutarRodada(pospc, chegada);

                if (pospc >= chegada)
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





