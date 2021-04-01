using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LealPassword.View
{
    internal sealed partial class MainForm : Form
    {
        private bool locked;

        internal MainForm(DataBase dataBase)
        {
            InitializeComponent();
            DataBase = dataBase;
            locked = true;
            Program.SetDefaultConf(this, $"LealPassword | {DataBase.Name}");
            labelDatabaseName.Text = DataBase.Name;
        }

        private DataBase DataBase { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogBag.AddNormalLog("MainForm loaded with success!");
        }

        private void UnlockOrLockDataBase()
        {
            var inputHashed = Hash.HashString(textBoxMasterPass.Text);

            if (!DataBase.Hash.Equals(inputHashed) && locked) // invalid
            {
                MessageBox.Show("Senha mestra incorreta", "Senha incorreta", MessageBoxButtons.OK);
                return;
            }
            
            if (locked) // unlocking
            {
                textBoxMasterPass.Text = "";
                buttonLockUnlock.Text = "Bloquear";
                labelStatus.Text = "Desbloqueado";
                labelStatus.ForeColor = Color.Green;
                panelSide.Enabled = true;
                panelContainer.Enabled = true;
                locked = false;
            }
            else // locking
            {
                buttonLockUnlock.Text = "Desbloquear";
                labelStatus.Text = "Bloqueado";
                labelStatus.ForeColor = Color.Red;
                panelSide.Enabled = false;
                panelContainer.Enabled = false;
                locked = true;
            }
        }

        private void MouseDownControl(object sender, MouseEventArgs e) => Program.DragAndDrop(e, Handle);

        private void LabelMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void LabelMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
            {
                WindowState = FormWindowState.Normal;
                labelMaximize.Image = Properties.Resources.maximize_window_32px;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                labelMaximize.Image = Properties.Resources.normalize_window_32px;              
            }
        }

        private void LabelClose_Click(object sender, EventArgs e) => Program.QuitProgram();

        private void ButtonLockUnlock_Click(object sender, EventArgs e) => UnlockOrLockDataBase();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => textBoxMasterPass.PasswordChar 
            = textBoxMasterPass.PasswordChar == '*'
            ? textBoxMasterPass.PasswordChar = '\0'
            : textBoxMasterPass.PasswordChar = '*';
    }
}
