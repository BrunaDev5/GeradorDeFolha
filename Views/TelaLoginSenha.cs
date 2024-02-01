using System;
using System.Windows.Forms;
using ProjetoHumanity.Views;
using ProjetoHumanity.Controller;


namespace ProjetoHumanity
{
    public partial class TelaLoginSenha : Form
    {
        public TelaLoginSenha()
        {
            InitializeComponent();
        }

        private void TelaLoginSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string LoginUser = txtLogin.Text;
            string SenhaUser = txtSenha.Text;

            ControleLoginUser controle = new ControleLoginUser();

            bool usuarioBloqueado = controle.ObterStatusUsuario(LoginUser);

            if (usuarioBloqueado)
            {
                MessageBox.Show("Usuário bloqueado. Entre em contato com o administrador.");
                return; // Não permita o login se o usuário estiver bloqueado
            }

            bool loginSucesso = controle.Acessar(LoginUser, SenhaUser);

            if (loginSucesso)
            {
                // Obtém o ID do usuário usando o método ObterIdUsuario
                int idUsuario = controle.ObterIdUsuario(LoginUser);

                //TelaMenu Principal = new TelaMenu(idUsuario);

                // Manipula o evento FormClosed
                // Principal.FormClosed += (s, args) => this.Close();

                // Exibe o MenuPrincipal
                //  Principal.Show();

                // Oculta a tela de login (opcional, dependendo do seu caso de uso)
                this.Hide();
            }
            else
            {
               
            }
        }



        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void login_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}