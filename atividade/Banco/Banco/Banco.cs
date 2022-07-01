using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco 
{
    public class Banco
    {
        public int numContas { get; private set; }
        public Conta conta;


        public void criarConta(Conta c)
        {
            numContas++;
        }

        public void realizarSaque(float valor)
        {
            conta.Sacar(valor);
        }

        public void realizarDeposito(float valor)
        {
            conta.Depositar(valor);
        }

        public Conta localizarConta(int num)
        {
            if(num == conta.getNumero())
            {
                return conta;
            }
            return null;
            
        }

        public void listarContas(List<Conta> contas)
        {
            conta.listarContas(contas);
        }

    }
}
