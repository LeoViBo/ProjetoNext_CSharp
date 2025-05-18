using CP3.Estrutura.Controller;
using CP3.Estrutura.Repository;

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
                // Aqui você pode adicionar a lógica para abrir a próxima tela ou fazer o que for necessário após o login.
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
