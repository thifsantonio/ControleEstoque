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
    public class DALCategoria
    {
        private DALConexao CONEXAO;

        public DALCategoria(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloCategoria c) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "insert into categoria(cat_nome) values(@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", c.NomeCategoria);

            CONEXAO.Conectar();

            c.CodCategoria = Convert.ToInt32(cmd.ExecuteScalar());

            CONEXAO.Desconectar();
        }

        public void Alterar(ModeloCategoria c) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@nome", c.NomeCategoria);
            cmd.Parameters.AddWithValue("@codigo", c.CodCategoria);

            CONEXAO.Conectar();

            cmd.ExecuteNonQuery();

            CONEXAO.Desconectar();
        }

        public void Excluir(int codigo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@codigo", codigo);            

            CONEXAO.Conectar();

            cmd.ExecuteNonQuery();

            CONEXAO.Desconectar();
        }

        public DataTable Localizar(String s) 
        {
            string sqlQuery = "select cat_cod as Categoria, cat_nome as Nome from categoria where cat_nome like '%" + s + "%'; ";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, CONEXAO.StringConexao);

            da.Fill(tabela);

            return tabela;
        }

        public ModeloCategoria carregaCategoria(int codigo) 
        {
            ModeloCategoria m = new ModeloCategoria();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "select * from categoria where cat_cod = " + codigo.ToString() + "; ";
            
            CONEXAO.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows) 
            {
                registro.Read();

                m.CodCategoria  = Convert.ToInt32(registro["cat_cod"]);
                m.NomeCategoria = Convert.ToString(registro["cat_nome"]);
            }

            CONEXAO.Desconectar();

            return m;
        }
    }
}