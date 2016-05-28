﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Especificaciones
{
    public class RealizarCalculo
    {
        public Numero OperadorBinario(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero) {
            Numero elResultado;
            switch (elOperador)
            {
                case '+':
                    var accionSuma = new Acciones.Suma();
                    elResultado = accionSuma.operar(elPrimerNumero, elSegundoNumero);
                    break;
            }

            return elResultado;
        }
    }
}
