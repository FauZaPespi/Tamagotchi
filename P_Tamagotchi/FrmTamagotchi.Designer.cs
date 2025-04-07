namespace P_Tamagotchi
{
    partial class FrmTamagotchi
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pictureTamagotchi = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.borderlessform = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmTick = new System.Windows.Forms.Timer(this.components);
            this.lsbTamagotchis = new System.Windows.Forms.ListBox();
            this.chkFreeze = new Guna.UI2.WinForms.Guna2CheckBox();
            this.upDownMulti = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlController = new System.Windows.Forms.Panel();
            this.lblInfoTama = new System.Windows.Forms.Label();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTamagotchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMulti)).BeginInit();
            this.pnlController.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.btnLeft.Location = new System.Drawing.Point(3, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 45);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "Heal";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnMid
            // 
            this.btnMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.btnMid.Location = new System.Drawing.Point(122, 39);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(75, 45);
            this.btnMid.TabIndex = 1;
            this.btnMid.Text = "Sleep";
            this.btnMid.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.btnRight.Location = new System.Drawing.Point(245, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 45);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Eat";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.White;
            this.pnlGame.Controls.Add(this.pictureTamagotchi);
            this.pnlGame.Controls.Add(this.pictureBG);
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(323, 240);
            this.pnlGame.TabIndex = 3;
            // 
            // pictureTamagotchi
            // 
            this.pictureTamagotchi.ImageRotate = 0F;
            this.pictureTamagotchi.Location = new System.Drawing.Point(125, 82);
            this.pictureTamagotchi.Name = "pictureTamagotchi";
            this.pictureTamagotchi.Size = new System.Drawing.Size(72, 77);
            this.pictureTamagotchi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTamagotchi.TabIndex = 7;
            this.pictureTamagotchi.TabStop = false;
            // 
            // pictureBG
            // 
            this.pictureBG.FillColor = System.Drawing.Color.DarkGray;
            this.pictureBG.ImageRotate = 0F;
            this.pictureBG.Location = new System.Drawing.Point(3, 49);
            this.pictureBG.Name = "pictureBG";
            this.pictureBG.Size = new System.Drawing.Size(317, 145);
            this.pictureBG.TabIndex = 6;
            this.pictureBG.TabStop = false;
            // 
            // borderlessform
            // 
            this.borderlessform.BorderRadius = 50;
            this.borderlessform.ContainerControl = this;
            this.borderlessform.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessform.TransparentWhileDrag = true;
            // 
            // tmTick
            // 
            this.tmTick.Enabled = true;
            this.tmTick.Interval = 1;
            this.tmTick.Tick += new System.EventHandler(this.tmTick_Tick);
            // 
            // lsbTamagotchis
            // 
            this.lsbTamagotchis.FormattingEnabled = true;
            this.lsbTamagotchis.Location = new System.Drawing.Point(341, 12);
            this.lsbTamagotchis.Name = "lsbTamagotchis";
            this.lsbTamagotchis.Size = new System.Drawing.Size(209, 238);
            this.lsbTamagotchis.TabIndex = 4;
            this.lsbTamagotchis.SelectedIndexChanged += new System.EventHandler(this.lsbTamagotchis_SelectedIndexChanged);
            // 
            // chkFreeze
            // 
            this.chkFreeze.AutoSize = true;
            this.chkFreeze.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFreeze.CheckedState.BorderRadius = 0;
            this.chkFreeze.CheckedState.BorderThickness = 0;
            this.chkFreeze.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFreeze.Location = new System.Drawing.Point(341, 258);
            this.chkFreeze.Name = "chkFreeze";
            this.chkFreeze.Size = new System.Drawing.Size(76, 17);
            this.chkFreeze.TabIndex = 5;
            this.chkFreeze.Text = "chkFreeze";
            this.chkFreeze.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFreeze.UncheckedState.BorderRadius = 0;
            this.chkFreeze.UncheckedState.BorderThickness = 0;
            this.chkFreeze.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFreeze.CheckedChanged += new System.EventHandler(this.chkFreeze_CheckedChanged);
            // 
            // upDownMulti
            // 
            this.upDownMulti.BackColor = System.Drawing.Color.Transparent;
            this.upDownMulti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upDownMulti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.upDownMulti.Location = new System.Drawing.Point(341, 281);
            this.upDownMulti.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.upDownMulti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownMulti.Name = "upDownMulti";
            this.upDownMulti.Size = new System.Drawing.Size(100, 36);
            this.upDownMulti.TabIndex = 6;
            this.upDownMulti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownMulti.ValueChanged += new System.EventHandler(this.upDownMulti_ValueChanged);
            // 
            // pnlController
            // 
            this.pnlController.BackColor = System.Drawing.Color.Teal;
            this.pnlController.Controls.Add(this.btnRight);
            this.pnlController.Controls.Add(this.btnLeft);
            this.pnlController.Controls.Add(this.btnMid);
            this.pnlController.Location = new System.Drawing.Point(12, 258);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(323, 87);
            this.pnlController.TabIndex = 7;
            // 
            // lblInfoTama
            // 
            this.lblInfoTama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoTama.AutoSize = true;
            this.lblInfoTama.Location = new System.Drawing.Point(556, 9);
            this.lblInfoTama.MaximumSize = new System.Drawing.Size(395, 333);
            this.lblInfoTama.MinimumSize = new System.Drawing.Size(395, 333);
            this.lblInfoTama.Name = "lblInfoTama";
            this.lblInfoTama.Size = new System.Drawing.Size(395, 333);
            this.lblInfoTama.TabIndex = 8;
            this.lblInfoTama.Text = "lblInfoTama";
            this.lblInfoTama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTamagotchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(211)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(977, 357);
            this.Controls.Add(this.lblInfoTama);
            this.Controls.Add(this.upDownMulti);
            this.Controls.Add(this.chkFreeze);
            this.Controls.Add(this.lsbTamagotchis);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTamagotchi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTamagotchi_Load);
            this.pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTamagotchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMulti)).EndInit();
            this.pnlController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel pnlGame;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBG;
        private Guna.UI2.WinForms.Guna2PictureBox pictureTamagotchi;
        private System.Windows.Forms.Timer tmTick;
        private System.Windows.Forms.ListBox lsbTamagotchis;
        private Guna.UI2.WinForms.Guna2CheckBox chkFreeze;
        private Guna.UI2.WinForms.Guna2NumericUpDown upDownMulti;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Label lblInfoTama;
    }
}

