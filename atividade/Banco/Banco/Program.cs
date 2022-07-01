using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Banco
{
    public class Program
    {

        static List<Conta> contas;
        static void Main(string[] args)
        {

            contas = new List<Conta>();

            contas.Add(new Conta("Larissa", 1));
            contas.Add(new Conta("Leticia", 2));
            contas.Add(new Conta("Luiz", 3));
            contas.Add(new Conta("Felipe", 4));
            contas.Add(new Conta("João", 5));

        }
    }
}
