using BLL;
using DAL;
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
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarCategoria(txtSubCategoria.Text);
            txtSubCategoria.Focus();
        }

        private void CarregarCategoria(string dados)
        {

            // Objeto conexão
            DALConexao con = new DALConexao(DadosConexao.StringConexao);

            //Objeto categoria regras e manipulação de dados
            BLLSubCategoria sc = new BLLSubCategoria(con);

            dgvDadosSubCategoria.DataSource = sc.Localizar(dados);
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            CarregarCategoria("");

            dgvDadosSubCategoria.Columns[0].HeaderText = "Código SubCategoria";
            dgvDadosSubCategoria.Columns[0].Width = 150;
            dgvDadosSubCategoria.Columns[1].HeaderText = "SubCategoria Descrição";
            dgvDadosSubCategoria.Columns[1].Width = 200;
            dgvDadosSubCategoria.Columns[2].HeaderText = "Categoria Descrição";
            dgvDadosSubCategoria.Columns[2].Width = 235;
        }

        private void dgvDadosSubCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dgvDadosSubCategoria.Rows[e.RowIndex].Cells[0].Value);
                
                this.Close();
            }
        }
    }
}
