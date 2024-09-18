using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adicionado biblioteca de conexão com o BD e biblioteca para conseguir a string de conexão personalizada
using System.Configuration;
using System.Data.SqlClient;

namespace WS
{
    //Criando as propriedades da classe e configurando a string de conexão flexível
    public class Paciente
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AgendamentoDb"].ConnectionString);

        //Método de listagem, para listar todos os acientes, usando try e catch, para capturar e retornar caso ocorra algum erro
        public List<Paciente> Listar()
        {
            try
            {
                List<Paciente> pacientes = new List<Paciente>();
                string sql = "SELECT * FROM Paciente";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Id = (int)dr["Id"];
                    paciente.NomePaciente = dr["NomePaciente"].ToString();
                    paciente.NomeMedico = dr["NomeMedico"].ToString();
                    paciente.Dia = dr["Dia"].ToString();
                    paciente.Horario = dr["Horario"].ToString();
                    pacientes.Add(paciente);
                }
                conn.Close();
                return pacientes;
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

        //Método de inserção para inserir o paciente no BD, usando try e catch, para capturar e retornar caso ocorra algum erro
        public void Inserir(string nomePaciente, string nomeMedico, string dia, string horario)
        {
            try
            {
                string sql = "INSERT INTO Paciente(NomePaciente, NomeMedico, Dia, Horario) VALUES('" + nomePaciente + "','" + nomeMedico + "','" + dia + "','" + horario + "')";
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
