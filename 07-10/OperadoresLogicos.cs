using System;

class OperadoresLogicos
{   
     static void Main (string[] args) {
        
        bool temCarteira = false;
        int idade = 29;
        bool maiorIdade = idade >= 18;

        Console.WriteLine($"Para poder dirigir, uma pessoa precisa ter carteira e ter 18 anos ou mais.");
        Console.WriteLine($"Você tem carteira: {temCarteira}.");
        Console.WriteLine($"Você é de maior: {maiorIdade}.");

        //OPERADOR LÓGICO E(AND): retorna true apenas se todos forem true
        //Apenas um único false já é suciciente para que a equação retorne false
        Console.WriteLine(temCarteira == true && maiorIdade == true);

        Console.WriteLine(true && true && true && true && false); // true
        /*
        true && false // false
        false && true // false
        false && false // false
        */


        //OPERADOR LÓGICO OU (OR): retorna false apenas se todos forem false. Apenas um único true já é suficiente para que a equação retorne true.

        bool temTrabalho = false;
        bool economiza = false;
        bool investe = false;

        bool nasceuHerdeiro = false;

        Console.WriteLine((temTrabalho && economiza && investe) || nasceuHerdeiro);

        /*
            true || true // true
            true || false // true
            false || true // true
            false || false // false
        */

        //OPERADOR LÓGICO NÃO/NEGAÇÃO (NOT): Inverte o estado. Se algo retorna true, ele transforma em false e vice-versa

        !true //false
        !false //true

        bool ligado = true;
        Console.WriteLine(!ligado); //false

    }  
}
