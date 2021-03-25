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
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(467, 110);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "LealPassword";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            // 
            // labelOpenLast
            // 
            this.labelOpenLast.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOpenLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenLast.ForeColor = System.Drawing.Color.Blue;
            this.labelOpenLast.Location = new System.Drawing.Point(0, 110);
            this.labelOpenLast.Name = "labelOpenLast";
            this.labelOpenLast.Size = new System.Drawing.Size(467, 32);
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
            this.buttonChooseFileToOpen.Location = new System.Drawing.Point(133, 210);
            this.buttonChooseFileToOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseFileToOpen.Name = "buttonChooseFileToOpen";
            this.buttonChooseFileToOpen.Size = new System.Drawing.Size(200, 62);
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
            this.buttonCreateNewDataBase.Location = new System.Drawing.Point(133, 297);
            this.buttonCreateNewDataBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateNewDataBase.Name = "buttonCreateNewDataBase";
            this.buttonCreateNewDataBase.Size = new System.Drawing.Size(200, 62);
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
            this.buttonCredits.Location = new System.Drawing.Point(167, 404);
            this.buttonCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(133, 37);
            this.buttonCredits.TabIndex = 4;
            this.buttonCredits.Text = "Créditos";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // labelClose
            // 
            this.labelClose.Image = global::LealPassword.Properties.Resources.close_window_32px;
            this.labelClose.Location = new System.Drawing.Point(403, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(64, 64);
            this.labelClose.TabIndex = 5;
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // OCDataBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(467, 492);
            this.ControlBox = false;
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonCreateNewDataBase);
            this.Controls.Add(this.buttonChooseFileToOpen);
            this.Controls.Add(this.labelOpenLast);
            this.Controls.Add(this.labelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 492);
            this.MinimizeBox = false;
            this.Name = "OCDataBaseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OCDataBaseView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownControl);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOpenLast;
        private System.Windows.Forms.Button buttonChooseFileToOpen;
        private System.Windows.Forms.Button buttonCreateNewDataBase;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Label labelClose;
    }
}