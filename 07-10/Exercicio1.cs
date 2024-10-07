using System;

class Exercicio1
{

    static void Main (string[] args) {
       int numero = 10;
       int numero2 = 20;
       int numero3 = 62;
       int numero4 = 100;
       int soma1 = numero + numero2;
       int soma2 = numero + numero3;
       int soma3 = numero + numero4;
       Console.WriteLine($"A soma de {numero} + {numero2} é igual a {numero + numero2}");
       Console.WriteLine($"A soma de {numero} + {numero3} é igual a {soma2}");
       Console.WriteLine($"A soma de {numero} + {numero4} é igual a {soma3}");

    }  
}

