using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    public class Ponto
    {
        private float x;
        private float y;

        public Ponto()
        {

        }

        public Ponto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float getX()
        {
            return this.x;
        }

        public float getY()
        {
            return this.y;
        }
    }
}
