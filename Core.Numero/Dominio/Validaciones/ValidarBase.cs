using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool laBaseEstaEnElIntervaloCorrecto (int laBase) {
            return laBase >= 2 & laBase <= 16;
        }

        public bool lasDosBasesSonIguales(Numero primerNumero, Numero segundoNumero) {
            return primerNumero.laBase == segundoNumero.laBase;
        }

    }
}
