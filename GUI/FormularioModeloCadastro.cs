using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormularioModeloCadastro : Form
    {
        public String operacao;

        public FormularioModeloCadastro()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op) 
        {
            // 1 Prepara os botoes para inserir e localiza
            // 2 Prepara os botoes para inserir/alterar um registro
            // 3 Prepara a tela para exluir ou alterar

            pnlDados.Enabled    = false;
            btnAlterar.Enabled   = false;
            btnCancelar.Enabled  = false;
            btnExcluir.Enabled   = false;
            btnInserir.Enabled   = false;
            btnLocalizar.Enabled = false;
            btnSalvar.Enabled    = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }

            if (op == 2) 
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                pnlDados.Enabled = true;
            }

            if (op == 3) 
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void FormularioModeloCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void FormularioModeloCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
