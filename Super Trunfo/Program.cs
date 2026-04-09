using System;

public class Carta
{
    // criação da classe carta com atributos e métodos
    private string _code;
    private string _name;
    private int _hp;
    private int _power;
    private int _speed;
    private int _strength;
    private int _resistance;

    public string Code
    {
        get { return _code; }
        set { _code = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }
    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    public int Strength
    {
        get { return _strength; }
        set { _strength = value; }
    }
    public int Resistance
    {
        get { return _resistance; }
        set { _resistance = value; }
    }

    public Carta(string code, string name, int hp, int power, int speed, int strength, int resistance)
    {
        _code = code;
        _name = name;
        _hp = hp;
        _power = power;
        _speed = speed;
        _strength = strength;
        _resistance = resistance;
    }

    public void displayCard()
    {
        // função para exibir a carta e seus atributos
        Console.WriteLine("\n------- SUA CARTA -------");
        Console.WriteLine($"[{_code}] {_name}");
        Console.WriteLine($"A. HP: {_hp}");
        Console.WriteLine($"B. Poder: {_power}");
        Console.WriteLine($"C. Velocidade: {_speed}");
        Console.WriteLine($"D. Força: {_strength}");
        Console.WriteLine($"E. Resistência: {_resistance}");
        Console.WriteLine("------------------------");
    }
}

public class Baralho
{
    private Carta[] _cards = new Carta[32];

    public Baralho()
    {
        // função que cria e adiciona cartas ao array Carta[]"
        _cards[0] = new Carta("A1", "Guerreiro", 100, 85, 40, 80, 90);
        _cards[1] = new Carta("A2", "Mago", 80, 90, 60, 70, 60);
        _cards[2] = new Carta("A3", "Arqueiro", 90, 75, 80, 65, 70);
        _cards[3] = new Carta("A4", "Ladino", 70, 80, 90, 60, 50);
        _cards[4] = new Carta("A5", "Paladino", 110, 80, 50, 85, 95);
        _cards[5] = new Carta("A6", "Bárbaro", 120, 90, 30, 95, 80);
        _cards[6] = new Carta("A7", "Druida", 85, 75, 70, 65, 80);
        _cards[7] = new Carta("A8", "Assassino", 75, 85, 95, 55, 60);
        _cards[8] = new Carta("B1", "Necromante", 80, 90, 50, 70, 65);
        _cards[9] = new Carta("B2", "Monge", 90, 80, 85, 60, 75);
        _cards[10] = new Carta("B3", "Feiticeiro", 85, 90, 60, 70, 65);
        _cards[11] = new Carta("B4", "Anão", 100, 85, 40, 80, 90);
        _cards[12] = new Carta("B5", "Goblin", 60, 70, 50, 40, 30);
        _cards[13] = new Carta("B6", "Orc", 110, 80, 30, 90, 70);
        _cards[14] = new Carta("B7", "Troll", 120, 75, 20, 85, 80);
        _cards[15] = new Carta("B8", "Dragão", 150, 100, 40, 95, 90);
        _cards[16] = new Carta("C1", "Vampiro", 90, 85, 70, 80, 60);
        _cards[17] = new Carta("C2", "Zumbi", 80, 60, 30, 50, 40);
        _cards[18] = new Carta("C3", "Esqueleto", 70, 65, 40, 45, 35);
        _cards[19] = new Carta("C4", "Golem", 130, 75, 20, 85, 95);
        _cards[20] = new Carta("C5", "Anjo", 100, 90, 60, 80, 70);
        _cards[21] = new Carta("C6", "Demônio", 110, 85, 50, 90, 80);
        _cards[22] = new Carta("C7", "Fada", 80, 70, 90, 60, 50);
        _cards[23] = new Carta("C8", "Sereia", 85, 75, 80, 65, 70);
        _cards[24] = new Carta("D1", "Centauro", 95, 80, 70, 75, 65);
        _cards[25] = new Carta("D2", "Minotauro", 120, 85, 30, 90, 80);
        _cards[26] = new Carta("D3", "Fênix", 110, 90, 60, 85, 75);
        _cards[27] = new Carta("D4", "Grifo", 100, 80, 70, 75, 65);
        _cards[28] = new Carta("D5", "Hidra", 130, 85, 40, 90, 80);
        _cards[29] = new Carta("D6", "Quimera", 120, 80, 50, 85, 75);
        _cards[30] = new Carta("D7", "Gigante", 90, 75, 80, 65, 60);
        _cards[31] = new Carta("D8", "Fantasma", 95, 80, 70, 75, 65);
    }

