using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public float Saldo { get; set; }
        public float ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(float saldo, float valorSaque)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
