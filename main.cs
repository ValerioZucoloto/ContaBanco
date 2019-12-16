using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    Conta x;

    Console.Write ("Informe o número da conta : ");
    int numero = int.Parse (Console.ReadLine());
    Console.Write ("Informe o nome do titular : ");
    string nome = Console.ReadLine();
    Console.Write ("Haverá depósito inicial  (S/N) ?  ");
    char ch = char.Parse (Console.ReadLine());

    if (ch == 's') {
      Console.Write ("Digite o valor do depósito inicial: ");
      double valorInicial = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
      x = new Conta (numero, nome, valorInicial);
    }
    else {
       x = new Conta (numero, nome);
    }

    Console.WriteLine ();
    Console.WriteLine ("Conta criada : ");
    Console.WriteLine (x);

    Console.Write ("Digite um valor para depósito: ");
    double dep = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
    x.depositar (dep);
    Console.WriteLine ();
    Console.WriteLine ("Conta atualizada : ");
    Console.WriteLine (x);

    Console.WriteLine();

    Console.WriteLine ("Digite um valor para saque : ");
    double saq = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
    x.sacar (saq);

    Console.WriteLine ();
    Console.WriteLine ("Conta atualizada : ");
    Console.WriteLine (x);

    Console.ReadLine();
  }
}