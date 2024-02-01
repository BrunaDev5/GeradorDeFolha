using ProjetoHumanity.Controller;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


// Este código possui os métodos para o funcionamento correto do Forms de Nova Empresa.

namespace ProjetoHumanity.Views
{
    public partial class NovaEmpresa : Form
    {
        private int idUsuario;

        // Construtor da classe NovaEmpresa
        public NovaEmpresa(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            // Atualiza a exibição do ID do usuário
            AtualizarLabelUsuario();
        }

        // Método para atualizar a exibição do ID do usuário na interface
        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = idUsuario.ToString();
        }

        // Método para habilitar a edição dos campos no carregamento do formulário
        private void HabilitarEdicaoCampos()
        {
            // Itera sobre todos os controles no formulário
            foreach (Control control in this.Controls)
            {
                // Verifica se o controle é um TextBox
                if (control is TextBox)
                {
                    // Habilita a edição
                    ((TextBox)control).ReadOnly = false;
                }
            }
        }

        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {

            // Chama o método para habilitar a edição dos campos no carregamento do formulário
            HabilitarEdicaoCampos();
            
            // Verifica se todos os campos obrigatórios estão preenchidos
            if (!CamposObrigatoriosPreenchidos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de formato para o CNPJ
            if (!ValidarCNPJ(txtCNPJ.Text))
            {
                MessageBox.Show("Por favor, insira um CNPJ válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de formato para o e-mail
            if (!IsValidEmail(txtEmailEmp.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de formato para o CEP
            if (!ValidarCEP(txtCepEmpresa.Text))
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de formato para a inscrição estadual (exemplo de validação simples)
            if (!ValidarInscricaoEstadual(txtInscEstadual.Text))
            {
                MessageBox.Show("Por favor, insira uma inscrição estadual válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de formato para o telefone (exemplo de validação simples)
            if (!ValidarTelefone(txtTelEmpresa.Text))
            {
                MessageBox.Show("Por favor, insira um telefone válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se todos os campos passaram nas validações, prossegue com o cadastro da empresa
            ControllerEmpresa controllerEmpresa = new ControllerEmpresa();

            string mensagem = controllerEmpresa.NovaEmpresa(
                txtRazaoSocial.Text, txtCodEmpresa.Text, txtCNPJ.Text, txtNomeFantEmpresa.Text, txtInscEstadual.Text,
                txtRuaEmpresa.Text, txtNumEnd.Text, txtBairroEmp.Text, txtCidadeEmpresa.Text, cbUFEmpresa.Text,
                txtComplem.Text, txtTelEmpresa.Text, txtEmailEmp.Text, txtRespEmp.Text, cbStatusEmp.Text, Convert.ToInt32(lblID_USUARIO.Text));

            if (controllerEmpresa.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controllerEmpresa.mensagem);
            }
        }

        private bool CamposObrigatoriosPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtRazaoSocial.Text) &&
                   !string.IsNullOrWhiteSpace(txtCodEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtCNPJ.Text) &&
                   !string.IsNullOrWhiteSpace(txtNomeFantEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtInscEstadual.Text) &&
                   !string.IsNullOrWhiteSpace(txtCepEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtRuaEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtNumEnd.Text) &&
                   !string.IsNullOrWhiteSpace(txtBairroEmp.Text) &&
                   !string.IsNullOrWhiteSpace(txtCidadeEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(cbUFEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelEmpresa.Text) &&
                   !string.IsNullOrWhiteSpace(txtRespEmp.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmailEmp.Text) &&
                   !string.IsNullOrWhiteSpace(cbStatusEmp.Text);
        }

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

        private bool ValidarCNPJ(string cnpj)
        {
            // Remove caracteres não numéricos
            var cnpjLimpo = new string(cnpj.Where(char.IsDigit).ToArray());

            // Verifica se tem 14 dígitos
            if (cnpjLimpo.Length != 14)
                return false;

            // Calcula e compara os dígitos verificadores
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma1 = 0;
            for (int i = 0; i < 12; i++)
                soma1 += int.Parse(cnpjLimpo[i].ToString()) * multiplicadores1[i];

            int resto1 = soma1 % 11;
            int digitoVerificador1 = resto1 < 2 ? 0 : 11 - resto1;

            int soma2 = 0;
            for (int i = 0; i < 13; i++)
                soma2 += int.Parse(cnpjLimpo[i].ToString()) * multiplicadores2[i];

            int resto2 = soma2 % 11;
            int digitoVerificador2 = resto2 < 2 ? 0 : 11 - resto2;

            return int.Parse(cnpjLimpo[12].ToString()) == digitoVerificador1 &&
                   int.Parse(cnpjLimpo[13].ToString()) == digitoVerificador2;
        }

        private bool ValidarCEP(string cep)
        {
            // Implemente a lógica de validação do CEP
            // Pode ser uma validação simples, considerando apenas o formato
            return Regex.IsMatch(cep, @"^\d{5}-\d{3}$");
        }

        private bool ValidarInscricaoEstadual(string inscEstadual)
        {
            // Verifica se a inscrição estadual tem 12 dígitos numéricos
            return inscEstadual.All(char.IsDigit) && inscEstadual.Length == 12;
        }

        private bool ValidarTelefone(string telefone)
        {
            return Regex.IsMatch(telefone, @"^\(\d{2}\)\s\d{4,5}-\d{4}$");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os dados dos controles de entrada
            txtRazaoSocial.Text = string.Empty;
            txtCodEmpresa.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNomeFantEmpresa.Text = string.Empty;
            txtInscEstadual.Text = string.Empty;
            txtRuaEmpresa.Text = string.Empty;
            txtNumEnd.Text = string.Empty;
            txtBairroEmp.Text = string.Empty;
            txtCidadeEmpresa.Text = string.Empty;
            cbUFEmpresa.Text = string.Empty;
            txtComplem.Text = string.Empty;
            txtTelEmpresa.Text = string.Empty;
            txtEmailEmp.Text = string.Empty;
            txtRespEmp.Text = string.Empty;
            cbStatusEmp.Text = string.Empty;

        }

        private void btnCalcelarCadastro_Click(object sender, EventArgs e)
        {
            // Lógica para fechar o formulário
            this.Close();

        }

        private void lblID_USUARIO_Click(object sender,EventArgs e)
        {

        }
    }
}
