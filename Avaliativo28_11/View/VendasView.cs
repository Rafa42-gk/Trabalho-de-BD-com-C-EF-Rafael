using Avaliativo28_11.Controller;
using Avaliativo28_11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliativo28_11.View
{
    public class VendasView
    {
        public static void Create()
        {
            string vNome, vDetalhes; 
            DateTime vData; 
            decimal vPreço;

            Console.WriteLine("Digite o nome do produto: ");
            vNome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto: ");
            vDetalhes = Console.ReadLine();
            Console.WriteLine("Digite a data da venda: ");
            vData = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço: ");
            vPreço = decimal.Parse(Console.ReadLine());


            using (var contexto = new Context())
            {
                contexto.Vendas.Add(new Vendas
                {
                    Produto = vNome,
                    Descricao = vDetalhes,
                    DataVenda = vData,
                    Valor = vPreço,
                });

                contexto.SaveChanges();
                Console.WriteLine("Registro realizado com sucesso!");
            }

          
            Console.ReadKey();
        }

        public static void Update()
        {
            Console.WriteLine("Digite o nome do arquivo a ser atualizado: ");
            string nome = Console.ReadLine();

            using (var contexto = new Context())
            {
                var Vendas = contexto.Vendas.FirstOrDefault(c => c.Produto == nome);

                if (Vendas != null)
                {
                    Console.WriteLine("Digite o novo nome do produto: ");
                    Vendas.Produto = Console.ReadLine();
                    Console.WriteLine("Digite a nova descrição do produto: ");
                    Vendas.Descricao = Console.ReadLine();
                    Console.WriteLine("Digite a nova data de venda: ");
                    Vendas.DataVenda = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo valor do produto: ");
                    Vendas.Valor = decimal.Parse(Console.ReadLine());

                    contexto.SaveChanges();
                    Console.WriteLine("produto atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }

            Console.ReadKey();
        }
        public static void Read()
        {
            using (var contexto = new Context())

            {
                var arquivo = contexto.Vendas.ToList();

                if (arquivo.Any())
                {
                    foreach (var Vendas in arquivo)
                    {
                        Console.WriteLine($"Nome: {Vendas.Produto}, Tipo: {Vendas.Descricao}, Data: {Vendas.DataVenda}. Preço: {Vendas.Valor}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum Produto encontrado.");
                }
            }
            Console.ReadKey();
        }
        public static void Delete()
        {
            Console.WriteLine("Digite o nome do Produto a ser deletado: ");
            string nome = Console.ReadLine();

            using (var contexto = new Context())
            {
                var Vendas = contexto.Vendas.FirstOrDefault(c => c.Produto == nome);

                if (Vendas != null)
                {
                    contexto.Vendas.Remove(Vendas);
                    contexto.SaveChanges();
                    Console.WriteLine("Produto deletado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }

            Console.ReadKey();
        }
    }
}
