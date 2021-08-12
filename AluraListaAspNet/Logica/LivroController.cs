using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace AluraListaAspNet
{
    public class LivroController:Controller
    {
        public IEnumerable<Livro> Livros { get; set; }


        public string Detalhes(int id)
        {   
            var _repo = new LivroRepositorioCSV();
            var livro = _repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
        public IActionResult ParaLer()
        {
            //var conteudoArquivo = HTMLUtils.carregaArquivoHTML("ParaLer");
            // var _repo = new LivroRepositorioCSV();
            // return context.Response.WriteAsync(_repo.ParaLer.ToString());

            //foreach (var livro in _repo.ParaLer.Livros)
            // {
            // conteudoArquivo = conteudoArquivo
            //.Replace("#NOVO-ITEM", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM");
            //}
            //conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM", "");
            // return context.Response.WriteAsync(conteudoArquivo);
          
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            //var html = new ViewResult { ViewName = "ParaLer" };
            return View("Lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("Lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("Lista");
        }
        public string Teste()
        {
            return ("TESTE!");
        }
    }
}



//private static string CarregaLista(IEnumerable<Livro> livros)
//{
//    var conteudoArquivo = HTMLUtils.carregaArquivoHTML("ParaLer");
//
//    return conteudoArquivo.Replace("#NOVO-ITEM", "");
//}