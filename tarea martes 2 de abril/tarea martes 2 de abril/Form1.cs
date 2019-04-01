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
namespace tarea_martes_2_de_abril
{
    public partial class Form1 : Form
    {
        multiplcaciones obj3;
        restas obj2;
        divisiones obj4;
        suma obj1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true) {
                obj1 = new suma();
                obj1.S1 = double.Parse(val1.Text);
                obj1.S2 = double.Parse(val2.Text);
                resultado.Text = obj1.calcular().ToString();
               
            }
            else if (this.checkBox2.Checked == true)
            {
                obj2 = new restas();
                obj2.R1 = double.Parse(val1.Text);
                obj2.R2 = double.Parse(val2.Text);
                resultado.Text = obj2.calcular().ToString();

            }

            else if (this.checkBox3.Checked == true)
            {
                obj3 = new multiplcaciones();
                obj3.M1 = double.Parse(val1.Text);
                obj3.M2 = double.Parse(val2.Text);
                resultado.Text = obj1.calcular().ToString();

            }
            else if (this.checkBox4.Checked == true)
            {
                obj4 = new divisiones();
                obj4.D1 = double.Parse(val1.Text);
                obj4.D2 = double.Parse(val2.Text);
                resultado.Text = obj4.calcular().ToString();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            
            
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }
    }
}
