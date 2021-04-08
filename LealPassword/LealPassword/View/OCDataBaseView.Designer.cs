namespace LealPassword.View
{
    internal sealed partial class OCDataBaseView
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOpenLast = new System.Windows.Forms.Label();
            this.buttonChooseFileToOpen = new System.Windows.Forms.Button();
            this.buttonCreateNewDataBase = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMasterPass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAdvanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(600, 89);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LealPassword";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            // 
            // labelOpenLast
            // 
            this.labelOpenLast.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOpenLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenLast.ForeColor = System.Drawing.Color.Crimson;
            this.labelOpenLast.Location = new System.Drawing.Point(0, 89);
            this.labelOpenLast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpenLast.Name = "labelOpenLast";
            this.labelOpenLast.Size = new System.Drawing.Size(600, 50);
            this.labelOpenLast.TabIndex = 1;
            this.labelOpenLast.Text = "Abrir último: nome_database";
            this.labelOpenLast.Visible = false;
            this.labelOpenLast.Click += new System.EventHandler(this.LabelOpenLast_Click);
            // 
            // buttonChooseFileToOpen
            // 
            this.buttonChooseFileToOpen.BackColor = System.Drawing.Color.Gray;
            this.buttonChooseFileToOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFileToOpen.ForeColor = System.Drawing.Color.White;
            this.buttonChooseFileToOpen.Location = new System.Drawing.Point(100, 171);
            this.buttonChooseFileToOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChooseFileToOpen.Name = "buttonChooseFileToOpen";
            this.buttonChooseFileToOpen.Size = new System.Drawing.Size(150, 50);
            this.buttonChooseFileToOpen.TabIndex = 2;
            this.buttonChooseFileToOpen.Text = "Escolher arquivo";
            this.buttonChooseFileToOpen.UseVisualStyleBackColor = false;
            this.buttonChooseFileToOpen.Click += new System.EventHandler(this.ButtonChooseFileToOpen_Click);
            // 
            // buttonCreateNewDataBase
            // 
            this.buttonCreateNewDataBase.BackColor = System.Drawing.Color.Gray;
            this.buttonCreateNewDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewDataBase.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNewDataBase.Location = new System.Drawing.Point(100, 241);
            this.buttonCreateNewDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNewDataBase.Name = "buttonCreateNewDataBase";
            this.buttonCreateNewDataBase.Size = new System.Drawing.Size(150, 50);
            this.buttonCreateNewDataBase.TabIndex = 3;
            this.buttonCreateNewDataBase.Text = "Criar novo";
            this.buttonCreateNewDataBase.UseVisualStyleBackColor = false;
            this.buttonCreateNewDataBase.Click += new System.EventHandler(this.ButtonCreateNewDataBase_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Gray;
            this.buttonCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredits.ForeColor = System.Drawing.Color.White;
            this.buttonCredits.Location = new System.Drawing.Point(125, 328);
            this.buttonCredits.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(100, 30);
            this.buttonCredits.TabIndex = 4;
            this.buttonCredits.Text = "Créditos";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Image = global::LealPassword.Properties.Resources.close_window_32px;
            this.labelClose.Location = new System.Drawing.Point(576, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(24, 26);
            this.labelClose.TabIndex = 5;
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do novo banco de dados";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(361, 187);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 26);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxMasterPass
            // 
            this.textBoxMasterPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMasterPass.Location = new System.Drawing.Point(361, 241);
            this.textBoxMasterPass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterPass.MaxLength = 50;
            this.textBoxMasterPass.Name = "textBoxMasterPass";
            this.textBoxMasterPass.PasswordChar = '*';
            this.textBoxMasterPass.Size = new System.Drawing.Size(164, 26);
            this.textBoxMasterPass.TabIndex = 8;
            this.textBoxMasterPass.TextChanged += new System.EventHandler(this.TextBoxMasterPass_Tiping);
            this.textBoxMasterPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMasterPass_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(529, 241);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha mestra";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(361, 271);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 8);
            this.progressBar1.TabIndex = 11;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(358, 282);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 12;
            this.labelError.Visible = false;
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.BackColor = System.Drawing.Color.Gray;
            this.buttonCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNew.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNew.Location = new System.Drawing.Point(396, 328);
            this.buttonCreateNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(100, 30);
            this.buttonCreateNew.TabIndex = 13;
            this.buttonCreateNew.Text = "Criar";
            this.buttonCreateNew.UseVisualStyleBackColor = false;
            this.buttonCreateNew.Click += new System.EventHandler(this.ButtonCreateNew_Click);
            // 
            // buttonAdvanced
            // 
            this.buttonAdvanced.BackColor = System.Drawing.Color.Gray;
            this.buttonAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvanced.ForeColor = System.Drawing.Color.White;
            this.buttonAdvanced.Location = new System.Drawing.Point(0, 375);
            this.buttonAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdvanced.Name = "buttonAdvanced";
            this.buttonAdvanced.Size = new System.Drawing.Size(77, 24);
            this.buttonAdvanced.TabIndex = 14;
            this.buttonAdvanced.Text = "Converter";
            this.buttonAdvanced.UseVisualStyleBackColor = false;
            this.buttonAdvanced.Click += new System.EventHandler(this.ButtonAdvanced_Click);
            // 
            // OCDataBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAdvanced);
            this.Controls.Add(this.buttonCreateNew);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxMasterPass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonCreateNewDataBase);
            this.Controls.Add(this.buttonChooseFileToOpen);
            this.Controls.Add(this.labelOpenLast);
            this.Controls.Add(this.labelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "OCDataBaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OCDataBaseView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOpenLast;
        private System.Windows.Forms.Button buttonChooseFileToOpen;
        private System.Windows.Forms.Button buttonCreateNewDataBase;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMasterPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonAdvanced;
    }
}