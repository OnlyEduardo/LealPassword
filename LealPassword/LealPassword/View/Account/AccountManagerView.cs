using LealPassword.DataBases;
using LealPassword.Diagnostics;
using LealPassword.Extensions;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Account
{
    internal sealed partial class AccountManagerView : Form
    {
        internal AccountManagerView()
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            UpdateAccounts();
        }

        internal DataBase DataBase { get; set; }

        private void UpdateAccounts()
        {
            LogBag.AddNormalLog("Accounts list view updated");
            DataBase = Data.ReadController.ReadDataBase(Properties.Settings.Default.LastPath);
            panel1.Controls.Clear();

            for (int i = DataBase.Registers.Count - 1; i >= 0; i--)
            {
                var reg = DataBase.Registers[i];
                panel1.Controls.Add(new PanelRegister(reg));
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            var aan = new AccountAddNew(DataBase);
            aan.Closed += (s, args) => UpdateAccounts();
            aan.Show();
        }
    }
}
