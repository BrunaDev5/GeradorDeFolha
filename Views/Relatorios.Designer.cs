namespace ProjetoHumanity.Views
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID_USUARIO = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblTituloGerenFunc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInformacaopesq = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(991, 44);
            this.panel1.TabIndex = 3;
            // 
            // lblID_USUARIO
            // 
            this.lblID_USUARIO.AutoSize = true;
            this.lblID_USUARIO.BackColor = System.Drawing.Color.Transparent;
            this.lblID_USUARIO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USUARIO.ForeColor = System.Drawing.Color.White;
            this.lblID_USUARIO.Location = new System.Drawing.Point(948, 8);
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
            this.lblUsuarioLogado.Location = new System.Drawing.Point(874, 9);
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
            this.lblTituloGerenFunc.Size = new System.Drawing.Size(255, 28);
            this.lblTituloGerenFunc.TabIndex = 0;
            this.lblTituloGerenFunc.Text = "Relatórios Gerenciais ";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 615);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 51);
            this.panel3.TabIndex = 204;
            // 
            // lblInformacaopesq
            // 
            this.lblInformacaopesq.AutoSize = true;
            this.lblInformacaopesq.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacaopesq.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblInformacaopesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(235)))));
            this.lblInformacaopesq.Location = new System.Drawing.Point(10, 69);
            this.lblInformacaopesq.Name = "lblInformacaopesq";
            this.lblInformacaopesq.Size = new System.Drawing.Size(266, 19);
            this.lblInformacaopesq.TabIndex = 205;
            this.lblInformacaopesq.Text = "Selecione o Relatório desejado : ";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 666);
            this.Controls.Add(this.lblInformacaopesq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID_USUARIO;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Label lblTituloGerenFunc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInformacaopesq;
    }
}