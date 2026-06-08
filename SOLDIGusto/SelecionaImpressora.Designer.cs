namespace SOLDIGusto
{
    partial class SelecionaImpressora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaImpressora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.GwImp = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spoolImpressoraDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblOperador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GwImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolImpressoraDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtnConfirm);
            this.panel1.Controls.Add(this.GwImp);
            this.panel1.Controls.Add(this.LblOperador);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 540);
            this.panel1.TabIndex = 0;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfirm.BackgroundImage")));
            this.BtnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirm.Location = new System.Drawing.Point(130, 475);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(141, 53);
            this.BtnConfirm.TabIndex = 154;
            this.BtnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // GwImp
            // 
            this.GwImp.AllowUserToAddRows = false;
            this.GwImp.AllowUserToDeleteRows = false;
            this.GwImp.AllowUserToResizeColumns = false;
            this.GwImp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GwImp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GwImp.AutoGenerateColumns = false;
            this.GwImp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GwImp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GwImp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GwImp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GwImp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GwImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GwImp.ColumnHeadersVisible = false;
            this.GwImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.portaDataGridViewTextBoxColumn});
            this.GwImp.DataSource = this.spoolImpressoraDAOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GwImp.DefaultCellStyle = dataGridViewCellStyle3;
            this.GwImp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            this.GwImp.Location = new System.Drawing.Point(14, 65);
            this.GwImp.MultiSelect = false;
            this.GwImp.Name = "GwImp";
            this.GwImp.ReadOnly = true;
            this.GwImp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GwImp.RowHeadersVisible = false;
            this.GwImp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GwImp.RowTemplate.Height = 50;
            this.GwImp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GwImp.Size = new System.Drawing.Size(400, 393);
            this.GwImp.TabIndex = 149;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portaDataGridViewTextBoxColumn
            // 
            this.portaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.portaDataGridViewTextBoxColumn.DataPropertyName = "Porta";
            this.portaDataGridViewTextBoxColumn.HeaderText = "Porta";
            this.portaDataGridViewTextBoxColumn.Name = "portaDataGridViewTextBoxColumn";
            this.portaDataGridViewTextBoxColumn.ReadOnly = true;
            this.portaDataGridViewTextBoxColumn.Visible = false;
            // 
            // spoolImpressoraDAOBindingSource
            // 
            this.spoolImpressoraDAOBindingSource.DataSource = typeof(SpoolImpressoraDAO);
            // 
            // LblOperador
            // 
            this.LblOperador.AutoSize = true;
            this.LblOperador.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.LblOperador.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblOperador.Location = new System.Drawing.Point(125, 6);
            this.LblOperador.Name = "LblOperador";
            this.LblOperador.Size = new System.Drawing.Size(181, 58);
            this.LblOperador.TabIndex = 144;
            this.LblOperador.Text = "Selecione uma\r\n  impressora";
            // 
            // SelecionaImpressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(458, 564);
            this.Controls.Add(this.panel1);
            this.Name = "SelecionaImpressora";
            this.Text = "SelecionaImpressora";
            this.Load += new System.EventHandler(this.SelecionaImpressora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GwImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolImpressoraDAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblOperador;
        private System.Windows.Forms.DataGridView GwImp;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.BindingSource spoolImpressoraDAOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portaDataGridViewTextBoxColumn;
    }
}