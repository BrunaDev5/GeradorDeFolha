namespace ProjetoHumanity.Views
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GerenciarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeFolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeFolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosGerenciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.geradorDeFolhaToolStripMenuItem,
            this.relatóriosGerenciaisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(990, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // UsuarioToolStripMenuItem
            // 
            this.UsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarUsuárioToolStripMenuItem,
            this.GerenciarUsuárioToolStripMenuItem});
            this.UsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem";
            this.UsuarioToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.UsuarioToolStripMenuItem.Text = "    Usuário ";
            // 
            // CadastrarUsuárioToolStripMenuItem
            // 
            this.CadastrarUsuárioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CadastrarUsuárioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.CadastrarUsuárioToolStripMenuItem.Name = "CadastrarUsuárioToolStripMenuItem";
            this.CadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.CadastrarUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.CadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.CadastrarUsuárioToolStripMenuItem_Click);
            // 
            // GerenciarUsuárioToolStripMenuItem
            // 
            this.GerenciarUsuárioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.GerenciarUsuárioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.GerenciarUsuárioToolStripMenuItem.Name = "GerenciarUsuárioToolStripMenuItem";
            this.GerenciarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.GerenciarUsuárioToolStripMenuItem.Text = "Gerenciar Usuários";
            this.GerenciarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.GerenciarUsuárioToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaEmpresaToolStripMenuItem,
            this.gerenciarEmpresaToolStripMenuItem});
            this.empresasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.empresasToolStripMenuItem.Text = "   Empresa";
            // 
            // novaEmpresaToolStripMenuItem
            // 
            this.novaEmpresaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.novaEmpresaToolStripMenuItem.Name = "novaEmpresaToolStripMenuItem";
            this.novaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.novaEmpresaToolStripMenuItem.Text = "Nova Empresa";
            this.novaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.novaEmpresaToolStripMenuItem_Click);
            // 
            // gerenciarEmpresaToolStripMenuItem
            // 
            this.gerenciarEmpresaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.gerenciarEmpresaToolStripMenuItem.Name = "gerenciarEmpresaToolStripMenuItem";
            this.gerenciarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.gerenciarEmpresaToolStripMenuItem.Text = "Gerenciar Empresas";
            this.gerenciarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEmpresaToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem,
            this.gerenciarFuncionáriosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.funcionáriosToolStripMenuItem.Text = "   Funcionário";
            this.funcionáriosToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.novoFuncionárioToolStripMenuItem.Text = "Novo Funcionário";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click);
            // 
            // gerenciarFuncionáriosToolStripMenuItem
            // 
            this.gerenciarFuncionáriosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.gerenciarFuncionáriosToolStripMenuItem.Name = "gerenciarFuncionáriosToolStripMenuItem";
            this.gerenciarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.gerenciarFuncionáriosToolStripMenuItem.Text = "Gerenciar Funcionários";
            this.gerenciarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFuncionáriosToolStripMenuItem_Click);
            // 
            // geradorDeFolhaToolStripMenuItem
            // 
            this.geradorDeFolhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeFolhaToolStripMenuItem1});
            this.geradorDeFolhaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.geradorDeFolhaToolStripMenuItem.Name = "geradorDeFolhaToolStripMenuItem";
            this.geradorDeFolhaToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.geradorDeFolhaToolStripMenuItem.Text = "    Folha de pagamento";
            // 
            // geradorDeFolhaToolStripMenuItem1
            // 
            this.geradorDeFolhaToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.geradorDeFolhaToolStripMenuItem1.Name = "geradorDeFolhaToolStripMenuItem1";
            this.geradorDeFolhaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.geradorDeFolhaToolStripMenuItem1.Text = "Gerenciar Folha";
            this.geradorDeFolhaToolStripMenuItem1.Click += new System.EventHandler(this.geradorDeFolhaToolStripMenuItem1_Click);
            // 
            // relatóriosGerenciaisToolStripMenuItem
            // 
            this.relatóriosGerenciaisToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatóriosGerenciaisToolStripMenuItem.Name = "relatóriosGerenciaisToolStripMenuItem";
            this.relatóriosGerenciaisToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.relatóriosGerenciaisToolStripMenuItem.Text = "     Relatórios ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblID_USUARIO);
            this.panel1.Controls.Add(this.lblUsuarioLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 33);
            this.panel1.TabIndex = 2;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.Red;
            this.lblID_USUARIO.Location = new System.Drawing.Point(86, 6);
            this.lblID_USUARIO.Name = "lblID_USUARIO";
            this.lblID_USUARIO.Size = new System.Drawing.Size(23, 18);
            this.lblID_USUARIO.TabIndex = 78;
            this.lblID_USUARIO.Text = "ID";
            this.lblID_USUARIO.Click += new System.EventHandler(this.lblID_USUARIO_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(12, 6);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 77;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(990, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humanity Group v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GerenciarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem geradorDeFolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosGerenciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeFolhaToolStripMenuItem1;
    }
}