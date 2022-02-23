namespace FactureManagement.Forms
{
    partial class FormCreationFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreationFacture));
            this.GpOwner = new Guna.UI.WinForms.GunaGroupBox();
            this.GpItems = new System.Windows.Forms.GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbTtc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotCumule = new System.Windows.Forms.Label();
            this.lbTva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCdfAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbDevise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbfac = new System.Windows.Forms.Label();
            this.DGVDetail = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDetail = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.TextPu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.TextQte = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.TextDesign = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GbFacture = new System.Windows.Forms.GroupBox();
            this.chkTva = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.btnCreateFacture = new Guna.UI.WinForms.GunaButton();
            this.TextDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextFonction = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TextNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.GpOwner.SuspendLayout();
            this.GpItems.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbFacture.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpOwner
            // 
            this.GpOwner.AutoScroll = true;
            this.GpOwner.BackColor = System.Drawing.Color.Transparent;
            this.GpOwner.BaseColor = System.Drawing.Color.White;
            this.GpOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.BorderSize = 1;
            this.GpOwner.Controls.Add(this.GpItems);
            this.GpOwner.Controls.Add(this.groupBox1);
            this.GpOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GpOwner.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.Location = new System.Drawing.Point(27, 74);
            this.GpOwner.Margin = new System.Windows.Forms.Padding(4);
            this.GpOwner.Name = "GpOwner";
            this.GpOwner.Size = new System.Drawing.Size(1512, 776);
            this.GpOwner.TabIndex = 12;
            this.GpOwner.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // GpItems
            // 
            this.GpItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpItems.Controls.Add(this.guna2GroupBox1);
            this.GpItems.Controls.Add(this.label2);
            this.GpItems.Controls.Add(this.gunaLabel3);
            this.GpItems.Controls.Add(this.cbDevise);
            this.GpItems.Controls.Add(this.lbfac);
            this.GpItems.Controls.Add(this.DGVDetail);
            this.GpItems.Controls.Add(this.btnAddDetail);
            this.GpItems.Controls.Add(this.gunaLabel9);
            this.GpItems.Controls.Add(this.TextPu);
            this.GpItems.Controls.Add(this.gunaLabel8);
            this.GpItems.Controls.Add(this.TextQte);
            this.GpItems.Controls.Add(this.gunaLabel7);
            this.GpItems.Controls.Add(this.TextDesign);
            this.GpItems.Enabled = false;
            this.GpItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpItems.Location = new System.Drawing.Point(731, 38);
            this.GpItems.Margin = new System.Windows.Forms.Padding(4);
            this.GpItems.Name = "GpItems";
            this.GpItems.Padding = new System.Windows.Forms.Padding(4);
            this.GpItems.Size = new System.Drawing.Size(777, 724);
            this.GpItems.TabIndex = 20;
            this.GpItems.TabStop = false;
            this.GpItems.Text = "INSERTION DES ITEMS / RUBRIQUES DE LA FACTURE";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.lbTtc);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.lbTotCumule);
            this.guna2GroupBox1.Controls.Add(this.lbTva);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.lbCdfAmount);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 517);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(756, 201);
            this.guna2GroupBox1.TabIndex = 71;
            // 
            // lbTtc
            // 
            this.lbTtc.AutoSize = true;
            this.lbTtc.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTtc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.lbTtc.Location = new System.Drawing.Point(250, 137);
            this.lbTtc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTtc.Name = "lbTtc";
            this.lbTtc.Size = new System.Drawing.Size(83, 35);
            this.lbTtc.TabIndex = 84;
            this.lbTtc.Text = "00,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total cumulé :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(171, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 28);
            this.label8.TabIndex = 83;
            this.label8.Text = "TTC :";
            // 
            // lbTotCumule
            // 
            this.lbTotCumule.AutoSize = true;
            this.lbTotCumule.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotCumule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.lbTotCumule.Location = new System.Drawing.Point(250, 26);
            this.lbTotCumule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotCumule.Name = "lbTotCumule";
            this.lbTotCumule.Size = new System.Drawing.Size(83, 35);
            this.lbTotCumule.TabIndex = 78;
            this.lbTotCumule.Text = "00,00";
            // 
            // lbTva
            // 
            this.lbTva.AutoSize = true;
            this.lbTva.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.lbTva.Location = new System.Drawing.Point(250, 100);
            this.lbTva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTva.Name = "lbTva";
            this.lbTva.Size = new System.Drawing.Size(83, 35);
            this.lbTva.TabIndex = 82;
            this.lbTva.Text = "00,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(31, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 79;
            this.label4.Text = "Equivalent en CDF :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(168, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 81;
            this.label6.Text = "TVA :";
            // 
            // lbCdfAmount
            // 
            this.lbCdfAmount.AutoSize = true;
            this.lbCdfAmount.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCdfAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.lbCdfAmount.Location = new System.Drawing.Point(250, 63);
            this.lbCdfAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCdfAmount.Name = "lbCdfAmount";
            this.lbCdfAmount.Size = new System.Drawing.Size(83, 35);
            this.lbCdfAmount.TabIndex = 80;
            this.lbCdfAmount.Text = "00,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(457, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "FACTURE N°";
            this.label2.Visible = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(508, 115);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel3.TabIndex = 69;
            this.gunaLabel3.Text = "Devise *";
            // 
            // cbDevise
            // 
            this.cbDevise.Animated = true;
            this.cbDevise.BackColor = System.Drawing.Color.Transparent;
            this.cbDevise.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbDevise.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevise.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbDevise.FocusedColor = System.Drawing.Color.Empty;
            this.cbDevise.FocusedState.Parent = this.cbDevise;
            this.cbDevise.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevise.FormattingEnabled = true;
            this.cbDevise.HoverState.FillColor = System.Drawing.Color.White;
            this.cbDevise.HoverState.Parent = this.cbDevise;
            this.cbDevise.ItemHeight = 30;
            this.cbDevise.Items.AddRange(new object[] {
            "usd",
            "cdf"});
            this.cbDevise.ItemsAppearance.Parent = this.cbDevise;
            this.cbDevise.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbDevise.Location = new System.Drawing.Point(508, 153);
            this.cbDevise.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevise.Name = "cbDevise";
            this.cbDevise.ShadowDecoration.Parent = this.cbDevise;
            this.cbDevise.Size = new System.Drawing.Size(123, 36);
            this.cbDevise.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevise.TabIndex = 68;
            // 
            // lbfac
            // 
            this.lbfac.AutoSize = true;
            this.lbfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbfac.ForeColor = System.Drawing.Color.Black;
            this.lbfac.Location = new System.Drawing.Point(588, 36);
            this.lbfac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfac.Name = "lbfac";
            this.lbfac.Size = new System.Drawing.Size(0, 22);
            this.lbfac.TabIndex = 67;
            // 
            // DGVDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.DGVDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDetail.ColumnHeadersHeight = 40;
            this.DGVDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDetail.EnableHeadersVisualStyles = false;
            this.DGVDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.DGVDetail.Location = new System.Drawing.Point(13, 254);
            this.DGVDetail.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDetail.Name = "DGVDetail";
            this.DGVDetail.ReadOnly = true;
            this.DGVDetail.RowHeadersVisible = false;
            this.DGVDetail.RowHeadersWidth = 57;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDetail.RowTemplate.Height = 30;
            this.DGVDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetail.Size = new System.Drawing.Size(756, 256);
            this.DGVDetail.TabIndex = 64;
            this.DGVDetail.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.DGVDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.DGVDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDetail.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.DGVDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.DGVDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVDetail.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVDetail.ThemeStyle.ReadOnly = true;
            this.DGVDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.DGVDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVDetail.ThemeStyle.RowsStyle.Height = 30;
            this.DGVDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.DGVDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetail_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 76.14214F;
            this.Column1.HeaderText = "N°";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 105.9645F;
            this.Column2.HeaderText = "DESIGNATION";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 105.9645F;
            this.Column5.HeaderText = "QUANTITE";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 105.9645F;
            this.Column3.HeaderText = "P.U";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 105.9645F;
            this.Column4.HeaderText = "P.T";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Animated = true;
            this.btnAddDetail.AnimationHoverSpeed = 0.1F;
            this.btnAddDetail.AnimationSpeed = 0.1F;
            this.btnAddDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDetail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddDetail.BorderColor = System.Drawing.Color.Black;
            this.btnAddDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDetail.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAddDetail.ForeColor = System.Drawing.Color.White;
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDetail.Location = new System.Drawing.Point(13, 204);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnAddDetail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDetail.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDetail.OnHoverImage = null;
            this.btnAddDetail.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDetail.Size = new System.Drawing.Size(618, 42);
            this.btnAddDetail.TabIndex = 62;
            this.btnAddDetail.Text = "Ajouter un item à la facture";
            this.btnAddDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel9.Location = new System.Drawing.Point(207, 115);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(105, 20);
            this.gunaLabel9.TabIndex = 61;
            this.gunaLabel9.Text = "Prix unitaire *";
            // 
            // TextPu
            // 
            this.TextPu.Animated = true;
            this.TextPu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextPu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPu.DefaultText = "";
            this.TextPu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPu.DisabledState.Parent = this.TextPu;
            this.TextPu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPu.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextPu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPu.FocusedState.Parent = this.TextPu;
            this.TextPu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPu.HoverState.Parent = this.TextPu;
            this.TextPu.Location = new System.Drawing.Point(207, 145);
            this.TextPu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextPu.Name = "TextPu";
            this.TextPu.PasswordChar = '\0';
            this.TextPu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextPu.PlaceholderText = "Entrez le prix unitaire";
            this.TextPu.SelectedText = "";
            this.TextPu.ShadowDecoration.Parent = this.TextPu;
            this.TextPu.Size = new System.Drawing.Size(292, 44);
            this.TextPu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextPu.TabIndex = 60;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel8.Location = new System.Drawing.Point(13, 115);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(81, 20);
            this.gunaLabel8.TabIndex = 59;
            this.gunaLabel8.Text = "Quantité *";
            // 
            // TextQte
            // 
            this.TextQte.Animated = true;
            this.TextQte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextQte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextQte.DefaultText = "";
            this.TextQte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextQte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextQte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQte.DisabledState.Parent = this.TextQte;
            this.TextQte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextQte.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextQte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQte.FocusedState.Parent = this.TextQte;
            this.TextQte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextQte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextQte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextQte.HoverState.Parent = this.TextQte;
            this.TextQte.Location = new System.Drawing.Point(13, 145);
            this.TextQte.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextQte.Name = "TextQte";
            this.TextQte.PasswordChar = '\0';
            this.TextQte.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextQte.PlaceholderText = "Entrez la quantité...ex .02";
            this.TextQte.SelectedText = "";
            this.TextQte.ShadowDecoration.Parent = this.TextQte;
            this.TextQte.Size = new System.Drawing.Size(185, 44);
            this.TextQte.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextQte.TabIndex = 58;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel7.Location = new System.Drawing.Point(11, 36);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(104, 20);
            this.gunaLabel7.TabIndex = 57;
            this.gunaLabel7.Text = "Désignation *";
            // 
            // TextDesign
            // 
            this.TextDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDesign.Animated = true;
            this.TextDesign.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextDesign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextDesign.DefaultText = "";
            this.TextDesign.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextDesign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextDesign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextDesign.DisabledState.Parent = this.TextDesign;
            this.TextDesign.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextDesign.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextDesign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextDesign.FocusedState.Parent = this.TextDesign;
            this.TextDesign.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextDesign.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextDesign.HoverState.Parent = this.TextDesign;
            this.TextDesign.Location = new System.Drawing.Point(13, 66);
            this.TextDesign.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextDesign.Name = "TextDesign";
            this.TextDesign.PasswordChar = '\0';
            this.TextDesign.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextDesign.PlaceholderText = "Entrez la désignation...";
            this.TextDesign.SelectedText = "";
            this.TextDesign.ShadowDecoration.Parent = this.TextDesign;
            this.TextDesign.Size = new System.Drawing.Size(756, 44);
            this.TextDesign.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextDesign.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.GbFacture);
            this.groupBox1.Controls.Add(this.gunaSeparator2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gunaSeparator1);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.TextFonction);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.TextNom);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(713, 724);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATION DE LA FACTURE";
            // 
            // GbFacture
            // 
            this.GbFacture.Controls.Add(this.chkTva);
            this.GbFacture.Controls.Add(this.gunaLabel5);
            this.GbFacture.Controls.Add(this.cbClient);
            this.GbFacture.Controls.Add(this.btnAnnuler);
            this.GbFacture.Controls.Add(this.gunaLabel10);
            this.GbFacture.Controls.Add(this.btnCreateFacture);
            this.GbFacture.Controls.Add(this.TextDate);
            this.GbFacture.Location = new System.Drawing.Point(11, 23);
            this.GbFacture.Margin = new System.Windows.Forms.Padding(4);
            this.GbFacture.Name = "GbFacture";
            this.GbFacture.Padding = new System.Windows.Forms.Padding(4);
            this.GbFacture.Size = new System.Drawing.Size(692, 295);
            this.GbFacture.TabIndex = 68;
            this.GbFacture.TabStop = false;
            // 
            // chkTva
            // 
            this.chkTva.BaseColor = System.Drawing.Color.White;
            this.chkTva.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkTva.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.chkTva.FillColor = System.Drawing.Color.WhiteSmoke;
            this.chkTva.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTva.Location = new System.Drawing.Point(12, 107);
            this.chkTva.Margin = new System.Windows.Forms.Padding(4);
            this.chkTva.Name = "chkTva";
            this.chkTva.Size = new System.Drawing.Size(218, 26);
            this.chkTva.TabIndex = 64;
            this.chkTva.Text = "Inclure le tva (optionnel)";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(6, 20);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(553, 20);
            this.gunaLabel5.TabIndex = 47;
            this.gunaLabel5.Text = "Sélectionnez le client et cliquez sur le bouton créer avant d\'ajouter des items";
            // 
            // cbClient
            // 
            this.cbClient.Animated = true;
            this.cbClient.BackColor = System.Drawing.Color.Transparent;
            this.cbClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbClient.FocusedColor = System.Drawing.Color.Empty;
            this.cbClient.FocusedState.Parent = this.cbClient;
            this.cbClient.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.HoverState.FillColor = System.Drawing.Color.White;
            this.cbClient.HoverState.Parent = this.cbClient;
            this.cbClient.ItemHeight = 30;
            this.cbClient.ItemsAppearance.Parent = this.cbClient;
            this.cbClient.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbClient.Location = new System.Drawing.Point(8, 54);
            this.cbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbClient.Name = "cbClient";
            this.cbClient.ShadowDecoration.Parent = this.cbClient;
            this.cbClient.Size = new System.Drawing.Size(671, 36);
            this.cbClient.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbClient.TabIndex = 48;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Animated = true;
            this.btnAnnuler.AnimationHoverSpeed = 0.1F;
            this.btnAnnuler.AnimationSpeed = 0.1F;
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnnuler.BorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnnuler.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.ImageSize = new System.Drawing.Size(18, 18);
            this.btnAnnuler.Location = new System.Drawing.Point(503, 186);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(180, 37);
            this.btnAnnuler.TabIndex = 63;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel10.Location = new System.Drawing.Point(8, 159);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(231, 20);
            this.gunaLabel10.TabIndex = 59;
            this.gunaLabel10.Text = "Date de la création de la facture";
            // 
            // btnCreateFacture
            // 
            this.btnCreateFacture.Animated = true;
            this.btnCreateFacture.AnimationHoverSpeed = 0.1F;
            this.btnCreateFacture.AnimationSpeed = 0.1F;
            this.btnCreateFacture.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateFacture.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCreateFacture.BorderColor = System.Drawing.Color.Black;
            this.btnCreateFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFacture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateFacture.FocusedColor = System.Drawing.Color.Empty;
            this.btnCreateFacture.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCreateFacture.ForeColor = System.Drawing.Color.White;
            this.btnCreateFacture.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateFacture.Image")));
            this.btnCreateFacture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateFacture.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCreateFacture.Location = new System.Drawing.Point(314, 186);
            this.btnCreateFacture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFacture.Name = "btnCreateFacture";
            this.btnCreateFacture.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnCreateFacture.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCreateFacture.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCreateFacture.OnHoverImage = null;
            this.btnCreateFacture.OnPressedColor = System.Drawing.Color.Black;
            this.btnCreateFacture.Size = new System.Drawing.Size(180, 37);
            this.btnCreateFacture.TabIndex = 62;
            this.btnCreateFacture.Text = "CREER";
            this.btnCreateFacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateFacture.Click += new System.EventHandler(this.btnCreateFacture_Click);
            // 
            // TextDate
            // 
            this.TextDate.BackColor = System.Drawing.Color.Transparent;
            this.TextDate.BaseColor = System.Drawing.Color.White;
            this.TextDate.BorderColor = System.Drawing.Color.Silver;
            this.TextDate.BorderSize = 1;
            this.TextDate.CustomFormat = null;
            this.TextDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TextDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextDate.ForeColor = System.Drawing.Color.Black;
            this.TextDate.Location = new System.Drawing.Point(12, 186);
            this.TextDate.Margin = new System.Windows.Forms.Padding(4);
            this.TextDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TextDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TextDate.Name = "TextDate";
            this.TextDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.TextDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDate.OnPressedColor = System.Drawing.Color.Black;
            this.TextDate.Size = new System.Drawing.Size(293, 37);
            this.TextDate.TabIndex = 60;
            this.TextDate.Text = "mercredi 18 novembre 2020";
            this.TextDate.Value = new System.DateTime(2020, 11, 18, 22, 34, 40, 388);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(0, 367);
            this.gunaSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(712, 2);
            this.gunaSeparator2.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(155, 332);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "PERSONNALISATION DE LA FACTURE";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(1, 326);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(712, 5);
            this.gunaSeparator1.TabIndex = 61;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(15, 465);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(205, 23);
            this.gunaLabel2.TabIndex = 53;
            this.gunaLabel2.Text = "Fonction du Signataire *";
            // 
            // TextFonction
            // 
            this.TextFonction.Animated = true;
            this.TextFonction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextFonction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextFonction.DefaultText = "";
            this.TextFonction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextFonction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextFonction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextFonction.DisabledState.Parent = this.TextFonction;
            this.TextFonction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextFonction.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextFonction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextFonction.FocusedState.Parent = this.TextFonction;
            this.TextFonction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextFonction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextFonction.HoverState.Parent = this.TextFonction;
            this.TextFonction.Location = new System.Drawing.Point(16, 495);
            this.TextFonction.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextFonction.Name = "TextFonction";
            this.TextFonction.PasswordChar = '\0';
            this.TextFonction.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextFonction.PlaceholderText = "Entrez la fonction du signataire.. ex. Chef de service";
            this.TextFonction.SelectedText = "";
            this.TextFonction.ShadowDecoration.Parent = this.TextFonction;
            this.TextFonction.Size = new System.Drawing.Size(687, 44);
            this.TextFonction.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextFonction.TabIndex = 52;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 379);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(172, 23);
            this.gunaLabel1.TabIndex = 51;
            this.gunaLabel1.Text = "Nom du signataire *";
            // 
            // TextNom
            // 
            this.TextNom.Animated = true;
            this.TextNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextNom.DefaultText = "";
            this.TextNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNom.DisabledState.Parent = this.TextNom;
            this.TextNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextNom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNom.FocusedState.Parent = this.TextNom;
            this.TextNom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextNom.HoverState.Parent = this.TextNom;
            this.TextNom.Location = new System.Drawing.Point(16, 414);
            this.TextNom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextNom.Name = "TextNom";
            this.TextNom.PasswordChar = '\0';
            this.TextNom.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextNom.PlaceholderText = "Entrez le nom du signataire.. Ex. gaston delimond";
            this.TextNom.SelectedText = "";
            this.TextNom.ShadowDecoration.Parent = this.TextNom;
            this.TextNom.Size = new System.Drawing.Size(687, 44);
            this.TextNom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextNom.TabIndex = 50;
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.AnimationHoverSpeed = 0.1F;
            this.btnPrint.AnimationSpeed = 0.1F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.Enabled = false;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.ImageOffsetX = 15;
            this.btnPrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(11, 574);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Size = new System.Drawing.Size(692, 70);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "IMPRIMER";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormCreationFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1566, 875);
            this.Controls.Add(this.GpOwner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormCreationFacture";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = " FACTURE";
            this.Load += new System.EventHandler(this.FormCreationFacture_Load);
            this.GpOwner.ResumeLayout(false);
            this.GpItems.ResumeLayout(false);
            this.GpItems.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbFacture.ResumeLayout(false);
            this.GbFacture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaGroupBox GpOwner;
        private System.Windows.Forms.GroupBox groupBox1;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox TextFonction;
        public Guna.UI2.WinForms.Guna2TextBox TextNom;
        public Guna.UI2.WinForms.Guna2ComboBox cbClient;
        public Guna.UI.WinForms.GunaButton btnPrint;
        public Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.GroupBox GpItems;
        public Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI2.WinForms.Guna2TextBox TextDesign;
        public Guna.UI.WinForms.GunaLabel gunaLabel9;
        public Guna.UI2.WinForms.Guna2TextBox TextPu;
        public Guna.UI.WinForms.GunaLabel gunaLabel8;
        public Guna.UI2.WinForms.Guna2TextBox TextQte;
        public Guna.UI.WinForms.GunaButton btnAddDetail;
        private Guna.UI.WinForms.GunaDataGridView DGVDetail;
        private Guna.UI.WinForms.GunaDateTimePicker TextDate;
        public Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        public Guna.UI.WinForms.GunaButton btnCreateFacture;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.Label lbfac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI2.WinForms.Guna2ComboBox cbDevise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbFacture;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCheckBox chkTva;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lbTtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotCumule;
        private System.Windows.Forms.Label lbTva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCdfAmount;
    }
}