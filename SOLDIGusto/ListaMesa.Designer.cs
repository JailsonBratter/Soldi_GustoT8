namespace SOLDIGusto
{
    partial class ListaMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMesa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblOperador = new System.Windows.Forms.Label();
            this.TxtDivisao = new System.Windows.Forms.TextBox();
            this.PnTeclado = new System.Windows.Forms.Panel();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnTecla5 = new System.Windows.Forms.Button();
            this.BtnTecla1 = new System.Windows.Forms.Button();
            this.BtnTecla2 = new System.Windows.Forms.Button();
            this.BtnTecla3 = new System.Windows.Forms.Button();
            this.BtnTecla4 = new System.Windows.Forms.Button();
            this.BtnTecla0 = new System.Windows.Forms.Button();
            this.BtnTecla6 = new System.Windows.Forms.Button();
            this.BtnTecla7 = new System.Windows.Forms.Button();
            this.BtnTecla9 = new System.Windows.Forms.Button();
            this.BtnTecla8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnTeclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.LblOperador);
            this.panel1.Controls.Add(this.TxtDivisao);
            this.panel1.Controls.Add(this.PnTeclado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 657);
            this.panel1.TabIndex = 0;
            // 
            // LblOperador
            // 
            this.LblOperador.AutoSize = true;
            this.LblOperador.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.LblOperador.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblOperador.Location = new System.Drawing.Point(10, 22);
            this.LblOperador.Name = "LblOperador";
            this.LblOperador.Size = new System.Drawing.Size(341, 58);
            this.LblOperador.TabIndex = 143;
            this.LblOperador.Text = "Digite o numero de pessoas \r\n    para divisão da conta";
            // 
            // TxtDivisao
            // 
            this.TxtDivisao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDivisao.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.TxtDivisao.ForeColor = System.Drawing.Color.Black;
            this.TxtDivisao.Location = new System.Drawing.Point(35, 92);
            this.TxtDivisao.MaxLength = 7;
            this.TxtDivisao.Name = "TxtDivisao";
            this.TxtDivisao.Size = new System.Drawing.Size(287, 41);
            this.TxtDivisao.TabIndex = 142;
            this.TxtDivisao.Tag = "2";
            this.TxtDivisao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCampo_KeyPress);
            this.TxtDivisao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDivisao_KeyUp);
            // 
            // PnTeclado
            // 
            this.PnTeclado.Controls.Add(this.BtnEnter);
            this.PnTeclado.Controls.Add(this.BtnApagar);
            this.PnTeclado.Controls.Add(this.BtnTecla5);
            this.PnTeclado.Controls.Add(this.BtnTecla1);
            this.PnTeclado.Controls.Add(this.BtnTecla2);
            this.PnTeclado.Controls.Add(this.BtnTecla3);
            this.PnTeclado.Controls.Add(this.BtnTecla4);
            this.PnTeclado.Controls.Add(this.BtnTecla0);
            this.PnTeclado.Controls.Add(this.BtnTecla6);
            this.PnTeclado.Controls.Add(this.BtnTecla7);
            this.PnTeclado.Controls.Add(this.BtnTecla9);
            this.PnTeclado.Controls.Add(this.BtnTecla8);
            this.PnTeclado.Controls.Add(this.button6);
            this.PnTeclado.Location = new System.Drawing.Point(24, 139);
            this.PnTeclado.Name = "PnTeclado";
            this.PnTeclado.Size = new System.Drawing.Size(309, 499);
            this.PnTeclado.TabIndex = 141;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            this.BtnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.FlatAppearance.BorderSize = 0;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnter.Location = new System.Drawing.Point(9, 395);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(287, 92);
            this.BtnEnter.TabIndex = 102;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.Transparent;
            this.BtnApagar.BackgroundImage = global::SOLDIGusto.Properties.Resources.Ico_apagar;
            this.BtnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnApagar.FlatAppearance.BorderSize = 0;
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApagar.Location = new System.Drawing.Point(203, 296);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(93, 93);
            this.BtnApagar.TabIndex = 113;
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnTecla5
            // 
            this.BtnTecla5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla5.FlatAppearance.BorderSize = 0;
            this.BtnTecla5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla5.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla5.ForeColor = System.Drawing.Color.White;
            this.BtnTecla5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla5.Location = new System.Drawing.Point(106, 102);
            this.BtnTecla5.Name = "BtnTecla5";
            this.BtnTecla5.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla5.TabIndex = 103;
            this.BtnTecla5.Text = "5";
            this.BtnTecla5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla5.UseVisualStyleBackColor = false;
            this.BtnTecla5.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla1
            // 
            this.BtnTecla1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla1.FlatAppearance.BorderSize = 0;
            this.BtnTecla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla1.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla1.ForeColor = System.Drawing.Color.White;
            this.BtnTecla1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla1.Location = new System.Drawing.Point(9, 198);
            this.BtnTecla1.Name = "BtnTecla1";
            this.BtnTecla1.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla1.TabIndex = 99;
            this.BtnTecla1.Text = "1";
            this.BtnTecla1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla1.UseVisualStyleBackColor = false;
            this.BtnTecla1.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla2
            // 
            this.BtnTecla2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla2.FlatAppearance.BorderSize = 0;
            this.BtnTecla2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla2.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla2.ForeColor = System.Drawing.Color.White;
            this.BtnTecla2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla2.Location = new System.Drawing.Point(106, 198);
            this.BtnTecla2.Name = "BtnTecla2";
            this.BtnTecla2.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla2.TabIndex = 100;
            this.BtnTecla2.Text = "2";
            this.BtnTecla2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla2.UseVisualStyleBackColor = false;
            this.BtnTecla2.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla3
            // 
            this.BtnTecla3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla3.FlatAppearance.BorderSize = 0;
            this.BtnTecla3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla3.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla3.ForeColor = System.Drawing.Color.White;
            this.BtnTecla3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla3.Location = new System.Drawing.Point(203, 198);
            this.BtnTecla3.Name = "BtnTecla3";
            this.BtnTecla3.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla3.TabIndex = 101;
            this.BtnTecla3.Text = "3";
            this.BtnTecla3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla3.UseVisualStyleBackColor = false;
            this.BtnTecla3.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla4
            // 
            this.BtnTecla4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla4.FlatAppearance.BorderSize = 0;
            this.BtnTecla4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla4.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla4.ForeColor = System.Drawing.Color.White;
            this.BtnTecla4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla4.Location = new System.Drawing.Point(9, 102);
            this.BtnTecla4.Name = "BtnTecla4";
            this.BtnTecla4.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla4.TabIndex = 102;
            this.BtnTecla4.Text = "4";
            this.BtnTecla4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla4.UseVisualStyleBackColor = false;
            this.BtnTecla4.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla0
            // 
            this.BtnTecla0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla0.FlatAppearance.BorderSize = 0;
            this.BtnTecla0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla0.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla0.ForeColor = System.Drawing.Color.White;
            this.BtnTecla0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla0.Location = new System.Drawing.Point(9, 296);
            this.BtnTecla0.Name = "BtnTecla0";
            this.BtnTecla0.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla0.TabIndex = 108;
            this.BtnTecla0.Text = "0";
            this.BtnTecla0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla0.UseVisualStyleBackColor = false;
            this.BtnTecla0.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla6
            // 
            this.BtnTecla6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla6.FlatAppearance.BorderSize = 0;
            this.BtnTecla6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla6.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla6.ForeColor = System.Drawing.Color.White;
            this.BtnTecla6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla6.Location = new System.Drawing.Point(203, 102);
            this.BtnTecla6.Name = "BtnTecla6";
            this.BtnTecla6.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla6.TabIndex = 104;
            this.BtnTecla6.Text = "6";
            this.BtnTecla6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla6.UseVisualStyleBackColor = false;
            this.BtnTecla6.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla7
            // 
            this.BtnTecla7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla7.FlatAppearance.BorderSize = 0;
            this.BtnTecla7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla7.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla7.ForeColor = System.Drawing.Color.White;
            this.BtnTecla7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla7.Location = new System.Drawing.Point(9, 6);
            this.BtnTecla7.Name = "BtnTecla7";
            this.BtnTecla7.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla7.TabIndex = 105;
            this.BtnTecla7.Text = "7";
            this.BtnTecla7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla7.UseVisualStyleBackColor = false;
            this.BtnTecla7.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla9
            // 
            this.BtnTecla9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla9.FlatAppearance.BorderSize = 0;
            this.BtnTecla9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla9.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla9.ForeColor = System.Drawing.Color.White;
            this.BtnTecla9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla9.Location = new System.Drawing.Point(203, 6);
            this.BtnTecla9.Name = "BtnTecla9";
            this.BtnTecla9.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla9.TabIndex = 107;
            this.BtnTecla9.Text = "9";
            this.BtnTecla9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla9.UseVisualStyleBackColor = false;
            this.BtnTecla9.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // BtnTecla8
            // 
            this.BtnTecla8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnTecla8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTecla8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTecla8.FlatAppearance.BorderSize = 0;
            this.BtnTecla8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTecla8.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTecla8.ForeColor = System.Drawing.Color.White;
            this.BtnTecla8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTecla8.Location = new System.Drawing.Point(106, 6);
            this.BtnTecla8.Name = "BtnTecla8";
            this.BtnTecla8.Size = new System.Drawing.Size(93, 93);
            this.BtnTecla8.TabIndex = 106;
            this.BtnTecla8.Text = "8";
            this.BtnTecla8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTecla8.UseVisualStyleBackColor = false;
            this.BtnTecla8.Click += new System.EventHandler(this.BtnTecla_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(239, -181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 155);
            this.button6.TabIndex = 115;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // ListaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(382, 680);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaMesa";
            this.Text = "ListaMesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnTeclado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnTeclado;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Button BtnTecla5;
        private System.Windows.Forms.Button BtnTecla1;
        private System.Windows.Forms.Button BtnTecla2;
        private System.Windows.Forms.Button BtnTecla3;
        private System.Windows.Forms.Button BtnTecla4;
        private System.Windows.Forms.Button BtnTecla0;
        private System.Windows.Forms.Button BtnTecla6;
        private System.Windows.Forms.Button BtnTecla7;
        private System.Windows.Forms.Button BtnTecla9;
        private System.Windows.Forms.Button BtnTecla8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TxtDivisao;
        private System.Windows.Forms.Label LblOperador;
    }
}