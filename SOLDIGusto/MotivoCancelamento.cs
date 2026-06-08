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
    public partial class MotivoCancelamento : Form
    {
        public string Motivo { get; set; }

        public MotivoCancelamento()
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
            GwMot.Region = new Region(Funcoes.BorderRadius(GwMot.Width, GwMot.Height, true, true));
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

        private void MotivoCancelamento_Load(object sender, EventArgs e)
        {
            try
            {
                MotivoDAO Obj = new MotivoDAO();
                List<MotivoDAO> Mot = Obj.BuscarMotivos();

                foreach (var item in Mot)
                    GwMot.Rows.Add(item.Motivo);

                if(GwMot.RowCount == 0)
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
                Motivo = GwMot.CurrentRow.Cells[0].Value.ToString();
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
