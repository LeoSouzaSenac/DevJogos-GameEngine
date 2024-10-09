//Condicionais são estruturas que permitem que um bloco de código só seja executado SE obedecer uma determinada condição

using System;

class Condicionais
{

    static void Main (string[] args) {
        bool temCarteira = true;
        bool maiorIdade = 29 >= 18;
        //SE eu tenho carteira

        if (temCarteira && maiorIdade){
            //Bloco de código que será executado se a condição for verdadeira
            Console.WriteLine("Você pode dirigir.");
        } else if (!temCarteira && maiorIdade){
            Console.WriteLine("Você é maior de idade, mas não tem carteira. Portanto, não pode dirigir.");
        } else {
            Console.WriteLine("Você não pode dirigir.");
        }       
    }  
}