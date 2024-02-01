// Importação da namespace necessária para suporte a expressões regulares
using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using System;
using System.Text.RegularExpressions; // Adicionado para suporte a expressões regulares
using System.Windows.Forms;

namespace ProjetoHumanity.Views
{
    public partial class NovoUsuario : Form
    {
        // Declaração de variáveis
        private int idUsuario;

        // Construtor do formulário, recebe o ID do usuário como parâmetro
        public NovoUsuario(int idUsuario)
        {
            InitializeComponent();

            // Atribui o ID do usuário recebido como parâmetro à propriedade do formulário
            this.idUsuario = idUsuario;

            // Atualiza a exibição do ID do usuário no formulário
            AtualizarLabelUsuario();
        }

        // Método para atualizar a exibição do ID do usuário no componente de label
        private void AtualizarLabelUsuario()
        {
            // Converte o ID do usuário para string e atribui ao texto da label
            lblID_USUARIO.Text = idUsuario.ToString();
        }

        // Evento do botão de novo usuário
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(txtNomeUser.Text) ||
                string.IsNullOrEmpty(txtEmailUser.Text) ||
                string.IsNullOrEmpty(txtLoginUser.Text) ||
                string.IsNullOrEmpty(txtSenhaUser.Text) ||
                string.IsNullOrEmpty(cbNivel.Text) ||
                string.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de e-mail
            if (!IsValidEmail(txtEmailUser.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de senha
            if (!IsValidPassword(txtSenhaUser.Text))
            {
                MessageBox.Show("A senha deve conter no mínimo 1 caractere especial e 1 número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criação de uma instância do controlador para cadastro de usuário
            ControleCadastroUser controleCadastroUser = new ControleCadastroUser();

            // Gera a senha criptografada e o salt
            var (senhaCriptografada, salt) = PasswordHasher.HashPassword(txtSenhaUser.Text);

            // Chama o método de cadastro de usuário e obtém a mensagem resultante
            String mensagem = controleCadastroUser.NovoUsuario(
                txtNomeUser.Text,
                txtEmailUser.Text,
                txtLoginUser.Text,
                cbNivel.Text,
                cbStatus.Text,
                senhaCriptografada,
                salt
            );

            // Verifica se o cadastro foi bem-sucedido
            if (controleCadastroUser.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controleCadastroUser.mensagem);
            }
        }

        // Função para validar o formato do e-mail
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Função para validar a senha
        private bool IsValidPassword(string password)
        {
            // Pelo menos 1 caractere especial e 1 número
            var regex = new Regex(@"^(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]).*(?=.*\d).*$");
            return regex.IsMatch(password);
        }

        // Evento do botão de limpar dados
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            // Limpa os dados dos controles conforme necessário
            txtNomeUser.Text = string.Empty;
            txtEmailUser.Text = string.Empty;
            txtLoginUser.Text = string.Empty;
            txtSenhaUser.Text = string.Empty;
            cbNivel.Text = string.Empty;
            cbStatus.Text = string.Empty;
        }

        // Evento do botão de cancelar cadastro
        private void btnCalcelarCadastro_Click_1(object sender, EventArgs e)
        {
            // Fecha a janela (formulário)
            this.Close();
        }

    }
}
