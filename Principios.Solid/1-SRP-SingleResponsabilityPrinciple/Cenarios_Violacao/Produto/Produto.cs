using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Violacao.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }

        //CRUD
        public void AdicionarProduto()
        {
            if (InsertProduto())
            {
                //Mensagem produto adicionado com sucesso
            }
            else
            {
                //Mensagem produto falha ao tentar inserir na base de dados
            }
        }

        public bool InsertProduto()
        {
            try
            {
                string scriptInsert = "INSERT INTO PRODUTO (DESCRICAO, MARCA, MODELO, QUANTIDADE, DATACADASTRO) " +
             "VALUES (@DESCRICAO, @MARCA, @MODELO, @QUANTIDADE, @DATACADASTRO)";

                var cmd = new SqlCommand();
                cmd.Connection = RetornarConexaoBanco();

                cmd.Parameters.AddWithValue("DESCRICAO", Descricao);
                cmd.Parameters.AddWithValue("MARCA", Marca);
                cmd.Parameters.AddWithValue("MODELO", Modelo);
                cmd.Parameters.AddWithValue("QUANTIDADE", Quantidade);
                cmd.Parameters.AddWithValue("DATACADASTRO", DataCadastro);

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
