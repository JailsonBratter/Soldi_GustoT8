using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLDIGusto
{
    public partial class EmUso : Form
    {
        public int intColuna { get; set; }
        public int intLinhas { get; set; }
        private int InicioPesq = 1;
        private int QuantPesq = 31;

        private int TipoOrdem = 10;

        private int Tempo = 0;

        public EmUso()
        {
            InitializeComponent();
            ParametrosLayout();
        }

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));
            BtnFechar.Region = new Region(Funcoes.BorderRadius(BtnFechar.Width, BtnFechar.Height, true, true));
            BtnAnterior.Region = new Region(Funcoes.BorderRadius(BtnAnterior.Width, BtnAnterior.Height, true, true));
            BtnProximo.Region = new Region(Funcoes.BorderRadius(BtnProximo.Width, BtnProximo.Height, true, true));
            BtnOrdemCom.Region = new Region(Funcoes.BorderRadius(BtnOrdemCom.Width, BtnOrdemCom.Height, true, true));
            BtnOrdemLanc.Region = new Region(Funcoes.BorderRadius(BtnOrdemLanc.Width, BtnOrdemLanc.Height, true, true));
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

        private void Comandas()
        {
            try
            {
                PnComandas.Controls.Clear();
                //Pegando os valores e a quantidade de botões
                ComandaControleDAO Com = new ComandaControleDAO();
                List<ComandaControleDAO> arrCom = Com.BuscarComanda(InicioPesq, QuantPesq, TipoOrdem);
                //variaveis para ajuda no layout
                int intBotoes = arrCom.Count();
                int locX = 10;
                int locY = 20;
                int cor = 0;

                if(intBotoes == 0)
                {
                    LblSemComandas.Visible = true;
                    LblSemComandas.Location = new Point(385, 246);
                }
                else
                    LblSemComandas.Visible = false;

                //Validando se tem paginação
                if (intBotoes >= 31)
                {
                    BtnProximo.Visible = true;
                    intBotoes--;
                }
                else
                {
                    BtnProximo.Visible = false;
                }
                //criando os botões
                for (int i = 0; i < intBotoes; i++)
                {
                    //definindo o valor da locazação (coluna)
                    if (intColuna == 6)
                    {
                        locY = locY + 100;
                        locX = 10;
                        intColuna = 0;
                        intLinhas++;
                    }
                    if (intLinhas == 5)
                    {
                        return;
                    }
                    if (cor == 15)
                    {
                        cor = 0;
                    }

                    #region Botão
                    //Gerando o botão
                    Button Btn = new Button();
                    Btn.Location = new Point(locX, locY);
                    locX = locX + 194;
                    Btn.Size = new Size(70, 53);
                    Btn.Region = new Region(Funcoes.BorderRadius(Btn.Width, Btn.Height, true, true));
                    Btn.BackgroundImageLayout = ImageLayout.Zoom;
                    cor++;
                    Btn.ForeColor = Color.White;
                    Btn.FlatStyle = FlatStyle.Flat;
                    Btn.Cursor = Cursors.Hand;
                    Btn.UseVisualStyleBackColor = false;
                    Btn.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    Btn.Click += new EventHandler(this.BtnCom_Click);
                    Btn.Name = arrCom.ElementAt(i).Total.ToString();
                    Btn.Tag = arrCom.ElementAt(i).comanda;

                    if (arrCom.ElementAt(i).status == "02")
                        Btn.BackgroundImage = Properties.Resources.Icon_Com;
                    else
                        Btn.BackgroundImage = Properties.Resources.Icon_ComVazia;

                    //Adicionado o botão ao painel
                    PnComandas.Controls.Add(Btn);
                    #endregion

                    Label LblCom = new Label();
                    LblCom.Location = new Point(Btn.Location.X + 80, locY);
                    LblCom.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    LblCom.Text = arrCom.ElementAt(i).comanda.ToString();
                    LblCom.Name = arrCom.ElementAt(i).Total.ToString();
                    LblCom.Tag = arrCom.ElementAt(i).comanda;
                    LblCom.Click += new EventHandler(this.Lbl_Click);
                    //Adicionado o botão ao painel
                    PnComandas.Controls.Add(LblCom);


                    Label LblValor = new Label();
                    LblValor.Location = new Point(Btn.Location.X + 80, locY + 20);
                    LblValor.Font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    LblValor.Name = arrCom.ElementAt(i).Total.ToString();
                    LblValor.Tag = arrCom.ElementAt(i).comanda;
                    LblValor.Click += new EventHandler(this.Lbl_Click);

                    if (arrCom.ElementAt(i).status == "02")
                        LblValor.Text = arrCom.ElementAt(i).Total.ToString("c");
                    else
                        LblValor.Text = 0.ToString("c");

                    //Adicionado o botão ao painel
                    PnComandas.Controls.Add(LblValor);

                    intColuna++;
                }
                intColuna = 0;
                intLinhas = 0;
            }
            catch (Exception err)
            {

                throw err;
            }

        }

        private void EmUso_Load(object sender, EventArgs e)
        {
            try
            {
                Comandas();
                TmAtualiza.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                TmAtualiza.Enabled = false;
                this.DialogResult = DialogResult.Cancel;

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            try
            {
                Button Btn = (Button)sender;
                Comanda PagCom = new Comanda(Btn.Tag.ToString(), Funcoes.ConvertstrToDecimal(Btn.Name));
                PagCom.ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            try
            {
                Label Lbl = (Label)sender;
                Comanda PagCom = new Comanda(Lbl.Tag.ToString(), Funcoes.ConvertstrToDecimal(Lbl.Name));
                PagCom.ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TmAtualiza_Tick(object sender, EventArgs e)
        {
            try
            {
                Tempo++;

                if (Tempo >= 200)
                {
                    PnComandas.Controls.Clear();
                    Comandas();
                    Tempo = 0;
                }

            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                InicioPesq += 30;
                QuantPesq += 31;

                Comandas();
                BtnAnterior.Visible = true;
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (InicioPesq > 30)
                {
                    InicioPesq -= 30;
                    QuantPesq -= 31;
                    Comandas();
                }

                if (InicioPesq == 1)
                    BtnAnterior.Visible = false;

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnOrdemCom_Click(object sender, EventArgs e)
        {
            try
            {
                InicioPesq = 1;
                QuantPesq = 31;
                BtnAnterior.Visible = false;
                if (TipoOrdem == 1)
                    TipoOrdem = 10;
                else
                    TipoOrdem = 1;

                Comandas();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnOrdemLanc_Click(object sender, EventArgs e)
        {
            try
            {
                InicioPesq = 1;
                QuantPesq = 31;
                BtnAnterior.Visible = false;
                if (TipoOrdem == 2)
                    TipoOrdem = 20;
                else
                    TipoOrdem = 2;

                Comandas();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
    }
}
