using System;

class Comparadores
{

    static void Main (string[] args) {
        int numero1 = 10;
        int numero2 = 3;

        //Verifica se um é igual ao outro
        Console.WriteLine(numero1 == numero2); //FALSE

        //Verifica se um é diferente do outro
        Console.WriteLine(numero1 != numero2); //TRUE

        //Verifica se um é maior que o outro
        Console.WriteLine(numero1 > numero2); //TRUE

        //Verifica se um é maior OU igual ao outro
        Console.WriteLine(numero1 >= numero2); //TRUE

        //Verifica se um é menor que o outro
        Console.WriteLine(numero1 < numero2); //FALSE

        //Verifica se um é menor OU igual ao outro
        Console.WriteLine(numero1 <= numero2); //FALSE
    }  
}
