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
            this.labelTitle.Size = new System.Drawing.Size(450, 109);
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
            this.labelOpenLast.Location = new System.Drawing.Point(0, 109);
            this.labelOpenLast.Name = "labelOpenLast";
            this.labelOpenLast.Size = new System.Drawing.Size(450, 23);
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
            this.buttonChooseFileToOpen.Location = new System.Drawing.Point(125, 196);
            this.buttonChooseFileToOpen.Name = "buttonChooseFileToOpen";
            this.buttonChooseFileToOpen.Size = new System.Drawing.Size(200, 60);
            this.buttonChooseFileToOpen.TabIndex = 2;
            this.buttonChooseFileToOpen.Text = "Escolher arquivo";
            this.buttonChooseFileToOpen.UseVisualStyleBackColor = false;
            // 
            // buttonCreateNewDataBase
            // 
            this.buttonCreateNewDataBase.BackColor = System.Drawing.Color.Gray;
            this.buttonCreateNewDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewDataBase.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNewDataBase.Location = new System.Drawing.Point(125, 275);
            this.buttonCreateNewDataBase.Name = "buttonCreateNewDataBase";
            this.buttonCreateNewDataBase.Size = new System.Drawing.Size(200, 60);
            this.buttonCreateNewDataBase.TabIndex = 3;
            this.buttonCreateNewDataBase.Text = "Criar novo";
            this.buttonCreateNewDataBase.UseVisualStyleBackColor = false;
            // 
            // OCDataBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCreateNewDataBase);
            this.Controls.Add(this.buttonChooseFileToOpen);
            this.Controls.Add(this.labelOpenLast);
            this.Controls.Add(this.labelTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 600);
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
    }
}