using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUnidadeMedida
    {
        private DALConexao CONEXAO;

        public DALUnidadeMedida(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloUnidadeMedida um) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "insert into undmedida(umed_nome) values(@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", um.UnidadeMedidaNome);

            CONEXAO.Conectar();

            um.UnidadeMedidaCodigo = Convert.ToInt32(cmd.ExecuteScalar());

            CONEXAO.Desconectar();
        }

        public void Alterar(ModeloUnidadeMedida um) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "update undmedida set umed_nome = @nome where umed_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@nome", um.UnidadeMedidaNome);
            cmd.Parameters.AddWithValue("@codigo", um.UnidadeMedidaCodigo);

            CONEXAO.Conectar();

            cmd.ExecuteNonQuery();

            CONEXAO.Desconectar();
        }

        public void Excluir(int codigo) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CONEXAO.objConexao;
                cmd.CommandText = "delete from undmedida where umed_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);

                CONEXAO.Conectar();

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                CONEXAO.Desconectar();
            }
        }

        public DataTable Localizar(String s) 
        {
            string sqlQuery = "select * from undmedida where umed_nome like '%" + s + "%'; ";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, CONEXAO.StringConexao);

            da.Fill(tabela);

            return tabela;
        }

        public ModeloUnidadeMedida carregaUnidadeMedida(int codigo)
        {
            ModeloUnidadeMedida m = new ModeloUnidadeMedida();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "select * from undmedida where umed_cod = " + codigo.ToString() + "; ";

            CONEXAO.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                m.UnidadeMedidaCodigo = Convert.ToInt32(registro["umed_cod"]);
                m.UnidadeMedidaNome = Convert.ToString(registro["umed_nome"]);
            }

            CONEXAO.Desconectar();

            return m;
        }
    }
}
