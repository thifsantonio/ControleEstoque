using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeMedida
    {
        private DALConexao CONEXAO;

        public BLLUnidadeMedida(DALConexao con) 
        {
            this.CONEXAO = con;
        }

        private bool UnidadeMedidaExiste(ModeloUnidadeMedida um) 
        {
            bool retorno;
            DataTable tabela = new DataTable();
            tabela = this.Localizar(um.UnidadeMedidaNome);

            if (tabela.Rows.Count > 0)
            {
                if (tabela.Rows[0]["umed_nome"].ToString().ToUpper() == um.UnidadeMedidaNome.ToUpper())
                    retorno = true;
                else
                    retorno = false;                
            }
            else
                retorno = false;

            return retorno;
        }

        public void Incluir(ModeloUnidadeMedida um)
        {
            if (um.UnidadeMedidaNome.Trim().Length == 0) //Verifica o nome.
            {
                throw new Exception("O nome da Unidade de Medida é obrigatorio.");
            }

            if (this.UnidadeMedidaExiste(um)) //Verifica se ja existe uma unidade de medida cadastrada.
            {
                throw new Exception("Unidade de medida ja cadastrada.");
            }

            DALUnidadeMedida da = new DALUnidadeMedida(CONEXAO);
            da.Incluir(um);
        }

        public void Alterar(ModeloUnidadeMedida um)
        {
            if (um.UnidadeMedidaCodigo <= 0) //Selecionar uma unidade de medida para operação.
            {
                throw new Exception("Selecione uma Unidade de Medida.");
            }

            if (um.UnidadeMedidaNome.Trim().Length == 0) //Verifica o nome.
            {
                throw new Exception("O nome da Unidade de Medida é obrigatorio.");
            }

            if (this.UnidadeMedidaExiste(um)) //Verifica se ja existe uma unidade de medida cadastrada.
            {
                throw new Exception("Unidade de medida ja cadastrada.");
            }

            DALUnidadeMedida da = new DALUnidadeMedida(CONEXAO);
            da.Alterar(um);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeMedida da = new DALUnidadeMedida(CONEXAO);
            da.Excluir(codigo);
        }

        public DataTable Localizar(String s)
        {
            DALUnidadeMedida da = new DALUnidadeMedida(CONEXAO);

            return da.Localizar(s);
        }

        public ModeloUnidadeMedida carregaUnidadeMedida(int codigo)
        {
            DALUnidadeMedida da = new DALUnidadeMedida(CONEXAO);

            return da.carregaUnidadeMedida(codigo);
        }
    }
}
