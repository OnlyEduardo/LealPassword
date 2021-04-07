using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.View.PersonalI
{
    internal sealed partial class PersonalIManagerView : Form
    {
        internal PersonalIManagerView()
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
        }

        internal delegate void PersonalInfoEvent(string name, string mail, string rg, string cpf);
        internal event PersonalInfoEvent PersonalInfoUpdated;

        private void PersonalIManagerView_Load(object sender, EventArgs e)
        {
            var path = Properties.Settings.Default.PictureImagePath;

            if (System.IO.File.Exists(path))
            {
                panel1.BackgroundImage = new Bitmap(path);
            }
        }

        private void LabelEdit_Click(object sender, EventArgs e) => EditMode(true);

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            EditMode(false);

            var name = textBoxName.Text;
            var mail = textBoxEmail.Text;
            var rg = textBoxRg.Text;
            var cpf = textBoxCpf.Text;

            if (CheckString(name))
            {
                labelError.Text = "Nome não pode ser vazio";
                return;
            }
            else if (CheckString(mail))
            {
                labelError.Text = "Email não pode ser vazio";
                return;
            }
            else if (CheckString(rg))
            {
                labelError.Text = "RG não pode ser vazio";
                return;
            }
            else if (CheckString(cpf))
            {
                labelError.Text = "CPF não pode ser vazio";
                return;
            }

            PersonalInfoUpdated?.Invoke(name, mail, rg, cpf);
        }

        private bool CheckString(string val) => string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);

        private void EditMode(bool mode)
        {
            buttonSave.Visible = mode;
            labelEdit.Visible = !mode;
            textBoxName.ReadOnly = !mode;
            textBoxEmail.ReadOnly = !mode;
            textBoxRg.ReadOnly = !mode;
            textBoxCpf.ReadOnly = !mode;
        }

        private void ButtonUpPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher imagem";
            openFileDialog1.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                panel1.BackgroundImage = new Bitmap(path);
                Properties.Settings.Default.PictureImagePath = path;
                Properties.Settings.Default.Save();
            }
        }
    }
}
