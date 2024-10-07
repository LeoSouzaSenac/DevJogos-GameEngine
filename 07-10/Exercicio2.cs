



//Crie 10 variáveis.
//Para 5 delas, coloque números pares.
//Para as outras 5, coloque números ímpares.
//Faça o resto da divisão de cada uma por 2.
// Imprima a frase, completando o que falta (substitua o ??? pelo que falta):
//"Para descobrir se um número é par, o resto da divisão dele por 2 tem que ser igual a ???. E, para descobrir se um número é ímpar, o resto da divisão dele por 2 tem que ser igual a ???"


using System;

class Exercicio2
{

    static void Main (string[] args) {
        // Criem 3 variáveis nota1, nota2, nota3
// Faça a média destas notas

//DICA: média é a soma de todas as notas dividido pelo número de notas (neste caso é 3) 

        double nota1 = 10;
        double nota2 = 9.7;
        double nota3 = 7.8;
        double soma = nota1 + nota2 + nota3
        double media = soma / 3;
        Console.WriteLine(media);

        int par1 = 2;
        int par2 = 44;
        int par3 = 32;
        int par4 = 100;
        int par5 = 286;

        int impar1 = 599;
        int impar2 = 53;
        int impar3 = 667;
        int impar4 = 333;
        int impar5 = 11;


        Console.WriteLine(par1%2);
        Console.WriteLine(par2%2);
        Console.WriteLine(par3%2);
        Console.WriteLine(par4%2);
        Console.WriteLine(par5%2);

        Console.WriteLine(impar1%2);
        Console.WriteLine(impar2%2);
        Console.WriteLine(impar3%2);
        Console.WriteLine(impar4%2);
        Console.WriteLine(impar5%2);


        Console.WriteLine("Para descobrir se um número é par, o resto da divisão dele por 2 tem que ser igual a 0. E, para descobrir se um número é ímpar, o resto da divisão dele por 2 tem que ser igual a 1.");
    }  
}



