using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1
{
    public partial class Ver : System.Web.UI.Page
    {
        private void MostrarTxt()
        {
            string ruta = Server.MapPath(".") + "cuentas.txt";

            if (!File.Exists(ruta)) {
                lblVista.Text = "No existen datos";
                return;
            }

            StreamReader streamReader = new StreamReader(Server.MapPath(".") + "cuentas.txt");
            lblVista.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarTxt();
        }
    }
}