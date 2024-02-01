using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProjetoHumanity.Views
{
    public partial class ConfiguracaoFolha : Form
    {
        private int idUsuario;
        public ConfiguracaoFolha(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

            // Habilita a seleção múltipla na ListView
            ListSelecaoEmpresa1.MultiSelect = true;


        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }

        public void PreencherDadosNasTextBoxes(FolhaPag folhaPag)
        {
            if (folhaPag != null)
            {
                // Preenche os dados nas TextBoxes


                lblIdFolha.Text = folhaPag.ID_FOLHAPGTO.ToString();
                txtCodFolha.Text = folhaPag.COD_FOLHA.ToString();
                txtDtIncVigencia.Text = folhaPag.DATA_INIC.ToString("dd-MM-yyyy");
                txtDtFinalVig.Text = folhaPag.DATA_FIM.ToString("dd-MM-yyyy");
                txtDataCrédito.Text = folhaPag.DATA_CREDITO.ToString("dd-MM-yyyy");

            }
            else
            {
                MessageBox.Show("Folha não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnListarEmpresas_Click(object sender, EventArgs e)
        {
            ControllerEmpresa controllerEmpresa = new ControllerEmpresa();

            try
            {
                List<EMPRESA> listaEmpresas = controllerEmpresa.ListarTodos();

                // Limpa o ListView antes de adicionar os itens
                ListSelecaoEmpresa1.Items.Clear();

                // Adiciona cada usuário ao ListView
                foreach (EMPRESA empresa in listaEmpresas)
                {
                    ListViewItem item = new ListViewItem(empresa.ID_EMPRESA.ToString());
                    item.SubItems.Add(empresa.RAZAO_SOCIAL);
                    item.SubItems.Add(empresa.CNPJ_EMPRESA);
                    item.SubItems.Add(empresa.STATUS_EMPRESA);
                    item.SubItems.Add(empresa.DATA_CADASTRO.ToString());

                    // Adicione o ID da empresa à propriedade Tag
                    item.Tag = empresa.ID_EMPRESA;

                    // Adiciona o item ao ListView
                    ListSelecaoEmpresa1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Empresas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSeleciona1_Click(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado na ListSelecaoEmpresa2
            if (ListSelecaoEmpresa1.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado
                ListViewItem selectedItem = ListSelecaoEmpresa1.SelectedItems[0];

                // Adicione o item selecionado a ListSelecaoEmpresa2
                ListSelecaoEmpresa2.Items.Add((ListViewItem)selectedItem.Clone());

                // Remova o item da ListSelecaoEmpresa2
                ListSelecaoEmpresa1.Items.Remove(selectedItem);
            }
        }



        private void btnCancelarSelecao_Click(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado na ListSelecaoEmpresa2
            if (ListSelecaoEmpresa2.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado
                ListViewItem selectedItem = ListSelecaoEmpresa2.SelectedItems[0];

                // Adicione o item selecionado de volta à ListSelecaoEmpresa1
                ListSelecaoEmpresa1.Items.Add((ListViewItem)selectedItem.Clone());

                // Remova o item da ListSelecaoEmpresa2
                ListSelecaoEmpresa2.Items.Remove(selectedItem);
            }

        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            // Percorra todos os itens da ListSelecaoEmpresa1
            foreach (ListViewItem item in ListSelecaoEmpresa1.Items)
            {
                // Adicione o item à ListSelecaoEmpresa2
                ListSelecaoEmpresa2.Items.Add((ListViewItem)item.Clone());
            }

            // Limpe a ListSelecaoEmpresa1, pois todos os itens foram transferidos
            ListSelecaoEmpresa1.Items.Clear();
        }

        private void btnCancelarTodos_Click(object sender, EventArgs e)
        {
            // Percorra todos os itens da ListSelecaoEmpresa2
            foreach (ListViewItem item in ListSelecaoEmpresa2.Items)
            {
                // Adicione o item de volta à ListSelecaoEmpresa1
                ListSelecaoEmpresa1.Items.Add((ListViewItem)item.Clone());
            }

            // Limpe a ListSelecaoEmpresa2, pois todos os itens foram transferidos de volta
            ListSelecaoEmpresa2.Items.Clear();

        }

        private void btnConfirmarSelecao_Click(object sender, EventArgs e)
        {
            DaoFolhaEmpresas daoFolhaEmpresas = new DaoFolhaEmpresas();

            try
            {
                // Obtenha o ID da folha de pagamento da sua lógica, como você mencionou que está na lblFolhaPagamento
                int idFolhaPgto = int.Parse(lblIdFolha.Text);

                // Percorra todos os itens selecionados na ListSelecaoEmpresa2
                foreach (ListViewItem selectedItem in ListSelecaoEmpresa2.Items)
                {
                    // Obtenha o ID da empresa do item selecionado (você deve ter armazenado isso nas tags dos itens)
                    int idEmpresa = (int)selectedItem.Tag;

                    // Defina o valor total como 0 por enquanto
                    decimal valorTotal = 0;

                    // Defina o total de funcionários como 0 por enquanto
                    int totalFuncionarios = 0;

                    // Insira a empresa na tabela EMPRESA_FOLHA
                    daoFolhaEmpresas.InserirEmpresaFolha(idEmpresa, idFolhaPgto, valorTotal, totalFuncionarios);
                }

                // Exiba uma mensagem de sucesso
                MessageBox.Show("Empresas selecionadas inseridas com sucesso na folha de pagamento.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpe a ListSelecaoEmpresa2
                ListSelecaoEmpresa2.Items.Clear();
            }
            catch (Exception ex)
            {
                // Em caso de erro, exiba uma mensagem de erro
                MessageBox.Show("Erro ao inserir empresas na folha de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o valor da lblIdFolha
                int idFolhaPgto = Convert.ToInt32(lblIdFolha.Text);
                int idUsuario = Convert.ToInt32(lblID_USUARIO.Text);

                // Cria uma instância do ControllerCalculoFolha
                ControllerCalculoFolha controllerCalculoFolha = new ControllerCalculoFolha();

                // Chama o método InserirRegistros
                string resultadoInsercao = controllerCalculoFolha.InserirRegistros(idFolhaPgto,idUsuario);

                // Verifica se a inserção foi bem-sucedida antes de chamar o método de atualização
                if (controllerCalculoFolha.Tem)
                {
                    // Chama o método AtualizarSalarioBase
                    string resultadoAtualizacao = controllerCalculoFolha.AtualizarSalarioBase(idFolhaPgto);

                    // Verifica se a atualização também foi bem-sucedida
                    if (controllerCalculoFolha.Tem)
                    {
                        // Exibe a mensagem de sucesso
                        MessageBox.Show("Folha gerada com sucesso!");
                    }
                    else
                    {
                        // Exibe os resultados apenas da inserção e da atualização
                        MessageBox.Show(resultadoInsercao + "\n" + resultadoAtualizacao);
                    }
                }
                else
                {
                    // Exibe o resultado apenas da inserção
                    MessageBox.Show(resultadoInsercao);
                }
            }
            catch (Exception ex)
            {
                // Lida com exceções de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao gerar folha: " + ex.Message);
            }













        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual (GerenciarFuncionario)
            this.Close();
        }
    }

}