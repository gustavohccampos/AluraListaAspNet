using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
            //var routeBuilder = new RouteBuilder(app);
            //routeBuilder.MapRoute("/livros/ler", LivrosLogica.LivrosParaLer);
            //routeBuilder.MapRoute("/livros/lendo", LivrosLogica.LivrosLendo);
           // routeBuilder.MapRoute("/livros/lidos", LivrosLogica.LivrosLidos);
            //routeBuilder.MapRoute("/cadastro/livro/{nome}/{autor}", NovoLivroParaLer);
           // routeBuilder.MapRoute("/livros/detalhes/{id:int}", LivrosLogica.ExibirDetalhes);
           // routeBuilder.MapRoute("/cadastro/livro", CadastroLogica.ExibeFormulario);
           // routeBuilder.MapRoute("/cadastro/incluir", CadastroLogica.ProcessaFormulario);
           // var rotas = routeBuilder.Build();
            //app.UseRouter(rotas);
            //app.Run(Roteamento);
        }


    }
}



/*
       public Task Roteamento(HttpContext context) 
       {
           var _repo = new LivroRepositorioCSV();
           var caminhosAtendidos = new Dictionary<string, RequestDelegate>
           {
                {"/cadastro/livro", LivrosParaLer },
               {"/livros/ler", LivrosParaLer },
               {"/livros/lendo", LivrosLendo },
               {"/livros/lidos", LivrosLidos }
           };
           //Livros/paraler
           //livros/lendo
           //livros/lidos
           if (caminhosAtendidos.ContainsKey(context.Request.Path))
           {
               var metodo = caminhosAtendidos[context.Request.Path];
               return metodo.Invoke(context);
           }
           context.Response.StatusCode = 404;
           return context.Response.WriteAsync("CAMINHO INEXISTENTE!");
       }
       */
