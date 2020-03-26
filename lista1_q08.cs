using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um valor monetário inteiro");
    int valor = int.Parse((Console.ReadLine()));
    int n100 = valor / 100 ;
    int r100 = valor % 100 ;
    int n50 = r100 / 50 ;
    int r50 = r100 % 50 ;
    int n20 = r50 / 20 ;
    int r20 = r50 % 20 ;
    int n10 = r20 / 10 ;
    int r10 = r20 % 10 ;
    int n5 = r10 / 5 ;
    int r5 = r10 % 5 ;
    int n2 = r5 / 2 ;
    int r2 = r5 % 2 ;
    Console.WriteLine ($"notas de 100:{n100}, notas de 50:{n50}, notas de 20:{n20}, notasde 10:{n10}, notas de 5:{n5}, notas de 2:{n2}, moedas de 1:{r2}");
  }
}
