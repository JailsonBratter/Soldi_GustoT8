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
    public partial class Mensagem : Form
    {
        /// <summary>
        /// Pagina para mostrar uma mensagem personalizada na tela. (mostra somente Texto)
        /// </summary>
        /// <param name="Mensagem">Mensagem a ser mostrada</param>
        /// <param name="btnConfirma">Texto no botão de confirmação</param>
        /// <param name="btnNaoConfirma">Texto no botão de cancel</param>
        public Mensagem(string Mensagem, string btnConfirma, string btnNaoConfirma)
        {
            InitializeComponent();
            BtnSim.Text = btnConfirma;
            BtnNao.Text = btnNaoConfirma;
            TxtMensagem.Text = Mensagem;
            ParametrosLayout();
        }

        /// <summary>
        /// Pagina para mostrar uma mensagem personalizada na tela. (mostra somente Texto)
        /// </summary>
        /// <param name="Titulo">Titulo da mensagem a ser mostrada</param>
        /// <param name="Mensagem">Mensagem a ser mostrada</param>
        /// <param name="btnConfirma">Texto no botão de confirmação</param>
        /// <param name="btnNaoConfirma">Texto no botão de cancel</param>
        public Mensagem(string Titulo, string Mensagem, string btnConfirma, string btnNaoConfirma)
        {
            InitializeComponent();
            BtnSim.Text = btnConfirma;
            BtnNao.Text = btnNaoConfirma;
            TxtMensagem.Text = Mensagem;
            LblTitulo.Text = Titulo;
            ParametrosLayout();
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
            BtnNao.Region = new Region(Funcoes.BorderRadius(BtnNao.Width, BtnNao.Height, true, true));
            BtnSim.Region = new Region(Funcoes.BorderRadius(BtnSim.Width, BtnSim.Height, true, true));
            this.Region = new Region(Funcoes.BorderRadius(this.Width, this.Height, true, true));

            //verificando se há algum valo p/ botão
            if (BtnNao.Text == "")
            {
                BtnNao.Visible = false;
            }

            Tamanhos();
            BtnSim.Focus();


        }

        /// <summary>
        /// Define o layout da fonte de acordo com a qtde de caracteres
        /// </summary>
        private void Tamanhos()
        {
            try
            {
                if (TxtMensagem.Text.Length > 115)
                {
                    TxtMensagem.Font = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
                else if (TxtMensagem.Text.Length > 100)
                {
                    TxtMensagem.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
                else if (TxtMensagem.Text.Length > 80)
                {
                    TxtMensagem.Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //-------------------------------------------------------------------------------
        // EVENTOS DA TELA
        //-------------------------------------------------------------------------------

        private void BtnSim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
