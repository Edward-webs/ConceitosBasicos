#region Dudu
using System;
using System.Collections.Generic;
public class Card
{
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
    public Card(string code, string name, int hp, int power, int speed, int strength, int resistance)
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
        Console.WriteLine("-----Carta-----:");
        Console.WriteLine($"Código: {_code}");
        Console.WriteLine($"Nome: {_name}");
        Console.WriteLine($"HP: {_hp}");
        Console.WriteLine($"Poder: {_power}");
        Console.WriteLine($"Velocidade: {_speed}");
        Console.WriteLine($"Força: {_strength}");
        Console.WriteLine($"Resistência: {_resistance}");
        Console.WriteLine("---------------");
    }
}
public class Deck
{
    private List<Card> _cards = new List<Card>();
    public Deck()
    {
        createCard();
    }
    private void createCard()
    {
        _cards.Add(new Card("A1", "Guerreiro", 100, 85, 40, 80, 90));
        _cards.Add(new Card("A2", "Mago", 80, 90, 60, 70, 60));
        _cards.Add(new Card("A3", "Arqueiro", 90, 75, 80, 65, 70));
        _cards.Add(new Card("A4", "Ladino", 70, 80, 90, 60, 50));
        _cards.Add(new Card("A5", "Paladino", 110, 80, 50, 85, 95));
        _cards.Add(new Card("A6", "Bárbaro", 120, 90, 30, 95, 80));
        _cards.Add(new Card("A7", "Druida", 85, 75, 70, 65, 80));
        _cards.Add(new Card("A8", "Assassino", 75, 85, 95, 55, 60));
        _cards.Add(new Card("B1", "Necromante", 80, 90, 50, 70, 65));
        _cards.Add(new Card("B2", "Monge", 90, 80, 85, 60, 75));
        _cards.Add(new Card("B3", "Feiticeiro", 85, 90, 60, 70, 65));
        _cards.Add(new Card("B4", "Anão", 100, 85, 40, 80, 90));
        _cards.Add(new Card("B5", "Golbin", 60, 70, 50, 40, 30));
        _cards.Add(new Card("B6", "Orc", 110, 80, 30, 90, 70));
        _cards.Add(new Card("B7", "Troll", 120, 75, 20, 85, 80));
        _cards.Add(new Card("B8", "Dragão", 150, 100, 40, 95, 90));
        _cards.Add(new Card("C1", "Vampiro", 90, 85, 70, 80, 60));
        _cards.Add(new Card("C2", "Zumbi", 80, 60, 30, 50, 40));
        _cards.Add(new Card("C3", "Esqueleto", 70, 65, 40, 45, 35));
        _cards.Add(new Card("C4", "Golem", 130, 75, 20, 85, 95));
        _cards.Add(new Card("C5", "Anjo", 100, 90, 60, 80, 70));
        _cards.Add(new Card("C6", "Demônio", 110, 85, 50, 90, 80));
        _cards.Add(new Card("C7", "Fada", 80, 70, 90, 60, 50));
        _cards.Add(new Card("C8", "Sereia", 85, 75, 80, 65, 70));
        _cards.Add(new Card("D1", "Centauro", 95, 80, 70, 75, 65));
        _cards.Add(new Card("D2", "Minotauro", 120, 85, 30, 90, 80));
        _cards.Add(new Card("D3", "Fênix", 110, 90, 60, 85, 75));
        _cards.Add(new Card("D4", "Grifo", 100, 80, 70, 75, 65));
        _cards.Add(new Card("D5", "Hidra", 130, 85, 40, 90, 80));
        _cards.Add(new Card("D6", "Quimera", 120, 80, 50, 85, 75));
        _cards.Add(new Card("D7", "Gigante", 90, 75, 80, 65, 60));
        _cards.Add(new Card("D8", "Fantasma", 95, 80, 70, 75, 65));
    }
    public List<Card> GetCards()
    {
        return _cards;
    }
}
#endregion

#region Julia
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao jogo Super Trunfo - Fantasia Medieval!\nDigite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"\nOlá, {nome}!:)\n---Menu de opções---\nDigite:\n1. Novo jogo\n2. Configurações\n3. Sair do jogo\n--------------------\n");

        bool sair = false;
        while (!sair)
        {
            string entrada = Console.ReadLine();
            int opcao;
            int i;

            if (int.TryParse(entrada, out opcao))
            {
                if (opcao == 1)
                {
                    Console.WriteLine("\nIniciando um novo jogo...");
                    Console.WriteLine("As cartas foram sorteadas e dividas\n");

                    Deck baralho = new Deck();
                    List<Card> cartas = new List<Card>(baralho.GetCards());

                    List<Card> jogador = new List<Card>();
                    List<Card> computador = new List<Card>();

                    Random embaralho = new Random();

                    for (i = 0; i < 15; i++)
                    {
                        int a = embaralho.Next(cartas.Count);
                        int b = embaralho.Next(cartas.Count);

                        Card temporaria = cartas[a];
                        cartas[a] = cartas[b];
                        cartas[b] = temporaria;
                    }

                    for (i = 0; i < cartas.Count; i++)
                        if (i % 2 == 0)
                        {
                            jogador.Add(cartas[i]);
                        }
                        else
                        {
                            computador.Add(cartas[i]);
                        }

                    int rodada = 1;

                    Random sorteada = new Random();
                    int c = sorteada.Next(jogador.Count);
                    jogador[c].displayCard();
                    Console.WriteLine($"Essa é sua {rodada}º carta sorteada!\n");

                    rodada++;

                    if (rodada % 2 == 0)
                    {
                        Console.WriteLine("Escolha qual característica sua carta vai disputar nessa rodada:\n A. HP\n B. Poder\n C. Velocidade\n D. Força\n E. Resistência");
                    }
                    else
                    {
                        Random atributo_aleatorio = new Random();
                    }
                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "A")
                    {
                        Console.WriteLine("Você escolheu disputar por HP");
                    }
                    else if (resposta.ToUpper() == "B")
                    {
                        Console.WriteLine("Você escolheu disputar por Poder!");
                    }
                    else if (resposta.ToUpper() == "C")
                    {
                        Console.WriteLine("Você escolheu disputar por Velocidade!");
                    }
                    else if (resposta.ToUpper() == "D")
                    {
                        Console.WriteLine("Você escolheu disputar por Força!");
                    }
                    else if (resposta.ToUpper() == "E")
                    {
                        Console.WriteLine("Você escolheu disputar por Resistência!");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Abrindo configurações...");
                    Console.WriteLine($"Olá, {nome}!\n" + "Nessa versão de fantasia medieval do jogo Super Trunfo, dois jogadores, sendo um o computador, recebem 16 cartas (31 cartas temáticas + 1 carta Super Trunfo), totalizando 32 cartas.");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Saindo do jogo...");
                    sair = true;
                }
                else
                {
                    Console.WriteLine("Você digitou um valor inválido!");
                }
            }
        }

    }
}
#endregion