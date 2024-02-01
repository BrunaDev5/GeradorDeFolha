using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ProjetoHumanity.Views
{
    public partial class PontoFuncionario : Form
    {
        private int idUsuario;
        private FUNCIONARIO funcionario;

        public PontoFuncionario(int idUsuario, FUNCIONARIO funcionario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
            this.funcionario = funcionario;

            AtualizarLabelUsuario();
            PreencherDadosFuncionario();
        }

        private void AtualizarLabelUsuario()
        {
            lblID_USUARIO.Text = idUsuario.ToString();
        }

        private void PreencherDadosFuncionario()
        {
            if (funcionario != null)
            {
                lblIdFunc.Text = funcionario.ID_FUNCIONARIO.ToString();
                txtCodFunc.Text = funcionario.COD_FUNC;
                cbStatusFunc.Text = funcionario.STATUS_FUNC;
                txtNomeFunc.Text = funcionario.NOME_FUNC;
                txtDtAdmissao.Text = funcionario.DT_ADMISSAO.ToString("dd-MM-yyyy");
                cbTurno.Text = funcionario.TURNO_FUNC;
                txtFuncao.Text = funcionario.FUNCAO_FUNC;
                txtSalarioBase.Text = funcionario.SALARIO_BASE.ToString("N2");

                // Tornar os campos somente leitura
                txtCodFunc.ReadOnly = false;
                cbStatusFunc.Enabled = false; // Use Enabled false para caixas de combinação
                txtNomeFunc.ReadOnly = false;
                txtDtAdmissao.ReadOnly = false;
                cbTurno.Enabled = false;
                txtFuncao.ReadOnly = false;
                txtSalarioBase.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnNovoPonto_Click(object sender, EventArgs e)
        {
            ControllerPonto controllerPonto = new ControllerPonto();

            // Verificar se o TIPO_TRABALHO é "Faltou"
            if (cbTipTrabalho.Text == "Faltou")
            {
                // Definir todos os campos de tempo como "00:00"
                txtHEntrada.Text = "00:00";
                txtHSaida.Text = "00:00";
                txtInicioIntervalo.Text = "00:00";
                txtFimInterv.Text = "00:00";
            }

            // Verificar se já existe um registro com a mesma data e tipo de trabalho
            int idFuncionario = Convert.ToInt32(lblIdFunc.Text);
            DateTime dataRegistro = Convert.ToDateTime(txtDtRegistro.Text);
            string tipoTrabalho = cbTipTrabalho.Text;

            if (controllerPonto.ExisteRegistroPonto(idFuncionario, dataRegistro, tipoTrabalho))
            {
                // Exibir um aviso ao usuário
                var confirmResult = MessageBox.Show("Já existe um registro com a mesma data e tipo de trabalho. Deseja criar outro registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.No)
                {
                    // O usuário escolheu não criar outro registro
                    return;
                }
            }

            // Criar o novo registro de ponto
            string mensagem = controllerPonto.NovoRegistroPonto(new RegistroPonto
            {
                ID_FUNCIONARIO = Convert.ToInt32(lblIdFunc.Text),
                DATA_REGISTRO = Convert.ToDateTime(txtDtRegistro.Text),
                TIPO_TRABALHO = cbTipTrabalho.Text,
                H_ENTRADA = TimeSpan.Parse(txtHEntrada.Text),
                H_SAIDA = TimeSpan.Parse(txtHSaida.Text),
                INICIO_ALMOCO = TimeSpan.Parse(txtInicioIntervalo.Text),
                FIM_ALMOCO = TimeSpan.Parse(txtFimInterv.Text),
                TIPO_FALTA = cbTipFalta.Text,
                ID_USUARIO = Convert.ToInt32(lblID_USUARIO.Text)
            });

            if (controllerPonto.Tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar os valores dos ComboBoxes para o mês e ano do novo registro
                DateTime DataRegistro = DateTime.Parse(txtDtRegistro.Text);
                cbMesesPesq.SelectedItem = DataRegistro.Month.ToString();
                cbAnoPesq.SelectedItem = DataRegistro.Year.ToString();

                // Chamar o método para buscar e atualizar os registros
                btnPesqFrequencia_Click(sender, e);
            }
            else
            {
                MessageBox.Show(controllerPonto.mensagem);
            }
        }

        private void btnPesqFrequencia_Click(object sender, EventArgs e)
        {
            // Verifique se um mês foi selecionado
            if (cbMesesPesq.SelectedItem == null)
            {
                MessageBox.Show("Selecione um mês desejado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Saia da função
            }

            // Verifique se um ano foi selecionado
            if (cbAnoPesq.SelectedItem == null)
            {
                MessageBox.Show("Selecione um ano desejado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Saia da função
            }


            // Capture o mês e o ano dos ComboBoxes ou outros controles
            int mesSelecionado = int.Parse(cbMesesPesq.SelectedItem.ToString());
            int anoSelecionado = int.Parse(cbAnoPesq.SelectedItem.ToString());
            int idFuncionario = int.Parse(lblIdFunc.Text.ToString());

            ControllerPonto controllerPonto = new ControllerPonto();
            

            List<RegistroPonto> registrosPonto = controllerPonto.BuscarRegistrosPontoPorMesEAno(mesSelecionado, anoSelecionado, idFuncionario);

            ListFrequencia.Items.Clear();

            if (registrosPonto != null && registrosPonto.Count > 0)
            {
                foreach (var registro in registrosPonto)
                {
                    string horasRealizadasFormatadas = $"{Math.Floor(registro.H_REALIZADAS)}:{(registro.H_REALIZADAS - Math.Floor(registro.H_REALIZADAS)) * 60:00}";
                    string[] linha = {

                         registro.DATA_REGISTRO.ToString("dd-MM-yyyy"), // Formata a data como "dd-MM-yyyy"
                         registro.TIPO_TRABALHO.ToString(),
                         registro.H_ENTRADA.ToString(),
                         registro.INICIO_ALMOCO.ToString(),
                         registro.FIM_ALMOCO.ToString(),
                         registro.H_SAIDA.ToString(),
                         horasRealizadasFormatadas, // Formata o valor como número decimal com 2 casas decimais
                         registro.QTDE_ATRASOS.ToString(),
                         registro.FALTAS.ToString(),
                         registro.TIPO_FALTA.ToString()
                    };

                    var linhaLista = new ListViewItem(linha);
                    ListFrequencia.Items.Add(linhaLista);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro de ponto encontrado para o mês e ano selecionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGerarListaPDF_Click(object sender, EventArgs e)
        {
            // Verifique se uma lista foi selecionada para salvar em PDF
            if (ListFrequencia.Items.Count == 0)
            {
                MessageBox.Show("Selecione uma lista para Salvar em PDF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Saia da função
            }

            // Crie um documento PDF
            Document doc = new Document();

            // Inicialize o objeto SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Especifique o caminho do arquivo de saída com base na escolha do usuário
                string outputPath = saveFileDialog.FileName;

                try
                {
                    // Inicialize o documento PDF e crie um arquivo de saída
                    PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                    // Abra o documento para edição
                    doc.Open();

                    // Adicione um título ao documento
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    Paragraph titulo = new Paragraph("Registro de Frequência", titleFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    // Adicione um espaço em branco após o título
                    Paragraph espacoEmBrancoAposTitulo = new Paragraph(" ");
                    espacoEmBrancoAposTitulo.SpacingAfter = 10f; // Adicione espaço após o parágrafo
                    doc.Add(espacoEmBrancoAposTitulo);

                    // Crie uma tabela para o cabeçalho
                    PdfPTable headerTable = new PdfPTable(2);
                    headerTable.WidthPercentage = 100;

                    PdfPCell funcionarioCell = new PdfPCell(new Phrase("Nome do Funcionário: " + txtNomeFunc.Text + "\n" +
                        "Código: " + txtCodFunc.Text + "\n" +
                        "Data de Admissão: " + txtDtAdmissao.Text + "\n" +
                        "Turno: " + cbTurno.Text + "\n" +
                        "Função: " + txtFuncao.Text));
                    funcionarioCell.Border = 0; // Remova a borda da célula
                    funcionarioCell.PaddingBottom = 10f; // Adicione espaço após a célula
                    funcionarioCell.Colspan = 2; // Mescla as duas colunas
                    headerTable.AddCell(funcionarioCell);

                    // Adicione a tabela de cabeçalho ao documento
                    doc.Add(headerTable);

                    // Adicione um espaço em branco após o título
                    Paragraph espacoEmBrancoAposcabecalho = new Paragraph(" ");
                    espacoEmBrancoAposcabecalho.SpacingAfter = 10f; // Adicione espaço após o parágrafo
                    doc.Add(espacoEmBrancoAposTitulo);

                    // Capture o mês e o ano dos ComboBoxes ou outros controles
                    int mesSelecionado = int.Parse(cbMesesPesq.SelectedItem.ToString());
                    int anoSelecionado = int.Parse(cbAnoPesq.SelectedItem.ToString());
                    int idFuncionario = int.Parse(lblIdFunc.Text.ToString());

                    ControllerPonto controllerPonto = new ControllerPonto();
                    List<RegistroPonto> registrosPonto = controllerPonto.BuscarRegistrosPontoPorMesEAno(mesSelecionado, anoSelecionado, idFuncionario);

                    if (registrosPonto != null && registrosPonto.Count > 0)
                    {
                        
                        // Crie uma tabela para armazenar os dados do ListView
                        PdfPTable table = new PdfPTable(ListFrequencia.Columns.Count);
                        table.DefaultCell.Padding = 3;

                        // Defina a largura total da tabela como a largura da página (100% da largura da página)
                        table.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;

                        // Bloqueie a largura da tabela para que o iTextSharp calcule as larguras automaticamente
                        table.LockedWidth = true;

                        table.HorizontalAlignment = Element.ALIGN_CENTER; // Centraliza a tabela
                        table.SetWidths(new float[] { 2f, 2f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 2f }); // Largura relativa das colunas

                        // Crie uma matriz de cabeçalho para as colunas
                        string[] headers = new string[ListFrequencia.Columns.Count];
                        for (int i = 0; i < ListFrequencia.Columns.Count; i++)
                        {
                            headers[i] = ListFrequencia.Columns[i].Text;
                        }

                        foreach (string header in headers)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 10f))); // Reduza o tamanho da fonte
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER; // Centraliza o conteúdo da célula
                            table.AddCell(cell);
                        }


                        // Adicione os dados da lista à tabela
                        foreach (var registro in registrosPonto)
                        {
                            string horasRealizadasFormatadas = $"{Math.Floor(registro.H_REALIZADAS)}:{(registro.H_REALIZADAS - Math.Floor(registro.H_REALIZADAS)) * 60:00}";
                            string qtdeAtrasosFormatada = $"{registro.QTDE_ATRASOS.Hours:00}:{registro.QTDE_ATRASOS.Minutes:00}";
                            table.AddCell(registro.DATA_REGISTRO.ToString("dd-MM-yyyy"));
                            table.AddCell(registro.TIPO_TRABALHO.ToString());
                            table.AddCell(registro.H_ENTRADA.ToString(@"hh\:mm"));
                            table.AddCell(registro.INICIO_ALMOCO.ToString(@"hh\:mm"));
                            table.AddCell(registro.FIM_ALMOCO.ToString(@"hh\:mm"));
                            table.AddCell(registro.H_SAIDA.ToString(@"hh\:mm"));
                            table.AddCell(horasRealizadasFormatadas);
                            table.AddCell(qtdeAtrasosFormatada);
                            table.AddCell(registro.FALTAS.ToString());
                            table.AddCell(registro.TIPO_FALTA.ToString());
                        }

                        // Adicione a tabela ao documento
                        doc.Add(table);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro de ponto encontrado para o mês e ano selecionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DocumentException de)
                {
                    MessageBox.Show("Erro ao criar o documento PDF: " + de.Message);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Erro de E/S: " + ioe.Message);
                }
                finally
                {
                    // Feche o documento
                    doc.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Feche o formulário atual (PontoFuncionario)
        }

        private void txtHEntrada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


