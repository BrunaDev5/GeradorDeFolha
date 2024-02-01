using System;
using System.Windows.Forms;
using ProjetoHumanity.Controller;

namespace ProjetoHumanity.Views
{
    
    public partial class TelaMenu : Form
    {
        private ControleLoginUser controleLoginUser = new ControleLoginUser();
        private TextBox txtLogin = new TextBox();
        private int idUsuario;

  
        public TelaMenu(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            

            // Atualiza a label com o ID do usuário
            AtualizarLabelUsuario();

            // Verifica as permissões dos botões e ajusta suas propriedades Enabled
            VerificarPermissaoBotoes();

        }

        private void VerificarPermissaoBotoes()
        {
            // Certifique-se de que idUsuario é do tipo int
            if (int.TryParse(lblID_USUARIO.Text, out int idUsuario))
            {
                // Crie uma instância de ControllerUsuario
                ControllerUsuario controllerUsuario = new ControllerUsuario();

                // Obtém o nível de permissão do usuário
                int nivelPermissao = controllerUsuario.ObterNivelPermissaoUsuario(idUsuario);

                // Verifica se o usuário tem permissão para cadastrar usuário (Nível 1)
                CadastrarUsuárioToolStripMenuItem.Enabled = (nivelPermissao == 1);

                // Verifica se o usuário tem permissão para gerenciar usuários (Nível 1 ou 2)
                GerenciarUsuárioToolStripMenuItem.Enabled = (nivelPermissao == 1);

                geradorDeFolhaToolStripMenuItem1.Enabled = (nivelPermissao == 1);


            }
            else
            {
                // Trate o caso em que a conversão do ID do usuário falhou
                MessageBox.Show("Erro ao obter o ID do usuário.");
            }
        }


        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUser = new NovoUsuario(idUsuario);
            novoUser.ShowDialog();

           
        }

        private void GerenciarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsGerenciarUsuario gerenciarUsuario = new FormsGerenciarUsuario(idUsuario);
            gerenciarUsuario.ShowDialog();

        }

        private void novaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaEmpresa novaEmpresa = new NovaEmpresa(idUsuario);
            novaEmpresa.ShowDialog();
           
        }


        private void gerenciarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarEmpresa gerenciarEmpresa = new GerenciarEmpresa(idUsuario);
            gerenciarEmpresa.ShowDialog();
           
        }

        private void lblID_USUARIO_Click(object sender, EventArgs e)
        {
            
        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoFuncionario novoFuncionario = new NovoFuncionario(idUsuario);
            novoFuncionario.ShowDialog();

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gerenciarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarFuncionario gerenciarFuncionario = new GerenciarFuncionario(idUsuario);
            gerenciarFuncionario.ShowDialog();

            
        }

        private void geradorDeFolhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GerenciarFolha gerenciarFolha = new GerenciarFolha(idUsuario);
            gerenciarFolha.ShowDialog();

            
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoFolha configuracaoFolha = new ConfiguracaoFolha(idUsuario);
            configuracaoFolha.ShowDialog();

        }

       



    }
}

