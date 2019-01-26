using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using DAL;
using BLL;
using System.Linq.Expressions;

namespace MyWebForm.Registros
{
    public partial class UsuarioWF : System.Web.UI.Page
    {
        Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
        Expression<Func<Usuario, bool>> filtrar = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            usuarioIdTextBox.Text = "0";
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

            usuario.UsuarioId = ToInt(usuarioIdTextBox.Text);
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

        private bool ComprobarEmail()
        {
            bool paso = false;
            filtrar = t => t.Email.Equals(emailTextBox.Text);
            if (repositorio.GetList(filtrar).Count() != 0)
            {
                Response.Write("<script>alert('Este email ya existe');</script>");
                paso = true;
            }
            return paso;
        }

        private bool HayErrores()
        {
            bool HayErrores = false;
            filtrar = t => t.Email.Equals(emailTextBox.Text);
            string s = passwordTextBox.Text;
            string ss = cpasswordTextBox.Text;
            int comparacion = 0;
            comparacion = String.Compare(s, ss);
            if (comparacion != 0)
            {
                Response.Write("<script>alert('Contraseñas no concuerdan');</script>");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                Response.Write("<script>alert('Debe ingresar un Nombre');</script>");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(noTelefonoTextBox.Text))
            {
                Response.Write("<script>alert('Debe ingresar un Número de Teléfono');</script>");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                Response.Write("<script>alert('Debe ingresar un Email');</script>");
                HayErrores = true;
            }
            if (repositorio.GetList(filtrar).Count() != 0)
            {
                Response.Write("<script>alert('Este email ya existe');</script>");
                HayErrores = true;
            }
            return HayErrores;
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
            Usuario usuario = repositorio.Buscar(ToInt(usuarioIdTextBox.Text));
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

            if (HayErrores())
                Response.Write("<script>alert('Llene los Campos Correctamente');</script>");
            else
            {
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
                    int id = ToInt(usuarioIdTextBox.Text);
                    usuario = repositorio.Buscar(id);

                    if (usuario != null)
                    {
                        paso = repositorio.Modificar(LlenaClase());
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

        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void eliminarutton_Click(object sender, EventArgs e)
        {
            BLL.Repositorio<Usuario> repositorio = new BLL.Repositorio<Usuario>();
            int id = ToInt(usuarioIdTextBox.Text);

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