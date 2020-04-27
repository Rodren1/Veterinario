using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        
        public Boolean loginUsuario(String dni, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = 
                    new MySqlCommand("SELECT * FROM usuarios WHERE dni = @dni AND contraseña = @contraseña", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    //string passwordConHash = resultado.GetString("contraseña");
                    //if (BCrypt.Net.BCrypt.Verify(contraseña, passwordConHash))
                    //{
                    //    return true;
                    //}
                    //return false;
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }

        public DataTable getAllClMa()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM clientes as c, mascotas as m WHERE m.dueño = c.dni", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public String insertaCliente(String dni, String nombre, String apellido, String direccion, String telefono, String email)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO clientes(dni, nombre, apellido, direccion, telefono, email, identifi) " +
                    "VALUES (@dni, @nombre, @apellido, @direccion, @telefono, @email, NULL)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@direccion", direccion);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@email", email);

                consulta.ExecuteNonQuery();
                conexion.Close();
                return "Registro finalizado";
            }
            catch(MySqlException e)
            {
                return "error";
            }
        }
        public String insertaMascota(String codigo_identif, String nombre_mascota, String especie, String edad, String dueño)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO mascotas(codigo_identif, nombre_mascota, especie, edad, dueño) " +
                    "VALUES (NULL, @nombre_mascota, @especie, @edad, @dueño)", conexion);
                consulta.Parameters.AddWithValue("@nombre_mascota", nombre_mascota);
                consulta.Parameters.AddWithValue("@especie", especie);
                consulta.Parameters.AddWithValue("@edad", edad);
                consulta.Parameters.AddWithValue("@dueño", dueño);

                consulta.ExecuteNonQuery();
                conexion.Close();
                return "Registro finalizado";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public String insertaUsuario(String dni, String contraseña, String nombre_us, String telefono)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuarios(id, dni, contraseña, nombre_us, telefono) " +
                    "VALUES (NULL, @dni, @contraseña, @nombre_us, @telefono)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);
                consulta.Parameters.AddWithValue("@nombre_us", nombre_us);
                consulta.Parameters.AddWithValue("@telefono", telefono);

                consulta.ExecuteNonQuery();
                conexion.Close();
                return "Registro finalizado";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
        public DataTable getClientesPorId(int identifi)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM clientes where identifi = '" + identifi + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getMascotasPorId(int codigo_identif)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascotas where codigo_identif = '" + codigo_identif + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public int buscadorCliente(String dni)
        {
            int resul;
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT identifi FROM clientes WHERE dni = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                MySqlDataReader resultado = consulta.ExecuteReader();
                resultado.Read();
                return resul = resultado.GetInt32("identifi");
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

    }
}