    public Carta[] getCards()
    {
        // função para retornar o array de cartas que tem no baralho
        return _cards;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Super Trunfo - Fantasia Medieval!\nDigite seu nome: ");
        string nome = Console.ReadLine();
        bool sair = false;
        while (!sair)
        {
            // loop para exibição do menu principal e suas opções
            Console.WriteLine($"\nOlá, {nome}!\n----- Menu -----\n1. Novo Jogo\n2. Configurações\n3. Sair\n----------------");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    iniciarJogo();
                    break;
                case "2":
                    // limpa a tela e mostra as regras do jogo
                    Console.Clear();
                    Console.WriteLine("\nConfigurações:\nRegras:\nO baralho do jogo possui 32 cartas, sendo divido em duas pilhas de 16 para cada jogador.\nCada carta possui 5 atributos, sendo eles: HP, Poder, Velocidade, Força e Resistência.\nUm jogador receberá uma carta e deve ser escolhido um atributo. Se o seu atributo for maior que o atributo do outro jogador, você ganha a carta dele.\nNesta versão do jogo há apenas dois jogadores, sendo eles: você e o computador.");
                    break;
                case "3":
                    // faz com que o programa saia do loop, terminando a execução do programa
                    sair = true;
                    break;
                default:
                    // tratamento de erro para opções inválidas que o usuário inserir
                    Console.WriteLine("Opção inválida. Por favor digite um valor válido.");
                    break;
            }
        }
    }
    static void iniciarJogo()
    {
        // função que inicia o jogo, embaralhando as cartas, as dividindo entre os jogadores e comparando os atributos para determinar o vencedor do jogo
        Random embaralhar = new Random(); // comando para selecionar um número aleatório

        // cria um novo baralho
        Baralho baralho = new Baralho();
        Carta[] cartasTotal = baralho.getCards();

        for (int i = cartasTotal.Length - 1; i > 0; i--)
        {
            // embaralha as cartas
            int j = embaralhar.Next(i + 1);
            Carta carta = cartasTotal[i];
            cartasTotal[i] = cartasTotal[j];
            cartasTotal[j] = carta;
        }

        // cria dois baralhos, um para o jogador e outro para o computador
        Carta[] jogadorBaralho = new Carta[32]; // tamanho maior para caber as cartas que ganhar
        Carta[] computadorBaralho = new Carta[32];

        int totalJogador = 16;
        int totalComputador = 16;

        for (int i = 0; i < 16; i++)
        {
            // distribui as cartas para os jogadores
            jogadorBaralho[i] = cartasTotal[i];
            computadorBaralho[i] = cartasTotal[i + 16];
        }

        while (totalJogador > 0 && totalComputador > 0)
        {
            Console.Clear();
            Console.WriteLine($"\n--- Placar: Você : {totalJogador} | Computador : {totalComputador} ---");

            // atribui a primeira carta do baralho de cada jogador a uma variável para comparação
            Carta jCarta = jogadorBaralho[0];
            Carta cCarta = computadorBaralho[0];

            bool escolhaValida = false; // variável para controle de validez da respostas do usuário

            int aJogador = 0, aComputador = 0; // variáveis para guardar o valor do atributo selecionado

            while (!escolhaValida) // loop para tratar erro de resposta inválida
            {
                jCarta.displayCard();
                Console.WriteLine("Escolha o atributo:\nA. HP\nB. Poder\nC. Velocidade\nD. Força\nE. Resistência\n");
                string escolha = Console.ReadLine().ToUpper();

                escolhaValida = true; // assume que a resposta é válida, a não ser que caia no default

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
                        escolhaValida = false; // repete o loop
                        break;
                }
            }
            
            Console.WriteLine($"\nSua carta: {jCarta.Name} ({aJogador}) vs Carta do Computador: {cCarta.Name} ({aComputador})");

            // diminui os contadores antes de mover as cartas para não dar erro e o programa tentar ultrapassar o limite do array
            totalJogador--;
            totalComputador--;

            for (int i = 0; i < totalJogador; i++)
            {
                //puxa todas as cartas do baralho do usuário para frente
                jogadorBaralho[i] = jogadorBaralho[i + 1];
            }

            for (int i =0; i < totalComputador; i++)
            {
                //puxa todas as cartas do baralho do computador para frente
                computadorBaralho[i] = computadorBaralho[i + 1];
            }

            if (aJogador > aComputador)
            {
                Console.WriteLine("Você VENCEU a rodada! +1 carta.\n");
                jogadorBaralho[totalJogador] = jCarta; // adiciona a carta do usuário no final do array do baralho do usuário
                jogadorBaralho[totalJogador + 1] = cCarta; // adiciona a carta do computador no final do array do baralho do usuário
                totalJogador += 2; // aumenta dois de espaço para as cartas do baralho do usuário
            }
            else if (aComputador > aJogador)
            {
                // adiciona a carta do usuário e do computador ao baralho do computador
                Console.WriteLine("Você PERDEU a rodada! O computador pegou sua carta.\n");
                computadorBaralho[totalComputador] = cCarta; // adiciona a carta do computador no final do array do baralho do computador
                computadorBaralho[totalComputador + 1] = jCarta; // adiciona a carta do usuário no final do array do baralho do computador
                totalComputador += 2; // aumenta dois de espaço para as cartas do baralho do computador
            }
            else
            {
                // adiciona a carta do usuário ao baralho do usuário e a carta do computador ao baralho do computador
                Console.WriteLine("EMPATE! Cada um fica com sua carta.");
                jogadorBaralho[totalJogador] = jCarta; // adiciona a carta do usuário no final do array do baralho do próprio usuário
                computadorBaralho[totalComputador] = cCarta; // adiciona a carta do computador no final do array do baralho do própri computador
                totalJogador++;
                totalComputador++;
            }

            if (totalJogador >=32 || totalComputador >= 32)
            {
                // se qualquer um dos dois arrays chegar no 32 ou tentar ultrapassá-lo, significa que o baralho conquistou todas as cartas do jogo, decidindo o vencedor
                break;
            }

            Console.WriteLine("Pressione Enter para próxima rodada...");
            Console.ReadLine();
        }

        if (totalJogador > 0)
        {
            // se apenas a quantidade de cartas do baralho do usuário for maior que 0, significa que a do computador é 0, então o computador perde
            Console.WriteLine("\nPARABÉNS! Você ganhou o jogo!");
        }
        else
        {
            // se apenas a quantidade de cartas do baralho do computador for maior que 0, significa que a do usuário é 0, então o usuário perde
            Console.WriteLine("\nQue pena... O computador venceu.");
        }
    }
}