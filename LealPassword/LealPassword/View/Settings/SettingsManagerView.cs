using LealPassword.DataBases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LealPassword.View.Settings
{
    // TODO: Adicionar gerador de diagnostico
    internal sealed partial class SettingsManagerView : Form, ISubForm
    {
        private static readonly Dictionary<string, Color[]> Themes = new Dictionary<string, Color[]>
        {
            {"Padrão", new Color[2]{ Color.White, Color.Black } },
            {"Escuro", new Color[2]{ Color.Black, Color.White } },
            {"Escuro 2", new Color[2]{ Color.FromArgb(43, 47, 54), Color.FromArgb(241, 243, 246) } },
            {"Cinza", new Color[2]{ Color.FromArgb(93, 99, 112), Color.FromArgb(248, 246, 246) } },
            {"Azul", new Color[2]{ Color.FromArgb(29, 126, 238), Color.FromArgb(250, 245, 240) } },
            {"Azul Intenso", new Color[2]{ Color.FromArgb(40, 6, 128), Color.White } },
            {"Roxo intenso", new Color[2]{ Color.FromArgb(25, 13, 27), Color.FromArgb(246, 248, 244) } },
            {"Roxo intenso 2", new Color[2]{ Color.FromArgb(25, 13, 27), Color.FromArgb(80, 179, 219) } },
            {"Vivinti", new Color[2]{ Color.FromArgb(49, 41, 48), Color.FromArgb(240, 243, 243) } },
            {"Mandelel", new Color[2]{ Color.FromArgb(46, 75, 86), Color.FromArgb(244, 244, 241) } },
        };

        private readonly Random rnd;

        internal SettingsManagerView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            rnd = new Random();
            checkBoxSysTray.Checked = dataBase.SystemTray;
            checkBoxAskToSave.Checked = dataBase.AutoSave;
            PopThemes();
            UpdateColor();
        }

        internal delegate void GoBack();
        internal event GoBack GotoMenu;

        internal DataBase DataBase { get; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;
            comboBoxThemes.BackColor = BackColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

        private void PopThemes()
        {
            foreach (var kv in Themes)
                comboBoxThemes.Items.Add(kv.Key);
            comboBoxThemes.SelectedIndex = 0;
        }

        private void CheckBoxSysTray_CheckedChanged(object sender, EventArgs e) => DataBase.SystemTray = checkBoxSysTray.Checked;

        private void CheckBoxAskToSave_CheckedChanged(object sender, EventArgs e) => DataBase.AutoSave = checkBoxAskToSave.Checked;

        private void ButtonBackColorSelector_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = DataBase.BackgroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                DataBase.BackgroundColor = colorDialog1.Color;
                UpdateColor();
            }
        }

        private void ButtonForeColorSelector_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = DataBase.ForegroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                DataBase.ForegroundColor = colorDialog1.Color;
                UpdateColor();
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            var theme = (string) comboBoxThemes.SelectedItem;
            var clrs = Themes[theme];
            DataBase.BackgroundColor = clrs[0];
            DataBase.ForegroundColor = clrs[1];
            UpdateColor();
        }

        private void ButtonGoBack_Click(object sender, EventArgs e) => GotoMenu?.Invoke();

        private void ButtonGenTheme_Click(object sender, EventArgs e)
        {
            bool light = rnd.NextDouble() <= 0.5;

            if (light)
            {
                DataBase.BackgroundColor = Color.FromArgb(rnd.Next(150, 255), rnd.Next(150, 255), rnd.Next(150, 255));
                DataBase.ForegroundColor = Color.FromArgb(rnd.Next(0, 150), rnd.Next(0, 150), rnd.Next(0, 150));
            }
            else 
            {            
                DataBase.BackgroundColor = Color.FromArgb(rnd.Next(0, 150), rnd.Next(0, 150), rnd.Next(0, 150));
                DataBase.ForegroundColor = Color.FromArgb(rnd.Next(150, 255), rnd.Next(150, 255), rnd.Next(150, 255));
            }

            UpdateColor();
        }

        
    }
}
