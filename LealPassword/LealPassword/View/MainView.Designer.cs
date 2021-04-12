namespace LealPassword.View
{
    internal sealed partial class MainView
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonLockUnlock = new System.Windows.Forms.Button();
            this.textBoxMasterPass = new System.Windows.Forms.TextBox();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelMaximize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelCards = new System.Windows.Forms.Label();
            this.labelPersonalInfo = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.panelTop.Controls.Add(this.checkBox1);
            this.panelTop.Controls.Add(this.buttonLockUnlock);
            this.panelTop.Controls.Add(this.textBoxMasterPass);
            this.panelTop.Controls.Add(this.labelDatabaseName);
            this.panelTop.Controls.Add(this.labelStatus);
            this.panelTop.Controls.Add(this.labelMinimize);
            this.panelTop.Controls.Add(this.labelMaximize);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelLogo);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 96);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            // 
            // checkBox1
            // 
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(428, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(17, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // buttonLockUnlock
            // 
            this.buttonLockUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLockUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLockUnlock.ForeColor = System.Drawing.Color.White;
            this.buttonLockUnlock.Location = new System.Drawing.Point(288, 62);
            this.buttonLockUnlock.Name = "buttonLockUnlock";
            this.buttonLockUnlock.Size = new System.Drawing.Size(95, 23);
            this.buttonLockUnlock.TabIndex = 7;
            this.buttonLockUnlock.Text = "Desbloquear";
            this.buttonLockUnlock.UseVisualStyleBackColor = true;
            this.buttonLockUnlock.Click += new System.EventHandler(this.ButtonLockUnlock_Click);
            // 
            // textBoxMasterPass
            // 
            this.textBoxMasterPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMasterPass.Location = new System.Drawing.Point(238, 28);
            this.textBoxMasterPass.Name = "textBoxMasterPass";
            this.textBoxMasterPass.PasswordChar = '*';
            this.textBoxMasterPass.Size = new System.Drawing.Size(184, 23);
            this.textBoxMasterPass.TabIndex = 6;
            this.textBoxMasterPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMasterPass_KeyDown);
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.AutoSize = true;
            this.labelDatabaseName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseName.ForeColor = System.Drawing.Color.White;
            this.labelDatabaseName.Location = new System.Drawing.Point(235, 9);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(83, 15);
            this.labelDatabaseName.TabIndex = 5;
            this.labelDatabaseName.Text = "databasename";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(847, 48);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(153, 48);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Bloqueado";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            // 
            // labelMinimize
            // 
            this.labelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Image = global::LealPassword.Properties.Resources.minimize_32px;
            this.labelMinimize.Location = new System.Drawing.Point(844, 0);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(48, 48);
            this.labelMinimize.TabIndex = 3;
            this.labelMinimize.Click += new System.EventHandler(this.LabelMinimize_Click);
            // 
            // labelMaximize
            // 
            this.labelMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMaximize.Image = global::LealPassword.Properties.Resources.normalize_window_32px;
            this.labelMaximize.Location = new System.Drawing.Point(898, 0);
            this.labelMaximize.Name = "labelMaximize";
            this.labelMaximize.Size = new System.Drawing.Size(48, 48);
            this.labelMaximize.TabIndex = 2;
            this.labelMaximize.Click += new System.EventHandler(this.LabelMaximize_Click);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Image = global::LealPassword.Properties.Resources.close_window_32px;
            this.labelClose.Location = new System.Drawing.Point(952, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(48, 48);
            this.labelClose.TabIndex = 1;
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLogo.Image = global::LealPassword.Properties.Resources.logo_200x96px;
            this.labelLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLogo.Location = new System.Drawing.Point(0, 0);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 96);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLogo.Click += new System.EventHandler(this.LabelLogo_Click);
            this.labelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.panelSide.Controls.Add(this.labelSettings);
            this.panelSide.Controls.Add(this.labelCards);
            this.panelSide.Controls.Add(this.labelPersonalInfo);
            this.panelSide.Controls.Add(this.labelNotes);
            this.panelSide.Controls.Add(this.labelAccounts);
            this.panelSide.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Enabled = false;
            this.panelSide.Location = new System.Drawing.Point(0, 96);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(96, 504);
            this.panelSide.TabIndex = 1;
            // 
            // labelSettings
            // 
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSettings.ForeColor = System.Drawing.Color.White;
            this.labelSettings.Image = global::LealPassword.Properties.Resources.settings_32px;
            this.labelSettings.Location = new System.Drawing.Point(0, 456);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(96, 48);
            this.labelSettings.TabIndex = 4;
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelSettings.Click += new System.EventHandler(this.LabelSettings_Click);
            // 
            // labelCards
            // 
            this.labelCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCards.ForeColor = System.Drawing.Color.White;
            this.labelCards.Image = global::LealPassword.Properties.Resources.card_48px;
            this.labelCards.Location = new System.Drawing.Point(0, 288);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(96, 96);
            this.labelCards.TabIndex = 3;
            this.labelCards.Text = "Cartões";
            this.labelCards.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelCards.Click += new System.EventHandler(this.LabelCards_Click);
            // 
            // labelPersonalInfo
            // 
            this.labelPersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.labelPersonalInfo.Image = global::LealPassword.Properties.Resources.personalInfo_48px;
            this.labelPersonalInfo.Location = new System.Drawing.Point(0, 192);
            this.labelPersonalInfo.Name = "labelPersonalInfo";
            this.labelPersonalInfo.Size = new System.Drawing.Size(96, 96);
            this.labelPersonalInfo.TabIndex = 2;
            this.labelPersonalInfo.Text = "Informações pessoais";
            this.labelPersonalInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelPersonalInfo.Click += new System.EventHandler(this.LabelPersonalInfo_Click);
            // 
            // labelNotes
            // 
            this.labelNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNotes.ForeColor = System.Drawing.Color.White;
            this.labelNotes.Image = global::LealPassword.Properties.Resources.note_48px;
            this.labelNotes.Location = new System.Drawing.Point(0, 96);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(96, 96);
            this.labelNotes.TabIndex = 1;
            this.labelNotes.Text = "Notas secretas";
            this.labelNotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNotes.Click += new System.EventHandler(this.LabelNotes_Click);
            // 
            // labelAccounts
            // 
            this.labelAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAccounts.ForeColor = System.Drawing.Color.White;
            this.labelAccounts.Image = global::LealPassword.Properties.Resources.accounts_48px;
            this.labelAccounts.Location = new System.Drawing.Point(0, 0);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(96, 96);
            this.labelAccounts.TabIndex = 0;
            this.labelAccounts.Text = "Contas";
            this.labelAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelAccounts.Click += new System.EventHandler(this.LabelAccounts_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = global::LealPassword.Properties.Resources.backlogo;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Enabled = false;
            this.panelContainer.Location = new System.Drawing.Point(96, 96);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(904, 504);
            this.panelContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelMaximize;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonLockUnlock;
        private System.Windows.Forms.TextBox textBoxMasterPass;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.Label labelCards;
        private System.Windows.Forms.Label labelPersonalInfo;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelSettings;
    }
}