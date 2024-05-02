using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string n)
        {
            this.nome = n;
            proximo = null;
        }


        public void setNext(Pessoa aux)
        {
            this.proximo = aux;
        }

        public Pessoa? getNext()
        {
            return this.proximo;
        }


        public override string? ToString()
        {
            return this.nome;
        }
    }
}