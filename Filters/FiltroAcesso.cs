﻿using ProjetoLP3.Repositories.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLP3.Filters
{
    public class FiltroAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtroContexto)
        {
            var controller = filtroContexto.ActionDescriptor.ControllerDescriptor.ControllerName;

            if (controller != "Home")
            {
                if (GestaoUsuario.VerificarStatusUsuario() == null)
                {
                    filtroContexto.RequestContext.HttpContext.Response.Redirect("/Home/Login");
                }
            }
        }
    }
}