using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AluraListaAspNet
{
   public class CadastroController
    {

        public IActionResult ExibeFormulario()
        {
            //var html = HTMLUtils.carregaArquivoHTML("Formulario");
            //return context.Response.WriteAsync(html);
            var html = new ViewResult { ViewName = "Formulario" };
            return html;
        }


        public string Incluir(Livro  livro)
        {
            //var livro = new Livro()
            //{
               // Titulo = Convert.ToString(context.GetRouteValue("nome")),
               // Autor = Convert.ToString(context.GetRouteValue("autor")),
            //};

            var _repo = new LivroRepositorioCSV();
            _repo.Incluir(livro);
            return ("Livro ADD COM SUCESSO a LIVROS PARA LER!");
        }

        public string Teste()
        {
            return ("TESTE!");
        }
    }

}



// public static Task ProcessaFormulario(HttpContext context)
// {
//var livro = new Livro()
//{
//USANDO POST
//Titulo = context.Request.Form["titulo"].First(),
//Autor = context.Request.Form["autor"].First(),
//USANDO GET
// Titulo = context.Request.Query["titulo"].First(),
// Autor = context.Request.Query["autor"].First(),
//};
//var _repo = new LivroRepositorioCSV();
//_repo.Incluir(livro);
 // return context.Response.WriteAsync("Livro ADD COM SUCESSO a LIVROS PARA LER!");
 // }

