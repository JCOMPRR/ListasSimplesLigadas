using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string Valor { get; set; }

        public Nodo EnlaceAnterior { get; set; }

        public Nodo EnlaceSiguiente { get; set; }

        public Nodo(string valor = "", Nodo nodoAnt = null, Nodo nodoSig = null)
        {
            Valor = valor;
            EnlaceAnterior = nodoAnt;
            EnlaceSiguiente = nodoSig;
        }
    }
}
