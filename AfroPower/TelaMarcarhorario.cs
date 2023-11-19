using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AfroPower
{
    public partial class TelaMarcarhorario : Form
    {
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Dictionary<string, decimal> produtos = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> adicionais = new Dictionary<string, decimal>();
        DataTable dt = new DataTable();
        public TelaMarcarhorario()
        {
            InitializeComponent();
            produtos.Add("      ", 00.0m);
            produtos.Add("Lateral Simples", 15.0m);
            produtos.Add("Lateral Desenhada", 25.0m);
            produtos.Add("Topo Simples", 25.0m);
            produtos.Add("Topo Desenhada", 30.0m);
            produtos.Add("Cabeça Toda Desenhada", 40.0m);
            produtos.Add("Cabeça Toda Desenhada Simples", 55.0m);
            produtos.Add("Boxeadora", 50.0m);

            cb_Servicos.Items.AddRange(produtos.Keys.ToArray());

            adicionais.Add("      ", 00.0m);
            adicionais.Add("Simples Até o Ombro", 80.0m);
            adicionais.Add("Simples Até a cintura", 150.0m);


            cb_Adicionais.Items.AddRange(adicionais.Keys.ToArray());
            //data timer
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            Controls.Add(dateTimePicker1);

            // Configurar as propriedades do DateTimePicker conforme necessário
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Location = new System.Drawing.Point(75, 80);
            // ... outras configurações

            // Adicionar um manipulador de eventos para lidar com a mudança de valor
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void CalcularValorTotal()
        {
            if (cb_Servicos.SelectedItem == null || cb_Adicionais.SelectedItem == null)
            {
                textBoxValor.Text = "";
                return;
            }

            string produtoSelecionado = cb_Servicos.SelectedItem.ToString();
            string adicionalSelecionada = cb_Adicionais.SelectedItem.ToString();

            decimal valorprod = produtos[produtoSelecionado];
            decimal valoradicio = adicionais[adicionalSelecionada];

            decimal valorTotal = valorprod + valoradicio;

            textBoxValor.Text = valorTotal.ToString("C");
        }
        private void cb_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void cb_Adicionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }
        private void CarregarDadosDoDataGridView()
        {
            string vquery = @"
                SELECT 
                    N_IDFUNCIONARIO as 'ID',
                    T_FUNCIONARIO as 'Funcionario',
                    T_DIA as 'Dia',
                    T_DESCRICAOHORARIO as 'Horários',
                    T_STATUS as 'Status'
                FROM 
                    Tb_AdicionarHorario
            ";

            DataTable dt = Banco.consulta(vquery);
            dgv_horariosmarcar.DataSource = dt;
        }
        private void TelaMarcarhorario_Load(object sender, EventArgs e)
        {
            CarregarDadosDoDataGridView();
            dateTimePicker1.Value = DateTime.Today;
            FiltrarPorData2(dateTimePicker1.Value);



        }
        private void dgv_horariosmarcar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                  SELECT
                    *
                  FROM
                   Tb_AdicionarHorario
                 WHERE
                      N_IDFUNCIONARIO=" + vid;
                dt = Banco.dql(vquery);


                
                txt_Funcionario.Text = dt.Rows[0].Field<string>("T_FUNCIONARIO").ToString();
                msk_Data.Text = dt.Rows[0].Field<string>("T_DIA").ToString();
                msk_Hora.Text = dt.Rows[0].Field<string>("T_DESCRICAOHORARIO").ToString();
                txt_Status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                txt_NomeCliente.Text = Globais.nome;


            }


        }

        private void btn_Agendar_Click(object sender, EventArgs e)
        {

            string funcionario = txt_Funcionario.Text;
            string data = msk_Data.Text;
            string horario = msk_Hora.Text;
            string status = txt_Status.Text;
            string servico = cb_Servicos.Text;
            string adicional = cb_Adicionais.Text;
            string valor = textBoxValor.Text;
            string obervacao = txt_Obeservacao.Text;
            string nomeUsuario = txt_NomeCliente.Text;

           
                string queryVerificar = "SELECT T_STATUS FROM Tb_AdicionarHorario WHERE T_DIA = '" + data + "' AND T_DESCRICAOHORARIO = '" + horario + "'";
            string statusExistente = Banco.consulta(queryVerificar).Rows.Count > 0
                ? Banco.consulta(queryVerificar).Rows[0]["T_STATUS"].ToString()
                : "";

                if (statusExistente == "Indisponível")
                {
                    MessageBox.Show("Horário indisponível. Escolha outro horário.");
                }
                else
                {

                    DialogResult res = MessageBox.Show($"Prezado(a), {Globais.nome}, seu agendamento está confirmado para o dia {data} às {horario}, com o(a) trancista {funcionario}.Agradecemos por confiar em nós para cuidar de sua beleza!", "Confirmar Agendamento", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        string vquery = "UPDATE Tb_AdicionarHorario SET T_STATUS = 'Indisponível', T_SERVICO = '" + servico + "', T_ADICIONAL = '" + adicional + "', N_VALORTOTAL = '" + valor + "', T_OBESERVACAOCLIENTE = '" + obervacao + "', T_NOMECLIENTE = '" + nomeUsuario + "' WHERE T_DIA = '" + data + "' AND T_DESCRICAOHORARIO = '" + horario + "'";
                        Banco.dml(vquery);


                        CarregarDadosDoDataGridView();


                    }
                
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            string nomeclienteagendado = txt_NomeCliente.Text; 
            string data = msk_Data.Text;
            string horario = msk_Hora.Text;

            // Verificar se o horário já está marcado como "Indisponível"
            string queryVerificar = "SELECT T_STATUS, T_NOMECLIENTE FROM Tb_AdicionarHorario WHERE T_DIA = '" + data + "' AND T_DESCRICAOHORARIO = '" + horario + "'";
            DataTable dt = Banco.consulta(queryVerificar);

            if (dt.Rows.Count == 1)
            {
                string nomeAgendado = dt.Rows[0].Field<string>("T_NOMECLIENTE");

                if (nomeclienteagendado == nomeAgendado)
                {
                    DialogResult res = MessageBox.Show("Confirma Cancelar Agendamento?", "Excluir?", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        string vquery = "UPDATE Tb_AdicionarHorario SET T_STATUS = 'Disponível' WHERE T_DIA = '" + data + "' AND T_DESCRICAOHORARIO = '" + horario + "' AND T_NOMECLIENTE = '" + nomeclienteagendado + "'";
                        Banco.dml(vquery);
                        CarregarDadosDoDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para cancelar este agendamento.");
                }
            }
            else
            {
                MessageBox.Show("Horário não encontrado ou você não pode cancelar.");
            }
        }
        private void FiltrarPorData2(DateTime data)
        {
            string formattedDate = data.ToString("dd/MM/yyyy");

            // Certifique-se de que está usando DateTime como tipo de dado
            if (data is DateTime)
            {
                formattedDate = ((DateTime)data).ToString("dd/MM/yyyy");
            }

            string vquery = @"
            SELECT 
                N_IDFUNCIONARIO as 'ID',
                T_FUNCIONARIO as 'Funcionario',
                T_DIA as 'Dia',
                T_DESCRICAOHORARIO as 'Horários',
                T_STATUS as 'Status'
            FROM 
                Tb_AdicionarHorario
            WHERE
                T_DIA = '" + formattedDate + "'";

            dgv_horariosmarcar.DataSource = Banco.consulta(vquery);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorData2(dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }
    }

}
