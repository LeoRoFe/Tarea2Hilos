using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2Hilos.Clases;

namespace Tarea2Hilos
{
    public partial class TransaccionForm : Form
    {
        private Transaccion[] transacciones; //arreglo global.
        private Transaccion[] transaccionesManuales;
        private Transaccion[] transaccionesAutomaticas;
        private double MontoTotal = 5000000;//Cuenta 
        private Semaphore semaforo;

        public TransaccionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Comment como subir a github
        }


        private void B_AgregaTransaccion_Click(object sender, EventArgs e)
        {

        }

        private void B_AbrirArchivo_Click(object sender, EventArgs e)
        {
            Archivos archivoNuevo = new Archivos();
            transacciones = archivoNuevo.ObtenerDatos();
            if(transacciones == null)
            {
                MessageBox.Show("El archivo se encuentra vacío o dañado.");
            }
            transaccionesManuales = transacciones.Where(x => x.transmision.Equals("M")).ToArray();
            transaccionesAutomaticas = transacciones.Where(x => x.transmision.Equals("A")).ToArray();

            DGV_Automaticos.DataSource = transaccionesAutomaticas;
            DGV_Manuales.DataSource = transaccionesManuales;
        }
        
        private void ComenzarPosteo(){
            semaforo = new Semaphore(0, 2);
            //Instancia hilos
            Thread nuevoHiloA = new Thread(new ParameterizedThreadStart(EjecutarTransacciones));
            Thread nuevoHiloM = new Thread(new ParameterizedThreadStart(Worker));
            //inicia hilos
            nuevoHiloA.Start(transaccionesAutomaticas);
            nuevoHiloM.Start(transaccionesManuales);
            //Espera q empicen
            Thread.Sleep(500);
            semaforo.Release(2);
             
        }
        
        private EjecutarTransacciones(Transaccion[] listaTransacciones){
            semaforo.WaitOne();
            //codigo q actualiza el total
            Thread.Sleep(5000); //Espera 5 seg
        
        }
    }
}
