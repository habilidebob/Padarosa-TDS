namespace Padarosa
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.txbNumeroFicha = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Square721 BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(47, 31);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(297, 33);
            this.lblNumeroComanda.TabIndex = 1;
            this.lblNumeroComanda.Text = "NÚMERO COMANDA:";
            // 
            // txbNumeroFicha
            // 
            this.txbNumeroFicha.Font = new System.Drawing.Font("Square721 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroFicha.Location = new System.Drawing.Point(350, 23);
            this.txbNumeroFicha.MaxLength = 3;
            this.txbNumeroFicha.Name = "txbNumeroFicha";
            this.txbNumeroFicha.Size = new System.Drawing.Size(219, 47);
            this.txbNumeroFicha.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackgroundImage = global::Padarosa.Properties.Resources.go;
            this.btnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.ForeColor = System.Drawing.Color.Green;
            this.btnListar.Location = new System.Drawing.Point(575, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 47);
            this.btnListar.TabIndex = 3;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::Padarosa.Properties.Resources.cash_register;
            this.pibIcone.Location = new System.Drawing.Point(53, 412);
            this.pibIcone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(411, 111);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 0;
            this.pibIcone.TabStop = false;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(35, 82);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(768, 276);
            this.dgvCaixa.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Square721 BT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(578, 393);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 42);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // chbPagamentoRecebido
            // 
            this.chbPagamentoRecebido.AutoSize = true;
            this.chbPagamentoRecebido.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoRecebido.Location = new System.Drawing.Point(546, 453);
            this.chbPagamentoRecebido.Name = "chbPagamentoRecebido";
            this.chbPagamentoRecebido.Size = new System.Drawing.Size(245, 30);
            this.chbPagamentoRecebido.TabIndex = 6;
            this.chbPagamentoRecebido.Text = "Pagamento Recebido";
            this.chbPagamentoRecebido.UseVisualStyleBackColor = true;
            this.chbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.chbPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.Green;
            this.btnEncerrar.Location = new System.Drawing.Point(532, 499);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(271, 55);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 576);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamentoRecebido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbNumeroFicha);
            this.Controls.Add(this.lblNumeroComanda);
            this.Controls.Add(this.pibIcone);
            this.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCaixa";
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.TextBox txbNumeroFicha;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrar;
    }
}