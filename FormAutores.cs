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
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
        }

        private void btnSalvarAutor_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAutor.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome do Autor é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string checkQuery = "SELECT COUNT(*) FROM Autor WHERE Nome = @nome";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                        checkCmd.Parameters.AddWithValue("@nome", nome);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Este autor já está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string query = "INSERT INTO Autor (Nome) VALUES (@nome)";
                            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Autor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar autor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarAutor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdAutor.Text, out int autorId))
            {
                MessageBox.Show("ID do autor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNomeAutor.Text.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome do Autor é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "UPDATE Autor SET Nome = @nome WHERE Id = @autorId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@autorId", autorId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Autor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum autor foi atualizado. Verifique o ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar autor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdAutor.Text, out int autorId))
            {
                MessageBox.Show("ID do autor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "DELETE FROM Autor WHERE Id = @autorId";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@autorId", autorId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Autor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum autor foi excluído. Verifique o ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir autor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnConsultarAutor_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAutor.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Digite um nome para consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        string query = "SELECT * FROM Autor WHERE Nome = @nome";
                        MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                        cmd.Parameters.AddWithValue("@nome", nome);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                txtIdAutor.Text = reader["Id"].ToString();
                                txtNomeAutor.Text = reader["Nome"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Autor não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        reader.Close();
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar autor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
