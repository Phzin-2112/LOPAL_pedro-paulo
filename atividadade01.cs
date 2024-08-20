using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOPAL_pedro_paulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1º Passo - Definir variaveis
        int n1, n2, n3, maior,menor;

        // 2º Passo - Realizar entrada
        private void btncalcular_Click(object sender, EventArgs e)
        {
            n1 =int.Parse(txtvalor1.Text);
            n2 = int.Parse(txtvalor2.Text);
            n3 = int.Parse(txtvalor3.Text); 

        // 3º Passo - Realizar processamento
            if (n1> n2 && n1> n3 && n3<n2)
            {
                lblmaior.Text=txtvalor1.Text;
                lblmenor.Text=txtvalor3.Text;

            }else if (n1< n2 && n2> n3 && n3<n1)
            {
                lblmaior.Text=txtvalor2.Text;
                lblmenor.Text = txtvalor3.Text;
            }
            else if (n1 < n3 && n3 > n2 && n2 < n1)
            {
                lblmaior.Text = txtvalor3.Text;
                lblmenor.Text = txtvalor2.Text;

            }else if(n1 > n2 && n1 > n3 && n3 >n2)
            {
                lblmaior.Text = txtvalor1.Text;
                lblmenor.Text = txtvalor2.Text;


            }else if (n1 < n2 && n2 > n3 && n3 > n1)
            {
                lblmaior.Text = txtvalor2.Text;
                lblmenor.Text = txtvalor1.Text;
            }
            else if (n1 < n3 && n3 > n2 && n2 > n1)
            {
                lblmaior.Text = txtvalor3.Text;
                lblmenor.Text = txtvalor1.Text;
            }
        }

        // 4º Passo - Realizar saída
        
        private void lblmenor_Click(object sender, EventArgs e)
        {
            menor.ToString();
        }

        private void lblmaior_Click(object sender, EventArgs e)
        {
            maior.ToString();
        }
    }
}
