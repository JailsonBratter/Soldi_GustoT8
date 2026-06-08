using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLDIGusto
{
    public partial class Busca : Form
    {
        public int Item { get; set; }
        public int OrdemBusca = 2;
        public string Categoria { get; set; }

        public Busca()
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
            GwItens.Region = new Region(Funcoes.BorderRadius(GwItens.Width, GwItens.Height, true, true));
            BtnLimpaFil.Region = new Region(Funcoes.BorderRadius(BtnLimpaFil.Width, BtnLimpaFil.Height, true, true));
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
            BtnCatg01.Region = new Region(Funcoes.BorderRadius(BtnCatg01.Width, BtnCatg01.Height, true, true));
            BtnCatg02.Region = new Region(Funcoes.BorderRadius(BtnCatg02.Width, BtnCatg02.Height, true, true));
            BtnCatg03.Region = new Region(Funcoes.BorderRadius(BtnCatg03.Width, BtnCatg03.Height, true, true));
            BtnCatg04.Region = new Region(Funcoes.BorderRadius(BtnCatg04.Width, BtnCatg04.Height, true, true));
            BtnCatg05.Region = new Region(Funcoes.BorderRadius(BtnCatg05.Width, BtnCatg05.Height, true, true));
            BtnOrdemDesc.Region = new Region(Funcoes.BorderRadius(BtnOrdemDesc.Width, BtnOrdemDesc.Height, true, true));
            BtnOrdemPlu.Region = new Region(Funcoes.BorderRadius(BtnOrdemPlu.Width, BtnOrdemPlu.Height, true, true));
            BtnOrdemPreco.Region = new Region(Funcoes.BorderRadius(BtnOrdemPreco.Width, BtnOrdemPreco.Height, true, true));
            BtnFecha.Region = new Region(Funcoes.BorderRadius(BtnFecha.Width, BtnFecha.Height, true, true));
            BtnEnter.Region = new Region(Funcoes.BorderRadius(BtnEnter.Width, BtnEnter.Height, true, true));
            BtnTecladoAlfa.Region = new Region(Funcoes.BorderRadius(BtnTecladoAlfa.Width, BtnTecladoAlfa.Height, true, true));


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
                TxtBusca.Focus();
                SendKeys.Send(tecla);
                
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        /// <summary>
        /// Metodo para realizar a busca dos itens
        /// </summary>
        private void BuscarItens()
        {
            try
            {
                //busca os itens
                MercadoriaDAO Obj = new MercadoriaDAO();
                List<MercadoriaDAO> Merc = Obj.BuscarMercadoriaLike(TxtBusca.Text,OrdemBusca,Categoria);

                //Preenche a Grid
                GwItens.DataSource = null;
                GwItens.DataSource = Merc;
                GwItens.ClearSelection();
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
            }
        }

        private void BtnCategoria()
        {
            try
            {
                #region Ctg 01
                if (Parametros.Cod_Ctg01 != null && Parametros.Cod_Ctg01.Length > 0)
                {
                    if (File.Exists(Parametros.Img_Ctg01))
                        BtnCatg01.BackgroundImage = Image.FromFile(Parametros.Img_Ctg01);
                    else
                    {
                        BtnCatg01.TextAlign = ContentAlignment.MiddleRight;
                        BtnCatg01.BackgroundImage = Properties.Resources.Icon_CtgNEncontrada;
                        if (Parametros.Cod_Ctg01.Length == 1)
                            BtnCatg01.Text = "Grupo: " + Parametros.Cod_Ctg01;
                        else if (Parametros.Cod_Ctg01.Length == 6)
                            BtnCatg01.Text = "Sub grupo:" + Parametros.Cod_Ctg01;
                        else if (Parametros.Cod_Ctg01.Length == 9)
                            BtnCatg01.Text = "Depto:" + Parametros.Cod_Ctg01;
                    }
                        

                    if (Parametros.Cod_Ctg01 != null && Parametros.Cod_Ctg01.Length > 0)
                        BtnCatg01.Tag = Parametros.Cod_Ctg01;
                    else
                        BtnCatg01.Enabled = false;
                }
                else
                {
                    BtnCatg01.Enabled = false;
                    BtnCatg01.Text = "Categoria não cadastrada";
                }
                #endregion

                #region Ctg 02
                if (Parametros.Cod_Ctg02 != null && Parametros.Cod_Ctg02.Length > 0)
                {
                    if (File.Exists(Parametros.Img_Ctg02))
                        BtnCatg02.BackgroundImage = Image.FromFile(Parametros.Img_Ctg02);
                    else
                    {
                        BtnCatg02.TextAlign = ContentAlignment.MiddleRight;
                        BtnCatg02.BackgroundImage = Properties.Resources.Icon_CtgNEncontrada;
                        if (Parametros.Cod_Ctg02.Length == 1)
                            BtnCatg02.Text = "Grupo: " + Parametros.Cod_Ctg02;
                        else if (Parametros.Cod_Ctg02.Length == 6)
                            BtnCatg02.Text = "Sub grupo:" + Parametros.Cod_Ctg02;
                        else if (Parametros.Cod_Ctg02.Length == 9)
                            BtnCatg02.Text = "Depto:" + Parametros.Cod_Ctg02;
                    }


                    if (Parametros.Cod_Ctg02 != null && Parametros.Cod_Ctg02.Length > 0)
                        BtnCatg02.Tag = Parametros.Cod_Ctg02;
                    else
                        BtnCatg02.Enabled = false;
                }
                else
                {
                    BtnCatg02.Enabled = false;
                    BtnCatg02.Text = "Categoria não cadastrada";
                }
                #endregion

                #region Ctg 03
                if (Parametros.Cod_Ctg03 != null && Parametros.Cod_Ctg03.Length > 0)
                {
                    if (File.Exists(Parametros.Img_Ctg03))
                        BtnCatg03.BackgroundImage = Image.FromFile(Parametros.Img_Ctg03);
                    else
                    {
                        BtnCatg03.TextAlign = ContentAlignment.MiddleRight;
                        BtnCatg03.BackgroundImage = Properties.Resources.Icon_CtgNEncontrada;
                        if (Parametros.Cod_Ctg03.Length == 1)
                            BtnCatg03.Text = "Grupo: " + Parametros.Cod_Ctg03;
                        else if (Parametros.Cod_Ctg03.Length == 6)
                            BtnCatg03.Text = "Sub grupo:" + Parametros.Cod_Ctg03;
                        else if (Parametros.Cod_Ctg03.Length == 9)
                            BtnCatg03.Text = "Depto:" + Parametros.Cod_Ctg03;
                    }


                    if (Parametros.Cod_Ctg03 != null && Parametros.Cod_Ctg03.Length > 0)
                        BtnCatg03.Tag = Parametros.Cod_Ctg03;
                    else
                        BtnCatg03.Enabled = false;
                }
                else
                {
                    BtnCatg03.Enabled = false;
                    BtnCatg03.Text = "Categoria não cadastrada";
                }
                #endregion

                #region Ctg 04
                if (Parametros.Cod_Ctg04 != null && Parametros.Cod_Ctg04.Length > 0)
                {
                    if (File.Exists(Parametros.Img_Ctg04))
                        BtnCatg04.BackgroundImage = Image.FromFile(Parametros.Img_Ctg04);
                    else
                    {
                        BtnCatg04.TextAlign = ContentAlignment.MiddleRight;
                        BtnCatg04.BackgroundImage = Properties.Resources.Icon_CtgNEncontrada;
                        if (Parametros.Cod_Ctg04.Length == 1)
                            BtnCatg04.Text = "Grupo: " + Parametros.Cod_Ctg04;
                        else if (Parametros.Cod_Ctg04.Length == 6)
                            BtnCatg04.Text = "Sub grupo:" + Parametros.Cod_Ctg04;
                        else if (Parametros.Cod_Ctg04.Length == 9)
                            BtnCatg04.Text = "Depto:" + Parametros.Cod_Ctg04;
                    }


                    if (Parametros.Cod_Ctg04 != null && Parametros.Cod_Ctg04.Length > 0)
                        BtnCatg04.Tag = Parametros.Cod_Ctg04;
                    else
                        BtnCatg04.Enabled = false;
                }
                else
                {
                    BtnCatg04.Enabled = false;
                    BtnCatg04.Text = "Categoria não cadastrada";
                }
                #endregion

                #region Ctg 05
                if (Parametros.Cod_Ctg05 != null && Parametros.Cod_Ctg05.Length > 0)
                {
                    if (File.Exists(Parametros.Img_Ctg05))
                        BtnCatg05.BackgroundImage = Image.FromFile(Parametros.Img_Ctg05);
                    else
                    {
                        BtnCatg05.TextAlign = ContentAlignment.MiddleRight;
                        BtnCatg05.BackgroundImage = Properties.Resources.Icon_CtgNEncontrada;
                        if (Parametros.Cod_Ctg05.Length == 1)
                            BtnCatg05.Text = "Grupo: " + Parametros.Cod_Ctg05;
                        else if (Parametros.Cod_Ctg05.Length == 6)
                            BtnCatg05.Text = "Sub grupo:" + Parametros.Cod_Ctg05;
                        else if (Parametros.Cod_Ctg05.Length == 9)
                            BtnCatg05.Text = "Depto:" + Parametros.Cod_Ctg05;
                    }


                    if (Parametros.Cod_Ctg05 != null && Parametros.Cod_Ctg05.Length > 0)
                        BtnCatg05.Tag = Parametros.Cod_Ctg05;
                    else
                        BtnCatg05.Enabled = false;
                }
                else
                {
                    BtnCatg05.Enabled = false;
                    BtnCatg05.Text = "Categoria não cadastrada";
                }
                #endregion
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
            }
        }

        private void Busca_Load(object sender, EventArgs e)
        {
            try
            {
                BuscarItens();
                BtnCategoria();
                TxtBusca.Focus();
            }
            catch (Exception err)
            {

                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void PnTeclado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFecha_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                TxtBusca.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PnTecladoAlfa.Visible = false;
        }

        private void TxtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                BuscarItens();
                if (e.KeyCode == Keys.Enter && GwItens.RowCount > 0 && Parametros.Comanda != null && Parametros.Comanda.Length > 0)
                {
                    Item = Funcoes.ConvertstrToInt(GwItens.CurrentRow.Cells[0].Value.ToString());
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnCtg_Click(object sender, EventArgs e)
        {
            try
            {
                Button Btn = (Button)sender;
                Categoria = Btn.Tag.ToString();
                BuscarItens();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnOrdem_Click(object sender, EventArgs e)
        {
            try
            {
                Button Btn = (Button)sender;
                int Tipo = Funcoes.ConvertstrToInt(Btn.Tag.ToString());
                //Define se a ordem será crecente ou decrescente
                if (OrdemBusca == Tipo)
                    Tipo = Tipo * 10;

                    OrdemBusca = Tipo;
                BuscarItens();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void GwItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GwItens.RowCount > 0 && Parametros.Comanda != null && Parametros.Comanda.Length > 0)
                {
                    Item = Funcoes.ConvertstrToInt(GwItens.CurrentRow.Cells[0].Value.ToString());
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnLimpaFil_Click(object sender, EventArgs e)
        {
            try
            {
                OrdemBusca = 2;
                Categoria = "";
                TxtBusca.Text = "";
                BuscarItens();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
    }
}
