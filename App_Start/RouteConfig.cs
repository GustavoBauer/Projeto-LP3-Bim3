using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoLP3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Controller Bairro   
            routes.MapRoute(
                name: "InserirBairro",
                url: "Bairro/Inserir",
                defaults: new { controller = "Bairro", action = "Inserir"}
            );

            routes.MapRoute(
                name: "DetalhesBairro",
                url: "Bairro/Detalhes/{id}",
                defaults: new { controller = "Bairro", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirBairro",
                url: "Bairro/Excluir/{id}",
                defaults: new { controller = "Bairro", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarBairro",
                url: "Bairro/Alterar/{id}",
                defaults: new { controller = "Bairro", action = "Alterar" }
            );

            routes.MapRoute(
                name: "Bairro",
                url: "Bairro",
                defaults: new { controller = "Bairro", action = "Index"}
            );

            //Controller CategoriaProduto
            routes.MapRoute(
                name: "InserirCategoriaProduto",
                url: "CategoriaProduto/Inserir",
                defaults: new { controller = "CategoriaProduto", action = "Inserir"}
            );

            routes.MapRoute(
                name: "DetalhesCategoriaProduto",
                url: "CategoriaProduto/Detalhes/{id}",
                defaults: new { controller = "CategoriaProduto", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirCategoriaProduto",
                url: "CategoriaProduto/Excluir/{id}",
                defaults: new { controller = "CategoriaProduto", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarCategoriaProduto",
                url: "CategoriaProduto/Alterar/{id}",
                defaults: new { controller = "CategoriaProduto", action = "Alterar" }
            );

            routes.MapRoute(
                name: "CategoriaProduto",
                url: "CategoriaProduto",
                defaults: new { controller = "CategoriaProduto", action = "Index" }
            );

            //Controller Loja
            routes.MapRoute(
                name: "InserirLoja",
                url: "Loja/Inserir",
                defaults: new { controller = "Loja", action = "Inserir"}
            );

            routes.MapRoute(
                name: "DetalhesLoja",
                url: "Loja/Detalhes/{id}",
                defaults: new { controller = "Loja", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirLoja",
                url: "Loja/Excluir/{id}",
                defaults: new { controller = "Loja", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarLoja",
                url: "Loja/Alterar/{id}",
                defaults: new { controller = "Loja", action = "Alterar" }
            );

            routes.MapRoute(
                name: "Loja",
                url: "Loja",
                defaults: new { controller = "Loja", action = "Index"}
            );

            //Controller Rua
            routes.MapRoute(
                name: "InserirRua",
                url: "Rua/Inserir",
                defaults: new { controller = "Rua", action = "Inserir"}
            );

            routes.MapRoute(
                name: "DetalhesRua",
                url: "Rua/Detalhes/{id}",
                defaults: new { controller = "Rua", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirRua",
                url: "Rua/Excluir/{id}",
                defaults: new { controller = "Rua", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarRua",
                url: "Rua/Alterar/{id}",
                defaults: new { controller = "Rua", action = "Alterar" }
            );

            routes.MapRoute(
                name: "Rua",
                url: "Rua",
                defaults: new { controller = "Rua", action = "Index" }
            );

            //Controller TipoComercio
            routes.MapRoute(
                name: "InserirTipoComercio",
                url: "TipoComercio/Inserir",
                defaults: new { controller = "TipoComercio", action = "Inserir" }
            );

            routes.MapRoute(
                name: "DetalhesTipoComercio",
                url: "TipoComercio/Detalhes/{id}",
                defaults: new { controller = "TipoComercio", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirTipoComercio",
                url: "TipoComercio/Excluir/{id}",
                defaults: new { controller = "TipoComercio", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarTipoComercio",
                url: "TipoComercio/Alterar/{id}",
                defaults: new { controller = "TipoComercio", action = "Alterar" }
            );

            routes.MapRoute(
                name: "TipoComercio",
                url: "TipoComercio",
                defaults: new { controller = "TipoComercio", action = "Index"}
            );

            //Controller Usuario
            routes.MapRoute(
                name: "InserirUsuario",
                url: "Usuario/Inserir",
                defaults: new { controller = "Usuario", action = "Inserir" }
            );

            routes.MapRoute(
                name: "DetalhesUsuario",
                url: "Usuario/Detalhes/{id}",
                defaults: new { controller = "Usuario", action = "Detalhes" }
            );

            routes.MapRoute(
                name: "ExcluirUsuario",
                url: "Usuario/Excluir/{id}",
                defaults: new { controller = "Usuario", action = "Excluir" }
            );

            routes.MapRoute(
                name: "AlterarUsuario",
                url: "Usuario/Alterar/{id}",
                defaults: new { controller = "Usuario", action = "Alterar" }
            );

            routes.MapRoute(
                name: "Usuario",
                url: "Usuario",
                defaults: new { controller = "Usuario", action = "Index"}
            );

            //Controller Home Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
