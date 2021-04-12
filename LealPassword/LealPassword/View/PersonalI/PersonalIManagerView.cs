using LealPassword.DataBases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.View.PersonalI
{
    internal sealed partial class PersonalIManagerView : Form, ISubView
    {
        internal PersonalIManagerView(DataBase database)
            : this(database, null) { }

        internal PersonalIManagerView(DataBase database, Image image)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);

            if (image != null)
                panel1.BackgroundImage = image;

            DataBase = database;
            UpdateColor();
        }

        internal DataBase DataBase { get; }

        internal delegate void UpdateImage(string oldpath, string newpath);
        internal event UpdateImage ImageUpdated;

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;

            textBoxName.BackColor = BackColor;
            textBoxEmail.BackColor = BackColor;
            textBoxRg.BackColor = BackColor;
            textBoxCpf.BackColor = BackColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

        private void PersonalIManagerView_Load(object sender, EventArgs e)
        {
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

            DataBase.PersonalInfo.Name = name;
            DataBase.PersonalInfo.Email = mail;
            DataBase.PersonalInfo.Rg = rg;
            DataBase.PersonalInfo.Cpf = cpf; 
        }

        private bool CheckString(string val) => string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);

        private void EditMode(bool mode)
        {
            buttonSave.Visible = mode;
            labelEdit.Visible = !mode;

            textBoxName.Enabled = mode;
            textBoxEmail.Enabled = mode;
            textBoxRg.Enabled = mode;
            textBoxCpf.Enabled = mode;
        }

        private void ButtonUpPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher imagem";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                panel1.BackgroundImage = new Bitmap(path);
                ImageUpdated?.Invoke(DataBase.PersonalInfo.ImagePath, path);
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
