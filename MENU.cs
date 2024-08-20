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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atividade02 Tela1 = new atividade02();
            Tela1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Tela1 = new Form1();
            Tela1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atividade03 Tela1 = new atividade03();
            Tela1.ShowDialog();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
