using System;
using System.Globalization;

class Conta {
  public int numeroDaConta {get; private set;}
  public string titular {get; set;}
  public double saldo {get; private set;}

  public Conta (int numeroDaConta, string titular, double saldo){
  this.numeroDaConta = numeroDaConta;
  this.titular = titular;
  this.saldo = saldo;
  }

  public Conta (int numeroDaConta, string titular){
  this.numeroDaConta = numeroDaConta;
  this.titular = titular;
  this.saldo = 0.0;
  }

  public void depositar  (double quantia) {
    saldo = saldo + quantia;
  }

  public void sacar (double quantia) {
    saldo = saldo - quantia - 5.0;
  }


  public override string  ToString () {
    return "Conta: " + numeroDaConta + " , Titular: " + titular + " , Saldo R$ : " + saldo.ToString ("F2", CultureInfo.InvariantCulture);
  }


}