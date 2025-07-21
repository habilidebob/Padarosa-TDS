﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("E-mail inválido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 3)
            {
                MessageBox.Show("Senha inválida ou incorreta!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Instanciar um obj do tipo usuário:
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
                // Variavel p/ armazenar o resultado do logar (SELECT):
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                // Verificar se a tabela tem ao menos uma linha:
                if(resultado.Rows.Count > 0)
                {
                    // Armazenar as infos do usuário no obj:
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];

                    // Mudar para o menu principal:
                    FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(usuario);
                    this.Hide();
                    formMenuPrincipal.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
