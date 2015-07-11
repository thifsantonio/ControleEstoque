namespace GUI
{
    partial class FormularioModeloCadastro
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Location = new System.Drawing.Point(12, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(615, 294);
            this.pnlDados.TabIndex = 0;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Controls.Add(this.btnLocalizar);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 326);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(615, 100);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::GUI.Properties.Resources.Novo;
            this.btnInserir.Location = new System.Drawing.Point(13, 16);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 74);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
            this.btnLocalizar.Location = new System.Drawing.Point(117, 16);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 74);
            this.btnLocalizar.TabIndex = 4;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::GUI.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(221, 16);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 74);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btnSalvar.Location = new System.Drawing.Point(429, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(533, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 74);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::GUI.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(325, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 74);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormularioModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 437);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormularioModeloCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de formulario de cadastro";
            this.Load += new System.EventHandler(this.FormularioModeloCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormularioModeloCadastro_KeyDown);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlDados;
        protected System.Windows.Forms.Panel pnlBotoes;
        protected System.Windows.Forms.Button btnInserir;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnExcluir;

    }
}