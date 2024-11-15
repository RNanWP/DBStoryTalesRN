using MySql.Data.MySqlClient;
using StoryTales_Rn___Trabalho_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTales_RN___Trabalho_Final
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text;
            string email = txtEmailUsuario.Text;

            using (var db = new Database())
            {
                if (db.OpenConnection())
                {
                    string query = "INSERT INTO Usuario (Nome, Email) VALUES (@nome, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
            }
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text;
            string email = txtEmailUsuario.Text;

            using (var db = new Database())
            {
                if (db.OpenConnection())
                {
                    string query = "INSERT INTO Usuarios (Nome, Email) VALUES (@nome, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text;
            string email = txtEmailUsuario.Text;

            using (var db = new Database())
            {
                if (db.OpenConnection())
                {
                    string query = "INSERT INTO Usuarios (Nome, Email) VALUES (@nome, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
            }
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text;
            string email = txtEmailUsuario.Text;

            using (var db = new Database())
            {
                if (db.OpenConnection())
                {
                    string query = "INSERT INTO Usuarios (Nome, Email) VALUES (@nome, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
            }
        }
    }
}