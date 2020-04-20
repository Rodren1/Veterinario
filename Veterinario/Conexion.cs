using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Veterinario
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root;Pwd=;Port=3306");

        }
        
        public String loginUsuario(String dni, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = 
                    new MySqlCommand("SELECT * FROM usuarios WHERE dni = @dni AND contraseña  = @contraseña", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    resultado.GetString(0);
                }

                conexion.Close();
                return "error usuario/contraseña";
            }
            catch(MySqlException e)
            {
                return "error";
            }
        }

        


    }
}

