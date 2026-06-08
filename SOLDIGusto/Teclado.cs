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
    public partial class Teclado : Form
    {
        public string Tecla { get; set; }
        private TextBoxBase CampoSelecionado { get; set; }
        private Form FormSelecionado { get; set; }


        public Teclado(TextBoxBase Campo,Form Formulario)
        {
            InitializeComponent();
            ParametrosLayout();
            CampoSelecionado = Campo;
            FormSelecionado = Formulario;
        }

        /// <summary>
        /// Arredonda os objetos da tela
        /// </summary>
        private void ArredondarObjtos()
        {
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));
            //-------------------------------------------TECLADO---------------------------------------------------
            //numeros
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
            BtnTeclaVirgula.Region = new Region(Funcoes.BorderRadius(BtnTeclaVirgula.Width, BtnTeclaVirgula.Height, true, true));
            BtnClearTeclado.Region = new Region(Funcoes.BorderRadius(BtnClearTeclado.Width, BtnClearTeclado.Height, true, true));
            BtnTraco.Region = new Region(Funcoes.BorderRadius(BtnTraco.Width, BtnTraco.Height, true, true));
            BtnApagar.Region = new Region(Funcoes.BorderRadius(BtnApagar.Width, BtnApagar.Height, true, true));

        }

        /// <summary>
        /// Metodo para definir os parametro de inicialização do form
        /// </summary>
        private void ParametrosLayout()
        {
            // definindo a posição e o layout 
            this.StartPosition = FormStartPosition.Manual;
            int height = SystemInformation.VirtualScreen.Height;
            int Right = SystemInformation.VirtualScreen.Right;
            this.DesktopLocation = new Point((Right- this.Right)/3, height - this.Height + 30);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //arredondando os botes
            ArredondarObjtos();
        }

        private void EventoTeclado(string tecla)
        {
            try
            {


                SendKeys.Send(tecla);

            }
            catch (Exception err)
            {

                throw err;
            }
        }

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

        #region Teclado
        private void BtnTecla_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                EventoTeclado(btn.Text.Trim());
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
                EventoTeclado("{BS}");
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
                EventoTeclado("{ENTER}");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnTeclaESPACO_Click(object sender, EventArgs e)
        {
            try
            {
                EventoTeclado(" ");
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
                EventoTeclado("{LEFT}");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnTeclaSetaDireita_Click(object sender, EventArgs e)
        {
            try
            {
                EventoTeclado("{RIGHT}");
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }
        #endregion

        private void Teclado_Load(object sender, EventArgs e)
        {

        }
    }
}
