using LealPassword.DataBases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.Extensions
{
    internal sealed class PanelCard : Panel
    {
        private readonly Timer timer;
        private const int delay = 1;
        private const int interval = 500;
        private bool isRunning = false;
        private int count;

        internal PanelCard(Card card)
        {
            Card = card;
            timer = new Timer()
            {
                Interval = interval,
            };
            timer.Tick += Timer_Tick;
            Dock = DockStyle.Top;
            Height = 40;

            var final = card.Number.Substring(card.Number.Length - 5, 4);

            var lbl = new Label()
            {
                AutoSize = false,
                Text = $"Cartão {card.CardName} - final {final}",
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Verdana", 12, FontStyle.Regular),
                Width = 300,
            };

            ViewLabel = GenerateLabel(Properties.Resources.view_32px);
            DeleteLabel = GenerateLabel(Properties.Resources.garbage_32px);

            lbl.MouseEnter += C_MouseEnter;
            lbl.MouseLeave += C_MouseLeave;
            MouseEnter += C_MouseEnter;
            MouseLeave += C_MouseLeave;

            Controls.Add(DeleteLabel);
            Controls.Add(ViewLabel);
            Controls.Add(lbl);

            ViewLabel.Click += LblView;
            DeleteLabel.Click += LblDele;
        }

        private Card Card { get; }
        private Label ViewLabel { get; }
        private Label DeleteLabel { get; }

        internal delegate void ClickedHander(bool value, Card card);
        internal event ClickedHander ClickedEvent;

        private Label GenerateLabel(Image image) => new Label()
        {
            AutoSize = false,
            Cursor = Cursors.Hand,
            Dock = DockStyle.Right,
            ImageAlign = ContentAlignment.MiddleLeft,
            Image = image,
            Width = 48,
            Enabled = true,
            Visible = false,
        };

        private void MouseEnterPanel()
        {
            ViewLabel.Visible = true;
            DeleteLabel.Visible = true;
            count = 0;
            timer.Stop();
            isRunning = false;
        }

        private void MouseLeavePanel()
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (count == delay)
            {
                ViewLabel.Visible = false;
                DeleteLabel.Visible = false;
                count = 0;
                isRunning = false;
                timer.Stop();
                return;
            }

            count++;
        }

        private void LblView(object sender, EventArgs e) => ClickedEvent?.Invoke(true, Card);
        private void LblDele(object sender, EventArgs e) => ClickedEvent?.Invoke(false, Card);
        private void C_MouseEnter(object sender, EventArgs e) => MouseEnterPanel();
        private void C_MouseLeave(object sender, EventArgs e) => MouseLeavePanel();
    }
}
