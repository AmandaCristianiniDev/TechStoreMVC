namespace TechStoreMVC.Models;

public class ProdutosDB
{
    // passo 01 criar/trazer os dados de produto controller
    // Metodo que vai listar novos objetos de um produto
    // e armazená-los na variavel produtos 
    private static readonly List<Produto> produtos = new()
    {
         new Produto(1, "Mouse Gamer", 129.9m, 10),
         new Produto(2, "Teclado Mecânico", 249.9m, 5),
         new Produto(3, "Monitor 24 poegadas", 899.9m, 8),
         new Produto(4, "Headset Gamer", 179.9m, 17),
          

    };

    // passo 02 criar os metodosdo crud e rmeover toda regra de negocio do controll
    //Responsabilidade do listar: Devolver/mostrar os produtos. Igual o index
    //Controller
    public List<Produto> Listar()
    {
        return produtos;
    }

    public Produto? buscaPorId(int id)
    {
        return produtos.FirstOrDefault(
            Produto => Produto.Id == id

        );
    }

    public void Adicionar (Produto produto)
    {
        produto.Id = produtos.Count + 1;
        produtos.Add(produto);
    }

    public bool Atualizar(Produto produtoAtualizado)
    {
        Produto? produtoExistente =
            buscaPorId(produtoAtualizado.Id);

        if (produtoExistente is null)
            return false;

        produtoExistente.Nome = produtoAtualizado.Nome;
        produtoExistente.Preco = produtoAtualizado.Preco;
        produtoExistente.Estoque = produtoAtualizado.Estoque;
        return true;
    }

    public bool Excluir(int id)
    {
        Produto? produto = buscaPorId(id);
        if (produto is null)
            return false;
        produtos.Remove(produto);

        return true;
    }
}   