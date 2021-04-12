using LealPassword.Data;
using LealPassword.DataBases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using X_Password.Data;

namespace LealPassword.View
{
    internal sealed partial class ConversorView : Form
    {
        internal ConversorView()
        {
            InitializeComponent();
            Program.SetDefaultConf(this, "LealPassword - Conversor");   
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (!MasterPasswordController.ExistMasterPassword())
            {
                labelError.Text = "Nenhum dado do X-Password foi encontrado nesse computador";
                return;
            }
            var masterpass = textBox2.Text;

            if (!MasterPasswordController.CompareStringToMasterHash(masterpass))
            {
                labelError.Text = "Senha mestra não corresponde a senha do X-Password";
                return;
            }
            
            var name = textBox1.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                labelError.Text = "Nome inválido";
                return;
            }

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            var pathfolder = folderBrowserDialog1.SelectedPath;
            var path = Path.Combine(pathfolder, $"{name}{Configuration.extension}");

            var cats = CategoryController.LoadCategories();

            var regs = new List<Register>();

            foreach (var cat in cats)
            {
                foreach (var reg in cat.Registers)
                {
                    regs.Add(new Register(reg.Name, reg.Login, reg.Email, reg.Password, new Tag(cat.Name)));
                }
            }

            var bd = new DataBase(name, new Hash(masterpass), regs);
            WriteController.WriteDataBase(bd, path);

            foreach (var cat in cats)
            {
                CategoryController.RemoveCategory(cat);
            }
            MasterPasswordController.RemoveMasterPassword();

            MessageBox.Show("Banco de dados convertido com sucesso!\n" +
            "Seus dados antigos do X-Password foram excluídos, o programa vai reiniciar agora.", "Sucesso", MessageBoxButtons.OK);

            Properties.Settings.Default.LastPath = path;
            Properties.Settings.Default.Save();
            Program.RestartProgram();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
            => textBox2.PasswordChar =  textBox2.PasswordChar == '*'? '\0' : '*';
    }
}
