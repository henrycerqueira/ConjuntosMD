using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntosMD
{
    class Conjunto<T>
    {
        List<T> lista;

        public Conjunto()
        {
            lista = new List<T>();
        }

        public void Adicionar(T item)
        {
            lista.Add(item);
        }

        public void Remover(T item)
        {
            lista.Remove(item);
        }

        public void Imprimir(Conjunto<T> conjunto)
        {
            Console.Write("\n\nIMPRESSÃO DO CONJUNTO\n");

            for (int i = 0; i < conjunto.lista.Count; i++)
            {
                Console.Write(conjunto.lista[i].ToString() + ", \n");
            }
        }

        public int Cardinalidade(Conjunto<T> conjunto)
        {
            int cardinalidade = conjunto.lista.Count;
            
            Console.WriteLine("\n\nCARDINALIDADE -- Tamanho do conjunto: "+cardinalidade);

            return cardinalidade;
        }

        public bool Pertinencia(T item)
        {
            bool pertence = false;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Equals(item))
                {
                    pertence = true;
                }
            }

            Console.WriteLine("\n\nPERTINENCIA -- Elemento " + item + " pertence ao conjunto? " + pertence.ToString());

            return pertence;
        }

        public bool Continencia(Conjunto<T> B)
        {
            int tamB = 0;
            for (int i = 0; i < B.lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (B.lista[i].Equals(lista[j]))
                    {
                        j++;
                        tamB++;
                        break;
                    }
                }
            }

            if (B.lista.Count.Equals(tamB))
            {
                Console.WriteLine("\n\nCONTINENCIA -- Conjuto B está contido em A");
                return true;
            }
            else
            {
                Console.WriteLine("\n\nCONTINENCIA -- Conjuto B não está contido em A");
                return false;
            }
        }

        public void Uniao(Conjunto<T> B)
        {
            Conjunto<T> ConjC = new Conjunto<T>();

            for (int i = 0; i < lista.Count; i++)
            {
                ConjC.Adicionar(lista[i]);
            }

            for (int i = 0; i < B.lista.Count; i++)
            {
                for (int j = 0; j < ConjC.lista.Count; j++)
                {
                    if (ConjC.lista.Contains(B.lista[i]) == true)
                    {
                        break;
                    }
                    else
                    {
                        ConjC.Adicionar(B.lista[i]);
                    }
                }
            }

            Console.Write("\n\nUNIAO - IMPRESSAO DO CONJUNTO C");

            ConjC.Imprimir(ConjC);
        }

        public void Igualdade(Conjunto<T> B)
        {
            Boolean iguais = false;

            if (lista.Equals(B))
            {
                iguais = true;
            }

            Console.WriteLine("\n\nIGUALDADE -- Os Conjuntos são iguais? " + iguais.ToString());
        }

        public void Interseção(Conjunto<T> B)
        {
            Conjunto<T> ConjC = new Conjunto<T>();

            for (int i = 0; i < B.lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[j].Equals(B.lista[i]))
                    {
                        ConjC.Adicionar(lista[j]);
                    }
                }
            }

            Console.WriteLine("\n\nINTERSECAO -- IMPRESSAO DO CONJUNTO C");
            ConjC.Imprimir(ConjC);
        }

        public void Produto(Conjunto<T> B)
        {
            Conjunto<string> ConjC = new Conjunto<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < B.lista.Count; j++)
                {
                    ConjC.Adicionar("<" + lista[i] + ", " + B.lista[j] + ">");
                }
            }

            Console.WriteLine("\n\nPRODUTO CARTESIANO -- IMPRESSAO DO CONJUNTO C");
            ConjC.Imprimir(ConjC);
        }
    }
}
