namespace SOLDIGusto
{
    partial class Comanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comanda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnListaMesa = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GwItens = new System.Windows.Forms.DataGridView();
            this.pluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaItemDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblComanda = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GwItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaItemDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnListaMesa);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.GwItens);
            this.panel1.Controls.Add(this.LblComanda);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 507);
            this.panel1.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(852, 439);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 28);
            this.txtTotal.TabIndex = 152;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(733, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 151;
            this.label1.Text = "Total: R$";
            // 
            // BtnListaMesa
            // 
            this.BtnListaMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnListaMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnListaMesa.BackgroundImage")));
            this.BtnListaMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnListaMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListaMesa.FlatAppearance.BorderSize = 0;
            this.BtnListaMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaMesa.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListaMesa.ForeColor = System.Drawing.Color.White;
            this.BtnListaMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListaMesa.Location = new System.Drawing.Point(199, 439);
            this.BtnListaMesa.Name = "BtnListaMesa";
            this.BtnListaMesa.Size = new System.Drawing.Size(141, 53);
            this.BtnListaMesa.TabIndex = 150;
            this.BtnListaMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnListaMesa.UseVisualStyleBackColor = false;
            this.BtnListaMesa.Click += new System.EventHandler(this.BtnListaMesa_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFechar.BackgroundImage")));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechar.Location = new System.Drawing.Point(28, 439);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(141, 53);
            this.BtnFechar.TabIndex = 149;
            this.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GwItens
            // 
            this.GwItens.AllowUserToAddRows = false;
            this.GwItens.AllowUserToDeleteRows = false;
            this.GwItens.AllowUserToResizeColumns = false;
            this.GwItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GwItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GwItens.AutoGenerateColumns = false;
            this.GwItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GwItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GwItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GwItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GwItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GwItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GwItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pluDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.qtdeDataGridViewTextBoxColumn,
            this.unitarioDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.GwItens.DataSource = this.comandaItemDAOBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GwItens.DefaultCellStyle = dataGridViewCellStyle9;
            this.GwItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(49)))), ((int)(((byte)(131)))));
            this.GwItens.Location = new System.Drawing.Point(28, 64);
            this.GwItens.MultiSelect = false;
            this.GwItens.Name = "GwItens";
            this.GwItens.ReadOnly = true;
            this.GwItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GwItens.RowHeadersVisible = false;
            this.GwItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GwItens.RowTemplate.Height = 50;
            this.GwItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GwItens.Size = new System.Drawing.Size(961, 343);
            this.GwItens.TabIndex = 148;
            // 
            // pluDataGridViewTextBoxColumn
            // 
            this.pluDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pluDataGridViewTextBoxColumn.DataPropertyName = "plu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pluDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pluDataGridViewTextBoxColumn.HeaderText = "Plu";
            this.pluDataGridViewTextBoxColumn.Name = "pluDataGridViewTextBoxColumn";
            this.pluDataGridViewTextBoxColumn.ReadOnly = true;
            this.pluDataGridViewTextBoxColumn.Width = 62;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdeDataGridViewTextBoxColumn
            // 
            this.qtdeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtdeDataGridViewTextBoxColumn.DataPropertyName = "qtde";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qtdeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "Qtde.";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            this.qtdeDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdeDataGridViewTextBoxColumn.Width = 82;
            // 
            // unitarioDataGridViewTextBoxColumn
            // 
            this.unitarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitarioDataGridViewTextBoxColumn.DataPropertyName = "unitario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.unitarioDataGridViewTextBoxColumn.HeaderText = "Vlr. Unitario";
            this.unitarioDataGridViewTextBoxColumn.Name = "unitarioDataGridViewTextBoxColumn";
            this.unitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitarioDataGridViewTextBoxColumn.Width = 119;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Vlr. Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 98;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 99;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 74;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataGridViewCellStyle8.Format = "T";
            dataGridViewCellStyle8.NullValue = null;
            this.horaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 75;
            // 
            // comandaItemDAOBindingSource
            // 
            this.comandaItemDAOBindingSource.DataSource = typeof(ComandaItemDAO);
            // 
            // LblComanda
            // 
            this.LblComanda.AutoSize = true;
            this.LblComanda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.LblComanda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblComanda.Location = new System.Drawing.Point(23, 22);
            this.LblComanda.Name = "LblComanda";
            this.LblComanda.Size = new System.Drawing.Size(136, 29);
            this.LblComanda.TabIndex = 147;
            this.LblComanda.Text = "Comanda: ";
            // 
            // Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1041, 531);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comanda";
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.Comanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GwItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaItemDAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblComanda;
        private System.Windows.Forms.DataGridView GwItens;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnListaMesa;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.BindingSource comandaItemDAOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
    }
}