using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SOLDIGusto
{
    public partial class Comanda : Form
    {
        public string Com { get; set; }
        public Decimal Total { get; set; }
        public int Divisao = 1;

        public Comanda(string Comanda)
        {
            InitializeComponent();
            ParametrosLayout();
            Com = Comanda;
            LblComanda.Text += Com;
        }

        public Comanda(string Comanda, decimal Valor)
        {
            InitializeComponent();
            ParametrosLayout();
            Com = Comanda;
            Total = Valor;
            txtTotal.Text = Total.ToString("N");
            LblComanda.Text += Com;
        }

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));
            BtnFechar.Region = new Region(Funcoes.BorderRadius(BtnFechar.Width, BtnFechar.Height, true, true));
            GwItens.Region = new Region(Funcoes.BorderRadius(GwItens.Width, GwItens.Height, true, true));
            BtnListaMesa.Region = new Region(Funcoes.BorderRadius(BtnListaMesa.Width, BtnListaMesa.Height, true, true));
        }

        /// <summary>
        /// Metodo para definir os parametro de inicialização do form
        /// </summary>
        private void ParametrosLayout()
        {
            // definindo a posição e o layout 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //arredondando os botes
            ArredondarObjtos();
        }

        private void BuscarItens()
        {
            try
            {
                ComandaItemDAO Obj = new ComandaItemDAO();
                List<ComandaItemDAO> Itens = Obj.BuscarItensComanda(Funcoes.ConvertstrToInt(Com));
                GwItens.DataSource = null;
                GwItens.DataSource = Itens;
                GwItens.ClearSelection();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void Comanda_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarItens();
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnListaMesa_Click(object sender, EventArgs e)
        {
            string Mensagem = "";
            try
            {
                PrintDocument print = new PrintDocument();

                if (Parametros.Divide_Conta)
                {
                    ListaMesa PagLista = new ListaMesa();
                    PagLista.ShowDialog();

                    if (PagLista.DialogResult == DialogResult.OK)
                    {
                        Divisao = PagLista.Divisao;
                    }
                }

                if (Parametros.Solicita_Imp_Conta)
                {
                    SelecionaImpressora PagImp = new SelecionaImpressora();
                    PagImp.ShowDialog();
                    if (PagImp.DialogResult == DialogResult.OK)
                    {
                        if (PagImp.Impressora != null && PagImp.Impressora.Length > 0)
                        {
                            bool ImpInstalada = false;
                            //print.PrinterSettings.PrinterName = PagImp.Impressora;

                            foreach (string item in PrinterSettings.InstalledPrinters)
                            {
                                if (item.ToUpper() == PagImp.Impressora.ToUpper())
                                {
                                    ImpInstalada = true;
                                    print.PrinterSettings.PrinterName = item;
                                }
                            }// end foreach

                            if (!ImpInstalada)
                                Mensagem = "A impressora selecionada ("+ PagImp.Impressora + ") não esta configurada corretamente no terminal";
                        }
                    }// end if dialog
                }
                print.PrintPage += printDocument_PrintPage;
                print.Print();

                if(Mensagem.Length > 0)
                    Funcoes.GravarLog(Mensagem);
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var printDocument = sender as PrintDocument;

            if (printDocument != null)
            {
                #region Criando OBJ
                string Linhas = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
                string PulaLinha = "---------------------------------------- \n";
                StringBuilder Impressao = new StringBuilder();
                ImpressaoDao obj = new ImpressaoDao();
                List<ImpressaoDao> imprime = obj.BuscaConteudo(Funcoes.ConvertstrToInt(Com));
                decimal Total = 0;
                #endregion

                if (imprime.Count > 0)
                {
                    #region Razao
                    using (var font = new Font("Arial", 10, FontStyle.Bold))
                    using (var brush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(
                            imprime[0].NomeFantasia + "\n",
                            font,
                            brush,
                            new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                    }
                    #endregion

                    #region Conteudo Impressao
                    Impressao.Append("\n" + imprime[0].RazaoSocial);
                    Impressao.Append("\nDATA: " + DateTime.Now.ToShortDateString() + "      ");
                    Impressao.Append("HORA: " + DateTime.Now.ToLongTimeString() + "\n");
                    Impressao.Append("COMANDA/MESA:  " + Com + "  ");
                    Impressao.Append("| LOCALIZACAO: " + imprime[0].Item.localizacao + "\n");

                    Impressao.Append(PulaLinha);
                    Impressao.Append("|       DESCRICAO      |  QTDE  | TOTAL\n");
                    Impressao.Append(PulaLinha);

                    foreach (var item in imprime)
                    {
                        string descr = item.Item.Descrição;
                        if (descr.Length > 23)
                            descr = descr.Substring(0, 23);
                        Impressao.Append(descr.PadRight(23, ' ') + " ");
                        Impressao.Append(item.Item.qtde.ToString().PadLeft(7, ' ') + " ");
                        Impressao.Append(item.Item.total.ToString().PadLeft(7, ' ') + "\n");
                        Total += item.Item.total;
                        Linhas += "\n";
                    }

                    Impressao.Append(PulaLinha);
                    Impressao.Append("SubTotal".PadRight(20, ' ') + "--> R$" + Total.ToString("n").PadLeft(13, ' ') + " \n");
                    Decimal ServOp = Total * ((decimal)Parametros.Pct_Calculo / 100);
                    Impressao.Append("Serviço Opcional".PadRight(20, ' ') + "--> R$" + (ServOp).ToString("n").PadLeft(13, ' ') + " \n");
                    Impressao.Append("T O T A L".PadRight(20, ' ') + "--> R$" + (Total + ServOp).ToString("n").PadLeft(13, ' ') + " \n");
                    Impressao.Append(PulaLinha);
                    Impressao.Append("Nro de pessoas".PadRight(20, ' ') + "--> " + Divisao.ToString().PadLeft(15, ' ') + "\n");
                    Impressao.Append("Vlr por pessoas".PadRight(19, ' ') + " --> " + ((Total + ServOp) / Divisao).ToString("N").PadLeft(15, ' ') + "\n");

                    Impressao.Append(PulaLinha);
                    #endregion

                    using (var font2 = new Font("Courier New", 8))
                    using (var brush2 = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(
                            Impressao.ToString(),
                            font2,
                            brush2,
                            new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                    }

                    #region Assinatura
                    using (var font3 = new Font("Arial", 8, FontStyle.Bold))
                    using (var brush3 = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(
                            Linhas + "Bratter e Bocco (11) 5078-6121",
                            font3,
                            brush3,
                            new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                    }
                    #endregion
                }

            }
        }

    }
}
