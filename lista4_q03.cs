using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o salário atual");
    double sal = double.Parse(Console.ReadLine());

    double aumento = 0;

    if (sal < 500) aumento = sal * 0.2;
    if (sal > 500 && sal < 1000) aumento = sal * 0.15;
    if (sal > 1000) aumento = sal * 01;

    double salariototal = sal + aumento;

    Console.WriteLine($"Seu novo salário é {salariototal:0.00}");

  }
}
