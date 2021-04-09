namespace LealPassword.View.Settings
{
    internal sealed partial class SettingsManagerView
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAskToSave = new System.Windows.Forms.CheckBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBackColorSelector = new System.Windows.Forms.Button();
            this.buttonForeColorSelector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonGenTheme = new System.Windows.Forms.Button();
            this.checkBoxSysTray = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nConfigurações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxAskToSave
            // 
            this.checkBoxAskToSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAskToSave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAskToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAskToSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAskToSave.Location = new System.Drawing.Point(117, 205);
            this.checkBoxAskToSave.Name = "checkBoxAskToSave";
            this.checkBoxAskToSave.Size = new System.Drawing.Size(487, 33);
            this.checkBoxAskToSave.TabIndex = 1;
            this.checkBoxAskToSave.Text = "Salvar automaticamente o seus dados quando fechar.";
            this.checkBoxAskToSave.UseVisualStyleBackColor = true;
            this.checkBoxAskToSave.CheckedChanged += new System.EventHandler(this.CheckBoxAskToSave_CheckedChanged);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Location = new System.Drawing.Point(566, 391);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(147, 29);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Voltar ao menu principal";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.ButtonGoBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modificar cor do fundo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBackColorSelector
            // 
            this.buttonBackColorSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackColorSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackColorSelector.Location = new System.Drawing.Point(508, 241);
            this.buttonBackColorSelector.Name = "buttonBackColorSelector";
            this.buttonBackColorSelector.Size = new System.Drawing.Size(96, 26);
            this.buttonBackColorSelector.TabIndex = 4;
            this.buttonBackColorSelector.Text = "Selecionar";
            this.buttonBackColorSelector.UseVisualStyleBackColor = true;
            this.buttonBackColorSelector.Click += new System.EventHandler(this.ButtonBackColorSelector_Click);
            // 
            // buttonForeColorSelector
            // 
            this.buttonForeColorSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForeColorSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForeColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForeColorSelector.Location = new System.Drawing.Point(508, 280);
            this.buttonForeColorSelector.Name = "buttonForeColorSelector";
            this.buttonForeColorSelector.Size = new System.Drawing.Size(96, 26);
            this.buttonForeColorSelector.TabIndex = 6;
            this.buttonForeColorSelector.Text = "Selecionar";
            this.buttonForeColorSelector.UseVisualStyleBackColor = true;
            this.buttonForeColorSelector.Click += new System.EventHandler(this.ButtonForeColorSelector_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificar cor do texto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxThemes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.ItemHeight = 18;
            this.comboBoxThemes.Location = new System.Drawing.Point(347, 316);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(129, 26);
            this.comboBoxThemes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temas predefinidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Location = new System.Drawing.Point(508, 316);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(96, 26);
            this.buttonApply.TabIndex = 9;
            this.buttonApply.Text = "Aplicar";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // buttonGenTheme
            // 
            this.buttonGenTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenTheme.Location = new System.Drawing.Point(347, 350);
            this.buttonGenTheme.Name = "buttonGenTheme";
            this.buttonGenTheme.Size = new System.Drawing.Size(257, 26);
            this.buttonGenTheme.TabIndex = 10;
            this.buttonGenTheme.Text = "Gerar tema aleatório";
            this.buttonGenTheme.UseVisualStyleBackColor = true;
            this.buttonGenTheme.Click += new System.EventHandler(this.ButtonGenTheme_Click);
            // 
            // checkBoxSysTray
            // 
            this.checkBoxSysTray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSysTray.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSysTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSysTray.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSysTray.Location = new System.Drawing.Point(117, 171);
            this.checkBoxSysTray.Name = "checkBoxSysTray";
            this.checkBoxSysTray.Size = new System.Drawing.Size(487, 35);
            this.checkBoxSysTray.TabIndex = 11;
            this.checkBoxSysTray.Text = "Minimizar para a bandeja quando clicar no X.";
            this.checkBoxSysTray.UseVisualStyleBackColor = true;
            this.checkBoxSysTray.CheckedChanged += new System.EventHandler(this.CheckBoxSysTray_CheckedChanged);
            // 
            // SettingsManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 432);
            this.Controls.Add(this.checkBoxSysTray);
            this.Controls.Add(this.buttonGenTheme);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxThemes);
            this.Controls.Add(this.buttonForeColorSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBackColorSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.checkBoxAskToSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsManagerView";
            this.Text = "SettingsManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAskToSave;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBackColorSelector;
        private System.Windows.Forms.Button buttonForeColorSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxThemes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonGenTheme;
        private System.Windows.Forms.CheckBox checkBoxSysTray;
    }
}