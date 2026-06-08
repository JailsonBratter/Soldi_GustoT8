using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLDIGusto
{
    public partial class Inicializar : Form
    {
        private int Tempo = 0;

        public Inicializar()
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

        public void PegarConfig()
        {
            try
            {
                string tt = ConfigurationManager.AppSettings.Keys.Get(0);

                foreach (var item in ConfigurationManager.AppSettings.AllKeys)
                {
                    if(item == "Terminal")
                        Parametros.Terminal = Funcoes.ConvertstrToInt(ConfigurationManager.AppSettings[item]);
                    if (item == "FILIAL")
                        Parametros.Filial = ConfigurationManager.AppSettings[item];
                }

                

                ConfiguracaoDAO Obj = new ConfiguracaoDAO();
                Obj = Obj.BuscarConfig();

                if (Obj.ID > 0)
                {
                    Parametros.ID_Config = Obj.ID;
                    Parametros.Qtde_Max_Item = Obj.Qtde_maxItem;
                    Parametros.Valor_Max_Item = Obj.Valor_maxItem;
                    Parametros.Trata_Comanda = Obj.Trata_Comanda;
                    Parametros.Col_Retira_Comanda = Obj.Com_RetiraCluna;
                    Parametros.Divide_Conta = Obj.Divide_conta;
                    Parametros.Solicita_Imp_Conta = Obj.Solicita_ImpConta;
                    Parametros.Com_apenas_leitura = Obj.Com_ApenasLeitura;
                    Parametros.Fixa_Op = Obj.Fixa_User;
                    Parametros.Balanca_Integra = Obj.Integra_Balanca;
                    Parametros.Velocidade_porta = Obj.Velocidade;
                    Parametros.Porta_balanca = Obj.Balanca_porta;
                    Parametros.Cod_Inicio = Obj.Balanca_CodInicio;
                    Parametros.Cod_Fim = Obj.Balanca_CodFim;
                    Parametros.Item_Incio = Obj.Balanca_ItemInicio;
                    Parametros.Item_Fim = Obj.Balanca_ItemFim;
                    Parametros.Tipo_Etiqueta = Obj.Balanca_Etiqueta;
                    Parametros.Manda_preco_bal = Obj.Manda_preco;
                    Parametros.Terminal = Obj.Terminal;
                    Parametros.Solicita_Motivo = Obj.Solicita_Motivo;
                    Parametros.Filial = Obj.Filial;
                    Parametros.Pct_Calculo = Obj.Pct_calculo;

                    Parametros.Cod_Btn01 = Obj.Cod_BtnAtalho1;
                    Parametros.Desc_Btn01 = Obj.Desc_ProdAtalho1;
                    Parametros.Texto_Btn01 = Obj.Leg_BtnAtalho1;

                    Parametros.Cod_Btn02 = Obj.Cod_BtnAtalho2;
                    Parametros.Desc_Btn02 = Obj.Desc_ProdAtalho2;
                    Parametros.Texto_Btn02 = Obj.Leg_BtnAtalho2;

                    Parametros.Cod_Btn03 = Obj.Cod_BtnAtalho3;
                    Parametros.Desc_Btn03 = Obj.Desc_ProdAtalho3;
                    Parametros.Texto_Btn03 = Obj.Leg_BtnAtalho3;

                    Parametros.Cod_Btn04 = Obj.Cod_BtnAtalho4;
                    Parametros.Desc_Btn04 = Obj.Desc_ProdAtalho4;
                    Parametros.Texto_Btn04 = Obj.Leg_BtnAtalho4;

                    Parametros.Cod_Btn05 = Obj.Cod_BtnAtalho5;
                    Parametros.Desc_Btn05 = Obj.Desc_ProdAtalho5;
                    Parametros.Texto_Btn05 = Obj.Leg_BtnAtalho5;

                    Parametros.Cod_Btn06 = Obj.Cod_BtnAtalho6;
                    Parametros.Desc_Btn06 = Obj.Desc_ProdAtalho6;
                    Parametros.Texto_Btn06 = Obj.Leg_BtnAtalho6;

                    Parametros.Cod_Btn07 = Obj.Cod_BtnAtalho7;
                    Parametros.Desc_Btn07 = Obj.Desc_ProdAtalho7;
                    Parametros.Texto_Btn07 = Obj.Leg_BtnAtalho7;

                    Parametros.Cod_Btn08 = Obj.Cod_BtnAtalho8;
                    Parametros.Desc_Btn08 = Obj.Desc_ProdAtalho8;
                    Parametros.Texto_Btn08 = Obj.Leg_BtnAtalho8;

                    Parametros.Cod_Btn09 = Obj.Cod_BtnAtalho9;
                    Parametros.Desc_Btn09 = Obj.Desc_ProdAtalho9;
                    Parametros.Texto_Btn09 = Obj.Leg_BtnAtalho9;

                    Parametros.Cod_Btn10 = Obj.Cod_BtnAtalho10;
                    Parametros.Desc_Btn10 = Obj.Desc_ProdAtalho10;
                    Parametros.Texto_Btn10 = Obj.Leg_BtnAtalho10;

                    Parametros.Cod_Btn11 = Obj.Cod_BtnAtalho11;
                    Parametros.Desc_Btn11 = Obj.Desc_ProdAtalho11;
                    Parametros.Texto_Btn11 = Obj.Leg_BtnAtalho11;

                    Parametros.Cod_Btn12 = Obj.Cod_BtnAtalho12;
                    Parametros.Desc_Btn12 = Obj.Desc_ProdAtalho12;
                    Parametros.Texto_Btn12 = Obj.Leg_BtnAtalho12;


                    Parametros.Cod_Ctg01 = Obj.Cod_BtnCtg1;
                    Parametros.Cod_Ctg02 = Obj.Cod_BtnCtg2;
                    Parametros.Cod_Ctg03 = Obj.Cod_BtnCtg3;
                    Parametros.Cod_Ctg04 = Obj.Cod_BtnCtg4;
                    Parametros.Cod_Ctg05 = Obj.Cod_BtnCtg5;


                    Parametros.Altera_Local = Obj.Altera_local;
                    Parametros.Insere_local = Obj.Insere_Local;

                    Parametros.Codigo_Barras_Duplicado = Obj.CodigoBarrasDuplicado;
                    Parametros.Codigo_Barras_Duplicado_Digitos = Obj.CodigoBarrasDuplicadoDigitos;

                    Parametros.Bloqueia_Impressao = Obj.BloqueiaImpressao;

                    Home PagHome = new Home();
                    this.Hide();
                    PagHome.Show();
                }
                else
                {
                    Configuracao PagConfig = new Configuracao();
                    this.Hide();
                    PagConfig.Inicio = true;
                    PagConfig.ShowDialog();

                }

            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                Application.Exit();
            }
        }

        private void Inicializar_Load(object sender, EventArgs e)
        {
            try
            {
                TmInicia.Enabled = true;
                //string T = "Par. Terminal User:" + Properties.Settings.Default.Terminal;
                //T += "\r\nPar. Terminal:" + ConfigurationManager.AppSettings.GetValues("Terminal")[0];
                // MessageBox.Show(T);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PnConteudo_Paint(object sender, PaintEventArgs e)
        {
            try
            {

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }

        }

        private void TmInicia_Tick(object sender, EventArgs e)
        {
            try
            {
                Tempo++;

                if (Tempo == 20)
                {
                    PegarConfig();
                    TmInicia.Enabled = false;
                }

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                Application.Exit();
            }
        }
    }
}
