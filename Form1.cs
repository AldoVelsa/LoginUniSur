using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUniSur
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = tbusuario.Text;
            string password = tbcontrasena.Text;
            intentos = 0;
            if (this.tbusuario.Text == "horchato" && this.tbcontrasena.Text == "velsa123")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\aldoy\source\repos\LoginUniSur\DesbloqueoUniSur");
                MessageBox.Show("bienvenido");
            }
            else if (intentos <= 3 && intentos > 0)
            {
                avisos.Text = "te queda" + Convert.ToString(intentos) + "intentos mas";
                intentos--;
            }
            else
            {
                MessageBox.Show("usuario y contraseña incorrectos");
                intentos++;
                Application.Exit();
            }


        }
    }
}
