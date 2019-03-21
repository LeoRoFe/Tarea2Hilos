using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2Hilos.Clases
{
    class Archivos
    {
        public Transaccion[] ObtenerDatos()
        {

            string linea;
            OpenFileDialog abrirArchivo = new OpenFileDialog();


            DialogResult resultado = abrirArchivo.ShowDialog(); // Respuesta de ventana.
            if (resultado == DialogResult.OK) // Test result.
            {
                try
                {
                    Transaccion[] arreglo = new Transaccion[100];
                    int contador = 0;

                    StreamReader archivoTransacciones = new StreamReader(abrirArchivo.FileName); //lee el archivo.
                    while ((linea = archivoTransacciones.ReadLine()) != null)
                    {
                        if (contador > 0)
                        {
                            string[] lineaDividida = linea.Split(';');
                            arreglo[contador] = new Transaccion(lineaDividida[0], lineaDividida[1], lineaDividida[2], Convert.ToDouble(lineaDividida[3]));
                        }
                        contador++;
                    }
                    return arreglo.Where(x => x != null).ToArray(); // Limpia el arreglo de valores nulos.
                }
                catch (FileNotFoundException ex)
                {
                    return null;
                }
                catch (IOException ex)
                {
                    return null;
                }
                catch (FormatException ex)
                {
                    return null;
                }


            }
            else
            {
                return null;
            }




        }
    }
}
