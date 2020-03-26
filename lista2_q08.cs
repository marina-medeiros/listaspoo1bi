using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int maior = a;
    if (a > maior) maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    if (d > maior) maior = d;

    int menor = a;
    if (a < menor) menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    if (d < maior) maior = d;

    int somatotal = a + b + c + d ;
    int somamm = maior + menor ;
    int somaseg = somatotal - somamm ;

    Console.WriteLine($"Maior valor = {maior}");
    Console.WriteLine($"Menor valor = {menor}");
    Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {somaseg} ");

  }
}  
