namespace Padarosa
{
    partial class FrmGestaoProdutos
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
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.txbCadastroPreco = new System.Windows.Forms.TextBox();
            this.lblCadastroPreco = new System.Windows.Forms.Label();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.cmbCategoriasCadastrar = new System.Windows.Forms.ComboBox();
            this.grbApagar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(28, 522);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(750, 67);
            this.grbApagar.TabIndex = 12;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(617, 25);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 36);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(18, 32);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(194, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário que deseja apagar.";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.cmbCategoriasCadastrar);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblCadastroSenha);
            this.grbCadastro.Controls.Add(this.txbCadastroPreco);
            this.grbCadastro.Controls.Add(this.lblCadastroPreco);
            this.grbCadastro.Controls.Add(this.txbCadastroNome);
            this.grbCadastro.Controls.Add(this.lblCadastroNome);
            this.grbCadastro.Location = new System.Drawing.Point(28, 350);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(372, 166);
            this.grbCadastro.TabIndex = 10;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(22, 123);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(335, 37);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Location = new System.Drawing.Point(18, 90);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(67, 13);
            this.lblCadastroSenha.TabIndex = 4;
            this.lblCadastroSenha.Text = "Id Categoria:";
            // 
            // txbCadastroPreco
            // 
            this.txbCadastroPreco.Location = new System.Drawing.Point(145, 57);
            this.txbCadastroPreco.Name = "txbCadastroPreco";
            this.txbCadastroPreco.Size = new System.Drawing.Size(212, 20);
            this.txbCadastroPreco.TabIndex = 3;
            // 
            // lblCadastroPreco
            // 
            this.lblCadastroPreco.AutoSize = true;
            this.lblCadastroPreco.Location = new System.Drawing.Point(18, 60);
            this.lblCadastroPreco.Name = "lblCadastroPreco";
            this.lblCadastroPreco.Size = new System.Drawing.Size(38, 13);
            this.lblCadastroPreco.TabIndex = 2;
            this.lblCadastroPreco.Text = "Preço:";
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(145, 28);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(212, 20);
            this.txbCadastroNome.TabIndex = 1;
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(18, 31);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(88, 13);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome Completo: ";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(28, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(771, 318);
            this.dgvProdutos.TabIndex = 9;
            // 
            // cmbCategoriasCadastrar
            // 
            this.cmbCategoriasCadastrar.FormattingEnabled = true;
            this.cmbCategoriasCadastrar.Location = new System.Drawing.Point(145, 87);
            this.cmbCategoriasCadastrar.Name = "cmbCategoriasCadastrar";
            this.cmbCategoriasCadastrar.Size = new System.Drawing.Size(212, 21);
            this.cmbCategoriasCadastrar.TabIndex = 7;
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 593);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmGestaoProdutos";
            this.Text = "FrmGestaoProdutos";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.TextBox txbCadastroPreco;
        private System.Windows.Forms.Label lblCadastroPreco;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ComboBox cmbCategoriasCadastrar;
    }
}