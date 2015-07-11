using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        private int SubCatCod;
        private int FK_CatCod;
        private String SubCatNome;

        public ModeloSubCategoria() 
        {
            this.SubCatCod = 0;
            this.FK_CatCod = 0;
            this.SubCatNome = "";
        }

        public ModeloSubCategoria(int codsubcat, int fk_codcat, string subcatnome) 
        {
            this.SubCatCod = codsubcat;
            this.FK_CatCod = fk_codcat;
            this.SubCatNome = subcatnome;
        }

        public int CodSubCat
        {
            get 
            {
                return this.SubCatCod;
            }
            set 
            {
                this.SubCatCod = value;
            }
        }

        public int FKCatCod 
        {
            get 
            {
                return this.FK_CatCod; 
            }
            set 
            {
                this.FK_CatCod = value;
            }
        }

        public String SubCategoriaNome 
        {
            get 
            {
                return this.SubCatNome;
            }
            set 
            {
                this.SubCatNome = value;
            }
        }
    }
}
