using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entities;
using DAL;
using System.Linq.Expressions;

namespace MyWebForm.Consultas
{
    public partial class CUsuarioWF : System.Web.UI.Page
    {
        Expression<Func<Usuario, bool>> filtro;// = p => true;
        Repositorio<Usuario> repositorio = new Repositorio<Usuario>();
        public static List<Usuario> listUsuarios { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            listUsuarios = repositorio.GetList(x => true);
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (FiltroDropDownList.SelectedIndex)
            {
                //    case 0://Todo
                //        filtro = p => true && p.Fecha >= desde && p.Fecha <= hasta;
                //        break;

                case 0://UsuarioId
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    break;

                case 1://Nombre
                    filtro = p => p.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 2://Email
                filtro = p => p.Email.Contains(CriterioTextBox.Text);
                    break;
            }

            listUsuarios = repositorio.GetList(filtro);
            UsuarioGridView.DataSource = listUsuarios;
            UsuarioGridView.DataBind();
        }

        public static List<Usuario> RetornarUsuarios()
        {
            return listUsuarios;
        }
    }
}