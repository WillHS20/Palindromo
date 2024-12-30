using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Palindromo
{
    class clsPila
    {
        clsNodo raiz;

        public clsPila()
        {
            raiz = null;
        }

        public void Insertar(char x)
        {
            clsNodo nuevo;
            nuevo = new clsNodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public char Extraer()
        {
            if (raiz != null)
            {
                char informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return ' ';
            }
        }
    }
}
