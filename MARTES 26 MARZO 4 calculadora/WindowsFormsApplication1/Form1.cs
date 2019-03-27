using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;
namespace WindowsFormsApplication1
{
    public partial class frmOperaciones : Form
    {
        operaciones ingreso;
        restas objresta;
        multiplcaciones objmult;
        divisiones objdiv;
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso = new operaciones();
            ingreso.Val1 = double.Parse(val1.Text);
            ingreso.Val2 = double.Parse(val2.Text);
            resultado.Text = ingreso.calcular().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void resta_Click(object sender, EventArgs e)
        {
            objresta = new restas();
            objresta.R1 = double.Parse(val1.Text);
            objresta.R2 = double.Parse(val2.Text);
            resultado.Text = objresta.calcular().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            objmult = new multiplcaciones();
            objmult.M1 = double.Parse(val1.Text);
            objmult.M2 = double.Parse(val2.Text);
            resultado.Text = objmult.calcular().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objdiv = new divisiones();
            objdiv.D1 = double.Parse(val1.Text);
            objdiv.D2 = double.Parse(val2.Text);
            resultado.Text = objdiv.calcular().ToString();
        }
    }
}
