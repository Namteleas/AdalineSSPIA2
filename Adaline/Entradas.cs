using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaline
{
    class Entradas
    {
        int clase;
        float x;
        float y;

        public Entradas(int c, float x, float y)
        {
            clase = c;
            this.x = x;
            this.y = y;
        }

        public int Clase
        {
            get
            {
                return clase;
            }
        }

        public float X
        {
            get
            {
                return x;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            string s = "Clase " + clase + ": Centro X,Y = " + x + ", " + y;
            return s;
        }

    }
}

