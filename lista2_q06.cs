using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite três valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int maior = a;
    if (a > maior) maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;

    int menor = a;
    if (a < menor) menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;

    int soma = maior + menor ;

    Console.WriteLine($"A soma do maior com o menor número é {soma}");

  }
}  
