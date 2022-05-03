using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        Nodo nodoFinal; //Por que no esta en uso?

        public Lista()
        {
            nodoInicial = new Nodo();
            this.nodoActual = new Nodo();
            this.nodoFinal = new Nodo();
            nodoInicial.Enlace = nodoInicial;
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Enlace == nodoInicial);
        }
        public void Vaciar()
        {
            nodoInicial.Enlace = nodoInicial;
        }
        public string RecorrerLista()
        {
            string datoslista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial)
            {
                nodoActual = nodoActual.Enlace;
                datoslista += $"{nodoActual.Valor}\n";
            }
            return datoslista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial) //Estoy comparando "=="
            {
                nodoActual = nodoActual.Enlace;
            }
            //Como funciona esto? 
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.Enlace = nodoNuevo;
            nodoNuevo.Enlace = nodoInicial;
            nodoFinal = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)


        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != nodoInicial && nodoBusqueda.Enlace.Valor != dato)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    if (nodoBusqueda.Enlace.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != nodoInicial)
                {
                    Nodo nodoAnterior = BuscarAnterior(dato);
                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;

                }
            }
        }




    }
}

