using Metodosvirtuales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace metvirtbonilla
{
    public class Cono : CuerpoRevolucion


    {
        private double altura, generatriz;

        public Cono(double radio, double altura, double generatriz) : base(radio)
        {
            this.altura = altura;
            this.generatriz = generatriz;

        }

            public override double Volumen()
            {
            return (1.0 / 3)*base.Volumen()*altura;

            }
           
    }
}
