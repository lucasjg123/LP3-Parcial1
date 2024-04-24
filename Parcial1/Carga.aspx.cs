using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial1
{
    public partial class FormularioCarga : System.Web.UI.Page
    {
        private void HabilitarControles(bool x)
        {
            //deshabilitamos el txtcodigo
            txtCodigo.Enabled = x;
            //deshabilitamos el boton de cargar
            btnCargar.Enabled = x;
        }

        // Carga los tipos de cuentas en el dropdownlist
        private void CargarTipos()
        {
            if (!IsPostBack)
            {
                // Definir los tipos a cargar en el DropDownList
                string[] tipos = { "Seleccione un tipo", "Activo", "Pasivo", "Patrimonio Neto", "Resultados Positivos", "Resultados Negativos" };

                // Agregarlos al DropDownList
                foreach (string tipo in tipos)
                {
                    DropDownList1.Items.Add(new ListItem(tipo));
                }
            }
        }

        private string ValidarDatos()
        {
            string error = "";

            // Validar que los txt no esten vacios
            if (txtNombre.Text.Trim().Length == 0) error += "- Debe ingresar un nombre <br/>";
            if (txtCodigo.Text.Trim().Length == 0) error += "- Debe ingresar un codigo <br/>";
            else // Validar que el txtcodigo solo contenga nros
            {
                // Definimos expresion regular de solo nros
                Regex regex = new Regex("^[0-9]+$");

                if (!regex.IsMatch(txtCodigo.Text.Trim())) error += "- Sólo se permiten nros en el codigo <br/>";
            }

            // Si sucedio algun error le agregamos el titulo
            if (error.Length != 0) error = "ERROR <br/>" + error;

            return error;
        }


        private void Guardar()
        {
            // extraer datos
            string nombre = txtNombre.Text.Trim();
            string tipo = DropDownList1.SelectedItem.ToString();
            string codigo = lblCodigo.Text + txtCodigo.Text.Trim();

            // guardar en txt
            StreamWriter arch = new StreamWriter(Server.MapPath(".") + "cuentas.txt", true);
            arch.WriteLine("<hr>");
            arch.WriteLine("Nombre: " + nombre + "<br/>");
            arch.WriteLine("Tipo: " + tipo + "<br/>");
            arch.WriteLine("Código: " + codigo + "<br/>");
            arch.WriteLine("<hr>");

            arch.Close();

            // Enviamos msj de exito
            lblResponse.Text = "La carga fue exitosa";
        }

        /* EVENTOS */
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Si no se selecciona un tipo
            if (DropDownList1.SelectedIndex == 0)
            {
                HabilitarControles(false);
                // quitamos el nro identificador de tipo
                lblCodigo.Text = "..";
            }
            else
            {
                HabilitarControles(true);
                // Asignamos el nro identificador de tipo
                lblCodigo.Text = DropDownList1.SelectedIndex.ToString();
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        { 
            // Validar datos
            string msj = ValidarDatos();
            if (msj.Length != 0) {
                lblResponse.Text = msj;
                return;
            }
            

            // extraer los datos y guardarlos en un txt
            Guardar();

        }
    }
}