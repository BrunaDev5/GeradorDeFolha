using iTextSharp.text.pdf;
using iTextSharp.text;
using ProjetoHumanity.Models.Classes;
using System;
using System.Windows.Forms;
using System.IO;
using ProjetoHumanity.Controller;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoHumanity.Views
{
    public partial class Demonstrativo : Form
    {
        private int idUsuario;
        public Demonstrativo(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            AtualizarLabelUsuario();

        }

        private void AtualizarLabelUsuario()
        {
            lblUsuario.Text = "" + idUsuario.ToString();
        }

        public void PreencherDadosNasTextBoxes(DemonstrativoPagamento demonstrativoPagamento)
        {
            if (demonstrativoPagamento != null)
            {
                // Preenche os dados nas TextBoxes
                lblMesComp.Text = demonstrativoPagamento.DATA_INIC.ToString("MM");
                lblAnoComp.Text = demonstrativoPagamento.DATA_INIC.ToString("yyyy");
                lblCodFunc.Text = demonstrativoPagamento.COD_FUNC;
                lblNomeFunc.Text = demonstrativoPagamento.NOME_FUNC;
                lblFuncaoFunc.Text = demonstrativoPagamento.FUNCAO_FUNC;
                lblDtAdmi.Text = demonstrativoPagamento.DT_ADMISSAO.ToString("dd-MM-yyyy");
                lblInicio.Text = demonstrativoPagamento.DATA_INIC.ToString("dd-MM-yyyy");
                lblFim.Text = demonstrativoPagamento.DATA_FIM.ToString("dd-MM-yyyy");
                lblDtCredito.Text = demonstrativoPagamento.DATA_CREDITO.ToString("dd-MM-yyyy");
                txtSalBase.Text = demonstrativoPagamento.SALARIO_BASE.ToString("N2");
                txtTotalHrs.Text = demonstrativoPagamento.TOTAL_HRSTRAB.ToString();
                txtValorHrs.Text = demonstrativoPagamento.VALOR_HRSTRAB.ToString("N2");
                txtHrsExtra50.Text = demonstrativoPagamento.H_EXTRAS50.ToString("N2");
                txtValor50.Text = demonstrativoPagamento.VALOR_HEXTRAS50.ToString("N2");
                txtHrsExtra100.Text = demonstrativoPagamento.H_EXTRAS100.ToString("N2");
                txtValor100.Text = demonstrativoPagamento.VALOR_HEXTRAS100.ToString("N2");
                txtSalBruto.Text = demonstrativoPagamento.SAL_BRUTO.ToString("N2");
                txtFalta.Text = demonstrativoPagamento.QTD_FALTAS.ToString();
                txtValorFaltas.Text = demonstrativoPagamento.DSCT_FALTAS.ToString("N2");
                txtBenef.Text = demonstrativoPagamento.BENEFICIO.ToString();
                txtValorDesctBenef.Text = demonstrativoPagamento.DSCT_BENEF.ToString("N2");
                txtFaixaInss.Text = demonstrativoPagamento.FAIXA_INSS;
                txtValorInss.Text = demonstrativoPagamento.DSCT_INSS.ToString("N2");
                txtFaixaFgts.Text = demonstrativoPagamento.FAIXA_FGTS;
                txtValorFgts.Text = demonstrativoPagamento.DSCT_FGTS.ToString("N2");
                txtFaixaIrrf.Text = demonstrativoPagamento.FAIXA_IRRF;
                txtValorIrrf.Text = demonstrativoPagamento.DSCT_IRRF.ToString("N2");
                txtTotalDescontos.Text = demonstrativoPagamento.TOTAL_DESCONTOS.ToString("N2");
                txtSalLiquido.Text = demonstrativoPagamento.SALARIO_LIQUIDO.ToString("N2");
            }
            else
            {
                MessageBox.Show("Demonstrativo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Demonstrativo_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarPdf_Click(object sender, EventArgs e)
        {
            // Inicialize o objeto SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Especifique o caminho do arquivo de saída com base na escolha do usuário
                string outputPath = saveFileDialog.FileName;

                try
                {
                    using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                    {
                        // Crie um documento PDF
                        Document doc = new Document();

                        // Inicialize o documento PDF e crie um arquivo de saída
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                        // Abra o documento para edição
                        doc.Open();

                        // Adicione um título ao documento
                        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph titulo = new Paragraph("Demonstrativo de pagamento", titleFont);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);

                        // Adicione um espaço em branco após o título
                        Paragraph espacoEmBrancoAposTitulo = new Paragraph(" ");
                        espacoEmBrancoAposTitulo.SpacingAfter = 10f; // Adicione espaço após o parágrafo
                        doc.Add(espacoEmBrancoAposTitulo);

                        // Crie uma tabela para o cabeçalho
                        PdfPTable headerTable = new PdfPTable(2);
                        headerTable.WidthPercentage = 100;

                        PdfPCell funcionarioCell = new PdfPCell(new Phrase(
                        "Competência: " + lblMesComp.Text + "/" + lblAnoComp.Text + "\n\n\n" +
                        "Nome do Funcionário: " + lblNomeFunc.Text + "\n" +
                        "Código: " + lblCodFunc.Text + "\n" +
                        "Data de Admissão: " + lblDtAdmi.Text + "\n" +
                        "Função: " + lblFuncaoFunc.Text + "\n" +
                        "Data de Crédito: " + DateTime.Parse(lblDtCredito.Text).ToString("dd/MM/yyyy")
                        ));
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

                        // Crie uma tabela para armazenar os dados do demonstrativo de pagamento
                        PdfPTable table = new PdfPTable(2);
                        table.SetWidths(new float[] { 1, 1 }); // Divide a tabela em duas colunas
                        table.WidthPercentage = 100;

                        // Adicione a tabela de vencimentos à coluna 1
                        PdfPTable vencimentosTable = new PdfPTable(2);
                        AdicionarCabecalhoTabela(vencimentosTable, "Vencimentos");
                        AdicionarCelula(vencimentosTable, "Salário Base", txtSalBase.Text);
                        AdicionarCelula(vencimentosTable, "H.Trabalhadas", txtTotalHrs.Text);
                        AdicionarCelula(vencimentosTable, "Valor H.T R$", txtValorHrs.Text);
                        AdicionarCelula(vencimentosTable, "H.Extras 50%", txtHrsExtra50.Text);
                        AdicionarCelula(vencimentosTable, "Valor Horas Extras50% R$", txtValor50.Text);
                        AdicionarCelula(vencimentosTable, "Horas Extras (100%)", txtHrsExtra100.Text);
                        AdicionarCelula(vencimentosTable, "Valor Horas Extras (100%)", txtValor100.Text);
                        AdicionarCelula(vencimentosTable, "Faltas", txtFalta.Text);
                        AdicionarCelula(vencimentosTable, "Valor de Faltas", txtValorFaltas.Text);
                        AdicionarCelula(vencimentosTable, "Benefícios", txtBenef.Text);
                        AdicionarCelula(vencimentosTable, "Salário Bruto", txtSalBruto.Text);

                        PdfPCell vencimentosCell = new PdfPCell(vencimentosTable);
                       
                        // Obtenha a última célula adicionada à tabela
                        PdfPCell ultimaCelula = vencimentosTable.GetRow(vencimentosTable.Rows.Count - 1).GetCells()[1];
                        // Defina a cor de fundo da célula
                        ultimaCelula.BackgroundColor = new BaseColor(186, 205, 212); // Substitua pelos valores RGB desejados


                        // Adicione a tabela de descontos à coluna 2
                        PdfPTable descontosTable = new PdfPTable(2);
                        AdicionarCabecalhoTabela(descontosTable, "Descontos");
                        AdicionarCelula(descontosTable, "Desconto V.T", txtValorDesctBenef.Text);
                        AdicionarCelula(descontosTable, "Faixa INSS", txtFaixaInss.Text);
                        AdicionarCelula(descontosTable, "Valor de Desconto INSS", txtValorInss.Text);
                        AdicionarCelula(descontosTable, "Faixa FGTS", txtFaixaFgts.Text);
                        AdicionarCelula(descontosTable, "Valor de Desconto FGTS", txtValorFgts.Text);
                        AdicionarCelula(descontosTable, "Faixa IRRF", txtFaixaIrrf.Text);
                        AdicionarCelula(descontosTable, "Valor de Desconto IRRF", txtValorIrrf.Text);
                        AdicionarCelula(descontosTable, "Total de Descontos", txtTotalDescontos.Text);
                        // Adicione uma célula mesclada à tabela de descontos
                        // Adicione uma célula mesclada para as quatro células consecutivas
                        // Adicione uma célula mesclada para as quatro células consecutivas
                        PdfPCell celulaMesclada = new PdfPCell(new Phrase("Salário Liquido"));
                        celulaMesclada.HorizontalAlignment = Element.ALIGN_RIGHT;
                        celulaMesclada.Colspan = 2; // Mescla as quatro colunas
                        descontosTable.AddCell(celulaMesclada);

                        // Adicione uma célula com dados à nova linha (Salário Líquido)
                        PdfPCell celulaSalarioLiquido = new PdfPCell(new Phrase(txtSalLiquido.Text));
                        celulaSalarioLiquido.HorizontalAlignment = Element.ALIGN_RIGHT;
                        celulaSalarioLiquido.Colspan = 2; // Mescla as quatro colunas
                        celulaSalarioLiquido.BackgroundColor = new BaseColor(186, 205, 212); // Mova esta linha para antes de adicionar a célula à tabela
                        descontosTable.AddCell(celulaSalarioLiquido);

                        // Crie uma célula para envolver a tabela descontosTable
                        PdfPCell descontosCell = new PdfPCell(descontosTable);

                        // Adicione uma nova linha à tabela principal
                        table.AddCell(vencimentosCell);
                        table.AddCell(descontosCell);

                        // Defina o estilo para os cabeçalhos das tabelas
                        Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                        // Adicione os cabeçalhos diretamente às tabelas
                        PdfPCell vencimentosHeader = new PdfPCell(new Phrase("Vencimentos", headerFont));
                        vencimentosHeader.Colspan = 2;
                        vencimentosTable.AddCell(vencimentosHeader);

                        PdfPCell descontosHeader = new PdfPCell(new Phrase("Descontos", headerFont));
                        descontosHeader.Colspan = 2;
                        descontosTable.AddCell(descontosHeader);

                        // Adicione a tabela ao documento
                        doc.Add(table);

                      
                        doc.Close();

                        MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (DocumentException de)
                {
                    MessageBox.Show("Erro ao criar o documento PDF: " + de.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Erro de E/S: " + ioe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdicionarCelula(PdfPTable table, string rotulo, string valor)
        {
            PdfPCell rotuloCell = new PdfPCell(new Phrase(rotulo, FontFactory.GetFont(FontFactory.HELVETICA, 10f)));
            rotuloCell.BackgroundColor = new BaseColor(240, 240, 240);
            rotuloCell.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(rotuloCell);

            PdfPCell valorCell = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA, 10f)));
            valorCell.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(valorCell);
        }

        private void AdicionarCabecalhoTabela(PdfPTable table, string titulo)
        {
            // Adicione um espaço em branco
            table.AddCell(new PdfPCell(new Paragraph(" ")) { Colspan = 2, Border = 0 });

            // Adicione o título da seção centralizado e com um tamanho menor
            PdfPCell tituloCell = new PdfPCell(new Paragraph(titulo, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f)));
            tituloCell.Colspan = 2;
            tituloCell.Border = 0;
            tituloCell.HorizontalAlignment = Element.ALIGN_CENTER; // Centraliza o título
            table.AddCell(tituloCell);

            // Adicione um espaço em branco
            table.AddCell(new PdfPCell(new Paragraph(" ")) { Colspan = 2, Border = 0 });
        }
































    }
}





    







