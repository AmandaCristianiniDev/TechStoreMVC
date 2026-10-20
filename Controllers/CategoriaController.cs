using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class CategoriaController : Controller // o ":" significa herença
    //herança = herda as caracteristicas de um controlador
    //Conceito de POO -> Programação Orientada a Objetos

    {
        // GET: ProdutosControllers

        //Passo 02 Criar a ação
        //Uma view depende de uma ação e vice versa
        public ActionResult Index()
        {
            //Passo 05 - Objeto
            // criar um objeto com varios produtos, por isso usamos um list
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria(1, "Informática", "Computadores e componentes", true),
                new Categoria(2, "Periféricos", "Mouse, teclado e acessórios", true),
                new Categoria(3, "Áudio", "Fones, caixas e microfones", true),
                new Categoria(4, "Monitores", "Telas e monitores", true),
                new Categoria(5, "Descontinuados", "Telas e monitores", false),
            };

            return View(categorias);
        }

    }
}
