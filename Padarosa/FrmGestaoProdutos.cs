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
    public partial class FrmGestaoProdutos : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.Categoria categoria = new Model.Categoria();

        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;


            // Obter as categorias do banco:
            DataTable resultadoCategorias = categoria.Listar();

            foreach (DataRow linha in resultadoCategorias.Rows)
            {
                // Exemplo: 1 - Alimentação:
                // Adicionar ao ComboBox:
                cmbCategoriasCadastrar.Items.Add($"{linha["id"]} - {linha["nome"]}");
                //cmbCategoriasEditar.Items.Add($"{linha["id"]} - {linha["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // VALIDAR A ENTRADA DO USUÁRIO!!!!! (PENDENTE)

            // Obter os dados dos textboxes:
            this.produto.Nome = txbCadastroNome.Text;
            this.produto.Preco = double.Parse(txbCadastroPreco.Text);
            //this.produto.IdCategoria = int.Parse(txbCadastroCategoria.Text);
            // Obter apenas o id da categoria do combobox
            this.produto.IdCategoria = int.Parse(cmbCategoriasCadastrar.Text.Split('-')[0]);

            // Obter o id do usuário que está logado:
            this.produto.IdRespCadastro = usuario.Id;

            // Corrigir abaixo!
            if (this.produto.Cadastrar())
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("DES-OK");
            }

        }
    }
}
