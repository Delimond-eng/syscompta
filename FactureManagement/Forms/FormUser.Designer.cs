namespace FactureManagement.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbProfil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnRegister = new Guna.UI.WinForms.GunaButton();
            this.TextPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaShadowPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.Controls.Add(this.panel1);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(39, 78);
            this.gunaShadowPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Padding = new System.Windows.Forms.Padding(7, 4, 7, 6);
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowDepth = 150;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(1147, 430);
            this.gunaShadowPanel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.cbProfil);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.TextPwd);
            this.panel1.Controls.Add(this.TextUsername);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 420);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel3.Location = new System.Drawing.Point(63, 35);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(168, 25);
            this.gunaLabel3.TabIndex = 74;
            this.gunaLabel3.Text = "Nom d\'utilisateur";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(63, 122);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel1.TabIndex = 73;
            this.gunaLabel1.Text = "Mot de passe";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(66, 217);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(155, 25);
            this.gunaLabel2.TabIndex = 72;
            this.gunaLabel2.Text = "Profil utilisateur";
            // 
            // cbProfil
            // 
            this.cbProfil.Animated = true;
            this.cbProfil.BackColor = System.Drawing.Color.Transparent;
            this.cbProfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cbProfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfil.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbProfil.FocusedColor = System.Drawing.Color.Empty;
            this.cbProfil.FocusedState.Parent = this.cbProfil;
            this.cbProfil.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProfil.FormattingEnabled = true;
            this.cbProfil.HoverState.FillColor = System.Drawing.Color.White;
            this.cbProfil.HoverState.Parent = this.cbProfil;
            this.cbProfil.ItemHeight = 30;
            this.cbProfil.Items.AddRange(new object[] {
            "Administrateur",
            "Caissier"});
            this.cbProfil.ItemsAppearance.Parent = this.cbProfil;
            this.cbProfil.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.cbProfil.Location = new System.Drawing.Point(61, 251);
            this.cbProfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProfil.Name = "cbProfil";
            this.cbProfil.ShadowDecoration.Parent = this.cbProfil;
            this.cbProfil.Size = new System.Drawing.Size(630, 36);
            this.cbProfil.TabIndex = 71;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimationHoverSpeed = 0.1F;
            this.btnCancel.AnimationSpeed = 0.1F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Gray;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(386, 312);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(305, 54);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "ANNULER";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.Animated = true;
            this.btnRegister.AnimationHoverSpeed = 0.1F;
            this.btnRegister.AnimationSpeed = 0.1F;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnRegister.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = null;
            this.btnRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegister.Location = new System.Drawing.Point(61, 312);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnHoverBaseColor = System.Drawing.Color.SkyBlue;
            this.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegister.OnHoverImage = null;
            this.btnRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegister.Size = new System.Drawing.Size(305, 54);
            this.btnRegister.TabIndex = 63;
            this.btnRegister.Text = "CREER";
            this.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // TextPwd
            // 
            this.TextPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPwd.Animated = true;
            this.TextPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TextPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPwd.DefaultText = "";
            this.TextPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPwd.DisabledState.Parent = this.TextPwd;
            this.TextPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextPwd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPwd.FocusedState.Parent = this.TextPwd;
            this.TextPwd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextPwd.HoverState.Parent = this.TextPwd;
            this.TextPwd.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextPwd.IconLeft")));
            this.TextPwd.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextPwd.Location = new System.Drawing.Point(61, 153);
            this.TextPwd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '\0';
            this.TextPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPwd.PlaceholderText = "Entrez votre mot de passe...";
            this.TextPwd.SelectedText = "";
            this.TextPwd.ShadowDecoration.Parent = this.TextPwd;
            this.TextPwd.Size = new System.Drawing.Size(1038, 44);
            this.TextPwd.TabIndex = 58;
            this.TextPwd.UseSystemPasswordChar = true;
            // 
            // TextUsername
            // 
            this.TextUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextUsername.Animated = true;
            this.TextUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TextUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextUsername.DefaultText = "";
            this.TextUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUsername.DisabledState.Parent = this.TextUsername;
            this.TextUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextUsername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextUsername.FocusedState.Parent = this.TextUsername;
            this.TextUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextUsername.HoverState.Parent = this.TextUsername;
            this.TextUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextUsername.IconLeft")));
            this.TextUsername.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextUsername.Location = new System.Drawing.Point(61, 69);
            this.TextUsername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.PasswordChar = '\0';
            this.TextUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextUsername.PlaceholderText = "Entrez le nom d\'utilisateur...";
            this.TextUsername.SelectedText = "";
            this.TextUsername.ShadowDecoration.Parent = this.TextUsername;
            this.TextUsername.Size = new System.Drawing.Size(1038, 44);
            this.TextUsername.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 408);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 12);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 12);
            this.panel2.TabIndex = 0;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormUser";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "UTILISATEUR";
            this.gunaShadowPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaButton btnCancel;
        public Guna.UI.WinForms.GunaButton btnRegister;
        public Guna.UI2.WinForms.Guna2TextBox TextPwd;
        public Guna.UI2.WinForms.Guna2TextBox TextUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2ComboBox cbProfil;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}