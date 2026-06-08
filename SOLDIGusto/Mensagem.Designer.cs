namespace SOLDIGusto
{
    partial class Mensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensagem));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.TxtMensagem);
            this.panel2.Controls.Add(this.BtnSim);
            this.panel2.Controls.Add(this.BtnNao);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 271);
            this.panel2.TabIndex = 70;
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMensagem.Font = new System.Drawing.Font("Arial", 27F, System.Drawing.FontStyle.Bold);
            this.TxtMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMensagem.Location = new System.Drawing.Point(12, 9);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(697, 156);
            this.TxtMensagem.TabIndex = 67;
            this.TxtMensagem.TabStop = false;
            this.TxtMensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMensagem_KeyPress);
            // 
            // BtnSim
            // 
            this.BtnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            this.BtnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSim.FlatAppearance.BorderSize = 0;
            this.BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSim.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.BtnSim.ForeColor = System.Drawing.Color.White;
            this.BtnSim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSim.Location = new System.Drawing.Point(484, 170);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(218, 92);
            this.BtnSim.TabIndex = 1;
            this.BtnSim.Text = "SIM";
            this.BtnSim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSim.UseVisualStyleBackColor = false;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnNao
            // 
            this.BtnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            this.BtnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNao.FlatAppearance.BorderSize = 0;
            this.BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNao.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.BtnNao.ForeColor = System.Drawing.Color.White;
            this.BtnNao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNao.Location = new System.Drawing.Point(14, 170);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(218, 92);
            this.BtnNao.TabIndex = 2;
            this.BtnNao.Text = "NÃO";
            this.BtnNao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNao.UseVisualStyleBackColor = false;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTitulo.Location = new System.Drawing.Point(12, 3);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(0, 35);
            this.LblTitulo.TabIndex = 71;
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(741, 322);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mensagem";
            this.Text = "Mensagem";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.Label LblTitulo;
    }
}