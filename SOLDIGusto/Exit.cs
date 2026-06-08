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
    public partial class Exit : Form
    {
        public string Operador { get; set; }
        bool FuncaoValida = false;
        
        public Exit()
        {
            InitializeComponent();
            ParametrosLayout();
        }

        public Exit(string Msg)
        {
            InitializeComponent();
            ParametrosLayout();
            FuncaoValida = true;
            LblTitulo.Text = Msg;
        }

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));
            ////teclado
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
                TxtUser.Focus();
                SendKeys.Send(tecla);

            }
            catch (Exception err)
            {

                throw err;
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

        private void BtnVoltar_Click(object sender, EventArgs e)
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

        private void TxtDivisao_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && TxtUser.TextLength > 0)
                {
                    OperadorDao ObjOp = new OperadorDao();
                    ObjOp = ObjOp.LogarOp(Funcoes.ConvertstrToInt(TxtUser.Text));
                    if (ObjOp.Senha != null && TxtUser.Text == ObjOp.Senha.ToString())
                    {
                        if (ObjOp.ID_NivelAcesso > 1 && ObjOp.inativo != 0)
                        {
                            if(!FuncaoValida)
                                Application.Exit();
                            else
                            {
                                Operador = ObjOp.Nome;
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            if (!FuncaoValida)
                                throw new Exception("Operador sem permissão para fechar o sistema!");
                            else
                                throw new Exception("Operador sem permissão!");
                        }
                            
                    }
                    else
                        throw new Exception("Operador Invalido!");
                }

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
                TxtUser.Text = "";
            }
        }

        private void Exit_Load(object sender, EventArgs e)
        {
            try
            {
                TxtUser.Focus();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
    }
}
