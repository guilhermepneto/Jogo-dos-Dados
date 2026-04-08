using System.Security.Cryptography;

//CORRIDA DOS DADOS

Console.Clear();

Console.WriteLine("-------------------------");
Console.WriteLine("Seja bem vindo à corrida de dados, seu objetivo é cruzar a linha de chegada antes do computador. Você se considera uma pessoa de sorte?");
Console.WriteLine("Pressione qualquer tecla para iniciar o jogo!");
Console.WriteLine("-------------------------");
Console.ReadLine();

Console.WriteLine("O sistema irá decidir quem começa, se o dado cair 1, o jogador começa, caso caia 2, a máquina dará início");
Console.WriteLine("Pressione qualquer tecla para iniciar o jogo!");
Console.ReadLine();

int saida = RandomNumberGenerator.GetInt32(1, 3);
Console.WriteLine("O número sorteado foi " + saida);

if (saida == 1)
{
    Console.WriteLine("O jogador recebeu a honra de iniciar o caminho");
    Console.WriteLine("-------------------------");
    Console.WriteLine();
}
else
{
    Console.WriteLine("A máquina vai dar o primeiro passo!");
    Console.WriteLine("-------------------------");
    Console.WriteLine();
}

bool vitoria = false;
int rodada = 1;
int pos = 0;
int pospc = 0;

while (vitoria == false)
{
    if (saida == 1)
    {
        Console.WriteLine("Vez do jogador!");
        Console.WriteLine("RODADA nº " + rodada);
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadLine();

        int dado = RandomNumberGenerator.GetInt32(1, 7);
        Console.WriteLine("Você roda o dado e o número que cai é: " + dado);

        pos = pos + dado;
        Console.WriteLine("Sua posição atual é: " + pos);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dado == 6)
        {
            Console.WriteLine("VOCÊ TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dado = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("Você roda o dado e o número que cai é: " + dado);

            pos = pos + dado;
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

        if (pos >= 30)
        {
            Console.WriteLine("PARABÉNS, VOCê CHEGOU AO FINAL PRIMEIRO!!!!");
            vitoria = true;
        }

        rodada++;
    }
    else
    {
        Console.WriteLine("Vez da máquina!");
        Console.WriteLine("RODADA nº " + rodada);
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadLine();

        int dado = RandomNumberGenerator.GetInt32(1, 7);
        Console.WriteLine("A máquina roda o dado e o número que cai é: " + dado);

        pospc = pospc + dado;
        Console.WriteLine("A posição atual da máquina é: " + pospc);
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        if (dado == 6)
        {
            Console.WriteLine("A MÁQUINA TIROU O NÚMERO 6, JOGUE OS DADOS NOVAMENTE");

            dado = RandomNumberGenerator.GetInt32(1, 7);
            Console.WriteLine("A máquina roda o dado e o número que cai é: " + dado);

            pospc = pospc + dado;
            Console.WriteLine("A posição atual da máquina é: " + pos);
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

        if (pospc >= 30)
        {
            Console.WriteLine("A MÁQUINA TE VENCEU, MAIS SORTE NA PRÓXIMA VEZ");
            vitoria = true;
        }
    }
    if (saida == 1)
    {
        saida = 2;
    }
    else
    {
        saida = 1;
    }
}


Console.ReadLine();



