using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegaloLaura
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ViewState["IntentosFallidos"] = 0;
            }
        }

        protected void boton_Click(object sender, EventArgs e)
        {
            if (contraseña.Text == "29-11-2023")
            {
                Response.Redirect("Regalo.aspx");
            }
            else if (contraseña.Text == "")
            {
            }
            else
            {
                int intentosFallidos = (int)ViewState["IntentosFallidos"];
                intentosFallidos++;
                ViewState["IntentosFallidos"] = intentosFallidos;
                error.Text = "Error, contraseña incorrecta";
                if (intentosFallidos >= 2)
                {
                    pista.Text = "PISTA: Es una fecha (formato DD-MM-AAAA)";
                }
                else
                {
                    pista.Text = "";
                }
            }
        }
    }
}