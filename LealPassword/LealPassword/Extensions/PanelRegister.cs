using LealPassword.DataBases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.Extensions
{
    internal sealed class PanelRegister : Panel
    {       
        internal PanelRegister(Register register)
        {
            Register = register;
            Dock = DockStyle.Top;
            Height = 40;

            var lblName = GenerateLabel(register.Name, true);
            var lblUser = GenerateLabel($"Tag: {register.Tag.Name}");
            ViewLabel = GenerateLabel(Properties.Resources.view_32px);
            DeleteLabel = GenerateLabel(Properties.Resources.garbage_32px);

            Controls.Add(DeleteLabel);
            Controls.Add(ViewLabel);
            Controls.Add(lblUser);
            Controls.Add(lblName);

            MouseEnter += PanelRegister_MouseEnter;
            ViewLabel.Click += LblClick;
            ViewLabel.MouseEnter += PanelRegister_MouseEnter;
            ViewLabel.MouseLeave += Label_MouseLeave;;
            DeleteLabel.Click += LblClick;
            DeleteLabel.MouseEnter += PanelRegister_MouseEnter;
            DeleteLabel.MouseLeave += Label_MouseLeave;
        }

        private Register Register { get; }
        private Label ViewLabel { get; }
        private Label DeleteLabel { get; }

        internal delegate void ClickedHander(Label sender, Register register);
        internal event ClickedHander ClickedEvent;

        private Label GenerateLabel(string text, bool bold = false) => new Label()
        {
            AutoSize = false,
            Text = text,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Verdana", 12, bold ? FontStyle.Bold : FontStyle.Regular),
            Width = 200,
        };

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

        private void LblClick(object sender, EventArgs e) => ClickedEvent?.Invoke((Label)sender, Register);
        
        private void MouseEnterPanel()
        {
            ViewLabel.Visible = true;
            DeleteLabel.Visible = true;
        }

        private void MouseLeavePanel()
        {       
            ViewLabel.Visible = false;
            DeleteLabel.Visible = false;
        }

        private void PanelRegister_MouseEnter(object sender, EventArgs e) => MouseEnterPanel();
        private void Label_MouseLeave(object sender, EventArgs e) => MouseLeavePanel();
    }
}
