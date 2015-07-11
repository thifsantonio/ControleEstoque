using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Categoria regra de negocio
namespace BLL
{
    public class BLLCategoria
    {
        private DALConexao CONEXAO;

        public BLLCategoria(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloCategoria c) 
        {
            if (c.NomeCategoria.Trim().Length == 0) 
            {
                throw new Exception("O nome da categoria é obrigatorio.");
            }

            DALCategoria da = new DALCategoria(CONEXAO);
            da.Incluir(c);
        }

        public void Alterar(ModeloCategoria c) 
        {
            if (c.CodCategoria <= 0)
            {
                throw new Exception("Selecione uma categoria.");
            }

            DALCategoria da = new DALCategoria(CONEXAO);
            da.Alterar(c);
        }

        public void Excluir(int codigo) 
        {
            DALCategoria da = new DALCategoria(CONEXAO);
            da.Excluir(codigo);
        }

        public DataTable Localizar(String s) 
        {
            DALCategoria da = new DALCategoria(CONEXAO);
            
            return da.Localizar(s);
        }

        public ModeloCategoria carregaCategoria(int codigo) 
        {
            DALCategoria da = new DALCategoria(CONEXAO);

            return da.carregaCategoria(codigo);
        }
    }
}
