using System;
using System.Collections.Generic;
using System.Text;

namespace Dados2
{
    internal class ClaseDado
    {
        public int GeneraAleatorio(int NumeroDados)
        {
            Random Aleatorio = new Random();
            int ValorRetorno = Aleatorio.Next(1,(NumeroDados*6)+1);
            return ValorRetorno;
        }

    }
}
