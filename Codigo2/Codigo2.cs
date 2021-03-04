using System;

class Codigo2
{
  static void Main()
  {
      byte n1 = 10; 
      int idade = 25;
      char letra = '8';
      float valor = 5.3f;
      string nome = "Bruno";

      var aux = nome;

      Console.WriteLine ("Seu nome é {0}, com idade de {1} anos.", aux,idade);
      Console.ReadKey();
  }
}