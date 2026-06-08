namespace SOLDIGusto
{
    partial class Inicializar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicializar));
            this.PnConteudo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblProgresso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbGif = new System.Windows.Forms.PictureBox();
            this.TmInicia = new System.Windows.Forms.Timer(this.components);
            this.PnConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PnConteudo
            // 
            this.PnConteudo.BackColor = System.Drawing.Color.White;
            this.PnConteudo.Controls.Add(this.label2);
            this.PnConteudo.Controls.Add(this.pictureBox1);
            this.PnConteudo.Controls.Add(this.label1);
            this.PnConteudo.Controls.Add(this.LblProgresso);
            this.PnConteudo.Controls.Add(this.PbGif);
            this.PnConteudo.Location = new System.Drawing.Point(12, 12);
            this.PnConteudo.Name = "PnConteudo";
            this.PnConteudo.Size = new System.Drawing.Size(526, 508);
            this.PnConteudo.TabIndex = 0;
            this.PnConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnConteudo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(757, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(114, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inicializando o sistema...";
            // 
            // LblProgresso
            // 
            this.LblProgresso.AutoSize = true;
            this.LblProgresso.Font = new System.Drawing.Font("Arial", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgresso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblProgresso.Location = new System.Drawing.Point(69, 8);
            this.LblProgresso.Name = "LblProgresso";
            this.LblProgresso.Size = new System.Drawing.Size(368, 68);
            this.LblProgresso.TabIndex = 5;
            this.LblProgresso.Text = "Soldi Gusto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SOLDIGusto.Properties.Resources.LogoBratter;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(102, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 115);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PbGif
            // 
            this.PbGif.BackColor = System.Drawing.Color.Transparent;
            this.PbGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbGif.Image = global::SOLDIGusto.Properties.Resources.gif4;
            this.PbGif.InitialImage = null;
            this.PbGif.Location = new System.Drawing.Point(10, 27);
            this.PbGif.Name = "PbGif";
            this.PbGif.Size = new System.Drawing.Size(474, 334);
            this.PbGif.TabIndex = 4;
            this.PbGif.TabStop = false;
            this.PbGif.UseWaitCursor = true;
            // 
            // TmInicia
            // 
            this.TmInicia.Tick += new System.EventHandler(this.TmInicia_Tick);
            // 
            // Inicializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(548, 531);
            this.Controls.Add(this.PnConteudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicializar";
            this.Text = "Inicializar";
            this.Load += new System.EventHandler(this.Inicializar_Load);
            this.PnConteudo.ResumeLayout(false);
            this.PnConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnConteudo;
        private System.Windows.Forms.PictureBox PbGif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblProgresso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TmInicia;
    }
}