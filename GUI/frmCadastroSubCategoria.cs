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
    public partial class frmCadastroSubCategoria : GUI.FormularioModeloCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimparCampos() 
        {
            txtCodigoSubCategoria.Clear();
            txtNomeSubCategoria.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);

            DALConexao con = new DALConexao(DadosConexao.StringConexao);
            BLLCategoria c = new BLLCategoria(con);

            cbCategoria.DataSource = c.Localizar("");
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Categoria";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "INSERIR";
            txtNomeSubCategoria.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            this.operacao = "ALTERAR";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSubCategoria m = new ModeloSubCategoria();
                m.SubCategoriaNome = txtNomeSubCategoria.Text;
                m.FKCatCod = Convert.ToInt32(cbCategoria.SelectedValue);

                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLSubCategoria sc = new BLLSubCategoria(con);

                if (this.operacao.Equals("INSERIR"))
                {
                    sc.Incluir(m);

                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + m.CodSubCat.ToString());
                }
                else 
                {
                    m.CodSubCat = Convert.ToInt32(txtCodigoSubCategoria.Text);

                    sc.Alterar(m);

                    MessageBox.Show("Cadastro alterado com sucesso.");
                }

                this.LimparCampos();

                this.AlteraBotoes(1);
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mensagem = MessageBox.Show("Desaja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (mensagem.ToString().Equals("Yes"))
                {
                    DALConexao con = new DALConexao(DadosConexao.StringConexao);

                    BLLSubCategoria sc = new BLLSubCategoria(con);

                    sc.Excluir(Convert.ToInt32(txtCodigoSubCategoria.Text));

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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria tela = new frmConsultaSubCategoria();
            tela.ShowDialog();

            if (tela.codigo != 0)
            {
                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLSubCategoria sc = new BLLSubCategoria(con);

                ModeloSubCategoria m = sc.carregaSubCategoria(tela.codigo);

                txtCodigoSubCategoria.Text = m.CodSubCat.ToString();
                txtNomeSubCategoria.Text   = m.SubCategoriaNome;
                cbCategoria.SelectedValue  = m.FKCatCod;


                this.AlteraBotoes(3);
            }
            else
            {
                this.LimparCampos();

                this.AlteraBotoes(1);
            }

            tela.Dispose();
        }
    }
}
