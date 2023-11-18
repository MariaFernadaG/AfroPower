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
    public partial class TelaBoasVindasCliente : Form
    {
        public TelaBoasVindasCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(); 
            telaPrincipal.Show();
            this.Close();
        }
    }
}
