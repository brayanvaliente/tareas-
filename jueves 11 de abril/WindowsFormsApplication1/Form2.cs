using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String u, p;
            u = textBox1.Text.TrimEnd();
            p = textBox2.Text.TrimEnd();
            if ((u=="utec")&&(p=="programacion1")){


                MessageBox.Show("BIENVENIDO AL SISTEMA");
            }
            else{
                MessageBox.Show("verifique usuario y contra");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
