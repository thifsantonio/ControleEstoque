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
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void CarregarCategoria(string dados)
        {

            // Objeto conexão
            DALConexao con = new DALConexao(DadosConexao.StringConexao);

            //Objeto categoria regras e manipulação de dados
            BLLCategoria c = new BLLCategoria(con);

            dgvDadosCategoria.DataSource = c.Localizar(dados);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarCategoria(txtDesCategoria.Text);
            txtDesCategoria.Focus();
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            CarregarCategoria("");
            dgvDadosCategoria.Columns[1].Width = 474;
        }

        private void dgvDadosCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dgvDadosCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
