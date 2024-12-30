using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Palindromo
{
    class clsCola
    {
        //  Declaramos dos nodos para la raiz y el fondo de la cola
        clsNodo raiz, fondo;

        public clsCola()
        {
            //  Los instanciamos con valor nulo
            raiz = null;
            fondo = null;
        }

        //  Creamos un metodo para saber si la cola esta vacia
        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        //  Creamos el metodo para insertar valores
        //  Recibimos la info de fuera de la clase
        public void Insertar(char info)
        {
            //  Declaramos e instanciamos un nuevo nodo para recibir la info
            clsNodo nuevo;
            nuevo = new clsNodo();
            //  Le asignamos los datos recibidos y un valor nulo al no tener donde apuntar
            nuevo.info = info;
            nuevo.sig = null;
            //  Si la cola esta vacia los datos seran iguales para la raiz y fondo
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            // Sino los datos seran delegados a la siguiente posicion 
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        //  Creamos un metodo para extraer los datos
        public char Extraer()
        {
            // Si la cola no esta vacia
            if (!Vacia())
            {
                //  Instanciamos el valor informacion del tipo int que recibe su valor de la raiz
                char informacion = raiz.info;
                //  Mientras la raiz y el fondo no vuelvan a coincidir se seguira avanzando entre los nodos
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }
                // Regresamos la informacion en formato string
                return informacion;
            }
            else
                //  Regresamos el valor maximo posible si la cola esta vacia
                return ' ';
        }
        public int numNodos()
        {
            //  Instanciamos un nodo leer con los valores de la raiz y un contador en 0
            clsNodo leer = raiz;
            int cont = 0;
            //  La funcion solo avanzara si el valor de leer no es nulo, e ira incremetando el contador conforme avance
            while (leer != null)
            {
                cont++;
                leer = leer.sig;
            }
            //  Nos regresa el numero del contador en formato string
            return cont;
        }
    }
}
