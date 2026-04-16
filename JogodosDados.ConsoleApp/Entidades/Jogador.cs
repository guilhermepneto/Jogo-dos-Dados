namespace JogodosDados.ConsoleApp.Entidades;

using System.Security.Cryptography;

public class Jogador
{
    public static int ExecutarRodada(int pos, int chegada)
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

        pos += dado;
        Console.WriteLine("Sua posição atual é: " + pos);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dado == 6)
        {
            Console.WriteLine("VOCÊ TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dado = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("Você roda o dado e o número que cai é: " + dado);

            pos += dado;
            Console.WriteLine("Sua posição atual é: " + pos);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        switch (pos)
        {
            case 2:
            case 10:
                Console.WriteLine("AVANÇO EXTRA, PULE 2 CASAS");
                pos = pos + 2;
                Console.WriteLine("Sua posição agora é: " + pos);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 16:
            case 7:
                Console.WriteLine("AVANÇO EXTRA, PULE 3 CASAS");
                pos = pos + 3;
                Console.WriteLine("Sua posição agora é: " + pos);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 26:
            case 5:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 2 CASAS");
                pos = pos - 2;
                Console.WriteLine("Sua posição agora é: " + pos);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 18:
            case 29:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 3 CASAS");
                pos = pos - 3;
                Console.WriteLine("Sua posição agora é: " + pos);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;
        }

        MensagemJogador(pos, chegada);
        return pos;
    }

    private static void MensagemJogador(int pos, int chegada)
    {
        if (pos >= chegada)
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





