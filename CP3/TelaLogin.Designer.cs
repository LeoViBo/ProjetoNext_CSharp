namespace CP3
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Login = new Button();
            label_Title = new Label();
            label_RM = new Label();
            label_Senha = new Label();
            textBox_RM = new TextBox();
            textBox_Senha = new TextBox();
            label_LoginInvalido = new Label();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.BackColor = SystemColors.HighlightText;
            button_Login.FlatAppearance.BorderColor = Color.White;
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.Font = new Font("Segoe UI", 18F);
            button_Login.Location = new Point(263, 170);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(257, 56);
            button_Login.TabIndex = 0;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI", 42F);
            label_Title.Location = new Point(12, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(538, 93);
            label_Title.TabIndex = 1;
            label_Title.Text = "NexTech - Login";
            // 
            // label_RM
            // 
            label_RM.AutoSize = true;
            label_RM.Font = new Font("Segoe UI", 12F);
            label_RM.Location = new Point(50, 148);
            label_RM.Name = "label_RM";
            label_RM.Size = new Size(42, 28);
            label_RM.TabIndex = 2;
            label_RM.Text = "RM";
            // 
            // label_Senha
            // 
            label_Senha.AutoSize = true;
            label_Senha.Font = new Font("Segoe UI", 12F);
            label_Senha.Location = new Point(38, 215);
            label_Senha.Name = "label_Senha";
            label_Senha.Size = new Size(65, 28);
            label_Senha.TabIndex = 3;
            label_Senha.Text = "Senha";
            // 
            // textBox_RM
            // 
            textBox_RM.Font = new Font("Segoe UI", 12F);
            textBox_RM.Location = new Point(109, 145);
            textBox_RM.Name = "textBox_RM";
            textBox_RM.Size = new Size(125, 34);
            textBox_RM.TabIndex = 4;
            // 
            // textBox_Senha
            // 
            textBox_Senha.Font = new Font("Segoe UI", 12F);
            textBox_Senha.Location = new Point(109, 215);
            textBox_Senha.Name = "textBox_Senha";
            textBox_Senha.Size = new Size(125, 34);
            textBox_Senha.TabIndex = 5;
            // 
            // label_LoginInvalido
            // 
            label_LoginInvalido.AutoSize = true;
            label_LoginInvalido.Font = new Font("Segoe UI", 9F);
            label_LoginInvalido.ForeColor = Color.Red;
            label_LoginInvalido.Location = new Point(306, 225);
            label_LoginInvalido.Name = "label_LoginInvalido";
            label_LoginInvalido.Size = new Size(173, 20);
            label_LoginInvalido.TabIndex = 6;
            label_LoginInvalido.Text = "*Senha e/ou RM inválido";
            label_LoginInvalido.Visible = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(548, 272);
            Controls.Add(label_LoginInvalido);
            Controls.Add(textBox_Senha);
            Controls.Add(textBox_RM);
            Controls.Add(label_Senha);
            Controls.Add(label_RM);
            Controls.Add(label_Title);
            Controls.Add(button_Login);
            Name = "TelaLogin";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private Label label_Title;
        private Label label_RM;
        private Label label_Senha;
        private TextBox textBox_RM;
        private TextBox textBox_Senha;
        private Label label_LoginInvalido;
    }
}
