using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o número do mês");
    int n = int.Parse(Console.ReadLine());

    switch (n)
    {
      case 1:
          string nome = "Janeiro";
          string tri = "primeiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 2:
          nome = "Fevereiro";
          tri = "primeiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 3:
          nome = "Março";
          tri = "primeiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;



      case 4:
          nome = "Abril";
          tri = "segundo";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 5:
          nome = "Maio";
          tri = "segundo";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 6:
          nome = "Junho";
          tri = "segundo";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;



      case 7:
          nome = "Julho";
          tri = "terceiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 8:
          nome = "Agosto";
          tri = "terceiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 9:
          nome = "Setembro";
          tri = "terceiro";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;



      case 10:
          nome = "Outubro";
          tri = "quarto";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 11:
          nome = "Novembro";
          tri = "quarto";
          Console.WriteLine($"O mês de {nome} é do {tri} trimestre do ano");
      break;

      case 12:
          nome = "Dezembro";
          tri = "quarto";
          Console.WriteLine($"O mês de {nome} é do {tri}  trimestre do ano");
      break;

    }


  }
}
