using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Violacao.Funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        //Validações
        public bool ValidarCPF(string cpf)
        {
            if (cpf != "")
            {
                //Processso de validação do CPF
                // ...
                // ...
                // ...

                if (cpf.Length == 11)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public bool ValidarEmail(string email)
        {
            if (email != "")
            {
                //Processo de validação de e-mail
                // ...
                // ...
                // ...
                return true;
            }
            else
                return false;

        }

        //CRUD
        public string AdicionarFuncionario()
        {
            if (InsertFuncionario())
                return "Funcionário adicionado com sucesso";
            else
                return "Falha ao tentar adicionar funcionário";
        }

        public bool InsertFuncionario()
        {
            try
            {
                string scriptInsert = "INSERT INTO FUNCIONARIO (NOME, CPF, EMAIL, DATANASCIMENTO) " +
             "VALUES (@NOME, @CPF, @EMAIL, @DATANASCIMENTO)";

                var cmd = new SqlCommand();
                cmd.Connection = RetornarConexaoBanco();

                cmd.Parameters.AddWithValue("NOME", Nome);
                cmd.Parameters.AddWithValue("CPF", CPF);
                cmd.Parameters.AddWithValue("EMAIL", Email);
                cmd.Parameters.AddWithValue("DATANASCIMENTO", DataNascimento);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = scriptInsert;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException errorSql)
            {
                //Processos para salvar em log ou enviar para algum e-mail a resposta de errorSql.Message 
                return false;
            }
        }

        public SqlConnection RetornarConexaoBanco()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=MeuEnderecoServidor;Database=MinhaBaseDados;User Id=userTeste;Password = 123456;";
            return connection;
        }
    }
}
