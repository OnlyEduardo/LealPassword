using LealPassword.DataBases;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Card
{
    internal sealed partial class CardAddNew : Form
    {
        internal CardAddNew(DataBase dataBase, DataBases.Card card = null)
        {
            InitializeComponent();
            Program.SetDefaultConf(this, card != null ? card.CardName : "Novo cartão");
            DataBase = dataBase;
            Card = card;

            if (card != null)
            {
                buttonCreate.Text = "Ok";
                labelError.Visible = false;

                textBoxApplid.Text = card.CardName;
                textBoxApplid.ReadOnly = true;

                textBoxNumber.Text = card.Number;
                textBoxNumber.ReadOnly = true;

                textBoxOnName.Text = card.OnwerName;
                textBoxOnName.ReadOnly = true;

                dateTimePicker1.Value = card.ValidDate;
                dateTimePicker1.Enabled = false;

                textBoxCvv.Text = card.Cvv;
                textBoxCvv.ReadOnly = true;
            }
        }

        private DataBase DataBase { get; }
        private DataBases.Card Card { get; }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (Card != null)
            {
                Close();
                return;
            }

            var applid = textBoxApplid.Text;
            var onName = textBoxOnName.Text;
            var number = textBoxNumber.Text;
            var valid = dateTimePicker1.Value;
            var cvv = textBoxCvv.Text;

            if (string.IsNullOrEmpty(applid) || string.IsNullOrEmpty(applid))
            {
                labelError.Text = "Apelido do cartão inválido"; return;
            }

            if (string.IsNullOrEmpty(onName) || string.IsNullOrEmpty(onName))
            {
                labelError.Text = "Nome do dono do cartão inválido"; return;
            }

            if (!long.TryParse(number, out long lr) || number.Length < 12)
            {
                labelError.Text = "Número do cartão inválido"; return;
            }

            if (!short.TryParse(cvv, out short sr))
            {
                labelError.Text = "Número CVV inválido"; return;
            }

            try
            {
                DataBase.Cards.Add(new DataBases.Card(applid, onName, number, valid, cvv));
            } catch
            {
                labelError.Text = "Data de validade inválida"; return;
            }
            
            Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
            => textBoxCvv.PasswordChar = textBoxCvv.PasswordChar == '*' ? '\0' : '*';
    }
}
