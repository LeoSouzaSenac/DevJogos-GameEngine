using System;

class OperadoresAritmeticos
{
    static void Main (string[] args) {
        int numero1 = 100;
        double numero2 = 50.9;

        //Aqui eu criei/declarei minha variável
        double soma;
        //Aqui, eu troquei o valor dela
        soma = numero1 + numero2;
        Console.WriteLine(soma);

        double subtracao;
        subtracao = numero1 - numero2;
        Console.WriteLine(subtracao);

        double multiplicacao;
        multiplicacao = numero1 * numero2;
        Console.WriteLine(multiplicacao);

        double divisao;
        divisao = numero1 / numero2;
        Console.WriteLine(divisao);

        double resto;
        resto = numero1 % numero2;
        Console.WriteLine(resto);

    }  
}



