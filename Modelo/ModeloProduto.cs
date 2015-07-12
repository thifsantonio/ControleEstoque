using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        private int _pro_cod;
        private String _pro_nome;
        private String _pro_descricao;
        private String _pro_foto;
        private Double _pro_valor_pago;
        private Double _pro_valor_venda;
        private float _pro_quantidade;
        private int _umed_codigo;
        private int _cat_codigo;
        private int _scat_codigo;

        public ModeloProduto() 
        {
            this._pro_cod = 0;
            this._pro_nome = "";
            this._pro_descricao = "";
            this._pro_foto = "";
            this._pro_valor_pago = 0.0;
            this._pro_valor_venda = 0.0;
            this._pro_quantidade = 0.0f;
            this._umed_codigo = 0;
            this._cat_codigo = 0;
            this._scat_codigo = 0;
        }

        public ModeloProduto(int args_codigo_produto, string args_nome_produto, string args_descricao_produto, string args_foto, double args_valor_pago, double args_valor_venda, float args_quantidade, int args_unidade_medida, int args_categoria, int args_sub_categoria) 
        {
            //
        }        
    }
}
