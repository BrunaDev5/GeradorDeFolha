using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHumanity.Views
{
    public partial class FormsGerenciarUsuario : Form
    {

        private int idUsuario;
        public FormsGerenciarUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = "" + idUsuario.ToString();
        }

        
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = int.Parse(txtPesqUsuario.Text);

                ControllerUsuario controllerUsuario = new ControllerUsuario();
                Usuario usuario = controllerUsuario.BuscarUsuarioPorID(idUsuario);

                ListUsuario.Items.Clear();

                String[] linha =
                {

                usuario.ID_USUARIO.ToString(),
                usuario.NOME_USER,
                usuario.EMAIL_USER,
                usuario.LOGIN_USER,
               
                usuario.NIVEL_PERM,
                usuario.STATUS_USER,
                };

                var linhaLista = new ListViewItem(linha);
                ListUsuario.Items.Add(linhaLista);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            ControllerUsuario controllerUsuario = new ControllerUsuario();

                try
                {
                    List<Usuario> listaUsuarios = controllerUsuario.ListarTodos();

                    // Limpa o ListView antes de adicionar os itens
                    ListUsuario.Items.Clear();

                    // Adiciona cada usuário ao ListView
                    foreach (Usuario usuario in listaUsuarios)
                    {
                        ListViewItem item = new ListViewItem(usuario.ID_USUARIO.ToString());
                        item.SubItems.Add(usuario.NOME_USER);
                        item.SubItems.Add(usuario.EMAIL_USER);
                        item.SubItems.Add(usuario.LOGIN_USER);
                        item.SubItems.Add(usuario.NIVEL_PERM);
                        item.SubItems.Add(usuario.STATUS_USER);

                        // Adiciona o item ao ListView
                        ListUsuario.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void ListUsuario_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = ListUsuario.SelectedItems[0].SubItems[0].Text;
            txtNomeUser.Text = ListUsuario.SelectedItems[0].SubItems[1].Text;
            txtEmailUser.Text = ListUsuario.SelectedItems[0].SubItems[2].Text;
            txtLoginUser.Text = ListUsuario.SelectedItems[0].SubItems[3].Text;
            cbNivel.Text = ListUsuario.SelectedItems[0].SubItems[4].Text;
            cbStatus.Text = ListUsuario.SelectedItems[0].SubItems[5].Text;
            
            btnAlterar.Enabled = true;

        }

        private bool SenhaAtendeRequisitos(string senha)
        {
            // Pelo menos 8 caracteres
            if (senha.Length < 8)
                return false;

            // Pelo menos um número
            if (!senha.Any(char.IsDigit))
                return false;

            // Pelo menos um caractere especial
            if (!senha.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            // Pelo menos uma letra
            if (!senha.Any(char.IsLetter))
                return false;

            return true;
        }

        public static bool EmailValido(string email)
        {
            // Defina a expressão regular para validar um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Cria um objeto Regex
            Regex regex = new Regex(pattern);

            // Verifica se o e-mail corresponde ao padrão
            return regex.IsMatch(email);
        }

        private void AtualizarListView()
        {
            // Chama o método de listagem e atualiza o ListView
            btnListarUsuario_Click(null, null);
        }

        private void txtPesqUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormsGerenciarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void ListUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtém os dados dos TextBoxes
                string novoNome = txtNomeUser.Text;
                string novoEmail = txtEmailUser.Text;
                string novoLogin = txtLoginUser.Text;
                string novaSenha = txtSenhaUser.Text;
                string novoNivel = cbNivel.Text;
                string novoStatus = cbStatus.Text;

                if (!SenhaAtendeRequisitos(novaSenha))
                {
                    MessageBox.Show("A senha deve ter pelo menos 8 caracteres, incluindo pelo menos um número, uma letra e um caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se o e-mail é válido
                if (!EmailValido(novoEmail))
                {
                    MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtém o ID do usuário que você deseja alterar
                int idUsuario = int.Parse(lblID.Text);

                // Gera a senha criptografada e o salt
                var (senhaNovaCriptografada, salt) = PasswordHasher.HashPassword(txtSenhaUser.Text);

                // Criando um objeto Usuario com os novos dados
                Usuario usuarioAlterado = new Usuario(idUsuario, novoNome, novoEmail, novoLogin, novoNivel, novoStatus, senhaNovaCriptografada,salt);

                // Chama o método no Controller para realizar a alteração
                ControllerUsuario controllerUsuario = new ControllerUsuario();
                Usuario usuarioAtualizado = controllerUsuario.Alterar(usuarioAlterado);

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o ListView com os dados atualizados
                AtualizarListView();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Fecha a janela (formulário)
            this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpe os dados dos controles conforme necessário
            
            lblID.Text = string.Empty;
            txtNomeUser.Text = string.Empty;
            txtEmailUser.Text = string.Empty;
            txtLoginUser.Text = string.Empty;
            txtSenhaUser.Text = string.Empty;
            cbNivel.Text = string.Empty;
            cbStatus.Text = string.Empty;




        }

        private void txtNomeUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





