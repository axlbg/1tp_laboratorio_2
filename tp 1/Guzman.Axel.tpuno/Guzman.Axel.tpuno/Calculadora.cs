using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guzman.Axel.tpuno
{
    class Calculadora
    {

        public double Operar(Numero numeroUno, Numero numeroDos, string operador)
        {
            operador = ValidarOperador(operador);

            if (operador == "+")
            {
                return numeroUno.getNumero() + numeroDos.getNumero();
            }
            if (operador == "-")
            {
                return numeroUno.getNumero() - numeroDos.getNumero();
            }
            if (operador == "*")
            {
                return numeroUno.getNumero() * numeroDos.getNumero();
            }
            if (operador == "/")
            {
                if (numeroDos.getNumero() == 0)
                    return 0;

                return numeroUno.getNumero() / numeroDos.getNumero();
            }
            return 0;
        }

        public string ValidarOperador(string operador)
        {
            if (operador!="-" && operador!="*" && operador!="/")
                return "+";
            return operador;
        }
    }
}
