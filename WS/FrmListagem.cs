using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmListagem : Form
    {
        public FrmListagem()
        {
            InitializeComponent();
            /*Após o Formulário Iniciar é feito uma operação em que é usado o método Listar da classe médico,
            para que preencha o comboBox com os nomes do médicos.
            Também é feito uma operação onde é escondido a Coluna Id do DataGridView*/
            Paciente paciente = new Paciente();
            Medico medico = new Medico();

            dgvAgenda.DataSource = paciente.Listar();
            dgvAgenda.Columns["Id"].Visible = false;

            foreach (var item in medico.Listar())
            {
                cbxNomeMedico.Items.Add(item.NomeMedico);
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
        //Método para localizar o médico desejado, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                var listaFiltrada = paciente.Listar();
                dgvAgenda.DataSource = listaFiltrada.Where(p => p.NomeMedico == cbxNomeMedico.Text).ToList();
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        /*Método para limpar a pesquisa e retornar o DataGridView com todos os médicos e suas consultas, usando try e catch, 
         para capturar e retornar caso ocorra algum erro*/
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                dgvAgenda.DataSource = paciente.Listar();
               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
