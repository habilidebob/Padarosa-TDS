namespace Padarosa
{
    partial class FrmComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComandas));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInfos = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblQtdInfo = new System.Windows.Forms.Label();
            this.lblProdutoInfo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInfos.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(330, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(485, 561);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbInfos
            // 
            this.grbInfos.Controls.Add(this.btnContinuar);
            this.grbInfos.Controls.Add(this.txbProduto);
            this.grbInfos.Controls.Add(this.txbComanda);
            this.grbInfos.Controls.Add(this.lblProduto);
            this.grbInfos.Controls.Add(this.lblComanda);
            this.grbInfos.Location = new System.Drawing.Point(12, 12);
            this.grbInfos.Name = "grbInfos";
            this.grbInfos.Size = new System.Drawing.Size(312, 220);
            this.grbInfos.TabIndex = 1;
            this.grbInfos.TabStop = false;
            this.grbInfos.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnContinuar.Location = new System.Drawing.Point(16, 142);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(283, 45);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Square721 BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(152, 79);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(137, 43);
            this.txbProduto.TabIndex = 3;
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Square721 BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(152, 28);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(137, 43);
            this.txbComanda.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(18, 84);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(118, 29);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(18, 37);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(128, 29);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbNome);
            this.grbLancamento.Controls.Add(this.lblQtdInfo);
            this.grbLancamento.Controls.Add(this.lblProdutoInfo);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(12, 253);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(312, 181);
            this.grbLancamento.TabIndex = 2;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLancar.Location = new System.Drawing.Point(16, 121);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(283, 45);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(123, 69);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(166, 37);
            this.txbQuantidade.TabIndex = 7;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(123, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(166, 37);
            this.txbNome.TabIndex = 5;
            // 
            // lblQtdInfo
            // 
            this.lblQtdInfo.AutoSize = true;
            this.lblQtdInfo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdInfo.Location = new System.Drawing.Point(12, 74);
            this.lblQtdInfo.Name = "lblQtdInfo";
            this.lblQtdInfo.Size = new System.Drawing.Size(105, 20);
            this.lblQtdInfo.TabIndex = 6;
            this.lblQtdInfo.Text = "Quantidade:";
            // 
            // lblProdutoInfo
            // 
            this.lblProdutoInfo.AutoSize = true;
            this.lblProdutoInfo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoInfo.Location = new System.Drawing.Point(37, 37);
            this.lblProdutoInfo.Name = "lblProdutoInfo";
            this.lblProdutoInfo.Size = new System.Drawing.Size(80, 20);
            this.lblProdutoInfo.TabIndex = 5;
            this.lblProdutoInfo.Text = "Produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(12, 528);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(312, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 585);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInfos);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmComandas";
            this.Text = "Lançamento de Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInfos.ResumeLayout(false);
            this.grbInfos.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInfos;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblQtdInfo;
        private System.Windows.Forms.Label lblProdutoInfo;
        private System.Windows.Forms.Button btnCancelar;
    }
}