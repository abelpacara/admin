using Admin.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class EditCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Domicilio = txtDomicilio.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;

                if (EditCliente.Insertar(cliente) > 0)
                {
                    messageBox.ShowMessage("El cliente se inserto correctamente");
                }
            }
            catch (Exception ex)
            {
                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}