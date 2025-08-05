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
    public partial class FrmComandas : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;

        Model.Produto produto = new Model.Produto();
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();

        public FrmComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv(); 
        }

        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produto.Listar();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos foram preenchidos:
            if(txbComanda.Text == "")
            {
                MessageBox.Show("Informe o número da comanda!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txbProduto.Text == "")
            {
                MessageBox.Show("Informe o código do produto!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Habilitar o campo de lançamento:
                grbLancamento.Enabled = true;
                txbNome.Enabled = false;

                // Desativar o grbInfos:
                grbInfos.Enabled = false;

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
            // Atribuir o ID do produto no txb:
            txbProduto.Text = dgvProdutos.Rows[linhaSelecionada].Cells[0].Value.ToString();
            // Atribuir o nome no txb:
            txbNome.Text = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();

        }

        public void ResetarCampos()
        {
            
            grbInfos.Enabled = true;
            grbLancamento.Enabled = false;

            // Limpar os campos:
            txbComanda.Clear();
            txbNome.Clear();
            txbProduto.Clear();
            txbQuantidade.Clear();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (txbQuantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show($"Tem certeza que deseja lançar " +
                    $"{txbQuantidade.Text} unidades de {txbNome.Text} na comanda {txbComanda.Text}?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                // Se "sim":
                if (r == DialogResult.Yes)
                {
                    ordemComanda.IdResp = usuario.Id;
                    ordemComanda.IdProduto = int.Parse(txbProduto.Text);
                    ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                    ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                    ordemComanda.Situacao = 1; // Inserir na comanda ativa;
                    if (ordemComanda.Cadastrar())
                    {
                        MessageBox.Show("Lançamento efetuado com sucesso!",
                            "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpar os campos:
                        ResetarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao efetuar lançamento!",
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Resetar os compos
                    ResetarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
