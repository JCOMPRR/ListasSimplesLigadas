using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            this.nodoInicial = new Nodo();
        }

        public bool ValidaVacio()
        {
            return (nodoInicial.EnlaceAnterior == null);
            return (nodoInicial.EnlaceSiguiente == null);
        }

        public void Vaciar()
        {
            nodoInicial.EnlaceSiguiente = null;
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
            }

            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.EnlaceSiguiente = nodoNuevo;
            nodoNuevo.EnlaceAnterior = nodoActual;
        }

        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda != null)
                {
                    nodoBusqueda = nodoBusqueda.EnlaceSiguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

}
