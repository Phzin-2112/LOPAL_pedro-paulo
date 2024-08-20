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
    public partial class atividade03 : Form
    {
        public atividade03()
        {
            InitializeComponent();
        }

        

        private void txtresult01_Click(object sender, EventArgs e)
        {
            txtresult01.ToString();
        }

        private void txtresult02_Click(object sender, EventArgs e)
        {
            txtresult02.ToString();
        }

        private void txtresult03_Click(object sender, EventArgs e)
        {
            txtresult03.ToString();
        }

        private void txtresult04_Click(object sender, EventArgs e)
        {
            txtresult04.ToString();
        }

        private void txtresult05_Click(object sender, EventArgs e)
        {
            txtresult05.ToString();
        }

        private void txtresult06_Click(object sender, EventArgs e)
        {
            txtresult06.ToString();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            // 1º passo - Definir variaveis

            double brentford,everton, fulham, newcastle,spurs, astonv, brighton,mancity,manutd,liverpool,arsenal,chelsea;

            // 2º passo - Realizar entrada
            brentford = double.Parse(txtbrent.Text);
            everton = double.Parse(txteverton.Text);
            fulham = double.Parse(txtfulham.Text);
            newcastle = double.Parse(txtnewcast.Text);
            spurs = double.Parse(txtspurs.Text);
            astonv = double.Parse(txtastonv.Text);
            brighton = double.Parse(txtbright.Text);
            mancity = double.Parse(txtcity.Text);
            manutd = double.Parse(txtutd.Text);
            liverpool = double.Parse(txtliver.Text);
            arsenal = double.Parse(txtarsenal.Text);
            chelsea = double.Parse(txtchel.Text);


            // 3º passo - Processamento e saída

            if (brentford < brighton)
            {
                txtresult01.Text = ("Brighton");
            }
            else if (brentford > brighton)
            {
                txtresult01.Text = ("Brentford");
            }
            else
            {
                txtresult01.Text = ("Empate");
            }
            
            if (everton < mancity)
            {
                txtresult02.Text = ("Man City");
            }
            else if (everton > mancity)
            {
                txtresult02.Text = ("Everton");
            }
            else
            {
                txtresult02.Text = ("Empate");
            }

            if (fulham > manutd)
            {
                txtresult03.Text = ("Fulhan");
            }
            else if (fulham < manutd)
            {
                txtresult03.Text = ("Man Utd");
            }
            else
            {
                txtresult03.Text = ("Empate");
            }

            if (newcastle < liverpool)
            {
                txtresult04.Text = ("Liverpool");
            }
            else if (newcastle > liverpool)
            {
                txtresult04.Text = ("Newcastle");
            }
            else
            {
                txtresult04.Text = ("Empate");
            }

            if (spurs < arsenal)
            {
                txtresult05.Text = ("Asenal");
            }
            else if (spurs > arsenal)
            {
                txtresult05.Text = ("Spurs");
            }
            else
            {
                txtresult05.Text = ("Empate");
            }

            if (astonv < chelsea)
            {
                txtresult06.Text = ("Chelsea");
            }
            else if (astonv > chelsea)
            {
                txtresult06.Text = ("Aston Vila");
            }
            else
            {
                txtresult06.Text = ("Empate");
            }

        }
    }
 }
