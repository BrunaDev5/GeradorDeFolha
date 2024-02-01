namespace ProjetoHumanity.Views
{
    partial class FormsGerenciarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsGerenciarUsuario));
            this.ListUsuario = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesqUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListUsuario
            // 
            this.ListUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNome,
            this.colunaEmail,
            this.colunaLogin,
            this.colunaNivel,
            this.colunaStatus});
            this.ListUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsuario.FullRowSelect = true;
            this.ListUsuario.HideSelection = false;
            this.ListUsuario.Location = new System.Drawing.Point(340, 213);
            this.ListUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.ListUsuario.MultiSelect = false;
            this.ListUsuario.Name = "ListUsuario";
            this.ListUsuario.Size = new System.Drawing.Size(528, 249);
            this.ListUsuario.TabIndex = 0;
            this.ListUsuario.UseCompatibleStateImageBehavior = false;
            this.ListUsuario.View = System.Windows.Forms.View.Details;
            this.ListUsuario.SelectedIndexChanged += new System.EventHandler(this.ListUsuario_SelectedIndexChanged);
            this.ListUsuario.DoubleClick += new System.EventHandler(this.ListUsuario_DoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            this.colunaId.Width = 58;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome";
            this.colunaNome.Width = 270;
            // 
            // colunaEmail
            // 
            this.colunaEmail.Text = "Email";
            this.colunaEmail.Width = 258;
            // 
            // colunaLogin
            // 
            this.colunaLogin.Text = "Login";
            this.colunaLogin.Width = 65;
            // 
            // colunaNivel
            // 
            this.colunaNivel.Text = "Permissão";
            this.colunaNivel.Width = 91;
            // 
            // colunaStatus
            // 
            this.colunaStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciar Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(336, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o ID do usuário:";
            // 
            // txtPesqUsuario
            // 
            this.txtPesqUsuario.Location = new System.Drawing.Point(529, 168);
            this.txtPesqUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesqUsuario.Multiline = true;
            this.txtPesqUsuario.Name = "txtPesqUsuario";
            this.txtPesqUsuario.Size = new System.Drawing.Size(126, 27);
            this.txtPesqUsuario.TabIndex = 4;
            this.txtPesqUsuario.TextChanged += new System.EventHandler(this.txtPesqUsuario_TextChanged);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(663, 168);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(94, 27);
            this.btnBuscarUsuario.TabIndex = 6;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnListarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnListarUsuario.Location = new System.Drawing.Point(764, 168);
            this.btnListarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(104, 27);
            this.btnListarUsuario.TabIndex = 7;
            this.btnListarUsuario.Text = "Listar";
            this.btnListarUsuario.UseVisualStyleBackColor = true;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 51);
            this.panel1.TabIndex = 33;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(10, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "X CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnAlterar.Location = new System.Drawing.Point(743, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(125, 34);
            this.btnAlterar.TabIndex = 173;
            this.btnAlterar.Text = "SALVAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnLimpar.Location = new System.Drawing.Point(611, 5);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 34);
            this.btnLimpar.TabIndex = 172;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblID_USUARIO);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUsuarioLogado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 48);
            this.panel2.TabIndex = 34;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(835, 17);
            this.lblID_USUARIO.Name = "lblID_USUARIO";
            this.lblID_USUARIO.Size = new System.Drawing.Size(23, 18);
            this.lblID_USUARIO.TabIndex = 176;
            this.lblID_USUARIO.Text = "ID";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(761, 17);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 175;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(13, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 21);
            this.label15.TabIndex = 171;
            this.label15.Text = "Informações de Usuário";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNomeUsuario.Location = new System.Drawing.Point(11, 213);
            this.lblNomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(132, 18);
            this.lblNomeUsuario.TabIndex = 13;
            this.lblNomeUsuario.Text = "Nome do Usuário";
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.BackColor = System.Drawing.Color.Transparent;
            this.EmailUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailUsuario.ForeColor = System.Drawing.Color.Black;
            this.EmailUsuario.Location = new System.Drawing.Point(11, 278);
            this.EmailUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(47, 18);
            this.EmailUsuario.TabIndex = 14;
            this.EmailUsuario.Text = "Email";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblLoginUsuario.Location = new System.Drawing.Point(15, 348);
            this.lblLoginUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(48, 18);
            this.lblLoginUsuario.TabIndex = 15;
            this.lblLoginUsuario.Text = "Login";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaUsuario.Location = new System.Drawing.Point(178, 348);
            this.lblSenhaUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(53, 18);
            this.lblSenhaUsuario.TabIndex = 16;
            this.lblSenhaUsuario.Text = "Senha";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(178, 415);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 18);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.Black;
            this.lblNivel.Location = new System.Drawing.Point(14, 415);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(124, 18);
            this.lblNivel.TabIndex = 18;
            this.lblNivel.Text = "Nivel Permissão";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUser.Location = new System.Drawing.Point(15, 301);
            this.txtEmailUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailUser.Multiline = true;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(317, 25);
            this.txtEmailUser.TabIndex = 20;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.Location = new System.Drawing.Point(15, 371);
            this.txtLoginUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUser.Multiline = true;
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(151, 25);
            this.txtLoginUser.TabIndex = 21;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUser.Location = new System.Drawing.Point(174, 371);
            this.txtSenhaUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaUser.Multiline = true;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(158, 25);
            this.txtSenhaUser.TabIndex = 22;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbStatus.Location = new System.Drawing.Point(174, 438);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(158, 24);
            this.cbStatus.TabIndex = 23;
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbNivel.Location = new System.Drawing.Point(17, 438);
            this.cbNivel.Margin = new System.Windows.Forms.Padding(4);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(149, 24);
            this.cbNivel.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(50, 173);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 18);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(13, 235);
            this.txtNomeUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUser.Multiline = true;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(319, 25);
            this.txtNomeUser.TabIndex = 176;
            this.txtNomeUser.TextChanged += new System.EventHandler(this.txtNomeUser_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(178, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 180;
            this.label6.Text = "B = Bloqueado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(178, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 179;
            this.label7.Text = "A = Ativo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 178;
            this.label4.Text = "2 - Assistente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 177;
            this.label5.Text = "1 - Admin/Gerente";
            // 
            // FormsGerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSenhaUsuario);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnListarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.txtPesqUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListUsuario);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormsGerenciarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuario";
            this.Load += new System.EventHandler(this.FormsGerenciarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesqUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.ColumnHeader colunaEmail;
        private System.Windows.Forms.ColumnHeader colunaLogin;
        private System.Windows.Forms.ColumnHeader colunaNivel;
        private System.Windows.Forms.ColumnHeader colunaStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNivel;
        
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}