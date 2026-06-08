namespace SOLDIGusto
{
    partial class LimpaComanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimpaComanda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCom = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GwItens = new System.Windows.Forms.DataGridView();
            this.pluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaItemDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancelarTodos = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.LblSoldi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtComanda = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.GwItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaItemDAOBindingSource)).BeginInit();
            this.PnTeclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblCom);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GwItens);
            this.panel1.Controls.Add(this.BtnCancelarTodos);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.LblSoldi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtComanda);
            this.panel1.Controls.Add(this.PnTeclado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 664);
            this.panel1.TabIndex = 0;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCom.Location = new System.Drawing.Point(526, 64);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(0, 22);
            this.lblCom.TabIndex = 155;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(751, 601);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 28);
            this.txtTotal.TabIndex = 154;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(632, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 153;
            this.label2.Text = "Total: R$";
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
            this.Excluir,
            this.idDataGridViewTextBoxColumn});
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
            this.GwItens.Location = new System.Drawing.Point(17, 100);
            this.GwItens.MultiSelect = false;
            this.GwItens.Name = "GwItens";
            this.GwItens.ReadOnly = true;
            this.GwItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GwItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GwItens.RowHeadersVisible = false;
            this.GwItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GwItens.RowTemplate.Height = 50;
            this.GwItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GwItens.Size = new System.Drawing.Size(871, 481);
            this.GwItens.TabIndex = 150;
            this.GwItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GwItens_CellClick);
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
            this.qtdeDataGridViewTextBoxColumn.HeaderText = "Qtde";
            this.qtdeDataGridViewTextBoxColumn.Name = "qtdeDataGridViewTextBoxColumn";
            this.qtdeDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdeDataGridViewTextBoxColumn.Width = 77;
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
            // Excluir
            // 
            this.Excluir.DataPropertyName = "EX";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.NullValue = "Excluir";
            this.Excluir.DefaultCellStyle = dataGridViewCellStyle7;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.ToolTipText = "EXCLUIR";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // comandaItemDAOBindingSource
            // 
            this.comandaItemDAOBindingSource.DataSource = typeof(ComandaItemDAO);
            // 
            // BtnCancelarTodos
            // 
            this.BtnCancelarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnCancelarTodos.BackgroundImage = global::SOLDIGusto.Properties.Resources.Icon_CancelItem;
            this.BtnCancelarTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancelarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarTodos.FlatAppearance.BorderSize = 0;
            this.BtnCancelarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarTodos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarTodos.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarTodos.Location = new System.Drawing.Point(193, 597);
            this.BtnCancelarTodos.Name = "BtnCancelarTodos";
            this.BtnCancelarTodos.Size = new System.Drawing.Size(141, 53);
            this.BtnCancelarTodos.TabIndex = 149;
            this.BtnCancelarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCancelarTodos.UseVisualStyleBackColor = false;
            this.BtnCancelarTodos.Click += new System.EventHandler(this.BtnCancelarTodos_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFechar.BackgroundImage = global::SOLDIGusto.Properties.Resources.Icon_Fecha;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechar.Location = new System.Drawing.Point(27, 597);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(141, 53);
            this.BtnFechar.TabIndex = 148;
            this.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // LblSoldi
            // 
            this.LblSoldi.AutoSize = true;
            this.LblSoldi.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.LblSoldi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSoldi.Location = new System.Drawing.Point(256, 3);
            this.LblSoldi.Name = "LblSoldi";
            this.LblSoldi.Size = new System.Drawing.Size(691, 35);
            this.LblSoldi.TabIndex = 145;
            this.LblSoldi.Text = "Limpeza (exclusão de itens) de Mesa/Comanda ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 144;
            this.label1.Text = "Comanda:";
            // 
            // TxtComanda
            // 
            this.TxtComanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtComanda.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.TxtComanda.ForeColor = System.Drawing.Color.Black;
            this.TxtComanda.Location = new System.Drawing.Point(117, 49);
            this.TxtComanda.MaxLength = 13;
            this.TxtComanda.Name = "TxtComanda";
            this.TxtComanda.Size = new System.Drawing.Size(147, 38);
            this.TxtComanda.TabIndex = 143;
            this.TxtComanda.Tag = "1";
            this.TxtComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidaCampo_KeyPress);
            this.TxtComanda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtComanda_KeyUp);
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
            this.PnTeclado.Location = new System.Drawing.Point(894, 94);
            this.PnTeclado.Name = "PnTeclado";
            this.PnTeclado.Size = new System.Drawing.Size(309, 499);
            this.PnTeclado.TabIndex = 142;
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
            // LimpaComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1253, 688);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LimpaComanda";
            this.Text = "LimpaComanda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GwItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaItemDAOBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtComanda;
        private System.Windows.Forms.Label LblSoldi;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCancelarTodos;
        private System.Windows.Forms.DataGridView GwItens;
        private System.Windows.Forms.BindingSource comandaItemDAOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCom;
    }
}