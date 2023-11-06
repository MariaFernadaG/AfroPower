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
    public partial class TelaHorariosAgendados : Form
    {
        public TelaHorariosAgendados()
        {
            InitializeComponent();
        }

        private void TelaHorariosAgendados_Load(object sender, EventArgs e)
        {
            string vquery = @"
        SELECT 
            N_IDFUNCIONARIO as 'ID',
            T_FUNCIONARIO as 'Funcionario',
            T_DIA as 'Dia',
            T_DESCRICAOHORARIO as 'Horários',
            T_SERVICO as 'Nagos',
            T_ADICIONAL as 'Box Braids',
            N_VALORTOTAL as 'Valor',
            T_NOMECLIENTE as 'Cliente',
            T_OBESERVACAOCLIENTE as 'Observação'
           
        FROM 
            Tb_AdicionarHorario
        WHERE T_STATUS = 'Indisponível';  -- Filtra somente horários disponíveis
    ";

            DataTable dt = Banco.consulta(vquery);
            dgv_HorariosAgendados.DataSource = dt;
        }

        private void dt_Filtro_ValueChanged(object sender, EventArgs e)
        {

            DateTime dataFiltro = dt_Filtro.Value.Date; // Pega a data selecionada no DateTimePicker

            // Loop através das linhas da DataGridView e aplique o filtro
            foreach (DataGridViewRow row in dgv_HorariosAgendados.Rows)
            {
                if (row.Cells["Dia"].Value != null)
                {
                    string dataNaCelulaString = row.Cells["Dia"].Value.ToString();
                    DateTime dataNaCelula;

                    if (DateTime.TryParse(dataNaCelulaString, out dataNaCelula))
                    {
                        // Compare a data na célula com a data de filtro
                        if (dataNaCelula.Date == dataFiltro)
                        {
                            row.Visible = true; // Mostra a linha se corresponder ao filtro
                        }
                        else
                        {
                            row.Visible = false; // Oculta a linha se não corresponder ao filtro
                        }
                    }
                    else
                    {
                        // Lidar com datas inválidas ou em formato incorreto, se necessário
                    }
                }
            }
        }
    }
}
