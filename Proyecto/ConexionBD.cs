using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    class ConexionBD
    {
        String cadenaConexion = "server=LUISARAYA-ENVY1\\SQLEXPRESS; database=JPS_Loteria_Chances;Trusted_Connection=True;";

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */
        public Usuario iniciarSesion(String nombre, String contrasenia) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataReader obtenerDatos;
            int rol = -1; ;
            String consultaUsuario= "select Rol from Usuarios where NombreUsuario=@nombre and Contrasenia=@contrasenia";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consultaUsuario, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            obtenerDatos = cmd.ExecuteReader();
            while (obtenerDatos.Read())
            {
                rol = Convert.ToInt32(obtenerDatos.GetValue(0));
            }
            if (!obtenerDatos.HasRows)
            {
                rol = -1;
            }
            obtenerDatos.Close();
            cmd.Dispose();
            conexion.Close();
           
            return new Usuario(nombre,rol);
        }

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */

        public Boolean insertarSorteo(Sorteo nuevoSorteo) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("InsertarSorteo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = nuevoSorteo.obtenerNumeroSorteo();
            cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = nuevoSorteo.obtenerTipoSorteo();
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = nuevoSorteo.obtenerFecha();
            cmd.Parameters.Add("@CantidadFracciones", SqlDbType.Int).Value = nuevoSorteo.obtenerCantidadFracciones();
            cmd.Parameters.Add("@PrecioFraccion", SqlDbType.Int).Value = nuevoSorteo.obtenerPrecioFraccion();
            cmd.Parameters.Add("@Leyenda", SqlDbType.NVarChar).Value = nuevoSorteo.obtenerLeyenda();
            cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoSorteo.obtenerEstado();
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

            
        }



    }
}
