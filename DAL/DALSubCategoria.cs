using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALSubCategoria
    {
        private DALConexao CONEXAO;

        public DALSubCategoria(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloSubCategoria sc) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CONEXAO.objConexao;
                cmd.CommandText = "insert into subcategoria(cat_cod, scat_nome) values(@fk_codcategoria, @nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@fk_codcategoria", sc.FKCatCod);
                cmd.Parameters.AddWithValue("@nome", sc.SubCategoriaNome);


                CONEXAO.Conectar();

                sc.CodSubCat = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloSubCategoria sc) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CONEXAO.objConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome, cat_cod = @codcat where scat_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@nome", sc.SubCategoriaNome);
                cmd.Parameters.AddWithValue("@codcat", sc.FKCatCod);                
                cmd.Parameters.AddWithValue("@codigo", sc.CodSubCat);

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

        public void Excluir(int codigo) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CONEXAO.objConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);

                CONEXAO.Conectar();

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message + "Este registro esta sendo usado em outra tabela e nao pode ser apagado.");
            }
            finally
            {
                CONEXAO.Desconectar();
            }
        }

        public DataTable Localizar(String s) 
        {            
            string sqlQuery = "select subcategoria.scat_cod, subcategoria.scat_nome, categoria.cat_nome  from subcategoria inner join categoria on subcategoria.cat_cod = categoria.cat_cod where scat_nome like '%" + s + "%'; ";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, CONEXAO.StringConexao);

            da.Fill(tabela);

            return tabela;
        }

        public ModeloSubCategoria carregaSubCategoria(int codigo) 
        {            
            ModeloSubCategoria m = new ModeloSubCategoria();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = " + codigo.ToString() + "; ";
            
            CONEXAO.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows) 
            {
                registro.Read();

                m.CodSubCat  = Convert.ToInt32(registro["scat_cod"]);
                m.SubCategoriaNome = Convert.ToString(registro["scat_nome"]);
                m.FKCatCod = Convert.ToInt32(registro["cat_cod"]);
            }

            CONEXAO.Desconectar();

            return m;
        }
    }
}
