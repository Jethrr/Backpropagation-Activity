using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
namespace NeuralNetActivity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        int[][] truthTable = new int[][]
{
                new int[] {0, 0, 0, 0, 0},
                new int[] {0, 0, 0, 1, 0},
                new int[] {0, 0, 1, 0, 0},
                new int[] {0, 0, 1, 1, 0},
                new int[] {0, 1, 0, 0, 0},
                new int[] {0, 1, 0, 1, 0},
                new int[] {0, 1, 1, 0, 0},
                new int[] {0, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0},
                new int[] {1, 0, 0, 1, 0},
                new int[] {1, 0, 1, 0, 0},
                new int[] {1, 0, 1, 1, 0},
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 0, 1, 0},
                new int[] {1, 1, 1, 0, 0},
                new int[] {1, 1, 1, 1, 1},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create
            nn = new NeuralNet(4,1000,1);
            MessageBox.Show(nn.getNumbers());
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            // Train
            for (int epoch = 0; epoch < 100; epoch++)
            {
                foreach (var row in truthTable)
                {
                    
                    for (int i = 0; i < 4; i++) 
                    {
                        nn.setInputs(i, (double)row[i]);
                    }

                   
                    nn.setDesiredOutput(0, (double)row[4]);

                  
                    nn.learn();
                }
            }

            MessageBox.Show("Training Completed!");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //Test

            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));

            nn.setInputs(3, Convert.ToDouble(textBox4.Text));

            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
