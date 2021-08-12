using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AluraListaAspNet
{
    class HTMLUtils
    {
        public static string carregaArquivoHTML(string nomearquivo)
        {
            var nomeCompletoArquivo = $"HTML/{nomearquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }

    }
}
