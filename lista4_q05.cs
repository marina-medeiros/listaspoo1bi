using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o dia da semana");
    string dia = Console.ReadLine();
    Console.WriteLine ("Informe a hora inicial do filme");
    int hora = int.Parse(Console.ReadLine());

    int preço = 10;

    if(dia == "Segunda" || dia == "Quarta"){
      preço = preço - 2;
    }
    if(dia == "Sexta" || dia == "Sábado"){
      preço = preço + 5;
    }
    if(hora <= 16){
      preço = preço - 2;
    }   

    Console.WriteLine($"R${preço},00");

  }
}
