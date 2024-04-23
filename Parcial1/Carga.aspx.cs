using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1
{
    public partial class FormularioCarga : System.Web.UI.Page
    {
        // Carga los tipos de cuentas en el dropdownlist
        private void CargarTipos()
        {
            if (!IsPostBack)
            {
                // Definir los tipos a cargar en el DropDownList
                string[] tipos = { "Activo", "Pasivo", "Patrimonio Neto", "Resultados Positivos", "Resultados Negativos" };

                // Agregarlos al DropDownList
                foreach (string tipo in tipos)
                {
                    DropDownList1.Items.Add(new ListItem(tipo));
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }
    }
}