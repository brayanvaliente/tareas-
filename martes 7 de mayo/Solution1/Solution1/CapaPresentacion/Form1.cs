using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        ManttVendor neg = new ManttVendor();
        ManttVendor enlc = new ManttVendor();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            neg.CodVendedor = textBox1.Text;
            neg.NombreVendeor = textBox2.Text;
            neg.insertVendedor();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            neg.CodVendedor = textBox1.Text;
            neg.NombreVendeor = textBox2.Text;
            neg.actVendedor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            neg.CodVendedor = textBox1.Text;
            neg.NombreVendeor = textBox2.Text;
            neg.deleteVendor();
        }
    }
}
