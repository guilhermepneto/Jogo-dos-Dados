namespace JogodosDados.ConsoleApp;

using JogodosDados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        int chegada = 30;

        while (true)
        {
            int pos = 0;
            int pospc = 0;

            while (true)
            {
                //Rodada jogador
                pos = Jogador.ExecutarRodada(pos, chegada);

                if (pos >= chegada)
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





