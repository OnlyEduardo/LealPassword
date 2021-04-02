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
            Dock = DockStyle.Top;
            Height = 40;

            var lblName = GenerateLabel(register.Name, true);
            var lblUser = GenerateLabel(register.User);
            var lblPass = GenerateLabel("***********");
            var lblMail = GenerateLabel(register.Email);
            var lblTag = GenerateLabel(register.Tag.Name);
            // editlabel
            // deletelabel

            Controls.Add(lblTag);
            Controls.Add(lblMail);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblName);

            MouseEnter += PanelRegister_MouseEnter;
            MouseLeave += PanelRegister_MouseLeave;
            Register = register;
        }

        internal Register Register { get; }

        private Label GenerateLabel(string text, bool bold = false) => new Label()
        {
            Text = text,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Verdana", 12, bold ? FontStyle.Bold : FontStyle.Regular),
        };

        private void PanelRegister_MouseEnter(object sender, EventArgs e)
        {
            // TODO: Mostrar icones de edição e delete;
        }

        private void PanelRegister_MouseLeave(object sender, EventArgs e)
        {
           // TODO: Ocultar icones de edição e delete;
        }       
    }
}
