using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class SistemaLoteriaChances
    {
        ConexionBD conexionBD = new ConexionBD();
        Usuario usuario;
        List<Sorteo> sorteos = null;

        public Usuario IniciarSesion(String nombre, String contrasenia) {
            this.usuario = conexionBD.IniciarSesion(nombre, contrasenia);
            return usuario;
        }

        public List<Sorteo> ObtenerSorteos()
        {       
            sorteos = conexionBD.ObtenerSorteos();
            return sorteos;
        }

        public Sorteo ObtenerUltimoSorteoTipo(String tipo)
        {
            if (sorteos == null)
            {
                ObtenerSorteos();
            }
            if (sorteos != null)
            {
                Sorteo sorteo;
                int cantidadSorteos = sorteos.Count;
                for (int i = cantidadSorteos-1; i > -1; i--)
                {
                    sorteo = sorteos[i];
                    if (sorteo.estado && sorteo.tipoSorteo.Equals(tipo))
                    {
                        return sorteo;
                    }
                }
            }
            return null;
        }

        public Sorteo ObtenerSorteoSeleccionado(String tipoSorteo, int numeroSorteo)
        {
            if (sorteos != null)
            {
                foreach (Sorteo sorteo in sorteos)
                {
                    if (sorteo.tipoSorteo.Equals(tipoSorteo) && sorteo.ObtenerNumeroSorteo.Equals(numeroSorteo))
                    {
                        return sorteo;
                    }
                }
            }
            return null;
        }

        public Boolean CrearSorteo(Sorteo nuevoSorteo)
        {
            return conexionBD.InsertarSorteo(nuevoSorteo);
        }

        public Boolean EliminarSorteo(Sorteo sorteo) {
            return conexionBD.EliminarSorteo(sorteo);
        }

        public Boolean ModificarSorteo(Sorteo sorteo)
        {
            return conexionBD.ModificarSorteo(sorteo);

        }

        public Boolean JugarSorteo(Sorteo sorteo)
        {
            return conexionBD.InsertarResultadosSorteos(sorteo) &&
                conexionBD.EstablecerSorteoJugado(sorteo);
        }

        public Boolean GenerarReporteResultadosSorteo(Sorteo sorteo)
        {
            Boolean retorno = true;
            // Se establecen las varibales y textos por utilizar en el PDF
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            List<Resultado> resultados = sorteo.planPremios.resultados;
            List<Premio> premios = sorteo.planPremios.premios;
            String tituloDocumento = "Reporte de resultados de sorteo";
            String datosSorteo =
                $"Tipo: {sorteo.tipoSorteo}\n" +
                $"Número: {sorteo.numeroSorteo}\n" +
                $"Realizado: {sorteo.fecha.ToShortDateString()}";
            String tituloTabla = "Resultados:";
            String finalDocumento = $"\n--- Final del documento - " +
                $"Junta de Protección Social - Reporte generado el {DateTime.Now.ToString()} ---";
            Document document = null;
            try
            {
                // Se genera la ruta del archivo pdf: Escritorio + "Resultados - " + tipo + numero + ".pdf"
                String rutaCreacionPDF = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\Resultados - " + sorteo.tipoSorteo + sorteo.numeroSorteo + ".pdf";

                // Se inicializan las variables para manipular el pdf.
                PdfWriter writer = new PdfWriter(rutaCreacionPDF);
                PdfDocument pdf = new PdfDocument(writer);
                document = new Document(pdf);
                
                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);// Fuente en negrita(bold)
                // Se crea el logo del documento.
                Image logo = new Image(ImageDataFactory.Create(
                    (byte[])converter.ConvertTo(Properties.Resources.LogoHorizontalJPS, typeof(byte[]))));
                logo.SetWidth(170);
                logo.SetHeight(80);
                logo.SetFixedPosition(400, 730);// Se establece la posición fija dentro de la página.

                // Se crea la tabla que contiene los resultados del sorteo.
                Table table = new Table(new float[] { 1, 1, 1 });
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Serie").SetFont(font)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Número").SetFont(font)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Monto").SetFont(font)));
                Paragraph parrafoSerie, parrafoNumero, parrafoMonto;
                // Se agregan los resutados a la tabla
                foreach (Resultado resultado in resultados)
                {
                    parrafoSerie = new Paragraph(resultado.serieGanadora.ToString());
                    parrafoNumero = new Paragraph(resultado.numeroGanador.ToString());
                    parrafoMonto = new Paragraph(resultado.montoGanado.ToString());
                    if (premios[0].montoPremio==resultado.montoGanado ||
                        premios[1].montoPremio == resultado.montoGanado ||
                        premios[2].montoPremio == resultado.montoGanado)
                    {
                        parrafoSerie.SetFont(font);
                        parrafoNumero.SetFont(font);
                        parrafoMonto.SetFont(font);
                    }
                    table.AddCell(new Cell().Add(parrafoSerie));
                    table.AddCell(new Cell().Add(parrafoNumero));
                    table.AddCell(new Cell().Add(parrafoMonto));
                }

                // Se agregan todos los componentes del archivo pdf
                document.Add(logo);
                document.Add(new Paragraph(tituloDocumento).SetFont(font).SetFontSize(14));
                document.Add(new Paragraph(datosSorteo));
                document.Add(new Paragraph(tituloTabla).SetFont(font));
                document.Add(table);
                document.Add(new Paragraph(finalDocumento).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER));
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                // Se cierra el archivo
                if (document != null)
                {
                    document.Close();
                }
            }
            return retorno;
        }

        public Boolean GenerarReportePlanPremiosSorteo(Sorteo sorteo)
        {
            Boolean retorno = true;
            // Se establecen las varibales y textos por utilizar en el PDF
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            List<Premio> premios = sorteo.planPremios.premios;
            String tituloDocumento = "Reporte de plan de premios de sorteo";
            String datosSorteo =
                $"Tipo: {sorteo.tipoSorteo}\n" +
                $"Número: {sorteo.numeroSorteo}\n" +
                $"Realizado: {sorteo.fecha.ToShortDateString()}";
            String tituloTabla = "Plan de premios:";
            String finalDocumento = $"\n--- Final del documento - " +
                $"Junta de Protección Social - Reporte generado el {DateTime.Now.ToString()} ---";
            Document document = null;
            try
            {
                // Se genera la ruta del archivo pdf: Escritorio + "Resultados - " + tipo + numero + ".pdf"
                String rutaCreacionPDF = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\PlanDePremios - " + sorteo.tipoSorteo + sorteo.numeroSorteo + ".pdf";

                // Se inicializan las variables para manipular el pdf.
                PdfWriter writer = new PdfWriter(rutaCreacionPDF);
                PdfDocument pdf = new PdfDocument(writer);
                document = new Document(pdf);

                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);// Fuente en negrita(bold)
                // Se crea el logo del documento.
                Image logo = new Image(ImageDataFactory.Create(
                    (byte[])converter.ConvertTo(Properties.Resources.LogoHorizontalJPS, typeof(byte[]))));
                logo.SetWidth(170);
                logo.SetHeight(80);
                logo.SetFixedPosition(400, 730);// Se establece la posición fija dentro de la página.

                // Se crea la tabla que contiene los resultados del sorteo.
                Table table = new Table(new float[] { 1, 1 });
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Premio").SetFont(font)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Cantidad").SetFont(font)));
                Paragraph parrafoPremio, parrafoCantidad;
                int indice = 0;
                // Se agregan los resutados a la tabla
                foreach (Premio premio in premios)
                {
                    parrafoPremio = new Paragraph(premio.montoPremio.ToString());
                    parrafoCantidad = new Paragraph(premio.cantidadPremio.ToString());
                    if (indice < 3)
                    {
                        parrafoPremio.SetFont(font);
                        parrafoCantidad.SetFont(font);
                    }
                    table.AddCell(new Cell().Add(parrafoPremio));
                    table.AddCell(new Cell().Add(parrafoCantidad));

                    indice++;
                }

                // Se agregan todos los componentes del archivo pdf
                document.Add(logo);
                document.Add(new Paragraph(tituloDocumento).SetFont(font).SetFontSize(14));
                document.Add(new Paragraph(datosSorteo));
                document.Add(new Paragraph(tituloTabla).SetFont(font));
                document.Add(table);
                document.Add(new Paragraph(finalDocumento).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER));
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                // Se cierra el archivo
                if (document != null)
                {
                    document.Close();
                }
            }
            return retorno;
        }


        public List<Resultado> ObtenerTopNumerosPrimerPremio(String filtro) {
            if (filtro.Equals(""))
            {
                return conexionBD.ObtenerTopNumerosPrimerPremio();
            }
            else
            {
                return conexionBD.ObtenerTopFiltros("Top5NumerosConPrimerPremioFiltro", filtro);
            }
        }

        public List<Resultado> ObtenerTopNumerosMasDineroRepartido(String filtro)
        {
            if (filtro.Equals(""))
            {
                return conexionBD.ObtenerTopNumerosMasDineroRepartido();
            }
            else {
                return conexionBD.ObtenerTopFiltros("Top5NumerosMasDineroRepartidoFiltro",filtro);
            }
            
        }

        public List<Resultado> ObtenerTopNumerosMasJugados(String filtro)
        {
            if (filtro.Equals(""))
            {
                return conexionBD.ObtenerTopNumerosMasJugados();
            }
            else {
                return conexionBD.ObtenerTopFiltros("Top10NumerosMasJugadosFiltro", filtro);
            }

        }


        public List<PorcentajeNumeros> ObtenerPorcentajeAparicionNumeros() {
            return conexionBD.ObtenerPorcentajeAparicionNumeros();
        }
    }
}
