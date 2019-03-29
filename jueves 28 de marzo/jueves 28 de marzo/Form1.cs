using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jueves_28_de_marzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                radioButton1.Checked = true;

            }
            if (this.checkBox2.Checked == true)
            {
                radioButton3.Checked = true;
            }
            if (this.checkBox3.Checked == true)
            {
                radioButton2.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ha dado un click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "ha dado doble click";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (this.radioButton1.Checked == true) { 
            label1.Text = "selecciono suma";
            }
            if (this.radioButton2.Checked == true) { 
                label1.Text = "selecciono resta";
            }
            if (this.radioButton3.Checked == true) {
                label1.Text = "selecciono multi";
            }
            if (this.radioButton4.Checked == true) {
                label1.Text = "selecciono div";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                label1.BackColor = Color.Blue;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                
                this.BackColor = Color.LimeGreen;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(i.ToString());

                   
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
