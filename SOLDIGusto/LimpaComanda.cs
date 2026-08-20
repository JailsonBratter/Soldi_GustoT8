using SOLDIGusto.DAO;
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
    public partial class LimpaComanda : Form
    {
        public decimal Total { get; set; }
        private string Com { get; set; }

        public LimpaComanda()
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
            BtnCancelarTodos.Region = new Region(Funcoes.BorderRadius(BtnCancelarTodos.Width, BtnCancelarTodos.Height, true, true));
            BtnFechar.Region = new Region(Funcoes.BorderRadius(BtnFechar.Width, BtnFechar.Height, true, true));
            BtnEnter.Region = new Region(Funcoes.BorderRadius(BtnEnter.Width, BtnEnter.Height, true, true));
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
            BtnApagar.Region = new Region(Funcoes.BorderRadius(BtnApagar.Width, BtnApagar.Height, true, true));

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

        private void Teclado(string tecla)
        {
            try
            {
                TxtComanda.Focus();
                SendKeys.Send(tecla);
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
                GwItens.DataSource = Itens.OrderByDescending(listaProd => listaProd.id).ToList();
                GwItens.ClearSelection();
                lblCom.Text = "Mesa/Comanda selecionada: " + TxtComanda.Text.Trim();
                Com = TxtComanda.Text;
                TxtComanda.Text = "";
                Total = 0;
                for (int i = 0; i < GwItens.RowCount; i++)
                {
                    DataGridViewRow row = GwItens.Rows[i];
                    row.Cells["Excluir"].Style.BackColor = Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
                    row.Cells["Excluir"].Style.ForeColor = Color.Black;
                    row.Cells["Excluir"].Style.SelectionBackColor = Color.Tomato;
                    Total += Funcoes.ConvertstrToDecimal(row.Cells[4].Value.ToString());
                }

                txtTotal.Text = Total.ToString("n");
                if (Itens.Count == 0)
                    throw new Exception("Não há itens nesta comanda!");

            }
            catch (Exception err)
            {
                if(err.Message != "Não há itens nesta comanda!")
                Funcoes.GravarLog(err.Message);
                throw err;
            }
        }

        private void CancelaTodos()
        {
            try
            {
                #region Cancelar Comanda
                ComandaControleDAO Obj = new ComandaControleDAO();
                Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(Com));
                //se a comanda existe
                if (Com == Obj.comanda.ToString())
                {
                    ComandaItemDAO ObjItens = new ComandaItemDAO();
                    List<ComandaItemDAO> Itens = ObjItens.BuscarItensComanda(Funcoes.ConvertstrToInt(Com));

                    string Mot = "";
                    if (Parametros.Solicita_Motivo)
                    {
                        MotivoCancelamento PagMot = new MotivoCancelamento();
                        PagMot.ShowDialog();
                        if (PagMot.DialogResult == DialogResult.OK)
                            Mot = PagMot.Motivo;
                    }

                    foreach (var item in Itens)
                    {
                        ComandaItemDAO ObjCom = item;

                        //Cancelando o item na origem
                        item.Motivo_Cancelamento = Mot;
                        item.data_cancelamento = DateTime.Now;
                        item.Usuario_Cancelamento = ((Home)Application.OpenForms["Home"]).LblOperador.Text;
                        item.CancelarItemComanda(item);

                    }

                    //Atualizando os status
                    Obj.status = "00";
                    Obj.comanda = Funcoes.ConvertstrToInt(Com);
                    Obj.AtualizarComandaControle(Obj);

                    if (Parametros.usa_goomer)
                    {
                        ComandaItemintegracao comadaitemintegra = new ComandaItemintegracao();
                        comadaitemintegra.InserirCancelamentoTotalComanda(Obj.comanda.ToString(), "TerminalT8");
                    }
                    GwItens.DataSource = null;
                    lblCom.Text = "";
                    txtTotal.Text = "0,00";
                }
                #endregion
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void TxtComanda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && TxtComanda.Text.Length > 0)
                {
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
                                TxtComanda.Text = "W" + strCodigoBarra01;
                            }
                        }
                    }

                    #region Tratando a comanda
                    // se for tratar o texto na comanda
                    if (Parametros.Trata_Comanda)
                    {
                        if (Parametros.Col_Retira_Comanda == 0 && TxtComanda.Text.Substring(0, 1).ToUpper() == "W")
                            TxtComanda.Text = TxtComanda.Text.Substring(1);
                        else if (Parametros.Col_Retira_Comanda == 1)
                            TxtComanda.Text = TxtComanda.Text.Substring(0, TxtComanda.TextLength - 1);
                        else if (Parametros.Col_Retira_Comanda == 2)
                        {
                            if (TxtComanda.Text.Substring(0, 1).ToUpper() == "W")
                                TxtComanda.Text = TxtComanda.Text.Substring(1);
                            TxtComanda.Text = TxtComanda.Text.Substring(0, TxtComanda.TextLength - 1);
                        }
                    }
                    #endregion

                    ComandaControleDAO Obj = new ComandaControleDAO();
                    Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(TxtComanda.Text));

                    if (Funcoes.ConvertstrToInt(TxtComanda.Text) == Obj.comanda)
                    {
                        TxtComanda.Text = Funcoes.ConvertstrToInt(TxtComanda.Text).ToString();
                        if (Obj.status == "02")
                            BuscarItens();
                        else
                            throw new Exception("Não há itens nesta comanda!");
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

        private void GwItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 && GwItens.RowCount > 0)
                {

                    ComandaItemDAO Obj = (ComandaItemDAO)GwItens.CurrentRow.DataBoundItem;

                    string MSG = "Tem certeza que deseja excluir o item: " + Obj.Descrição;
                    Mensagem PgMsg = new Mensagem(MSG, "SIM", "NÃO");
                    PgMsg.ShowDialog();

                    if (PgMsg.DialogResult == DialogResult.OK)
                    {
                        if (Parametros.Solicita_Motivo)
                        {
                            MotivoCancelamento PagMot = new MotivoCancelamento();
                            PagMot.ShowDialog();
                            if (PagMot.DialogResult == DialogResult.OK)
                                Obj.Motivo_Cancelamento = PagMot.Motivo;
                        }
                        Obj.data_cancelamento = DateTime.Now;
                        Obj.Usuario_Cancelamento = ((Home)Application.OpenForms["Home"]).LblOperador.Text;
                        Obj.CancelarItemComanda(Obj);
                        TxtComanda.Text = Obj.comanda.ToString();
                        if (Parametros.usa_goomer)
                        {
                           ComandaItemintegracao cmdin = new ComandaItemintegracao();
                            cmdin.InserirCancelamentoItem(Obj.comanda, Obj.plu, Obj.id, Obj.qtde, Obj.Idseq, "TerminalT8");
                        }
                        BuscarItens();
                    }
                    
                }
            }
            catch (Exception err)
            {
                if (err.Message != "Não há itens nesta comanda!")
                {
                    Funcoes.GravarLog(err.Message);
                    Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                    PgMsg.ShowDialog();
                }
                else
                    CancelaTodos();


            }
        }

        private void BtnCancelarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Com != null && Com.Length > 0)
                {
                    string Msg = " Tem certeza que deseja cancelar todos os itens da comanda?";
                    Mensagem PgMsg = new Mensagem(Msg, "SIM", "NÃO");
                    PgMsg.ShowDialog();

                    if (PgMsg.DialogResult == DialogResult.OK)
                    {
                        CancelaTodos();
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
    }
}
