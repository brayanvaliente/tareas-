using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             int a, b, c;
             string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a + b;
            datos = "resultado " + c.ToString();
            label3.Text = datos;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a - b;
            datos = "resultado " + c.ToString();
            label3.Text = datos;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a * b;
            datos = "resultado " + c.ToString();
            label3.Text = datos;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string datos;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a / b;
            datos = "resultado " + c.ToString();
            label3.Text = datos;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
