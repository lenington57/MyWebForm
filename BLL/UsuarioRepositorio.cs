using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Web.Security;
using System.Web.UI;

namespace BLL
{
    public class UsuarioRepositorio : Repositorio<Usuario> 
    {
        public UsuarioRepositorio()
        {

        }

        public static void Autenticar(string email, string password, Page page)
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            Expression<Func<Usuario, bool>> filtrar = x => true;
            Usuario usuario = new Usuario();

            filtrar = t => t.Email.Equals(email) && t.Password.Equals(password);

            if (repositorio.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(usuario.Email, true);
            else
                ScriptManager.RegisterStartupScript(page, typeof(Page), "toastr_message", script: "toastr['error'] ('Usuario o Contraseña Incorrecto');", addScriptTags: true);
        }
    }
}
