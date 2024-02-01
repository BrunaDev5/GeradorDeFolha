using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Diagnostics;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProjetoHumanity.Views
{
    public partial class FuncionarioAlteracoes : Form
    {
        private bool controlesHabilitados = false; // Variável para controlar o estado dos controles
        private int idUsuario;


        public FuncionarioAlteracoes(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

            HabilitarDesabilitarControles(false); // Desabilita os controles no início

        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Alterna entre habilitar e desabilitar os controles
            controlesHabilitados = !controlesHabilitados;
            HabilitarDesabilitarControles(controlesHabilitados);

        }

        private void HabilitarDesabilitarControles(bool habilitar)
        {
            txtIdEmpresa.Enabled = habilitar;
            txtCodFunc.Enabled = habilitar;
            cbStatusFunc.Enabled = habilitar;
            txtNomeFunc.Enabled = habilitar;
            cbGenero.Enabled = habilitar;
            cbEstadoCivil.Enabled = habilitar;
            txtNascimento.Enabled = habilitar;
            txtCPF.Enabled = habilitar;
            txtRG.Enabled = habilitar;
            txtPis.Enabled = habilitar;
            txtDtAdmissao.Enabled = habilitar;
            cbTurno.Enabled = habilitar;
            txtFuncao.Enabled = habilitar;
            txtSalarioBase.Enabled = habilitar;
            txtCEP.Enabled = habilitar;
            cbUFFunc.Enabled = habilitar;
            txtRuaFunc.Enabled = habilitar;
            txtNumFunc.Enabled = habilitar;
            txtBairroFunc.Enabled = habilitar;
            txtComplFunc.Enabled = habilitar;
            txtCidadeFunc.Enabled = habilitar;
            txtTelFunc.Enabled = habilitar;
            txtEmailFunc.Enabled = habilitar;
            txtContBanco.Enabled = habilitar;
            txtAgenciaBanc.Enabled = habilitar;
            cbTipoConta.Enabled = habilitar;
            txtLoginFunc.Enabled = habilitar;
            txtSenhaFunc.Enabled = habilitar;
            cbVA.Enabled = habilitar;
            cbVT.Enabled = habilitar;
        }

        public void PreencherDadosNasTextBoxes(FUNCIONARIO funcionario)
        {
            if (funcionario != null)
            {
                // Preenche os dados nas TextBoxes
                lblIdFunc.Text = funcionario.ID_FUNCIONARIO.ToString();
                txtIdEmpresa.Text = funcionario.ID_EMPRESA.ToString();
                txtCodFunc.Text = funcionario.COD_FUNC;
                cbStatusFunc.Text = funcionario.STATUS_FUNC;
                txtNomeFunc.Text = funcionario.NOME_FUNC;
                cbGenero.Text = funcionario.GENERO;
                cbEstadoCivil.Text = funcionario.EST_CIVIL;
                txtNascimento.Text = funcionario.DT_NASC.ToString();
                txtCPF.Text = funcionario.CPF;
                txtRG.Text = funcionario.RG;
                txtPis.Text = funcionario.PIS;
                txtDtAdmissao.Text = funcionario.DT_ADMISSAO.ToString("dd-MM-yyyy");
                cbTurno.Text = funcionario.TURNO_FUNC;
                txtFuncao.Text = funcionario.FUNCAO_FUNC;
                txtSalarioBase.Text = funcionario.SALARIO_BASE.ToString("N2");
                txtCEP.Text = funcionario.CEP_FUNC;
                cbUFFunc.Text = funcionario.UF_FUNC;
                txtRuaFunc.Text = funcionario.RUA_FUNC;
                txtNumFunc.Text = funcionario.NUM_FUNC;
                txtBairroFunc.Text = funcionario.BAIRRO_FUNC;
                txtComplFunc.Text = funcionario.COMPLEM_FUNC;
                txtCidadeFunc.Text = funcionario.CIDADE_FUNC;
                txtTelFunc.Text = funcionario.TEL_FUNC;
                txtEmailFunc.Text = funcionario.EMAIL_FUNC;
                txtContBanco.Text = funcionario.CONTA_PGTO;
                txtAgenciaBanc.Text = funcionario.AGENCIA_PGTO;
                cbTipoConta.Text = funcionario.TIPO_CONTA;
                cbVA.Text = funcionario.VL_ALIMENTACAO;
                cbVT.Text = funcionario.VL_TRANSPORTE;
                txtLoginFunc.Text = funcionario.LOGIN_DEMONSTRATIVO;
                txtSenhaFunc.Text = funcionario.SENHA_DEMONSTRATIVO;

                btnAlteraDadosFunc.Enabled = true;
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btnSalvarDadosAlterados_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID do funcionário que você deseja alterar
                if (int.TryParse(lblIdFunc.Text, out int idFuncionario))
                {
                    Debug.WriteLine("ID do Funcionário: " + idFuncionario); // Debug

                    // O código dentro deste bloco só será executado se o ID for um número inteiro válido.

                    int idEmpresa = int.Parse(txtIdEmpresa.Text);
                    string codFunc = txtCodFunc.Text;
                    string statusFunc = cbStatusFunc.Text;
                    string nomeFunc = txtNomeFunc.Text;
                    string genero = cbGenero.Text;
                    string estCivil = cbEstadoCivil.Text;
                    DateTime dtNasc = DateTime.Parse(txtNascimento.Text);
                    string cpf = txtCPF.Text;
                    string rg = txtRG.Text;
                    string pis = txtPis.Text;
                    DateTime dtAdmissao = DateTime.Parse(txtDtAdmissao.Text);
                    string turnoFunc = cbTurno.Text;
                    string funcaoFunc = txtFuncao.Text;
                    decimal salarioBase = decimal.Parse(txtSalarioBase.Text);
                    string cepFunc = txtCEP.Text;
                    string ruaFunc = txtRuaFunc.Text;
                    string numFunc = txtNumFunc.Text;
                    string bairroFunc = txtBairroFunc.Text;
                    string cidadeFunc = txtCidadeFunc.Text;
                    string complemFunc = txtComplFunc.Text;
                    string ufFunc = cbUFFunc.Text;
                    string telFunc = txtTelFunc.Text;
                    string emailFunc = txtEmailFunc.Text;
                    string agenciaPgto = txtAgenciaBanc.Text;
                    string contaPgto = txtContBanco.Text;
                    string tipoConta = cbTipoConta.Text;
                    string vlAlimentacao = cbVA.Text;
                    string vlTransporte = cbVT.Text;
                    string loginDemonstrativo = txtLoginFunc.Text;
                    string senhaDemonstrativo = txtSenhaFunc.Text;

                    Debug.WriteLine("Dados de funcionário:"); // Debug
                    Debug.WriteLine("ID Funcionário: " + idFuncionario);
                    Debug.WriteLine("ID Empresa: " + idEmpresa);
                    Debug.WriteLine("Cod Func: " + codFunc);
                    Debug.WriteLine("Status Func: " + statusFunc);
                    Debug.WriteLine("Nome Func: " + nomeFunc);
                    Debug.WriteLine("Gênero: " + genero);
                    Debug.WriteLine("Estado Civil: " + estCivil);
                    Debug.WriteLine("Data de Nascimento: " + dtNasc);
                    Debug.WriteLine("CPF: " + cpf);
                    Debug.WriteLine("RG: " + rg);
                    Debug.WriteLine("PIS: " + pis);
                    Debug.WriteLine("Data de Admissão: " + dtAdmissao);
                    Debug.WriteLine("Turno Func: " + turnoFunc);
                    Debug.WriteLine("Função Func: " + funcaoFunc);
                    Debug.WriteLine("Salário Base: " + salarioBase);
                    Debug.WriteLine("CEP Func: " + cepFunc);
                    Debug.WriteLine("Rua Func: " + ruaFunc);
                    Debug.WriteLine("Número Func: " + numFunc);
                    Debug.WriteLine("Bairro Func: " + bairroFunc);
                    Debug.WriteLine("Cidade Func: " + cidadeFunc);
                    Debug.WriteLine("Complemento Func: " + complemFunc);
                    Debug.WriteLine("UF Func: " + ufFunc);
                    Debug.WriteLine("Telefone Func: " + telFunc);
                    Debug.WriteLine("Email Func: " + emailFunc);
                    Debug.WriteLine("Agência de Pagamento: " + agenciaPgto);
                    Debug.WriteLine("Conta de Pagamento: " + contaPgto);
                    Debug.WriteLine("Tipo de Conta: " + tipoConta);
                    Debug.WriteLine("Vale Alimentação: " + vlAlimentacao);
                    Debug.WriteLine("Vale Transporte: " + vlTransporte);
                    Debug.WriteLine("Login Demonstrativo: " + loginDemonstrativo);
                    Debug.WriteLine("Senha Demonstrativo: " + senhaDemonstrativo);

                    // Crie um objeto FUNCIONARIO com os novos dados
                    idFuncionario = int.Parse(lblIdFunc.Text);

                    FUNCIONARIO funcionarioAlterado = new FUNCIONARIO(idFuncionario, idEmpresa, codFunc, statusFunc, nomeFunc, genero, estCivil, dtNasc, cpf, rg, pis, dtAdmissao, turnoFunc, funcaoFunc, salarioBase, cepFunc, ruaFunc, numFunc, bairroFunc, cidadeFunc, complemFunc, ufFunc, telFunc, emailFunc, agenciaPgto, contaPgto, tipoConta, vlAlimentacao, vlTransporte, loginDemonstrativo, senhaDemonstrativo);

                    // Chama o método no Controller para realizar a alteração
                    ControllerFuncionario controllerFuncionario = new ControllerFuncionario();

                    FUNCIONARIO funcionarioAtualizado = controllerFuncionario.Alterar(funcionarioAlterado);



                    // Exemplo de exibição de mensagem de sucesso
                    MessageBox.Show("Funcionário alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ID de Funcionário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Erro de formato: " + ex.Message); // Debug
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados de Funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Erro: " + ex.Message); // Debug
            }
        }

        private FUNCIONARIO ObterDadosCompletosDoFuncionario(int idFuncionario)
        {
            try
            {
                // Aqui, você instancia a classe DAO e chama o método apropriado
                DaoFuncionario daoFuncionario = new DaoFuncionario();

                return daoFuncionario.ObterDadosFuncionario(idFuncionario);
                // Certifique-se de ter um método para obter todos os dados.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados completos do Funcionário : " + ex.Message);
                MessageBox.Show("Erro ao obter dados completos do Funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Isso depende da sua lógica geral de tratamento de exceções
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            // Obtém o valor da lblIdFunc e converte em um inteiro
            if (int.TryParse(lblIdFunc.Text, out int idFuncionario))
            {
                // Obtém os dados completos do funcionário
                FUNCIONARIO funcionarioCompleto = ObterDadosCompletosDoFuncionario(idFuncionario);

                // Abre o formulário PontoFuncionario com os dados do funcionário
                PontoFuncionario pontoFuncionario = new PontoFuncionario(idUsuario, funcionarioCompleto);
                pontoFuncionario.ShowDialog();

                // Fecha o formulário atual (GerenciarFuncionario) após a conclusão do ShowDialog
                this.Hide();
            }
            else
            {
                MessageBox.Show("O ID do funcionário não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDemonstrativo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenha os valores selecionados nos ComboBoxes e o ID do funcionário
                int mesSelecionado = int.Parse(cbMesDemons.SelectedItem.ToString());
                int anoSelecionado = int.Parse(cbAnoDemonstrativo.SelectedItem.ToString());
                int idFuncionario = int.Parse(lblIdFunc.Text);

                Debug.WriteLine($"Mes: {mesSelecionado}, Ano: {anoSelecionado}, ID Funcionário: {idFuncionario}");

                // Chame o método no Controller para obter o DemonstrativoPagamento
                DemonstrativoPagamento demonstrativoPagamento = ObterDadosdoDemonstrativo(mesSelecionado, anoSelecionado, idFuncionario);

                // Verifique se o demonstrativo foi encontrado
                if (demonstrativoPagamento != null)
                {
                    Debug.WriteLine("Demonstrativo encontrado.");

                    // Crie uma instância do formulário Demonstrativo e passe os dados
                    Demonstrativo demonstrativo = new Demonstrativo(idUsuario);
                    demonstrativo.PreencherDadosNasTextBoxes(demonstrativoPagamento); // Implemente esse método no seu formulário Demonstrativo

                    // Abra o formulário em modo de diálogo
                    demonstrativo.ShowDialog();
                }
                else
                {
                    Debug.WriteLine("Demonstrativo não encontrado.");
                    MessageBox.Show("Não foram encontrados dados para o mês e ano especificados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao abrir o Demonstrativo: {ex.Message}");
                MessageBox.Show("Erro ao abrir o Demonstrativo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private DemonstrativoPagamento ObterDadosdoDemonstrativo(int mes, int ano, int idFuncionario)
        {
            try
            {
                DaoDemonstrativoPagamento daoDemonstrativoPagamento = new DaoDemonstrativoPagamento();

                Console.WriteLine("Chamando daoDemonstrativoPagamento.ObterDemonstrativoPagamento...");
                DemonstrativoPagamento demonstrativoPagamento = daoDemonstrativoPagamento.ObterDemonstrativoPagamento(mes, ano, idFuncionario);

                if (demonstrativoPagamento != null)
                {
                    Console.WriteLine("DemonstrativoPagamento encontrado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Nenhum DemonstrativoPagamento encontrado para o mês e ano especificados.");
                }

                return demonstrativoPagamento;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter dados do Demonstrativo do Funcionário: {ex.Message}");
                MessageBox.Show($"Erro ao obter dados do Demonstrativo do Funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}







       
















