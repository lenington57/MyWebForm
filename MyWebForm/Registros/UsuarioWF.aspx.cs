using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using DAL;
using BLL;

namespace MyWebForm.Registros
{
    public partial class UsuarioWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            usuarioIdTextBox.Text = " ";
            nombreTextBox.Text = " ";
            noTelefonoTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            cpasswordTextBox.Text = "";
            tipoUsuarioDropDownList.SelectedIndex = 0;
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioId = Convert.ToInt32(usuarioIdTextBox.Text);
            usuario.Nombres = nombreTextBox.Text;
            usuario.NoTelefono = noTelefonoTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Password = passwordTextBox.Text;
            usuario.CPassword = cpasswordTextBox.Text;
            usuario.TipoUsuario = tipoUsuarioDropDownList.Text;

            return usuario;

        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            Usuario usuario = repositorio.Buscar(Convert.ToInt32(usuarioIdTextBox.Text));
            if (usuario != null)
            {
                nombreTextBox.Text = usuario.Nombres;
                noTelefonoTextBox.Text = usuario.NoTelefono;
                emailTextBox.Text = usuario.Email;
                passwordTextBox.Text = usuario.Password;
                cpasswordTextBox.Text = usuario.CPassword;
                tipoUsuarioDropDownList.Text = usuario.TipoUsuario.ToString();
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");

            }
        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            Usuario usuario = new Usuario();
            bool paso = false;

            //todo: validaciones adicionales
            usuario = LlenaClase();

            if (usuario.UsuarioId == 0)
            {
                paso = repositorio.Guardar(usuario);
                Response.Write("<script>alert('Guardado');</script>");
                Limpiar();
            }
            else
            {
                int id = Convert.ToInt32(usuarioIdTextBox.Text);
                usuario = repositorio.Buscar(id);

                if (usuario != null)
                {
                    paso = repositorio.Modificar(usuario);
                    Response.Write("<script>alert('Modificado');</script>");
                }
                else
                    Response.Write("<script>alert('Id no existe');</script>");
            }

            if (paso)
            {
                Limpiar();
            }
            else
                Response.Write("<script>alert('No se pudo guardar');</script>");

        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            int id = Convert.ToInt32(usuarioIdTextBox.Text);

            var usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                if (repositorio.Eliminar(id))
                {
                    Response.Write("<script>alert('Eliminado');</script>");
                    Limpiar();
                }
                else
                    Response.Write("<script>alert('No se pudo eliminar');</script>");
            }
            else
                Response.Write("<script>alert('No existe');</script>");
        }
    }
}