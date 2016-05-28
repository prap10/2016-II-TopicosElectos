using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        public bool elNumeroEsValidoEnLaBase(string elNumero, int laBase) {
            bool elResultado = true;
            for (int i=0; (elResultado & i < elNumero.Length); i++) {
                elResultado = elDigitoEsValidoEnLaBase(elNumero[i], laBase);
            }
            return elResultado;
        }

        private bool elDigitoEsValidoEnLaBase(char elDigito, int laBase) {
            //TODOL: Verificado!
            return true;
        }
    }
}
