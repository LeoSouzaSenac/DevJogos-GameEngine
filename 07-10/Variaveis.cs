using System;

class Variaveis
{

    static void Main (string[] args) {
        //Aqui, criei uma variável de número INTEIRO, com o valor 15
         int numero = 15;
        Console.WriteLine(numero);
        Console.WriteLine(numero + 30);
        Console.WriteLine(numero + 10);
        Console.WriteLine(numero + 90);

        //Comentário de uma linha só
        /*
        Comentário de mais de uma linha
        */

        int idade = 29;              // Número inteiro
        double altura = 1.70;        // Número com ponto flutuante
        char inicial = 'L';          // Um único caractere
        string nome = "Leonardo de Souza";      // Texto
        bool aprovado = true;        // Verdadeiro ou falso

        Console.WriteLine($"Meu nome é {nome}. Tenho {idade} anos. Minha altura é {altura}. Meu nome começa com a letra {inicial}. Estou aprovado na escola? {aprovado}.");
       
       
        
    }  
}



/*
    static void Main(string[] args)
    {
        int idade = 25;              // Número inteiro
        double altura = 1.75;        // Número com ponto flutuante
        char inicial = 'A';          // Um único caractere
        string nome = "Carlos";      // Texto
        bool aprovado = true;        // Verdadeiro ou falso

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Inicial: {inicial}, Aprovado: {aprovado}");
    }
    */