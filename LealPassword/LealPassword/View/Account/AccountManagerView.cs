using LealPassword.Data;
using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.Extensions;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Account
{
    internal sealed partial class AccountManagerView : Form, ISubView
    {
        private AccountView accountView;

        internal AccountManagerView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            UpdateColor();
            UpdateAccounts();
        }

        internal DataBase DataBase { get; }
        internal OrderMode OrderMode { get; set; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;
            textBoxSearch.BackColor = BackColor;
            comboBoxOrderBy.BackColor = BackColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

        private void UpdateAccounts()
        {
            panelRegisterList.Controls.Clear();

            switch (OrderMode)
            {
                case OrderMode.Tag:
                    DataBase.Registers.Sort((x, y) => x.Tag.Name.CompareTo(y.Tag.Name));
                    break;
                case OrderMode.Name:
                default:
                    DataBase.Registers.Sort((x, y) => x.Name.CompareTo(y.Name));
                    break;
            }
            
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

        private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderMode = comboBoxOrderBy.SelectedIndex == 0 ? OrderMode.Name : OrderMode.Tag;
            UpdateAccounts();
        }
    }
}
