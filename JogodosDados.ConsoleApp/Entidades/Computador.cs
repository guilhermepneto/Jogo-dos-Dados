using System.Security.Cryptography;
namespace JogodosDados.ConsoleApp.Entidades;

public static class Computador
{

    public static int posicao = 0;
    const int chegada = 30;

    public static void ExecutarRodada()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Corrida dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Vez do Computador");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadLine();


        int dadopc = RandomNumberGenerator.GetInt32(1, 7);
        Console.WriteLine("A máquina roda o dado e o número que cai é: " + dadopc);

        posicao += dadopc;
        Console.WriteLine("A posição atual da máquina é: " + posicao);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dadopc == 6)
        {
            Console.WriteLine("A MÁQUINA TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dadopc = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("A máquina roda o dado e o número que cai é: " + dadopc);

            posicao += dadopc;
            Console.WriteLine("A posição atual da máquina é: " + posicao);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        switch (posicao)
        {
            case 2:
            case 10:
                Console.WriteLine("AVANÇO EXTRA, PULE 2 CASAS");
                posicao = posicao + 2;
                Console.WriteLine("A posição da máquina agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 16:
            case 7:
                Console.WriteLine("AVANÇO EXTRA, PULE 3 CASAS");
                posicao = posicao + 3;
                Console.WriteLine("A posição da máquina agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 26:
            case 5:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 2 CASAS");
                posicao = posicao - 2;
                Console.WriteLine("A posição da máquina agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 18:
            case 29:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 3 CASAS");
                posicao = posicao - 3;
                Console.WriteLine("A posição da máquina agora é: " + posicao);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;
        }
        MensagemPC();
    }

    public static bool GanhouPartida()
    {
        return posicao >= chegada;
    }

    private static void MensagemPC()
    {
        if (posicao >= chegada)
        {
            Console.WriteLine("A MÁQUINA TE VENCEU, MAIS SORTE NA PRÓXIMA VEZ");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
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
