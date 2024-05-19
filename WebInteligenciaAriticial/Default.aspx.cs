using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebInteligenciaAriticial
{
    public partial class _Default : Page
    {

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
           
            if (tbUsuario.Text == "user@gmail.com" & tbPassword.Text == "123")
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                lblError.Text = "Error de Usuario o Contrasenia";
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {



            
        }
    }
}