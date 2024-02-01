using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;


namespace ProjetoHumanity.Views
{
    public partial class GerenciarEmpresa : Form
    {
        private int idUsuario;
        private bool controlesEmpresaHabilitados = false;
        public GerenciarEmpresa(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }

        // Dentro do formulário GerenciarEmpresa
        // Dentro do formulário GerenciarEmpresa
        

        public void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            ControllerEmpresa controllerEmpresa = new ControllerEmpresa();  
           
            try
            {
                // Obtenha o ID da empresa (ou outra identificação relevante)
                if (int.TryParse(txtPesqEmpresas.Text, out int idEmpresa))
                {
                    // Verifique se daoEmpresa está nulo e, se estiver, inicialize-o
                    if (controllerEmpresa.daoEmpresa == null)
                    {
                        controllerEmpresa.daoEmpresa = new DaoEmpresa(); // Substitua isso pelo método que você usa para inicializar daoEmpresa
                    }

                    // Busque as informações da empresa
                    EMPRESA empresa = controllerEmpresa.BuscarEmpresaporId(idEmpresa);
                    ListEmpresa.Items.Clear();

                    // Verifique se a empresa foi encontrada
                    if (empresa != null)
                    {
                        // Agora você pode acessar as propriedades da empresa com segurança
                        String[] linha =
                        {
                             empresa.ID_EMPRESA.ToString(),
                             empresa.RAZAO_SOCIAL,
                             empresa.CNPJ_EMPRESA,
                             empresa.STATUS_EMPRESA,
                             empresa.DATA_CADASTRO.ToString(),
                             
                         };

                        var linhaLista = new ListViewItem(linha);
                        ListEmpresa.Items.Add(linhaLista);

                        
                    }
                    else
                    {
                        MessageBox.Show("Empresa não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um ID válido (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar empresa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesqEmpresas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarEmpresas_Click(object sender, EventArgs e)
        {

            ControllerEmpresa controllerEmpresa= new ControllerEmpresa();

            try
            {
                List<EMPRESA> listaEmpresas = controllerEmpresa.ListarTodos();

                // Limpa o ListView antes de adicionar os itens
                ListEmpresa.Items.Clear();

                // Adiciona cada usuário ao ListView
                foreach (EMPRESA empresa in listaEmpresas)
                {
                    ListViewItem item = new ListViewItem(empresa.ID_EMPRESA.ToString());
                    item.SubItems.Add(empresa.RAZAO_SOCIAL); // Substituí NOME_USER por RAZAO_SOCIAL
                    item.SubItems.Add(empresa.CNPJ_EMPRESA); // Substituí EMAIL_USER por CNPJ_EMPRESA                                        
                    item.SubItems.Add(empresa.STATUS_EMPRESA); // Substituí STATUS_USER por STATUS_EMPRESA
                    item.SubItems.Add(empresa.DATA_CADASTRO.ToString()); // Substituí SENHA_USER por DATA_CADASTRO

                    // Adiciona o item ao ListView
                    ListEmpresa.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar Empresas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListEmpresa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            if (ListEmpresa.SelectedItems.Count > 0)
            {
                // Obtém o ID da empresa a partir dos dados na ListView
                if (int.TryParse(ListEmpresa.SelectedItems[0].SubItems[0].Text, out int idEmpresa))
                {
                    // Consulta a base de dados para obter todos os dados da empresa
                    EMPRESA empresaCompleta = ObterDadosCompletosDaEmpresa(idEmpresa);

                    // Preenche os dados nas TextBoxes
                    PreencherDadosNasTextBoxes(empresaCompleta);

                    // Habilita o botão de alterar
                    btnAlterarEmpresa.Enabled = true;

                    // Desativa as TextBoxes
                    txtDtCadastroEmp.Enabled = false;
                    txtQtdFunc.Enabled = false;
                    // Adicione outras TextBoxes conforme necessário
                }
                else
                {
                    MessageBox.Show("ID de empresa inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreencherDadosNasTextBoxes(EMPRESA empresa)
        {
            if (empresa != null)
            {
                // Preenche os dados nas TextBoxes
                lblIdEmpresa.Text = empresa.ID_EMPRESA.ToString();
                cbStatusEmp.Text = empresa.STATUS_EMPRESA;
                lblCodigoEmpresa.Text = empresa.CODIGO_EMP;
                txtDtCadastroEmp.Text = empresa.DATA_CADASTRO.ToString("dd/MM/yyyy"); // Certifique-se de tratar possíveis valores nulos
                txtQtdFunc.Text = empresa.QTDE_FUNCIONARIOS.ToString();
                txtRazaoSocial.Text = empresa.RAZAO_SOCIAL;
                txtCNPJ.Text = empresa.CNPJ_EMPRESA;
                txtNomeFantEmpresa.Text = empresa.NOME_FANTASIA;
                txtInscEstadual.Text = empresa.INSC_ESTADUAL;
                txtRuaEmpresa.Text = empresa.RUA_EMP;
                txtNumEnd.Text = empresa.NUM_EMP;
                txtBairroEmp.Text = empresa.BAIRRO_EMP;
                txtComplem.Text = empresa.COMPLE_EMP;
                txtCidadeEmpresa.Text = empresa.CIDADE_EMP;
                cbUFEmpresa.Text = empresa.UF_EMP;
                txtEmailEmp.Text = empresa.EMAIL_EMP;
                txtTelEmpresa.Text = empresa.CONTATO_EMP;
                txtRespEmp.Text = empresa.RESPONS_EMP;

                btnAlterarEmpresa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Empresa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EMPRESA ObterDadosCompletosDaEmpresa(int idEmpresa)
        {
            try
            {
                DaoEmpresa daoempresa = new DaoEmpresa();
                EMPRESA empresa = daoempresa.ObterDadosEmpresa(idEmpresa);

                if (empresa != null)
                {
                    Console.WriteLine("Empresa encontrada: " + empresa.RAZAO_SOCIAL);
                }
                else
                {
                    Console.WriteLine("Empresa não encontrada.");
                }

                return empresa;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados completos da empresa: " + ex.Message);
                MessageBox.Show("Erro ao obter dados completos da empresa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAlterarEmpresa_Click(object sender, EventArgs e)
        {
            // Alterna entre habilitar e desabilitar os controles da empresa
            controlesEmpresaHabilitados = !controlesEmpresaHabilitados;
            HabilitarDesabilitarControlesEmpresa(controlesEmpresaHabilitados);

        }

        private void AtualizarListView()
        {
                // Chama o método de listagem e atualiza o ListView
                 btnListarEmpresas_Click(null, null);
        }

        private void ListEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
             LimparCampos();
           
        }

        private void LimparCampos()
        {
            // Limpa os dados nas TextBoxes e ComboBoxes
            lblIdEmpresa.Text = string.Empty;
            cbStatusEmp.SelectedIndex = -1; // Limpa a seleção no ComboBox
            lblCodigoEmpresa.Text = string.Empty;
            txtDtCadastroEmp.Text = string.Empty;
            txtQtdFunc.Text = string.Empty;
            txtRazaoSocial.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNomeFantEmpresa.Text = string.Empty;
            txtInscEstadual.Text = string.Empty;
            txtRuaEmpresa.Text = string.Empty;
            txtNumEnd.Text = string.Empty;
            txtBairroEmp.Text = string.Empty;
            txtComplem.Text = string.Empty;
            txtCidadeEmpresa.Text = string.Empty;
            cbUFEmpresa.SelectedIndex = -1; // Limpa a seleção no ComboBox
            txtEmailEmp.Text = string.Empty;
            txtTelEmpresa.Text = string.Empty;
            txtRespEmp.Text = string.Empty;

        }

        private void lblIdEmpresa_Click(object sender, EventArgs e)
        {

        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcessoFunc_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o ID da empresa a partir da label lblIdEmpresa
                int idEmpresa = Convert.ToInt32(lblIdEmpresa.Text);

                // Inicializa uma instância de GerenciarFuncionario passando o idEmpresa como parâmetro
                GerenciarFuncionario gerenciarFuncionario = new GerenciarFuncionario(idEmpresa);

                // Insere automaticamente o IdEmpresa na txtIdEmpresa
                gerenciarFuncionario.txtIdEmpresa.Text = idEmpresa.ToString();

                // Chama o método btnListarPorEmpresa_Click diretamente
                gerenciarFuncionario.btnListarPorEmpresa_Click(sender, e);

                // Exibe o formulário GerenciarFuncionario
                gerenciarFuncionario.ShowDialog();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao acessar funcionários: " + ex.Message);
                // Trate o erro conforme necessário
            }


        }

        private void SalvarAlteracao_Click(object sender, EventArgs e)
        {
            // Exemplo de como você pode configurar o evento ListEmpresa_MouseDoubleClick
            ListEmpresa.MouseDoubleClick += new MouseEventHandler(ListEmpresa_MouseDoubleClick);

            try
            {
                // Obtém o ID da empresa que você deseja alterar
                if (int.TryParse(lblIdEmpresa.Text, out int idEmpresa))
                {
                    // Adiciona uma mensagem de log para verificar o ID
                    Debug.WriteLine($"ID da Empresa: {idEmpresa}");

                    // Obtém os dados dos TextBoxes

                    string novoStatus = cbStatusEmp.Text;
                    string novaRazaoSocial = txtRazaoSocial.Text;
                    string novoCnpj = txtCNPJ.Text;
                    string novaInscEstadual = txtInscEstadual.Text;
                    string novoNomeFantasia = txtNomeFantEmpresa.Text;
                    string novaRua = txtRuaEmpresa.Text;
                    string novoNum = txtNumEnd.Text;
                    string novoBairro = txtBairroEmp.Text;
                    string novaCidade = txtCidadeEmpresa.Text;
                    string novoUf = cbUFEmpresa.Text;
                    string novoComple = txtComplem.Text;
                    string novoContato = txtTelEmpresa.Text;
                    string novoEmail = txtEmailEmp.Text;
                    string novoRespons = txtRespEmp.Text;

                    // Adicione mensagens de log
                    Debug.WriteLine($"Novo Status: {novoStatus}");
                    Debug.WriteLine($"Nova Razão Social: {novaRazaoSocial}");
                    Debug.WriteLine($"Novo CNPJ: {novoCnpj}");
                    Debug.WriteLine($"Nova Inscrição Estadual: {novaInscEstadual}");
                    Debug.WriteLine($"Novo Nome Fantasia: {novoNomeFantasia}");
                    Debug.WriteLine($"Nova Rua: {novaRua}");
                    Debug.WriteLine($"Novo Número: {novoNum}");
                    Debug.WriteLine($"Novo Bairro: {novoBairro}");
                    Debug.WriteLine($"Nova Cidade: {novaCidade}");
                    Debug.WriteLine($"Novo UF: {novoUf}");
                    Debug.WriteLine($"Novo Complemento: {novoComple}");
                    Debug.WriteLine($"Novo Contato: {novoContato}");
                    Debug.WriteLine($"Novo Email: {novoEmail}");
                    Debug.WriteLine($"Novo Responsável: {novoRespons}");

                    // Cria um objeto Empresa com os novos dados

                    idEmpresa = int.Parse(lblIdEmpresa.Text);

                    EMPRESA empresaAlterada = new EMPRESA(idEmpresa, novoStatus, novaRazaoSocial, novoCnpj, novaInscEstadual, novoNomeFantasia, novaRua, novoNum, novoBairro, novaCidade, novoUf, novoComple, novoContato, novoEmail, novoRespons);

                    // Adicione uma mensagem de log para verificar os dados
                    Debug.WriteLine($"Empresa Alterada: {empresaAlterada}");

                    // Chama o método no Controller para realizar a alteração
                    ControllerEmpresa controllerEmpresa = new ControllerEmpresa();

                    EMPRESA empresaAtualizada = controllerEmpresa.Alterar(empresaAlterada);

                    // Chame explicitamente o SaveChanges para persistir as alterações no banco de dados


                    // Adicione uma mensagem de log para verificar se a atualização ocorreu com sucesso
                    Debug.WriteLine($"Empresa Atualizada: {empresaAtualizada}");

                    // Exibe uma mensagem de sucesso
                    MessageBox.Show("Empresa alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a ListView------------------------------
                    AtualizarListView();
                }
                else
                {
                    MessageBox.Show("ID de empresa inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar empresa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

           


        }

        public void HabilitarDesabilitarControlesEmpresa(bool habilitar)
        {
            txtRazaoSocial.Enabled = habilitar;
            txtCNPJ.Enabled = habilitar;
            txtInscEstadual.Enabled = habilitar;
            txtNomeFantEmpresa.Enabled = habilitar;
            txtRuaEmpresa.Enabled = habilitar;
            txtNumEnd.Enabled = habilitar;
            txtBairroEmp.Enabled = habilitar;
            txtCidadeEmpresa.Enabled = habilitar;
            cbUFEmpresa.Enabled = habilitar;
            txtComplem.Enabled = habilitar;
            txtTelEmpresa.Enabled = habilitar;
            txtEmailEmp.Enabled = habilitar;
            txtRespEmp.Enabled = habilitar;
        }












    }










        //-----------------------------------------------------------------------------------//




    
}