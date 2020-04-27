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
    public partial class FichaMascotas : Form
    {
        Conexion miConexion = new Conexion();
        DataTable mascotas = new DataTable();

        public static int idActual = 0;
        public FichaMascotas()
        {
            InitializeComponent();
        }

        private void anteriorMascota_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0)
            {
                idActual = 1;
            }
            infoMascota(idActual);
        }

        private void siguienteMascota_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 100)
            {
                idActual = 2;
            }
            infoMascota(idActual);
        }
        public void infoMascota(int codigo_identif)
        {
            mascotas = miConexion.getMascotasPorId(codigo_identif);
            labelFichaNombreMascota.Text = "Nombre : " + mascotas.Rows[0]["nombre_mascota"].ToString();
            labelFichaEspecie.Text = "Especie : " + mascotas.Rows[0]["especie"].ToString();
            labelFichaEdad.Text = "Edad : " + mascotas.Rows[0]["edad"].ToString();
            labelFichaDueño.Text = "Dueño : " + mascotas.Rows[0]["dueño"].ToString();
        }
    }
}
