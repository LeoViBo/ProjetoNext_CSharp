﻿using CP3.Estrutura.Controller;
using System.Web;

namespace CP3.Estrutura.UI
{
    public partial class TelaMenu : Form
    {
        public TelaMenu(string nome)
        {
            InitializeComponent();
            AtualizarLabelLogin();
            HideUI();
            labelHome_NomeUsuario.Text = nome + "!";
            label_PaginaAtual.Text = "Home";
            labelHome_Bemvindo.Show();
            labelHome_NomeUsuario.Show();
        }

        private void AtualizarLabelLogin()
        {
            // Fazer Depois:
            // Trocar nome da label baseado no rm que foi preenchido no login 
        }
        private void HideUI()
        {
            labelHome_Bemvindo.Hide();
            labelHome_NomeUsuario.Hide();
            dataGridView_Clientes.Hide();
            label_NewClienteNome.Hide();
            label_NewClientePerfil.Hide();
            textBox_NewClienteNome.Hide();
            comboBox_NewClientePerfil.Hide();
            button_AdicionarCliente.Hide();
            label_PerfilAgressivo.Hide();
            label_PerfilModerado.Hide();
            label_PerfilConservador.Hide();
        }
        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideUI();
            label_PaginaAtual.Text = "Ver Clientes";
            CarregarClientes();
            dataGridView_Clientes.Show();
        }
        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideUI();
            label_PaginaAtual.Text = "Adicionar Cliente";
            label_NewClienteNome.Show();
            label_NewClientePerfil.Show();
            textBox_NewClienteNome.Show();
            comboBox_NewClientePerfil.Show();
            button_AdicionarCliente.Show();
        }

        private void informaçõesSobrePerfilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideUI();
            label_PaginaAtual.Text = "Informações sobre Perfils";
            label_PerfilAgressivo.Show();
            label_PerfilModerado.Show();
            label_PerfilConservador.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideUI();
            label_PaginaAtual.Text = "Sair";
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideUI();
            label_PaginaAtual.Text = "Home";
            labelHome_Bemvindo.Show();
            labelHome_NomeUsuario.Show();
        }
        private void CarregarClientes()
        {
            var repo = new ClienteController();
            var lista = repo.ListarClientes();

            dataGridView_Clientes.DataSource = lista;
        }

        private void button_AdicionarCliente_Click(object sender, EventArgs e)
        {
            string nome = textBox_NewClienteNome.Text;
            string tipoPerfil = comboBox_NewClientePerfil.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(tipoPerfil))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }

            var repo = new ClienteController();
            repo.AdicionarCliente(nome, tipoPerfil);

            MessageBox.Show($"O usuário {nome} foi adicionado com sucesso!");
        }
    }
}
