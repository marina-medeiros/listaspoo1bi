using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int ai = 0;
    int ap = 0;
    int bi = 0;
    int bp = 0;
    int ci = 0;
    int cp = 0;
    int di = 0;
    int dp = 0;

    if(a%2 > 0){
    ai = a;
    }
    else{
      ap = a;
    }
    
    if(b%2 > 0){
    bi = b;
    }
    else{
      bp = b;
    }

    if(c%2 > 0){
    ci = c;
    }
    else{
      cp = c;
    }

    if(d%2 > 0){
    di = d;
    }
    else{
      dp = d;
    }

    int impares = ai + bi + ci + di ;
    int pares = ap + bp + cp + dp ;

    Console.WriteLine($"Soma dos impares = {impares} e soma dos pares = {pares}");

  }
}
