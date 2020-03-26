using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe sua massa em kg:");
    double massa = double.Parse(Console.ReadLine());
    Console.WriteLine ("Informe sua altura em metros:");
    double altura = double.Parse(Console.ReadLine());
    double IMC = massa / (altura * altura);
    Console.WriteLine ($"Seu IMC é {IMC:0.00}");
  }
}
