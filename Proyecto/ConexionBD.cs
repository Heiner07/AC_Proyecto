using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
    class ConexionBD
    {
        private readonly String cadenaConexion = "server=.\\SQLEXPRESS; database=JPS_Loteria_Chances;Trusted_Connection=True;";

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
            List<Premio> premios;
            
            try
            {
                premios = nuevoSorteo.PlanPremios.Premios;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("InsertarSorteo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = nuevoSorteo.NumeroSorteo;
                cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = nuevoSorteo.TipoSorteo;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = nuevoSorteo.Fecha;
                cmd.Parameters.Add("@CantidadFracciones", SqlDbType.Int).Value = nuevoSorteo.CantidadFracciones;
                cmd.Parameters.Add("@PrecioFraccion", SqlDbType.Int).Value = nuevoSorteo.PrecioFraccion;
                cmd.Parameters.Add("@Leyenda", SqlDbType.NVarChar).Value = nuevoSorteo.LeyendaBillete;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoSorteo.Estado;
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
                        cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = premio.MontoPremio;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = premio.CantidadPremio;
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
                        IdSorteo = (int)lectorDatos[0],
                        NumeroSorteo = (int)lectorDatos[1],
                        TipoSorteo = (String)lectorDatos[2],
                        Fecha = (DateTime)lectorDatos[3],
                        CantidadFracciones = (int)lectorDatos[4],
                        PrecioFraccion = (int)lectorDatos[5],
                        LeyendaBillete = (String)lectorDatos[6],
                        Estado = (Boolean)lectorDatos[7],
                        PlanPremios = new PlanPremios()
                        {
                            IdSorteo = (int)lectorDatos[0],
                            Premios = premiosDelPlan,
                            Resultados = resultadosSorteo
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
                cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.IdSorteo;
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
            List<Premio> premios;
            premios = sorteo.PlanPremios.Premios;
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ActualizarSorteo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = sorteo.TipoSorteo;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = sorteo.Fecha;
                cmd.Parameters.Add("@Numero", SqlDbType.Int).Value = sorteo.NumeroSorteo;
                cmd.Parameters.Add("@CantidadFracciones", SqlDbType.Int).Value = sorteo.CantidadFracciones;
                cmd.Parameters.Add("@PrecioFraccion", SqlDbType.Int).Value = sorteo.PrecioFraccion;
                cmd.Parameters.Add("@Leyenda", SqlDbType.NVarChar).Value = sorteo.LeyendaBillete;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sorteo.IdSorteo;
                cmd.ExecuteNonQuery();
                conexion.Close();
                conexion.Open();
                cmd = new SqlCommand("EliminarPlanDePremios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.IdSorteo;
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
                        cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.IdSorteo;
                        cmd.Parameters.Add("@Monto", SqlDbType.Int).Value = premio.MontoPremio;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = premio.CantidadPremio;
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
            List<Resultado> resultados = sorteo.PlanPremios.Resultados;
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
                    cmd.Parameters.Add("@IdSorteo", SqlDbType.Int).Value = sorteo.IdSorteo;
                    cmd.Parameters.Add("@MontoGanado", SqlDbType.Int).Value = resultado.MontoGanado;
                    cmd.Parameters.Add("@NumeroGanador", SqlDbType.Int).Value = resultado.NumeroGanador;
                    cmd.Parameters.Add("@SerieGanadora", SqlDbType.Int).Value = resultado.SerieGanadora;
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
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sorteo.IdSorteo;
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
            List<Resultado> resultados1 = new List<Resultado>();
            SqlConnection conexion1 = new SqlConnection(cadenaConexion);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Top5NumerosConPrimerPremio", conexion1)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion1.Open();
                SqlDataReader lectorDatos1 = cmd1.ExecuteReader();
                while (lectorDatos1.Read())
                {
                    resultados1.Add(new Resultado(lectorDatos1.GetInt32(0), 100, lectorDatos1.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados1;
            }
            finally
            {
                conexion1.Close();
            }
            return resultados1;
        }

        public List<Resultado> ObtenerTopNumerosMasDineroRepartido()
        {
            List<Resultado> resultados2 = new List<Resultado>();
            SqlConnection conexion2 = new SqlConnection(cadenaConexion);
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Top5NumerosMasDineroRepartido", conexion2)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion2.Open();
                SqlDataReader lectorDatos2 = cmd2.ExecuteReader();
                while (lectorDatos2.Read())
                {
                    resultados2.Add(new Resultado(lectorDatos2.GetInt32(0), 100, lectorDatos2.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados2;
            }
            finally
            {
                conexion2.Close();
            }
            return resultados2;
        }

        public List<Resultado> ObtenerTopFiltros(String procedimiento,String filtro)
        {
            List<Resultado> resultados3 = new List<Resultado>();
            SqlConnection conexion3 = new SqlConnection(cadenaConexion);
            SqlCommand cmdResultados3 = new SqlCommand(procedimiento, conexion3)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                conexion3.Open();
                cmdResultados3.Parameters.Add("@Tipo", SqlDbType.NVarChar).Value = filtro;
                SqlDataReader lectorResultados3 = cmdResultados3.ExecuteReader();
                while (lectorResultados3.Read())
                {
                    resultados3.Add(new Resultado((int)lectorResultados3[0], 100, (int)lectorResultados3[1]));
                }
                lectorResultados3.Close();
                return resultados3;
            }
            catch (Exception)
            {
                return resultados3;
            }
            finally
            {
                conexion3.Close();
            }
        }

        public List<Resultado> ObtenerTopNumerosMasJugados()
        {
            List<Resultado> resultados4 = new List<Resultado>();
            SqlConnection conexion4 = new SqlConnection(cadenaConexion);
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM Top10NumerosMasJugados", conexion4)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion4.Open();
                SqlDataReader lectorDatos4 = cmd4.ExecuteReader();
                while (lectorDatos4.Read())
                {
                    resultados4.Add(new Resultado(lectorDatos4.GetInt32(0), 100, lectorDatos4.GetInt32(1)));
                }
            }
            catch (Exception)
            {
                return resultados4;
            }
            finally
            {
                conexion4.Close();
            }
            return resultados4;
        }

        public List<PorcentajeNumeros> ObtenerPorcentajeAparicionNumeros()
        {
            List<PorcentajeNumeros> resultados = new List<PorcentajeNumeros>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PorcentajeAparicionNumeros", conexion)
            {
                CommandType = CommandType.Text
            };
            try
            {
                conexion.Open();
                SqlDataReader lectorDatos = cmd.ExecuteReader();
                while (lectorDatos.Read())
                {
                    
                    String porcentaje = lectorDatos.GetString(1);
                    resultados.Add(new PorcentajeNumeros() { Numero = lectorDatos.GetInt32(0), Porcentaje = porcentaje});
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
