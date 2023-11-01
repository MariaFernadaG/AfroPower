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
    public partial class AdicionarHorario : Form
    {
        public AdicionarHorario()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarHorario_Load(object sender, EventArgs e)
        {
           /* string vquery = @"
            SELECT 
                N_HORARIO as 'ID',
                T_DESCRICAOHORARIO as 'Horarios'
                FROM 
            tb_horarios
            ";
            dgv_horarios.DataSource = Banco.dlq(vquery)*/
        }
    }
}
