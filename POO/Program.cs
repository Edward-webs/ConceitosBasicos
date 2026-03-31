using POO.dominio;
using System.ComponentModel.Design;
/*
int numero1, numero2;
Console.WriteLine("Informe um número inteiro: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

int resultado;
SomaDoisNumeros somador = new SomaDoisNumeros();

resultado = somador.Somar(numero1, numero2);
Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é {resultado}");

*/

Console.WriteLine("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

VerificadorDeNumero verificador = new VerificadorDeNumero();

if (verificador.EhPar(numero))
    Console.WriteLine("O número {0} é Par!", numero);
else
    Console.WriteLine("O número " + numero + " é ímpar!");
