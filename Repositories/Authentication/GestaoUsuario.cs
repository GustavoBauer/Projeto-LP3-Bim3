using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoLP3.Models;

namespace ProjetoLP3.Repositories.Authentication
{
    public class GestaoUsuario
    {
        public static bool VerificarUsuarioBD(string login, string senha)
        {
            try
            {
                SeminarioLP3Container bd = new SeminarioLP3Container();
                var usuario = bd.Usuario.Where(x => x.Login == login && x.Senha == senha).SingleOrDefault();
                if (usuario == null)
                {
                    return false;
                }
                else
                {
                    GestaoCookie.CriarCookie(usuario.IdUsuario);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Usuario RecuperarUsuario(int idUsuario)
        {
            try
            {
                SeminarioLP3Container bd = new SeminarioLP3Container();
                var usuario = bd.Usuario.Where(u => u.IdUsuario == idUsuario).SingleOrDefault();
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Usuario VerificarStatusUsuario()
        {
            HttpCookie cookieUsuario = HttpContext.Current.Request.Cookies["CookieUsuario"];

            if (cookieUsuario == null)
            {
                return null;
            }
            else
            {
                int idUsuario = Convert.ToInt32(cookieUsuario.Values["IdUsuario"]);
                var usuario = RecuperarUsuario(idUsuario);
                return usuario;
            }
        }
    }
}