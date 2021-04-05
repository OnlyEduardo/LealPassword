using LealPassword.Data;
using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.Extensions;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Account
{
    internal sealed partial class AccountManagerView : Form
    {
        private AccountView accountView;

        internal AccountManagerView()
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            Order = OrderType.Default;
            UpdateAccounts();
        }

        internal DataBase DataBase { get; set; }
        internal OrderType Order { get; set; }

        private void UpdateAccounts()
        {
            DataBase = Data.ReadController.ReadDataBase(Properties.Settings.Default.LastPath);
            panelRegisterList.Controls.Clear();

            for (int i = DataBase.Registers.Count - 1; i >= 0; i--)
            {
                var reg = DataBase.Registers[i];
                var panelReg = new PanelRegister(reg);
                panelReg.ClickedEvent += PanelReg_ClickedEvent;
                panelRegisterList.Controls.Add(panelReg);
            }
        }

        private void Search(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                UpdateAccounts();
                return;
            }

            panelRegisterList.Controls.Clear();

            value = value.ToLower();

            for (int i = DataBase.Registers.Count - 1; i >= 0; i--)
            {
                var reg = DataBase.Registers[i];
                var name = reg.Name.ToLower();
                var tag = reg.Tag.Name.ToLower();

                if (name.Equals(value) || tag.Equals(value) || name.Contains(value) || tag.Contains(value))
                {
                    var panelReg = new PanelRegister(reg);
                    panelReg.ClickedEvent += PanelReg_ClickedEvent;
                    panelRegisterList.Controls.Add(panelReg);
                }
            }
        }

        private void ViewRegister(Register register)
        {
            LogBag.AddNormalLog($"View register '{register.Name}' from database '{DataBase.Name}'");

            if (accountView != null)
                accountView.Dispose();

            accountView = new AccountView(register);
            accountView.Show();
        }

        private void DeleteRegister(Register register)
        {
            var confimation = MessageBox.Show($"Deseja realmente deletar o registro {register.Name} ?", "Aviso", MessageBoxButtons.YesNo);

            if (!confimation.Equals(DialogResult.Yes))
                return;

            LogBag.AddWarningLog($"Deleting register '{register.Name}' from database '{DataBase.Name}'");
            DataBase.Registers.Remove(register);
            WriteController.WriteDataBase(DataBase, Properties.Settings.Default.LastPath);
            UpdateAccounts();
        }

        private void PanelReg_ClickedEvent(bool value, Register register)
        {
            if (value)
                ViewRegister(register);
            else
                DeleteRegister(register);
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            var aan = new AccountAddNew(DataBase);
            aan.Closed += (s, args) => UpdateAccounts();
            aan.Show();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                Search(textBoxSearch.Text);
        }

        private void ButtonSearch_Click(object sender, EventArgs e) => Search(textBoxSearch.Text);
    }
}
