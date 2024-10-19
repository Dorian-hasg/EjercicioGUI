using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Activa el Timer
            timer1.Interval = 1000; // Intervalo de 1 segundo
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualiza la etiqueta con la hora y fecha actuales
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss"); // Hora con segundos
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha formato DD/MM/AAAA
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
