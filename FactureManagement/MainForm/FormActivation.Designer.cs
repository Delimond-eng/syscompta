namespace FactureManagement.MainForm
{
    partial class FormActivation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivation));
            this.TextActivation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TextActivation
            // 
            this.TextActivation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TextActivation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextActivation.DefaultText = "";
            this.TextActivation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextActivation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextActivation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextActivation.DisabledState.Parent = this.TextActivation;
            this.TextActivation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextActivation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextActivation.FocusedState.Parent = this.TextActivation;
            this.TextActivation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextActivation.HoverState.Parent = this.TextActivation;
            this.TextActivation.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextActivation.IconLeft")));
            this.TextActivation.Location = new System.Drawing.Point(23, 74);
            this.TextActivation.Name = "TextActivation";
            this.TextActivation.PasswordChar = '\0';
            this.TextActivation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextActivation.PlaceholderText = "Entrer le code d\'activation...";
            this.TextActivation.SelectedText = "";
            this.TextActivation.ShadowDecoration.Parent = this.TextActivation;
            this.TextActivation.Size = new System.Drawing.Size(464, 38);
            this.TextActivation.TabIndex = 0;
            // 
            // btnActivate
            // 
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(23, 127);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.Size = new System.Drawing.Size(464, 42);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "ACTIVER";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // FormActivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 202);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.TextActivation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormActivation";
            this.Resizable = false;
            this.Text = "ACTIVATION";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextActivation;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
    }
}