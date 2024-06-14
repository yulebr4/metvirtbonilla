using System;

namespace Metodosvirtuales
{


    public class CuerpoRevolucion
    {
        public const double PI = Math.PI;
        protected double radio;

        public CuerpoRevolucion(double radio)
        {
            this.radio = radio;

        }


        public virtual double Volumen()
        {
            return PI*radio*radio;
        }
    }
}

        