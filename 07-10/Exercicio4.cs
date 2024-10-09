//Condicionais são estruturas que permitem que um bloco de código só seja executado SE obedecer uma determinada condição

using System;

class Exercicio4
{

    static void Main (string[] args) {
        /*
            EXERCICIO 1
            Crie uma variável que diga se uma lâmpada está ligada ou não
            Exemplo: 
            bool lampadaLigada = true;
            ou
            string lampadaLigada = "Ligada"

            SE a lâmpada estiver ligada, imprimir "A lâmpada está ligada"
            SE NÃO, imprimir "A lâmpada está desligada."
            */

            string lampadaLigada = "Ligada";

            //SE a lâmpada estiver ligada
            if (lampadaLigada == "Ligada") {
                Console.WriteLine("A lâmpada está acesa.");
            }
            //SE Não
            else {
                Console.WriteLine("A lâmpada está apagada.");
            }


            
            /*
            EXERCICIO 2
            Um dia pode ser dividido entre: manhã, tarde, noite, madrugada.
            Manhã é antes das 12 e igual ou maior que 6 horas.

            Tarde é das 12 em diante, até um pouco antes das 18.
            Noite é a partir das 18, até um pouco antes da meia noite (0 hora)
            Madrugada é a partir da 0 hora, até um pouco antes das 6.

            Crie uma variável chamada 'hora' e atribua um número inteiro a ela, de 0 a 23 (ex: 5). Através de um if, else if, else, imprima se é de manhã, se é de tarde, se é de noite, ou se é de madrugada.

        */

        int hora = 6;

        if (hora >= 6 && hora < 12) {
            Console.WriteLine("É de manhã.");
        } else if (hora >= 12 && hora < 18){
            Console.WriteLine("É de tarde.");
        } else if (hora >= 18 && hora <= 23){
            Console.WriteLine("É de noite.");
        } else {
            Console.WriteLine("É de madrugada.");
        }



    }  
}