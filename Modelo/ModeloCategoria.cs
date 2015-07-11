using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        private int cat_cod;
        private String cat_nome;

        public ModeloCategoria() 
        {
            this.cat_cod = 0;
            this.cat_nome = "";
        }

        public ModeloCategoria(int catcod, string catnome) 
        {
            this.cat_cod = catcod;
            this.cat_nome = catnome;
        }

        public int CodCategoria 
        {
            get 
            { 
                return this.cat_cod; 
            }

            set 
            {
                this.cat_cod = value;
            }
        }

        public string NomeCategoria 
        {
            get 
            {
                return this.cat_nome;
            }

            set 
            {
                this.cat_nome = value;
            }
        }
    }
}
