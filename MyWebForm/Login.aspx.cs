using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
        Expression<Func<Usuario, bool>> filtrar = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarSButton_Click(object sender, EventArgs e)
        {
            BLL.UsuarioRepositorio.Autenticar(emailTextBox.Text,passwordTextBox.Text, this);
        }
    }
}