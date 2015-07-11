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
    public partial class frmPrincipal : Form
    {        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategotia tela = new frmCadastroCategotia();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria tela = new frmConsultaCategoria();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Dener Carvalho \nSistema para controle de estoque.\n\nContato: dener.carvalho@outlook.com", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria tela = new frmCadastroSubCategoria();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria tela = new frmConsultaSubCategoria();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeMedida tela = new frmCadastroUnidadeMedida();
            tela.ShowDialog();
            tela.Dispose();
        }

        private void unidadeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida tela = new frmConsultaUnidadeMedida();
            tela.ShowDialog();
            tela.Dispose();
        }       
    }
}
