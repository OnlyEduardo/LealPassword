using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.View.Account;
using LealPassword.View.PersonalI;
using LealPassword.View.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.View
{
    internal sealed partial class MainForm : Form
    {
        private readonly Label[] sideLabels;
        private bool locked = true;
        private Form currentForm = null;

        internal MainForm(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultConf(this, $"LealPassword | {dataBase.Name}");

            sideLabels = new Label[5]
            {
                labelAccounts,
                labelNotes,
                labelPersonalInfo,
                labelCards,
                labelSettings,
            };

            SelectNullForm();
            DataBase = dataBase;
            labelDatabaseName.Text = DataBase.Name;
        }

        private DataBase DataBase { get; }

        private void MainForm_Load(object sender, EventArgs e) => LogBag.AddNormalLog("MainForm loaded with success!");

        private void Save()
        {
            if (DataBase.AutoSave)
                Data.WriteController.WriteDataBase(DataBase, Properties.Settings.Default.LastPath);
            else if (MessageBox.Show("Deseja salvar as alterações ?", DataBase.Name, MessageBoxButtons.YesNo) == DialogResult.Yes)
                Data.WriteController.WriteDataBase(DataBase, Properties.Settings.Default.LastPath);
        }

        private void MouseDownControl(object sender, MouseEventArgs e) => Program.DragAndDrop(e, Handle);

        #region Top buttons
        private void UnlockOrLockDataBase()
        {
            var inputHashed = Hash.HashString(textBoxMasterPass.Text);

            if (!DataBase.Hash.Hashed.Equals(inputHashed) && locked) // invalid
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
                SelectNullForm();
                locked = true;
            }
        }

        private void LabelLogo_Click(object sender, EventArgs e) => SelectNullForm();

        private void LabelMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void LabelMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
            {
                WindowState = FormWindowState.Normal;
                labelMaximize.Image = Properties.Resources.normalize_window_32px;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                labelMaximize.Image = Properties.Resources.maximize_window_32px;               
            }
        }

        private void LabelClose_Click(object sender, EventArgs e) => Program.QuitProgram();

        private void TextBoxMasterPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UnlockOrLockDataBase();
        }
    
        private void ButtonLockUnlock_Click(object sender, EventArgs e) => UnlockOrLockDataBase();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => textBoxMasterPass.PasswordChar
            = textBoxMasterPass.PasswordChar == '*'
            ? textBoxMasterPass.PasswordChar = '\0'
            : textBoxMasterPass.PasswordChar = '*';
        #endregion

        #region Sidepanel buttons
        private void SelectNullForm()
        {
            CleanCurrentForm();
            Select(null);
        }

        private void LabelAccounts_Click(object sender, EventArgs e)
        {
            CleanCurrentForm();
            Select(labelAccounts);
            currentForm = new AccountManagerView(DataBase);
            ShowCurrentForm();
        }

        private void LabelNotes_Click(object sender, EventArgs e)
        {
            CleanCurrentForm();
            Select(labelNotes);
            // TODO: definir função do NoteView currentForm = new NoteManagerView();
            currentForm = new CommingSoonView(DataBase);
            ShowCurrentForm();
        }

        private void LabelPersonalInfo_Click(object sender, EventArgs e)
        {
            CleanCurrentForm();
            Select(labelPersonalInfo);
            currentForm = new PersonalIManagerView(DataBase);
            ((PersonalIManagerView)currentForm).PersonalInfoUpdated += MainForm_PersonalInfoUpdated;
            ShowCurrentForm();
        }
  
        private void LabelCards_Click(object sender, EventArgs e)
        {
            CleanCurrentForm();
            Select(labelCards);
            // TODO: currentForm = new CardManagerView();
            currentForm = new CommingSoonView(DataBase);
            ShowCurrentForm();
        }

        private void LabelSettings_Click(object sender, EventArgs e)
        {
            CleanCurrentForm();
            Select(labelSettings);
            currentForm = new SettingsManagerView(DataBase);
            ((SettingsManagerView)currentForm).GotoMenu += MainForm_GotoMenu;
            ShowCurrentForm();
        }

        private void CleanCurrentForm()
        {
            if (currentForm != null)
            {
                panelContainer.Controls.Clear();
                currentForm.Dispose();
                currentForm.Close();
                currentForm = null;
            }
        }

        private void Select(Label label)
        {
            foreach (var lbl in sideLabels)
                lbl.BackColor = Color.FromArgb(0, 0, 32);

            if(label != null)
                label.BackColor = Color.FromArgb(0, 16, 64);
        }

        private void ShowCurrentForm()
        {
            panelContainer.Controls.Add(currentForm);
            currentForm.Show();
        }
        #endregion

        private void MainForm_GotoMenu()
        {
            Save();
            Program.SwitchForms(this, new OCDataBaseView());
        }

        private void MainForm_PersonalInfoUpdated(string name, string mail, string rg, string cpf, string imagepath)
        {
            DataBase.PersonalInfo.Name = name;
            DataBase.PersonalInfo.Email = mail;
            DataBase.PersonalInfo.Rg = rg;
            DataBase.PersonalInfo.Cpf = cpf;
            DataBase.PersonalInfo.ImagePath = imagepath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Save(); 
    }
}