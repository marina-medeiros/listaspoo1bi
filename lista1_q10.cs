using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Há quantos anos você fuma?");
  int anos = int.Parse(Console.ReadLine());
  Console.WriteLine("Quantos cigarros por dia?");
  int cigarrosdia = int.Parse(Console.ReadLine());
  Console.WriteLine("Qual o preço de uma carteira de cigarros?");
  double preco = double.Parse(Console.ReadLine());

  int cigarrostotais = anos * 365 * cigarrosdia ;
  double carteiras = cigarrostotais / 20 ;
  double total = carteiras * preco ;

  Console.WriteLine($"Total gasto = R$ {total:0.00}");
  }
}
