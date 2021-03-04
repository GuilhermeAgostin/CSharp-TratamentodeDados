using System;

class Codigo6
{
    enum DiasDaSemana{Domingo,Segunda,Terca,Quarta,Quinta,Sexta,Sabado}
  static void Main()
  {
    int ds = (int)DiasDaSemana.Sexta;
    Console.Write(ds);
    Console.ReadKey();
  }
}