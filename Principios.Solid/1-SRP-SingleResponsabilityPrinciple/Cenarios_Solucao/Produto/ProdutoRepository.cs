using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.Solid._1_SRP_SingleResponsabilityPrinciple.Cenarios_Solucao.Produto
{
    public class ProdutoRepository
    {
        public bool InsertProduto(Produto produto)
        {
            try
            {
                string scriptInsert = "INSERT INTO PRODUTO (DESCRICAO, MARCA, MODELO, QUANTIDADE, DATACADASTRO) " +
             "VALUES (@DESCRICAO, @MARCA, @MODELO, @QUANTIDADE, @DATACADASTRO)";

                var cmd = new SqlCommand();
                cmd.Connection = RetornarConexaoBanco();

                cmd.Parameters.AddWithValue("DESCRICAO", produto.Descricao);
                cmd.Parameters.AddWithValue("MARCA", produto.Marca);
                cmd.Parameters.AddWithValue("MODELO", produto.Modelo);
                cmd.Parameters.AddWithValue("QUANTIDADE", produto.Quantidade);
                cmd.Parameters.AddWithValue("DATACADASTRO", produto.DataCadastro);

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

        private SqlConnection RetornarConexaoBanco()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=MeuEnderecoServidor;Database=MinhaBaseDados;User Id=userTeste;Password = 123456;";
            return connection;
        }
    }
}
