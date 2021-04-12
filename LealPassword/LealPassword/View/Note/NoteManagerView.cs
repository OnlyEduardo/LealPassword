using LealPassword.Data;
using LealPassword.DataBases;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Note
{
    internal sealed partial class NoteManagerView : Form, ISubView
    {
        internal NoteManagerView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            UpdateColor();
        }

        private DataBase DataBase { get; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;
            textBoxCript.BackColor = BackColor;
            textBoxDecript.BackColor = BackColor;
            buttonChooseDecrypt.BackColor = BackColor;
            buttonChooseEncrypt.BackColor = BackColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }

            textBoxCript.ForeColor = DataBase.ForegroundColor;
            textBoxDecript.ForeColor = DataBase.ForegroundColor;
        }

        private void LabelInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui você pode proteger um arquivo de texto, ele será criptografado com uma chave que você escolher. " +
                "Esse arquivo poderá ser aberto em qualquer outro computador desde que possua a senha.",
                "Informação", MessageBoxButtons.OK);
        }

        private void ButtonSearchToEncript(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Arquivo para criptografar";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog1.FileName;
            var key = textBoxCript.Text;

            Console.WriteLine($"Selected path to encrypt-> {path}");

            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                labelError.Text = "Senha inválida";
                return;
            }

            if (SecretFileController.TryEncryptFile(path, key, out string err))
            {
                labelError.Text = "";
                textBoxCript.Text = "";
                MessageBox.Show("Sucesso ao encryptar o arquivo!", "Sucesso", MessageBoxButtons.OK);
            }             
            else
            {
                labelError.Text = err;
            }
        }

        private void ButtonSearchToDecript(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Arquivo para descriptografar";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog1.FileName;
            var key = textBoxDecript.Text;

            Console.WriteLine($"Selected path to decrypt-> {path}");


            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                labelError.Text = "Senha inválida";
                return;
            }

            if (SecretFileController.TryDecryptFile(path, key, out string err))
            {
                labelError.Text = "";
                textBoxDecript.Text = "";
                MessageBox.Show("Sucesso ao descriptografar o arquivo!", "Sucesso", MessageBoxButtons.OK);
            }
            else
            {
                labelError.Text = err;
            }
        }
    }
}
