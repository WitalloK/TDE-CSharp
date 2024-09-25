using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Produto
{
    public static int Menu()
    {
        int opcao = 0;

        Console.Clear();
        Console.WriteLine("Menu do Estoque");
        Console.WriteLine("Listar produtos {1}");
        Console.WriteLine("Adicionar produto {2}");
        Console.WriteLine("Atualizar produto {3}");
        Console.WriteLine("Apagar produto {4}");
        Console.WriteLine("Sair {5}");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();

        return opcao;
    }

    public static void ListarProdutos(String[] id, String[] nome, String[] quantidade, String[] fornecedor, String[] tipo, int quant_Registro)
    {
        Console.WriteLine("Lista dos produtos");

        for (int i = 0; i < quant_Registro; i++)
        {
            Console.WriteLine("Id: {0} -- Nome: {1} --  Quantidade: {2} -- Fornecedor: {3} -- Tipo: {4}",id[i], nome[i], quantidade[i], fornecedor[i], tipo[i]);
        }

        quant_Registro++;

        Console.ReadLine();
    }

    public static void AdicionarProdutos(ref String[] id, ref String[] nome, ref String[] quantidade, ref String[] fornecedor, ref String[] tipo, ref int quant_Registro)
    {
        Console.WriteLine("Adicionar dados do produto");
        Console.WriteLine("Id: ");
        id[quant_Registro] = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Nome: ");
        nome[quant_Registro] = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Quantidade: ");
        quantidade[quant_Registro] = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Fornecedor: ");
        fornecedor[quant_Registro] = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Tipo: ");
        tipo[quant_Registro] = Console.ReadLine();
        Console.Clear();

        int posicao = ChecarProdutos(id, quant_Registro, id[quant_Registro]);

        if(posicao == -1)
        {
            quant_Registro++;
        }
        else
        {
            Console.WriteLine("Já existe um produto com este Id");
            Console.ReadLine();
        }
    }

    public static int ChecarProdutos(String[] id, int quant_Registro, String IdProduto)
    {
        int posicao = -1;
        int i = 0;

        while (i < quant_Registro && id[i] != IdProduto)
        {
            i++;
        }

        if (i < quant_Registro) posicao = i;
        return posicao;
    }

    public static void AtualizarProdutos(ref String[] id, ref String[] nome, ref String[] quantidade, ref String[] fornecedor, ref String[] tipo, ref int quant_Registro)
    {
        Console.WriteLine("Atualizar dados do produto");
        Console.WriteLine("Insira o Id do produto: ");
        String idProduto = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Insira os novos dados");
        Console.WriteLine("Nome: ");
        String nomeProduto = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Quantidade: ");
        String quantidadeProduto = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Fornecedor: ");
        String fornecedorProduto = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Tipo: ");
        String tipoProduto = Console.ReadLine();
        Console.Clear();

        int posicao = ChecarProdutos(id, quant_Registro, idProduto);
        
        if (posicao != -1)
        {
            nome[posicao] = nomeProduto;
            quantidade[posicao] = quantidadeProduto;
            fornecedor[posicao] = fornecedorProduto;
            tipo[posicao] = tipoProduto;
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
            Console.ReadLine();
        }
    }

    public static Boolean ApagarProduto(ref String[] id, ref String[] nome, ref String[] quantidade, ref String[] fornecedor, ref String[] tipo, ref int quant_Registro, String idProduto)
    {
        Boolean Excluir = false;

        int posicao = -1;
        posicao = ChecarProdutos(id, quant_Registro, idProduto);

        if(posicao != -1)
        {
            for (int i = posicao; i < quant_Registro-1; i++)
            {
                id[i] = id[i + 1];
                nome[i] = nome[i + 1];
                quantidade[i] = quantidade[i + 1];
                fornecedor[i] = fornecedor[i + 1];
                tipo[i] = tipo[i + 1];
            }
            Excluir = true;

            quant_Registro--;
        }
        return Excluir;    
    }
}