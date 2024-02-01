namespace ProjetoHumanity.Views
{
    partial class GerenciarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarFuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTituloGerenFunc = new System.Windows.Forms.Label();
            this.btnListaFuncionarios = new System.Windows.Forms.Button();
            this.btnBuscaIdFuncionario = new System.Windows.Forms.Button();
            this.txtPesqFuncionario = new System.Windows.Forms.TextBox();
            this.lblInformacaopesq = new System.Windows.Forms.Label();
            this.ListFuncionarios = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFuncionário = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaAdmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFuncao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.btnListarPorEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelaNovoFuncionario = new System.Windows.Forms.Button();
            this.btnRetornaEmpresas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblID_USUARIO);
            this.panel1.Controls.Add(this.lblUsuarioLogado);
            this.panel1.Controls.Add(this.lblTituloGerenFunc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 44);
            this.panel1.TabIndex = 2;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(973, 8);
            this.lblID_USUARIO.Name = "lblID_USUARIO";
            this.lblID_USUARIO.Size = new System.Drawing.Size(25, 19);
            this.lblID_USUARIO.TabIndex = 79;
            this.lblID_USUARIO.Text = "ID";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(897, 9);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 78;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // lblTituloGerenFunc
            // 
            this.lblTituloGerenFunc.AutoSize = true;
            this.lblTituloGerenFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloGerenFunc.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloGerenFunc.ForeColor = System.Drawing.Color.White;
            this.lblTituloGerenFunc.Location = new System.Drawing.Point(9, 9);
            this.lblTituloGerenFunc.Name = "lblTituloGerenFunc";
            this.lblTituloGerenFunc.Size = new System.Drawing.Size(265, 28);
            this.lblTituloGerenFunc.TabIndex = 0;
            this.lblTituloGerenFunc.Text = "Gerenciar Funcionários";
            // 
            // btnListaFuncionarios
            // 
            this.btnListaFuncionarios.BackColor = System.Drawing.Color.White;
            this.btnListaFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaFuncionarios.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnListaFuncionarios.Location = new System.Drawing.Point(497, 53);
            this.btnListaFuncionarios.Name = "btnListaFuncionarios";
            this.btnListaFuncionarios.Size = new System.Drawing.Size(170, 30);
            this.btnListaFuncionarios.TabIndex = 3;
            this.btnListaFuncionarios.Text = "LISTAR FUNCIONARIOS";
            this.btnListaFuncionarios.UseVisualStyleBackColor = false;
            this.btnListaFuncionarios.Click += new System.EventHandler(this.btnListaFuncionarios_Click);
            // 
            // btnBuscaIdFuncionario
            // 
            this.btnBuscaIdFuncionario.BackColor = System.Drawing.Color.White;
            this.btnBuscaIdFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaIdFuncionario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscaIdFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnBuscaIdFuncionario.Location = new System.Drawing.Point(346, 53);
            this.btnBuscaIdFuncionario.Name = "btnBuscaIdFuncionario";
            this.btnBuscaIdFuncionario.Size = new System.Drawing.Size(145, 30);
            this.btnBuscaIdFuncionario.TabIndex = 2;
            this.btnBuscaIdFuncionario.Text = "BUSCAR";
            this.btnBuscaIdFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscaIdFuncionario.Click += new System.EventHandler(this.btnBuscaIdFuncionario_Click);
            // 
            // txtPesqFuncionario
            // 
            this.txtPesqFuncionario.Location = new System.Drawing.Point(266, 53);
            this.txtPesqFuncionario.Multiline = true;
            this.txtPesqFuncionario.Name = "txtPesqFuncionario";
            this.txtPesqFuncionario.Size = new System.Drawing.Size(74, 30);
            this.txtPesqFuncionario.TabIndex = 1;
            // 
            // lblInformacaopesq
            // 
            this.lblInformacaopesq.AutoSize = true;
            this.lblInformacaopesq.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacaopesq.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblInformacaopesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.lblInformacaopesq.Location = new System.Drawing.Point(12, 64);
            this.lblInformacaopesq.Name = "lblInformacaopesq";
            this.lblInformacaopesq.Size = new System.Drawing.Size(217, 19);
            this.lblInformacaopesq.TabIndex = 39;
            this.lblInformacaopesq.Text = "Insira o ID do Funcionário:";
            // 
            // ListFuncionarios
            // 
            this.ListFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaStatus,
            this.colunaFuncionário,
            this.colunaAdmissao,
            this.colunaFuncao,
            this.colunaSalario,
            this.colunaCPF,
            this.colunaEmpresa});
            this.ListFuncionarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFuncionarios.FullRowSelect = true;
            this.ListFuncionarios.HideSelection = false;
            this.ListFuncionarios.Location = new System.Drawing.Point(15, 151);
            this.ListFuncionarios.MultiSelect = false;
            this.ListFuncionarios.Name = "ListFuncionarios";
            this.ListFuncionarios.Size = new System.Drawing.Size(972, 398);
            this.ListFuncionarios.TabIndex = 38;
            this.ListFuncionarios.UseCompatibleStateImageBehavior = false;
            this.ListFuncionarios.View = System.Windows.Forms.View.Details;
            this.ListFuncionarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListFuncionarios_MouseClick);
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID ";
            this.colunaId.Width = 44;
            // 
            // colunaStatus
            // 
            this.colunaStatus.Text = "Status";
            this.colunaStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaStatus.Width = 93;
            // 
            // colunaFuncionário
            // 
            this.colunaFuncionário.Text = "Nome";
            this.colunaFuncionário.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaFuncionário.Width = 203;
            // 
            // colunaAdmissao
            // 
            this.colunaAdmissao.Text = "Admissão";
            this.colunaAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaAdmissao.Width = 98;
            // 
            // colunaFuncao
            // 
            this.colunaFuncao.Text = "Função";
            this.colunaFuncao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaFuncao.Width = 153;
            // 
            // colunaSalario
            // 
            this.colunaSalario.Text = "Salário";
            this.colunaSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaSalario.Width = 93;
            // 
            // colunaCPF
            // 
            this.colunaCPF.Text = "CPF";
            this.colunaCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaCPF.Width = 121;
            // 
            // colunaEmpresa
            // 
            this.colunaEmpresa.Text = "Empresa";
            this.colunaEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaEmpresa.Width = 133;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.btnRetornaEmpresas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 51);
            this.panel3.TabIndex = 203;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(266, 101);
            this.txtIdEmpresa.Multiline = true;
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(74, 30);
            this.txtIdEmpresa.TabIndex = 5;
            // 
            // btnListarPorEmpresa
            // 
            this.btnListarPorEmpresa.BackColor = System.Drawing.Color.White;
            this.btnListarPorEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPorEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnListarPorEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnListarPorEmpresa.Location = new System.Drawing.Point(346, 101);
            this.btnListarPorEmpresa.Name = "btnListarPorEmpresa";
            this.btnListarPorEmpresa.Size = new System.Drawing.Size(145, 30);
            this.btnListarPorEmpresa.TabIndex = 6;
            this.btnListarPorEmpresa.Text = "LISTAR";
            this.btnListarPorEmpresa.UseVisualStyleBackColor = false;
            this.btnListarPorEmpresa.Click += new System.EventHandler(this.btnListarPorEmpresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 208;
            this.label1.Text = "Insira o ID da Empresa:";
            // 
            // btnTelaNovoFuncionario
            // 
            this.btnTelaNovoFuncionario.BackColor = System.Drawing.Color.White;
            this.btnTelaNovoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaNovoFuncionario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTelaNovoFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnTelaNovoFuncionario.Location = new System.Drawing.Point(673, 53);
            this.btnTelaNovoFuncionario.Name = "btnTelaNovoFuncionario";
            this.btnTelaNovoFuncionario.Size = new System.Drawing.Size(209, 30);
            this.btnTelaNovoFuncionario.TabIndex = 4;
            this.btnTelaNovoFuncionario.Text = "NOVO FUNCIONÁRIO";
            this.btnTelaNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnTelaNovoFuncionario.Click += new System.EventHandler(this.btnTelaNovoFuncionario_Click);
            // 
            // btnRetornaEmpresas
            // 
            this.btnRetornaEmpresas.BackColor = System.Drawing.Color.White;
            this.btnRetornaEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornaEmpresas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnRetornaEmpresas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnRetornaEmpresas.Location = new System.Drawing.Point(842, 9);
            this.btnRetornaEmpresas.Name = "btnRetornaEmpresas";
            this.btnRetornaEmpresas.Size = new System.Drawing.Size(145, 30);
            this.btnRetornaEmpresas.TabIndex = 8;
            this.btnRetornaEmpresas.Text = "EMPRESAS";
            this.btnRetornaEmpresas.UseVisualStyleBackColor = false;
            this.btnRetornaEmpresas.Click += new System.EventHandler(this.btnRetornaEmpresas_Click);
            // 
            // GerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 632);
            this.Controls.Add(this.btnTelaNovoFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarPorEmpresa);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnListaFuncionarios);
            this.Controls.Add(this.btnBuscaIdFuncionario);
            this.Controls.Add(this.txtPesqFuncionario);
            this.Controls.Add(this.lblInformacaopesq);
            this.Controls.Add(this.ListFuncionarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Funcionários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblTituloGerenFunc;
        private System.Windows.Forms.Button btnListaFuncionarios;
        private System.Windows.Forms.Button btnBuscaIdFuncionario;
        private System.Windows.Forms.TextBox txtPesqFuncionario;
        private System.Windows.Forms.Label lblInformacaopesq;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaStatus;
        private System.Windows.Forms.ColumnHeader colunaFuncionário;
        private System.Windows.Forms.ColumnHeader colunaAdmissao;
        private System.Windows.Forms.ColumnHeader colunaFuncao;
        private System.Windows.Forms.ColumnHeader colunaSalario;
        private System.Windows.Forms.ColumnHeader colunaCPF;
        private System.Windows.Forms.ColumnHeader colunaEmpresa;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView ListFuncionarios;
        private System.Windows.Forms.Button btnListarPorEmpresa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Button btnTelaNovoFuncionario;
        private System.Windows.Forms.Button btnRetornaEmpresas;
    }
}