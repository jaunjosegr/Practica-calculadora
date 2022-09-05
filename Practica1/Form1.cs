using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear objeto  
            /*clsuma osuma = new clsuma(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text)); textBox3.Text = osuma.sumar()
                .ToString();*/
            clsuma osuma = new clsuma();

            // EL valor de la textbox1 lo convierte a entero y lo asigna a la propiedad N2
            osuma.N1 = double.Parse(textBox1.Text);
            osuma.N2 = double.Parse(textBox2.Text);

            //se va al metodo clsuma, hace la operacion,
            //la convierte a texto y se lo asigna a la caja de texto 3
            textBox3.Text = osuma.sumar().ToString();

            //copea el valor de N2, lo convierte a texto y lo asigna la texbox 4
            textBox4.Text = osuma.N2.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsuma orestar = new clsuma(int.Parse(textBox1.Text),
            int.Parse(textBox2.Text)); textBox3.Text = orestar.restar().
            ToString();
            textBox4.Text = orestar.N2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clsuma omultip = new clsuma (int.Parse(textBox1.Text),
            int.Parse(textBox2.Text)); textBox3.Text = omultip.multiplicar()
            .ToString();

            textBox4.Text = omultip.N2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsuma odividr = new clsuma(Convert.ToDouble(textBox1.Text),
           Convert.ToDouble(textBox2.Text)); textBox3.Text = odividr.dividir().
            ToString();

            textBox4.Text = odividr.N2.ToString();
        }
    }
}
