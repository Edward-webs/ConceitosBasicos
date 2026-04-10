using System;
using Super_Trunfo.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Super Trunfo - Fantasia Medieval!\nDigite seu nome: ");
        string nome = Console.ReadLine();
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine($"\nOlá, {nome}!\n----- Menu -----\n1. Novo Jogo\n2. Configurações\n3. Sair\n----------------");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    iniciarJogo();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"\nConfigurações:\nOlá {nome}! Bem-vindo(a) as configurações.\nRegras:\nO baralho do jogo possui 32 cartas, sendo divido em duas pilhas de 16 para cada jogador.\nCada carta possui 5 atributos, sendo eles: HP, Poder, Velocidade, Força e Resistência.\nUm jogador receberá uma carta e deve ser escolhido um atributo. Se o seu atributo for maior que o atributo do outro jogador, você ganha a carta dele.\nO jogador que consquistar todas as cartas do oponente, vence o jogo.\nNesta versão do jogo há apenas dois jogadores, sendo eles: você e o computador.");
                    break;
                case "3":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor digite um valor válido.");
                    break;
            }
        }
    }
    static void iniciarJogo()
    {
        Random embaralhar = new Random();

        Baralho baralho = new Baralho();
        Carta[] cartasTotal = baralho.getCards();

        for (int i = cartasTotal.Length - 1; i > 0; i--)
        {
            int j = embaralhar.Next(i + 1);
            Carta carta = cartasTotal[i];
            cartasTotal[i] = cartasTotal[j];
            cartasTotal[j] = carta;
        }

        Carta[] jogadorBaralho = new Carta[32];
        Carta[] computadorBaralho = new Carta[32];

        int totalJogador = 16;
        int totalComputador = 16;

        for (int i = 0; i < 16; i++)
        {
            jogadorBaralho[i] = cartasTotal[i];
            computadorBaralho[i] = cartasTotal[i + 16];
        }

        while (totalJogador > 0 && totalComputador > 0)
        {
            Console.Clear();
            Console.WriteLine($"\n--- Placar: Você : {totalJogador} | Computador : {totalComputador} ---");

            Carta jCarta = jogadorBaralho[0];
            Carta cCarta = computadorBaralho[0];

            bool escolhaValida = false;

            int aJogador = 0, aComputador = 0;

            while (!escolhaValida)
            {
                jCarta.displayCard();
                Console.WriteLine("Escolha o atributo:\nA. HP\nB. Poder\nC. Velocidade\nD. Força\nE. Resistência\n");
                string escolha = Console.ReadLine().ToUpper();

                escolhaValida = true;

                switch (escolha)
                {
                    case "A":
                        aJogador = jCarta.Hp;
                        aComputador = cCarta.Hp;
                        break;
                    case "B":
                        aJogador = jCarta.Power;
                        aComputador = cCarta.Power;
                        break;
                    case "C":
                        aJogador = jCarta.Speed;
                        aComputador = cCarta.Speed;
                        break;
                    case "D":
                        aJogador = jCarta.Strength;
                        aComputador = cCarta.Strength;
                        break;
                    case "E":
                        aJogador = jCarta.Resistance;
                        aComputador = cCarta.Resistance;
                        break;
                    default:
                        Console.WriteLine("Valor inválido! Por favor insira um valor válido.");
                        escolhaValida = false;
                        break;
                }
            }
            if (jCarta.Supertrunfo)
            {
                Console.WriteLine("SUPER TRUNFO! Você VENCEU essa rodada automaticamente!");
                aJogador = 1;
                aComputador = 0;
            }
            else if (cCarta.Supertrunfo)
            {
                Console.WriteLine("O computador possui SUPER TRUNFO! Você PERDEU essa rodada automaticamente!");
                aJogador = 0;
                aComputador = 1;
            }

            Console.WriteLine($"\nSua carta: {jCarta.Name} ({aJogador}) vs Carta do Computador: {cCarta.Name} ({aComputador})");

            totalJogador--;
            totalComputador--;

            for (int i = 0; i < totalJogador; i++)
            {
                jogadorBaralho[i] = jogadorBaralho[i + 1];
            }

            for (int i = 0; i < totalComputador; i++)
            {
                computadorBaralho[i] = computadorBaralho[i + 1];
            }

            if (aJogador > aComputador)
            {
                Console.WriteLine("Você VENCEU a rodada! +1 carta.\n");
                jogadorBaralho[totalJogador] = jCarta;
                jogadorBaralho[totalJogador + 1] = cCarta;
                totalJogador += 2;
            }
            else if (aComputador > aJogador)
            {
                Console.WriteLine("Você PERDEU a rodada! O computador pegou sua carta.\n");
                computadorBaralho[totalComputador] = cCarta;
                computadorBaralho[totalComputador + 1] = jCarta;
                totalComputador += 2;
            }
            else
            {
                Console.WriteLine("EMPATE! Cada um fica com sua carta.");
                jogadorBaralho[totalJogador] = jCarta;
                computadorBaralho[totalComputador] = cCarta;
                totalJogador++;
                totalComputador++;
            }

            if (totalJogador >= 32 || totalComputador >= 32)
            {
                break;
            }

            Console.WriteLine("Pressione Enter para próxima rodada...");
            Console.ReadLine();
        }

        if (totalJogador > 0)
        {
            Console.WriteLine("\nPARABÉNS! Você ganhou o jogo!");
        }
        else
        {
            Console.WriteLine("\nQue pena... O computador venceu.");
        }
    }
}