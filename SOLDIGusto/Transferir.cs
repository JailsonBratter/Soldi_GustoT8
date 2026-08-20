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
    public partial class Transferir : Form
    {
        private TextBoxBase UltimoCampo { get; set; }

        public Transferir()
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
            BtnEnter.Region = new Region(Funcoes.BorderRadius(BtnEnter.Width, BtnEnter.Height, true, true));
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
                //if (tecla == "{ENTER}" && TxtDestino.Text.Length == 0 && TxtOrigem.Text.Length > 0)
                //    UltimoCampo = TxtDestino;
                //else if (tecla == "{ENTER}" && TxtDestino.Text.Length > 0 && TxtOrigem.Text.Length == 0)
                //    UltimoCampo = TxtOrigem;
                //else if (tecla == "{ENTER}" && TxtDestino.Text.Length > 0 && TxtOrigem.Text.Length > 0)
                //    TransferirComanda();

                UltimoCampo.Focus();
                SendKeys.Send(tecla);
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void TransferirComanda()
        {
            try
            {
                ComandaDAO Obj = new ComandaDAO();
                Obj.TransfereComanda(TxtOrigem.Text, TxtDestino.Text);

                Mensagem PgMsg = new Mensagem("Transferencia Completa com sucesso!", "OK", null);
                PgMsg.ShowDialog();
                if (Parametros.usa_goomer)
                {
                    ComandaItemintegracao comandaintegracao = new ComandaItemintegracao();
                    comandaintegracao.InserirTransferenciaComanda(TxtOrigem.Text, TxtDestino.Text, "terminalt8");

                }
                TxtDestino.Text = "";
                TxtOrigem.Text = "";
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                throw err;
            }
        }

        private void ValidarComandas(bool ValidaDest)
        {
            try
            {
                ComandaControleDAO Obj = new ComandaControleDAO();

                //Se a origem existe
                Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(TxtOrigem.Text));
                if (TxtOrigem.TextLength > 0 && Funcoes.ConvertstrToInt(TxtOrigem.Text) == Obj.comanda)
                {
                    // se a origem tem algum item
                    ComandaItemDAO ObjItens = new ComandaItemDAO();
                    List<ComandaItemDAO> Itens = ObjItens.BuscarItensComanda(Funcoes.ConvertstrToInt(TxtOrigem.Text));
                    if (Itens.Count > 0)
                    {
                        //Para validar somente a origem
                        if (ValidaDest)
                        {
                            // se o destino existe
                            Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(TxtDestino.Text));
                            if (TxtDestino.TextLength > 0 && Funcoes.ConvertstrToInt(TxtDestino.Text) == Obj.comanda)
                            {
                                if(TxtDestino.Text == TxtOrigem.Text)
                                    throw new Exception("A origem e destino não podem ser iguais");
                            }
                            else
                                throw new Exception("Destino invalido!");
                        }
                        
                    }
                    else
                        throw new Exception("Não há itens na origem!");
                }
                else
                    throw new Exception("Origem invalida!");
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void Transferir_Load(object sender, EventArgs e)
        {
            try
            {
                UltimoCampo = TxtOrigem;
                TxtOrigem.Focus();

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

        private void TxtOrigem_KeyUp(object sender, KeyEventArgs e)
        {
            //
            try
            {
                if (e.KeyCode == Keys.Enter && TxtOrigem.TextLength > 0)
                {
                    ComandaControleDAO Obj = new ComandaControleDAO();
                    Obj = Obj.BuscarComanda(Funcoes.ConvertstrToInt(TxtOrigem.Text));
                    //se a comanda existe
                    if (Funcoes.ConvertstrToInt(TxtOrigem.Text) == Obj.comanda)
                    {
                        TxtOrigem.Text = Funcoes.ConvertstrToInt(TxtOrigem.Text).ToString();
                        ValidarComandas(false);
                        UltimoCampo = TxtDestino;
                        UltimoCampo.Focus();
                    }
                    else
                        throw new Exception("Origem invalida!");
                }
                

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void TxtDestino_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && TxtDestino.TextLength > 0)
                {
                    ValidarComandas(true);
                    string Msg = "Deseja transferir os itens da Mesa/Comanda " + TxtOrigem.Text +
                        " para a Mesa/Comanda " + TxtDestino.Text;
                    Mensagem PgMsg = new Mensagem(Msg, "SIM", "NÃO");
                    PgMsg.ShowDialog();
                    if (PgMsg.DialogResult == DialogResult.OK)
                        TransferirComanda();
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
