using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o nome da primeira pessoa:");
    string nome1 = Console.ReadLine();
    Console.WriteLine ("Informe a data de nascimento da primeira pessoa:");
    string data1 = Console.ReadLine();
    Console.WriteLine ("Informe o nome da segunda pessoa:");
    string nome2 = Console.ReadLine();
    Console.WriteLine ("Informe a data de nascimento da segunda pessoa:");
    string data2 = Console.ReadLine();

    string velho = " ";
    string novo = " ";

    string[] da1 = data1.Split("/");
    d1 = int.Parse(da1[0]);
    m1 = int.Parse(da1[1]);
    a1 = int.Parse(da1[2]);

    string[] da2 = data2.Split("/");
    d2 = int.Parse(da2[0]);
    m2 = int.Parse(da2[1]);
    a2 = int.Parse(da2[2]);

      if (a1 < a2) {
        velho = nome1;
        } 
      if (a2 < a1) {
        velho = nome2;
        } 
      if (a1 == a2 && m1 < m2) {
        velho = nome1;
        } 
      if (a1 == a2 && m2 < m1) {
        velho = nome2;
        } 
      if (a1 == a2 && m1 == m2 && d1 < d2) {
        velho = nome1;
        } 
      if (a1 == a2 && m1 == m2 && d2 < d1) {
        velho = nome2;
        } 
      if (data1 == data2) Console.WriteLine($"{nome1} e {nome2} tem a mesma idade");

      if (velho == nome1) {
        novo = nome2;
        }
        else{
          novo = nome1;
        }
      }

      Console.WriteLine("cu") ;
  
  }
}
