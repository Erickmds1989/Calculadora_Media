using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);

            media = (n1 + n2 + n3) / 3;

            txtMedia.Text = media.ToString();


            if (media >= 7)
            {
                MessageBox.Show(media + "  " + "Aluno aprovado");
            }
                
            else if (media < 5)
            {
                MessageBox.Show(media + "  " + "Aluno reprovado");
            }
             
            else
            {
                MessageBox.Show(media + "  " + "Aluno em recuperação");
            }
            





        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";
        }
    }
}
