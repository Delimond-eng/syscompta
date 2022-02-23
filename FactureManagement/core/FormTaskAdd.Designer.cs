namespace FactureManagement.core
{
    partial class FormTaskAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDesignTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.inputTime = new System.Windows.Forms.MaskedTextBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Désignation de la Tâche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(327, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure";
            // 
            // inputDesignTask
            // 
            this.inputDesignTask.Animated = true;
            this.inputDesignTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.inputDesignTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDesignTask.DefaultText = "";
            this.inputDesignTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputDesignTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputDesignTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDesignTask.DisabledState.Parent = this.inputDesignTask;
            this.inputDesignTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDesignTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDesignTask.FocusedState.Parent = this.inputDesignTask;
            this.inputDesignTask.ForeColor = System.Drawing.Color.Black;
            this.inputDesignTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDesignTask.HoverState.Parent = this.inputDesignTask;
            this.inputDesignTask.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputDesignTask.IconLeft")));
            this.inputDesignTask.Location = new System.Drawing.Point(27, 105);
            this.inputDesignTask.Name = "inputDesignTask";
            this.inputDesignTask.PasswordChar = '\0';
            this.inputDesignTask.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.inputDesignTask.PlaceholderText = "Entrez la désignation de la  tâche";
            this.inputDesignTask.SelectedText = "";
            this.inputDesignTask.ShadowDecoration.Enabled = true;
            this.inputDesignTask.ShadowDecoration.Parent = this.inputDesignTask;
            this.inputDesignTask.Size = new System.Drawing.Size(747, 36);
            this.inputDesignTask.TabIndex = 3;
            // 
            // inputDate
            // 
            this.inputDate.CheckedState.Parent = this.inputDate;
            this.inputDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(240)))));
            this.inputDate.ForeColor = System.Drawing.Color.Black;
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputDate.HoverState.Parent = this.inputDate;
            this.inputDate.Location = new System.Drawing.Point(23, 180);
            this.inputDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inputDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inputDate.Name = "inputDate";
            this.inputDate.ShadowDecoration.Parent = this.inputDate;
            this.inputDate.Size = new System.Drawing.Size(298, 36);
            this.inputDate.TabIndex = 4;
            this.inputDate.Value = new System.DateTime(2021, 1, 14, 14, 37, 46, 432);
            // 
            // inputTime
            // 
            this.inputTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(240)))));
            this.inputTime.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.inputTime.ForeColor = System.Drawing.Color.Black;
            this.inputTime.Location = new System.Drawing.Point(327, 180);
            this.inputTime.Mask = "00:00";
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(117, 36);
            this.inputTime.TabIndex = 5;
            this.inputTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(215)))), ((int)(((byte)(139)))));
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(23, 244);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(164, 35);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "CREER TACHE";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 302);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.inputDesignTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaskAdd";
            this.Resizable = false;
            this.Text = "Ajout d\'une Tâche";
            this.Load += new System.EventHandler(this.FormTaskAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox inputDesignTask;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputDate;
        private System.Windows.Forms.MaskedTextBox inputTime;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
    }
}