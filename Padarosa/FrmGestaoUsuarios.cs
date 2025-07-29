using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class FrmGestaoUsuarios : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Puxar o dados da tabela "usuário":
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbCadastroEmail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é inválido!", "Erro!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastroNome.Text.Length < 7)
            {
                MessageBox.Show("Nome informado vazio ou inválido!", "Erro!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastroSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia o cadastro no bd:
                // Instanciar o usuario:
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbCadastroEmail.Text;
                usuario.NomeCompleto = txbCadastroNome.Text;
                usuario.Senha = txbCadastroSenha.Text;

                if(usuario.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos do cadastro:
                    txbCadastroEmail.Clear();
                    txbCadastroNome.Clear();
                    txbCadastroSenha.Clear();
                    // Atualizar o dgv (reexecutar o SELECT):
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validação de erro:
            if (txbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é inválido!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("Nome informado vazio ou inválido!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarSenha.Text.Length >=1 && txbEditarSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia a edição no bd:
                // Obter os valores dos txbs de editar:
                this.usuario.NomeCompleto = txbEditarNome.Text;
                this.usuario.Email = txbEditarEmail.Text;
                this.usuario.Senha = txbEditarSenha.Text;

                // Executar o .Modificar():
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();

                    // Limpar o campos e desabilitar os grbs:
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbEditarNome.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário!", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                // Executar o delete no bd

                // o id já está no usuário global!
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuário removido com sucesso!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();

                    // Limpar o campos e desabilitar os grbs:
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbEditarNome.Clear();
                    lblApagar.Text = "Selecione o usuário que deseja apagar.";
                }
                else
                {
                    MessageBox.Show("Falha ao remover o usuário!", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvUsuarios.SelectedCells[0].RowIndex;

            this.usuario.NomeCompleto = dgvUsuarios.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email = dgvUsuarios.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)dgvUsuarios.Rows[linhaSelecionada].Cells[0].Value;
            

            // Atribuir os dados da linha selecionada no grbEditar:
            txbEditarNome.Text = this.usuario.NomeCompleto;
            txbEditarEmail.Text = this.usuario.Email;
            // Ativar o grbEdicao:
            grbEdicao.Enabled = true;

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
            lblApagar.Text = $"{this.usuario.Id} - {this.usuario.NomeCompleto}";

        }
    }
}
