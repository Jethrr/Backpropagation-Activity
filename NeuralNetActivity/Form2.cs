using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetActivity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            if(loading == null)
            {

            }
            loading.Minimum = 0;
            loading.Maximum = 100;
            InitializeComponent();
        }

        public void UpdateProgress(int value)
        {
            if (value <= loading.Maximum)
            {
                loading.Value = value;
                loading.Refresh(); 
            }
        }
    }
}
