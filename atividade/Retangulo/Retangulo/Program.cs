using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Retangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pon1 = new Ponto(50, 30);
            var pon2 = new Ponto(2, 4);
            var pon3 = new Ponto(8, 6);
            var ret1 = new Retangulo(6, 12, pon2);
            var ret2 = new Retangulo(10, 4, pon3);
            var ret3 = new Retangulo(4, 8);
            var ret4 = new Retangulo(pon1);
            var ret5 = new Retangulo();
            var ret6 = new Retangulo(9, 7, pon1);

            Console.WriteLine($"Área do ret1: {ret1.calcularArea()}m²");
            Console.WriteLine($"Área do ret2: {ret2.calcularArea()}m²");
            Console.WriteLine($"Área do ret3: {ret3.calcularArea()}m²");
            Console.WriteLine();
            Console.WriteLine($"Há intersecção entre ret1 e ret2: {ret1.temInterseccao(ret1, ret2)}");
            Console.WriteLine($"Há interseccção entre ret1 e ret6: {ret1.temInterseccao(ret1, ret6)}");

            Console.ReadLine();

            
        }
    }
}
