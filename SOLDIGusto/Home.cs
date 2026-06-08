using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLDIGusto
{
    public partial class Home : Form
    {
        #region Propriedades
        public bool BloqUser { get; set; }
        private TextBoxBase UltimoCampo { get; set; }
        public int TipoBtnSair = 1;
        public decimal Total { get; set; }
        public string Senha { get; set; }
        public bool ProdPesavel { get; set; }

        public bool ConfirmaPedido { get; set; }


        SerialPort port = null;

        #endregion

        public Home()
        {
            InitializeComponent();
        }

        #region Objs telas

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            GwItens.Region = new Region(Funcoes.BorderRadius(GwItens.Width, GwItens.Height, true, true));
            //teclado
            BtnTecla0.Region = new Region(Funcoes.BorderRadius(BtnTecla0.Width, BtnTecla0.Height, true, true));
            BtnTecla1.Region = new Region(Funcoes.BorderRadius(BtnTecla1.Width, BtnTecla1.Height, true, true));
            BtnTecla2.Region = new Region(Funcoes.BorderRadius(BtnTecla2.Width, BtnTecla2.Height, true, true));
            BtnTecla3.Region = new Region(Funcoes.BorderRadius(BtnTecla3.Width, BtnTecla3.Height, true, true));
            BtnTecla4.Region = new Region(Funcoes.BorderRadius(BtnTecla4.Width, BtnTecla4.Height, true, true));
            BtnTecla5.Region = new Region(Funcoes.BorderRadius(BtnTecla5.Width, BtnTecla5.Height, true, true));
            BtnTecla6.Region = new Region(Funcoes.BorderRadius(BtnTecla6.Width, BtnTecla6.Height, true, true));
            BtnTecla7.Region = new Region(Funcoes.BorderRadius(BtnTecla7.Width, BtnTecla7.Height, true, true));
            BtnTecla8.Region = new Region(Funcoes.BorderRadius(BtnTecla8.Width, BtnTecla8.Height, true, true));
            BtnTecla9.Region = new Region(Funcoes.BorderRadius(BtnTecla9.Width, BtnTecla9.Height, true, true));
            BtnTeclaVirgula.Region = new Region(Funcoes.BorderRadius(BtnTeclaVirgula.Width, BtnTeclaVirgula.Height, true, true));
            BtnApagar.Region = new Region(Funcoes.BorderRadius(BtnApagar.Width, BtnApagar.Height, true, true));

            //Botões
            BtnConfirma.Region = new Region(Funcoes.BorderRadius(BtnConfirma.Width, BtnConfirma.Height, true, true));
            BtnInsere.Region = new Region(Funcoes.BorderRadius(BtnInsere.Width, BtnInsere.Height, true, true));
            BtnMenu.Region = new Region(Funcoes.BorderRadius(BtnMenu.Width, BtnMenu.Height, true, true));
            BtnEnter.Region = new Region(Funcoes.BorderRadius(BtnEnter.Width, BtnEnter.Height, true, true));
            BtnCadiado.Region = new Region(Funcoes.BorderRadius(BtnCadiado.Width, BtnCadiado.Height, true, true));
            BtnBusca.Region = new Region(Funcoes.BorderRadius(BtnBusca.Width, BtnBusca.Height, true, true));
            BtnSair.Region = new Region(Funcoes.BorderRadius(BtnSair.Width, BtnSair.Height, true, true));

            //Botões Atalho
            BtnAtalho1.Region = new Region(Funcoes.BorderRadius(BtnAtalho1.Width, BtnAtalho1.Height, true, true));
            BtnAtalho2.Region = new Region(Funcoes.BorderRadius(BtnAtalho2.Width, BtnAtalho2.Height, true, true));
            BtnAtalho3.Region = new Region(Funcoes.BorderRadius(BtnAtalho3.Width, BtnAtalho3.Height, true, true));
            BtnAtalho4.Region = new Region(Funcoes.BorderRadius(BtnAtalho4.Width, BtnAtalho4.Height, true, true));
            BtnAtalho5.Region = new Region(Funcoes.BorderRadius(BtnAtalho5.Width, BtnAtalho5.Height, true, true));
            BtnAtalho6.Region = new Region(Funcoes.BorderRadius(BtnAtalho6.Width, BtnAtalho6.Height, true, true));
            BtnAtalho7.Region = new Region(Funcoes.BorderRadius(BtnAtalho7.Width, BtnAtalho7.Height, true, true));
            BtnAtalho8.Region = new Region(Funcoes.BorderRadius(BtnAtalho8.Width, BtnAtalho8.Height, true, true));
            BtnAtalho9.Region = new Region(Funcoes.BorderRadius(BtnAtalho9.Width, BtnAtalho9.Height, true, true));
            BtnAtalho10.Region = new Region(Funcoes.BorderRadius(BtnAtalho10.Width, BtnAtalho10.Height, true, true));
            BtnAtalho11.Region = new Region(Funcoes.BorderRadius(BtnAtalho11.Width, BtnAtalho11.Height, true, true));
            BtnAtalho12.Region = new Region(Funcoes.BorderRadius(BtnAtalho12.Width, BtnAtalho12.Height, true, true));

        }

        /// <summary>
        /// Metodo para as funcionalidades do teclado
        /// </summary>
        /// <param name="tecla">Tecla digitada</param>
        private void Teclado(string tecla)
        {
            try
            {
                if (ConfirmaPedido && tecla == "{ENTER}" && UltimoCampo == TxtCodigo)
                {
                    ConfirmaPedido = false;
                    BtnConfirma.Focus();
                }
                else
                {
                    ConfirmaPedido = false;
                    UltimoCampo.Focus();
                }

                SendKeys.Send(tecla);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Metodo para limpar os valores da tela e do sistema
        /// </summary>
        private void LimparTelaCom()
        {
            try
            {
                //Campos
                TxtMesa.Text = "";
                TxtComanda.Text = "";
                TxtCodigo.Text = "";
                TxtDescricao.Text = "";
                TxtQtde.Text = "1,000";

                TxtComanda.Enabled = true;
                TxtMesa.Enabled = true;
                PnItem.Enabled = false;


                LblMesa.Visible = false;
                TxtMesa.Visible = false;
                GwItens.DataSource = null;
                Total = 0;
                LblSubTotal.Text = Total.ToString("N");

                UltimoCampo = TxtComanda;
                UltimoCampo.Focus();
                TipoBtnSair = 2;
                BtnSair.BackgroundImage = Properties.Resources.Icon_Logout;

                //Parametros
                Parametros.Comanda = "";

                if (!BloqUser)
                    Deslogar();

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Define um layout para a grid
        /// </summary>
        private void DefinindoLayoutGrid()
        {
            try
            {
                // formatando o layout da grid
                for (int i = 0; i < GwItens.RowCount; i++)
                {
                    ComandaItemDAO it = (ComandaItemDAO)GwItens.Rows[i].DataBoundItem;
                    DataGridViewRow row = GwItens.Rows[i];

                    if (it.origem != "TM1")
                    {
                        row.Cells["excluir"].Value = "-";
                        row.Cells["AddObs"].Value = "-";
                    }
                    else if (it.Estoque <= 0)
                        row.DefaultCellStyle.ForeColor = Color.Red;

                    #region Botao
                    if (row.Cells["excluir"].Value == null)
                    {
                        row.Cells["excluir"].Style.BackColor = Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
                        row.Cells["excluir"].Style.ForeColor = Color.Black;
                        row.Cells["excluir"].Style.SelectionBackColor = Color.Tomato;
                    }

                    if (row.Cells["AddObs"].Value == null)
                    {
                        row.Cells["AddObs"].Style.BackColor = Color.MediumAquamarine;
                        row.Cells["AddObs"].Style.ForeColor = Color.Black;
                        row.Cells["AddObs"].Style.SelectionBackColor = Color.LightSeaGreen;
                    }
                    #endregion
                    GwItens.ClearSelection();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Preenche os botões de atalho com os seus respectivos conteudos
        /// </summary>
        private void BotoesAtalho()
        {
            try
            {
                #region Btn 01
                if (Parametros.Cod_Btn01 > 0 || (Parametros.Texto_Btn01 != null && Parametros.Texto_Btn01.Length > 0))
                {
                    if (Parametros.Texto_Btn01 != null)
                        BtnAtalho1.Text = Parametros.Texto_Btn01;


                    if (Parametros.Cod_Btn01 > 0)
                    {
                        BtnAtalho1.Tag = Parametros.Cod_Btn01;
                        BtnAtalho1.Enabled = true;
                    }
                    else
                        BtnAtalho1.Enabled = false;
                }
                else
                {
                    BtnAtalho1.Enabled = false;
                    BtnAtalho1.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 02
                if (Parametros.Cod_Btn02 > 0 || (Parametros.Texto_Btn02 != null && Parametros.Texto_Btn02.Length > 0))
                {
                    if (Parametros.Texto_Btn02 != null)
                        BtnAtalho2.Text = Parametros.Texto_Btn02;


                    if (Parametros.Cod_Btn02 > 0)
                    {
                        BtnAtalho2.Tag = Parametros.Cod_Btn02;
                        BtnAtalho2.Enabled = true;
                    }
                    else
                        BtnAtalho2.Enabled = false;
                }
                else
                {
                    BtnAtalho2.Enabled = false;
                    BtnAtalho2.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 03
                if (Parametros.Cod_Btn03 > 0 || (Parametros.Texto_Btn03 != null && Parametros.Texto_Btn03.Length > 0))
                {
                    if (Parametros.Texto_Btn03 != null)
                        BtnAtalho3.Text = Parametros.Texto_Btn03;


                    if (Parametros.Cod_Btn03 > 0)
                    {
                        BtnAtalho3.Tag = Parametros.Cod_Btn03;
                        BtnAtalho3.Enabled = true;
                    }
                    else
                        BtnAtalho3.Enabled = false;
                }
                else
                {
                    BtnAtalho3.Enabled = false;
                    BtnAtalho3.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 04
                if (Parametros.Cod_Btn04 > 0 || (Parametros.Texto_Btn04 != null && Parametros.Texto_Btn04.Length > 0))
                {
                    if (Parametros.Texto_Btn04 != null)
                        BtnAtalho4.Text = Parametros.Texto_Btn04;


                    if (Parametros.Cod_Btn04 > 0)
                    {
                        BtnAtalho4.Tag = Parametros.Cod_Btn04;
                        BtnAtalho4.Enabled = true;
                    }
                    else
                        BtnAtalho4.Enabled = false;
                }
                else
                {
                    BtnAtalho4.Enabled = false;
                    BtnAtalho4.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 05
                if (Parametros.Cod_Btn05 > 0 || (Parametros.Texto_Btn05 != null && Parametros.Texto_Btn05.Length > 0))
                {
                    if (Parametros.Texto_Btn05 != null)
                        BtnAtalho5.Text = Parametros.Texto_Btn05;


                    if (Parametros.Cod_Btn05 > 0)
                    {
                        BtnAtalho5.Tag = Parametros.Cod_Btn05;
                        BtnAtalho5.Enabled = true;
                    }
                    else
                        BtnAtalho5.Enabled = false;
                }
                else
                {
                    BtnAtalho5.Enabled = false;
                    BtnAtalho5.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 06
                if (Parametros.Cod_Btn06 > 0 || (Parametros.Texto_Btn06 != null && Parametros.Texto_Btn06.Length > 0))
                {
                    if (Parametros.Texto_Btn06 != null)
                        BtnAtalho6.Text = Parametros.Texto_Btn06;


                    if (Parametros.Cod_Btn06 > 0)
                    {
                        BtnAtalho6.Tag = Parametros.Cod_Btn06;
                        BtnAtalho6.Enabled = true;
                    }
                    else
                        BtnAtalho6.Enabled = false;
                }
                else
                {
                    BtnAtalho6.Enabled = false;
                    BtnAtalho6.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 07
                if (Parametros.Cod_Btn07 > 0 || (Parametros.Texto_Btn07 != null && Parametros.Texto_Btn07.Length > 0))
                {
                    if (Parametros.Texto_Btn07 != null)
                        BtnAtalho7.Text = Parametros.Texto_Btn07;


                    if (Parametros.Cod_Btn07 > 0)
                    {
                        BtnAtalho7.Tag = Parametros.Cod_Btn07;
                        BtnAtalho7.Enabled = true;
                    }
                    else
                        BtnAtalho7.Enabled = false;
                }
                else
                {
                    BtnAtalho7.Enabled = false;
                    BtnAtalho7.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 08
                if (Parametros.Cod_Btn08 > 0 || (Parametros.Texto_Btn08 != null && Parametros.Texto_Btn08.Length > 0))
                {
                    if (Parametros.Texto_Btn08 != null)
                        BtnAtalho8.Text = Parametros.Texto_Btn08;


                    if (Parametros.Cod_Btn08 > 0)
                    {
                        BtnAtalho8.Tag = Parametros.Cod_Btn08;
                        BtnAtalho8.Enabled = true;
                    }
                    else
                        BtnAtalho8.Enabled = false;
                }
                else
                {
                    BtnAtalho8.Enabled = false;
                    BtnAtalho8.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 09
                if (Parametros.Cod_Btn09 > 0 || (Parametros.Texto_Btn09 != null && Parametros.Texto_Btn09.Length > 0))
                {
                    if (Parametros.Texto_Btn09 != null)
                        BtnAtalho9.Text = Parametros.Texto_Btn09;


                    if (Parametros.Cod_Btn09 > 0)
                    {
                        BtnAtalho9.Tag = Parametros.Cod_Btn09;
                        BtnAtalho9.Enabled = true;
                    }
                    else
                        BtnAtalho9.Enabled = false;
                }
                else
                {
                    BtnAtalho9.Enabled = false;
                    BtnAtalho9.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 10
                if (Parametros.Cod_Btn10 > 0 || (Parametros.Texto_Btn10 != null && Parametros.Texto_Btn10.Length > 0))
                {
                    if (Parametros.Texto_Btn10 != null)
                        BtnAtalho10.Text = Parametros.Texto_Btn10;


                    if (Parametros.Cod_Btn10 > 0)
                    {
                        BtnAtalho10.Tag = Parametros.Cod_Btn10;
                        BtnAtalho10.Enabled = true;
                    }
                    else
                        BtnAtalho10.Enabled = false;
                }
                else
                {
                    BtnAtalho10.Enabled = false;
                    BtnAtalho10.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 11
                if (Parametros.Cod_Btn11 > 0 || (Parametros.Texto_Btn11 != null && Parametros.Texto_Btn11.Length > 0))
                {
                    if (Parametros.Texto_Btn11 != null)
                        BtnAtalho11.Text = Parametros.Texto_Btn11;


                    if (Parametros.Cod_Btn11 > 0)
                    {
                        BtnAtalho11.Tag = Parametros.Cod_Btn11;
                        BtnAtalho11.Enabled = true;
                    }
                    else
                        BtnAtalho11.Enabled = false;
                }
                else
                {
                    BtnAtalho11.Enabled = false;
                    BtnAtalho11.Text = "Atalho não cadastrado";
                }
                #endregion

                #region Btn 12
                if (Parametros.Cod_Btn12 > 0 || (Parametros.Texto_Btn12 != null && Parametros.Texto_Btn12.Length > 0))
                {
                    if (Parametros.Texto_Btn12 != null)
                        BtnAtalho12.Text = Parametros.Texto_Btn12;


                    if (Parametros.Cod_Btn12 > 0)
                    {
                        BtnAtalho12.Tag = Parametros.Cod_Btn12;
                        BtnAtalho12.Enabled = true;
                    }
                    else
                        BtnAtalho12.Enabled = false;
                }
                else
                {
                    BtnAtalho12.Enabled = false;
                    BtnAtalho12.Text = "Atalho não cadastrado";
                }
                #endregion


            }
            catch (Exception err)
            {

                throw err;
            }
        }

        #endregion

        public void ComLeitura()
        {
            try
            {
                if (Parametros.Com_apenas_leitura && Parametros.Id_Operador > 0)
                    PnTeclado.Enabled = false;
                UltimoCampo = TxtComanda;
                UltimoCampo.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region Operador
        public void Logar()
        {
            try
            {
                OperadorDao ObjOp = new OperadorDao();
                ObjOp = ObjOp.LogarOp(Funcoes.ConvertstrToInt(TxtUser.Text));

                if (ObjOp.Senha != null && TxtUser.Text == ObjOp.Senha.ToString())
                {
                    if (ObjOp.inativo != 1)
                        throw new Exception("Operador Inativo!");
                    //prenche objs
                    TxtComanda.Focus();
                    TxtComanda.Enabled = true;
                    UltimoCampo = TxtComanda;
                    LblOperador.Text = ObjOp.Nome;
                    TxtUser.Enabled = false;
                    Parametros.Id_Operador = ObjOp.ID_Operador;
                    Parametros.Nome_Operador = ObjOp.Nome;
                    Parametros.Nivel_Operador = ObjOp.ID_NivelAcesso;
                    TipoBtnSair = 2;
                    BtnSair.BackgroundImage = Properties.Resources.Icon_Logout;
                    ComLeitura();
                }
                else
                    throw new Exception("Operador Invalido!");
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Metodo para deslogar o operador
        /// </summary>
        private void Deslogar()
        {
            try
            {

                TipoBtnSair = 1;
                BtnSair.BackgroundImage = Properties.Resources.Icon_Exit;
                LblOperador.Text = "";
                TxtUser.Enabled = true;
                TxtUser.Text = "";
                TxtComanda.Text = "";
                Parametros.Id_Operador = 0;
                Parametros.Nome_Operador = "";
                Parametros.Nivel_Operador = 0;


                TxtComanda.Enabled = false;
                UltimoCampo = TxtUser;
                UltimoCampo.Focus();
                PnTeclado.Enabled = true;
            }
            catch (Exception err)
            {

                throw err;
            }
        }
        #endregion

        private bool BuscarItensPendentes()
        {
            try
            {

                ComandaItemDAO Obj = new ComandaItemDAO();
                List<ComandaItemDAO> Itens = Obj.BuscarItensPendentesComanda(Funcoes.ConvertstrToInt(TxtComanda.Text));

                if (Itens.Count > 0)
                {
                    Itens = Itens.OrderByDescending(listaProd => listaProd.id).ToList();

                    if (Itens[0].Terminal != Parametros.Terminal)
                    {
                        string Msg = "Há " + Itens.Count + " lançamento(s) pendente(s) no Terminal: " + Itens[0].Terminal + "\r\nUsuario: " + Itens[0].usuario + ".\r\nDeseja assumir o lançamento dos itens?";
                        Mensagem ObjMsg = new Mensagem("LANÇAMENTOS PENDENTES", Msg, "SIM", "NÃO");

                        bool Resposta = false;
                        string OpAutentica = "";

                        if (ObjMsg.ShowDialog() == DialogResult.OK)
                        {
                            Resposta = true;
                            if (Parametros.Nivel_Operador < 3)
                            {
                                Exit ObjAut = new Exit("Senha Gerente");
                                if (ObjAut.ShowDialog() == DialogResult.OK)
                                    OpAutentica = ObjAut.Operador;
                                else
                                    Resposta = false;
                            }
                        }
                        else
                            Resposta = false;

                        string Log = Msg.Replace("Deseja assumir o lançamento dos itens?", "");
                        Log += "Lançamento assumido:" + Resposta + "\r\n";
                        Log += "Usuario Responsavel:" + Parametros.Nome_Operador;
                        if (OpAutentica.Length > 0)
                            Log += "\r\nResponsavel Autenticacao:" + OpAutentica;
                        Funcoes.GravarLog(Log);

                        return Resposta;
                    }
                    else
                        return true;
                }
                else
                    return true;


            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void BuscarItens()
        {
            try
            {

                ComandaItemDAO Obj = new ComandaItemDAO();
                List<ComandaItemDAO> Itens = Obj.BuscarItensComanda(Funcoes.ConvertstrToInt(TxtComanda.Text));
                GwItens.DataSource = null;
                //GwItens.Rows.Add(GwItens);

                GwItens.DataSource = Itens.OrderByDescending(listaProd => listaProd.id).ToList(); ;
                GwItens.ClearSelection();

                for (int i = 0; i < GwItens.RowCount; i++)
                {
                    DataGridViewRow row = GwItens.Rows[i];
                    //row.Cells["excluir"].Value = "-";

                    //row.Cells["AddObs"].Value = "-";
                    Total += Funcoes.ConvertstrToDecimal(row.Cells[4].Value.ToString());

                }

                DefinindoLayoutGrid();

                LblSubTotal.Text = Total.ToString("N");
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private decimal PegarPeso()
        {
            try
            {

                if (port == null)
                {
                    port = new SerialPort(Parametros.Porta_balanca, Parametros.Velocidade_porta, Parity.None, 8, StopBits.One);
                    port.Open();
                }
                if (!port.IsOpen )
                {
                    port = new SerialPort(Parametros.Porta_balanca, Parametros.Velocidade_porta, Parity.None, 8, StopBits.One);
                    port.Open();
                }

                #region Balanca

                //peso
                byte[] buff = { 5 };
                string RetornoBalanca = "";

                if (port.IsOpen)
                {
                    port.Write(buff, 0, 1);
                    int tempo = 0;
                    while (RetornoBalanca.Length == 0 || tempo < 50000)
                    {
                        tempo++;
                        RetornoBalanca += port.ReadExisting();
                        if (tempo == 50000 && RetornoBalanca.Length == 0)
                            RetornoBalanca = "0";
                    }
                    //port.Close();
                }


                string Peso = RetornoBalanca.Replace("\u0002", "").Replace("\u0003", "");

                #endregion

                return Funcoes.ConvertstrToDecimal(Peso) / 1000;
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem("Erro ao comunicar com a balança", err.Message, "OK", null);
                PgMsg.ShowDialog();
                return 0;
            }
            finally
            {
                //if (port != null && port.IsOpen)
                //    port.Close();
            }

        }

        private void MandarPreco(decimal Preco)
        {

            //SerialPort port = null;

            try
            {
                //port = new SerialPort(Parametros.Porta_balanca, Parametros.Velocidade_porta, Parity.None, 8, StopBits.One);

                if (port == null)
                {
                    port = new SerialPort(Parametros.Porta_balanca, Parametros.Velocidade_porta, Parity.None, 8, StopBits.One);
                    port.Open();
                }
                if (!port.IsOpen)
                {
                    port = new SerialPort(Parametros.Porta_balanca, Parametros.Velocidade_porta, Parity.None, 8, StopBits.One);
                    port.Open();
                }

                #region Balanca

                //string p0 = ConfigurationManager.AppSettings["PortaSerial"];
                byte[] buff2 = { 2 };
                byte[] buff3 = { 3 };
                string p = Preco.ToString().Replace(",", "").Replace(".", "").PadLeft(6, '0');

                if (!port.IsOpen)
                    port.Open();
                if (port.IsOpen)
                {
                    //mandando o preco
                    port.Write(buff2, 0, 1);
                    port.Write(p);
                    port.Write(buff3, 0, 1);

                    //dando o tempo de resposta
                    int tempo = 0;
                    while (tempo < 50000)
                        tempo++;

                    port.Close();
                }

                #endregion

            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                //Mensagem PgMsg = new Mensagem("Erro ao comunicar com a balança", err.Message, "OK", null);
                //PgMsg.ShowDialog();
            }
            finally
            {
                if (port != null && port.IsOpen)
                    port.Close();
            }

        }

        /// <summary>
        /// Metodo para adiconar um item ao pedido atual
        /// </summary>
        /// <param name="Codigo"></param>
        private void AdicionarItem()
        {
            try
            {
                //validando produto
                MercadoriaDAO Obj = new MercadoriaDAO();
                Obj = Obj.BuscarMercadoria(TxtCodigo.Text);
                if (TxtCodigo.Text == Obj.PLU.ToString())
                {

                    List<ComandaItemDAO> Itens = new List<ComandaItemDAO>();
                    ComandaItemDAO ObjCom = new ComandaItemDAO();
                    InserirComanda();

                    //Inserindo no obj
                    #region Preenchendo Obj Item

                    ObjCom.plu = Obj.PLU.ToString();
                    ObjCom.Descrição = Obj.DESCRICAO;
                    #region Unitario
                    if (Obj.Promocao && !Parametros.Delivery)
                    {
                        //validando ointervalo de datas
                        bool Inicio = Funcoes.ValidarData(Obj.DataInicio, DateTime.Now);
                        bool Fim = Funcoes.ValidarData(DateTime.Now, Obj.DataFim);

                        if (Obj.PrecoPromo > 0 && Inicio && Fim)
                            ObjCom.unitario = Obj.PrecoPromo;
                        else
                            ObjCom.unitario = Obj.PRECO;
                    }
                    else
                        ObjCom.unitario = Obj.PRECO;
                    #endregion

                    //definindo a quantado maxima de casas decimais
                    string Qtde = Funcoes.ConvertstrToDecimal(TxtQtde.Text).ToString("0.###");
                    //defindo a qtde minm de casa decimais
                    Qtde = Funcoes.ConvertstrToDecimal(Qtde).ToString("0.000");
                    ObjCom.qtde = Funcoes.ConvertstrToDecimal(Qtde);
                    #region Total
                    string total = (ObjCom.unitario * ObjCom.qtde).ToString("N");
                    ObjCom.total = Funcoes.ConvertstrToDecimal(total);
                    if (Parametros.Valor_Max_Item > 0 && ObjCom.total > Parametros.Valor_Max_Item)
                        throw new Exception("O item Ultrapassou o valor maximo permitido! " +
                                    "\n Valor Maximo: " + Parametros.Valor_Max_Item.ToString("C"));
                    Total += ObjCom.total;
                    LblSubTotal.Text = Total.ToString("n");
                    #endregion
                    ObjCom.usuario = LblOperador.Text;
                    ObjCom.origem = "TM1";
                    ObjCom.filial = "MATRIZ";
                    ObjCom.Loja = 1;
                    ObjCom.cupom = "0";
                    ObjCom.data = DateTime.Now;
                    ObjCom.comanda = Funcoes.ConvertstrToDecimal(Parametros.Comanda);
                    ObjCom.localizacao = Funcoes.ConvertstrToInt(TxtMesa.Text);
                    ObjCom.Estoque = Obj.SaldoAtual;
                    ObjCom.Terminal = Parametros.Terminal;
                    ObjCom.id = ObjCom.PegarIdProd((int)ObjCom.comanda) + 1;
                    // pegando Id sequencia prod
                    ObjCom.id = ObjCom.PegarIdProd(Funcoes.ConvertstrToInt(Parametros.Comanda)) + 1;
                    ObjCom.InserirItemComanda(ObjCom);
                    #endregion

                    Itens.Add(ObjCom);
                    //Pegando itens já existentes na grid
                    foreach (DataGridViewRow item in GwItens.Rows)
                    {
                        Itens.Add((ComandaItemDAO)item.DataBoundItem);
                    }
                    GwItens.DataSource = null;
                    GwItens.DataSource = Itens;
                    DefinindoLayoutGrid();
                    //limpando campos
                    TxtCodigo.Text = "";
                    TxtDescricao.Text = "";
                    TxtQtde.Text = "1,000";
                    UltimoCampo = TxtCodigo;
                    TxtCodigo.Focus();
                    ProdPesavel = false;
                }

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Metodo para cancelar o pedido atual
        /// </summary>
        private void CancelarPedido()
        {
            try
            {
                ComandaControleDAO ObjCom = new ComandaControleDAO
                {
                    comanda = Funcoes.ConvertstrToInt(Parametros.Comanda),
                };
                if (GwItens.RowCount == 0)
                    ObjCom.status = "00";
                else
                    ObjCom.status = "02";
                ObjCom.AtualizarComandaControle(ObjCom);

                ComandaAbertaDAO ObjComAb = new ComandaAbertaDAO
                {
                    Comanda = Funcoes.ConvertstrToInt(Parametros.Comanda),
                };
                ObjComAb.ExcluirComandaAberta(ObjComAb);

                ComandaItemDAO Obj = new ComandaItemDAO();
                Obj.CancelarPedidoComanda(ObjComAb.Comanda);

                ComLeitura();
                LimparTelaCom();


            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InserirComanda()
        {
            try
            {
                bool Atualiza = false;
                ComandaDAO ObjCom = new ComandaDAO();
                ObjCom = ObjCom.BuscarComanda(Funcoes.ConvertstrToInt(Parametros.Comanda));
                if (ObjCom.comanda > 0)
                    Atualiza = true;

                ObjCom.comanda = Funcoes.ConvertstrToInt(Parametros.Comanda);
                ObjCom.cupom = "0";
                ObjCom.filial = "MATRIZ";
                ObjCom.data_alteracao = DateTime.Now;
                ObjCom.usuario = LblOperador.Text;

                if (Atualiza)
                    ObjCom.AtualizarComanda(ObjCom);
                else
                {
                    ObjCom.data_chave = DateTime.Now;
                    ObjCom.InserirComanda(ObjCom);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SalvarComanda()
        {
            try
            {
                ComandaControleDAO ObjComControle = new ComandaControleDAO
                {
                    status = "02",
                    comanda = Funcoes.ConvertstrToInt(Parametros.Comanda)
                };
                ObjComControle.AtualizarComandaControle(ObjComControle);

                ComandaAbertaDAO ObjComAb = new ComandaAbertaDAO
                {
                    Comanda = Funcoes.ConvertstrToInt(Parametros.Comanda),
                };
                ObjComAb.ExcluirComandaAberta(ObjComAb);

                InserirComanda();

                LimparTelaCom();

                ComandaItemDAO ObjComItem = new ComandaItemDAO
                {
                    filial = "MATRIZ",
                    comanda = ObjComControle.comanda,
                    tip_id = 0
                };

                try
                {
                    ObjComItem.Com_Finaliza(ObjComItem);
                    ObjComItem.Com_Finaliza_ok(ObjComItem);
                }
                catch (Exception err)
                {
                    string e = err.Message;
                    //throw ;
                }

                ComLeitura();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        //-------------------------------------------------------------------------------
        // EVENTOS DA TELA
        //-------------------------------------------------------------------------------

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                //Definindo os parametros de inicialização do form
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                ArredondarObjtos();
                LblVersao.Text = "Versão: " + Application.ProductVersion;
                //Carregando e definindo os campos da tela
                if (Parametros.Id_Operador == 0)
                {
                    UltimoCampo = TxtUser;
                    TxtUser.Focus();
                }
                else
                {
                    TxtUser.Text = Senha;
                    Logar();
                }

                BotoesAtalho();

                if (Parametros.Fixa_Op)
                {
                    BloqUser = true;
                    BtnCadiado.BackgroundImage = Properties.Resources.Ico_CadFecha;
                }

                if (Parametros.Delivery)
                    LblDelivery.Visible = true;
                else
                    LblDelivery.Visible = false;

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                if (Parametros.Id_Operador > 0)
                {
                    if (Parametros.Comanda != null && Parametros.Comanda.Length > 0)
                    {
                        string Msg = "Confirma a inclusão do pedido?";
                        Mensagem PagMsg = new Mensagem(Msg, "SIM", "NÃO");
                        PagMsg.ShowDialog();
                        if (PagMsg.DialogResult == DialogResult.OK)
                        {
                            SalvarComanda();
                            LimparTelaCom();
                        }

                    }

                    else
                        throw new Exception("Digite a comanda!");
                }
                else
                    throw new Exception("Digite o operador!");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                UltimoCampo.Focus();
            }
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                //Se estiver algum operado logado
                if (Parametros.Id_Operador > 0)
                {
                    Busca PagBusca = new Busca();
                    PagBusca.ShowDialog();

                    if (PagBusca.DialogResult == DialogResult.OK && Parametros.Comanda.Length > 0)
                    {
                        //Seleciona o item para adição
                        TxtCodigo.Text = PagBusca.Item.ToString();
                        TxtCodigo.Focus();
                        SendKeys.Send("{ENTER}");
                    }
                    UltimoCampo.Focus();
                }
                else
                    throw new Exception("Digite o operador!");

            }
            catch (Exception err)
            {
                if (err.Message != "Digite o operador!")
                    Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                UltimoCampo.Focus();
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //Se estiver algum operado logado
                if (Parametros.Id_Operador > 0)
                {

                    // se não estiver ocorrendo um pedido
                    if (Parametros.Comanda == null || Parametros.Comanda.Length == 0)
                    {
                        Menu PagMenu = new Menu();
                        PagMenu.ShowDialog();
                        UltimoCampo.Focus();
                    }
                    else
                        throw new Exception("Não é possivel fazer isso com um pedido em aberto!");

                }
                else
                    throw new Exception("Digite o operador!");

            }
            catch (Exception err)
            {

                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                UltimoCampo.Focus();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {

                if (TipoBtnSair == 1)
                {
                    Exit PagEx = new Exit();
                    PagEx.ShowDialog();

                }
                else if (TipoBtnSair == 2)
                    Deslogar();
                else if (TipoBtnSair == 3)
                {
                    string Msg = "Tem certeza que deseja cancelar o pedido?";
                    Mensagem PagMsg = new Mensagem(Msg, "SIM", "NÃO");
                    PagMsg.ShowDialog();
                    if (PagMsg.DialogResult == DialogResult.OK)
                        CancelarPedido();
                }

                UltimoCampo.Focus();
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnCadiado_Click(object sender, EventArgs e)
        {
            try
            {
                //Define se o operador estará fixado
                if (BloqUser)
                {
                    BtnCadiado.BackgroundImage = Properties.Resources.Ico_CadAb;
                    BloqUser = false;
                }
                else
                {
                    BtnCadiado.BackgroundImage = Properties.Resources.Ico_CadFecha;
                    BloqUser = true;
                }
                UltimoCampo.Focus();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

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
        #endregion

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
                // BLOQUEANDO CARACTERES NO CAMPO
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

        #region KeyUp
        private void TxtUser_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
                if (e.KeyCode == Keys.Enter && TxtUser.TextLength > 0)
                {
                    Logar();
                }
            }
            catch (Exception err)
            {
                if (err.Message != "Operador Invalido!" && err.Message != "Operador Inativo!")
                    Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtComanda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
               if (e.KeyCode == Keys.Enter && TxtComanda.TextLength > 0)
                {
                    #region Tratando a comanda

                    //Tratamento para leitura de comanda quando o codigo de barras for duplicado
                    if (Parametros.Codigo_Barras_Duplicado)
                    {
                        if (TxtComanda.Text.Trim().Length == Parametros.Codigo_Barras_Duplicado_Digitos && TxtComanda.Text.Trim().Length > 0)
                        {
                            int ComandaColunas = TxtComanda.Text.Trim().Length / 2;
                            string strCodigoBarra01 = TxtComanda.Text.Substring(0, ComandaColunas);
                            string strcodigoBarra02 = TxtComanda.Text.Substring(ComandaColunas, ComandaColunas);
                            if (strCodigoBarra01.Length > 0 && strCodigoBarra01 == strcodigoBarra02)
                            {
                                //TxtComanda.Text = "W" + strCodigoBarra01;
                                TxtComanda.Text = Parametros.CaractereComanda + strCodigoBarra01;
                            }
                        }
                    }

                    // se for tratar o texto na comanda
                    if (Parametros.Trata_Comanda)
                    {
                        if (Parametros.Col_Retira_Comanda == 0 && TxtComanda.Text.Substring(0, 1).ToUpper() == Parametros.CaractereComanda) //Antigo "W"
                            TxtComanda.Text = TxtComanda.Text.Substring(1);
                        else if (Parametros.Col_Retira_Comanda == 1)
                            TxtComanda.Text = TxtComanda.Text.Substring(0, TxtComanda.TextLength - 1);
                        else if (Parametros.Col_Retira_Comanda == 2)
                        {
                            if (TxtComanda.Text.Substring(0, 1).ToUpper() == Parametros.CaractereComanda) //Antigo "W"
                                TxtComanda.Text = TxtComanda.Text.Substring(1);
                            TxtComanda.Text = TxtComanda.Text.Substring(0, TxtComanda.TextLength - 1);
                        }

                        //else if (Parametros.Col_Retira_Comanda > 0 && Parametros.Col_Retira_Comanda < TxtComanda.TextLength)
                        //    TxtComanda.Text = TxtComanda.Text.Substring(0, Parametros.Col_Retira_Comanda) +
                        //        TxtComanda.Text.Substring(Parametros.Col_Retira_Comanda + 1);
                        //else if (Parametros.Col_Retira_Comanda > 0 && Parametros.Col_Retira_Comanda == TxtComanda.TextLength)
                        //    TxtComanda.Text = TxtComanda.Text.Substring(0, Parametros.Col_Retira_Comanda);
                    }
                    #endregion

                    ComandaControleDAO Obj = new ComandaControleDAO();
                    Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(TxtComanda.Text));
                    //se a comanda existe
                    if (Funcoes.ConvertstrToInt(TxtComanda.Text) == Obj.comanda && Obj.comanda > 0)
                    {
                        if (Funcoes.ConvertstrToInt(Obj.status) >= 4)
                            throw new Exception("Comanda Bloqueada!");

                        TxtComanda.Text = Funcoes.ConvertstrToInt(TxtComanda.Text).ToString();

                        GwItens.DataSource = null;
                        bool Continua = BuscarItensPendentes();

                        if (!Continua)
                            return;

                        BuscarItens();

                        Obj.status = "02";
                        Obj.AtualizarComandaControle(Obj);

                        ComandaAbertaDAO ObjComAb = new ComandaAbertaDAO
                        {
                            Comanda = Funcoes.ConvertstrToInt(TxtComanda.Text),
                        };
                        ObjComAb.InserirComandaAberta(ObjComAb);

                        Parametros.Comanda = Obj.comanda.ToString();
                        // se terá local
                        if (Parametros.Insere_local)
                        {
                            #region Local
                            LblMesa.Visible = true;
                            TxtMesa.Visible = true;
                            if (!Parametros.Altera_Local && GwItens.RowCount > 0)
                            {
                                //se o local não puder ser alterado
                                TxtMesa.Enabled = false;
                                PnItem.Enabled = true;
                                TxtCodigo.Focus();
                                UltimoCampo = TxtCodigo;
                            }
                            else
                            {
                                TxtMesa.Focus();
                                UltimoCampo = TxtMesa;
                            }
                            ComandaItemDAO ObjLoc = new ComandaItemDAO();
                            TxtMesa.Text = ObjLoc.BuscarLocalComanda(TxtComanda.Text).ToString();
                            #endregion
                        }
                        else
                        {
                            PnItem.Enabled = true;
                            TxtCodigo.Focus();
                            UltimoCampo = TxtCodigo;
                        }


                        TipoBtnSair = 3;
                        BtnSair.BackgroundImage = Properties.Resources.Icon_Cancel;
                        TxtComanda.Enabled = false;

                        if (Parametros.Com_apenas_leitura)
                            PnTeclado.Enabled = true;


                    }
                    else
                        throw new Exception("Comanda Invalida!");

                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
                if (e.KeyCode == Keys.Enter && TxtCodigo.TextLength > 0)
                {
                    string Cod = "";
                    Decimal PrecoBalanca = 0;
                    bool Etiqueta = false;

                    #region Validando etiqueta
                    if (TxtCodigo.TextLength == 13 && TxtCodigo.Text.Substring(0, 1) == "2")
                    {
                        Etiqueta = true;

                        Cod = TxtCodigo.Text.Substring(Parametros.Cod_Inicio, Parametros.Cod_Fim);
                        if (Parametros.Tipo_Etiqueta == 1)
                        {
                            decimal peso = Funcoes.ConvertstrToDecimal(TxtCodigo.Text.Substring(Parametros.Item_Incio, Parametros.Item_Fim)) / 1000;
                            TxtQtde.Text = peso.ToString();
                        }
                        else if (Parametros.Tipo_Etiqueta == 2)
                            PrecoBalanca = Funcoes.ConvertstrToDecimal(TxtCodigo.Text.Substring(Parametros.Item_Incio, Parametros.Item_Fim)) / 100;

                        TxtCodigo.Text = Cod.ToString();
                    }
                    else
                        Cod = TxtCodigo.Text;
                    #endregion


                    MercadoriaDAO Obj = new MercadoriaDAO();
                    Obj = Obj.BuscarMercadoria(Cod);

                    if (Obj.PLU > 0)
                    {
                        //Avisa se o produto está inativo
                        if (Obj.Inativo == 1)
                        {
                            Mensagem PgMsg = new Mensagem("O produto " + Obj.DESCRICAO + " está INATIVADO.", "OK", null);
                            PgMsg.ShowDialog();
                            TxtCodigo.Text = "";
                            return;

                        }

                        if (TxtCodigo.Text != Obj.PLU.ToString())
                            TxtCodigo.Text = Obj.PLU.ToString();

                        string Descri = TxtDescricao.Text;
                        TxtDescricao.Text = Obj.DESCRICAO;


                        //se for o segundo enter do mesmo produto
                        if (Descri.Length > 0 && Descri == Obj.DESCRICAO && TxtQtde.TextLength > 0)
                        {
                            if (Obj.Peso_Variavel == "PESO" && Parametros.Balanca_Integra && !Etiqueta)
                            {
                                decimal Peso = PegarPeso();
                                if (Peso > 0)
                                    TxtQtde.Text = Peso.ToString();
                            }
                            AdicionarItem();
                        }
                        else
                        {
                            UltimoCampo = TxtQtde;
                            BtnInsere.Enabled = true;
                            TxtQtde.Focus();
                            if (Obj.Peso_Variavel == "PESO")
                            {
                                if (Parametros.Balanca_Integra)
                                {
                                    if (!Etiqueta)
                                    {

                                        decimal Peso = PegarPeso();
                                        if (Peso > 0)
                                            TxtQtde.Text = Peso.ToString();
                                        else
                                            TxtQtde.Text = "";

                                        if (Parametros.Manda_preco_bal)
                                            MandarPreco(Obj.PRECO);
                                    }
                                }

                                ProdPesavel = true;
                            }

                            if (PrecoBalanca > 0)
                                TxtQtde.Text = String.Format("{0:0.####}", PrecoBalanca / Obj.PRECO); ;
                        }

                    }
                    else
                    {
                        BtnInsere.Enabled = false;
                        throw new Exception("Produto Invalido!");
                    }


                }
                else if (e.KeyCode == Keys.Enter)
                {
                    ConfirmaPedido = true;
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtMesa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
                if (e.KeyCode == Keys.Enter)
                {
                    if (TxtMesa.TextLength == 0)
                        TxtMesa.Text = "0";
                    PnItem.Enabled = true;
                    TxtCodigo.Focus();
                    UltimoCampo = TxtCodigo;
                    TxtMesa.Enabled = false;
                    Parametros.Comanda = Funcoes.ConvertstrToInt(TxtComanda.Text).ToString();
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtQtde_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
                if (e.KeyCode == Keys.Enter && TxtCodigo.TextLength > 0)
                {
                    decimal Peso = 0;
                    if (ProdPesavel && Parametros.Balanca_Integra && TxtQtde.TextLength == 0)
                    {
                        Peso = PegarPeso();
                    }

                    if (TxtQtde.TextLength > 0 || Peso > 0)
                    {
                        decimal Qtde = Funcoes.ConvertstrToDecimal(TxtQtde.Text);
                        if (Qtde == (int)Qtde || ProdPesavel)
                        {
                            if (Parametros.Qtde_Max_Item > 0 && Qtde > Parametros.Qtde_Max_Item)
                                throw new Exception("A quantidade ultrapassou o limite permitido!" +
                                    "\n Qtde. Maxima: " + Parametros.Qtde_Max_Item);
                            else
                            {
                                if ((Peso > 0 && TxtQtde.Text == Peso.ToString()) || Peso == 0)
                                    AdicionarItem();
                                else
                                    TxtQtde.Text = Peso.ToString();
                            }

                        }
                        else
                        {
                            string Msg = "O item selecionado só aceita quantidades inteiras";
                            throw new Exception(Msg);
                        }

                    }


                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                TxtQtde.Text = "";
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        #endregion

        #endregion

        private void GwItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GwItens.RowCount > 0)
                {
                    if (e.ColumnIndex == 5)
                    {
                        if (GwItens.CurrentRow.Cells[5].Value == null)
                        {
                            int Item = Funcoes.ConvertstrToInt(GwItens.CurrentRow.Cells[0].Value.ToString());
                            int ID = Funcoes.ConvertstrToInt(GwItens.CurrentRow.Cells["id"].Value.ToString());
                            Decimal Qtde = Funcoes.ConvertstrToDecimal(GwItens.CurrentRow.Cells["Qtde"].Value.ToString());
                            int Loc = Funcoes.ConvertstrToInt(TxtMesa.Text);
                            AdicionarObs PagObs = new AdicionarObs(Item, ID, Qtde, Loc);
                            PagObs.ShowDialog();
                        }
                    }

                    else if (e.ColumnIndex == 6)
                    {
                        if (GwItens.CurrentRow.Cells[6].Value == null)
                        {
                            ComandaItemDAO Obj = (ComandaItemDAO)GwItens.CurrentRow.DataBoundItem;
                            string Msg = "Tem certeza que deseja excluir o item selecionado?";
                            Mensagem PagMsg = new Mensagem(Obj.Descrição, Msg, "SIM", "NÃO");
                            PagMsg.ShowDialog();
                            if (PagMsg.DialogResult == DialogResult.OK)
                            {
                                #region Excluindo Item

                                //atualizando subtotal
                                Total -= Obj.total;
                                LblSubTotal.Text = Total.ToString("N");

                                //recuperando/ atualizando itens da grid
                                List<ComandaItemDAO> it = new List<ComandaItemDAO>();
                                for (int i = 0; i < GwItens.RowCount; i++)
                                    it.Add((ComandaItemDAO)GwItens.Rows[i].DataBoundItem);
                                it.Remove(Obj);
                                //deletando no banco

                                Obj.DeletarItemComandaComOBS(Obj);
                                Obj.DeletarItemComanda(Obj);

                                GwItens.DataSource = null;
                                if (it.Count > 0)
                                    GwItens.DataSource = it;
                                DefinindoLayoutGrid();
                                #endregion
                            }
                        }
                    }
                }


            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnInsere_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.TextLength > 0 && TxtQtde.TextLength > 0)
                {
                    TxtQtde.Focus();
                    SendKeys.Send("{ENTER}");
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnAtalho_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                TxtCodigo.Text = btn.Tag.ToString();
                TxtCodigo.Focus();
                SendKeys.Send("{ENTER}");


            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            try
            {
                if (Parametros.Comanda == null || Parametros.Comanda.Length == 0)
                {
                    //Abre o manual do sistema
                    System.Diagnostics.Process.Start(Application.StartupPath.ToString() +
                        @"\\Documentos\Manual Soldi Gusto T8.pdf");
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void GwItens_Click(object sender, EventArgs e)
        {
            UltimoCampo.Focus();
        }

        private void GwItens_DoubleClick(object sender, EventArgs e)
        {
            UltimoCampo.Focus();
        }
    }
}
