using System;

namespace TechStoreMVC.Models;

public class Categoria
{
    //passo 01 criar as modas
    //Atributos
    public int Id {get; set;} // Get para obter um id = Identificador
                             //  Set para definir um novo  valor, atuaizar
    public string Nome {get; set;}
    public string Descricao {get; set;}
    public int Estoque {get; set;}

    //public bool Ativa {get; set;}

    //Metodo construtor - Define vaores inicial desses atributos acima
    public Categoria(
        int id,
        string nome,
        string descricao,
        int estoque
        //bool ativa
    )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Estoque = estoque;
       // Ativa = ativa;
    }
}
