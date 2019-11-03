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
        public Usuario IniciarSesion(String nombre, String contrasenia)
        {
            Usuario usuario = null;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataReader obtenerDatos = null;
            SqlCommand cmd = null;
            int rol = -1;
            String consultaUsuario = "select Rol from Usuarios where NombreUsuario=@nombre and Contrasenia=@contrasenia";
            try
            {
                conexion.Open();
                cmd = new SqlCommand(consultaUsuario, conexion);
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
                usuario = new Usuario(nombre, rol);
            }
            catch (Exception)
            {
                // Representa error de conexión
                usuario = null;
            }
            finally
            {
                if (obtenerDatos != null)
                {
                    obtenerDatos.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                conexion.Close();
            }
            return usuario;
        }

        /*
         * E: El nombre y la contrasenia del usuario/admin
         * S: El objeto usuario con los datos correspondientes.
         * R: Debe recibir solo dos parámetros
         */
        public Boolean InsertarSorteo(Sorteo nuevoSorteo)
        {
            Boolean retorno = true;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            List<Premio> premios = new List<Premio>();
            premios = nuevoSorteo.ObtenerPlanPremios.ObtenerPremios;
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
                    foreach (Premio premio in premios)
                    {
                        cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = idSorteo;
                        cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = premio.ObtenerMonto;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = premio.ObtenerCantidad;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public List<Sorteo> ObtenerSorteos()
        {
            List<Sorteo> sorteos = new List<Sorteo>();
            List<Premio> premiosDelPlan;
            List<Resultado> resultadosSorteo;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlConnection conexion2 = new SqlConnection(cadenaConexion);
            SqlConnection conexion3 = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM ObtenerSorteos", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                conexion2.Open();
                conexion3.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                Sorteo sorteo;
                SqlCommand cmdPremios, cmdResultados;
                SqlDataReader lectorPremios = null, lectorResultados = null;
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

                    // Preparo las variables para obtener los resultados del sorteo
                    resultadosSorteo = new List<Resultado>();
                    cmdResultados = new SqlCommand("ObtenerResultados", conexion3)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Agrego el id del sorteo como parámetro para el procedimiento
                    cmdResultados.Parameters.Clear();
                    cmdResultados.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = (int)lectorDatos[0];// IdSorteo
                    // Ejecuto y obtengo los resultados
                    lectorResultados = cmdResultados.ExecuteReader();
                    while (lectorResultados.Read())
                    {
                        resultadosSorteo.Add(new Resultado((int)lectorResultados[1],
                            (int)lectorResultados[2], (int)lectorResultados[0]));
                    }
                    lectorResultados.Close();

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
                            premios = premiosDelPlan,
                            resultados = resultadosSorteo
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
                conexion3.Close();
            }
            return sorteos;
        }

        public Boolean EliminarSorteo(Sorteo sorteo)
        {
            Boolean retorno = true;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd;
            try
            {
                conexion.Open();
                cmd = new SqlCommand("EliminarSorteo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.ObtenerIdSorteo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public Boolean ModificarSorteo(Sorteo sorteo)
        {
            Boolean retorno = true;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            List<Premio> premios = new List<Premio>();
            premios = sorteo.ObtenerPlanPremios.ObtenerPremios;
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ActualizarSorteo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = sorteo.ObtenerTipoSorteo;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = sorteo.ObtenerFecha;
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = sorteo.ObtenerNumeroSorteo;
                cmd.Parameters.Add("@CantidadFracciones", SqlDbType.Int).Value = sorteo.ObtenerCantidadFracciones;
                cmd.Parameters.Add("@PrecioFraccion", SqlDbType.Int).Value = sorteo.ObtenerPrecioFraccion;
                cmd.Parameters.Add("@Leyenda", SqlDbType.NVarChar).Value = sorteo.ObtenerLeyenda;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sorteo.ObtenerIdSorteo;
                cmd.ExecuteNonQuery();
                conexion.Close();
                conexion.Open();
                cmd = new SqlCommand("EliminarPlanDePremios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.ObtenerIdSorteo;
                cmd.ExecuteNonQuery();
                if (premios != null)
                {
                    conexion.Close();
                    conexion.Open();
                    cmd = new SqlCommand("InsertarPlanDePremios", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    foreach (Premio premio in premios)
                    {
                        cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.ObtenerIdSorteo;
                        cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = premio.ObtenerMonto;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = premio.ObtenerCantidad;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public Boolean InsertarResultadosSorteos(Sorteo sorteo)
        {
            Boolean retorno = true;
            List<Resultado> resultados = sorteo.planPremios.resultados;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("InsertarResultado", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                conexion.Open();
                foreach (Resultado resultado in resultados)
                {
                    cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.idSorteo;
                    cmd.Parameters.Add("@MontoGanado", SqlDbType.Int).Value = resultado.montoGanado;
                    cmd.Parameters.Add("@NumeroGanador", SqlDbType.Int).Value = resultado.numeroGanador;
                    cmd.Parameters.Add("@SerieGanadora", SqlDbType.Int).Value = resultado.serieGanadora;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public Boolean EstablecerSorteoJugado(Sorteo sorteo)
        {
            Boolean retorno = true;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("EstablecerSorteoJugado", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                conexion.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sorteo.idSorteo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public List<Resultado> ObtenerTopNumerosPrimerPremio()
        {
            List<Resultado> resultados = new List<Resultado>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Top5NumerosConPrimerPremio", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                while (lectorDatos.Read())
                {
                    resultados.Add(new Resultado(lectorDatos.GetInt32(0), 100, lectorDatos.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados;
            }
            finally
            {
                conexion.Close();
            }
            return resultados;
        }



        public List<Resultado> ObtenerTopNumerosMasDineroRepartido()
        {
            List<Resultado> resultados = new List<Resultado>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Top5NumerosMasDineroRepartido", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                while (lectorDatos.Read())
                {
                    resultados.Add(new Resultado(lectorDatos.GetInt32(0), 100, lectorDatos.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados;
            }
            finally
            {
                conexion.Close();
            }
            return resultados;
        }
        public List<Resultado> ObtenerTopFiltros(String procedimiento,String filtro)
        {
            List<Resultado> resultados = new List<Resultado>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdResultados = new SqlCommand(procedimiento, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                conexion.Open();
                cmdResultados.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = filtro;
                SqlDataReader lectorResultados = cmdResultados.ExecuteReader();
                while (lectorResultados.Read())
                {
                    resultados.Add(new Resultado((int)lectorResultados[0], 100, (int)lectorResultados[1]));
                }
                lectorResultados.Close();
                return resultados;
            }
            catch (Exception)
            {
                return resultados;
            }
            finally
            {
                conexion.Close();
            }




        }





        public List<Resultado> ObtenerTopNumerosMasJugados()
        {
            List<Resultado> resultados = new List<Resultado>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Top10NumerosMasJugados", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                while (lectorDatos.Read())
                {
                    resultados.Add(new Resultado(lectorDatos.GetInt32(0), 100, lectorDatos.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados;
            }
            finally
            {
                conexion.Close();
            }
            return resultados;
        }



    }


}
