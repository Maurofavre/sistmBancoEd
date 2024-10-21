using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistmBancoEd.Cola
{
    internal class clsCola
    {
        public Nodo Primero { get; set; }
        public Nodo Ultimo { get; set; }


        public clsCola()
        {
            Primero = null;
            Ultimo = null;
        }

        public bool Agregar(Nodo nuevoNodo)
        {
            if (nuevoNodo != null)
            {
                // Verificamos si el DNI ya está en la cola
                if (ExisteDNI(nuevoNodo.DNI))
                {
                    return false; // El DNI ya está en la cola, no se agrega
                }

                if (EstaVacia())
                {
                    Primero = nuevoNodo;
                    Ultimo = nuevoNodo;
                }
                else
                {
                    Ultimo.Siguiente = nuevoNodo;
                    Ultimo = nuevoNodo;
                }

                return true; // El nodo se ha agregado correctamente
            }

            return false; // El nodo no se debería agregar si es nulo
        }



        public bool ExisteDNI(int dni)
        {
            Nodo actual = Primero;

            // Recorre la cola y verifica si el DNI existe
            while (actual != null)
            {
                if (actual.DNI == dni)
                {
                    return true; // El DNI ya existe en la cola
                }
                actual = actual.Siguiente; // Avanza al siguiente nodo
            }

            return false; // El DNI no está en la cola
        }




        public bool EstaVacia()
        {
            return Primero == null;
        }



        public List<Nodo> ListarElementos()
        {
            List<Nodo> nodos = new List<Nodo>();
            Nodo actual = Primero;

            while (actual != null)
            {
                nodos.Add(actual);
                actual = actual.Siguiente;
            }



            return nodos;
        }


        public Nodo Eliminar()
        {
            if (EstaVacia())
            {
                return null; // O lanza una excepción si prefieres
            }

            // Guarda el nodo que se va a eliminar
            Nodo nodoEliminado = Primero;

            // Mueve el puntero Primero al siguiente nodo
            Primero = Primero.Siguiente;

            // Si la cola queda vacía, también actualiza Ultimo
            if (Primero == null)
            {
                Ultimo = null;
            }

            // Devuelve el nodo eliminado
            return nodoEliminado;
        }
    }
}
