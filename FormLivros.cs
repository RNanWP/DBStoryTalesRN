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
    public partial class FormLivros : Form
    {
        public FormLivros()
        {
            InitializeComponent();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloLivro.Text.Trim();
            string autor = txtAutorLivro.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Os campos Nome do Livro e Autor são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        // Verificação de duplicidade
                        string checkQuery = "SELECT COUNT(*) FROM Livro WHERE Titulo = @titulo AND Autor = @autor";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                        checkCmd.Parameters.AddWithValue("@titulo", titulo);
                        checkCmd.Parameters.AddWithValue("@autor", autor);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Livro já existe no sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Inserção de novo livro
                        string query = "INSERT INTO Livro (Titulo, Autor) VALUES (@titulo, @autor)";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Livro adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAtualizarLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdLivro.Text.Trim()))
            {
                MessageBox.Show("O campo ID do Livro é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int livroId;
            if (!int.TryParse(txtIdLivro.Text.Trim(), out livroId))
            {
                MessageBox.Show("O campo ID do Livro deve ser um número inteiro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titulo = txtTituloLivro.Text.Trim();
            string autor = txtAutorLivro.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Os campos Nome do Livro e Autor são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "UPDATE Livro SET Titulo = @titulo, Autor = @autor WHERE Id = @livroId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.Parameters.AddWithValue("@livroId", livroId);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                        MessageBox.Show("Livro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            int livroId;
            if (!int.TryParse(txtIdLivro.Text.Trim(), out livroId))
            {
                MessageBox.Show("O campo ID do Livro deve ser um número inteiro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "DELETE FROM Livro WHERE Id = @livroId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@livroId", livroId);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                        MessageBox.Show("Livro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExcluirLivro_Click_1(object sender, EventArgs e)
        {
            int livroId = Convert.ToInt32(txtIdLivro.Text);

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "DELETE FROM Livro WHERE Id = @livroId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@livroId", livroId);
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                        MessageBox.Show("Livro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarLivro_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloLivro.Text.Trim();
            string autor = txtAutorLivro.Text.Trim();

            if (string.IsNullOrEmpty(titulo) && string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Digite um título ou autor para consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "SELECT * FROM Livro WHERE Titulo = @titulo OR Autor = @autor";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txtIdLivro.Text = reader["Id"].ToString();
                                txtTituloLivro.Text = reader["Titulo"].ToString();
                                txtAutorLivro.Text = reader["Autor"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Livro não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reader.Close();
                        db.CloseConnection();
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Erro ao consultar livro (SQL): " + sqlEx.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
