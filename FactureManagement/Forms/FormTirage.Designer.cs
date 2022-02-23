namespace FactureManagement.Forms
{
    partial class FormTirage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTirage));
            this.GpOwner = new Guna.UI.WinForms.GunaGroupBox();
            this.PanelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.DGVTirage = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lbSelectInfo = new System.Windows.Forms.Label();
            this.TextDateBegin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextDateEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnAfficher = new Guna.UI.WinForms.GunaButton();
            this.btnAfficher1 = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumCompte = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.GpInfoCompte = new System.Windows.Forms.GroupBox();
            this.lbSolde = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCompte = new System.Windows.Forms.Label();
            this.cbCompte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PanelAction = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEntree = new Guna.UI.WinForms.GunaButton();
            this.btnSortie = new Guna.UI.WinForms.GunaButton();
            this.labelTitleSolde = new System.Windows.Forms.Label();
            this.labelSolde = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpOwner.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTirage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.GpInfoCompte.SuspendLayout();
            this.PanelAction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpOwner
            // 
            this.GpOwner.BackColor = System.Drawing.Color.Transparent;
            this.GpOwner.BaseColor = System.Drawing.Color.White;
            this.GpOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.BorderSize = 1;
            this.GpOwner.Controls.Add(this.PanelInfo);
            this.GpOwner.Controls.Add(this.lbNumCompte);
            this.GpOwner.Controls.Add(this.guna2Panel2);
            this.GpOwner.Controls.Add(this.PanelAction);
            this.GpOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GpOwner.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.LineTop = 25;
            this.GpOwner.Location = new System.Drawing.Point(27, 74);
            this.GpOwner.Margin = new System.Windows.Forms.Padding(4);
            this.GpOwner.Name = "GpOwner";
            this.GpOwner.Size = new System.Drawing.Size(1647, 644);
            this.GpOwner.TabIndex = 13;
            this.GpOwner.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelInfo.Controls.Add(this.labelSolde);
            this.PanelInfo.Controls.Add(this.labelTitleSolde);
            this.PanelInfo.Controls.Add(this.DGVTirage);
            this.PanelInfo.Controls.Add(this.gunaSeparator2);
            this.PanelInfo.Controls.Add(this.lbSelectInfo);
            this.PanelInfo.Controls.Add(this.TextDateBegin);
            this.PanelInfo.Controls.Add(this.TextDateEnd);
            this.PanelInfo.Controls.Add(this.label1);
            this.PanelInfo.Controls.Add(this.label5);
            this.PanelInfo.Controls.Add(this.label2);
            this.PanelInfo.Controls.Add(this.textDate);
            this.PanelInfo.Controls.Add(this.btnAfficher);
            this.PanelInfo.Controls.Add(this.btnAfficher1);
            this.PanelInfo.Controls.Add(this.label3);
            this.PanelInfo.CustomBorderColor = System.Drawing.Color.Silver;
            this.PanelInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.PanelInfo.Location = new System.Drawing.Point(9, 288);
            this.PanelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.ShadowDecoration.Parent = this.PanelInfo;
            this.PanelInfo.Size = new System.Drawing.Size(1630, 352);
            this.PanelInfo.TabIndex = 113;
            this.PanelInfo.Visible = false;
            // 
            // DGVTirage
            // 
            this.DGVTirage.AllowUserToResizeColumns = false;
            this.DGVTirage.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVTirage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVTirage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTirage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTirage.BackgroundColor = System.Drawing.Color.White;
            this.DGVTirage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTirage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTirage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTirage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVTirage.ColumnHeadersHeight = 60;
            this.DGVTirage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column8});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTirage.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVTirage.EnableHeadersVisualStyles = false;
            this.DGVTirage.GridColor = System.Drawing.Color.DimGray;
            this.DGVTirage.Location = new System.Drawing.Point(4, 156);
            this.DGVTirage.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTirage.Name = "DGVTirage";
            this.DGVTirage.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTirage.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVTirage.RowHeadersVisible = false;
            this.DGVTirage.RowHeadersWidth = 57;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVTirage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVTirage.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.RowTemplate.Height = 50;
            this.DGVTirage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTirage.Size = new System.Drawing.Size(1622, 189);
            this.DGVTirage.TabIndex = 110;
            this.DGVTirage.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.DGVTirage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVTirage.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTirage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTirage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTirage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTirage.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTirage.ThemeStyle.GridColor = System.Drawing.Color.DimGray;
            this.DGVTirage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightGray;
            this.DGVTirage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTirage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.DGVTirage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTirage.ThemeStyle.HeaderStyle.Height = 60;
            this.DGVTirage.ThemeStyle.ReadOnly = true;
            this.DGVTirage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTirage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTirage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTirage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVTirage.ThemeStyle.RowsStyle.Height = 50;
            this.DGVTirage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            this.DGVTirage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(0, 77);
            this.gunaSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(1627, 2);
            this.gunaSeparator2.TabIndex = 114;
            // 
            // lbSelectInfo
            // 
            this.lbSelectInfo.AutoSize = true;
            this.lbSelectInfo.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbSelectInfo.Location = new System.Drawing.Point(12, 11);
            this.lbSelectInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSelectInfo.Name = "lbSelectInfo";
            this.lbSelectInfo.Size = new System.Drawing.Size(413, 46);
            this.lbSelectInfo.TabIndex = 106;
            this.lbSelectInfo.Text = "Compte sélectionné......";
            // 
            // TextDateBegin
            // 
            this.TextDateBegin.BackColor = System.Drawing.Color.Transparent;
            this.TextDateBegin.BaseColor = System.Drawing.Color.White;
            this.TextDateBegin.BorderColor = System.Drawing.Color.Silver;
            this.TextDateBegin.BorderSize = 1;
            this.TextDateBegin.CustomFormat = null;
            this.TextDateBegin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TextDateBegin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateBegin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextDateBegin.ForeColor = System.Drawing.Color.Black;
            this.TextDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TextDateBegin.Location = new System.Drawing.Point(53, 113);
            this.TextDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.TextDateBegin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TextDateBegin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TextDateBegin.Name = "TextDateBegin";
            this.TextDateBegin.OnHoverBaseColor = System.Drawing.Color.White;
            this.TextDateBegin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateBegin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateBegin.OnPressedColor = System.Drawing.Color.Black;
            this.TextDateBegin.Size = new System.Drawing.Size(269, 37);
            this.TextDateBegin.TabIndex = 61;
            this.TextDateBegin.Text = "18/11/2020";
            this.TextDateBegin.Value = new System.DateTime(2020, 11, 18, 22, 34, 40, 388);
            // 
            // TextDateEnd
            // 
            this.TextDateEnd.BackColor = System.Drawing.Color.Transparent;
            this.TextDateEnd.BaseColor = System.Drawing.Color.White;
            this.TextDateEnd.BorderColor = System.Drawing.Color.Silver;
            this.TextDateEnd.BorderSize = 1;
            this.TextDateEnd.CustomFormat = null;
            this.TextDateEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TextDateEnd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextDateEnd.ForeColor = System.Drawing.Color.Black;
            this.TextDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TextDateEnd.Location = new System.Drawing.Point(376, 113);
            this.TextDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.TextDateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TextDateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TextDateEnd.Name = "TextDateEnd";
            this.TextDateEnd.OnHoverBaseColor = System.Drawing.Color.White;
            this.TextDateEnd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateEnd.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextDateEnd.OnPressedColor = System.Drawing.Color.Black;
            this.TextDateEnd.Size = new System.Drawing.Size(272, 37);
            this.TextDateEnd.TabIndex = 62;
            this.TextDateEnd.Text = "18/11/2020";
            this.TextDateEnd.Value = new System.DateTime(2020, 11, 18, 22, 34, 40, 388);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Rechercher la situation périodique d\'une opération";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(851, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 23);
            this.label5.TabIndex = 104;
            this.label5.Text = "Rechercher situation périodique du compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(331, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.TabIndex = 64;
            this.label2.Text = "Au";
            // 
            // textDate
            // 
            this.textDate.BackColor = System.Drawing.Color.Transparent;
            this.textDate.BaseColor = System.Drawing.Color.White;
            this.textDate.BorderColor = System.Drawing.Color.Silver;
            this.textDate.BorderSize = 1;
            this.textDate.CustomFormat = null;
            this.textDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.textDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDate.ForeColor = System.Drawing.Color.Black;
            this.textDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textDate.Location = new System.Drawing.Point(856, 113);
            this.textDate.Margin = new System.Windows.Forms.Padding(4);
            this.textDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.textDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.textDate.Name = "textDate";
            this.textDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.textDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textDate.OnPressedColor = System.Drawing.Color.Black;
            this.textDate.Size = new System.Drawing.Size(261, 37);
            this.textDate.TabIndex = 93;
            this.textDate.Text = "18/11/2020";
            this.textDate.Value = new System.DateTime(2020, 11, 18, 22, 34, 40, 388);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Animated = true;
            this.btnAfficher.AnimationHoverSpeed = 0.1F;
            this.btnAfficher.AnimationSpeed = 0.1F;
            this.btnAfficher.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAfficher.BorderColor = System.Drawing.Color.Black;
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAfficher.FocusedColor = System.Drawing.Color.Empty;
            this.btnAfficher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAfficher.ForeColor = System.Drawing.Color.White;
            this.btnAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher.Image")));
            this.btnAfficher.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAfficher.Location = new System.Drawing.Point(656, 111);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnAfficher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAfficher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAfficher.OnHoverImage = null;
            this.btnAfficher.OnPressedColor = System.Drawing.Color.Black;
            this.btnAfficher.Size = new System.Drawing.Size(167, 39);
            this.btnAfficher.TabIndex = 90;
            this.btnAfficher.Text = "Rechercher";
            this.btnAfficher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAfficher1
            // 
            this.btnAfficher1.Animated = true;
            this.btnAfficher1.AnimationHoverSpeed = 0.1F;
            this.btnAfficher1.AnimationSpeed = 0.1F;
            this.btnAfficher1.BackColor = System.Drawing.Color.Transparent;
            this.btnAfficher1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAfficher1.BorderColor = System.Drawing.Color.Black;
            this.btnAfficher1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAfficher1.FocusedColor = System.Drawing.Color.Empty;
            this.btnAfficher1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAfficher1.ForeColor = System.Drawing.Color.White;
            this.btnAfficher1.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficher1.Image")));
            this.btnAfficher1.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAfficher1.Location = new System.Drawing.Point(1125, 111);
            this.btnAfficher1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficher1.Name = "btnAfficher1";
            this.btnAfficher1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnAfficher1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAfficher1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAfficher1.OnHoverImage = null;
            this.btnAfficher1.OnPressedColor = System.Drawing.Color.Black;
            this.btnAfficher1.Size = new System.Drawing.Size(172, 39);
            this.btnAfficher1.TabIndex = 95;
            this.btnAfficher1.Text = "Rechercher";
            this.btnAfficher1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAfficher1.Click += new System.EventHandler(this.btnAfficher1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 91;
            this.label3.Text = "Du";
            // 
            // lbNumCompte
            // 
            this.lbNumCompte.AutoSize = true;
            this.lbNumCompte.ForeColor = System.Drawing.Color.Transparent;
            this.lbNumCompte.Location = new System.Drawing.Point(4, 5);
            this.lbNumCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumCompte.Name = "lbNumCompte";
            this.lbNumCompte.Size = new System.Drawing.Size(0, 17);
            this.lbNumCompte.TabIndex = 108;
            this.lbNumCompte.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.GpInfoCompte);
            this.guna2Panel2.Controls.Add(this.cbCompte);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel2.Location = new System.Drawing.Point(9, 34);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1630, 105);
            this.guna2Panel2.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 28);
            this.label4.TabIndex = 104;
            this.label4.Text = "Veuillez Sélectionner un compte dans la liste déroulante";
            // 
            // GpInfoCompte
            // 
            this.GpInfoCompte.Controls.Add(this.lbSolde);
            this.GpInfoCompte.Controls.Add(this.label7);
            this.GpInfoCompte.Controls.Add(this.lbCompte);
            this.GpInfoCompte.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpInfoCompte.Location = new System.Drawing.Point(688, 16);
            this.GpInfoCompte.Margin = new System.Windows.Forms.Padding(4);
            this.GpInfoCompte.Name = "GpInfoCompte";
            this.GpInfoCompte.Padding = new System.Windows.Forms.Padding(4);
            this.GpInfoCompte.Size = new System.Drawing.Size(925, 71);
            this.GpInfoCompte.TabIndex = 107;
            this.GpInfoCompte.TabStop = false;
            this.GpInfoCompte.Text = "Vous êtes dans le compte";
            this.GpInfoCompte.Visible = false;
            // 
            // lbSolde
            // 
            this.lbSolde.AutoSize = true;
            this.lbSolde.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolde.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbSolde.Location = new System.Drawing.Point(476, 23);
            this.lbSolde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSolde.Name = "lbSolde";
            this.lbSolde.Size = new System.Drawing.Size(83, 35);
            this.lbSolde.TabIndex = 107;
            this.lbSolde.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(384, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 106;
            this.label7.Text = "SOLDE :";
            // 
            // lbCompte
            // 
            this.lbCompte.AutoSize = true;
            this.lbCompte.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompte.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbCompte.Location = new System.Drawing.Point(8, 27);
            this.lbCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompte.Name = "lbCompte";
            this.lbCompte.Size = new System.Drawing.Size(314, 37);
            this.lbCompte.TabIndex = 105;
            this.lbCompte.Text = "Compte sélectionné......";
            // 
            // cbCompte
            // 
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
            this.cbCompte.Location = new System.Drawing.Point(7, 49);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompte.Name = "cbCompte";
            this.cbCompte.ShadowDecoration.Parent = this.cbCompte;
            this.cbCompte.Size = new System.Drawing.Size(672, 36);
            this.cbCompte.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCompte.TabIndex = 105;
            this.cbCompte.SelectedIndexChanged += new System.EventHandler(this.cbCompte_SelectedIndexChanged);
            // 
            // PanelAction
            // 
            this.PanelAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAction.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelAction.Controls.Add(this.groupBox2);
            this.PanelAction.CustomBorderColor = System.Drawing.Color.Silver;
            this.PanelAction.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PanelAction.Location = new System.Drawing.Point(9, 146);
            this.PanelAction.Margin = new System.Windows.Forms.Padding(4);
            this.PanelAction.Name = "PanelAction";
            this.PanelAction.ShadowDecoration.Parent = this.PanelAction;
            this.PanelAction.Size = new System.Drawing.Size(1630, 134);
            this.PanelAction.TabIndex = 111;
            this.PanelAction.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEntree);
            this.groupBox2.Controls.Add(this.btnSortie);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(702, 112);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veuillez choisir une situation que vous voulez afficher";
            // 
            // btnEntree
            // 
            this.btnEntree.Animated = true;
            this.btnEntree.AnimationHoverSpeed = 0.1F;
            this.btnEntree.AnimationSpeed = 0.1F;
            this.btnEntree.BackColor = System.Drawing.Color.Transparent;
            this.btnEntree.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnEntree.BorderColor = System.Drawing.Color.Black;
            this.btnEntree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntree.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntree.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntree.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEntree.ForeColor = System.Drawing.Color.White;
            this.btnEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnEntree.Image")));
            this.btnEntree.ImageOffsetX = 15;
            this.btnEntree.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntree.Location = new System.Drawing.Point(15, 30);
            this.btnEntree.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntree.Name = "btnEntree";
            this.btnEntree.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnEntree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntree.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntree.OnHoverImage = null;
            this.btnEntree.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntree.Size = new System.Drawing.Size(333, 63);
            this.btnEntree.TabIndex = 89;
            this.btnEntree.Text = "SITUATION SUR LES ENTREES";
            this.btnEntree.Click += new System.EventHandler(this.btnEntree_Click);
            // 
            // btnSortie
            // 
            this.btnSortie.Animated = true;
            this.btnSortie.AnimationHoverSpeed = 0.1F;
            this.btnSortie.AnimationSpeed = 0.1F;
            this.btnSortie.BackColor = System.Drawing.Color.Transparent;
            this.btnSortie.BaseColor = System.Drawing.Color.LightCoral;
            this.btnSortie.BorderColor = System.Drawing.Color.Black;
            this.btnSortie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSortie.FocusedColor = System.Drawing.Color.Empty;
            this.btnSortie.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSortie.ForeColor = System.Drawing.Color.White;
            this.btnSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnSortie.Image")));
            this.btnSortie.ImageOffsetX = 15;
            this.btnSortie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSortie.Location = new System.Drawing.Point(356, 30);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSortie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSortie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSortie.OnHoverImage = null;
            this.btnSortie.OnPressedColor = System.Drawing.Color.Black;
            this.btnSortie.Size = new System.Drawing.Size(333, 63);
            this.btnSortie.TabIndex = 90;
            this.btnSortie.Text = "SITUATION SUR LES SORTIES";
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // labelTitleSolde
            // 
            this.labelTitleSolde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleSolde.AutoSize = true;
            this.labelTitleSolde.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSolde.ForeColor = System.Drawing.Color.Black;
            this.labelTitleSolde.Location = new System.Drawing.Point(1157, 10);
            this.labelTitleSolde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleSolde.Name = "labelTitleSolde";
            this.labelTitleSolde.Size = new System.Drawing.Size(144, 23);
            this.labelTitleSolde.TabIndex = 115;
            this.labelTitleSolde.Text = "Solde des Entrées";
            this.labelTitleSolde.Visible = false;
            // 
            // labelSolde
            // 
            this.labelSolde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSolde.AutoSize = true;
            this.labelSolde.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolde.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelSolde.Location = new System.Drawing.Point(1186, 35);
            this.labelSolde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(83, 35);
            this.labelSolde.TabIndex = 116;
            this.labelSolde.Text = "00.00";
            this.labelSolde.Visible = false;
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
            this.Column4.HeaderText = "DESIGNATION";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TYPE";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MONTANT";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OBSERVATION";
            this.Column8.MinimumWidth = 7;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FormTirage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1701, 743);
            this.Controls.Add(this.GpOwner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTirage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "TIRAGE";
            this.GpOwner.ResumeLayout(false);
            this.GpOwner.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTirage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.GpInfoCompte.ResumeLayout(false);
            this.GpInfoCompte.PerformLayout();
            this.PanelAction.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaGroupBox GpOwner;
        public Guna.UI.WinForms.GunaButton btnSortie;
        public Guna.UI.WinForms.GunaButton btnEntree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker TextDateEnd;
        private Guna.UI.WinForms.GunaDateTimePicker TextDateBegin;
        public Guna.UI.WinForms.GunaButton btnAfficher;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaButton btnAfficher1;
        private Guna.UI.WinForms.GunaDateTimePicker textDate;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox cbCompte;
        private System.Windows.Forms.GroupBox GpInfoCompte;
        private System.Windows.Forms.Label lbSolde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaDataGridView DGVTirage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel PanelAction;
        private System.Windows.Forms.Label lbNumCompte;
        private Guna.UI2.WinForms.Guna2Panel PanelInfo;
        private System.Windows.Forms.Label lbSelectInfo;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Label labelTitleSolde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}