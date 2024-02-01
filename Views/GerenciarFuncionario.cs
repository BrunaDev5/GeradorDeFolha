using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoHumanity.Views
{
    public partial class GerenciarFuncionario : Form
    {
        private int idUsuario;
        private FuncionarioAlteracoes formularioAlteracoes; // Variável de instância para o formulário FuncionarioAlteracoes

        public GerenciarFuncionario(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

            // Inicialize o formulário FuncionarioAlteracoes
            formularioAlteracoes = new FuncionarioAlteracoes(idUsuario);
        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }

        private void btnBuscaIdFuncionario_Click(object sender, EventArgs e)
        {

            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
            DaoEmpresa daoEmpresa = new DaoEmpresa();


            try
            {
                // Obtenha o ID da empresa (ou outra identificação relevante)
                if (int.TryParse(txtPesqFuncionario.Text, out int idFuncionario))
                {
                    // Verifique se daoEmpresa está nulo e, se estiver, inicialize-o
                    if (controllerFuncionario.daoFuncionario == null)
                    {
                        controllerFuncionario.daoFuncionario = new DaoFuncionario(); // Substitua isso pelo método que você usa para inicializar daoFuncionario
                    }

                    // Busque as informações de Funcionário 

                    FUNCIONARIO Funcionario = controllerFuncionario.BuscarFuncionarioPorId(idFuncionario);
                    ListFuncionarios.Items.Clear();

                    // Verifique se a empresa foi encontrada
                    if (Funcionario != null)
                    {
                        // Agora você pode acessar as propriedades de funcionario com segurança
                        String[] linha =
                        {
                            Funcionario.ID_FUNCIONARIO.ToString(),
                            Funcionario.STATUS_FUNC,
                            Funcionario.NOME_FUNC,
                            Funcionario.DT_ADMISSAO.ToString("dd-MM-yyyy"), // Formata a data como "yyyy-MM-dd"
                            Funcionario.FUNCAO_FUNC,
                            Funcionario.SALARIO_BASE.ToString("N2"), // Formata o salário como número decimal com 2 casas decimais
                            Funcionario.CPF,
                            Funcionario.ID_EMPRESA.ToString()

                         };

                        var linhaLista = new ListViewItem(linha);
                        ListFuncionarios.Items.Add(linhaLista);


                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void btnListaFuncionarios_Click(object sender, EventArgs e)
        {
            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();

            try
            {
                List<FUNCIONARIO> listaFuncionario = controllerFuncionario.ListarTodos();


                // Limpa o ListView antes de adicionar os itens
                ListFuncionarios.Items.Clear();

                // Adiciona cada usuário ao ListView
                foreach (FUNCIONARIO funcionario in listaFuncionario)
                {

                    ListViewItem item = new ListViewItem(funcionario.ID_FUNCIONARIO.ToString());

                    item.SubItems.Add(funcionario.STATUS_FUNC);
                    item.SubItems.Add(funcionario.NOME_FUNC);
                    item.SubItems.Add(funcionario.DT_ADMISSAO.ToString("dd-MM-yyyy")); // Formata a data como "yyyy-MM-dd"
                    item.SubItems.Add(funcionario.FUNCAO_FUNC);
                    item.SubItems.Add(funcionario.SALARIO_BASE.ToString("N2")); // Formata o salário como número decimal com 2 casas decimais
                    item.SubItems.Add(funcionario.CPF);
                    item.SubItems.Add(funcionario.ID_EMPRESA.ToString());


                    // Adiciona o item ao ListView
                    ListFuncionarios.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void ListFuncionarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListFuncionarios.SelectedItems.Count > 0)
            {
                // Obtém o ID do funcionário a partir dos dados na ListView
                if (int.TryParse(ListFuncionarios.SelectedItems[0].SubItems[0].Text, out int idFuncionario))
                {
                    // Consulta a base de dados para obter todos os dados do funcionário
                    FUNCIONARIO funcionarioCompleto = ObterDadosCompletosDoFuncionario(idFuncionario);

                    // Chama o método PreencherDadosNasTextBoxes do formulário FuncionarioAlteracoes
                    formularioAlteracoes.PreencherDadosNasTextBoxes(funcionarioCompleto);

                    // Exibe o formulário FuncionarioAlteracoes
                    formularioAlteracoes.ShowDialog(); // Use ShowDialog() para abrir o formulário como uma janela modal

                    
                }
                else
                {
                    MessageBox.Show("ID do Funcionário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        public void btnListarPorEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID a partir da label lblIdEmpresa (ou qualquer outra fonte de ID)
                int id = Convert.ToInt32(txtIdEmpresa.Text);

                // Inicializa uma instância de ControllerFuncionario
                ControllerFuncionario controllerFuncionario = new ControllerFuncionario();

                // Obtém a lista de funcionários por ID usando o ControllerFuncionario
                List<FUNCIONARIO> funcionariosPorId = controllerFuncionario.ListarFuncionariosPorEmpresa(id);

                // Limpa itens existentes no ListFuncionarios antes de adicionar novos
                ListFuncionarios.Items.Clear();

                // Preenche o ListFuncionarios com a lista de funcionários por ID
                foreach (FUNCIONARIO funcionario in funcionariosPorId)
                {
                    ListViewItem item = new ListViewItem(funcionario.ID_FUNCIONARIO.ToString());
                    item.SubItems.Add(funcionario.STATUS_FUNC);
                    item.SubItems.Add(funcionario.NOME_FUNC);
                    item.SubItems.Add(funcionario.DT_ADMISSAO.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(funcionario.FUNCAO_FUNC);
                    item.SubItems.Add(funcionario.SALARIO_BASE.ToString("N2"));
                    item.SubItems.Add(funcionario.CPF);
                    item.SubItems.Add(funcionario.ID_EMPRESA.ToString());

                    ListFuncionarios.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar funcionários por ID: " + ex.Message);
                // Trate o erro conforme necessário
            }

        }

        private void btnTelaNovoFuncionario_Click(object sender, EventArgs e)
        {
            NovoFuncionario novoFuncionario = new NovoFuncionario(idUsuario);
            novoFuncionario.ShowDialog();
 

        }

        private void btnRetornaEmpresas_Click(object sender, EventArgs e)
        {
           GerenciarEmpresa gerenciarEmpresa = new GerenciarEmpresa(idUsuario);
           gerenciarEmpresa.ShowDialog();

        }

        
    }
}










