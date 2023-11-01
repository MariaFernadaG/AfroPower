using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroPower
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void agendarHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.nivel==trancistaToolStripMenuItem.Text)
            {
                AdicionarHorario t = new  AdicionarHorario();
                t.Show();
            }
            else
            {
                MessageBox.Show("Usuario nao permitido");
            }
        }
    }
}
