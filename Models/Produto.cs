using System;

namespace TechStoreMVC.Models;

public class Produto
{
    //passo 01 criar as modas
    //Atributos
    public int Id {get; set;} // Get para obter um id = Identificador
                             //  Set para definir um novo  valor, atuaizar
    public string Nome {get; set;}
    public decimal Preco {get; set;}
    public int Estoque {get; set;}

    //Metodo construtor - Define vaores inicial desses atributos acima
    public Produto(
        int id,
        string nome,
        decimal preco,
        int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}
