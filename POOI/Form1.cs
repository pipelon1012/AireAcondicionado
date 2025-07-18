using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POOI
{
    public partial class Form1 : Form
    {
        AireAcondicionado aire1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 245, 245);


            // Botón Aumentar
            btnAumentarGrados.BackColor = Color.White; // Fondo blanco limpio
            btnAumentarGrados.ForeColor = Color.Black; // Texto negro
            btnAumentarGrados.FlatStyle = FlatStyle.Flat; // Borde minimalista
            btnAumentarGrados.FlatAppearance.BorderColor = Color.Gray; // Borde gris suave
            btnAumentarGrados.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            // Botón Disminuir
            btnDisminuirGrados.BackColor = Color.White;
            btnDisminuirGrados.ForeColor = Color.Black;
            btnDisminuirGrados.FlatStyle = FlatStyle.Flat;
            btnDisminuirGrados.FlatAppearance.BorderColor = Color.Gray;
            btnDisminuirGrados.Font = new Font("Segoe UI", 8, FontStyle.Regular);


            // Opcional: si tienes TextBox
            txtGrados.BackColor = Color.WhiteSmoke;
            txtGrados.ForeColor = Color.Black;
            txtGrados.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            // Si tienes más labels, repite o ponles un nombre común
            lblTemperatura.ForeColor = Color.Black;
            lblTemperatura.Font = new Font("Segoe UI", 8, FontStyle.Regular);


            /*Creamos la variable aire1 del tipo de objeto AireAcondicionado
             *le signamos el valor a la variable aire1 que seria new AireAcondicionado
             *ahi creamos el objeto*/
            aire1 = new AireAcondicionado("xyz", "2023AC11012K","verde",110,12000,25);//Metodo Constructor
            /*
            AireAcondicionado aire2 = new AireAcondicionado();
           

            aire1.setMarca("xyz");
            aire1.setModelo("2023AC11012K");
            

            string MarcaAire = aire1.getMarca();
            string ModeloAire = aire1.getModelo();

            MessageBox.Show("La marca del aire es: " + MarcaAire);
            MessageBox.Show("El modelo del aire es: " + ModeloAire);
            

            aire1.bajarTemperatura();
            */

            MessageBox.Show("La temperatura actual del aire acondicionado es "+ aire1.darTemperaturaActual().ToString()+" grados");
            
        }

        private void btnAumentarGrados_Click(object sender, EventArgs e)
        {
            int grados = int.Parse(txtGrados.Text);
            aire1.subirTemperatura(grados);

            MessageBox.Show("La temperatura del aire es " + aire1.getTemperatura() + " grados.");
        }

        private void btnDisminuirGrados_Click(object sender, EventArgs e)
        {
            int grados = int.Parse(txtGrados.Text);
            aire1.bajarTemperatura(grados);

            MessageBox.Show("La temperatura del aire es " + aire1.getTemperatura() + " grados.");
        }
    }
}
