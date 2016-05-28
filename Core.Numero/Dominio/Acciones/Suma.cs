using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Suma
    {
        public Numero operar(Numero elPrimerNumero, Numero elSegundoNumero) {
            var validarBases = new Validaciones.ValidarBase();
            Numero elResultado = null;
            if (validarBases.lasDosBasesSonIguales(elPrimerNumero, elSegundoNumero))
            {
                double resultado = elPrimerNumero.elNumeroEnDecimal + elSegundoNumero.elNumeroEnDecimal;
                // TODO: Convertir el resultado en base 10 del punto anterior a la base de los numeros
                // por ejemplo, originalmente, podria estar sumando "2A" + "3F" en base hexadecimal
                elResultado = new Numero(resultado.ToString(), elPrimerNumero.laBase);
            }
            return elResultado;
        }
    }
}
