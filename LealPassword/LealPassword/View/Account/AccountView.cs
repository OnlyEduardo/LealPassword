using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Account
{
    internal sealed partial class AccountView : Form
    {
        internal AccountView(Register register)
        {
            // TODO: Melhorar design
            InitializeComponent();
            Program.SetDefaultConf(this, $"Registro: {register.Name}");
            ShowInTaskbar = true;
            Register = register;
        }

        private Register Register { get; }

        private void AccountView_Load(object sender, EventArgs e)
        {
            LogBag.AddNormalLog("AccountView loaded with success!");
            textBoxUser.Text = Register.User;
            textBoxMail.Text = Register.Email;
            textBoxPassword.Text = Register.Pass;
        }

        private void Button2_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxUser.Text);

        private void Button3_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxMail.Text);

        private void Button4_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxPassword.Text);

        private void ButtonOk_Click(object sender, EventArgs e) => Dispose();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) =>
            textBoxPassword.PasswordChar = textBoxPassword.PasswordChar == '*' ? '\0' : '*';
    }
}
