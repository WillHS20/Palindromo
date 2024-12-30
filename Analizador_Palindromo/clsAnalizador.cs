using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Palindromo
{
    class clsAnalizador
    {
        clsCola ColaI;
        clsPila PilaR;
        char[] convertidor; 

        public clsAnalizador()
        {
            ColaI = new clsCola();
            PilaR = new clsPila();
        }

        public void separadorCh(string oracion)
        {
            convertidor = oracion.ToCharArray();

            for (int i = 0; i < convertidor.Length; i++)
            {
                if (convertidor[i] != ' ')
                {
                    ColaI.Insertar(convertidor[i]);
                    PilaR.Insertar(convertidor[i]);
                }                
            }
        }

        public string comparadorCh()
        {
            char x;
            char y;
            int cont = 0;
            string mensaje;
            int num = ColaI.numNodos();
            for (int i = 0; i < num; i++)
            {
                x = ColaI.Extraer();
                y = PilaR.Extraer();

                if (x == y)
                {
                    cont++;
                }
            }

            if (cont == num)
            {
                mensaje = "Es un palindromo";
            }
            else
            {
                mensaje = "No es un palindromo";
            }
            return mensaje;
        }
    }
}
