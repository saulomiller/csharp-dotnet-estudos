
// using System;
// public static class CallMethodsFromDotNetClassLibrary
// {
//     public static void Executar()
//     {
//         Console.WriteLine("Executar CallMethodsFromDotNetClassLibrary");
//     }
// }

// //////Exercício – Chamar os métodos de uma classe .NET//////

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);


// sem a criacao de metodo 
// int result =Random.Next();

// Random dice = new Random();
// int roll = dice.Next();

// Random dice = new Random();

// int roll1 = dice.Next(-100,100);
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");

// Console.WriteLine($"Second roll: {roll2}");

// Console.WriteLine($"Third roll: {roll3}");

// dice.Next();



// int firstValue = 700;
// int secondValue = 600;

// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);


// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada Negada!");
// }


// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();


// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }



// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal"); 
// }else
// {
//     Console.WriteLine("Consoante");
// }



Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Consoante");
        break;


}

