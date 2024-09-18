using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            /*Após o Formulário Iniciar é feito uma operação em que é usado o método Listar da classe médico,
            para que preencha o comboBox com os nomes do médicos*/
            Medico medico = new Medico();
            foreach (var item in medico.Listar())
            {
                cbxNomeMedico.Items.Add(item.NomeMedico);
            }
        }
        //Método para cadastrar um paciente, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AgendamentoDb"].ConnectionString);

                string nomeMedico = cbxNomeMedico.Text;
                string dia = dtpDia.Text;
                string horario = dtpHora.Text;
                /*Foi realizado uma query no BD para que verifique se o médico selecionado já possui a agenda ocupada, caso esteja ocupada, não poderá
                 cadastrar o médico*/
                string sql = "SELECT COUNT(*) FROM Paciente WHERE NomeMedico='" + nomeMedico + "' AND Dia='" + dia + "' AND Horario='" + horario + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (string.IsNullOrEmpty(txtNomePaciente.Text)||string.IsNullOrEmpty(cbxNomeMedico.Text))
                {
                    MessageBox.Show("Campos estão vazios!", "Preencha os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result != 0)
                {
                    MessageBox.Show("O Médico, para esse dia e horário estão ocupados!", "Agenda Ocupada!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    paciente.Inserir(txtNomePaciente.Text, nomeMedico, dia, horario);
                    MessageBox.Show("Consulta Marcada!", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNomePaciente.Text = "";
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Método para voltar ao formulário anterior, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
