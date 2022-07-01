using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private int numero;
        private string titular;
        public float saldo;

        public Conta(string titular, int numero)
        {
            this.numero = numero;
            this.titular = titular;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public string getTitular()
        {
            return this.titular;
        }

        public void Sacar(float valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (saldo < valor)
            {
                throw new SaldoInsuficienteException(saldo, valor);
            }

            saldo -= valor;
        }

        public void Depositar(float valor)
        {
            saldo += valor;
        }

        public override string ToString()
        {
            return $"Número: {numero}, Titular: {titular}, Saldo: {saldo}";
        }

        public void listarContas(List<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Titular: {c.getTitular()}, Conta: { c.getNumero()}");
            }
        }
    }
}
