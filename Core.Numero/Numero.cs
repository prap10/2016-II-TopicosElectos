using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero
{
    public class Numero
    {
        public string elNumero { get; set; }
        public int laBase { get; set; }

        public bool esBaseDiez { get {
                return laBase == 10; }
             }

        public double elNumeroEnDecimal { get {
                return double.Parse(elNumero); } }

        public Numero(string elNumero, int laBase)
        {
            var validacionBase = new Dominio.Validaciones.ValidarBase();
            var validacionNumero = new Dominio.Validaciones.ValidarNumero();

            if (validacionBase.laBaseEstaEnElIntervaloCorrecto(laBase)
                & validacionNumero.elNumeroEsValidoEnLaBase(elNumero, laBase))
            {
                this.elNumero = elNumero;
                this.laBase = laBase;
            }
        }

    }
}
