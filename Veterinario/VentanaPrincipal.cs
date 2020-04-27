using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BCrypt.Net;

namespace Veterinario
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Datos r = new Datos();
            r.Show();
        }

        private void insertCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaCliente(textBoxDNI.Text, textBoxNombreC.Text, textBoxApellido.Text, 
                textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text));
        }

        private void insertMascota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxCodigo_identif.Text, textBoxNombre_mascota.Text, textBoxEspecie.Text,
                textBoxEdad.Text, textBoxDueño.Text));
        }

        private void Mascotas_Click(object sender, EventArgs e)
        {
            FichaMascotas m = new FichaMascotas();
            m.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            FichaClientes c = new FichaClientes();
            c.Show();
        }

       private void registroUsuarios_Click(object sender, EventArgs e)
        {
            //String textoContraseña = textBoxContraseña.Text;
            //string miHash = BCrypt.Net.BCrypt.HashPassword(textoContraseña, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.insertaUsuario(textBoxDniUsuario.Text, textBoxNombre_us.Text,
                textBoxContraseña.Text, textBoxTelefonoUs.Text));
        }

    }
}
