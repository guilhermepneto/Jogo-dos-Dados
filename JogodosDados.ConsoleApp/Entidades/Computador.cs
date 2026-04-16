using System.Security.Cryptography;
namespace JogodosDados.ConsoleApp.Entidades;

public class Computador
{
    public static int ExecutarRodada(int pospc, int chegada)
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

        pospc += dadopc;
        Console.WriteLine("A posição atual da máquina é: " + pospc);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dadopc == 6)
        {
            Console.WriteLine("A MÁQUINA TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dadopc = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("A máquina roda o dado e o número que cai é: " + dadopc);

            pospc += dadopc;
            Console.WriteLine("A posição atual da máquina é: " + pospc);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
        }

        switch (pospc)
        {
            case 2:
            case 10:
                Console.WriteLine("AVANÇO EXTRA, PULE 2 CASAS");
                pospc = pospc + 2;
                Console.WriteLine("A posição da máquina agora é: " + pospc);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 16:
            case 7:
                Console.WriteLine("AVANÇO EXTRA, PULE 3 CASAS");
                pospc = pospc + 3;
                Console.WriteLine("A posição da máquina agora é: " + pospc);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 26:
            case 5:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 2 CASAS");
                pospc = pospc - 2;
                Console.WriteLine("A posição da máquina agora é: " + pospc);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;

            case 18:
            case 29:
                Console.WriteLine("DÊ MEIA VOLTA, RETORNE 3 CASAS");
                pospc = pospc - 3;
                Console.WriteLine("A posição da máquina agora é: " + pospc);
                Console.WriteLine("-------------------------");
                Console.WriteLine();

                break;
        }
        MensagemPC(pospc, chegada);
        return pospc;
    }

    private static void MensagemPC(int pospc, int chegada)
    {
        if (pospc >= chegada)
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
