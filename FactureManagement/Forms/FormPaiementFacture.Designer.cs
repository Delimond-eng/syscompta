namespace FactureManagement.Forms
{
    partial class FormPaiementFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiementFacture));
            this.GpOwner = new Guna.UI.WinForms.GunaGroupBox();
            this.lbRestToPay = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.lbAmountPay = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.lbStatut = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lbClient = new Guna.UI.WinForms.GunaLabel();
            this.cbCompte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbMontant = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.DGVPaiement = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnEffectuerPaie = new Guna.UI.WinForms.GunaButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cbModePaie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDevise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbFacture = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GpOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaiement)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpOwner
            // 
            this.GpOwner.BackColor = System.Drawing.Color.Transparent;
            this.GpOwner.BaseColor = System.Drawing.Color.White;
            this.GpOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.BorderSize = 1;
            this.GpOwner.Controls.Add(this.lbRestToPay);
            this.GpOwner.Controls.Add(this.gunaLabel11);
            this.GpOwner.Controls.Add(this.lbAmountPay);
            this.GpOwner.Controls.Add(this.gunaLabel9);
            this.GpOwner.Controls.Add(this.lbStatut);
            this.GpOwner.Controls.Add(this.gunaLabel10);
            this.GpOwner.Controls.Add(this.gunaLabel6);
            this.GpOwner.Controls.Add(this.lbClient);
            this.GpOwner.Controls.Add(this.cbCompte);
            this.GpOwner.Controls.Add(this.lbMontant);
            this.GpOwner.Controls.Add(this.gunaLabel5);
            this.GpOwner.Controls.Add(this.gunaLabel3);
            this.GpOwner.Controls.Add(this.DGVPaiement);
            this.GpOwner.Controls.Add(this.groupBox3);
            this.GpOwner.Controls.Add(this.groupBox1);
            this.GpOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GpOwner.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.LineTop = 25;
            this.GpOwner.Location = new System.Drawing.Point(27, 74);
            this.GpOwner.Margin = new System.Windows.Forms.Padding(4);
            this.GpOwner.Name = "GpOwner";
            this.GpOwner.Size = new System.Drawing.Size(1451, 633);
            this.GpOwner.TabIndex = 12;
            this.GpOwner.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lbRestToPay
            // 
            this.lbRestToPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRestToPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.lbRestToPay.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestToPay.ForeColor = System.Drawing.Color.White;
            this.lbRestToPay.Location = new System.Drawing.Point(907, 215);
            this.lbRestToPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRestToPay.Name = "lbRestToPay";
            this.lbRestToPay.Size = new System.Drawing.Size(529, 36);
            this.lbRestToPay.TabIndex = 107;
            this.lbRestToPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel11.Location = new System.Drawing.Point(818, 220);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(68, 25);
            this.gunaLabel11.TabIndex = 106;
            this.gunaLabel11.Text = "Reste :\r\n";
            // 
            // lbAmountPay
            // 
            this.lbAmountPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAmountPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.lbAmountPay.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPay.ForeColor = System.Drawing.Color.White;
            this.lbAmountPay.Location = new System.Drawing.Point(906, 171);
            this.lbAmountPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmountPay.Name = "lbAmountPay";
            this.lbAmountPay.Size = new System.Drawing.Size(529, 36);
            this.lbAmountPay.TabIndex = 105;
            this.lbAmountPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel9.Location = new System.Drawing.Point(743, 178);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(143, 25);
            this.gunaLabel9.TabIndex = 104;
            this.gunaLabel9.Text = "Montant payé :\r\n";
            // 
            // lbStatut
            // 
            this.lbStatut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.lbStatut.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatut.ForeColor = System.Drawing.Color.White;
            this.lbStatut.Location = new System.Drawing.Point(906, 303);
            this.lbStatut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatut.Name = "lbStatut";
            this.lbStatut.Size = new System.Drawing.Size(530, 36);
            this.lbStatut.TabIndex = 103;
            this.lbStatut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel10.Location = new System.Drawing.Point(812, 309);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(74, 25);
            this.gunaLabel10.TabIndex = 102;
            this.gunaLabel10.Text = "Status :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel6.Location = new System.Drawing.Point(691, 41);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(215, 25);
            this.gunaLabel6.TabIndex = 101;
            this.gunaLabel6.Text = "Sélectionner un compte";
            // 
            // lbClient
            // 
            this.lbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.lbClient.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.ForeColor = System.Drawing.Color.White;
            this.lbClient.Location = new System.Drawing.Point(906, 259);
            this.lbClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(530, 36);
            this.lbClient.TabIndex = 99;
            this.lbClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCompte
            // 
            this.cbCompte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompte.Animated = true;
            this.cbCompte.BackColor = System.Drawing.Color.Transparent;
            this.cbCompte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbCompte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompte.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbCompte.FocusedColor = System.Drawing.Color.Empty;
            this.cbCompte.FocusedState.Parent = this.cbCompte;
            this.cbCompte.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.HoverState.FillColor = System.Drawing.Color.White;
            this.cbCompte.HoverState.Parent = this.cbCompte;
            this.cbCompte.ItemHeight = 30;
            this.cbCompte.ItemsAppearance.Parent = this.cbCompte;
            this.cbCompte.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbCompte.Location = new System.Drawing.Point(693, 71);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompte.Name = "cbCompte";
            this.cbCompte.ShadowDecoration.Parent = this.cbCompte;
            this.cbCompte.Size = new System.Drawing.Size(743, 36);
            this.cbCompte.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCompte.TabIndex = 100;
            // 
            // lbMontant
            // 
            this.lbMontant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMontant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(153)))), ((int)(((byte)(250)))));
            this.lbMontant.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontant.ForeColor = System.Drawing.Color.White;
            this.lbMontant.Location = new System.Drawing.Point(906, 127);
            this.lbMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(530, 36);
            this.lbMontant.TabIndex = 98;
            this.lbMontant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel5.Location = new System.Drawing.Point(814, 262);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 25);
            this.gunaLabel5.TabIndex = 97;
            this.gunaLabel5.Text = "Client :\r\n";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel3.Location = new System.Drawing.Point(688, 131);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(198, 25);
            this.gunaLabel3.TabIndex = 96;
            this.gunaLabel3.Text = "Montant net à payer :\r\n";
            // 
            // DGVPaiement
            // 
            this.DGVPaiement.AllowUserToResizeColumns = false;
            this.DGVPaiement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVPaiement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPaiement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPaiement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPaiement.BackgroundColor = System.Drawing.Color.White;
            this.DGVPaiement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPaiement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPaiement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPaiement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPaiement.ColumnHeadersHeight = 50;
            this.DGVPaiement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPaiement.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPaiement.EnableHeadersVisualStyles = false;
            this.DGVPaiement.GridColor = System.Drawing.Color.DarkGray;
            this.DGVPaiement.Location = new System.Drawing.Point(17, 431);
            this.DGVPaiement.Margin = new System.Windows.Forms.Padding(4);
            this.DGVPaiement.Name = "DGVPaiement";
            this.DGVPaiement.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPaiement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVPaiement.RowHeadersVisible = false;
            this.DGVPaiement.RowHeadersWidth = 57;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVPaiement.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVPaiement.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVPaiement.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVPaiement.RowTemplate.Height = 40;
            this.DGVPaiement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPaiement.Size = new System.Drawing.Size(1419, 198);
            this.DGVPaiement.TabIndex = 85;
            this.DGVPaiement.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.DGVPaiement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVPaiement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVPaiement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVPaiement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVPaiement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVPaiement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVPaiement.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.DGVPaiement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVPaiement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPaiement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPaiement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVPaiement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVPaiement.ThemeStyle.HeaderStyle.Height = 50;
            this.DGVPaiement.ThemeStyle.ReadOnly = true;
            this.DGVPaiement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVPaiement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPaiement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPaiement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVPaiement.ThemeStyle.RowsStyle.Height = 40;
            this.DGVPaiement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            this.DGVPaiement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "n°";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DATE";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CLIENT";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FACTURE";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MONTANT PAYE";
            this.Column6.MinimumWidth = 7;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "RESTANT";
            this.Column8.MinimumWidth = 7;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MODALITE DE PAYEMENT";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BtnCancel);
            this.groupBox3.Controls.Add(this.btnEffectuerPaie);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(679, 335);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(757, 89);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACTIONS";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Animated = true;
            this.BtnCancel.AnimationHoverSpeed = 0.1F;
            this.BtnCancel.AnimationSpeed = 0.1F;
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCancel.BorderColor = System.Drawing.Color.Black;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCancel.Location = new System.Drawing.Point(288, 29);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.BtnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancel.OnHoverImage = null;
            this.BtnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancel.Size = new System.Drawing.Size(256, 47);
            this.BtnCancel.TabIndex = 93;
            this.BtnCancel.Text = "Annuler le paiement ";
            this.BtnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnEffectuerPaie
            // 
            this.btnEffectuerPaie.Animated = true;
            this.btnEffectuerPaie.AnimationHoverSpeed = 0.1F;
            this.btnEffectuerPaie.AnimationSpeed = 0.1F;
            this.btnEffectuerPaie.BackColor = System.Drawing.Color.Transparent;
            this.btnEffectuerPaie.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnEffectuerPaie.BorderColor = System.Drawing.Color.Black;
            this.btnEffectuerPaie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffectuerPaie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEffectuerPaie.FocusedColor = System.Drawing.Color.Empty;
            this.btnEffectuerPaie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEffectuerPaie.ForeColor = System.Drawing.Color.White;
            this.btnEffectuerPaie.Image = ((System.Drawing.Image)(resources.GetObject("btnEffectuerPaie.Image")));
            this.btnEffectuerPaie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEffectuerPaie.Location = new System.Drawing.Point(14, 29);
            this.btnEffectuerPaie.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffectuerPaie.Name = "btnEffectuerPaie";
            this.btnEffectuerPaie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnEffectuerPaie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEffectuerPaie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEffectuerPaie.OnHoverImage = null;
            this.btnEffectuerPaie.OnPressedColor = System.Drawing.Color.Black;
            this.btnEffectuerPaie.Size = new System.Drawing.Size(256, 47);
            this.btnEffectuerPaie.TabIndex = 91;
            this.btnEffectuerPaie.Text = "Effectuer le paiement ";
            this.btnEffectuerPaie.Click += new System.EventHandler(this.btnEffectuerPaie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunaLabel7);
            this.groupBox1.Controls.Add(this.gunaLabel8);
            this.groupBox1.Controls.Add(this.cbModePaie);
            this.groupBox1.Controls.Add(this.cbDevise);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.TextMontant);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.cbFacture);
            this.groupBox1.Controls.Add(this.gunaLabel4);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(653, 385);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paiement de la facture ";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel7.Location = new System.Drawing.Point(457, 190);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel7.TabIndex = 87;
            this.gunaLabel7.Text = "Devise";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel8.Location = new System.Drawing.Point(8, 268);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(174, 25);
            this.gunaLabel8.TabIndex = 86;
            this.gunaLabel8.Text = "Mode de paiement";
            // 
            // cbModePaie
            // 
            this.cbModePaie.Animated = true;
            this.cbModePaie.BackColor = System.Drawing.Color.Transparent;
            this.cbModePaie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbModePaie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModePaie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModePaie.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbModePaie.FocusedColor = System.Drawing.Color.Empty;
            this.cbModePaie.FocusedState.Parent = this.cbModePaie;
            this.cbModePaie.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbModePaie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbModePaie.FormattingEnabled = true;
            this.cbModePaie.HoverState.FillColor = System.Drawing.Color.White;
            this.cbModePaie.HoverState.Parent = this.cbModePaie;
            this.cbModePaie.ItemHeight = 30;
            this.cbModePaie.Items.AddRange(new object[] {
            "Cash",
            "Virement",
            "Chèque"});
            this.cbModePaie.ItemsAppearance.Parent = this.cbModePaie;
            this.cbModePaie.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbModePaie.Location = new System.Drawing.Point(9, 297);
            this.cbModePaie.Margin = new System.Windows.Forms.Padding(4);
            this.cbModePaie.Name = "cbModePaie";
            this.cbModePaie.ShadowDecoration.Parent = this.cbModePaie;
            this.cbModePaie.Size = new System.Drawing.Size(595, 36);
            this.cbModePaie.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbModePaie.TabIndex = 85;
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
            this.cbDevise.Font = new System.Drawing.Font("Segoe UI", 11F);
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
            this.cbDevise.Location = new System.Drawing.Point(457, 218);
            this.cbDevise.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevise.Name = "cbDevise";
            this.cbDevise.ShadowDecoration.Parent = this.cbDevise;
            this.cbDevise.Size = new System.Drawing.Size(144, 36);
            this.cbDevise.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevise.TabIndex = 82;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel2.Location = new System.Drawing.Point(7, 187);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 25);
            this.gunaLabel2.TabIndex = 81;
            this.gunaLabel2.Text = "Montant payé";
            // 
            // TextMontant
            // 
            this.TextMontant.Animated = true;
            this.TextMontant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextMontant.DefaultText = "";
            this.TextMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextMontant.DisabledState.Parent = this.TextMontant;
            this.TextMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextMontant.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextMontant.FocusedState.Parent = this.TextMontant;
            this.TextMontant.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMontant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextMontant.HoverState.Parent = this.TextMontant;
            this.TextMontant.Location = new System.Drawing.Point(7, 218);
            this.TextMontant.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextMontant.Name = "TextMontant";
            this.TextMontant.PasswordChar = '\0';
            this.TextMontant.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextMontant.PlaceholderText = "Entrez le montant payé...";
            this.TextMontant.SelectedText = "";
            this.TextMontant.ShadowDecoration.Parent = this.TextMontant;
            this.TextMontant.Size = new System.Drawing.Size(441, 44);
            this.TextMontant.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextMontant.TabIndex = 80;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 111);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(306, 25);
            this.gunaLabel1.TabIndex = 79;
            this.gunaLabel1.Text = "Sélectionner le n° facture du client";
            // 
            // cbFacture
            // 
            this.cbFacture.Animated = true;
            this.cbFacture.BackColor = System.Drawing.Color.Transparent;
            this.cbFacture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbFacture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacture.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbFacture.FocusedColor = System.Drawing.Color.Empty;
            this.cbFacture.FocusedState.Parent = this.cbFacture;
            this.cbFacture.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbFacture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFacture.FormattingEnabled = true;
            this.cbFacture.HoverState.FillColor = System.Drawing.Color.White;
            this.cbFacture.HoverState.Parent = this.cbFacture;
            this.cbFacture.ItemHeight = 30;
            this.cbFacture.ItemsAppearance.Parent = this.cbFacture;
            this.cbFacture.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbFacture.Location = new System.Drawing.Point(9, 139);
            this.cbFacture.Margin = new System.Windows.Forms.Padding(4);
            this.cbFacture.Name = "cbFacture";
            this.cbFacture.ShadowDecoration.Parent = this.cbFacture;
            this.cbFacture.Size = new System.Drawing.Size(595, 36);
            this.cbFacture.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbFacture.TabIndex = 78;
            this.cbFacture.SelectedIndexChanged += new System.EventHandler(this.cbFacture_SelectedIndexChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaLabel4.Location = new System.Drawing.Point(7, 33);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(170, 25);
            this.gunaLabel4.TabIndex = 77;
            this.gunaLabel4.Text = "Sélectionner client";
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
            this.cbClient.Location = new System.Drawing.Point(8, 63);
            this.cbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbClient.Name = "cbClient";
            this.cbClient.ShadowDecoration.Parent = this.cbClient;
            this.cbClient.Size = new System.Drawing.Size(595, 36);
            this.cbClient.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbClient.TabIndex = 76;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // FormPaiementFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1505, 732);
            this.Controls.Add(this.GpOwner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaiementFacture";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "PAIEMENT DE LA FACTURE";
            this.GpOwner.ResumeLayout(false);
            this.GpOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaiement)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaGroupBox GpOwner;
        private System.Windows.Forms.GroupBox groupBox1;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI2.WinForms.Guna2ComboBox cbFacture;
        public Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI2.WinForms.Guna2ComboBox cbClient;
        public Guna.UI2.WinForms.Guna2ComboBox cbDevise;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox TextMontant;
        public Guna.UI.WinForms.GunaLabel gunaLabel8;
        public Guna.UI2.WinForms.Guna2ComboBox cbModePaie;
        private System.Windows.Forms.GroupBox groupBox3;
        public Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaButton BtnCancel;
        public Guna.UI.WinForms.GunaButton btnEffectuerPaie;
        private Guna.UI.WinForms.GunaDataGridView DGVPaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public Guna.UI.WinForms.GunaLabel lbRestToPay;
        public Guna.UI.WinForms.GunaLabel gunaLabel11;
        public Guna.UI.WinForms.GunaLabel lbAmountPay;
        public Guna.UI.WinForms.GunaLabel gunaLabel9;
        public Guna.UI.WinForms.GunaLabel lbStatut;
        public Guna.UI.WinForms.GunaLabel gunaLabel10;
        public Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaLabel lbClient;
        public Guna.UI2.WinForms.Guna2ComboBox cbCompte;
        public Guna.UI.WinForms.GunaLabel lbMontant;
        public Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}