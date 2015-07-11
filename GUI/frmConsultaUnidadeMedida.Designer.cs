namespace GUI
{
    partial class frmConsultaUnidadeMedida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidadeMedidaNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvUnidadeMedida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadeMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade de Medida:";
            // 
            // txtUnidadeMedidaNome
            // 
            this.txtUnidadeMedidaNome.Location = new System.Drawing.Point(12, 25);
            this.txtUnidadeMedidaNome.Name = "txtUnidadeMedidaNome";
            this.txtUnidadeMedidaNome.Size = new System.Drawing.Size(548, 20);
            this.txtUnidadeMedidaNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(566, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 26);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvUnidadeMedida
            // 
            this.dgvUnidadeMedida.AllowUserToAddRows = false;
            this.dgvUnidadeMedida.AllowUserToDeleteRows = false;
            this.dgvUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadeMedida.Location = new System.Drawing.Point(12, 70);
            this.dgvUnidadeMedida.Name = "dgvUnidadeMedida";
            this.dgvUnidadeMedida.ReadOnly = true;
            this.dgvUnidadeMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidadeMedida.Size = new System.Drawing.Size(627, 319);
            this.dgvUnidadeMedida.TabIndex = 4;
            this.dgvUnidadeMedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadeMedida_CellDoubleClick);
            // 
            // frmConsultaUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 401);
            this.Controls.Add(this.dgvUnidadeMedida);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtUnidadeMedidaNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultaUnidadeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Unidade de Medida";
            this.Load += new System.EventHandler(this.frmConsultaUnidadeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadeMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnidadeMedidaNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvUnidadeMedida;
    }
}