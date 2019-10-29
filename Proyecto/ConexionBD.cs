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
            return new Usuario(nombre,rol);
        }

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */

        public Boolean InsertarSorteo(Sorteo nuevoSorteo) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            List <Premio> premios = new List<Premio>();
            premios = nuevoSorteo.ObenerPlanPremios.ObtenerPremios;
            try
            {
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
                cmd.ExecuteNonQuery();
                if (premios != null)
                {
                    cmd = new SqlCommand("SELECT MAX(Id) FROM ObtenerSorteos", conexion);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader lectorDatos = cmd.ExecuteReader();
                    int idSorteo = 0;
                    while (lectorDatos.Read())
                    {
                        idSorteo = (int)lectorDatos[0];
                    }
                    conexion.Close();
                    conexion.Open();
                    cmd = new SqlCommand("InsertarPlanDePremios", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    foreach (Premio premio in premios) {
                        cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = idSorteo;
                        cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = premio.ObtenerMonto;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = premio.ObtenerCantidad;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    conexion.Close();
                    

                }
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
            List<Premio> premiosDelPlan;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlConnection conexion2 = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ObtenerSorteos", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                conexion2.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                Sorteo sorteo;
                SqlCommand cmdPremios;
                SqlDataReader lectorPremios = null;
                while (lectorDatos.Read())
                {
                    // Preparo las variables para obtener los premios del sorteo
                    premiosDelPlan = new List<Premio>();
                    cmdPremios = new SqlCommand("ObtenerPlanDePremios", conexion2)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agrego el id del sorteo como parámetro para el procedimiento
                    cmdPremios.Parameters.Clear();
                    cmdPremios.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = (int)lectorDatos[0];// IdSorteo
                    // Ejecuto y obtengo los premios
                    lectorPremios = cmdPremios.ExecuteReader();
                    while (lectorPremios.Read())
                    {
                        premiosDelPlan.Add(new Premio((int)lectorPremios[2], (int)lectorPremios[3]));
                    }
                    lectorPremios.Close();

                    sorteo = new Sorteo()
                    {
                        idSorteo = (int)lectorDatos[0],
                        numeroSorteo = (int)lectorDatos[1],
                        tipoSorteo = (String)lectorDatos[2],
                        fecha = (DateTime)lectorDatos[3],
                        cantidadFracciones = (int)lectorDatos[4],
                        precioFraccion = (int)lectorDatos[5],
                        leyendaBillete = (String)lectorDatos[6],
                        estado = (Boolean)lectorDatos[7],
                        planPremios = new PlanPremios()
                        {
                            idSorteo = (int)lectorDatos[0],
                            premios = premiosDelPlan
                        }
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
                conexion2.Close();
            }
            return sorteos;
        }

        public Boolean EliminarSorteo(Sorteo sorteo) {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("EliminarSorteo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.ObtenerIdSorteo;       
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
