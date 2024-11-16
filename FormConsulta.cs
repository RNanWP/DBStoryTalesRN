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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Database())
                {
                    if (db.OpenConnection())
                    {
                        // Livros Disponíveis
                        string queryDisponiveis = "SELECT * FROM Livro WHERE Id NOT IN (SELECT LivroId FROM Emprestimo WHERE DataDevolucao IS NULL)";
                        MySqlDataAdapter adapterDisponiveis = new MySqlDataAdapter(queryDisponiveis, db.GetConnection());
                        DataTable tableDisponiveis = new DataTable();
                        adapterDisponiveis.Fill(tableDisponiveis);

                        // Livros Emprestados
                        string queryEmprestados = "SELECT * FROM Livro WHERE Id IN (SELECT LivroId FROM Emprestimo WHERE DataDevolucao IS NULL)";
                        MySqlDataAdapter adapterEmprestados = new MySqlDataAdapter(queryEmprestados, db.GetConnection());
                        DataTable tableEmprestados = new DataTable();
                        adapterEmprestados.Fill(tableEmprestados);

                        // Histórico por Livro
                        string queryHistoricoLivro = "SELECT * FROM Emprestimo WHERE LivroId = @livroId";
                        MySqlDataAdapter adapterHistoricoLivro = new MySqlDataAdapter(queryHistoricoLivro, db.GetConnection());
                        adapterHistoricoLivro.SelectCommand.Parameters.AddWithValue("@livroId", 1); // Substitua pelo ID do livro desejado
                        DataTable tableHistoricoLivro = new DataTable();
                        adapterHistoricoLivro.Fill(tableHistoricoLivro);

                        // Histórico por Usuário
                        string queryHistoricoUsuario = "SELECT * FROM Emprestimo WHERE UsuarioId = @usuarioId";
                        MySqlDataAdapter adapterHistoricoUsuario = new MySqlDataAdapter(queryHistoricoUsuario, db.GetConnection());
                        adapterHistoricoUsuario.SelectCommand.Parameters.AddWithValue("@usuarioId", 1); // Substitua pelo ID do usuário desejado
                        DataTable tableHistoricoUsuario = new DataTable();
                        adapterHistoricoUsuario.Fill(tableHistoricoUsuario);

                        // Unindo todas as tabelas
                        DataTable mergedTable = new DataTable();
                        mergedTable.Merge(tableDisponiveis);
                        mergedTable.Merge(tableEmprestados);
                        mergedTable.Merge(tableHistoricoLivro);
                        mergedTable.Merge(tableHistoricoUsuario);

                        dataGridView1.DataSource = mergedTable;
                        db.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar tabelas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
