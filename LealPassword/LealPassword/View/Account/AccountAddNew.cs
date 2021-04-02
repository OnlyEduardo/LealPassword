using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.Text;
using System.Windows.Forms;

namespace LealPassword.View.Account
{
    internal sealed partial class AccountAddNew : Form
    {
        private readonly Random rnd;
        private readonly string alphaLower = "acbdefghijklmnopqrstuvwxyz";
        private readonly string alphaUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string numbers = "0123456789";
        private readonly string special = "!@#$%&*";
       
        internal AccountAddNew(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultConf(this, "Novo registro");
            rnd = new Random();
            DataBase = dataBase;
        }

        private DataBase DataBase { get; }

        private void AccountAddNew_Load(object sender, EventArgs e)
        {
            LogBag.AddNormalLog("AccountAddNew loaded with sucess!");

            if (DataBase.Registers.Count <= 0)
            {
                ButtonNewTag_Click(null, new EventArgs());
                buttonNewTag.Visible = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = textBoxPassword.PasswordChar == '*'
                ? textBoxPassword.PasswordChar = '\0'
                : textBoxPassword.PasswordChar = '*';
        }

        private void ButtonGenPass_Click(object sender, EventArgs e)
        {
            var len = rnd.Next(10, 12);
            var result = new StringBuilder();

            result.Append(alphaLower[rnd.Next(0, alphaLower.Length - 1)]);
            result.Append(alphaUpper[rnd.Next(0, alphaUpper.Length - 1)]);
            result.Append(numbers[rnd.Next(0, numbers.Length - 1)]);
            result.Append(numbers[rnd.Next(0, special.Length - 1)]);

            for (int i = 4; i < len; i++)
            {
                var checker = rnd.Next(0, 3);

                if (checker == 0)
                    result.Append(alphaLower[rnd.Next(0, alphaLower.Length - 1)]);
                else if (checker == 1)
                    result.Append(alphaUpper[rnd.Next(0, alphaUpper.Length - 1)]);
                else if (checker == 2)
                    result.Append(numbers[rnd.Next(0, numbers.Length - 1)]);
                else if (checker == 3)
                    result.Append(numbers[rnd.Next(0, special.Length - 1)]);
            }

            textBoxPassword.Text = result.ToString();
        }

        private void ButtonNewTag_Click(object sender, EventArgs e)
        {
            textBoxTag.Visible = !textBoxTag.Visible;
            comboBoxTags.Visible = !comboBoxTags.Visible;

            buttonNewTag.Text = buttonNewTag.Text.Equals("Nova tag")
                ? "Cancelar"
                : "Nova tag";
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var regname = textBoxRegName.Text;
            var username = textBoxUser.Text;
            var email = textBoxMail.Text;
            var pass = textBoxPassword.Text;
            
            foreach (var reg in DataBase.Registers)
            {
                if (regname.Equals(reg.Name))
                {
                    labelError.Text = "Já existe um registro com esse nome";
                    return;
                }
            }

            if (username.Length < 3)
            {
                labelError.Text = "Nome de usuário deve ter ao menos 3 caracteres";
                return;
            }

            if (email.Length < 10)
            {
                labelError.Text = "Email inválido";
                return;
            }

            if (pass.Length < 3)
            {
                labelError.Text = "Senha extremamente fraca, não é possível criar";
                return;
            }

            if (comboBoxTags.Visible)
                DataBase.Registers.Add(new Register(regname, username, email, pass, new Tag((string)comboBoxTags.SelectedItem)));
            else
                DataBase.Registers.Add(new Register(regname, username, email, pass, new Tag(textBoxTag.Text)));

            Data.WriteController.WriteDataBase(DataBase, Properties.Settings.Default.LastPath);
            Close();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e) => UpdateTextStrength(textBoxPassword.Text);

        private void UpdateTextStrength(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                progressBar1.Value = 0;
                return;
            }

            var strength = 0;

            if (text.Length >= 8)
                strength++;

            // Check digit
            foreach (var c in text)
            {
                if (char.IsDigit(c))
                {
                    strength++;
                    break;
                }
            }
            // Check Upper
            foreach (var c in text)
            {
                if (char.IsUpper(c))
                {
                    strength++;
                    break;
                }
            }
            // Check lower
            foreach (var c in text)
            {
                if (char.IsLower(c))
                {
                    strength++;
                    break;
                }
            }
            // Check especial
            foreach (var c in text)
            {
                if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    strength++;
                    break;
                }
            }

            progressBar1.Value = strength;
        }     
    }
}
