namespace ProjetoHumanity.Views
{
    partial class GerenciarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlterarEmpresa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListarEmpresas = new System.Windows.Forms.Button();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.txtPesqEmpresas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListEmpresa = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNomeEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaStatusEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDtCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAcessoFunc = new System.Windows.Forms.Button();
            this.lblCodigoEmpresa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIdEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatusEmp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRespEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelEmpresa = new System.Windows.Forms.TextBox();
            this.txtComplem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidadeEmpresa = new System.Windows.Forms.TextBox();
            this.txtBairroEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeFantEmpresa = new System.Windows.Forms.TextBox();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbUFEmpresa = new System.Windows.Forms.ComboBox();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.txtRuaEmpresa = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblStatusEmpresa = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtDtCadastroEmp = new System.Windows.Forms.TextBox();
            this.txtQtdFunc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAlterarEmpresa);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 750);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 51);
            this.panel1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.button1.Location = new System.Drawing.Point(1168, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALVAR ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SalvarAlteracao_Click);
            // 
            // btnAlterarEmpresa
            // 
            this.btnAlterarEmpresa.BackColor = System.Drawing.Color.White;
            this.btnAlterarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAlterarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnAlterarEmpresa.Location = new System.Drawing.Point(1041, 5);
            this.btnAlterarEmpresa.Name = "btnAlterarEmpresa";
            this.btnAlterarEmpresa.Size = new System.Drawing.Size(121, 34);
            this.btnAlterarEmpresa.TabIndex = 1;
            this.btnAlterarEmpresa.Text = "ALTERAR";
            this.btnAlterarEmpresa.UseVisualStyleBackColor = false;
            this.btnAlterarEmpresa.Click += new System.EventHandler(this.btnAlterarEmpresa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnLimpar.Location = new System.Drawing.Point(910, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(11, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 34);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "X CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListarEmpresas
            // 
            this.btnListarEmpresas.BackColor = System.Drawing.Color.White;
            this.btnListarEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEmpresas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnListarEmpresas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnListarEmpresas.Location = new System.Drawing.Point(1184, 169);
            this.btnListarEmpresas.Name = "btnListarEmpresas";
            this.btnListarEmpresas.Size = new System.Drawing.Size(125, 30);
            this.btnListarEmpresas.TabIndex = 37;
            this.btnListarEmpresas.Text = "Listar";
            this.btnListarEmpresas.UseVisualStyleBackColor = false;
            this.btnListarEmpresas.Click += new System.EventHandler(this.btnListarEmpresas_Click);
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.BackColor = System.Drawing.Color.White;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(1053, 169);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(125, 30);
            this.btnBuscarEmpresa.TabIndex = 36;
            this.btnBuscarEmpresa.Text = "Buscar";
            this.btnBuscarEmpresa.UseVisualStyleBackColor = false;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // txtPesqEmpresas
            // 
            this.txtPesqEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesqEmpresas.Location = new System.Drawing.Point(928, 169);
            this.txtPesqEmpresas.Multiline = true;
            this.txtPesqEmpresas.Name = "txtPesqEmpresas";
            this.txtPesqEmpresas.Size = new System.Drawing.Size(119, 30);
            this.txtPesqEmpresas.TabIndex = 35;
            this.txtPesqEmpresas.TextChanged += new System.EventHandler(this.txtPesqEmpresas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(730, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Digite o ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gerenciar Empresas";
            // 
            // ListEmpresa
            // 
            this.ListEmpresa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNomeEmpresa,
            this.colunaCNPJ,
            this.colunaStatusEmp,
            this.colunaDtCadastro});
            this.ListEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListEmpresa.FullRowSelect = true;
            this.ListEmpresa.HideSelection = false;
            this.ListEmpresa.Location = new System.Drawing.Point(734, 229);
            this.ListEmpresa.MultiSelect = false;
            this.ListEmpresa.Name = "ListEmpresa";
            this.ListEmpresa.Size = new System.Drawing.Size(571, 477);
            this.ListEmpresa.TabIndex = 32;
            this.ListEmpresa.UseCompatibleStateImageBehavior = false;
            this.ListEmpresa.View = System.Windows.Forms.View.Details;
            this.ListEmpresa.SelectedIndexChanged += new System.EventHandler(this.ListEmpresa_SelectedIndexChanged);
            this.ListEmpresa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListEmpresa_MouseDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            this.colunaId.Width = 58;
            // 
            // colunaNomeEmpresa
            // 
            this.colunaNomeEmpresa.Text = "Razão Social";
            this.colunaNomeEmpresa.Width = 270;
            // 
            // colunaCNPJ
            // 
            this.colunaCNPJ.Text = "CNPJ";
            this.colunaCNPJ.Width = 258;
            // 
            // colunaStatusEmp
            // 
            this.colunaStatusEmp.Text = "Status";
            this.colunaStatusEmp.Width = 68;
            // 
            // colunaDtCadastro
            // 
            this.colunaDtCadastro.Text = "Data Cadastro";
            this.colunaDtCadastro.Width = 146;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblID_USUARIO);
            this.panel2.Controls.Add(this.lblUsuarioLogado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 51);
            this.panel2.TabIndex = 39;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(1270, 16);
            this.lblID_USUARIO.Name = "lblID_USUARIO";
            this.lblID_USUARIO.Size = new System.Drawing.Size(25, 19);
            this.lblID_USUARIO.TabIndex = 77;
            this.lblID_USUARIO.Text = "ID";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(1194, 17);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 76;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(460, 606);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 18);
            this.label16.TabIndex = 149;
            this.label16.Text = "N° de Funcionários:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(282, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 18);
            this.label14.TabIndex = 147;
            this.label14.Text = "Data de Cadastro:";
            // 
            // btnAcessoFunc
            // 
            this.btnAcessoFunc.BackColor = System.Drawing.Color.White;
            this.btnAcessoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessoFunc.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAcessoFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnAcessoFunc.Location = new System.Drawing.Point(562, 672);
            this.btnAcessoFunc.Name = "btnAcessoFunc";
            this.btnAcessoFunc.Size = new System.Drawing.Size(148, 34);
            this.btnAcessoFunc.TabIndex = 2;
            this.btnAcessoFunc.Text = "FUNCIONÁRIOS";
            this.btnAcessoFunc.UseVisualStyleBackColor = false;
            this.btnAcessoFunc.Click += new System.EventHandler(this.btnAcessoFunc_Click);
            // 
            // lblCodigoEmpresa
            // 
            this.lblCodigoEmpresa.AutoSize = true;
            this.lblCodigoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpresa.Location = new System.Drawing.Point(225, 198);
            this.lblCodigoEmpresa.Name = "lblCodigoEmpresa";
            this.lblCodigoEmpresa.Size = new System.Drawing.Size(20, 18);
            this.lblCodigoEmpresa.TabIndex = 145;
            this.lblCodigoEmpresa.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(157, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 144;
            this.label11.Text = "Código:";
            // 
            // lblIdEmpresa
            // 
            this.lblIdEmpresa.AutoSize = true;
            this.lblIdEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpresa.ForeColor = System.Drawing.Color.Red;
            this.lblIdEmpresa.Location = new System.Drawing.Point(48, 198);
            this.lblIdEmpresa.Name = "lblIdEmpresa";
            this.lblIdEmpresa.Size = new System.Drawing.Size(20, 18);
            this.lblIdEmpresa.TabIndex = 143;
            this.lblIdEmpresa.Text = "---";
            this.lblIdEmpresa.Click += new System.EventHandler(this.lblIdEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 142;
            this.label2.Text = "ID:";
            // 
            // cbStatusEmp
            // 
            this.cbStatusEmp.Enabled = false;
            this.cbStatusEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusEmp.FormattingEnabled = true;
            this.cbStatusEmp.Items.AddRange(new object[] {
            "Ativa",
            "Desativada"});
            this.cbStatusEmp.Location = new System.Drawing.Point(529, 198);
            this.cbStatusEmp.Name = "cbStatusEmp";
            this.cbStatusEmp.Size = new System.Drawing.Size(178, 25);
            this.cbStatusEmp.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 140;
            this.label10.Text = "Responsável ";
            // 
            // txtRespEmp
            // 
            this.txtRespEmp.Enabled = false;
            this.txtRespEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespEmp.Location = new System.Drawing.Point(12, 627);
            this.txtRespEmp.Multiline = true;
            this.txtRespEmp.Name = "txtRespEmp";
            this.txtRespEmp.Size = new System.Drawing.Size(267, 28);
            this.txtRespEmp.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 138;
            this.label5.Text = "Email";
            // 
            // txtTelEmpresa
            // 
            this.txtTelEmpresa.Enabled = false;
            this.txtTelEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelEmpresa.Location = new System.Drawing.Point(532, 565);
            this.txtTelEmpresa.Multiline = true;
            this.txtTelEmpresa.Name = "txtTelEmpresa";
            this.txtTelEmpresa.Size = new System.Drawing.Size(178, 28);
            this.txtTelEmpresa.TabIndex = 137;
            // 
            // txtComplem
            // 
            this.txtComplem.Enabled = false;
            this.txtComplem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplem.Location = new System.Drawing.Point(12, 508);
            this.txtComplem.Multiline = true;
            this.txtComplem.Name = "txtComplem";
            this.txtComplem.Size = new System.Drawing.Size(237, 25);
            this.txtComplem.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 135;
            this.label6.Text = "Tel. Fixo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 134;
            this.label7.Text = "Complemento";
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Enabled = false;
            this.txtEmailEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmp.Location = new System.Drawing.Point(12, 565);
            this.txtEmailEmp.Multiline = true;
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(514, 28);
            this.txtEmailEmp.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 132;
            this.label4.Text = "UF";
            // 
            // txtCidadeEmpresa
            // 
            this.txtCidadeEmpresa.Enabled = false;
            this.txtCidadeEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEmpresa.Location = new System.Drawing.Point(255, 508);
            this.txtCidadeEmpresa.Multiline = true;
            this.txtCidadeEmpresa.Name = "txtCidadeEmpresa";
            this.txtCidadeEmpresa.Size = new System.Drawing.Size(284, 25);
            this.txtCidadeEmpresa.TabIndex = 131;
            // 
            // txtBairroEmp
            // 
            this.txtBairroEmp.Enabled = false;
            this.txtBairroEmp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroEmp.Location = new System.Drawing.Point(493, 453);
            this.txtBairroEmp.Multiline = true;
            this.txtBairroEmp.Name = "txtBairroEmp";
            this.txtBairroEmp.Size = new System.Drawing.Size(217, 28);
            this.txtBairroEmp.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 129;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 128;
            this.label9.Text = "Bairro";
            // 
            // txtNomeFantEmpresa
            // 
            this.txtNomeFantEmpresa.Enabled = false;
            this.txtNomeFantEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantEmpresa.Location = new System.Drawing.Point(11, 334);
            this.txtNomeFantEmpresa.Multiline = true;
            this.txtNomeFantEmpresa.Name = "txtNomeFantEmpresa";
            this.txtNomeFantEmpresa.Size = new System.Drawing.Size(390, 28);
            this.txtNomeFantEmpresa.TabIndex = 127;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Enabled = false;
            this.txtInscEstadual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEstadual.Location = new System.Drawing.Point(407, 334);
            this.txtInscEstadual.Multiline = true;
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(300, 28);
            this.txtInscEstadual.TabIndex = 126;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 18);
            this.label12.TabIndex = 125;
            this.label12.Text = "Nome Fantasia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(407, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 18);
            this.label13.TabIndex = 124;
            this.label13.Text = "Insc. Estadual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(10, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 21);
            this.label15.TabIndex = 123;
            this.label15.Text = "Endereço e Contato";
            // 
            // cbUFEmpresa
            // 
            this.cbUFEmpresa.Enabled = false;
            this.cbUFEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUFEmpresa.FormattingEnabled = true;
            this.cbUFEmpresa.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUFEmpresa.Location = new System.Drawing.Point(545, 508);
            this.cbUFEmpresa.Name = "cbUFEmpresa";
            this.cbUFEmpresa.Size = new System.Drawing.Size(165, 25);
            this.cbUFEmpresa.TabIndex = 122;
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.Enabled = false;
            this.txtNumEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEnd.Location = new System.Drawing.Point(408, 453);
            this.txtNumEnd.Multiline = true;
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(79, 28);
            this.txtNumEnd.TabIndex = 121;
            // 
            // txtRuaEmpresa
            // 
            this.txtRuaEmpresa.Enabled = false;
            this.txtRuaEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaEmpresa.Location = new System.Drawing.Point(11, 453);
            this.txtRuaEmpresa.Multiline = true;
            this.txtRuaEmpresa.Name = "txtRuaEmpresa";
            this.txtRuaEmpresa.Size = new System.Drawing.Size(393, 28);
            this.txtRuaEmpresa.TabIndex = 120;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(407, 279);
            this.txtCNPJ.Multiline = true;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(300, 28);
            this.txtCNPJ.TabIndex = 119;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(11, 279);
            this.txtRazaoSocial.Multiline = true;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(390, 28);
            this.txtRazaoSocial.TabIndex = 118;
            // 
            // lblStatusEmpresa
            // 
            this.lblStatusEmpresa.AutoSize = true;
            this.lblStatusEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEmpresa.Location = new System.Drawing.Point(526, 177);
            this.lblStatusEmpresa.Name = "lblStatusEmpresa";
            this.lblStatusEmpresa.Size = new System.Drawing.Size(55, 18);
            this.lblStatusEmpresa.TabIndex = 117;
            this.lblStatusEmpresa.Text = "Status";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(405, 434);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(24, 18);
            this.lblSenhaUsuario.TabIndex = 116;
            this.lblSenhaUsuario.Text = "Nº";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.Location = new System.Drawing.Point(11, 432);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(36, 18);
            this.lblLoginUsuario.TabIndex = 115;
            this.lblLoginUsuario.Text = "Rua";
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.BackColor = System.Drawing.Color.Transparent;
            this.EmailUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailUsuario.Location = new System.Drawing.Point(407, 259);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(47, 18);
            this.EmailUsuario.TabIndex = 114;
            this.EmailUsuario.Text = "CNPJ";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(14, 258);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(100, 18);
            this.lblNomeEmpresa.TabIndex = 113;
            this.lblNomeEmpresa.Text = "Razão Social";
            // 
            // txtDtCadastroEmp
            // 
            this.txtDtCadastroEmp.Enabled = false;
            this.txtDtCadastroEmp.Location = new System.Drawing.Point(285, 627);
            this.txtDtCadastroEmp.Multiline = true;
            this.txtDtCadastroEmp.Name = "txtDtCadastroEmp";
            this.txtDtCadastroEmp.Size = new System.Drawing.Size(172, 28);
            this.txtDtCadastroEmp.TabIndex = 151;
            // 
            // txtQtdFunc
            // 
            this.txtQtdFunc.Enabled = false;
            this.txtQtdFunc.Location = new System.Drawing.Point(463, 627);
            this.txtQtdFunc.Multiline = true;
            this.txtQtdFunc.Name = "txtQtdFunc";
            this.txtQtdFunc.Size = new System.Drawing.Size(247, 28);
            this.txtQtdFunc.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label17.Location = new System.Drawing.Point(16, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 21);
            this.label17.TabIndex = 172;
            this.label17.Text = "Dados da Empresa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1032, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 206;
            this.pictureBox1.TabStop = false;
            // 
            // GerenciarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1316, 801);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtQtdFunc);
            this.Controls.Add(this.btnAcessoFunc);
            this.Controls.Add(this.txtDtCadastroEmp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblCodigoEmpresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblIdEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatusEmp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRespEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelEmpresa);
            this.Controls.Add(this.txtComplem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmailEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidadeEmpresa);
            this.Controls.Add(this.txtBairroEmp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNomeFantEmpresa);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbUFEmpresa);
            this.Controls.Add(this.txtNumEnd);
            this.Controls.Add(this.txtRuaEmpresa);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lblStatusEmpresa);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListarEmpresas);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.txtPesqEmpresas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GerenciarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Empresas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarEmpresas;
        private System.Windows.Forms.Button btnBuscarEmpresa;
        private System.Windows.Forms.TextBox txtPesqEmpresas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListEmpresa;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaNomeEmpresa;
        private System.Windows.Forms.ColumnHeader colunaCNPJ;
        private System.Windows.Forms.ColumnHeader colunaStatusEmp;
        private System.Windows.Forms.ColumnHeader colunaDtCadastro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlterarEmpresa;
        private System.Windows.Forms.Button btnAcessoFunc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCodigoEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIdEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatusEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRespEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelEmpresa;
        private System.Windows.Forms.TextBox txtComplem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidadeEmpresa;
        private System.Windows.Forms.TextBox txtBairroEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeFantEmpresa;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbUFEmpresa;
        private System.Windows.Forms.TextBox txtNumEnd;
        private System.Windows.Forms.TextBox txtRuaEmpresa;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblStatusEmpresa;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtDtCadastroEmp;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtQtdFunc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}