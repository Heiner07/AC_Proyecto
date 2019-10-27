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
        private String cadenaConexion = "server=.\\SQLEXPRESS; database=JPS_Loteria_Chances;Trusted_Connection=True;";

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */
        public Usuario IniciarSesion(String nombre, String contrasenia) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataReader obtenerDatos;
            Usuario usuario = new Usuario();
            int rol = -1;
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
            usuario.establecerNombreUsuario(nombre);
            usuario.establecerRol(rol);
            return usuario;
        }

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */

        public Boolean InsertarSorteo(Sorteo nuevoSorteo) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("InsertarSorteo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = nuevoSorteo.ObtenerNumeroSorteo;
            cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = nuevoSorteo.ObtenerTipoSorteo;
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = nuevoSorteo.ObtenerFecha;
            cmd.Parameters.Add("@CantidadFracciones", SqlDbType.Int).Value = nuevoSorteo.ObtenerCantidadFracciones;
            cmd.Parameters.Add("@PrecioFraccion", SqlDbType.Int).Value = nuevoSorteo.ObtenerPrecioFraccion;
            cmd.Parameters.Add("@Leyenda", SqlDbType.NVarChar).Value = nuevoSorteo.ObtenerLeyenda;
            cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoSorteo.ObtenerEstado;
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

        public List<Sorteo> ObtenerSorteos()
        {
            List<Sorteo> sorteos = new List<Sorteo>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ObtenerSorteos", conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                conexion.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                Sorteo sorteo;
                while (lectorDatos.Read())
                {
                    sorteo = new Sorteo()
                    {
                        idSorteo = (int)lectorDatos[0],
                        numeroSorteo = (int)lectorDatos[1],
                        tipoSorteo = (String)lectorDatos[2],
                        fecha = (DateTime)lectorDatos[3],
                        cantidadFracciones = (int)lectorDatos[4],
                        precioFraccion = (int)lectorDatos[5],
                        leyendaBillete = (String)lectorDatos[6],
                        estado = (Boolean)lectorDatos[7]
                    };
                    sorteos.Add(sorteo);
                }

            }
            catch (Exception)
            {
                // Representa error de conexión
                sorteos = null;
            }
            finally
            {
                conexion.Close();
            }
            return sorteos;
        }

    }
}
