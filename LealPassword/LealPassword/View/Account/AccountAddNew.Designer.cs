namespace LealPassword.View.Account
{
    internal sealed partial class AccountAddNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenPass = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxTags = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNewTag = new System.Windows.Forms.Button();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegName.Location = new System.Drawing.Point(60, 74);
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(347, 27);
            this.textBoxRegName.TabIndex = 1;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(60, 134);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(347, 27);
            this.textBoxUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(60, 196);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(347, 27);
            this.textBoxMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(60, 253);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(249, 27);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // buttonGenPass
            // 
            this.buttonGenPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenPass.ForeColor = System.Drawing.Color.Black;
            this.buttonGenPass.Location = new System.Drawing.Point(346, 253);
            this.buttonGenPass.Name = "buttonGenPass";
            this.buttonGenPass.Size = new System.Drawing.Size(61, 27);
            this.buttonGenPass.TabIndex = 8;
            this.buttonGenPass.Text = "Gerar";
            this.buttonGenPass.UseVisualStyleBackColor = true;
            this.buttonGenPass.Click += new System.EventHandler(this.ButtonGenPass_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(315, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(25, 27);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // comboBoxTags
            // 
            this.comboBoxTags.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTags.FormattingEnabled = true;
            this.comboBoxTags.Location = new System.Drawing.Point(62, 317);
            this.comboBoxTags.Name = "comboBoxTags";
            this.comboBoxTags.Size = new System.Drawing.Size(196, 28);
            this.comboBoxTags.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tag";
            // 
            // buttonNewTag
            // 
            this.buttonNewTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewTag.ForeColor = System.Drawing.Color.Black;
            this.buttonNewTag.Location = new System.Drawing.Point(264, 317);
            this.buttonNewTag.Name = "buttonNewTag";
            this.buttonNewTag.Size = new System.Drawing.Size(87, 27);
            this.buttonNewTag.TabIndex = 12;
            this.buttonNewTag.Text = "Nova tag";
            this.buttonNewTag.UseVisualStyleBackColor = true;
            this.buttonNewTag.Click += new System.EventHandler(this.ButtonNewTag_Click);
            // 
            // textBoxTag
            // 
            this.textBoxTag.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTag.Location = new System.Drawing.Point(62, 318);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(196, 27);
            this.textBoxTag.TabIndex = 13;
            this.textBoxTag.Visible = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreate.Location = new System.Drawing.Point(154, 388);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(170, 47);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Criar";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 282);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 10);
            this.progressBar1.TabIndex = 15;
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(0, 352);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(484, 23);
            this.labelError.TabIndex = 16;
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AccountAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 468);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.buttonNewTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTags);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonGenPass);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountAddNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo registro";
            this.Load += new System.EventHandler(this.AccountAddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegName;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGenPass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxTags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNewTag;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelError;
    }
}