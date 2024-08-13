namespace NukUX_ModernUI
{
    partial class modernForm
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
            this.App_ControlBar = new System.Windows.Forms.Panel();
            this.App_Icon = new System.Windows.Forms.PictureBox();
            this.App_Minimize = new System.Windows.Forms.Button();
            this.App_Maximize = new System.Windows.Forms.Button();
            this.App_CloseBtn = new System.Windows.Forms.Button();
            this.App_Title = new System.Windows.Forms.Label();
            this.App_ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // App_ControlBar
            // 
            this.App_ControlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.App_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.App_ControlBar.Controls.Add(this.App_Icon);
            this.App_ControlBar.Controls.Add(this.App_Minimize);
            this.App_ControlBar.Controls.Add(this.App_Maximize);
            this.App_ControlBar.Controls.Add(this.App_CloseBtn);
            this.App_ControlBar.Controls.Add(this.App_Title);
            this.App_ControlBar.Location = new System.Drawing.Point(-4, -2);
            this.App_ControlBar.Name = "App_ControlBar";
            this.App_ControlBar.Size = new System.Drawing.Size(1139, 39);
            this.App_ControlBar.TabIndex = 0;
            this.App_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.App_ControlBar_MouseDown);
            this.App_ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.App_ControlBar_MouseMove);
            this.App_ControlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.App_ControlBar_MouseUp);
            // 
            // App_Icon
            // 
            this.App_Icon.Location = new System.Drawing.Point(12, 9);
            this.App_Icon.Name = "App_Icon";
            this.App_Icon.Size = new System.Drawing.Size(24, 24);
            this.App_Icon.TabIndex = 1;
            this.App_Icon.TabStop = false;
            // 
            // App_Minimize
            // 
            this.App_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.App_Minimize.FlatAppearance.BorderSize = 0;
            this.App_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_Minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Minimize.ForeColor = System.Drawing.Color.White;
            this.App_Minimize.Location = new System.Drawing.Point(953, 3);
            this.App_Minimize.Name = "App_Minimize";
            this.App_Minimize.Size = new System.Drawing.Size(49, 36);
            this.App_Minimize.TabIndex = 3;
            this.App_Minimize.Text = "-";
            this.App_Minimize.UseVisualStyleBackColor = true;
            // 
            // App_Maximize
            // 
            this.App_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.App_Maximize.FlatAppearance.BorderSize = 0;
            this.App_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_Maximize.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Maximize.ForeColor = System.Drawing.Color.White;
            this.App_Maximize.Location = new System.Drawing.Point(1018, 3);
            this.App_Maximize.Name = "App_Maximize";
            this.App_Maximize.Size = new System.Drawing.Size(49, 36);
            this.App_Maximize.TabIndex = 2;
            this.App_Maximize.Text = "▢";
            this.App_Maximize.UseVisualStyleBackColor = true;
            this.App_Maximize.Click += new System.EventHandler(this.App_Maximize_Click);
            // 
            // App_CloseBtn
            // 
            this.App_CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.App_CloseBtn.FlatAppearance.BorderSize = 0;
            this.App_CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_CloseBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.App_CloseBtn.Location = new System.Drawing.Point(1085, 3);
            this.App_CloseBtn.Name = "App_CloseBtn";
            this.App_CloseBtn.Size = new System.Drawing.Size(49, 36);
            this.App_CloseBtn.TabIndex = 1;
            this.App_CloseBtn.Text = "x";
            this.App_CloseBtn.UseVisualStyleBackColor = true;
            this.App_CloseBtn.Click += new System.EventHandler(this.App_CloseBtn_Click);
            // 
            // App_Title
            // 
            this.App_Title.AutoSize = true;
            this.App_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Title.ForeColor = System.Drawing.Color.White;
            this.App_Title.Location = new System.Drawing.Point(41, 12);
            this.App_Title.Name = "App_Title";
            this.App_Title.Size = new System.Drawing.Size(54, 18);
            this.App_Title.TabIndex = 0;
            this.App_Title.Text = "Form1";
            // 
            // modernForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.App_ControlBar);
            this.Name = "modernForm";
            this.Size = new System.Drawing.Size(1133, 636);
            this.App_ControlBar.ResumeLayout(false);
            this.App_ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel App_ControlBar;
        private System.Windows.Forms.Button App_Maximize;
        private System.Windows.Forms.Button App_CloseBtn;
        private System.Windows.Forms.Label App_Title;
        private System.Windows.Forms.Button App_Minimize;
        private System.Windows.Forms.PictureBox App_Icon;
    }
}
