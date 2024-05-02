using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.setNext(aux);
                tail = aux;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                if (tail == head) 
                {
                    head = tail = null;
                }

                else
                {
                    this.head = head.getNext();
                }
            }
        }


        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public void RunOver()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia");
                Console.WriteLine("Pressione qualqeur tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Pessoa aux = head;
                do
                {
                    Console.WriteLine("Nome" + aux.ToString());
                    aux = aux.getNext();

                } while (aux != null);

                Console.WriteLine("\nFim da impreesão");
                Console.WriteLine("\nPressione qualqeur tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}