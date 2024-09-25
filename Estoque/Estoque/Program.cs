using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] id = new string[50];
            String[] nome = new string[50];
            String[] quantidade = new string[50];
            String[] fornecedor = new string[50];
            String[] tipo = new string[50];

            int quant_Registro = 0;
            int opcao = 0;

            String IdProduto = "";

            while (opcao != 5)
            {
                opcao = Produto.Menu();

                switch (opcao)
                {
                    case 1:
                        Produto.ListarProdutos(id, nome, quantidade, fornecedor, tipo, quant_Registro);
                        break;

                    case 2:
                        Produto.AdicionarProdutos(ref id, ref nome, ref quantidade, ref fornecedor, ref tipo, ref quant_Registro);
                        break;

                    case 3:
                        Produto.AtualizarProdutos(ref id, ref nome, ref quantidade, ref fornecedor, ref tipo, ref quant_Registro);
                        break;

                    case 4:
                        Console.WriteLine("Apagar produto");
                        Console.WriteLine("Insira o Id");
                        IdProduto = Console.ReadLine();

                        if (Produto.ApagarProduto(ref id, ref nome, ref quantidade, ref fornecedor, ref tipo, ref quant_Registro, IdProduto))
                        {
                            Console.WriteLine("Produto apagado");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}