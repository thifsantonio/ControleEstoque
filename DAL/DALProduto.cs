using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

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
    }
}
