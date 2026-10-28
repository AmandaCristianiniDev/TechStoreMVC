namespace TechStoreMVC.Models;

public class CategoriasDB
{
    // passo 01 criar/trazer os dados de produto controller
    // Metodo que vai listar novos objetos de um produto
    // e armazená-los na variavel produtos 
    private static readonly List<Categoria> categorias = new()
    {
         new Categoria(1, "Computador Gamer", "PC Gamer pronto para rodar seus jogos favoritos com gráficos incríveis e FPS alto. Rápido, estiloso e sem travamentos!",10),
         new Categoria(2, "Periféricos", "Eleve o seu jogo com este combo de periféricos! Teclado de alta precisão, mouse com ajuste de DPI e headset com som imersivo para total controle nas partidas", 5),
         new Categoria(3, "Eletrônicos", "Encontre os melhores eletrônicos para o seu dia a dia! Produtos de alta qualidade, garantindo mais velocidade, praticidade e o melhor desempenho para a sua rotina.", 15),
         new Categoria(4, "Monitores", "Eleve sua experiência visual com monitores de alta resolução, taxa de atualização incrível e cores vibrantes. Perfeitos para jogos, trabalho ou entretenimento", 15)
          

    };

    // passo 02 criar os metodosdo crud e rmeover toda regra de negocio do controll
    //Responsabilidade do listar: Devolver/mostrar os produtos. Igual o index
    //Controller
    public List<Categoria> Listar()
    {
        return categorias;
    }

    public Categoria? buscaPorId(int id)
    {
        return categorias.FirstOrDefault(
            categoria => categoria.Id == id

        );
    }

    public void Adicionar (Categoria categoria)
    {
        categoria.Id = categorias.Count + 1;
        categorias.Add(categoria);
    }

    public bool Atualizar(Categoria categoriaAtualizada)
    {
        int indice = categorias.FindIndex(categoria => categoria.Id == categoriaAtualizada.Id);

        if (indice < 0)
            return false;

        categorias[indice] = categoriaAtualizada;
        return true;
    }

    public bool Excluir(int id)
    {
        Categoria? categoria = buscaPorId(id);
        if (categoria is null)
            return false;
        categorias.Remove(categoria);

        return true;
    }
}   