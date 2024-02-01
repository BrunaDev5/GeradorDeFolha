namespace ProjetoHumanity.Views
{
    partial class GerenciarFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarFolha));
            this.txtDtFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodFolha = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.btnCadastraFolha = new System.Windows.Forms.Button();
            this.btnListarFolhas = new System.Windows.Forms.Button();
            this.btnBuscarFolha = new System.Windows.Forms.Button();
            this.txtPesqFolhaPag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListFolhaPag = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunacodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDtInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDtFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDtCrédito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblIdFolha = new System.Windows.Forms.Label();
            this.txtDtcredito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDtInicio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtFinal.Location = new System.Drawing.Point(467, 126);
            this.txtDtFinal.Multiline = true;
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Size = new System.Drawing.Size(124, 25);
            this.txtDtFinal.TabIndex = 270;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(467, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 268;
            this.label12.Text = "Data Final";
            // 
            // txtCodFolha
            // 
            this.txtCodFolha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFolha.Location = new System.Drawing.Point(83, 126);
            this.txtCodFolha.Multiline = true;
            this.txtCodFolha.Name = "txtCodFolha";
            this.txtCodFolha.Size = new System.Drawing.Size(124, 25);
            this.txtCodFolha.TabIndex = 264;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(84, 105);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(62, 18);
            this.lblNomeEmpresa.TabIndex = 262;
            this.lblNomeEmpresa.Text = "Código ";
            // 
            // btnCadastraFolha
            // 
            this.btnCadastraFolha.BackColor = System.Drawing.Color.White;
            this.btnCadastraFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraFolha.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCadastraFolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnCadastraFolha.Location = new System.Drawing.Point(465, 157);
            this.btnCadastraFolha.Name = "btnCadastraFolha";
            this.btnCadastraFolha.Size = new System.Drawing.Size(125, 30);
            this.btnCadastraFolha.TabIndex = 273;
            this.btnCadastraFolha.Text = "CADASTRAR";
            this.btnCadastraFolha.UseVisualStyleBackColor = false;
            this.btnCadastraFolha.Click += new System.EventHandler(this.btnCadastraFolha_Click);
            // 
            // btnListarFolhas
            // 
            this.btnListarFolhas.BackColor = System.Drawing.Color.White;
            this.btnListarFolhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarFolhas.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnListarFolhas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnListarFolhas.Location = new System.Drawing.Point(465, 304);
            this.btnListarFolhas.Name = "btnListarFolhas";
            this.btnListarFolhas.Size = new System.Drawing.Size(125, 30);
            this.btnListarFolhas.TabIndex = 278;
            this.btnListarFolhas.Text = "LISTAR";
            this.btnListarFolhas.UseVisualStyleBackColor = false;
            this.btnListarFolhas.Click += new System.EventHandler(this.btnListarFolhas_Click);
            // 
            // btnBuscarFolha
            // 
            this.btnBuscarFolha.BackColor = System.Drawing.Color.White;
            this.btnBuscarFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFolha.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarFolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnBuscarFolha.Location = new System.Drawing.Point(334, 304);
            this.btnBuscarFolha.Name = "btnBuscarFolha";
            this.btnBuscarFolha.Size = new System.Drawing.Size(125, 30);
            this.btnBuscarFolha.TabIndex = 277;
            this.btnBuscarFolha.Text = "BUSCAR";
            this.btnBuscarFolha.UseVisualStyleBackColor = false;
            this.btnBuscarFolha.Click += new System.EventHandler(this.btnBuscarFolha_Click);
            // 
            // txtPesqFolhaPag
            // 
            this.txtPesqFolhaPag.Location = new System.Drawing.Point(196, 305);
            this.txtPesqFolhaPag.Multiline = true;
            this.txtPesqFolhaPag.Name = "txtPesqFolhaPag";
            this.txtPesqFolhaPag.Size = new System.Drawing.Size(132, 30);
            this.txtPesqFolhaPag.TabIndex = 276;
            this.txtPesqFolhaPag.TextChanged += new System.EventHandler(this.txtPesqFolhaPag_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 275;
            this.label3.Text = "Insira o ID :";
            // 
            // ListFolhaPag
            // 
            this.ListFolhaPag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunacodigo,
            this.colunaDtInicio,
            this.colunaDtFinal,
            this.colunaDtCrédito});
            this.ListFolhaPag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListFolhaPag.FullRowSelect = true;
            this.ListFolhaPag.HideSelection = false;
            this.ListFolhaPag.Location = new System.Drawing.Point(14, 341);
            this.ListFolhaPag.MultiSelect = false;
            this.ListFolhaPag.Name = "ListFolhaPag";
            this.ListFolhaPag.Size = new System.Drawing.Size(577, 194);
            this.ListFolhaPag.TabIndex = 274;
            this.ListFolhaPag.UseCompatibleStateImageBehavior = false;
            this.ListFolhaPag.View = System.Windows.Forms.View.Details;
            this.ListFolhaPag.SelectedIndexChanged += new System.EventHandler(this.ListFolhaPag_SelectedIndexChanged);
            this.ListFolhaPag.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListFolhaPag_MouseDoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            this.colunaId.Width = 58;
            // 
            // colunacodigo
            // 
            this.colunacodigo.Text = "Código";
            this.colunacodigo.Width = 104;
            // 
            // colunaDtInicio
            // 
            this.colunaDtInicio.Text = "Data Inicio";
            this.colunaDtInicio.Width = 109;
            // 
            // colunaDtFinal
            // 
            this.colunaDtFinal.Text = "Data Final";
            this.colunaDtFinal.Width = 142;
            // 
            // colunaDtCrédito
            // 
            this.colunaDtCrédito.Text = "Data de Crédito";
            this.colunaDtCrédito.Width = 155;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnLimpar.Location = new System.Drawing.Point(354, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpar.TabIndex = 281;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(17, 129);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 18);
            this.lblid.TabIndex = 325;
            this.lblid.Text = "ID :";
            // 
            // lblIdFolha
            // 
            this.lblIdFolha.AutoSize = true;
            this.lblIdFolha.BackColor = System.Drawing.Color.Transparent;
            this.lblIdFolha.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFolha.ForeColor = System.Drawing.Color.Red;
            this.lblIdFolha.Location = new System.Drawing.Point(54, 129);
            this.lblIdFolha.Name = "lblIdFolha";
            this.lblIdFolha.Size = new System.Drawing.Size(23, 18);
            this.lblIdFolha.TabIndex = 324;
            this.lblIdFolha.Text = "ID";
            // 
            // txtDtcredito
            // 
            this.txtDtcredito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtcredito.Location = new System.Drawing.Point(211, 126);
            this.txtDtcredito.Multiline = true;
            this.txtDtcredito.Name = "txtDtcredito";
            this.txtDtcredito.Size = new System.Drawing.Size(124, 25);
            this.txtDtcredito.TabIndex = 331;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 330;
            this.label4.Text = "Data do Crédito";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 576);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 51);
            this.panel3.TabIndex = 280;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(12, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 34);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "X CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblID_USUARIO);
            this.panel1.Controls.Add(this.lblUsuarioLogado);
            this.panel1.Controls.Add(this.lblDadosFuncionario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 44);
            this.panel1.TabIndex = 261;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(817, 8);
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
            this.lblUsuarioLogado.Location = new System.Drawing.Point(743, 9);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 78;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosFuncionario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblDadosFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblDadosFuncionario.Location = new System.Drawing.Point(9, 9);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(276, 28);
            this.lblDadosFuncionario.TabIndex = 0;
            this.lblDadosFuncionario.Text = "Gerenciamento da Folha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 263;
            this.label5.Text = "Data Inicio";
            // 
            // txtDtInicio
            // 
            this.txtDtInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtInicio.Location = new System.Drawing.Point(339, 126);
            this.txtDtInicio.Multiline = true;
            this.txtDtInicio.Name = "txtDtInicio";
            this.txtDtInicio.Size = new System.Drawing.Size(124, 25);
            this.txtDtInicio.TabIndex = 265;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(19, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 21);
            this.label15.TabIndex = 332;
            this.label15.Text = "Inclusão de Folha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(10, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 21);
            this.label1.TabIndex = 333;
            this.label1.Text = "Pesquisa de Folhas de Pagamento";
            // 
            // GerenciarFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDtcredito);
            this.Controls.Add(this.btnCadastraFolha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblIdFolha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnListarFolhas);
            this.Controls.Add(this.btnBuscarFolha);
            this.Controls.Add(this.txtPesqFolhaPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListFolhaPag);
            this.Controls.Add(this.txtDtFinal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDtInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodFolha);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciarFolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarFolha";
            this.Load += new System.EventHandler(this.GerenciarFolha_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.TextBox txtDtFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodFolha;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Button btnCadastraFolha;
        private System.Windows.Forms.Button btnListarFolhas;
        private System.Windows.Forms.Button btnBuscarFolha;
        private System.Windows.Forms.TextBox txtPesqFolhaPag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListFolhaPag;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunacodigo;
        private System.Windows.Forms.ColumnHeader colunaDtInicio;
        private System.Windows.Forms.ColumnHeader colunaDtFinal;
        private System.Windows.Forms.ColumnHeader colunaDtCrédito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblIdFolha;
        private System.Windows.Forms.TextBox txtDtcredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDtInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}