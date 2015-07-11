using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUnidadeMedida : GUI.FormularioModeloCadastro
    {
        public frmCadastroUnidadeMedida()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "INSERIR";
            this.AlteraBotoes(2);
            txtUnidadeMedida.Focus();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida tela = new frmConsultaUnidadeMedida();
            tela.ShowDialog();

            if (tela.codigo != 0)
            {
                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLUnidadeMedida um = new BLLUnidadeMedida(con);

                ModeloUnidadeMedida m = um.carregaUnidadeMedida(tela.codigo);

                txtCodigo.Text = m.UnidadeMedidaCodigo.ToString();
                txtUnidadeMedida.Text = m.UnidadeMedidaNome;

                this.AlteraBotoes(3);
            }
            else
            {
                this.LimparCampos();
                this.AlteraBotoes(1);
            }

            tela.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "ALTERAR";
            this.AlteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mensagem = MessageBox.Show("Desaja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (mensagem.ToString().Equals("Yes"))
                {
                    DALConexao con = new DALConexao(DadosConexao.StringConexao);

                    BLLUnidadeMedida um = new BLLUnidadeMedida(con);

                    um.Excluir(Convert.ToInt32(txtCodigo.Text));

                    this.LimparCampos();

                    this.AlteraBotoes(1);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao excluir registro");

                this.AlteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeMedida m = new ModeloUnidadeMedida();
                m.UnidadeMedidaNome = txtUnidadeMedida.Text;

                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLUnidadeMedida um = new BLLUnidadeMedida(con);

                if (this.operacao == "INSERIR") //Cadastro           
                {
                    um.Incluir(m);

                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + m.UnidadeMedidaCodigo.ToString());
                }
                else //Alterar 
                {
                    if (txtUnidadeMedida.Modified)
                    {
                        m.UnidadeMedidaCodigo = Convert.ToInt32(txtCodigo.Text);

                        um.Alterar(m);

                        MessageBox.Show("Cadastro alterado com sucesso.");
                    }
                }

                this.LimparCampos();

                this.AlteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();

            this.AlteraBotoes(1);

            this.Focus();
        }
    }
}
