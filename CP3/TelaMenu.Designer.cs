namespace CP3.Estrutura.UI
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            adicionarClienteToolStripMenuItem = new ToolStripMenuItem();
            informaçõesSobrePerfilsToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            labelHome_Bemvindo = new Label();
            labelHome_NomeUsuario = new Label();
            dataGridView_Clientes = new DataGridView();
            textBox_NewClienteNome = new TextBox();
            label_PaginaAtual = new Label();
            label_NewClienteNome = new Label();
            label_NewClientePerfil = new Label();
            button_AdicionarCliente = new Button();
            comboBox_NewClientePerfil = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, clientesToolStripMenuItem, informaçõesSobrePerfilsToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verClientesToolStripMenuItem, adicionarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(206, 26);
            verClientesToolStripMenuItem.Text = "Ver Clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // adicionarClienteToolStripMenuItem
            // 
            adicionarClienteToolStripMenuItem.Name = "adicionarClienteToolStripMenuItem";
            adicionarClienteToolStripMenuItem.Size = new Size(206, 26);
            adicionarClienteToolStripMenuItem.Text = "Adicionar Cliente";
            adicionarClienteToolStripMenuItem.Click += adicionarClienteToolStripMenuItem_Click;
            // 
            // informaçõesSobrePerfilsToolStripMenuItem
            // 
            informaçõesSobrePerfilsToolStripMenuItem.Name = "informaçõesSobrePerfilsToolStripMenuItem";
            informaçõesSobrePerfilsToolStripMenuItem.Size = new Size(191, 24);
            informaçõesSobrePerfilsToolStripMenuItem.Text = "Informações sobre perfils";
            informaçõesSobrePerfilsToolStripMenuItem.Click += informaçõesSobrePerfilsToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // labelHome_Bemvindo
            // 
            labelHome_Bemvindo.AutoSize = true;
            labelHome_Bemvindo.Font = new Font("Segoe UI", 40F);
            labelHome_Bemvindo.Location = new Point(12, 115);
            labelHome_Bemvindo.Name = "labelHome_Bemvindo";
            labelHome_Bemvindo.Size = new Size(360, 89);
            labelHome_Bemvindo.TabIndex = 1;
            labelHome_Bemvindo.Text = "Bem-vindo";
            // 
            // labelHome_NomeUsuario
            // 
            labelHome_NomeUsuario.AutoSize = true;
            labelHome_NomeUsuario.Font = new Font("Segoe UI", 40F);
            labelHome_NomeUsuario.Location = new Point(12, 204);
            labelHome_NomeUsuario.Name = "labelHome_NomeUsuario";
            labelHome_NomeUsuario.Size = new Size(471, 89);
            labelHome_NomeUsuario.TabIndex = 2;
            labelHome_NomeUsuario.Text = "nome_usuario!";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(12, 77);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.RowHeadersWidth = 51;
            dataGridView_Clientes.Size = new Size(776, 361);
            dataGridView_Clientes.TabIndex = 3;
            dataGridView_Clientes.Visible = false;
            // 
            // textBox_NewClienteNome
            // 
            textBox_NewClienteNome.Font = new Font("Segoe UI", 12F);
            textBox_NewClienteNome.Location = new Point(30, 170);
            textBox_NewClienteNome.MaxLength = 100;
            textBox_NewClienteNome.Name = "textBox_NewClienteNome";
            textBox_NewClienteNome.Size = new Size(439, 34);
            textBox_NewClienteNome.TabIndex = 4;
            textBox_NewClienteNome.Visible = false;
            // 
            // label_PaginaAtual
            // 
            label_PaginaAtual.AutoSize = true;
            label_PaginaAtual.Location = new Point(700, 44);
            label_PaginaAtual.Name = "label_PaginaAtual";
            label_PaginaAtual.Size = new Size(88, 20);
            label_PaginaAtual.TabIndex = 5;
            label_PaginaAtual.Text = "PaginaAtual";
            // 
            // label_NewClienteNome
            // 
            label_NewClienteNome.AutoSize = true;
            label_NewClienteNome.Font = new Font("Segoe UI", 12F);
            label_NewClienteNome.Location = new Point(30, 139);
            label_NewClienteNome.Name = "label_NewClienteNome";
            label_NewClienteNome.Size = new Size(207, 28);
            label_NewClienteNome.TabIndex = 6;
            label_NewClienteNome.Text = "Nome do novo cliente";
            label_NewClienteNome.Visible = false;
            // 
            // label_NewClientePerfil
            // 
            label_NewClientePerfil.AutoSize = true;
            label_NewClientePerfil.Font = new Font("Segoe UI", 12F);
            label_NewClientePerfil.Location = new Point(30, 222);
            label_NewClientePerfil.Name = "label_NewClientePerfil";
            label_NewClientePerfil.Size = new Size(146, 28);
            label_NewClientePerfil.TabIndex = 7;
            label_NewClientePerfil.Text = "Perfil do cliente";
            label_NewClientePerfil.Visible = false;
            // 
            // button_AdicionarCliente
            // 
            button_AdicionarCliente.Font = new Font("Segoe UI", 20F);
            button_AdicionarCliente.Location = new Point(510, 174);
            button_AdicionarCliente.Name = "button_AdicionarCliente";
            button_AdicionarCliente.Size = new Size(268, 108);
            button_AdicionarCliente.TabIndex = 9;
            button_AdicionarCliente.Text = "Adicionar Cliente";
            button_AdicionarCliente.UseVisualStyleBackColor = true;
            button_AdicionarCliente.Visible = false;
            button_AdicionarCliente.Click += button_AdicionarCliente_Click;
            // 
            // comboBox_NewClientePerfil
            // 
            comboBox_NewClientePerfil.Font = new Font("Segoe UI", 12F);
            comboBox_NewClientePerfil.FormattingEnabled = true;
            comboBox_NewClientePerfil.Items.AddRange(new object[] { "Conservador", "Moderado", "Agressivo" });
            comboBox_NewClientePerfil.Location = new Point(30, 248);
            comboBox_NewClientePerfil.Name = "comboBox_NewClientePerfil";
            comboBox_NewClientePerfil.Size = new Size(439, 36);
            comboBox_NewClientePerfil.TabIndex = 10;
            comboBox_NewClientePerfil.Visible = false;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_NewClientePerfil);
            Controls.Add(button_AdicionarCliente);
            Controls.Add(label_NewClientePerfil);
            Controls.Add(label_NewClienteNome);
            Controls.Add(label_PaginaAtual);
            Controls.Add(textBox_NewClienteNome);
            Controls.Add(dataGridView_Clientes);
            Controls.Add(labelHome_NomeUsuario);
            Controls.Add(labelHome_Bemvindo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem verClientesToolStripMenuItem;
        private ToolStripMenuItem adicionarClienteToolStripMenuItem;
        private ToolStripMenuItem informaçõesSobrePerfilsToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label labelHome_Bemvindo;
        private Label labelHome_NomeUsuario;
        private DataGridView dataGridView_Clientes;
        private TextBox textBox_NewClienteNome;
        private Label label_PaginaAtual;
        private Label label_NewClienteNome;
        private Label label_NewClientePerfil;
        private Button button_AdicionarCliente;
        private ComboBox comboBox_NewClientePerfil;
    }
}