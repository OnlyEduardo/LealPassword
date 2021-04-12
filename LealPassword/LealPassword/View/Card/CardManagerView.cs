using LealPassword.DataBases;
using LealPassword.Extensions;
using System;
using System.Windows.Forms;

namespace LealPassword.View.Card
{
    internal sealed partial class CardManagerView : Form, ISubView
    {
        internal CardManagerView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            UpdateColor();
            UpdateCardsList();
        }

        private DataBase DataBase { get; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;
            textBoxSearch.BackColor = BackColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

        private void UpdateCardsList()
        {
            panelCardsList.Controls.Clear();

            for (int i = DataBase.Cards.Count - 1; i >= 0; i--)
            {
                var card = DataBase.Cards[i];
                var ctrol = new PanelCard(card);
                ctrol.ClickedEvent += Ctrol_ClickedEvent;
                panelCardsList.Controls.Add(ctrol);
            }
        }

        private void Search(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                UpdateCardsList();
                return;
            }

            panelCardsList.Controls.Clear();

            value = value.ToLower();

            for (int i = DataBase.Cards.Count - 1; i >= 0; i--)
            {
                var card = DataBase.Cards[i];
                var name = card.CardName.ToLower();
                var tag = card.Number.ToLower();

                if (name.Equals(value) || tag.Equals(value) || name.Contains(value) || tag.Contains(value))
                {
                    var ctrol = new PanelCard(card);
                    ctrol.ClickedEvent += Ctrol_ClickedEvent;
                    panelCardsList.Controls.Add(ctrol);
                }
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            var can = new CardAddNew(DataBase);
            can.Closed += (s, args) => UpdateCardsList();
            can.Show();
        }

        private void ButtonSearch_Click(object sender, EventArgs e) => Search(textBoxSearch.Text);

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                Search(textBoxSearch.Text);
        }

        private void Ctrol_ClickedEvent(bool value, DataBases.Card card)
        {
            if (value)
                ViewRegister(card);
            else
                DeleteRegister(card);
        }

        private void ViewRegister(DataBases.Card card)
        {
            var can = new CardAddNew(DataBase, card);
            can.Show();
        }

        private void DeleteRegister(DataBases.Card card)
        {
            if (MessageBox.Show($"Deseja realmente deletar o cartão {card.CardName} ?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase.Cards.Remove(card);
                UpdateCardsList();
            }
        }
    }
}
