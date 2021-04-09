using LealPassword.DataBases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.View.PersonalI
{
    internal sealed partial class PersonalIManagerView : Form, ISubForm
    {
        internal PersonalIManagerView(DataBase database)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = database;
            UpdateColor();
        }

        internal delegate void PersonalInfoEvent(string name, string mail, string rg, string cpf, string imagepath);
        internal event PersonalInfoEvent PersonalInfoUpdated;
     
        internal DataBase DataBase { get; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

        private void PersonalIManagerView_Load(object sender, EventArgs e)
        {
            var path = DataBase.PersonalInfo.ImagePath;

            if (System.IO.File.Exists(path))
                panel1.BackgroundImage = new Bitmap(path);

            textBoxName.Text = DataBase.PersonalInfo.Name;
            textBoxEmail.Text = DataBase.PersonalInfo.Email;
            textBoxRg.Text = DataBase.PersonalInfo.Rg;
            textBoxCpf.Text = DataBase.PersonalInfo.Cpf;
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

            PersonalInfoUpdated?.Invoke(name, mail, rg, cpf, DataBase.PersonalInfo.ImagePath);
        }

        private bool CheckString(string val) => string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);

        private void EditMode(bool mode)
        {
            buttonSave.Visible = mode;
            labelEdit.Visible = !mode;
            textBoxName.Enabled = !mode;
            textBoxEmail.Enabled = !mode;
            textBoxRg.Enabled = !mode;
            textBoxCpf.Enabled = !mode;
        }

        private void ButtonUpPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher imagem";
            openFileDialog1.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                panel1.BackgroundImage = new Bitmap(path);

                DataBase.PersonalInfo.ImagePath = path;
            }
        }

        private void PersonalIManagerView_FormClosing(object sender, FormClosingEventArgs e) => panel1.Dispose();

        private void Button1_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxName.Text);

        private void Button2_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxEmail.Text);

        private void Button3_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxRg.Text);

        private void Button4_Click(object sender, EventArgs e) => Program.CopyToClipBoard(textBoxCpf.Text);
    }
}
