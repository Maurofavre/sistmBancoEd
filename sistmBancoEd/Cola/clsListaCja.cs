using System;
using System.Collections.Generic;

namespace sistmBancoEd.Cola
{
    internal class clsListaCja
    {
        public NodoLista Primero { get; set; }
        public NodoLista Ultimo { get; set; }

        public clsListaCja()
        {
            Primero = null;
            Ultimo = null;
        }

        // Verifica si la lista está vacía
        public bool controVacio()
        {
            return Primero == null && Ultimo == null;
        }

        // Inserta un nodo en la lista (FIFO)
        public void Insertar(NodoLista nuevo)
        {
            if (controVacio())
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        // Lista todos los nodos
        public List<NodoLista> Listar()
        {
            List<NodoLista> nodos = new List<NodoLista>();
            NodoLista auxiliar = Primero;

            while (auxiliar != null)
            {
                nodos.Add(auxiliar);
                auxiliar = auxiliar.Siguiente;
            }

            return nodos;
        }

        // Busca un nodo por su DNI
        public NodoLista Buscar(int dni)
        {
            NodoLista actual = Primero;

            while (actual != null)
            {
                if (actual.DNI == dni)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }

            return null;
        }

        // Elimina un nodo por su DNI
        public bool Eliminar(int dni)
        {
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return false;
            }

            if (Primero.DNI == dni)
            {
                Primero = Primero.Siguiente;

                if (Primero == null)
                {
                    Ultimo = null;
                }
                return true;
            }

            NodoLista actual = Primero;
            NodoLista anterior = null;

            while (actual != null && actual.DNI != dni)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                anterior.Siguiente = actual.Siguiente;

                if (actual == Ultimo)
                {
                    Ultimo = anterior;
                }
                return true;
            }

            Console.WriteLine("El nodo con el DNI especificado no se encontró.");
            return false;
        }

        // Busca y elimina el primer cliente en los primeros 3 nodos
        public NodoLista BuscarCliente()
        {
            NodoLista actual = Primero;
            int contador = 0;

            while (actual != null && contador < 3)
            {
                if (actual.Cliente)
                {
                    int dniCliente = actual.DNI;
                    Eliminar(dniCliente);
                    return actual;
                }
                actual = actual.Siguiente;
                contador++;
            }

            return Atender();
        }

        // Atiende (elimina) el primer nodo de la lista
        public NodoLista Atender()
        {
            if (controVacio())
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            NodoLista nodoAtendido = Primero;
            Primero = Primero.Siguiente;

            if (Primero == null)
            {
                Ultimo = null;
            }

            return nodoAtendido;
        }
    }
}
