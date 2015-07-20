using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao CONEXAO;

        public BLLProduto(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloProduto p) 
        {
            if (p.DescricaoProduto.Trim().Length == 0)
            {
                throw new Exception("A descrição do Produto é obrigatoria.");
            }

            if (p.NomeProduto.Trim().Length == 0) 
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            if (p.ValorVenda <= 0) 
            {
                throw new Exception("O valor da venda deve ser maior que zero.");
            }

            if (p.Quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }

            if (p.Quantidade > 1000) 
            {
                throw new Exception("Valor maximo da quantidade alcaçado para esta operação, o valor deve ser menor ou igual a mil.");
            }

            if (p.UnidadeMedida <= 0) 
            {
                throw new Exception("Unidade de medida deve ser informada.");
            }

            if (p.Categoria <= 0) 
            {
                throw new Exception("A Categoria deve ser informada.");
            }

            if (p.SubCategoria <= 0) 
            {
                throw new Exception("A SubCategoria deve ser informada.");
            }

            DALProduto da = new DALProduto(CONEXAO);
            da.Incluir(p);
        }

        public void Alterar(ModeloProduto p) 
        {

        }

        public void Excluir(int codigo) 
        { 

        }

        public DataTable Localizar(string s) 
        {
            return null;
        }

        public ModeloProduto carregaProduto(int codigo) 
        {
            return null;
        }
    }
}
