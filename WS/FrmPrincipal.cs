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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Método para abrir um novo Formulário de cadastro de médico, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnCadastrarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMedico frmMedico = new FrmMedico();
                frmMedico.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Método para abrir um novo Formulário de cadastro de paciente, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPaciente frmPaciente = new FrmPaciente();
                frmPaciente.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Método para abrir um novo Formulário de listagem da agenda, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnListarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListagem frmListagem = new FrmListagem();
                frmListagem.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Método para fechar o programa, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
