using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sprint8
{
    public partial class Form1 : Form
    {
        double y;
        double contador;

        public Form1()
        {
            InitializeComponent();
            contador = 0;
            y = 0;

            if (File.Exists("simulacio.txt"))
            {
                File.Delete("simulacio.txt");
            }
        }

        private void timerSegundos_Tick(object sender, EventArgs e)
        {

            //Dibujar Grafico
            y = Math.Pow(Math.E, (contador / 100));

            chart1.Series[0].Points.AddXY(contador, y);

            contador++;

            //escribir en txt
            StreamWriter fichero;
            fichero = File.AppendText("simulacio.txt");
            fichero.WriteLine(contador + "|" + y);
            fichero.Close();

            //Escribir columna Izquierda
            if (contador % 25 == 0)
            {
                ListViewItem listaI = new ListViewItem(contador.ToString());
                listaI.SubItems.Add(y.ToString());
                lvIzquierda.Items.Add(listaI);
            }

            //parar contador y escribir en el txt
            if (contador == 1000)
            {
                timerSegundos.Stop();
                string texto = File.ReadAllText("simulacio.txt");
                rtxtbTXT.Text = "Time | Temperatura\n" + texto;
            }
        }
    }
}