using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public DALConexao(String dadosConexao) 
        {
            this._conexao = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao 
        {
            get 
            {
                return this._stringConexao;
            }
            set 
            {
                this._stringConexao = value;
            }
        }

        public SqlConnection objConexao 
        {
            get 
            {
                return this._conexao;
            }

            set 
            {
                this._conexao = value;
            }
        }

        public void Conectar() 
        {
            this._conexao.Open();
        }

        public void Desconectar() 
        {
            this._conexao.Close();
        }
    }
}
