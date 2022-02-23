namespace FactureManagement.core
{
    partial class TaskCard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDateTask = new System.Windows.Forms.Label();
            this.lbHoureTask = new System.Windows.Forms.Label();
            this.btnCompleted = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbDesignTask = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedTask = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.guna2Panel1);
            this.guna2ShadowPanel2.Controls.Add(this.btnCompleted);
            this.guna2ShadowPanel2.Controls.Add(this.btnDelete);
            this.guna2ShadowPanel2.Controls.Add(this.checkedTask);
            this.guna2ShadowPanel2.Controls.Add(this.lbDesignTask);
            this.guna2ShadowPanel2.Controls.Add(this.label5);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.EdgeWidth = 50;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 10;
            this.guna2ShadowPanel2.ShadowShift = 4;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1440, 79);
            this.guna2ShadowPanel2.TabIndex = 94;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lbId);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lbDateTask);
            this.guna2Panel1.Controls.Add(this.lbHoureTask);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(229)))), ((int)(((byte)(240)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(324, 69);
            this.guna2Panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date :";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbId.Location = new System.Drawing.Point(21, 1);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(50, 23);
            this.lbId.TabIndex = 21;
            this.lbId.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Heure :";
            // 
            // lbDateTask
            // 
            this.lbDateTask.AutoSize = true;
            this.lbDateTask.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lbDateTask.ForeColor = System.Drawing.Color.Black;
            this.lbDateTask.Location = new System.Drawing.Point(96, 7);
            this.lbDateTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateTask.Name = "lbDateTask";
            this.lbDateTask.Size = new System.Drawing.Size(139, 23);
            this.lbDateTask.TabIndex = 10;
            this.lbDateTask.Text = "17 janvier  2021";
            // 
            // lbHoureTask
            // 
            this.lbHoureTask.AutoSize = true;
            this.lbHoureTask.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lbHoureTask.ForeColor = System.Drawing.Color.Black;
            this.lbHoureTask.Location = new System.Drawing.Point(107, 36);
            this.lbHoureTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoureTask.Name = "lbHoureTask";
            this.lbHoureTask.Size = new System.Drawing.Size(55, 23);
            this.lbHoureTask.TabIndex = 11;
            this.lbHoureTask.Text = "00:00";
            // 
            // btnCompleted
            // 
            this.btnCompleted.CheckedState.Parent = this.btnCompleted;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.CustomImages.Parent = this.btnCompleted;
            this.btnCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(223)))));
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCompleted.HoverState.Parent = this.btnCompleted;
            this.btnCompleted.Image = ((System.Drawing.Image)(resources.GetObject("btnCompleted.Image")));
            this.btnCompleted.ImageSize = new System.Drawing.Size(15, 15);
            this.btnCompleted.Location = new System.Drawing.Point(1349, 15);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCompleted.ShadowDecoration.Parent = this.btnCompleted;
            this.btnCompleted.Size = new System.Drawing.Size(36, 33);
            this.btnCompleted.TabIndex = 22;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(215)))), ((int)(((byte)(139)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDelete.Location = new System.Drawing.Point(1393, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(36, 33);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDesignTask
            // 
            this.lbDesignTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbDesignTask.ForeColor = System.Drawing.Color.Black;
            this.lbDesignTask.Location = new System.Drawing.Point(427, 7);
            this.lbDesignTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDesignTask.Name = "lbDesignTask";
            this.lbDesignTask.Size = new System.Drawing.Size(875, 55);
            this.lbDesignTask.TabIndex = 13;
            this.lbDesignTask.Text = "Lorem ipsum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(332, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tâche :";
            // 
            // checkedTask
            // 
            this.checkedTask.Animated = true;
            this.checkedTask.AutoSize = true;
            this.checkedTask.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.checkedTask.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(215)))), ((int)(((byte)(139)))));
            this.checkedTask.CheckedState.BorderRadius = 2;
            this.checkedTask.CheckedState.BorderThickness = 0;
            this.checkedTask.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.checkedTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.checkedTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.checkedTask.Location = new System.Drawing.Point(1309, 25);
            this.checkedTask.Margin = new System.Windows.Forms.Padding(4);
            this.checkedTask.Name = "checkedTask";
            this.checkedTask.Size = new System.Drawing.Size(18, 17);
            this.checkedTask.TabIndex = 15;
            this.checkedTask.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(215)))), ((int)(((byte)(139)))));
            this.checkedTask.UncheckedState.BorderRadius = 0;
            this.checkedTask.UncheckedState.BorderThickness = 2;
            this.checkedTask.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkedTask.UseVisualStyleBackColor = true;
            this.checkedTask.CheckedChanged += new System.EventHandler(this.checkedTask_CheckedChanged);
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(1440, 79);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDesignTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHoureTask;
        private System.Windows.Forms.Label lbDateTask;
        private System.Windows.Forms.Label lbId;
        public Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        public Guna.UI2.WinForms.Guna2CircleButton btnCompleted;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2CheckBox checkedTask;
    }
}
