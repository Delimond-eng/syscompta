namespace FactureManagement.Forms
{
    partial class FormOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GpOwner = new Guna.UI.WinForms.GunaGroupBox();
            this.GpWrite = new Guna.UI.WinForms.GunaGroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIntitule = new Guna.UI.WinForms.GunaLabel();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.btnValider = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.TextObs = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbDevise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TextMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextDesign = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.GpAction = new System.Windows.Forms.GroupBox();
            this.btnEntree = new Guna.UI.WinForms.GunaButton();
            this.btnSortie = new Guna.UI.WinForms.GunaButton();
            this.cbCompte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumCompte = new Guna.UI.WinForms.GunaLabel();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.DGVTirage = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpOwner.SuspendLayout();
            this.GpWrite.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.GpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTirage)).BeginInit();
            this.SuspendLayout();
            // 
            // GpOwner
            // 
            this.GpOwner.BackColor = System.Drawing.Color.Transparent;
            this.GpOwner.BaseColor = System.Drawing.Color.White;
            this.GpOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.BorderSize = 1;
            this.GpOwner.Controls.Add(this.GpWrite);
            this.GpOwner.Controls.Add(this.gunaShadowPanel1);
            this.GpOwner.Controls.Add(this.guna2ResizeBox1);
            this.GpOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GpOwner.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.LineTop = 25;
            this.GpOwner.Location = new System.Drawing.Point(27, 74);
            this.GpOwner.Margin = new System.Windows.Forms.Padding(4);
            this.GpOwner.Name = "GpOwner";
            this.GpOwner.Size = new System.Drawing.Size(1593, 785);
            this.GpOwner.TabIndex = 12;
            this.GpOwner.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // GpWrite
            // 
            this.GpWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpWrite.BackColor = System.Drawing.Color.Transparent;
            this.GpWrite.BaseColor = System.Drawing.Color.White;
            this.GpWrite.BorderColor = System.Drawing.Color.Gainsboro;
            this.GpWrite.BorderSize = 1;
            this.GpWrite.Controls.Add(this.DGVTirage);
            this.GpWrite.Controls.Add(this.groupBox1);
            this.GpWrite.Controls.Add(this.btnAnnuler);
            this.GpWrite.Controls.Add(this.btnValider);
            this.GpWrite.Controls.Add(this.gunaLabel6);
            this.GpWrite.Controls.Add(this.TextObs);
            this.GpWrite.Controls.Add(this.gunaLabel4);
            this.GpWrite.Controls.Add(this.cbDevise);
            this.GpWrite.Controls.Add(this.gunaLabel3);
            this.GpWrite.Controls.Add(this.TextMontant);
            this.GpWrite.Controls.Add(this.gunaLabel2);
            this.GpWrite.Controls.Add(this.TextDesign);
            this.GpWrite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpWrite.LineColor = System.Drawing.Color.Gainsboro;
            this.GpWrite.Location = new System.Drawing.Point(4, 170);
            this.GpWrite.Margin = new System.Windows.Forms.Padding(4);
            this.GpWrite.Name = "GpWrite";
            this.GpWrite.Size = new System.Drawing.Size(1585, 612);
            this.GpWrite.TabIndex = 25;
            this.GpWrite.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIntitule);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(245, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1095, 74);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vous êtes dans le compte";
            // 
            // lbIntitule
            // 
            this.lbIntitule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIntitule.AutoSize = true;
            this.lbIntitule.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbIntitule.ForeColor = System.Drawing.Color.Gray;
            this.lbIntitule.Location = new System.Drawing.Point(386, 20);
            this.lbIntitule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntitule.Name = "lbIntitule";
            this.lbIntitule.Size = new System.Drawing.Size(339, 46);
            this.lbIntitule.TabIndex = 84;
            this.lbIntitule.Text = "Compte Sélectionné";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnAnnuler.ImageOffsetX = 15;
            this.btnAnnuler.ImageSize = new System.Drawing.Size(18, 18);
            this.btnAnnuler.Location = new System.Drawing.Point(817, 342);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(255, 46);
            this.btnAnnuler.TabIndex = 90;
            this.btnAnnuler.Text = "Annuler l\'opération";
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnValider.Animated = true;
            this.btnValider.AnimationHoverSpeed = 0.1F;
            this.btnValider.AnimationSpeed = 0.1F;
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnValider.BorderColor = System.Drawing.Color.Black;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValider.FocusedColor = System.Drawing.Color.Empty;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Image = ((System.Drawing.Image)(resources.GetObject("btnValider.Image")));
            this.btnValider.ImageOffsetX = 15;
            this.btnValider.ImageSize = new System.Drawing.Size(20, 20);
            this.btnValider.Location = new System.Drawing.Point(529, 341);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnValider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnValider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnValider.OnHoverImage = null;
            this.btnValider.OnPressedColor = System.Drawing.Color.Black;
            this.btnValider.Size = new System.Drawing.Size(265, 46);
            this.btnValider.TabIndex = 89;
            this.btnValider.Text = "Valider l\'opération";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel6.Location = new System.Drawing.Point(13, 256);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(276, 25);
            this.gunaLabel6.TabIndex = 88;
            this.gunaLabel6.Text = "Observation (saisie facultative)";
            // 
            // TextObs
            // 
            this.TextObs.Animated = true;
            this.TextObs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextObs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextObs.DefaultText = "";
            this.TextObs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextObs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextObs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextObs.DisabledState.Parent = this.TextObs;
            this.TextObs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextObs.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextObs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextObs.FocusedState.Parent = this.TextObs;
            this.TextObs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextObs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextObs.HoverState.Parent = this.TextObs;
            this.TextObs.Location = new System.Drawing.Point(19, 286);
            this.TextObs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextObs.Name = "TextObs";
            this.TextObs.PasswordChar = '\0';
            this.TextObs.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextObs.PlaceholderText = "Entrez la désignation ou le motif...";
            this.TextObs.SelectedText = "";
            this.TextObs.ShadowDecoration.Parent = this.TextObs;
            this.TextObs.Size = new System.Drawing.Size(1053, 44);
            this.TextObs.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextObs.TabIndex = 87;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(803, 174);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel4.TabIndex = 79;
            this.gunaLabel4.Text = "Devise *";
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
            this.cbDevise.Location = new System.Drawing.Point(808, 208);
            this.cbDevise.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevise.Name = "cbDevise";
            this.cbDevise.ShadowDecoration.Parent = this.cbDevise;
            this.cbDevise.Size = new System.Drawing.Size(129, 36);
            this.cbDevise.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevise.TabIndex = 78;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(13, 177);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(100, 25);
            this.gunaLabel3.TabIndex = 77;
            this.gunaLabel3.Text = "Montant *";
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
            this.TextMontant.Location = new System.Drawing.Point(19, 208);
            this.TextMontant.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextMontant.Name = "TextMontant";
            this.TextMontant.PasswordChar = '\0';
            this.TextMontant.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextMontant.PlaceholderText = "Entrez le montant... ex.100";
            this.TextMontant.SelectedText = "";
            this.TextMontant.ShadowDecoration.Parent = this.TextMontant;
            this.TextMontant.Size = new System.Drawing.Size(779, 44);
            this.TextMontant.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextMontant.TabIndex = 76;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(13, 96);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(194, 25);
            this.gunaLabel2.TabIndex = 73;
            this.gunaLabel2.Text = "Désignation / Motif *";
            // 
            // TextDesign
            // 
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
            this.TextDesign.Location = new System.Drawing.Point(19, 127);
            this.TextDesign.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextDesign.Name = "TextDesign";
            this.TextDesign.PasswordChar = '\0';
            this.TextDesign.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextDesign.PlaceholderText = "Entrez la désignation ou le motif...";
            this.TextDesign.SelectedText = "";
            this.TextDesign.ShadowDecoration.Parent = this.TextDesign;
            this.TextDesign.Size = new System.Drawing.Size(1053, 44);
            this.TextDesign.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextDesign.TabIndex = 72;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(4, 32);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Padding = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 40;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1585, 130);
            this.gunaShadowPanel1.TabIndex = 24;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.GpAction);
            this.gunaGroupBox1.Controls.Add(this.cbCompte);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.lbNumCompte);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineTop = 0;
            this.gunaGroupBox1.Location = new System.Drawing.Point(4, 1);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1577, 127);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // GpAction
            // 
            this.GpAction.Controls.Add(this.btnEntree);
            this.GpAction.Controls.Add(this.btnSortie);
            this.GpAction.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpAction.Location = new System.Drawing.Point(651, 4);
            this.GpAction.Margin = new System.Windows.Forms.Padding(4);
            this.GpAction.Name = "GpAction";
            this.GpAction.Padding = new System.Windows.Forms.Padding(4);
            this.GpAction.Size = new System.Drawing.Size(752, 112);
            this.GpAction.TabIndex = 109;
            this.GpAction.TabStop = false;
            this.GpAction.Text = "Veuillez choisir l\'opération que vous voulez effectuer";
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
            this.btnEntree.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnEntree.ForeColor = System.Drawing.Color.White;
            this.btnEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnEntree.Image")));
            this.btnEntree.ImageOffsetX = 15;
            this.btnEntree.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntree.Location = new System.Drawing.Point(31, 32);
            this.btnEntree.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntree.Name = "btnEntree";
            this.btnEntree.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnEntree.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntree.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntree.OnHoverImage = null;
            this.btnEntree.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntree.Size = new System.Drawing.Size(341, 63);
            this.btnEntree.TabIndex = 89;
            this.btnEntree.Text = "ENTREE";
            this.btnEntree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntree.Click += new System.EventHandler(this.btnEntree_Click_1);
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
            this.btnSortie.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnSortie.ForeColor = System.Drawing.Color.White;
            this.btnSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnSortie.Image")));
            this.btnSortie.ImageOffsetX = 15;
            this.btnSortie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSortie.Location = new System.Drawing.Point(380, 32);
            this.btnSortie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSortie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSortie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSortie.OnHoverImage = null;
            this.btnSortie.OnPressedColor = System.Drawing.Color.Black;
            this.btnSortie.Size = new System.Drawing.Size(341, 63);
            this.btnSortie.TabIndex = 90;
            this.btnSortie.Text = "SORTIE";
            this.btnSortie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click_1);
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
            this.cbCompte.Location = new System.Drawing.Point(7, 69);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompte.Name = "cbCompte";
            this.cbCompte.ShadowDecoration.Parent = this.cbCompte;
            this.cbCompte.Size = new System.Drawing.Size(635, 36);
            this.cbCompte.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCompte.TabIndex = 107;
            this.cbCompte.SelectedIndexChanged += new System.EventHandler(this.cbCompte_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 28);
            this.label4.TabIndex = 106;
            this.label4.Text = "Veuillez sélectionner un compte pour effectuer une opération";
            // 
            // lbNumCompte
            // 
            this.lbNumCompte.AutoSize = true;
            this.lbNumCompte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbNumCompte.ForeColor = System.Drawing.Color.White;
            this.lbNumCompte.Location = new System.Drawing.Point(296, 39);
            this.lbNumCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumCompte.Name = "lbNumCompte";
            this.lbNumCompte.Size = new System.Drawing.Size(0, 25);
            this.lbNumCompte.TabIndex = 83;
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Empty;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(1567, 761);
            this.guna2ResizeBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(27, 25);
            this.guna2ResizeBox1.TabIndex = 18;
            this.guna2ResizeBox1.TargetControl = this.GpOwner;
            // 
            // DGVTirage
            // 
            this.DGVTirage.AllowUserToResizeColumns = false;
            this.DGVTirage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGVTirage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTirage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTirage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTirage.BackgroundColor = System.Drawing.Color.White;
            this.DGVTirage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTirage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTirage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTirage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVTirage.ColumnHeadersHeight = 60;
            this.DGVTirage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column3,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTirage.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTirage.EnableHeadersVisualStyles = false;
            this.DGVTirage.GridColor = System.Drawing.Color.DimGray;
            this.DGVTirage.Location = new System.Drawing.Point(0, 419);
            this.DGVTirage.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTirage.Name = "DGVTirage";
            this.DGVTirage.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTirage.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTirage.RowHeadersVisible = false;
            this.DGVTirage.RowHeadersWidth = 57;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVTirage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVTirage.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.RowTemplate.Height = 50;
            this.DGVTirage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTirage.Size = new System.Drawing.Size(1581, 189);
            this.DGVTirage.TabIndex = 111;
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
            this.DGVTirage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTirage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVTirage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTirage.ThemeStyle.HeaderStyle.Height = 60;
            this.DGVTirage.ThemeStyle.ReadOnly = true;
            this.DGVTirage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTirage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTirage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTirage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVTirage.ThemeStyle.RowsStyle.Height = 50;
            this.DGVTirage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            this.DGVTirage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "n°";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DESIGNATION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "MONTANT";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SOLDE";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OBSERVATION";
            this.Column8.MinimumWidth = 7;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 884);
            this.Controls.Add(this.GpOwner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormOperation";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "OPERATION SUR LES COMPTES";
            this.GpOwner.ResumeLayout(false);
            this.GpWrite.ResumeLayout(false);
            this.GpWrite.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.GpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTirage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaGroupBox GpOwner;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox GpWrite;
        public Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI2.WinForms.Guna2ComboBox cbDevise;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI2.WinForms.Guna2TextBox TextMontant;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox TextDesign;
        public Guna.UI.WinForms.GunaLabel lbIntitule;
        public Guna.UI.WinForms.GunaLabel lbNumCompte;
        public Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI2.WinForms.Guna2TextBox TextObs;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        public Guna.UI.WinForms.GunaButton btnValider;
        public Guna.UI2.WinForms.Guna2ComboBox cbCompte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GpAction;
        public Guna.UI.WinForms.GunaButton btnEntree;
        public Guna.UI.WinForms.GunaButton btnSortie;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaDataGridView DGVTirage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}