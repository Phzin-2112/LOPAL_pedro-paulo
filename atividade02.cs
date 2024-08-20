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
    public partial class atividade02 : Form
    {
        public atividade02()
        {
            InitializeComponent();
        }
        // 1º Passo - Definir variaveis
       double pesokg;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // 2º passo - entrada
            pesokg = int.Parse(txtvalor1.Text);

            txtvalor1 = new TextBox();

            // 3º passo - processamento e saída
            if (rbmercurio.Checked)
            {
                MessageBox.Show("O seu peso em Mercúrio é: " + pesokg * 0.37);
            }
            else if (rbjupter.Checked)
            {
                MessageBox.Show("O seu peso em Júpiter é: " + pesokg * 2.64);
            }
            else if (rbmarte.Checked)
            {
                MessageBox.Show("O seu peso em Marte é: " + pesokg * 0.38);
            }
            else if (rbvenus.Checked)
            {
                MessageBox.Show("O seu peso em Vênus é: " + pesokg * 0.88);

            }
            else if (rbsaturno.Checked)
            {
                MessageBox.Show("O seu peso em Saturno é: " + pesokg * 1.15);

            }
            else if (rburano.Checked)
            {
                MessageBox.Show("O seu peso em Urano é: " + pesokg * 1.17);
            }
            

        }

        
    }
}
