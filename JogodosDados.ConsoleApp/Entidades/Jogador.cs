namespace JogodosDados.ConsoleApp.Entidades;

using System.Security.Cryptography;

public static class Jogador
{

    public static int posicao = 0;
    const int chegada = 30;
    public static void ExecutarRodada()
    {
        Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("Corrida dos dados");
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        Console.WriteLine("Vez do jogador!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadLine();

        int dado = RandomNumberGenerator.GetInt32(1, 7);
        Console.WriteLine("Você roda o dado e o número que cai é: " + dado);

        posicao += dado;
        Console.WriteLine("Sua posição atual é: " + posicao);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dado == 6)
        {
            Console.WriteLine("VOCÊ TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dado = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("Você roda o dado e o número que cai é: " + dado);

            posicao += dado;
            Console.WriteLine("Sua posição atual é: " + posicao);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        switch (posicao)
        {
            case 2:
            case 10:
                Console.WriteLine("AVANÇO EXTRA, PULE 2 CASAS");
                posicao = posicao + 2;
                Console.WriteLine("Sua posição agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 16:
            case 7:
                Console.WriteLine("AVANÇO EXTRA, PULE 3 CASAS");
                posicao = posicao + 3;
                Console.WriteLine("Sua posição agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 26:
            case 5:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 2 CASAS");
                posicao = posicao - 2;
                Console.WriteLine("Sua posição agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 18:
            case 29:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 3 CASAS");
                posicao = posicao - 3;
                Console.WriteLine("Sua posição agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;
        }

        MensagemJogador();
    }

    public static bool GanhouPartida()
    {
        return posicao >= chegada;
    }

    private static void MensagemJogador()
    {
        if (posicao >= chegada)
        {
            Console.WriteLine("PARABÉNS, VOCê CHEGOU AO FINAL PRIMEIRO!!!!");
            Console.WriteLine("Pressione qualquer teclar para continuar!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}





