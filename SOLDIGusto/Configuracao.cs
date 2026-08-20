using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLDIGusto
{
    public partial class Configuracao : Form
    {
        public bool Inicio { get; set; }
        public bool Inicio_Sub { get; set; }

        private TextBoxBase UltimoCampo { get; set; }

        public Configuracao()
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
            BtnTecladoAlfa.Region = new Region(Funcoes.BorderRadius(BtnTecladoAlfa.Width, BtnTecladoAlfa.Height, true, true));
            BtnConfirm.Region = new Region(Funcoes.BorderRadius(BtnConfirm.Width, BtnConfirm.Height, true, true));
            PnTecladoAlfa.Region = new Region(Funcoes.BorderRadius(PnTecladoAlfa.Width, PnTecladoAlfa.Height, true, true));

            //-------------------------------------------TECLADO ALFA---------------------------------------------------
            //numeros
            BtnTeclaAlfa0.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa0.Width, BtnTeclaAlfa0.Height, true, true));
            BtnTeclaAlfa1.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa1.Width, BtnTeclaAlfa1.Height, true, true));
            BtnTeclaAlfa2.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa2.Width, BtnTeclaAlfa2.Height, true, true));
            BtnTeclaAlfa3.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa3.Width, BtnTeclaAlfa3.Height, true, true));
            BtnTeclaAlfa4.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa4.Width, BtnTeclaAlfa4.Height, true, true));
            BtnTeclaAlfa5.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa5.Width, BtnTeclaAlfa5.Height, true, true));
            BtnTeclaAlfa6.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa6.Width, BtnTeclaAlfa6.Height, true, true));
            BtnTeclaAlfa7.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa7.Width, BtnTeclaAlfa7.Height, true, true));
            BtnTeclaAlfa8.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa8.Width, BtnTeclaAlfa8.Height, true, true));
            BtnTeclaAlfa9.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfa9.Width, BtnTeclaAlfa9.Height, true, true));

            //alfabeto
            BtnTeclaA.Region = new Region(Funcoes.BorderRadius(BtnTeclaA.Width, BtnTeclaA.Height, true, true));
            BtnTeclaB.Region = new Region(Funcoes.BorderRadius(BtnTeclaB.Width, BtnTeclaB.Height, true, true));
            BtnTeclaC.Region = new Region(Funcoes.BorderRadius(BtnTeclaC.Width, BtnTeclaC.Height, true, true));
            BtnTeclaD.Region = new Region(Funcoes.BorderRadius(BtnTeclaD.Width, BtnTeclaD.Height, true, true));
            BtnTeclaE.Region = new Region(Funcoes.BorderRadius(BtnTeclaE.Width, BtnTeclaE.Height, true, true));
            BtnTeclaF.Region = new Region(Funcoes.BorderRadius(BtnTeclaF.Width, BtnTeclaF.Height, true, true));
            BtnTeclaG.Region = new Region(Funcoes.BorderRadius(BtnTeclaG.Width, BtnTeclaG.Height, true, true));
            BtnTeclaH.Region = new Region(Funcoes.BorderRadius(BtnTeclaH.Width, BtnTeclaH.Height, true, true));
            BtnTeclaI.Region = new Region(Funcoes.BorderRadius(BtnTeclaI.Width, BtnTeclaI.Height, true, true));
            BtnTeclaJ.Region = new Region(Funcoes.BorderRadius(BtnTeclaJ.Width, BtnTeclaJ.Height, true, true));
            BtnTeclaK.Region = new Region(Funcoes.BorderRadius(BtnTeclaK.Width, BtnTeclaK.Height, true, true));
            BtnTeclaL.Region = new Region(Funcoes.BorderRadius(BtnTeclaL.Width, BtnTeclaL.Height, true, true));
            BtnTeclaM.Region = new Region(Funcoes.BorderRadius(BtnTeclaM.Width, BtnTeclaM.Height, true, true));
            BtnTeclaN.Region = new Region(Funcoes.BorderRadius(BtnTeclaN.Width, BtnTeclaN.Height, true, true));
            BtnTeclaO.Region = new Region(Funcoes.BorderRadius(BtnTeclaO.Width, BtnTeclaO.Height, true, true));
            BtnTeclaP.Region = new Region(Funcoes.BorderRadius(BtnTeclaP.Width, BtnTeclaP.Height, true, true));
            BtnTeclaQ.Region = new Region(Funcoes.BorderRadius(BtnTeclaQ.Width, BtnTeclaQ.Height, true, true));
            BtnTeclaR.Region = new Region(Funcoes.BorderRadius(BtnTeclaR.Width, BtnTeclaR.Height, true, true));
            BtnTeclaS.Region = new Region(Funcoes.BorderRadius(BtnTeclaS.Width, BtnTeclaS.Height, true, true));
            BtnTeclaT.Region = new Region(Funcoes.BorderRadius(BtnTeclaT.Width, BtnTeclaT.Height, true, true));
            BtnTeclaU.Region = new Region(Funcoes.BorderRadius(BtnTeclaU.Width, BtnTeclaU.Height, true, true));
            BtnTeclaV.Region = new Region(Funcoes.BorderRadius(BtnTeclaV.Width, BtnTeclaV.Height, true, true));
            BtnTeclaX.Region = new Region(Funcoes.BorderRadius(BtnTeclaX.Width, BtnTeclaX.Height, true, true));
            BtnTeclaY.Region = new Region(Funcoes.BorderRadius(BtnTeclaY.Width, BtnTeclaY.Height, true, true));
            BtnTeclaW.Region = new Region(Funcoes.BorderRadius(BtnTeclaW.Width, BtnTeclaW.Height, true, true));
            BtnTeclaZ.Region = new Region(Funcoes.BorderRadius(BtnTeclaZ.Width, BtnTeclaZ.Height, true, true));

            //especiais
            BtnTeclaESPACO.Region = new Region(Funcoes.BorderRadius(BtnTeclaESPACO.Width, BtnTeclaESPACO.Height, true, true));
            BtnTeclaSetaDireita.Region = new Region(Funcoes.BorderRadius(BtnTeclaSetaDireita.Width, BtnTeclaSetaDireita.Height, true, true));
            BtnTeclaSetaEsquerda.Region = new Region(Funcoes.BorderRadius(BtnTeclaSetaEsquerda.Width, BtnTeclaSetaEsquerda.Height, true, true));
            BtnTeclaPonto.Region = new Region(Funcoes.BorderRadius(BtnTeclaPonto.Width, BtnTeclaPonto.Height, true, true));
            BtnTeclaAlfaVirgula.Region = new Region(Funcoes.BorderRadius(BtnTeclaAlfaVirgula.Width, BtnTeclaAlfaVirgula.Height, true, true));
            BtnClearTeclado.Region = new Region(Funcoes.BorderRadius(BtnClearTeclado.Width, BtnClearTeclado.Height, true, true));
            BtnTraco.Region = new Region(Funcoes.BorderRadius(BtnTraco.Width, BtnTraco.Height, true, true));
            BtnApagarAlfa.Region = new Region(Funcoes.BorderRadius(BtnApagarAlfa.Width, BtnApagarAlfa.Height, true, true));
            BtnEnter.Region = new Region(Funcoes.BorderRadius(BtnEnter.Width, BtnEnter.Height, true, true));

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

        /// <summary>
        /// Metodo para as funcionalidades do teclado
        /// </summary>
        /// <param name="tecla">Tecla digitada</param>
        private void Teclado(string tecla)
        {
            try
            {
                UltimoCampo.Focus();
                SendKeys.Send(tecla);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Carrega a lista de portas disponiveis para balança
        /// </summary>
        private void CarregarPortas()
        {
            try
            {
                CbxNamePorta.DataSource = null;
                CbxNamePorta.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                CbxNamePorta.SelectedItem = Parametros.Porta_balanca;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregarDadosTela()
        {
            try
            {
                // Geral
                TxtRetiraColuna.Text = Parametros.Col_Retira_Comanda.ToString();
                TxtQtdeMaxItem.Text = Parametros.Qtde_Max_Item.ToString();
                TxtVlrMaxItem.Text = Parametros.Valor_Max_Item.ToString();
                CbAlteraLocal.Checked = Parametros.Altera_Local;
                CbAtivaLocal.Checked = Parametros.Insere_local;
                CbApenasLeitura.Checked = Parametros.Com_apenas_leitura;
                CbDivideConta.Checked = Parametros.Divide_Conta;
                CbFixaUser.Checked = Parametros.Fixa_Op;
                CbImpConta.Checked = Parametros.Solicita_Imp_Conta;
                CbTrataCom.Checked = Parametros.Trata_Comanda;
                CbMotivoCan.Checked = Parametros.Solicita_Motivo;
                TxtVelocidade.Text = Parametros.Velocidade_porta.ToString();
                TxtFilial.Text = Parametros.Filial;
                TxtPct.Text = Parametros.Pct_Calculo.ToString();
                CbDelivery.Checked = Parametros.Delivery;
                CbBarraDuplicada.Checked = Parametros.Codigo_Barras_Duplicado;
                TxtBarraDuplicadaDigitos.Text = Parametros.Codigo_Barras_Duplicado_Digitos.ToString();
                chkBloqueiaImpressao.Checked = Parametros.Bloqueia_Impressao;
                CbGOOMER.Checked = Parametros.usa_goomer;
                if (Parametros.Terminal > 0)
                    TxtTerminal.Text = Parametros.Terminal.ToString();

                //Botões
                #region Btn atalho
                if (Parametros.Cod_Btn01 > 0)
                    TxtCodBtnAtalho1.Text = Parametros.Cod_Btn01.ToString();
                TxtDescBtnAtalho1.Text = Parametros.Desc_Btn01;
                TxtLegBtnAtalho1.Text = Parametros.Texto_Btn01;

                if (Parametros.Cod_Btn02 > 0)
                    TxtCodBtnAtalho2.Text = Parametros.Cod_Btn02.ToString();
                TxtDescBtnAtalho2.Text = Parametros.Desc_Btn02;
                TxtLegBtnAtalho2.Text = Parametros.Texto_Btn02;

                if (Parametros.Cod_Btn03 > 0)
                    TxtCodBtnAtalho3.Text = Parametros.Cod_Btn03.ToString();
                TxtDescBtnAtalho3.Text = Parametros.Desc_Btn03;
                TxtLegBtnAtalho3.Text = Parametros.Texto_Btn03;

                if (Parametros.Cod_Btn04 > 0)
                    TxtCodBtnAtalho4.Text = Parametros.Cod_Btn04.ToString();
                TxtDescBtnAtalho4.Text = Parametros.Desc_Btn04;
                TxtLegBtnAtalho4.Text = Parametros.Texto_Btn04;

                if (Parametros.Cod_Btn05 > 0)
                    TxtCodBtnAtalho5.Text = Parametros.Cod_Btn05.ToString();
                TxtDescBtnAtalho5.Text = Parametros.Desc_Btn05;
                TxtLegBtnAtalho5.Text = Parametros.Texto_Btn05;

                if (Parametros.Cod_Btn06 > 0)
                    TxtCodBtnAtalho6.Text = Parametros.Cod_Btn06.ToString();
                TxtDescBtnAtalho6.Text = Parametros.Desc_Btn06;
                TxtLegBtnAtalho6.Text = Parametros.Texto_Btn06;

                if (Parametros.Cod_Btn07 > 0)
                    TxtCodBtnAtalho7.Text = Parametros.Cod_Btn07.ToString();
                TxtDescBtnAtalho7.Text = Parametros.Desc_Btn07;
                TxtLegBtnAtalho7.Text = Parametros.Texto_Btn07;

                if (Parametros.Cod_Btn08 > 0)
                    TxtCodBtnAtalho8.Text = Parametros.Cod_Btn08.ToString();
                TxtDescBtnAtalho8.Text = Parametros.Desc_Btn08;
                TxtLegBtnAtalho8.Text = Parametros.Texto_Btn08;

                if (Parametros.Cod_Btn09 > 0)
                    TxtCodBtnAtalho9.Text = Parametros.Cod_Btn09.ToString();
                TxtDescBtnAtalho9.Text = Parametros.Desc_Btn09;
                TxtLegBtnAtalho9.Text = Parametros.Texto_Btn09;

                if (Parametros.Cod_Btn10 > 0)
                    TxtCodBtnAtalho10.Text = Parametros.Cod_Btn10.ToString();
                TxtDescBtnAtalho10.Text = Parametros.Desc_Btn10;
                TxtLegBtnAtalho10.Text = Parametros.Texto_Btn10;

                if (Parametros.Cod_Btn11 > 0)
                    TxtCodBtnAtalho11.Text = Parametros.Cod_Btn11.ToString();
                TxtDescBtnAtalho11.Text = Parametros.Desc_Btn11;
                TxtLegBtnAtalho11.Text = Parametros.Texto_Btn11;

                if (Parametros.Cod_Btn12 > 0)
                    TxtCodBtnAtalho12.Text = Parametros.Cod_Btn12.ToString();
                TxtDescBtnAtalho12.Text = Parametros.Desc_Btn12;
                TxtLegBtnAtalho12.Text = Parametros.Texto_Btn12;
                #endregion

                //Categorias
                #region Categorias de busca
                TxtCtg01.Text = Parametros.Cod_Ctg01;
                if (File.Exists(Parametros.Img_Ctg01))
                    TxtImg01.Text = Parametros.Img_Ctg01;

                TxtCtg02.Text = Parametros.Cod_Ctg02;
                if (File.Exists(Parametros.Img_Ctg02))
                    TxtImg02.Text = Parametros.Img_Ctg02;

                TxtCtg03.Text = Parametros.Cod_Ctg03;
                if (File.Exists(Parametros.Img_Ctg03))
                    TxtImg03.Text = Parametros.Img_Ctg03;

                TxtCtg04.Text = Parametros.Cod_Ctg04;
                if (File.Exists(Parametros.Img_Ctg04))
                    TxtImg04.Text = Parametros.Img_Ctg04;

                TxtCtg05.Text = Parametros.Cod_Ctg05;
                if (File.Exists(Parametros.Img_Ctg05))
                    TxtImg05.Text = Parametros.Img_Ctg05;
                #endregion

                //Balança
                TxtCodInicio.Text = Parametros.Cod_Inicio.ToString();
                TxtCodFim.Text = Parametros.Cod_Fim.ToString();
                TxtItemInicio.Text = Parametros.Item_Incio.ToString();
                TxtItemFim.Text = Parametros.Item_Fim.ToString();
                CarregarPortas();
                CbIntegraBalanca.Checked = Parametros.Balanca_Integra;
                CbMandaPreco.Checked = Parametros.Manda_preco_bal;
                if (Parametros.Tipo_Etiqueta == 1)
                    RbBalancaPeso.Select();
                else if (Parametros.Tipo_Etiqueta == 2)
                    RbBalancaValor.Select();
                TxtCaractereComanda.Text = Parametros.CaractereComanda;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void CarregarDadosSistema()
        {
            try
            {
                // Geral
                Parametros.Col_Retira_Comanda = Funcoes.ConvertstrToInt(TxtRetiraColuna.Text);
                Parametros.Qtde_Max_Item = Funcoes.ConvertstrToInt(TxtQtdeMaxItem.Text);
                Parametros.Valor_Max_Item = Funcoes.ConvertstrToDecimal(TxtVlrMaxItem.Text);
                Parametros.Altera_Local = CbAlteraLocal.Checked;
                Parametros.Insere_local = CbAtivaLocal.Checked;
                Parametros.Com_apenas_leitura = CbApenasLeitura.Checked;
                Parametros.Divide_Conta = CbDivideConta.Checked;
                Parametros.Fixa_Op = CbFixaUser.Checked;
                Parametros.Solicita_Imp_Conta = CbImpConta.Checked;
                Parametros.Trata_Comanda = CbTrataCom.Checked;
                Parametros.Terminal = Funcoes.ConvertstrToInt(TxtTerminal.Text);
                Parametros.Solicita_Motivo = CbMotivoCan.Checked;
                Parametros.Velocidade_porta = Funcoes.ConvertstrToInt(TxtVelocidade.Text);
                Parametros.Filial = TxtFilial.Text;
                Parametros.Pct_Calculo = Funcoes.ConvertstrToInt(TxtPct.Text);
                Parametros.Delivery = CbDelivery.Checked;
                Parametros.Codigo_Barras_Duplicado = CbBarraDuplicada.Checked;
                Parametros.Codigo_Barras_Duplicado_Digitos = Funcoes.ConvertstrToInt(TxtBarraDuplicadaDigitos.Text);
                Parametros.Bloqueia_Impressao = chkBloqueiaImpressao.Checked;
                Parametros.usa_goomer = CbGOOMER.Checked;

                //Botões
                #region Btn atalho
                Parametros.Cod_Btn01 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho1.Text);
                Parametros.Desc_Btn01 = TxtDescBtnAtalho1.Text;
                Parametros.Texto_Btn01 = TxtLegBtnAtalho1.Text;

                Parametros.Cod_Btn02 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho2.Text);
                Parametros.Desc_Btn02 = TxtDescBtnAtalho2.Text;
                Parametros.Texto_Btn02 = TxtLegBtnAtalho2.Text;

                Parametros.Cod_Btn03 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho3.Text);
                Parametros.Desc_Btn03 = TxtDescBtnAtalho3.Text;
                Parametros.Texto_Btn03 = TxtLegBtnAtalho3.Text;

                Parametros.Cod_Btn04 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho4.Text);
                Parametros.Desc_Btn04 = TxtDescBtnAtalho4.Text;
                Parametros.Texto_Btn04 = TxtLegBtnAtalho4.Text;

                Parametros.Cod_Btn05 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho5.Text);
                Parametros.Desc_Btn05 = TxtDescBtnAtalho5.Text;
                Parametros.Texto_Btn05 = TxtLegBtnAtalho5.Text;

                Parametros.Cod_Btn06 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho6.Text);
                Parametros.Desc_Btn06 = TxtDescBtnAtalho6.Text;
                Parametros.Texto_Btn06 = TxtLegBtnAtalho6.Text;

                Parametros.Cod_Btn07 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho7.Text);
                Parametros.Desc_Btn07 = TxtDescBtnAtalho7.Text;
                Parametros.Texto_Btn07 = TxtLegBtnAtalho7.Text;

                Parametros.Cod_Btn08 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho8.Text);
                Parametros.Desc_Btn08 = TxtDescBtnAtalho8.Text;
                Parametros.Texto_Btn08 = TxtLegBtnAtalho8.Text;

                Parametros.Cod_Btn09 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho9.Text);
                Parametros.Desc_Btn09 = TxtDescBtnAtalho9.Text;
                Parametros.Texto_Btn09 = TxtLegBtnAtalho9.Text;

                Parametros.Cod_Btn10 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho10.Text);
                Parametros.Desc_Btn10 = TxtDescBtnAtalho10.Text;
                Parametros.Texto_Btn10 = TxtLegBtnAtalho10.Text;

                Parametros.Cod_Btn11 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho11.Text);
                Parametros.Desc_Btn11 = TxtDescBtnAtalho11.Text;
                Parametros.Texto_Btn11 = TxtLegBtnAtalho11.Text;

                Parametros.Cod_Btn12 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho12.Text);
                Parametros.Desc_Btn12 = TxtDescBtnAtalho12.Text;
                Parametros.Texto_Btn12 = TxtLegBtnAtalho12.Text;
                #endregion

                //Categorias
                if (!Directory.Exists(Application.StartupPath.ToString() + @"\\Img"))
                    Directory.CreateDirectory(Application.StartupPath.ToString() + @"\\Img");

                #region Categorias de busca
                Parametros.Cod_Ctg01 = TxtCtg01.Text;
                if (File.Exists(TxtImg01.Text) && Parametros.Img_Ctg01 != TxtImg01.Text)
                {
                    if (File.Exists(Parametros.Img_Ctg01))
                        File.Replace(TxtImg01.Text, Parametros.Img_Ctg01, null);
                    else
                    {
                        Bitmap bmp = new Bitmap(TxtImg01.Text);
                        bmp.Save(Parametros.Img_Ctg01);
                    }
                }

                Parametros.Cod_Ctg02 = TxtCtg02.Text;
                if (File.Exists(TxtImg02.Text) && Parametros.Img_Ctg02 != TxtImg02.Text)
                {
                    if (File.Exists(Parametros.Img_Ctg02))
                        File.Replace(TxtImg02.Text, Parametros.Img_Ctg02, null);
                    else
                    {
                        Bitmap bmp = new Bitmap(TxtImg02.Text);
                        bmp.Save(Parametros.Img_Ctg02);
                    }
                }


                Parametros.Cod_Ctg03 = TxtCtg03.Text;
                if (File.Exists(TxtImg03.Text) && Parametros.Img_Ctg03 != TxtImg03.Text)
                {
                    if (File.Exists(Parametros.Img_Ctg03))
                        File.Replace(TxtImg03.Text, Parametros.Img_Ctg03, null);
                    else
                    {
                        Bitmap bmp = new Bitmap(TxtImg03.Text);
                        bmp.Save(Parametros.Img_Ctg03);
                    }
                }

                Parametros.Cod_Ctg04 = TxtCtg04.Text;
                if (File.Exists(TxtImg04.Text) && Parametros.Img_Ctg04 != TxtImg04.Text)
                {
                    if (File.Exists(Parametros.Img_Ctg04))
                        File.Replace(TxtImg04.Text, Parametros.Img_Ctg04, null);
                    else
                    {
                        Bitmap bmp = new Bitmap(TxtImg04.Text);
                        bmp.Save(Parametros.Img_Ctg04);
                    }
                }

                Parametros.Cod_Ctg05 = TxtCtg05.Text;
                if (File.Exists(TxtImg05.Text) && Parametros.Img_Ctg05 != TxtImg05.Text)
                {
                    if (File.Exists(Parametros.Img_Ctg05))
                        File.Replace(TxtImg05.Text, Parametros.Img_Ctg05, null);
                    else
                    {
                        Bitmap bmp = new Bitmap(TxtImg05.Text);
                        bmp.Save(Parametros.Img_Ctg05);
                    }
                }

                #endregion

                //Balança
                Parametros.Cod_Inicio = Funcoes.ConvertstrToInt(TxtCodInicio.Text);
                Parametros.Cod_Fim = Funcoes.ConvertstrToInt(TxtCodFim.Text);
                Parametros.Item_Incio = Funcoes.ConvertstrToInt(TxtItemInicio.Text);
                Parametros.Item_Fim = Funcoes.ConvertstrToInt(TxtItemFim.Text);
                Parametros.Balanca_Integra = CbIntegraBalanca.Checked;
                Parametros.Porta_balanca = CbxNamePorta.Text;
                Parametros.Manda_preco_bal = CbMandaPreco.Checked;
                if (RbBalancaPeso.Checked)
                    Parametros.Tipo_Etiqueta = 1;
                else if (RbBalancaValor.Checked)
                    Parametros.Tipo_Etiqueta = 2;
                Parametros.CaractereComanda = (TxtCaractereComanda.Text.Trim().Equals("") ? "W" : TxtCaractereComanda.Text);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private ConfiguracaoDAO PreencherConfig()
        {
            try
            {
                ConfiguracaoDAO Obj = new ConfiguracaoDAO
                {
                    ID = Parametros.ID_Config,
                    Integra_Balanca = CbIntegraBalanca.Checked,
                    Fixa_User = CbFixaUser.Checked,
                    Qtde_maxItem = Funcoes.ConvertstrToInt(TxtQtdeMaxItem.Text),
                    Valor_maxItem = Funcoes.ConvertstrToDecimal(TxtVlrMaxItem.Text),
                    Terminal = Funcoes.ConvertstrToInt(TxtTerminal.Text),
                    Solicita_Motivo = CbMotivoCan.Checked,
                    Filial = TxtFilial.Text,
                    Delivery = CbDelivery.Checked,
                    usa_goomer = CbGOOMER.Checked,  
                    Trata_Comanda = CbTrataCom.Checked,
                    Com_RetiraCluna = Funcoes.ConvertstrToInt(TxtRetiraColuna.Text),
                    Divide_conta = CbDivideConta.Checked,
                    Solicita_ImpConta = CbImpConta.Checked,
                    Com_ApenasLeitura = CbApenasLeitura.Checked,
                    Pct_calculo = Funcoes.ConvertstrToInt(TxtPct.Text),
                    Balanca_porta = CbxNamePorta.Text,
                    Balanca_CodInicio = Funcoes.ConvertstrToInt(TxtCodInicio.Text),
                    Balanca_CodFim = Funcoes.ConvertstrToInt(TxtCodFim.Text),
                    Balanca_ItemInicio = Funcoes.ConvertstrToInt(TxtItemInicio.Text),
                    Balanca_ItemFim = Funcoes.ConvertstrToInt(TxtItemFim.Text),
                    Velocidade = Funcoes.ConvertstrToInt(TxtVelocidade.Text),
                    Balanca_Etiqueta = (RbBalancaPeso.Checked ? 1 : 2),
                    Manda_preco = CbMandaPreco.Checked,

                    Cod_BtnAtalho1 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho1.Text),
                    Desc_ProdAtalho1 = TxtDescBtnAtalho1.Text,
                    Leg_BtnAtalho1 = TxtLegBtnAtalho1.Text,

                    Cod_BtnAtalho2 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho2.Text),
                    Desc_ProdAtalho2 = TxtDescBtnAtalho2.Text,
                    Leg_BtnAtalho2 = TxtLegBtnAtalho2.Text,

                    Cod_BtnAtalho3 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho3.Text),
                    Desc_ProdAtalho3 = TxtDescBtnAtalho3.Text,
                    Leg_BtnAtalho3 = TxtLegBtnAtalho3.Text,

                    Cod_BtnAtalho4 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho4.Text),
                    Desc_ProdAtalho4 = TxtDescBtnAtalho4.Text,
                    Leg_BtnAtalho4 = TxtLegBtnAtalho4.Text,

                    Cod_BtnAtalho5 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho5.Text),
                    Desc_ProdAtalho5 = TxtDescBtnAtalho5.Text,
                    Leg_BtnAtalho5 = TxtLegBtnAtalho5.Text,

                    Cod_BtnAtalho6 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho6.Text),
                    Desc_ProdAtalho6 = TxtDescBtnAtalho6.Text,
                    Leg_BtnAtalho6 = TxtLegBtnAtalho6.Text,

                    Cod_BtnAtalho7 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho7.Text),
                    Desc_ProdAtalho7 = TxtDescBtnAtalho7.Text,
                    Leg_BtnAtalho7 = TxtLegBtnAtalho7.Text,

                    Cod_BtnAtalho8 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho8.Text),
                    Desc_ProdAtalho8 = TxtDescBtnAtalho8.Text,
                    Leg_BtnAtalho8 = TxtLegBtnAtalho8.Text,

                    Cod_BtnAtalho9 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho9.Text),
                    Desc_ProdAtalho9 = TxtDescBtnAtalho9.Text,
                    Leg_BtnAtalho9 = TxtLegBtnAtalho9.Text,

                    Cod_BtnAtalho10 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho10.Text),
                    Desc_ProdAtalho10 = TxtDescBtnAtalho10.Text,
                    Leg_BtnAtalho10 = TxtLegBtnAtalho10.Text,

                    Cod_BtnAtalho11 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho11.Text),
                    Desc_ProdAtalho11 = TxtDescBtnAtalho11.Text,
                    Leg_BtnAtalho11 = TxtLegBtnAtalho11.Text,

                    Cod_BtnAtalho12 = Funcoes.ConvertstrToInt(TxtCodBtnAtalho12.Text),
                    Desc_ProdAtalho12 = TxtDescBtnAtalho12.Text,
                    Leg_BtnAtalho12 = TxtLegBtnAtalho12.Text,

                    Cod_BtnCtg1 = TxtCtg01.Text,
                    Cod_BtnCtg2 = TxtCtg02.Text,
                    Cod_BtnCtg3 = TxtCtg03.Text,
                    Cod_BtnCtg4 = TxtCtg04.Text,
                    Cod_BtnCtg5 = TxtCtg05.Text,

                    Altera_local = CbAlteraLocal.Checked,
                    Insere_Local = CbAtivaLocal.Checked,

                    CodigoBarrasDuplicado = CbBarraDuplicada.Checked,
                    CodigoBarrasDuplicadoDigitos = Funcoes.ConvertstrToInt(TxtBarraDuplicadaDigitos.Text),
                    BloqueiaImpressao = chkBloqueiaImpressao.Checked,
                    CaractereComanda = TxtCaractereComanda.Text.ToUpper()
                 


                };

                string strHostName = Dns.GetHostName();
                IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
                IPAddress[] addr = ipEntry.AddressList;
                Obj.IP_Terminal = addr[0].ToString();

                //SOLDIGusto.Properties.Settings.Default.Terminal = Obj.Terminal;
                //Properties.Settings.Default.Save();
                //Properties.Settings.Default.Reload();


                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Add an Application Setting.
                config.AppSettings.Settings.Remove("Terminal");
                config.AppSettings.Settings.Add("Terminal", Obj.Terminal.ToString());

                // Save the configuration file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");

                


                if (RbBalancaPeso.Checked)
                    Obj.Balanca_Etiqueta = 1;
                else if (RbBalancaPeso.Checked)
                    Obj.Balanca_Etiqueta = 2;


                return Obj;
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                throw err;
            }
        }

        private void SalvarConfig()
        {
            try
            {
                ConfiguracaoDAO Obj = PreencherConfig();
                Obj.SalvarConfig(Obj);

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // Add an Application Setting.
                config.AppSettings.Settings.Remove("FILIAL");
                config.AppSettings.Settings.Add("FILIAL", Obj.Filial);
                // Save the configuration file.
                config.Save(ConfigurationSaveMode.Modified);
                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");

                string Msg = "Configurações cadastradas com sucesso!";
                Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                PgMsg.ShowDialog();
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                throw err;
            }
        }

        private void EditarConfig()
        {
            try
            {
                ConfiguracaoDAO Obj = PreencherConfig();
                Obj.EditarConfig(Obj);
                string Msg = "Configurações salvas com sucesso!";
                Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                PgMsg.ShowDialog();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void LimparValidacao()
        {
            try
            {
                LblMsg.Text = "";
                Color cor = LblSoldi.ForeColor;

                LblTerminal.ForeColor = cor;
                LblTrataCom.ForeColor = cor;
                LblPctCalculo.ForeColor = cor;
                LblVelocidade.ForeColor = cor;
                LblPortaBalanca.ForeColor = cor;
                TxtCtg01.ForeColor = cor;
                TxtCtg02.ForeColor = cor;
                TxtCtg03.ForeColor = cor;
                TxtCtg04.ForeColor = cor;
                TxtCtg05.ForeColor = cor;
                TxtCodBtnAtalho1.ForeColor = cor;
                TxtCodBtnAtalho2.ForeColor = cor;
                TxtCodBtnAtalho3.ForeColor = cor;
                TxtCodBtnAtalho4.ForeColor = cor;
                TxtCodBtnAtalho5.ForeColor = cor;
                TxtCodBtnAtalho6.ForeColor = cor;
                TxtCodBtnAtalho7.ForeColor = cor;
                TxtCodBtnAtalho8.ForeColor = cor;
                TxtCodBtnAtalho9.ForeColor = cor;
                TxtCodBtnAtalho10.ForeColor = cor;
                TxtCodBtnAtalho11.ForeColor = cor;
                TxtCodBtnAtalho12.ForeColor = cor;
                LblFilial.ForeColor = cor;
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private bool ValidarTela()
        {
            try
            {
                LimparValidacao();

                #region Btn Atalho
                if (TxtCodBtnAtalho1.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho1.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho1.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho1.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho1.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho1.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho2.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho2.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho2.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho2.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho2.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho2.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho3.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho3.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho3.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho3.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho3.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho3.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho4.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho4.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho4.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho4.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho4.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho4.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho5.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho5.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho5.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho5.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho5.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho5.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho6.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho6.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho6.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho6.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho6.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho6.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho7.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho7.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho7.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho7.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho7.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho7.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho8.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho8.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho8.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho8.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho8.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho8.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho9.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho9.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho9.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho9.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho9.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho9.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho10.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho10.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho10.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho10.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho10.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho10.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho11.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho11.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho11.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho11.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho11.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho11.Text = Obj.DESCRICAO;
                    }
                }

                if (TxtCodBtnAtalho12.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(TxtCodBtnAtalho12.Text);
                    if (Obj.PLU <= 0)
                    {
                        TxtCodBtnAtalho12.ForeColor = Color.Red;
                        LblMsg.Text = "Código do botão não é valido";
                        TcConfig.SelectTab("TpBotoes");
                        return false;
                    }
                    else
                    {
                        if (TxtCodBtnAtalho12.Text != Obj.PLU.ToString())
                            TxtCodBtnAtalho12.Text = Obj.PLU.ToString();
                        TxtDescBtnAtalho12.Text = Obj.DESCRICAO;
                    }
                }

                #endregion

                #region Categoria
                if (TxtCtg01.TextLength > 0)
                {
                    if (TxtCtg01.TextLength == 1)// grupo
                    {
                        GrupoDAO Obj = new GrupoDAO();
                        Obj = Obj.BuscarGrupo(TxtCtg01.Text);
                        if (!(TxtCtg01.Text == Obj.Codigo_Grupo.ToString()))
                        {
                            TxtCtg01.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg01.TextLength == 6)//sub grupo
                    {
                        SubGrupoDao Obj = new SubGrupoDao();
                        Obj = Obj.BuscarSubGrupo(TxtCtg01.Text);

                        if (!(TxtCtg01.Text == Obj.Codigo_SubGrupo))
                        {
                            TxtCtg01.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg01.TextLength == 9)//Depto
                    {
                        DepartamentoDAO Obj = new DepartamentoDAO();
                        Obj = Obj.BuscarDepto(TxtCtg01.Text);

                        if (!(TxtCtg01.Text == Obj.Codigo_departamento))
                        {
                            TxtCtg01.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else
                    {
                        TxtCtg01.ForeColor = Color.Red;
                        LblMsg.Text = "Código da categoria não é valida";
                        TcConfig.SelectTab("TpCategoria");
                        return false;
                    }
                }

                if (TxtCtg02.TextLength > 0)
                {
                    if (TxtCtg02.TextLength == 1)// grupo
                    {
                        GrupoDAO Obj = new GrupoDAO();
                        Obj = Obj.BuscarGrupo(TxtCtg02.Text);
                        if (!(TxtCtg02.Text == Obj.Codigo_Grupo.ToString()))
                        {
                            TxtCtg02.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg02.TextLength == 6)//sub grupo
                    {
                        SubGrupoDao Obj = new SubGrupoDao();
                        Obj = Obj.BuscarSubGrupo(TxtCtg02.Text);

                        if (!(TxtCtg02.Text == Obj.Codigo_SubGrupo))
                        {
                            TxtCtg02.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg02.TextLength == 9)//Depto
                    {
                        DepartamentoDAO Obj = new DepartamentoDAO();
                        Obj = Obj.BuscarDepto(TxtCtg02.Text);

                        if (!(TxtCtg02.Text == Obj.Codigo_departamento))
                        {
                            TxtCtg02.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else
                    {
                        TxtCtg02.ForeColor = Color.Red;
                        LblMsg.Text = "Código da categoria não é valida";
                        TcConfig.SelectTab("TpCategoria");
                        return false;
                    }
                }

                if (TxtCtg03.TextLength > 0)
                {
                    if (TxtCtg03.TextLength == 1)// grupo
                    {
                        GrupoDAO Obj = new GrupoDAO();
                        Obj = Obj.BuscarGrupo(TxtCtg03.Text);
                        if (!(TxtCtg03.Text == Obj.Codigo_Grupo.ToString()))
                        {
                            TxtCtg03.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg03.TextLength == 6)//sub grupo
                    {
                        SubGrupoDao Obj = new SubGrupoDao();
                        Obj = Obj.BuscarSubGrupo(TxtCtg03.Text);

                        if (!(TxtCtg03.Text == Obj.Codigo_SubGrupo))
                        {
                            TxtCtg03.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg03.TextLength == 9)//Depto
                    {
                        DepartamentoDAO Obj = new DepartamentoDAO();
                        Obj = Obj.BuscarDepto(TxtCtg03.Text);

                        if (!(TxtCtg03.Text == Obj.Codigo_departamento))
                        {
                            TxtCtg03.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else
                    {
                        TxtCtg03.ForeColor = Color.Red;
                        LblMsg.Text = "Código da categoria não é valida";
                        TcConfig.SelectTab("TpCategoria");
                        return false;
                    }
                }

                if (TxtCtg04.TextLength > 0)
                {
                    if (TxtCtg04.TextLength == 1)// grupo
                    {
                        GrupoDAO Obj = new GrupoDAO();
                        Obj = Obj.BuscarGrupo(TxtCtg04.Text);
                        if (!(TxtCtg04.Text == Obj.Codigo_Grupo.ToString()))
                        {
                            TxtCtg04.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg04.TextLength == 6)//sub grupo
                    {
                        SubGrupoDao Obj = new SubGrupoDao();
                        Obj = Obj.BuscarSubGrupo(TxtCtg04.Text);

                        if (!(TxtCtg04.Text == Obj.Codigo_SubGrupo))
                        {
                            TxtCtg04.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg04.TextLength == 9)//Depto
                    {
                        DepartamentoDAO Obj = new DepartamentoDAO();
                        Obj = Obj.BuscarDepto(TxtCtg04.Text);

                        if (!(TxtCtg04.Text == Obj.Codigo_departamento))
                        {
                            TxtCtg04.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else
                    {
                        TxtCtg04.ForeColor = Color.Red;
                        LblMsg.Text = "Código da categoria não é valida";
                        TcConfig.SelectTab("TpCategoria");
                        return false;
                    }
                }

                if (TxtCtg05.TextLength > 0)
                {
                    if (TxtCtg05.TextLength == 1)// grupo
                    {
                        GrupoDAO Obj = new GrupoDAO();
                        Obj = Obj.BuscarGrupo(TxtCtg05.Text);
                        if (!(TxtCtg05.Text == Obj.Codigo_Grupo.ToString()))
                        {
                            TxtCtg05.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg05.TextLength == 6)//sub grupo
                    {
                        SubGrupoDao Obj = new SubGrupoDao();
                        Obj = Obj.BuscarSubGrupo(TxtCtg05.Text);

                        if (!(TxtCtg05.Text == Obj.Codigo_SubGrupo))
                        {
                            TxtCtg05.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else if (TxtCtg05.TextLength == 9)//Depto
                    {
                        DepartamentoDAO Obj = new DepartamentoDAO();
                        Obj = Obj.BuscarDepto(TxtCtg05.Text);

                        if (!(TxtCtg05.Text == Obj.Codigo_departamento))
                        {
                            TxtCtg05.ForeColor = Color.Red;
                            LblMsg.Text = "Código da categoria não é valida";
                            TcConfig.SelectTab("TpCategoria");
                            return false;
                        }
                    }
                    else
                    {
                        TxtCtg05.ForeColor = Color.Red;
                        LblMsg.Text = "Código da categoria não é valida";
                        TcConfig.SelectTab("TpCategoria");
                        return false;
                    }
                }


                #endregion

                if (CbTrataCom.Checked && TxtRetiraColuna.Text.Trim().Length == 0)
                {
                    LblTrataCom.ForeColor = Color.Red;
                    LblMsg.Text = "Tratamento da comanda habilitado \nsem o valor da coluna.";
                    TcConfig.SelectTab("TpGeral");
                    return false;
                }
                if (CbIntegraBalanca.Checked && CbxNamePorta.Text.Length == 0)
                {
                    LblPortaBalanca.ForeColor = Color.Red;
                    LblMsg.Text = "Balança habilitada \nsem o nome da porta.";
                    TcConfig.SelectTab("TpBalanca");
                    return false;
                }
                if (CbIntegraBalanca.Checked && TxtVelocidade.TextLength == 0)
                {
                    LblVelocidade.ForeColor = Color.Red;
                    LblMsg.Text = "Balança habilitada \nsem a velocidade da porta.";
                    TcConfig.SelectTab("TpBalanca");
                    return false;
                }
                if (TxtTerminal.Text.Trim().Length == 0 || TxtTerminal.Text == "0")
                {
                    LblTerminal.ForeColor = Color.Red;
                    LblMsg.Text = "O numero do terminal não pode \n ser nulo ou menor que 1.";
                    TcConfig.SelectTab("TpGeral");
                    return false;
                }
                if (TxtFilial.Text.Trim().Length == 0)
                {
                    LblFilial.ForeColor = Color.Red;
                    LblMsg.Text = "A filial não pode ser nula.";
                    TcConfig.SelectTab("TpGeral");
                    return false;
                }
                if (TxtPct.Text.Trim().Length == 0)
                {
                    LblPctCalculo.ForeColor = Color.Red;
                    LblMsg.Text = "A Porcentagem não pode ser nula.";
                    TcConfig.SelectTab("TpGeral");
                    return false;
                }
                if ( CbBarraDuplicada.Checked && Funcoes.ConvertstrToInt(TxtBarraDuplicadaDigitos.Text) <= 0)
                {
                    lblDigitosBarra.ForeColor = Color.Red;
                    LblMsg.Text = "Quantidade de dígitos deve ser maior que 0.";
                    TcConfig.SelectTab("TpGeral");
                    return false;
                }

                ConfiguracaoDAO ObjConfig = new ConfiguracaoDAO().BuscarConfig(Funcoes.ConvertstrToInt(TxtTerminal.Text));
                if(ObjConfig.ID > 0 && ObjConfig.ID != Parametros.ID_Config)
                {
                    string Msg = "O numero do terminal já existe no IP " + ObjConfig.IP_Terminal + ". Deseja substituir?";
                    Mensagem ObjMsg = new Mensagem("Conflito de terminal", Msg, "SIM", "NÃO");
                    if (ObjMsg.ShowDialog() != DialogResult.OK)
                    {
                        LblTerminal.ForeColor = Color.Red;
                        LblMsg.Text = "O numero do terminal já existe\n no IP " + ObjConfig.IP_Terminal;
                        TcConfig.SelectTab("TpGeral");
                        return false;
                    }
                    else
                    {
                        Parametros.ID_Config = ObjConfig.ID;
                        if(Inicio)
                            Inicio_Sub = true;
                        Inicio = false;
                        
                    }
                    
                }

                return true;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        //-------------------------------------------------------------------------------
        // EVENTOS DA TELA
        //-------------------------------------------------------------------------------

        private void Configuracao_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDadosTela();
                UltimoCampo = TxtRetiraColuna;
                if (!Inicio)
                    TxtFilial.Enabled = false;

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inicio)
                    Application.Exit();
                else
                    this.DialogResult = DialogResult.Cancel;

            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnTecladoAlfa_Click(object sender, EventArgs e)
        {
            try
            {
                PnTecladoAlfa.Visible = true;
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                OpenFileDialog DialogCtg = new OpenFileDialog
                {
                    //Proibe multiseleção
                    Multiselect = false,
                    Title = "Selecionar Categoria",
                    //Filtra p/ aparecer somente arquivos 
                    Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                    CheckFileExists = true,
                };

                if (DialogCtg.ShowDialog() == DialogResult.OK)
                {
                    if (btn.Tag.ToString() == "1")
                        TxtImg01.Text = DialogCtg.FileName.ToString();
                    else if (btn.Tag.ToString() == "2")
                        TxtImg02.Text = DialogCtg.FileName.ToString();
                    else if (btn.Tag.ToString() == "3")
                        TxtImg03.Text = DialogCtg.FileName.ToString();
                    else if (btn.Tag.ToString() == "4")
                        TxtImg04.Text = DialogCtg.FileName.ToString();
                    else if (btn.Tag.ToString() == "5")
                        TxtImg05.Text = DialogCtg.FileName.ToString();
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool Valida = ValidarTela();
                if (Valida)
                {
                    if (Inicio)
                    {
                        SalvarConfig();
                        Home Pg = new Home();
                        this.Close();
                        CarregarDadosSistema();
                        Pg.Show();
                    }
                    else
                    {
                        EditarConfig();
                        CarregarDadosSistema();
                        if (Inicio_Sub)
                        {
                            Home Pg = new Home();
                            this.Close();
                            Pg.Show();
                        }
                    }
                    Parametros.Atualiza_Home = true;
                    
                }


            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void CbxNamePorta_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarPortas();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtCodBtnAtalho_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TextBoxBase Txt = (TextBoxBase)sender;
                if (e.KeyCode == Keys.Enter && Txt.TextLength > 0)
                {
                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(Txt.Text);
                    if (Obj.PLU > 0)
                    {
                        if (Obj.PLU.ToString() != Txt.Text)
                            Txt.Text = Obj.PLU.ToString();
                    }
                    else
                    {
                        string Msg = "Código Invalido!";
                        Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                        PgMsg.ShowDialog();
                        Txt.Text = "";
                    }


                    if (Txt.Tag.ToString() == "1")
                        TxtDescBtnAtalho1.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "2")
                        TxtDescBtnAtalho2.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "3")
                        TxtDescBtnAtalho3.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "4")
                        TxtDescBtnAtalho4.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "5")
                        TxtDescBtnAtalho5.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "6")
                        TxtDescBtnAtalho6.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "7")
                        TxtDescBtnAtalho7.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "8")
                        TxtDescBtnAtalho8.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "9")
                        TxtDescBtnAtalho9.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "10")
                        TxtDescBtnAtalho10.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "11")
                        TxtDescBtnAtalho11.Text = Obj.DESCRICAO;
                    else if (Txt.Tag.ToString() == "12")
                        TxtDescBtnAtalho12.Text = Obj.DESCRICAO;
                }
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string caracteresPermitidos = Funcoes.ValidarCaracteres(2);
                if (!(caracteresPermitidos.Contains(e.KeyChar.ToString())))
                {
                    if ((Char.IsControl(e.KeyChar)))
                        e.Handled = false;
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtCtg_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxBase Txt = (TextBoxBase)sender;
            if (e.KeyCode == Keys.Enter && Txt.TextLength > 0)
            {
                if (Txt.TextLength == 1)// grupo
                {
                    GrupoDAO Obj = new GrupoDAO();
                    Obj = Obj.BuscarGrupo(Txt.Text);

                    if (!(Txt.Text == Obj.Codigo_Grupo.ToString()))
                    {
                        string Msg = "Código Invalido!";
                        Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                        PgMsg.ShowDialog();
                        Txt.Text = "";
                    }
                }
                else if (Txt.TextLength == 6)//sub grupo
                {
                    SubGrupoDao Obj = new SubGrupoDao();
                    Obj = Obj.BuscarSubGrupo(Txt.Text);

                    if (!(Txt.Text == Obj.Codigo_SubGrupo))
                    {
                        string Msg = "Código Invalido!";
                        Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                        PgMsg.ShowDialog();
                        Txt.Text = "";
                    }
                }
                else if (Txt.TextLength == 9)//Depto
                {
                    DepartamentoDAO Obj = new DepartamentoDAO();
                    Obj = Obj.BuscarDepto(Txt.Text);

                    if (!(Txt.Text == Obj.Codigo_departamento))
                    {
                        string Msg = "Código Invalido!";
                        Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                        PgMsg.ShowDialog();
                        Txt.Text = "";
                    }
                }
                else
                {
                    string Msg = "Código Invalido!";
                    Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                    PgMsg.ShowDialog();
                    Txt.Text = "";
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                PnTecladoAlfa.Visible = false;
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        #region Campo
        private void Campo_Click(object sender, EventArgs e)
        {
            try
            {
                // pegando os valores do ultimo campo clicado
                TextBoxBase Txt = (TextBoxBase)sender;
                UltimoCampo = Txt;
            }
            catch (Exception err)
            {
                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        private void ValidaCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox Txt = (TextBox)sender;
                // BLOQUEANDO CARACTERES QUE NÃO SEJAM NUMEROS NO CAMPO
                string caracteresPermitidos = Funcoes.ValidarCaracteres(Funcoes.ConvertstrToInt(Txt.Tag.ToString()));
                if (!(caracteresPermitidos.Contains(e.KeyChar.ToString())))
                {
                    if ((Char.IsControl(e.KeyChar)))
                        e.Handled = false;
                    else
                    {
                        e.Handled = true;
                    }
                }

                if (Txt.Tag.ToString() == "3")
                {
                    if (Txt.Text.IndexOf(",") >= 0 && e.KeyChar.ToString() == ",")
                        e.Handled = true;
                }



            }
            catch (Exception err)
            {
                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        #endregion

        #region Teclado
        private void BtnTecla_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Teclado(btn.Text.Trim());
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                Teclado("{BS}");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Teclado("{ENTER}");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnTeclaSetaEsquerda_Click(object sender, EventArgs e)
        {
            try
            {
                Teclado("{LEFT}");
            }
            catch (Exception err)
            {

                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        private void BtnTeclaSetaDireita_Click(object sender, EventArgs e)
        {
            try
            {
                Teclado("{RIGHT}");
            }
            catch (Exception err)
            {

                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        private void BtnTeclaESPACO_Click(object sender, EventArgs e)
        {
            try
            {
                Teclado(" ");
            }
            catch (Exception err)
            {
                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        private void BtnClearTeclado_Click(object sender, EventArgs e)
        {
            try
            {
                UltimoCampo.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre o manual do sistema
                System.Diagnostics.Process.Start(Application.StartupPath.ToString() +
                    @"\\Documentos\Manual Soldi Gusto T8.pdf");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
    }
}
