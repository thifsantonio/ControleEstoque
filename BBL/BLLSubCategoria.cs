//Dener Carvalho
//Regras de negócio subcategoria.
//==========================================================================//
/*Classe para validar as regras de negócio do modulo subcategoria.
 *Abaixo segues as funções de validação. 
*/
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
    public class BLLSubCategoria
    {
        private DALConexao CONEXAO;

        public BLLSubCategoria(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        public void Incluir(ModeloSubCategoria sc)
        {
            if (sc.SubCategoriaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio.");
            }

            if (sc.FKCatCod <= 0) 
            {
                throw new Exception("Informe a Categoria da Sub-Categoria.");
            }

            DALSubCategoria da = new DALSubCategoria(CONEXAO);
            da.Incluir(sc);
        }

        public void Alterar(ModeloSubCategoria sc)
        {
            if (sc.CodSubCat <= 0)
            {
                throw new Exception("Selecione uma categoria.");
            }

            if (sc.SubCategoriaNome.Trim().Length == 0)
            {
                throw new Exception(" O nome da categoria é obrigatorio.");
            }

            if (sc.FKCatCod <= 0)
            {
                throw new Exception(" Informe a Categoria da Sub-Categoria.");
            }

            DALSubCategoria da = new DALSubCategoria(CONEXAO);
            da.Alterar(sc);
        }

        public void Excluir(int codigo)
        {
            DALSubCategoria da = new DALSubCategoria(CONEXAO);
            da.Excluir(codigo);
        }

        public DataTable Localizar(String s)
        {
            DALSubCategoria da = new DALSubCategoria(CONEXAO);

            return da.Localizar(s);
        }

        public ModeloSubCategoria carregaSubCategoria(int codigo)
        {
            DALSubCategoria da = new DALSubCategoria(CONEXAO);

            return da.carregaSubCategoria(codigo);
        }
    }
}
