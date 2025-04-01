
// using System;
// public static class CallMethodsFromDotNetClassLibrary
// {
//     public static void Executar()
//     {
//         Console.WriteLine("Executar CallMethodsFromDotNetClassLibrary");
//     }
// }

////////Exercício – Chamar os métodos de uma classe .NET//////

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);


//sem a criacao de metodo 
//int result =Random.Next();

// Random dice = new Random();
// int roll = dice.Next();

Random dice = new Random();

int roll1 = dice.Next(-100,100);
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");

Console.WriteLine($"Second roll: {roll2}");

Console.WriteLine($"Third roll: {roll3}");

dice.Next();


