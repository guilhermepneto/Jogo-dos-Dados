using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
                pos = ExecutarRodadaJogador(pos);

                MensagemJogador(pos, chegada);
                if (pos >= chegada)
                    break;

                pospc = ExecutarRodadaPC(pospc);

                MensagemPC(pospc, chegada);
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

    static int ExecutarRodadaJogador(int pos)
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

        return pos;
    }

    static void MensagemJogador(int pos, int chegada)
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

    static int ExecutarRodadaPC(int pospc)
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
        return pospc;
    }

    static void MensagemPC(int pospc, int chegada)
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





