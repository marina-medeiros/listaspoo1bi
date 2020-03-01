using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o primeiro horário no formato hh:mm");
    string horario1 = Console.ReadLine();
    Console.WriteLine ("Digite o segundo horário no formato hh:mm");
    string horario2 = Console.ReadLine(); 


    string[] a = horario1.Split(':');
      int h1 = int.Parse(a[0]);
      int m1 = int.Parse(a[1]);

    string[] b = horario2.Split(':');
      int h2 = int.Parse(b[0]);
      int m2 = int.Parse(b[1]);

    int horas = h1 + h2 ;
    int minutos = m1 + m2 ;

    if(minutos>59)
    {
      minutos = minutos - 60 ;
      horas = horas + 1 ;
    } ;
    
    Console.WriteLine($"{horas}:{minutos}");
  }
}
