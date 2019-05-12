using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadesDataSet.tipocarrera' Puede moverla o quitarla según sea necesario.
            this.tipocarreraTableAdapter.Fill(this.universidadesDataSet.tipocarrera);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion c = new conexion();
            c.insertar(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,textBox4.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipocarreraTableAdapter.FillBy(this.universidadesDataSet.tipocarrera);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
