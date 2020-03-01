using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite os coeficientes a, b, e c de uma equação do II grau");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    double delta = (b * b) - 4 * a * c;
    double deltar = Math.Sqrt(delta);
    double x1 = (- b + deltar) / (a * 2);
    double x2 = (- b - deltar) / (a * 2);
    
    if(delta < 0){
      Console.WriteLine("Impossível calcular");
    }
    if(delta >= 0){
      Console.WriteLine($"{x1:00} {x2:00}");
    }
    
  }
}
