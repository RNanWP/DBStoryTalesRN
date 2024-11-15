namespace StoryTales_RN___Trabalho_Final
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            FormLivros formLivros = new FormLivros();
            formLivros.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FormAutores formAutores = new FormAutores();
            formAutores.ShowDialog();
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            FormEmprestimos formEmprestimos = new FormEmprestimos();
            formEmprestimos.ShowDialog();
        }
    }
}