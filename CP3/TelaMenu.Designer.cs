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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
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
            label_PerfilConservador = new Label();
            label_PerfilModerado = new Label();
            label_PerfilAgressivo = new Label();
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verClientesToolStripMenuItem, adicionarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(165, 22);
            verClientesToolStripMenuItem.Text = "Ver Clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // adicionarClienteToolStripMenuItem
            // 
            adicionarClienteToolStripMenuItem.Name = "adicionarClienteToolStripMenuItem";
            adicionarClienteToolStripMenuItem.Size = new Size(165, 22);
            adicionarClienteToolStripMenuItem.Text = "Adicionar Cliente";
            adicionarClienteToolStripMenuItem.Click += adicionarClienteToolStripMenuItem_Click;
            // 
            // informaçõesSobrePerfilsToolStripMenuItem
            // 
            informaçõesSobrePerfilsToolStripMenuItem.Name = "informaçõesSobrePerfilsToolStripMenuItem";
            informaçõesSobrePerfilsToolStripMenuItem.Size = new Size(152, 20);
            informaçõesSobrePerfilsToolStripMenuItem.Text = "Informações sobre perfils";
            informaçõesSobrePerfilsToolStripMenuItem.Click += informaçõesSobrePerfilsToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // labelHome_Bemvindo
            // 
            labelHome_Bemvindo.AutoSize = true;
            labelHome_Bemvindo.Font = new Font("Segoe UI", 40F);
            labelHome_Bemvindo.Location = new Point(10, 86);
            labelHome_Bemvindo.Name = "labelHome_Bemvindo";
            labelHome_Bemvindo.Size = new Size(292, 72);
            labelHome_Bemvindo.TabIndex = 1;
            labelHome_Bemvindo.Text = "Bem-vindo";
            // 
            // labelHome_NomeUsuario
            // 
            labelHome_NomeUsuario.AutoSize = true;
            labelHome_NomeUsuario.Font = new Font("Segoe UI", 40F);
            labelHome_NomeUsuario.Location = new Point(10, 153);
            labelHome_NomeUsuario.Name = "labelHome_NomeUsuario";
            labelHome_NomeUsuario.Size = new Size(381, 72);
            labelHome_NomeUsuario.TabIndex = 2;
            labelHome_NomeUsuario.Text = "nome_usuario!";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(10, 58);
            dataGridView_Clientes.Margin = new Padding(3, 2, 3, 2);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.RowHeadersWidth = 51;
            dataGridView_Clientes.Size = new Size(679, 286);
            dataGridView_Clientes.TabIndex = 3;
            dataGridView_Clientes.Visible = false;
            // 
            // textBox_NewClienteNome
            // 
            textBox_NewClienteNome.Font = new Font("Segoe UI", 12F);
            textBox_NewClienteNome.Location = new Point(26, 128);
            textBox_NewClienteNome.Margin = new Padding(3, 2, 3, 2);
            textBox_NewClienteNome.MaxLength = 100;
            textBox_NewClienteNome.Name = "textBox_NewClienteNome";
            textBox_NewClienteNome.Size = new Size(385, 29);
            textBox_NewClienteNome.TabIndex = 4;
            textBox_NewClienteNome.Visible = false;
            // 
            // label_PaginaAtual
            // 
            label_PaginaAtual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_PaginaAtual.AutoSize = true;
            label_PaginaAtual.Location = new Point(13, 31);
            label_PaginaAtual.Name = "label_PaginaAtual";
            label_PaginaAtual.Size = new Size(71, 15);
            label_PaginaAtual.TabIndex = 5;
            label_PaginaAtual.Text = "PaginaAtual";
            label_PaginaAtual.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_NewClienteNome
            // 
            label_NewClienteNome.AutoSize = true;
            label_NewClienteNome.Font = new Font("Segoe UI", 12F);
            label_NewClienteNome.Location = new Point(26, 104);
            label_NewClienteNome.Name = "label_NewClienteNome";
            label_NewClienteNome.Size = new Size(163, 21);
            label_NewClienteNome.TabIndex = 6;
            label_NewClienteNome.Text = "Nome do novo cliente";
            label_NewClienteNome.Visible = false;
            // 
            // label_NewClientePerfil
            // 
            label_NewClientePerfil.AutoSize = true;
            label_NewClientePerfil.Font = new Font("Segoe UI", 12F);
            label_NewClientePerfil.Location = new Point(26, 166);
            label_NewClientePerfil.Name = "label_NewClientePerfil";
            label_NewClientePerfil.Size = new Size(116, 21);
            label_NewClientePerfil.TabIndex = 7;
            label_NewClientePerfil.Text = "Perfil do cliente";
            label_NewClientePerfil.Visible = false;
            // 
            // button_AdicionarCliente
            // 
            button_AdicionarCliente.Font = new Font("Segoe UI", 20F);
            button_AdicionarCliente.Location = new Point(446, 130);
            button_AdicionarCliente.Margin = new Padding(3, 2, 3, 2);
            button_AdicionarCliente.Name = "button_AdicionarCliente";
            button_AdicionarCliente.Size = new Size(234, 81);
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
            comboBox_NewClientePerfil.Location = new Point(26, 190);
            comboBox_NewClientePerfil.Margin = new Padding(3, 2, 3, 2);
            comboBox_NewClientePerfil.Name = "comboBox_NewClientePerfil";
            comboBox_NewClientePerfil.Size = new Size(385, 29);
            comboBox_NewClientePerfil.TabIndex = 10;
            comboBox_NewClientePerfil.Visible = false;
            // 
            // label_PerfilConservador
            // 
            label_PerfilConservador.AutoSize = true;
            label_PerfilConservador.Font = new Font("Segoe UI", 10F);
            label_PerfilConservador.Location = new Point(16, 59);
            label_PerfilConservador.Name = "label_PerfilConservador";
            label_PerfilConservador.Size = new Size(169, 285);
            label_PerfilConservador.TabIndex = 11;
            label_PerfilConservador.Text = resources.GetString("label_PerfilConservador.Text");
            // 
            // label_PerfilModerado
            // 
            label_PerfilModerado.AutoSize = true;
            label_PerfilModerado.Font = new Font("Segoe UI", 10F);
            label_PerfilModerado.Location = new Point(203, 59);
            label_PerfilModerado.Name = "label_PerfilModerado";
            label_PerfilModerado.Size = new Size(215, 285);
            label_PerfilModerado.TabIndex = 12;
            label_PerfilModerado.Text = resources.GetString("label_PerfilModerado.Text");
            // 
            // label_PerfilAgressivo
            // 
            label_PerfilAgressivo.AutoSize = true;
            label_PerfilAgressivo.Font = new Font("Segoe UI", 10F);
            label_PerfilAgressivo.Location = new Point(436, 59);
            label_PerfilAgressivo.Name = "label_PerfilAgressivo";
            label_PerfilAgressivo.Size = new Size(248, 285);
            label_PerfilAgressivo.TabIndex = 13;
            label_PerfilAgressivo.Text = resources.GetString("label_PerfilAgressivo.Text");
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 351);
            Controls.Add(label_PerfilAgressivo);
            Controls.Add(label_PerfilModerado);
            Controls.Add(label_PerfilConservador);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label_PerfilConservador;
        private Label label_PerfilModerado;
        private Label label_PerfilAgressivo;
    }
}