// See https://aka.ms/new-console-template for more information
int acao;
do
{
    Console.WriteLine("Nesse instante, surge das nebulosas profundezas do fim do mundo um ser horrendo, " +
    "com 10 cabeças e soprando labaredas de fogo sem fim...");
    Console.WriteLine("Jogue o D10 para ação do herói (digite 0 para sair): ");
    try
    {
        acao = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Por favor, informe um número entre 0 e 10");
        continue;
    }
    acao = Convert.ToInt32(Console.ReadLine());
    if (acao == 0)
    {
        break;
    }
    else if (acao <= 3)
    {
        Console.WriteLine("O herói foi mortalmente ferido...");
    }
    else if (acao <= 6)
    {
        Console.WriteLine("O herói se feriu bastante, mas conseguiu se esconder a tempo...");
    }
    else
    {
        Console.WriteLine("Nosso herói se escondeu sem nenhum arranhão...");
    }
    Console.WriteLine("Pressione uma telca para continuar");
} while (acao != 0);
