using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Retangulo
{
    public class Retangulo
    {
        public Ponto o;
        private float altura;
        private float largura;

        public Retangulo()
        {

        }

        public Retangulo(float a, float l)
        {
            altura = a;
            largura = l;
        }

        public Retangulo(Ponto o)
        {
            this.o = o;
        }

        public Retangulo(float a, float l, Ponto o)
        {
            altura = a;
            largura = a;
            this.o = o;
        }

        public float getAltura()
        {
            return altura;
        }

        public float getLargura()
        {
            return largura;
        }

        public float calcularArea()
        {
            return altura * largura;
        }

        public bool temInterseccao (Retangulo a, Retangulo b)
        {

            float x1 = a.o.getX();
            float y1 = a.o.getY();
            float x2 = x1 + a.largura;
            float y2 = y1+a.altura;

            float x3 = b.o.getX();
            float y3 = b.o.getY();
            float x4 = x3 + a.largura;
            float y4 = y3 + a.altura;

            float x5 = Math.Max(x1, x3);
            float y5 = Math.Max(y1, y3);

            float x6 = Math.Min(x2, x4);
            float y6 = Math.Min(y2, y4);

            if (x5 > x6 || y5 > y6)
            {
                return false;
            }
            return true;
        }

        
    }
}
