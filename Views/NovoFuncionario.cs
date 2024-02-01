using ProjetoHumanity.Controller;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// Este trecho de código pertence ao Forms de Novo Funcionário , com métodos de cadastro de Funcionários com algumas validações .


namespace ProjetoHumanity.Views
{
    public partial class NovoFuncionario : Form
    {

        private int idUsuario;

        public NovoFuncionario(int idUsuario)
        {
            // Inicializa o formulário
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

        // Evento de carregamento do formulário
        private void NovoFuncionario_Load(object sender, EventArgs e)
        {
            // Código a ser executado durante o carregamento do formulário
        }

        // Evento do botão de cancelar cadastro
        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação dos campos obrigatórios
                if (string.IsNullOrWhiteSpace(txtIdEmpresa.Text) ||
                    string.IsNullOrWhiteSpace(txtCodFunc.Text) ||
                    string.IsNullOrWhiteSpace(cbStatusFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                    string.IsNullOrWhiteSpace(cbGenero.Text) ||
                    string.IsNullOrWhiteSpace(cbEstadoCivil.Text) ||
                    string.IsNullOrWhiteSpace(txtNascimento.Text) ||
                    string.IsNullOrWhiteSpace(txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(txtRG.Text) ||
                    string.IsNullOrWhiteSpace(txtPis.Text) ||
                    string.IsNullOrWhiteSpace(txtDtAdmissao.Text) ||
                    string.IsNullOrWhiteSpace(cbTurno.Text) ||
                    string.IsNullOrWhiteSpace(txtFuncao.Text) ||
                    string.IsNullOrWhiteSpace(txtSalarioBase.Text) ||
                    string.IsNullOrWhiteSpace(txtCEP.Text) ||
                    string.IsNullOrWhiteSpace(txtRuaFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtBairroFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtCidadeFunc.Text) ||
                    string.IsNullOrWhiteSpace(cbUFFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtTelFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtEmailFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtContBanco.Text) ||
                    string.IsNullOrWhiteSpace(txtAgenciaBanc.Text) ||
                    string.IsNullOrWhiteSpace(cbTipoConta.Text) ||
                    string.IsNullOrWhiteSpace(cbVA.Text) ||
                    string.IsNullOrWhiteSpace(cbVT.Text) ||
                    string.IsNullOrWhiteSpace(txtLoginFunc.Text) ||
                    string.IsNullOrWhiteSpace(txtSenhaFunc.Text))
                {
                    MessageBox.Show("Preencha os dados Obrigatórios corretamente!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar CPF
                if (!ValidarCPF(txtCPF.Text))
                {
                    MessageBox.Show("CPF inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar e-mail
                if (!ValidarEmail(txtEmailFunc.Text))
                {
                    MessageBox.Show("E-mail inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar senha forte (alfanumérica com letras, números e caracteres especiais)
                if (!ValidarSenhaForte(txtSenhaFunc.Text))
                {
                    MessageBox.Show("A senha deve conter no minimo 8 caracteres utilizando letras, números e caracteres especiais.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Se todos os campos passaram nas validações, prossegue com o cadastro do funcionário
                ControllerFuncionario controllerFuncionario = new ControllerFuncionario();

                string mensagem = controllerFuncionario.NovoFuncionario(

                       Convert.ToInt32(txtIdEmpresa.Text),
                       txtCodFunc.Text,
                       cbStatusFunc.Text,
                       txtNomeFunc.Text,
                       cbGenero.Text,
                       cbEstadoCivil.Text,
                       Convert.ToDateTime(txtNascimento.Text),
                       txtCPF.Text,
                       txtRG.Text,
                       txtPis.Text,
                       Convert.ToDateTime(txtDtAdmissao.Text),
                       cbTurno.Text,
                       txtFuncao.Text,
                       Convert.ToDecimal(txtSalarioBase.Text),
                       txtCEP.Text,
                       txtRuaFunc.Text,
                       txtNumFunc.Text,
                       txtBairroFunc.Text,
                       txtCidadeFunc.Text,
                       txtComplFunc.Text,
                       cbUFFunc.Text,
                       txtTelFunc.Text,
                       txtEmailFunc.Text,
                       txtAgenciaBanc.Text,
                       txtContBanco.Text,
                       cbTipoConta.Text,
                       cbVA.Text,
                       cbVT.Text,
                       txtLoginFunc.Text,
                       txtSenhaFunc.Text,

                       Convert.ToInt32(lblID_USUARIO.Text)

            );

                MessageBox.Show(mensagem, "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Restante do código de tratamento do cadastro...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar funcionário: " + ex.Message);
                // Trate o erro conforme necessário
            }
        }

        private void btnLimparCad_Click(object sender, EventArgs e)
        {
            // Limpa o texto de todos os TextBoxes
            txtCodFunc.Text = "";
            txtNomeFunc.Text = "";
            txtIdEmpresa.Text = "";
            txtNascimento.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtPis.Text = "";
            txtDtAdmissao.Text = "";
            txtFuncao.Text = "";
            txtSalarioBase.Text = "";
            txtCEP.Text = "";
            txtRuaFunc.Text = "";
            txtNumFunc.Text = "";
            txtBairroFunc.Text = "";
            txtComplFunc.Text = "";
            txtCidadeFunc.Text = "";
            txtTelFunc.Text = "";
            txtEmailFunc.Text = "";
            txtContBanco.Text = "";
            txtAgenciaBanc.Text = "";
            txtLoginFunc.Text = "";
            txtSenhaFunc.Text = "";

            // Limpa a seleção nos ComboBoxes
            cbStatusFunc.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            cbEstadoCivil.SelectedIndex = -1;
            cbTurno.SelectedIndex = -1;
            cbUFFunc.SelectedIndex = -1;
            cbTipoConta.SelectedIndex = -1;
            cbVA.SelectedIndex = -1;
            cbVT.SelectedIndex = -1;
        }

        // Função para validar CPF
        private bool ValidarCPF(string cpf)
        {
            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Cálculo do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            // Cálculo do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            // Verifica se os dígitos verificadores estão corretos
            return cpf.EndsWith(digitoVerificador1.ToString() + digitoVerificador2.ToString());
        }

        // Função para validar e-mail
        private bool ValidarEmail(string email)
        {
            try
            {
                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Função para validar senha forte (alfanumérica com letras, números e caracteres especiais)
        private bool ValidarSenhaForte(string senha)
        {
            // Pelo menos 8 caracteres
            if (senha.Length < 8)
                return false;

            // Pelo menos uma letra
            if (!senha.Any(char.IsLetter))
                return false;

            // Pelo menos um número
            if (!senha.Any(char.IsDigit))
                return false;

            // Pelo menos um caractere especial
            if (!senha.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

    }


}




