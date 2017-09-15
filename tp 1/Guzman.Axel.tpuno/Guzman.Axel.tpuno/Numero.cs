using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.Axel.tpuno
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(string num)
        {
            Double.TryParse(num, out this.numero);
        }
        public Numero(double num)
        {
            this.numero = num;
        }

        private double validarNumero(string numString)
        {
            if (Double.TryParse(numString, out this.numero))
                return 1;

            return 0;
        }

        private void setNumero(string num)
        {
            validarNumero(num);
        }

        public double getNumero()
        {
            return this.numero;
        }


    }
}
