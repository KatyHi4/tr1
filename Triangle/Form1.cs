using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                double side1 = Convert.ToDouble(textBox1.Text);
                double side2 = Convert.ToDouble(textBox2.Text);
                double side3 = Convert.ToDouble(textBox3.Text);
                if (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2)
                {
                    if (side1 == side2 && side2 == side3 && side1 == side3)
                    {
                        MessageBox.Show("Треугольник равносторонний");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        MessageBox.Show("Треугольник равнобедренный");
                    }
                    else if (side1 == 0 || side2 == 0 || side3 == 0)
                    {
                        MessageBox.Show("Треугольника не существует");
                    }
                    else
                    {
                        MessageBox.Show("Треугольник разносторонний");
                    }

                }
                else
                {
                    MessageBox.Show("Треугольника не существует");
                }

            }
            catch
            {
                MessageBox.Show("Введите значения сторон треугольника");
            }

            Application.Restart();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

