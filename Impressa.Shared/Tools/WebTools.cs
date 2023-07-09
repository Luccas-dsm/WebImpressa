using Impressa.Shared.Models;
using System.Web;

namespace Impressa.Shared
{
    public class WebTools
    {
        public static string GerarLinkWhatsApp(ProdutoModel conteudo)
        {

            string textoFormatado = $"Nome: {conteudo.Nome}\nDescrição: {conteudo.Descricao}";


            string encodedPhoneNumber = HttpUtility.UrlEncode("+553198312014");
            string encodedContent = HttpUtility.UrlEncode(textoFormatado);

            string link = $"https://api.whatsapp.com/send?phone={encodedPhoneNumber}&text={encodedContent}";

            return link;
        }
    }
}
