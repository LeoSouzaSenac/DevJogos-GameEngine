//Condicionais são estruturas que permitem que um bloco de código só seja executado SE obedecer uma determinada condição

using System;

class Condicionais
{

    static void Main (string[] args) {
        /*
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

        */

        string nacionalidade = "brasileiro";
        
        if (nacionalidade == "brasileiro"){
            Console.WriteLine("E aí cpx");
        } else if (nacionalidade == "americano"){
            Console.WriteLine("Você disse petróleo?");
        } else if (nacionalidade == "russo"){
            Console.WriteLine("Cade os ucranianos?");
        } else {
            Console.WriteLine("Nacionalidade não encontrada.");
        }
        

        switch (nacionalidade){

            case "brasileiro":
                Console.WriteLine("E aí cpx");
            break;

            case "americano":
                Console.WriteLine("Você disse petróleo?");
            break;

            case "russo":
                Console.WriteLine("Cade os ucranianos?");
            break;

            default:
                Console.WriteLine("Nacionalidade não encontrada.");
            break;
        }


        //Usando Switch, crie uma variável chamada meuTime
        // faça um switch com cada case representando um time, e imprima algo diferente para cada um
        //Não esqueça do default

    }  
}