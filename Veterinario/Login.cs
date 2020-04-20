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
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void inicioSesion_Click(object sender, EventArgs e)
        {
            String resul = conexion.loginUsuario(UsuarioTBox.Text, ContraseñaTBox.Text);
            MessageBox.Show(resul);
            
            //this.Hide();
            //VentanaPrincipal v = new VentanaPrincipal();
            //v.Show();
        }

    }
}
