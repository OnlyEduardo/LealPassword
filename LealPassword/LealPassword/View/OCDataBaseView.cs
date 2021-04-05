using LealPassword.Data;
using LealPassword.DataBases;
using LealPassword.Diagnostics;
using System;
using System.IO;
using System.Windows.Forms;

namespace LealPassword.View
{
    internal sealed partial class OCDataBaseView : Form
    {
        internal OCDataBaseView()
        {
            InitializeComponent();
            Program.SetDefaultConf(this);
            
            if (CheckLastPath()) // lastpath exist
            {
                labelOpenLast.Visible = true;
                var name = Properties.Settings.Default.LastPath;
                labelOpenLast.Text = $"Abrir último: {name}";
            }
        }

        private void OCDataBaseView_Load(object sender, EventArgs e) =>
             LogBag.AddNormalLog("OCDataBaseView loaded with success!");

        private void MouseDownControl(object sender, MouseEventArgs e) => Program.DragAndDrop(e, Handle);

        private void LabelOpenLast_Click(object sender, EventArgs e) => Program.OpenDataBase(this, Properties.Settings.Default.LastPath);

        private void ButtonChooseFileToOpen_Click(object sender, EventArgs e)
        {
            var defaulext = Configuration.extension;
            openFileDialog1.DefaultExt = defaulext;
            openFileDialog1.Filter = $"LealPassword file (*{defaulext})|*{defaulext}";
            var digr = openFileDialog1.ShowDialog();
            
            switch (digr)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    {
                        Properties.Settings.Default.LastPath = openFileDialog1.FileName;
                        break;
                    }
                case DialogResult.None:
                case DialogResult.Cancel:
                case DialogResult.Abort:
                case DialogResult.Retry:
                case DialogResult.Ignore:
                case DialogResult.No:
                default:
                    return;
            }

            Program.OpenDataBase(this, Properties.Settings.Default.LastPath);
        }

        private void ButtonCreateNew_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 2)
            {
                labelError.Visible = true;
                labelError.Text = "Senha mestra muito fraca";
                return;
            }

            if (textBoxName.TextLength < 3)
            {
                labelError.Visible = true;
                labelError.Text = "Nome precisa ter ao menos 3 caracteres";
                return;
            }

            folderBrowserDialog1.Description = "Selecione a pasta para salvar";
            var digr = folderBrowserDialog1.ShowDialog();
            string path;

            switch (digr)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    {
                        path = folderBrowserDialog1.SelectedPath;
                        break;
                    }
                case DialogResult.None:         
                case DialogResult.Cancel:
                case DialogResult.Abort:
                case DialogResult.Retry:
                case DialogResult.Ignore:             
                case DialogResult.No:
                default:
                    return;
            }

            var hash = new Hash(textBoxMasterPass.Text);
            path = Path.Combine(path, $"{textBoxName.Text}{Configuration.extension}");
            WriteController.WriteDataBase(new DataBase(textBoxName.Text, hash, new PersonalInfo()), path);
            Program.OpenDataBase(this, Properties.Settings.Default.LastPath);
        }

        private void TextBoxMasterPass_Tiping(object sender, EventArgs e) => UpdateTextStrength(textBoxMasterPass.Text);

        private void ButtonCreateNewDataBase_Click(object sender, EventArgs e)
        {
            Size = Size == MinimumSize ? MaximumSize : MinimumSize;
            CenterToScreen();
        }           

        private void ButtonCredits_Click(object sender, EventArgs e) => Program.ShowCredits();

        private void LabelClose_Click(object sender, EventArgs e) => Program.QuitProgram();

        private bool CheckLastPath() => ReadController.ExistLastPath();

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) =>
            textBoxMasterPass.PasswordChar = textBoxMasterPass.PasswordChar == '*' ? '\0' : '*';

        private void UpdateTextStrength(string text)
        {
            if (string.IsNullOrEmpty(textBoxMasterPass.Text) || string.IsNullOrWhiteSpace(textBoxMasterPass.Text))
            {
                progressBar1.Value = 0;
                return;
            }

            var strength = 0;

            if (text.Length >= 8)
                strength++;

            // Check digit
            foreach(var c in text)
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

        private void TextBoxMasterPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonCreateNew_Click(sender, e);
        }
    }
}
