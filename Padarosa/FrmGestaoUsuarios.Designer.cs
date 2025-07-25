namespace Padarosa
{
    partial class FrmGestaoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbCadastroEmail = new System.Windows.Forms.TextBox();
            this.lblCadastroEmail = new System.Windows.Forms.Label();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditarSenha = new System.Windows.Forms.TextBox();
            this.lblEditarSenha = new System.Windows.Forms.Label();
            this.txbEditarEmail = new System.Windows.Forms.TextBox();
            this.lblEditarEmail = new System.Windows.Forms.Label();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(23, 27);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(771, 318);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbCadastroSenha);
            this.grbCadastro.Controls.Add(this.lblCadastroSenha);
            this.grbCadastro.Controls.Add(this.txbCadastroEmail);
            this.grbCadastro.Controls.Add(this.lblCadastroEmail);
            this.grbCadastro.Controls.Add(this.txbCadastroNome);
            this.grbCadastro.Controls.Add(this.lblCadastroNome);
            this.grbCadastro.Location = new System.Drawing.Point(23, 365);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(372, 166);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(18, 31);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(132, 19);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome Completo: ";
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(145, 28);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(212, 26);
            this.txbCadastroNome.TabIndex = 1;
            // 
            // txbCadastroEmail
            // 
            this.txbCadastroEmail.Location = new System.Drawing.Point(145, 57);
            this.txbCadastroEmail.Name = "txbCadastroEmail";
            this.txbCadastroEmail.Size = new System.Drawing.Size(212, 26);
            this.txbCadastroEmail.TabIndex = 3;
            // 
            // lblCadastroEmail
            // 
            this.lblCadastroEmail.AutoSize = true;
            this.lblCadastroEmail.Location = new System.Drawing.Point(18, 60);
            this.lblCadastroEmail.Name = "lblCadastroEmail";
            this.lblCadastroEmail.Size = new System.Drawing.Size(53, 19);
            this.lblCadastroEmail.TabIndex = 2;
            this.lblCadastroEmail.Text = "Email:";
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.Location = new System.Drawing.Point(145, 87);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.Size = new System.Drawing.Size(212, 26);
            this.txbCadastroSenha.TabIndex = 5;
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Location = new System.Drawing.Point(18, 90);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(59, 19);
            this.lblCadastroSenha.TabIndex = 4;
            this.lblCadastroSenha.Text = "Senha:";
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
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.btnEditar);
            this.grbEdicao.Controls.Add(this.txbEditarSenha);
            this.grbEdicao.Controls.Add(this.lblEditarSenha);
            this.grbEdicao.Controls.Add(this.txbEditarEmail);
            this.grbEdicao.Controls.Add(this.lblEditarEmail);
            this.grbEdicao.Controls.Add(this.txbEditarNome);
            this.grbEdicao.Controls.Add(this.lblEditarNome);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Location = new System.Drawing.Point(401, 365);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(372, 166);
            this.grbEdicao.TabIndex = 7;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edição";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(22, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(335, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEditarSenha
            // 
            this.txbEditarSenha.Location = new System.Drawing.Point(145, 87);
            this.txbEditarSenha.Name = "txbEditarSenha";
            this.txbEditarSenha.Size = new System.Drawing.Size(212, 26);
            this.txbEditarSenha.TabIndex = 5;
            // 
            // lblEditarSenha
            // 
            this.lblEditarSenha.AutoSize = true;
            this.lblEditarSenha.Location = new System.Drawing.Point(18, 90);
            this.lblEditarSenha.Name = "lblEditarSenha";
            this.lblEditarSenha.Size = new System.Drawing.Size(99, 19);
            this.lblEditarSenha.TabIndex = 4;
            this.lblEditarSenha.Text = "Nova Senha:";
            // 
            // txbEditarEmail
            // 
            this.txbEditarEmail.Location = new System.Drawing.Point(145, 57);
            this.txbEditarEmail.Name = "txbEditarEmail";
            this.txbEditarEmail.Size = new System.Drawing.Size(212, 26);
            this.txbEditarEmail.TabIndex = 3;
            // 
            // lblEditarEmail
            // 
            this.lblEditarEmail.AutoSize = true;
            this.lblEditarEmail.Location = new System.Drawing.Point(18, 60);
            this.lblEditarEmail.Name = "lblEditarEmail";
            this.lblEditarEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEditarEmail.TabIndex = 2;
            this.lblEditarEmail.Text = "Email:";
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(145, 28);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(212, 26);
            this.txbEditarNome.TabIndex = 1;
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Location = new System.Drawing.Point(18, 31);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(132, 19);
            this.lblEditarNome.TabIndex = 0;
            this.lblEditarNome.Text = "Nome Completo: ";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(23, 537);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(750, 67);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(18, 32);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(290, 19);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário que deseja apagar.";
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
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 625);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGestaoUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastroSenha;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.TextBox txbCadastroEmail;
        private System.Windows.Forms.Label lblCadastroEmail;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditarSenha;
        private System.Windows.Forms.Label lblEditarSenha;
        private System.Windows.Forms.TextBox txbEditarEmail;
        private System.Windows.Forms.Label lblEditarEmail;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
    }
}