namespace ProjetoHumanity.Views
{
    partial class Relatorio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio1));
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.DataPesqFolha = new System.Windows.Forms.TextBox();
            this.Texto1 = new System.Windows.Forms.Label();
            this.ListRelatorioFolha = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNomeEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaQtdFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaValorTotalEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQtdTotalFunci = new System.Windows.Forms.TextBox();
            this.txtValorTotalFolha = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblIdFolha = new System.Windows.Forms.Label();
            this.txtDtFinalVig = new System.Windows.Forms.TextBox();
            this.txtDataCrédito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDtIncVigencia = new System.Windows.Forms.TextBox();
            this.txtCodFolha = new System.Windows.Forms.TextBox();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.label15.Location = new System.Drawing.Point(9, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 21);
            this.label15.TabIndex = 200;
            this.label15.Text = "Detalhamento da folha";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(714, 56);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(94, 27);
            this.btnBuscarUsuario.TabIndex = 184;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // DataPesqFolha
            // 
            this.DataPesqFolha.Location = new System.Drawing.Point(580, 56);
            this.DataPesqFolha.Margin = new System.Windows.Forms.Padding(4);
            this.DataPesqFolha.Multiline = true;
            this.DataPesqFolha.Name = "DataPesqFolha";
            this.DataPesqFolha.Size = new System.Drawing.Size(126, 27);
            this.DataPesqFolha.TabIndex = 183;
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.BackColor = System.Drawing.Color.Transparent;
            this.Texto1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Texto1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.Texto1.Location = new System.Drawing.Point(410, 64);
            this.Texto1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(162, 19);
            this.Texto1.TabIndex = 182;
            this.Texto1.Text = "Insira a Data Inicial:";
            // 
            // ListRelatorioFolha
            // 
            this.ListRelatorioFolha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListRelatorioFolha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNomeEmpresa,
            this.colunaQtdFunc,
            this.colunaValorTotalEmp});
            this.ListRelatorioFolha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRelatorioFolha.FullRowSelect = true;
            this.ListRelatorioFolha.HideSelection = false;
            this.ListRelatorioFolha.Location = new System.Drawing.Point(13, 237);
            this.ListRelatorioFolha.Margin = new System.Windows.Forms.Padding(4);
            this.ListRelatorioFolha.MultiSelect = false;
            this.ListRelatorioFolha.Name = "ListRelatorioFolha";
            this.ListRelatorioFolha.Size = new System.Drawing.Size(795, 241);
            this.ListRelatorioFolha.TabIndex = 181;
            this.ListRelatorioFolha.UseCompatibleStateImageBehavior = false;
            this.ListRelatorioFolha.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            this.colunaId.Width = 58;
            // 
            // colunaNomeEmpresa
            // 
            this.colunaNomeEmpresa.Text = "Empresa";
            this.colunaNomeEmpresa.Width = 401;
            // 
            // colunaQtdFunc
            // 
            this.colunaQtdFunc.Text = "Qtd. Funcionários";
            this.colunaQtdFunc.Width = 258;
            // 
            // colunaValorTotalEmp
            // 
            this.colunaValorTotalEmp.Text = "Valor";
            this.colunaValorTotalEmp.Width = 65;
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
            this.panel2.Size = new System.Drawing.Size(822, 48);
            this.panel2.TabIndex = 199;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(788, 17);
            this.lblID_USUARIO.Name = "lblID_USUARIO";
            this.lblID_USUARIO.Size = new System.Drawing.Size(23, 18);
            this.lblID_USUARIO.TabIndex = 176;
            this.lblID_USUARIO.Text = "ID";
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
            this.label1.Size = new System.Drawing.Size(367, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Folha de Pagamento";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(714, 17);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarioLogado.TabIndex = 175;
            this.lblUsuarioLogado.Text = "Usuário:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 51);
            this.panel1.TabIndex = 198;
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
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.btnLimpar.Location = new System.Drawing.Point(640, 5);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(168, 34);
            this.btnLimpar.TabIndex = 172;
            this.btnLimpar.Text = "GERENCIAR FOLHA";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtQtdTotalFunci
            // 
            this.txtQtdTotalFunci.Location = new System.Drawing.Point(274, 516);
            this.txtQtdTotalFunci.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdTotalFunci.Multiline = true;
            this.txtQtdTotalFunci.Name = "txtQtdTotalFunci";
            this.txtQtdTotalFunci.Size = new System.Drawing.Size(103, 27);
            this.txtQtdTotalFunci.TabIndex = 202;
            // 
            // txtValorTotalFolha
            // 
            this.txtValorTotalFolha.Location = new System.Drawing.Point(682, 516);
            this.txtValorTotalFolha.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorTotalFolha.Multiline = true;
            this.txtValorTotalFolha.Name = "txtValorTotalFolha";
            this.txtValorTotalFolha.Size = new System.Drawing.Size(126, 27);
            this.txtValorTotalFolha.TabIndex = 203;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(10, 194);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 18);
            this.lblid.TabIndex = 361;
            this.lblid.Text = "ID :";
            // 
            // lblIdFolha
            // 
            this.lblIdFolha.AutoSize = true;
            this.lblIdFolha.BackColor = System.Drawing.Color.Transparent;
            this.lblIdFolha.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFolha.ForeColor = System.Drawing.Color.Red;
            this.lblIdFolha.Location = new System.Drawing.Point(47, 194);
            this.lblIdFolha.Name = "lblIdFolha";
            this.lblIdFolha.Size = new System.Drawing.Size(23, 18);
            this.lblIdFolha.TabIndex = 360;
            this.lblIdFolha.Text = "ID";
            // 
            // txtDtFinalVig
            // 
            this.txtDtFinalVig.Enabled = false;
            this.txtDtFinalVig.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtFinalVig.Location = new System.Drawing.Point(557, 191);
            this.txtDtFinalVig.Multiline = true;
            this.txtDtFinalVig.Name = "txtDtFinalVig";
            this.txtDtFinalVig.Size = new System.Drawing.Size(124, 28);
            this.txtDtFinalVig.TabIndex = 359;
            // 
            // txtDataCrédito
            // 
            this.txtDataCrédito.Enabled = false;
            this.txtDataCrédito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCrédito.Location = new System.Drawing.Point(687, 191);
            this.txtDataCrédito.Multiline = true;
            this.txtDataCrédito.Name = "txtDataCrédito";
            this.txtDataCrédito.Size = new System.Drawing.Size(121, 28);
            this.txtDataCrédito.TabIndex = 358;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(557, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 357;
            this.label12.Text = "Data Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(690, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 18);
            this.label13.TabIndex = 356;
            this.label13.Text = "Data do Crédito";
            // 
            // txtDtIncVigencia
            // 
            this.txtDtIncVigencia.Enabled = false;
            this.txtDtIncVigencia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtIncVigencia.Location = new System.Drawing.Point(430, 191);
            this.txtDtIncVigencia.Multiline = true;
            this.txtDtIncVigencia.Name = "txtDtIncVigencia";
            this.txtDtIncVigencia.Size = new System.Drawing.Size(121, 28);
            this.txtDtIncVigencia.TabIndex = 355;
            // 
            // txtCodFolha
            // 
            this.txtCodFolha.Enabled = false;
            this.txtCodFolha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFolha.Location = new System.Drawing.Point(303, 191);
            this.txtCodFolha.Multiline = true;
            this.txtCodFolha.Name = "txtCodFolha";
            this.txtCodFolha.Size = new System.Drawing.Size(121, 28);
            this.txtCodFolha.TabIndex = 354;
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.BackColor = System.Drawing.Color.Transparent;
            this.EmailUsuario.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailUsuario.Location = new System.Drawing.Point(430, 171);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(86, 18);
            this.EmailUsuario.TabIndex = 353;
            this.EmailUsuario.Text = "Data Inicio";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(306, 170);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(102, 18);
            this.lblNomeEmpresa.TabIndex = 352;
            this.lblNomeEmpresa.Text = "Código Folha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 362;
            this.label2.Text = "Valor Total da Folha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 363;
            this.label3.Text = "Funcionários ";
            // 
            // txtQtdEmp
            // 
            this.txtQtdEmp.Location = new System.Drawing.Point(163, 516);
            this.txtQtdEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdEmp.Multiline = true;
            this.txtQtdEmp.Name = "txtQtdEmp";
            this.txtQtdEmp.Size = new System.Drawing.Size(103, 27);
            this.txtQtdEmp.TabIndex = 364;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 365;
            this.label4.Text = "Empresas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 366;
            this.label5.Text = "QuantidadeTotal : ";
            // 
            // Relatorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 636);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblIdFolha);
            this.Controls.Add(this.txtDtFinalVig);
            this.Controls.Add(this.txtDataCrédito);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDtIncVigencia);
            this.Controls.Add(this.txtCodFolha);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.txtValorTotalFolha);
            this.Controls.Add(this.txtQtdTotalFunci);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.DataPesqFolha);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.ListRelatorioFolha);
            this.Name = "Relatorio1";
            this.Text = "Relatorio1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox DataPesqFolha;
        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.ListView ListRelatorioFolha;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaNomeEmpresa;
        private System.Windows.Forms.ColumnHeader colunaQtdFunc;
        private System.Windows.Forms.ColumnHeader colunaValorTotalEmp;
        private System.Windows.Forms.TextBox txtQtdTotalFunci;
        private System.Windows.Forms.TextBox txtValorTotalFolha;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblIdFolha;
        private System.Windows.Forms.TextBox txtDtFinalVig;
        private System.Windows.Forms.TextBox txtDataCrédito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDtIncVigencia;
        private System.Windows.Forms.TextBox txtCodFolha;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}