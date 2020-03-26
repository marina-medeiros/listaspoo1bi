using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Digite seu nome");
   string nome = Console.ReadLine();
   string[] n = nome.Split(' ');
   string n1 = (n[0]);
   string n2 = (n[1]);
   Console.WriteLine("Resultado");
   Console.WriteLine($"{n2}, {n1}");
  }
}
