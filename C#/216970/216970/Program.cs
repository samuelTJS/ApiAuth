using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Teste
{
    class Pilha
    {
        public Pilha() 
        {
            info = 0;
            next = null;
        }
        public void Push(int n, ref Pilha TOPO)
        {
            this.info = n;
            this.next = TOPO;
            TOPO = this;
        }
        public void Pop(ref Pilha TOPO)
        {
            TOPO = this.next;
        }
        public void lista()
        {
            Pilha f = this;
            if (f == null)
            {
                Console.WriteLine("Não há elementos na pilha!");
            }
            else
            {
                while (f != null)
                {
                    Console.WriteLine(f.info);
                    f = f.next;
                }
            }
        }
        public int consulta(int n)
        {
            Pilha f = this;
            int c = 0;
            while (f != null)
            {
                c++;
                if (f.info == n)
                {
                    return c;
                }
                f = f.next;
            }
            Console.WriteLine("Elemento não encontrado!");
            return 0;
        }
        private int info;
        Pilha next;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pilha TOPO = null;
            int n, escolha, resultado;
            Pilha FF;
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Pilha");
                Console.WriteLine("(2) - Remove um elemento da Pilha");
                Console.WriteLine("(3) - Consulta um elemento da Pilha");
                Console.WriteLine("(4) - Imprime os elementos da Pilha");
                Console.WriteLine("(5) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: 
                        Console.Clear();
                        FF = new Pilha();
                        Console.Write("Digite um numero : ");
                        n = int.Parse(Console.ReadLine());
                        FF.Push(n, ref TOPO);
                        break;
                    case 2: 
                        Console.Clear();
                        if (TOPO != null)
                        {
                            TOPO.Pop(ref TOPO);
                            Console.WriteLine("Elemento Removido!");
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        Console.ReadKey();
                        break;
                    case 3: 
                        Console.Clear();
                        Console.Write("Digite o elemento que deseja encontrar: ");
                        int elem = int.Parse(Console.ReadLine());
                        int pos = TOPO.consulta(elem);
                        if (pos != 0)
                        {
                            Console.WriteLine($"O elemento {elem} está na posição {pos} da pilha.");
                        }
                        break;
                    case 4: 
                        Console.Clear();
                        if (TOPO != null)
                        {
                            Console.WriteLine("Elementos na pilha:");
                            TOPO.lista();
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        Console.ReadKey();
                        break;
                }
            } 
            while (escolha != 5);
        }
    }
}

