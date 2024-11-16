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
        private readonly object nome;
        private readonly object email;

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text.Trim();
            string email = txtEmailUsuario.Text.Trim();

            // Validação para verificar se os campos nome e e-mail foram preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Os campos Nome e Email são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        // Verifica se o e-mail já existe no banco de dados
                        string checkQuery = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Este dado já está registrado. Tente outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Adiciona o usuário se o e-mail não existir
                            string query = "INSERT INTO Usuario (Nome, Email) VALUES (@nome, @Email)";
                            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(txtIdUsuario.Text);
            string nome = txtNomeUsuario.Text;
            string email = txtEmailUsuario.Text;

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "UPDATE Usuario SET Nome = @nome, Email = @email WHERE Id = @usuarioId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                        MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(txtIdUsuario.Text);

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "DELETE FROM Usuario WHERE Id = @usuarioId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeUsuario.Text.Trim();
            string email = txtEmailUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Digite um nome ou email para consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "SELECT * FROM Usuario WHERE Nome = @nome OR Email = @email";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txtIdUsuario.Text = reader["Id"].ToString();
                                txtNomeUsuario.Text = reader["Nome"].ToString();
                                txtEmailUsuario.Text = reader["Email"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reader.Close();
                        db.CloseConnection();
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Erro ao consultar usuário (SQL): " + sqlEx.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}