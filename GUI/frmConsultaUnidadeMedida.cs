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
    public partial class frmConsultaUnidadeMedida : Form
    {
        public int codigo = 0;

        public frmConsultaUnidadeMedida()
        {
            InitializeComponent();
        }

        private void CarregaUnidadeMedida(string dados) 
        {
            // Objeto conexão
            DALConexao con = new DALConexao(DadosConexao.StringConexao);

            //Objeto categoria regras e manipulação de dados
            BLLUnidadeMedida um = new BLLUnidadeMedida(con);

            dgvUnidadeMedida.DataSource = um.Localizar(dados);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaUnidadeMedida(txtUnidadeMedidaNome.Text);
            txtUnidadeMedidaNome.Focus();
        }

        private void frmConsultaUnidadeMedida_Load(object sender, EventArgs e)
        {
            CarregaUnidadeMedida("");

            dgvUnidadeMedida.Columns[0].HeaderText = "Código Unidade de Medida";
            dgvUnidadeMedida.Columns[0].Width = 180;
            dgvUnidadeMedida.Columns[1].HeaderText = "Descrição";
            dgvUnidadeMedida.Columns[1].Width = 403;
        }

        private void dgvUnidadeMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dgvUnidadeMedida.Rows[e.RowIndex].Cells[0].Value);
               
                this.Close();
            }
        }
    }
}
