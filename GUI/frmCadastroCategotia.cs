using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmCadastroCategotia : GUI.FormularioModeloCadastro
    {
        public frmCadastroCategotia()
        {
            InitializeComponent();
        }

        public void LimparCampos() 
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
        }

        private void frmCadastroCategotia_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "INSERIR";
            this.AlteraBotoes(2);
            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();

            this.AlteraBotoes(1);

            this.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloCategoria m = new ModeloCategoria();
                m.NomeCategoria = txtDescricao.Text;

                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLCategoria c = new BLLCategoria(con);

                if (this.operacao == "INSERIR") //Cadastro           
                {
                    c.Incluir(m);

                    MessageBox.Show("Cadastro efetuado com sucesso: Código " + m.CodCategoria.ToString());
                }
                else //Alterar 
                {
                    m.CodCategoria = Convert.ToInt32(txtCodigo.Text);

                    c.Alterar(m);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "ALTERAR";
            this.AlteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {                                
                DialogResult mensagem = MessageBox.Show("Desaja excluir o registro?", "Aviso",MessageBoxButtons.YesNo);

                if (mensagem.ToString().Equals("Yes")) 
                {
                    DALConexao con = new DALConexao(DadosConexao.StringConexao);

                    BLLCategoria c = new BLLCategoria(con);

                    c.Excluir(Convert.ToInt32(txtCodigo.Text));

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
            frmConsultaCategoria tela = new frmConsultaCategoria();
            tela.ShowDialog();

            if (tela.codigo != 0)
            {
                DALConexao con = new DALConexao(DadosConexao.StringConexao);

                BLLCategoria c = new BLLCategoria(con);

                ModeloCategoria m = c.carregaCategoria(tela.codigo);

                txtCodigo.Text = m.CodCategoria.ToString();
                txtDescricao.Text = m.NomeCategoria;

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