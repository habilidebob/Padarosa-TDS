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
    public partial class FrmCaixa : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbNumeroFicha.Text == "" || txbNumeroFicha.Text.Length < 2)
            {
                MessageBox.Show("Informe corretamente o número da ficha!",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordemComanda.IdFicha = int.Parse(txbNumeroFicha.Text);
                DataTable consulta = ordemComanda.BuscarFicha();

                // Verificar se existem lançamentos na comanda:
                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existem lançamentos nessa comanda!",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mostrar a consulta no dgv:
                    dgvCaixa.DataSource = consulta;
                    // Obter o total em decimal para depois adicionar a vírgula:
                    decimal valor = decimal.Parse(consulta.Compute("Sum(Total_Item)", "True").ToString());
                    // Mostrar o total no lblTotal:
                    lblTotal.Text = "R$ " + valor.ToString("F");
                }
            }
        }

        private void chbPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar ou desativar o btnEncerrar:
            btnEncerrar.Enabled = chbPagamentoRecebido.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
                $"Tem certeza que deseja encerrar a comanda {ordemComanda.IdFicha}?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(pergunta == DialogResult.Yes)
            {
                if (ordemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda encerrada!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information );
                    // Desabilitar o botão de encerrar e o chb:
                    btnEncerrar.Enabled = false;
                    chbPagamentoRecebido.Checked = false;
                    // Limpar o dgv:
                    dgvCaixa.DataSource = null;
                    // Apagar o número da comanda:
                    txbNumeroFicha.Clear();
                    // Resetar o lblTotal:
                    lblTotal.Text = "R$ 0,00";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda!",
                        "Erro!", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
        }
    }
}
