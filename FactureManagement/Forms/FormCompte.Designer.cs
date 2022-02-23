namespace FactureManagement.Forms
{
    partial class FormCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompte));
            this.GpOwner = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbDevise = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TextDepot = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnregistrer = new Guna.UI.WinForms.GunaButton();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextIntitule = new Guna.UI2.WinForms.Guna2TextBox();
            this.GpOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpOwner
            // 
            this.GpOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpOwner.BackColor = System.Drawing.Color.Transparent;
            this.GpOwner.BaseColor = System.Drawing.Color.White;
            this.GpOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.BorderSize = 1;
            this.GpOwner.Controls.Add(this.gunaLabel4);
            this.GpOwner.Controls.Add(this.cbDevise);
            this.GpOwner.Controls.Add(this.gunaLabel3);
            this.GpOwner.Controls.Add(this.TextDepot);
            this.GpOwner.Controls.Add(this.btnEnregistrer);
            this.GpOwner.Controls.Add(this.btnAnnuler);
            this.GpOwner.Controls.Add(this.gunaLabel2);
            this.GpOwner.Controls.Add(this.TextIntitule);
            this.GpOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GpOwner.LineBottom = 30;
            this.GpOwner.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GpOwner.Location = new System.Drawing.Point(27, 74);
            this.GpOwner.Margin = new System.Windows.Forms.Padding(4);
            this.GpOwner.Name = "GpOwner";
            this.GpOwner.Size = new System.Drawing.Size(1601, 298);
            this.GpOwner.TabIndex = 12;
            this.GpOwner.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(803, 146);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 21);
            this.gunaLabel4.TabIndex = 71;
            this.gunaLabel4.Text = "Devise";
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
            this.cbDevise.Location = new System.Drawing.Point(804, 176);
            this.cbDevise.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevise.Name = "cbDevise";
            this.cbDevise.ShadowDecoration.Parent = this.cbDevise;
            this.cbDevise.Size = new System.Drawing.Size(129, 36);
            this.cbDevise.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevise.TabIndex = 70;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(11, 145);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(117, 21);
            this.gunaLabel3.TabIndex = 31;
            this.gunaLabel3.Text = "Depôt initial *";
            // 
            // TextDepot
            // 
            this.TextDepot.Animated = true;
            this.TextDepot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextDepot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextDepot.DefaultText = "";
            this.TextDepot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextDepot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextDepot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextDepot.DisabledState.Parent = this.TextDepot;
            this.TextDepot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextDepot.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextDepot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextDepot.FocusedState.Parent = this.TextDepot;
            this.TextDepot.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextDepot.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextDepot.HoverState.Parent = this.TextDepot;
            this.TextDepot.Location = new System.Drawing.Point(16, 176);
            this.TextDepot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextDepot.Name = "TextDepot";
            this.TextDepot.PasswordChar = '\0';
            this.TextDepot.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextDepot.PlaceholderText = "Entrez le depôt initial... ex.100";
            this.TextDepot.SelectedText = "";
            this.TextDepot.ShadowDecoration.Parent = this.TextDepot;
            this.TextDepot.Size = new System.Drawing.Size(779, 44);
            this.TextDepot.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextDepot.TabIndex = 30;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Animated = true;
            this.btnEnregistrer.AnimationHoverSpeed = 0.1F;
            this.btnEnregistrer.AnimationSpeed = 0.1F;
            this.btnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnEnregistrer.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnregistrer.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("btnEnregistrer.Image")));
            this.btnEnregistrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnregistrer.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEnregistrer.Location = new System.Drawing.Point(947, 166);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.btnEnregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.OnHoverImage = null;
            this.btnEnregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Size = new System.Drawing.Size(228, 54);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "CREER";
            this.btnEnregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
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
            this.btnAnnuler.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnnuler.Location = new System.Drawing.Point(1191, 166);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(228, 54);
            this.btnAnnuler.TabIndex = 26;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(11, 60);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(163, 21);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Intitulé du compte *";
            // 
            // TextIntitule
            // 
            this.TextIntitule.Animated = true;
            this.TextIntitule.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.TextIntitule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextIntitule.DefaultText = "";
            this.TextIntitule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextIntitule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextIntitule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIntitule.DisabledState.Parent = this.TextIntitule;
            this.TextIntitule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextIntitule.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextIntitule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIntitule.FocusedState.Parent = this.TextIntitule;
            this.TextIntitule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIntitule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextIntitule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextIntitule.HoverState.Parent = this.TextIntitule;
            this.TextIntitule.Location = new System.Drawing.Point(16, 91);
            this.TextIntitule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextIntitule.Name = "TextIntitule";
            this.TextIntitule.PasswordChar = '\0';
            this.TextIntitule.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextIntitule.PlaceholderText = "Entrez l\'intitulé du compte...";
            this.TextIntitule.SelectedText = "";
            this.TextIntitule.ShadowDecoration.Parent = this.TextIntitule;
            this.TextIntitule.Size = new System.Drawing.Size(920, 44);
            this.TextIntitule.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextIntitule.TabIndex = 11;
            // 
            // FormCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1655, 705);
            this.Controls.Add(this.GpOwner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormCompte";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "COMPTE DE TRESORIE";
            this.GpOwner.ResumeLayout(false);
            this.GpOwner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaGroupBox GpOwner;
        private Guna.UI.WinForms.GunaButton btnEnregistrer;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox TextIntitule;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI2.WinForms.Guna2TextBox TextDepot;
        public Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI2.WinForms.Guna2ComboBox cbDevise;
    }
}