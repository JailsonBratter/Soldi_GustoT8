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
    public partial class AdicionarObs : Form
    {
        public int Item { get; set; }
        public int ID_Item { get; set; }
        public decimal Qtde { get; set; }
        public int Loc { get; set; }

        public AdicionarObs(int Plu, int ID,decimal Quantidade, int Localizacao)
        {
            InitializeComponent();
            ParametrosLayout();
            Item = Plu;
            ID_Item = ID;
            Qtde = Quantidade;
            Loc = Localizacao;
        }

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));
            BtnFechar.Region = new Region(Funcoes.BorderRadius(BtnFechar.Width, BtnFechar.Height, true, true));
            BtnConfirm.Region = new Region(Funcoes.BorderRadius(BtnConfirm.Width, BtnConfirm.Height, true, true));
            GwObs.Region = new Region(Funcoes.BorderRadius(GwObs.Width, GwObs.Height, true, true));

            BtnGridTop.Region = new Region(Funcoes.BorderRadius(BtnGridTop.Width, BtnGridTop.Height, true, true));
            BtnGridBotton.Region = new Region(Funcoes.BorderRadius(BtnGridBotton.Width, BtnGridBotton.Height, true, true));

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
                TxtObs.Focus();
                SendKeys.Send(tecla);

            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void BuscarObs()
        {
            try
            {
                ObsDAO Obj = new ObsDAO();
                List<ObsDAO> Lista = Obj.BuscarObs(Item);

                GwObs.DataSource = null;
                foreach (var item in Lista)
                {
                    GwObs.Rows.Add(item.obs);
                    DataGridViewRow row = GwObs.Rows[GwObs.RowCount - 1];
                    row.Cells["Preco"].Value = item.Preco;
                    row.Cells["plu_item"].Value = item.plu_item_adc;
                    row.Cells[5].Value = 0;
                    if (item.Preco > 0)
                        row.DefaultCellStyle.ForeColor = Color.Red;
                }


                PreencheObsExistente();
                GwObs.ClearSelection();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void PreencheObsExistente()
        {
            try
            {
                ComandaItemObsDAO Obj = new ComandaItemObsDAO();
                Obj.comanda = Funcoes.ConvertstrToDecimal(Parametros.Comanda);
                Obj.id = ID_Item;
                Obj.plu = Item.ToString();


                List<ComandaItemObsDAO> Lista = Obj.BuscarObsExistente(Obj);
                if (Lista.Count > 0)
                {
                    int Maior = 0;
                    if (GwObs.RowCount > Lista.Count)
                        Maior = GwObs.RowCount;
                    else
                        Maior = Lista.Count;


                    foreach (var It in Lista)
                    {
                        int Index = -1;
                        foreach (DataGridViewRow i in GwObs.Rows)
                        {
                            if (It.obs == i.Cells["obs"].Value.ToString())
                                Index = i.Index;

                            if (i.Cells[5].Value.ToString() == "0")
                            {
                                i.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                                i.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                                i.Cells[3].Value = Properties.Resources.checkTrue2;
                                i.Cells[5].Value = 3;
                            }
                        }

                        if (Index == -1)
                        {
                            GwObs.Rows.Add(It.obs);
                            Index = GwObs.RowCount - 1;

                        }

                        if (It.modificador == "C")
                        {
                            GwObs.Rows[Index].Cells[1].Value = Properties.Resources.checkTrue2;
                            GwObs.Rows[Index].Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[5].Value = 1;
                        }
                        else if (It.modificador == "S")
                        {
                            GwObs.Rows[Index].Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[2].Value = Properties.Resources.checkTrue2;
                            GwObs.Rows[Index].Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[5].Value = 2;
                        }
                        else
                        {
                            GwObs.Rows[Index].Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.Rows[Index].Cells[3].Value = Properties.Resources.checkTrue2;
                            GwObs.Rows[Index].Cells[5].Value = 3;
                        }

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void AdicionarItenObs()
        {
            try
            {
                GwObs.Rows.Add(TxtObs.Text);
                DataGridViewRow row = GwObs.Rows[GwObs.RowCount - 1];
                if (RbCom.Checked)
                {
                    row.Cells[5].Value = 1;
                    row.Cells[1].Value = Properties.Resources.checkTrue2;
                }
                else if (RbSem.Checked)
                {
                    row.Cells[5].Value = 2;
                    row.Cells[2].Value = Properties.Resources.checkTrue2;
                }

                GwObs.FirstDisplayedScrollingRowIndex = GwObs.RowCount - 1;
                GwObs.ClearSelection();

                TxtObs.Text = "";
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                throw err;
            }
        }

        private void AdicionarObs_Load(object sender, EventArgs e)
        {
            try
            {
                MercadoriaDAO Obj = new MercadoriaDAO();
                Obj = Obj.BuscarMercadoria(Item.ToString());
                TxtItem.Text = Obj.DESCRICAO;
                BuscarObs();
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
                TxtObs.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void GwObs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GwObs.RowCount > 0)
                {
                    if (e.ColumnIndex == 1)
                    {
                        if (GwObs.CurrentRow.Cells[5].Value.ToString() != "1")
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.checkTrue2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[5].Value = 1;
                        }
                        else
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[5].Value = 0;
                        }

                    }
                    if (e.ColumnIndex == 2)
                    {
                        if (GwObs.CurrentRow.Cells[5].Value.ToString() != "2")
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.checkTrue2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[5].Value = 2;
                        }
                        else
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[5].Value = 0;
                        }
                    }
                    if (e.ColumnIndex == 3)
                    {
                        if (GwObs.CurrentRow.Cells[5].Value.ToString() != "3")
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.checkTrue2;
                            GwObs.CurrentRow.Cells[5].Value = 3;
                        }
                        else
                        {
                            GwObs.CurrentRow.Cells[1].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[2].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[3].Value = Properties.Resources.Icon_checkNull2;
                            GwObs.CurrentRow.Cells[5].Value = 0;
                        }
                    }

                }
            }
            catch (Exception err)
            {
                throw err;
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

            }
            catch (Exception err)
            {
                Form PagMsg = new Mensagem(err.Message, "OK", null);
                PagMsg.ShowDialog();
            }
        }

        private void TxtObs_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Se for acionado o enter
                if (e.KeyCode == Keys.Enter && TxtObs.TextLength > 0)
                {
                    if (RbCom.Checked || RbSem.Checked)
                        AdicionarItenObs();
                    else
                    {
                        string Msg = "Selecione 'COM' ou 'SEM'";
                        Mensagem PgMsg = new Mensagem(Msg, "OK", null);
                        PgMsg.ShowDialog();
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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ComandaItemObsDAO Obj = new ComandaItemObsDAO();
                Obj.plu = Item.ToString();
                Obj.comanda = Funcoes.ConvertstrToDecimal(Parametros.Comanda);
                Obj.id = ID_Item;
                Obj.filial = "MATRIZ";
                Obj.Loja = 1;
                Obj.ExcluirObs(Obj);

                foreach (DataGridViewRow item in GwObs.Rows)
                {
                    if (item.Cells[5].Value.ToString() != "0" && item.Cells[5].Value.ToString() != "3")
                    {
                        Obj.obs = item.Cells["obs"].Value.ToString();
                        if (item.Cells[5].Value.ToString() == "1")
                            Obj.modificador = "C";
                        else if(item.Cells[5].Value.ToString() == "2")
                            Obj.modificador = "S";
                        ComandaItemDAO obj2 = new ComandaItemDAO();
                        obj2.usuario = Parametros.Nome_Operador;
                        obj2.localizacao = Loc;
                        obj2.qtde = Qtde;
                        Obj.InsereObs(Obj,obj2);
                    }
                }

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnGridTop_Click(object sender, EventArgs e)
        {
            try
            {
                if (GwObs.RowCount > 0)
                {
                    GwObs.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnGridBotton_Click(object sender, EventArgs e)
        {
            try
            {
                if (GwObs.RowCount > 0)
                {
                    GwObs.FirstDisplayedScrollingRowIndex = GwObs.RowCount - 1;
                }
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
    }
}
