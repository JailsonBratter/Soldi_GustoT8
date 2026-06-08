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
    public partial class MsgCarregando : Form
    {
        public bool Inicio { get; set; }

        public MsgCarregando()
        {
            InitializeComponent();
        }

        public void ShowDiag()
        {
            try
            {
                Application.DoEvents();
                ShowDialog();
            }
            catch (Exception err)
            {
                Mensagem PgMsg = new Mensagem(err.Message, "OK", null);
                PgMsg.ShowDialog();
            }
            
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnShown(EventArgs e)
        {
            try
            {
                base.OnShown(e);
                Application.DoEvents();
                BringToFront();
                Inicio = true;

            }
            catch (Exception)
            {
                return;
            }

        }

        private void MsgCarregando_Load(object sender, EventArgs e)
        {
            Inicio = true;
        }
    }
}
