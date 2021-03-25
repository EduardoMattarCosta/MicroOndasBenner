using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndas
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
            
        }

        private void Tela_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessaInput processa = new ProcessaInput(Input.Text);
          
        }

        private void btn30seg_Click(object sender, EventArgs e)
        {
            ProcessaInput processa = new ProcessaInput(0.30, 8);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
        }
    }
}
