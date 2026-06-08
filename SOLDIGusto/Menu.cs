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
    public partial class Menu : Form
    {
        public Menu()
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
            BtnConfig.Region = new Region(Funcoes.BorderRadius(BtnConfig.Width, BtnConfig.Height, true, true));
            BtnEmUso.Region = new Region(Funcoes.BorderRadius(BtnEmUso.Width, BtnEmUso.Height, true, true));
            BtnFechar.Region = new Region(Funcoes.BorderRadius(BtnFechar.Width, BtnFechar.Height, true, true));
            BtnLimpaComanda.Region = new Region(Funcoes.BorderRadius(BtnLimpaComanda.Width, BtnLimpaComanda.Height, true, true));
            BtnTransferir.Region = new Region(Funcoes.BorderRadius(BtnTransferir.Width, BtnTransferir.Height, true, true));
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Parametros.Atualiza_Home)
                {
                    Home Pg = new Home();
                    string s = ((Home)Application.OpenForms["Home"]).TxtUser.Text;
                    ((Home)Application.OpenForms["Home"]).Close();
                    Pg.Senha = s;
                    Pg.Show();
                    Parametros.Atualiza_Home = false;
                }

                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception err)
            {
                Funcoes.GravarLog(err.Message);
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }

        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                Transferir PagTrans = new Transferir();
                PagTrans.ShowDialog();

            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnLimpaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaComanda PagLipCom = new LimpaComanda();
                PagLipCom.ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnEmUso_Click(object sender, EventArgs e)
        {
            try
            {
                EmUso PagUso = new EmUso();
                PagUso.ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Configuracao PagConfig = new Configuracao();
                PagConfig.ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                //se o operador tiver permissão
                if (Parametros.Nivel_Operador <= 1)
                {
                    BtnConfig.Enabled = false;
                    BtnTransferir.Enabled = false;
                    BtnLimpaComanda.Enabled = false;

                    Color Cor = Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
                    BtnConfig.BackColor = Cor;
                    BtnLimpaComanda.BackColor = Cor;
                    BtnTransferir.BackColor = Cor;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
