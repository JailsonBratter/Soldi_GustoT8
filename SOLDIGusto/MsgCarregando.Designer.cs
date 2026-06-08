namespace SOLDIGusto
{
    partial class MsgCarregando
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
            this.PnConteudo = new System.Windows.Forms.Panel();
            this.PbGif = new System.Windows.Forms.PictureBox();
            this.LblProgresso = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.PnConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PnConteudo
            // 
            this.PnConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.PnConteudo.Controls.Add(this.PbGif);
            this.PnConteudo.Controls.Add(this.LblProgresso);
            this.PnConteudo.Controls.Add(this.LblMsg);
            this.PnConteudo.Location = new System.Drawing.Point(10, 9);
            this.PnConteudo.Name = "PnConteudo";
            this.PnConteudo.Size = new System.Drawing.Size(436, 353);
            this.PnConteudo.TabIndex = 5;
            // 
            // PbGif
            // 
            this.PbGif.BackColor = System.Drawing.Color.Transparent;
            this.PbGif.BackgroundImage = global::SOLDIGusto.Properties.Resources.carregar4;
            this.PbGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbGif.InitialImage = null;
            this.PbGif.Location = new System.Drawing.Point(73, 22);
            this.PbGif.Name = "PbGif";
            this.PbGif.Size = new System.Drawing.Size(292, 244);
            this.PbGif.TabIndex = 3;
            this.PbGif.TabStop = false;
            // 
            // LblProgresso
            // 
            this.LblProgresso.AutoSize = true;
            this.LblProgresso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgresso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblProgresso.Location = new System.Drawing.Point(129, 269);
            this.LblProgresso.Name = "LblProgresso";
            this.LblProgresso.Size = new System.Drawing.Size(162, 24);
            this.LblProgresso.TabIndex = 1;
            this.LblProgresso.Text = "Processando...";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblMsg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblMsg.Location = new System.Drawing.Point(92, 304);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(255, 16);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "Processo em andamento, aguarde. ";
            // 
            // MsgCarregando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(456, 371);
            this.Controls.Add(this.PnConteudo);
            this.Name = "MsgCarregando";
            this.Text = "MsgCarregando";
            this.Load += new System.EventHandler(this.MsgCarregando_Load);
            this.PnConteudo.ResumeLayout(false);
            this.PnConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnConteudo;
        private System.Windows.Forms.PictureBox PbGif;
        private System.Windows.Forms.Label LblProgresso;
        private System.Windows.Forms.Label LblMsg;
    }
}