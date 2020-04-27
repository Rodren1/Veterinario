using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class FichaClientes : Form
    {
        Conexion miConexion = new Conexion();
        DataTable clientes = new DataTable();

        public int idActual = 0;
        public FichaClientes()
        {
            InitializeComponent();
        }

        private void anteriorCliente_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0)
            {
                idActual = 1;
                infoCliente(idActual);
            }
        }

        private void siguienteCliente_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 100)
            {
                idActual = 100;
                infoCliente(idActual);
            }
        }
        public void infoCliente(int identifi)
        {
            clientes = miConexion.getClientesPorId(identifi);
            labelFichaDni.Text = "DNI : " + clientes.Rows[0]["dni"].ToString();
            labelFichaNombreCliente.Text = "Nombre : " + clientes.Rows[0]["nombre"].ToString();
            labelFichaApellido.Text = "Apellido : " + clientes.Rows[0]["apellido"].ToString();
            labelFichaDireccion.Text = "Dir : " + clientes.Rows[0]["direccion"].ToString();
            labelFichaTelefono.Text = "Telefono : " + clientes.Rows[0]["telefono"].ToString();
            labelFichaEmail.Text = "Email : " + clientes.Rows[0]["email"].ToString();
        }
    }
}
