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
    public partial class FrmMedico : Form
    {
        public FrmMedico()
        {
            InitializeComponent();
        }
        //Método para cadastrar um médico, usando try e catch, para capturar e retornar caso ocorra algum erro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeMedico.Text) || string.IsNullOrEmpty(txtEspecialidade.Text))
                {
                    MessageBox.Show("Campos estão vazios!", "Preencha os campos!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                }
                Medico medico = new Medico();
                medico.Inserir(txtNomeMedico.Text, txtEspecialidade.Text);
                MessageBox.Show("Médico Cadastrado!","Cadastro com Sucesso!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeMedico.Text = "";
                txtEspecialidade.Text = "";
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
