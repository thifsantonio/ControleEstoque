using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosConexao
    {
        public static String StringConexao 
        {
            get 
            {
                return "Data Source=" + Environment.MachineName.ToString() + "\\HOMEDRMC;Initial Catalog=ControleEstoque;Integrated Security=True";
            }
        }
    }
}