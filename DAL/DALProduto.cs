using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao CONEXAO;

        public DALProduto(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloProduto p) 
        {
            string scriptInsert = "insert into produto(pro_nome, pro_descricao, pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod) "
                + "values(@nome, @descricao, @foto, @valorpago, @valorvenda, @quantidade, @unidademedida, @categoria, @subcategoria); select @@IDENTITY;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = scriptInsert;
            cmd.Parameters.AddWithValue("@nome", p.NomeProduto);
            cmd.Parameters.AddWithValue("@descricao", p.DescricaoProduto);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);

            if (p.FotoProduto == null)
                cmd.Parameters["@foto"].Value = DBNull.Value;
            else
                cmd.Parameters["@foto"].Value = p.FotoProduto;

            cmd.Parameters.AddWithValue("@valorpago", p.ValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", p.ValorVenda);
            cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
            cmd.Parameters.AddWithValue("@unidademedida", p.UnidadeMedida);
            cmd.Parameters.AddWithValue("@categoria", p.Categoria);
            cmd.Parameters.AddWithValue("@subcategoria", p.SubCategoria);

            CONEXAO.Conectar();

            p.CodigoProduto = Convert.ToInt32(cmd.ExecuteScalar());

            CONEXAO.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "delete from produto where pro_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            CONEXAO.Conectar();

            cmd.ExecuteNonQuery();

            CONEXAO.Desconectar();
        }

        public void Alterar(ModeloProduto p) 
        {
            string scriptAlterar = "update produto set pro_nome = @nome, set pro_descricao = @descricao, set pro_foto = @foto, set pro_valorpago = @valorpago, set pro_valorvenda = @valorvenda, set pro_qtde = @quantidade, set umed_cod = @unidademedida, set cat_cod = @categoria, set scat_cod = @subcategoria" 
                + " where pro_cod = @codigo;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = scriptAlterar;
            cmd.Parameters.AddWithValue("@nome", p.NomeProduto);
            cmd.Parameters.AddWithValue("@descricao", p.DescricaoProduto);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);

            if (p.FotoProduto == null)
                cmd.Parameters["@foto"].Value = DBNull.Value;
            else
                cmd.Parameters["@foto"].Value = p.FotoProduto;

            cmd.Parameters.AddWithValue("@valorpago", p.ValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", p.ValorVenda);
            cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
            cmd.Parameters.AddWithValue("@unidademedida", p.UnidadeMedida);
            cmd.Parameters.AddWithValue("@categoria", p.Categoria);
            cmd.Parameters.AddWithValue("@subcategoria", p.SubCategoria);
            cmd.Parameters.AddWithValue("@codigo", p.CodigoProduto);

            CONEXAO.Conectar();

            cmd.ExecuteNonQuery();

            CONEXAO.Desconectar();
        }

        public DataTable Localizar(string s) 
        {
            string sqlQuery = "select * from produto where pro_nome like '%" + s + "%'; ";

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, CONEXAO.StringConexao);

            da.Fill(tabela);

            return tabela;
        }

        public ModeloProduto carregaProduto(int codigo) 
        {
            ModeloProduto m = new ModeloProduto();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONEXAO.objConexao;
            cmd.CommandText = "select * from produto where pro_cod = " + codigo.ToString() + ";";

            CONEXAO.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows) 
            {
                registro.Read();

                m.CodigoProduto = Convert.ToInt32(registro["pro_cod"]);
                m.NomeProduto = Convert.ToString(registro["pro_nome"]);
                m.DescricaoProduto = Convert.ToString(registro["pro_descricao"]);

                try
                {
                    m.FotoProduto = (byte[])registro["pro_foto"];
                }
                catch { }

                m.ValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                m.ValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                m.Quantidade = Convert.ToInt32(registro["pro_qtde"]);
                m.UnidadeMedida = Convert.ToInt32(registro["umed_cod"]);
                m.Categoria = Convert.ToInt32(registro["cat_cod"]);
                m.SubCategoria = Convert.ToInt32(registro["scat_cod"]);
            }

            CONEXAO.Desconectar();
                        
            return m;
        }
    }
}
