using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SOLDIGusto
{
    public partial class SelecionaImpressora : Form
    {
        public string Impressora { get; set; }


        public SelecionaImpressora()
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
            GwImp.Region = new Region(Funcoes.BorderRadius(GwImp.Width, GwImp.Height, true, true));
            BtnConfirm.Region = new Region(Funcoes.BorderRadius(BtnConfirm.Width, BtnConfirm.Height, true, true));

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

        private void SelecionaImpressora_Load(object sender, EventArgs e)
        {
            try
            {
                GwImp.DataSource = null;
                SpoolImpressoraDAO Obj = new SpoolImpressoraDAO();
                List<SpoolImpressoraDAO> Lista = Obj.BuscarImpressoras();
                GwImp.DataSource = Lista;

                if (GwImp.RowCount == 0)
                    this.DialogResult = DialogResult.Cancel;
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
                SpoolImpressoraDAO Obj = (SpoolImpressoraDAO)GwImp.CurrentRow.DataBoundItem;
                Impressora = GwImp.CurrentRow.Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
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
