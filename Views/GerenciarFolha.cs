using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoHumanity.Views
{
    public partial class GerenciarFolha : Form
    {
        private int idUsuario;
        public GerenciarFolha(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            // Atualiza a exibição do ID do usuário
            AtualizarLabelUsuario();

        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = idUsuario.ToString();
        }


        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            ConfiguracaoFolha configuracaoFolha = new ConfiguracaoFolha(idUsuario);
            configuracaoFolha.ShowDialog();

        }

        private void GerenciarFolha_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastraFolha_Click(object sender, EventArgs e)
        {

            ControllerFolhaPag controllerFolhaPag = new ControllerFolhaPag();

            // Validação das datas
            if (!IsValidDate(txtDtInicio.Text) || !IsValidDate(txtDtFinal.Text) || !IsValidDate(txtDtcredito.Text))
            {
                MessageBox.Show("Por favor, insira datas válidas no formato correto (dd/MM/yyyy).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método se as datas não forem válidas
            }

            string mensagem = controllerFolhaPag.NovaFolhaPagamento(
                txtCodFolha.Text,
                Convert.ToDateTime(txtDtInicio.Text),
                Convert.ToDateTime(txtDtFinal.Text),
                Convert.ToDateTime(txtDtcredito.Text),
                Convert.ToInt32(lblID_USUARIO.Text)
            );

            if (controllerFolhaPag.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controllerFolhaPag.mensagem);
            }


        }


        private bool IsValidDate(string input)
        {
            DateTime date;
            return DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpe todos os campos do formulário
            txtCodFolha.Text = string.Empty;
            txtDtInicio.Text = string.Empty;
            txtDtFinal.Text = string.Empty;
            txtDtcredito.Text = string.Empty;

            // Defina o foco de volta para o primeiro campo (opcional)
            txtCodFolha.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void ListFolhaPag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarFolha_Click(object sender, EventArgs e)
        {
            ControllerFolhaPag controllerFolhaPag = new ControllerFolhaPag();


            try
            {
                // Obtenha o ID da empresa (ou outra identificação relevante)
                if (int.TryParse(txtPesqFolhaPag.Text, out int idFolhaPgto))
                {
                    // Verifique se daoEmpresa está nulo e, se estiver, inicialize-o
                    if (controllerFolhaPag.daoFolhaPag == null)
                    {
                        controllerFolhaPag.daoFolhaPag = new DaoFolhaPag();
                    }

                    // Busque as informações da empresa
                    FolhaPag folhaPag = controllerFolhaPag.BuscarFolhaporId(idFolhaPgto);
                    ListFolhaPag.Items.Clear();

                    // Verifique se a empresa foi encontrada
                    if (folhaPag != null)
                    {
                        // Agora você pode acessar as propriedades da empresa com segurança
                        String[] linha =
                        {
                             folhaPag.ID_FOLHAPGTO.ToString(),
                             folhaPag.COD_FOLHA.ToString(),
                             folhaPag.DATA_INIC.ToString("dd-MM-yyyy"),
                             folhaPag.DATA_FIM.ToString("dd-MM-yyyy"),
                             folhaPag.DATA_CREDITO.ToString("dd-MM-yyyy"),

                         };

                        var linhaLista = new ListViewItem(linha);
                        ListFolhaPag.Items.Add(linhaLista);


                    }
                    else
                    {
                        MessageBox.Show("Folha não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Folha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarFolhas_Click(object sender, EventArgs e)
        {
            ControllerFolhaPag controllerFolhaPag = new ControllerFolhaPag();

            try
            {
                List<FolhaPag> listaFolhasPagamento = controllerFolhaPag.ListarTodos();

                // Limpa o ListView antes de adicionar os itens
                ListFolhaPag.Items.Clear();

                // Adiciona cada folha de pagamento ao ListView
                foreach (FolhaPag folhaPag in listaFolhasPagamento)
                {
                    ListViewItem item = new ListViewItem(folhaPag.ID_FOLHAPGTO.ToString());
                    item.SubItems.Add(folhaPag.COD_FOLHA);
                    item.SubItems.Add(folhaPag.DATA_INIC.ToString()); // Ajuste para a propriedade correta
                    item.SubItems.Add(folhaPag.DATA_FIM.ToString());  // Ajuste para a propriedade correta
                    item.SubItems.Add(folhaPag.DATA_CREDITO.ToString()); // Ajuste para a propriedade correta

                    // Adiciona o item ao ListView
                    ListFolhaPag.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Folhas de Pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesqFolhaPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListFolhaPag_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListFolhaPag.SelectedItems.Count > 0)
            {
                // Obtém o ID da folha de pagamento a partir dos dados na ListView
                if (int.TryParse(ListFolhaPag.SelectedItems[0].SubItems[0].Text, out int idFolhaPgto))
                {
                    // Consulta a base de dados para obter todos os dados da folha de pagamento
                    FolhaPag folhaCompleta = ObterDadosCompletosDaFolha(idFolhaPgto);

                    if (folhaCompleta != null)
                    {
                        // Crie uma instância do formulário ConfiguracaoFolha
                        ConfiguracaoFolha configuracaoFolha = new ConfiguracaoFolha(idUsuario);

                        // Chama o método PreencherDadosNasTextBoxes no novo formulário
                        configuracaoFolha.PreencherDadosNasTextBoxes(folhaCompleta);

                        // Exibe o formulário ConfiguracaoFolha
                        configuracaoFolha.ShowDialog(); // Use ShowDialog() para abrir o formulário como uma janela modal
                    }
                    else
                    {
                        MessageBox.Show("Folha de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID da Folha de Pagamento inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide();
            }
        }

        private FolhaPag ObterDadosCompletosDaFolha(int idFolhaPgto)
        {
            try
            {
                // Aqui, você instancia a classe DAO e chama o método apropriado
                DaoFolhaPag daoFolhaPag = new DaoFolhaPag();

                return daoFolhaPag.ObterDadosdaFolha(idFolhaPgto);
                // Certifique-se de ter um método para obter todos os dados.

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados completos da Folha : " + ex.Message);
                MessageBox.Show("Erro ao obter dados completos da Folha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Isso depende da sua lógica geral de tratamento de exceções
            }



        }

        private void btnSalvarDadosAlterados_Click(object sender, EventArgs e)
        {

        }
    }
}
