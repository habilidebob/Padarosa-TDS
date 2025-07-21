﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Padarosa.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email {  get; set; }
        public string Senha { get; set; }

        public DataTable Logar()
        {
            string comando = "SELECT * FROM usuarios WHERE" +
                " email = @email AND senha = @senha";


            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // Trocar os caracteres coringas pelos valores reais
            cmd.Parameters.AddWithValue("@email", Email);
            // Criar o hash da senha:
            string senhahash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", senhahash); 


            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public int Cadastrar()
        {
            // Modificar depois:
            return 0;
        }
        public DataTable Listar()
        {
            // Modificar depois
            return new DataTable();
        }

        public int Remover()
        {
            // Modificar depois:
            return 0;
        }
        public int Modificar()
        {
            // Modificar depois:
            return 0;
        }
    }
}
