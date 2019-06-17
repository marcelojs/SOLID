using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Funcionario
{
    public class FuncionarioRepository
    {
        public void InsertFuncionario(Funcionario funcionario)
        {
            try
            {
                string scriptInsert = "INSERT INTO FUNCIONARIO (NOME, CPF, EMAIL, DATANASCIMENTO) " +
             "VALUES (@NOME, @CPF, @EMAIL, @DATANASCIMENTO)";

                var cmd = new SqlCommand();
                cmd.Connection = RetornarConexaoBanco();

                cmd.Parameters.AddWithValue("NOME", funcionario.Nome);
                cmd.Parameters.AddWithValue("CPF", funcionario.CPF);
                cmd.Parameters.AddWithValue("EMAIL", funcionario.Email);
                cmd.Parameters.AddWithValue("DATANASCIMENTO", funcionario.DataNascimento);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = scriptInsert;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException errorSql)
            {
                //Processos para salvar em log ou enviar para algum e-mail a resposta de errorSql.Message 
            }
        }

        private SqlConnection RetornarConexaoBanco()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=MeuEnderecoServidor;Database=MinhaBaseDados;User Id=userTeste;Password = 123456;";
            return connection;
        }

    }
}
