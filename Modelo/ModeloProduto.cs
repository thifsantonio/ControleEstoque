using System;
using System.Collections.Generic;
using System.IO;
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
        private byte[] _pro_foto;
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
            this._pro_valor_pago = 0.0;
            this._pro_valor_venda = 0.0;
            this._pro_quantidade = 0.0f;
            this._umed_codigo = 0;
            this._cat_codigo = 0;
            this._scat_codigo = 0;
        }

        public ModeloProduto(int args_codigo_produto, string args_nome_produto, string args_descricao_produto, 
            string args_foto, double args_valor_pago, double args_valor_venda, 
            float args_quantidade, int args_unidade_medida, int args_categoria, 
            int args_sub_categoria) 
        {
            this._pro_cod = args_codigo_produto;
            this._pro_nome = args_nome_produto;
            this._pro_descricao = args_descricao_produto;
            this.CarregaImagem(args_foto);
            this._pro_valor_pago = args_valor_pago;
            this._pro_valor_venda = args_valor_venda;
            this._pro_quantidade = args_quantidade;
            this._umed_codigo = args_unidade_medida;
            this._cat_codigo = args_categoria;
            this._scat_codigo = args_sub_categoria;
        }

        public ModeloProduto(int args_codigo_produto, string args_nome_produto, string args_descricao_produto,
            byte[] args_foto, double args_valor_pago, double args_valor_venda,
            float args_quantidade, int args_unidade_medida, int args_categoria,
            int args_sub_categoria)
        {
            this._pro_cod = args_codigo_produto;
            this._pro_nome = args_nome_produto;
            this._pro_descricao = args_descricao_produto;
            this._pro_foto = args_foto;
            this._pro_valor_pago = args_valor_pago;
            this._pro_valor_venda = args_valor_venda;
            this._pro_quantidade = args_quantidade;
            this._umed_codigo = args_unidade_medida;
            this._cat_codigo = args_categoria;
            this._scat_codigo = args_sub_categoria;
        }

        public void CarregaImagem(string caminhoImagem) 
        {
            try
            {
                if (string.IsNullOrEmpty(caminhoImagem))
                    return;

                FileInfo _file = new FileInfo(caminhoImagem);

                FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read);

                this.FotoProduto = new byte[Convert.ToInt32(_file.Length)]; //Aloca memoria para o vetor

                int _iBytesRead = fs.Read(this.FotoProduto, 0, Convert.ToInt32(_file.Length)); //Leitura e gravação dos dados

                fs.Close();
            }
            catch (Exception erro) 
            {
                throw new Exception(erro.Message.ToString());
            }
        }

        public int CodigoProduto 
        {
            get 
            {
                return this._pro_cod;
            }
            set 
            {
                this._pro_cod = value;
            }
        }

        public string NomeProduto 
        {
            get 
            {
                return this._pro_nome;
            }
            set 
            {
                this._pro_nome = value;
            }
        }

        public string DescricaoProduto 
        {
            get 
            {
                return this._pro_descricao;
            }
            set 
            {
                this._pro_descricao = value;
            }
        }

        public byte[] FotoProduto 
        {
            get 
            {
                return this._pro_foto;
            }
            set 
            {
                this._pro_foto = value;
            }
        }

        public double ValorPago 
        {
            get 
            {
                return this._pro_valor_pago;
            }
            set 
            {
                this._pro_valor_pago = value;
            }
        }

        public double ValorVenda 
        {
            get 
            {
                return this._pro_valor_venda;
            }
            set 
            {
                this._pro_valor_venda = value;
            }
        }

        public float Quantidade 
        {
            get 
            {
                return this._pro_quantidade;
            }
            set 
            {
                this._pro_quantidade = value;
            }
        }

        public int UnidadeMedida 
        {
            get 
            {
                return this._umed_codigo;
            }
            set 
            {
                this._umed_codigo = value;
            }
        }

        public int Categoria 
        {
            get 
            {
                return this._cat_codigo;
            }
            set 
            {
                this._cat_codigo = value;
            }
        }

        public int SubCategoria         
        {
            get 
            {
                return this._scat_codigo;
            }
            set 
            {
                this._scat_codigo = value;
            }
        }
    }
}
