using System;
using System.Collections.Generic;
public class Card
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Hp { get; set; }
    public int Power { get; set; }
    public int Speed { get; set; }
    public int Strength { get; set; }
    public int Resistance { get; set; }
    public Card(string code, string name, int hp, int power, int speed, int strength, int resistance)
    {
        Code = code;
        Name = name;
        Hp = hp;
        Power = power;
        Speed = speed;
        Strength = strength;
        Resistance = resistance;

    }
    public void displayCard()
    {
        Console.WriteLine("-----Carta-----:");
        Console.WriteLine($"Código: {Code}");
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"HP: {Hp}");
        Console.WriteLine($"Poder: {Power}");
        Console.WriteLine($"Velocidade: {Speed}");
        Console.WriteLine($"Força: {Strength}");
        Console.WriteLine($"Resistência: {Resistance}");
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
        _cards.Add(new Card("B4", "Guerreiro", 100, 85, 40, 80, 90));
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
class Program
{
    static void Main(string[] args) { }
}