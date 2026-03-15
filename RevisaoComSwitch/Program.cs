/*
 * Copie o código do projeto Revisao e modifique a estrutura if por switch.
 * Modifique o "do... while" por "while"
 * Acrescente ações para cada valor do dado entre 1 e 10
 * Use sua imaginação e criatividade 
 */
using System.Text;

int acao;
do
{
    Console.WriteLine("Nesse instante, surge das nebulosas profundezas do fim do mundo um ser horrendo, " +
    "com 10 cabeças e soprando labaredas de fogo sem fim...");
    Console.WriteLine("Jogue o D10 para ação do herói (digite 0 para sair): ");
    acao = Convert.ToInt32(Console.ReadLine());
    switch (acao)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("\nO herói foi morto sem nem perceber a vinda do ataque.");
            break;
        case 2:
            Console.WriteLine("\nO herói teve sua perna agarra pela causa da besta. " +
                "Logo em seguida foi suspenso no ar, onde foi queimado vivo pelas rajadas de fogo saídas das 10 cabeças incandecentes.");
            break;
        case 3:
            Console.WriteLine("\nO herói foi mortalmente ferido...");
            break;
        case 4:
            Console.WriteLine("\nO herói percebeu a besta e tentou correr, mas foi queimado por uma das rajadas das cabeças incandecentes.");
            break;
        case 5:
            Console.WriteLine("\n herói se feriu bastante, mas conseguiu se esconder a tempo...");
            break;
        case 6:
            Console.WriteLine("\nO herói correu da besta, mas durante a fuga sofreu diversas queimaduras.");
            break;
        case 7:
            Console.WriteLine("\nO herói correu da besta, mas durante a fuga sofreu uma leve queimadura.");
            break;
        case 8:
            Console.WriteLine("\nCom dificuldade, o herói conseguiu desviar de todos os ataques da besta.");
            break;
        case 9:
            Console.WriteLine("\nO herói conseguiu desviar de todos os ataques da besta.");
            break;
        case 10:
            Console.WriteLine("\nCom facilidade, o herói conseguiu desviar de todos os ataques da besta e fugiu ileso.");
            break;
        default:
            Console.WriteLine();
            break;
    }
    Console.WriteLine("\nPressione uma telca para continuar\n");
} while (acao != 0);
