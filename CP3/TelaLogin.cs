using CP3.Estrutura.Controller;
using CP3.Estrutura.Repository;
using CP3.Estrutura.UI;

namespace CP3
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            bool validacao = controller.validarUsuarioSenha(textBox_RM.Text, textBox_Senha.Text);

            if (validacao)
            {
                MessageBox.Show("Login realizado com sucesso!");
                TelaMenu menu = new TelaMenu();
                menu.Show();       // Abre a nova janela
                this.Hide();       // Oculta a tela de login

                // Encerra tudo quando TelaMenu for fechada
                menu.FormClosed += (s, args) => this.Close();
            }
            else
            {
                label_LoginInvalido.Visible = true;
                textBox_RM.Clear();
                textBox_Senha.Clear();
            }
        }
    }
}
