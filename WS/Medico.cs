using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adicionado biblioteca de conexão com o BD e biblioteca para conseguir a string de conexão personalizada
using System.Data.SqlClient;
using System.Configuration;

namespace WS
{
    //Criando as propriedades da classe e configurando a string de conexão flexível
    public class Medico
    {
        public int Id { get; set; }
        public string NomeMedico { get; set; }
        public string Especialidade { get; set; }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AgendamentoDb"].ConnectionString);

        //Método de listagem, para listra todos os médicos, usando try e catch, para capturar e retornar caso ocorra algum erro
        public List<Medico> Listar()
        {
            try
            {
                List<Medico> medicos = new List<Medico>();
                string sql = "SELECT * FROM Medico";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Medico medico = new Medico();
                    medico.Id = (int)dr["Id"];
                    medico.NomeMedico = dr["NomeMedico"].ToString();
                    medico.Especialidade = dr["Especialidade"].ToString();
                    medicos.Add(medico);
                }
                conn.Close();
                return medicos;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        //Método de inserção para inserir o médico no BD, usando try e catch, para capturar e retornar caso ocorra algum erro
        public void Inserir(string nomeMedico, string especialidade)
        {
            try
            {
                string sql = "INSERT INTO Medico(NomeMedico, Especialidade) VALUES('" + nomeMedico + "','" + especialidade + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
    }
}
