using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLP3.Helpers
{
    public static class HelperHome
    {
        public static MvcHtmlString ExibeImagem(this HtmlHelper hp)
        {
            string code = "<div class=\"containerTexto\">" +
            "    <div class=\"parallax\"></div>" +
            "    <div class=\"contentParallax\">" +
            "        <h1>Ruas de Comércio</h1>" +
            "        <p style=\"padding-bottom:50px\">Encontre as melhores ruas para fazer compras perto de você!</p>" +
            "        <a href=\"#\" class=\"scroll-down\" address=\"true\"></a>" +
            "    </div>" +
            "    <div class=\"parallax\"></div>" +
            "</div>";
            return new MvcHtmlString(code);
        }

        public static MvcHtmlString ExibeFrase(this HtmlHelper hp)
        {
            string code = "<div style=\"text-align:center\">" +
            "        <h1 style=\"margin:20px 0 20px 0; padding-top:20px\">Consultas</h1>" +
            "        <p style=\"font-size:19px;\">" +
            "            Esta aplicação tem o intuito de oferecer consultas para que o usuário possa encontrar as melhores lojas em diversas ruas e em diversos setores de comércios." +
            "        </p>" +
            "    </div>" +
            "    <hr style=\"background-color:#9dabab;\" />" +
            "    <br />";
            return new MvcHtmlString(code);
        }

        
    }
}