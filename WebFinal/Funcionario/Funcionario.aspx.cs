using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFinal.Funcionario
{
    public partial class Funcionario : System.Web.UI.Page
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =localhost:1521/xe ; PASSWORD = 123 ; USER ID = admin1");

        protected void Page_Load(object sender, EventArgs e)
        {
          


            
        }

        void listadoactivo()
        {

  
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("../Funcionario/SeleccionarcehckinPrueba.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("../Funcionario/SeleccionarChekout.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("../Funcionario/IniciarSesion.aspx");
        }
    }
}