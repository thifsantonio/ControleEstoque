using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeMedida
    {
        private int umed_cod;
        private String umed_nome;

        public ModeloUnidadeMedida() { }

        public ModeloUnidadeMedida(int codigo, string unidade_nome) 
        {
            this.umed_cod = codigo;
            this.umed_nome = unidade_nome;
        }

        public int UnidadeMedidaCodigo
        {
            get 
            {
                return this.umed_cod;
            }
            set 
            {
                this.umed_cod = value;
            }
        }

        public string UnidadeMedidaNome 
        {
            get 
            {
                return this.umed_nome;
            }
            set 
            {
                this.umed_nome = value;
            }
        }
    }
}
