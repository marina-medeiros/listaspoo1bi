using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Por favor escreva um valor no formato rr,cc (ex 10,25)");

    string valor = Console.ReadLine();

    string[] s = valor.Split(',');
    int r = int.Parse(s[0]);
    int c = int.Parse(s[1]);
    
    Console.WriteLine("");
    Console.WriteLine ($"Isso são {r} reais e {c} centavos"); 
  }
}
