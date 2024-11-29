using Avaliativo28_11.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaliativo28_11.Controller;

namespace Avaliativo28_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear(); 
                Console.WriteLine(" === Menu de Comandos ===");
                Console.WriteLine(" 1 - Adicionar Produto");
                Console.WriteLine(" 2 - Listar Produtos");
                Console.WriteLine(" 3 - Alterar Produto");
                Console.WriteLine(" 4 - Deletar Produto");
                Console.WriteLine(" 5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out int escolha)) 
                {
                    switch (escolha)
                    {
                        case 1:
                            VendasView.Create();
                            break;

                        case 2:
                            VendasView.Read();
                            break;

                        case 3:
                            VendasView.Update();
                            break;

                        case 4:
                            VendasView.Delete();
                            break;

                        case 5:
                            Console.WriteLine("Saindo do programa...");
                            return;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        }

        

        

        

        
    }
}
