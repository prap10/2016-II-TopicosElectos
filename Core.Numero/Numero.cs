using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Serialization.DataMemberAttribute;

namespace Core.Numero
{
//    [DataContract]
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

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

    }

}
