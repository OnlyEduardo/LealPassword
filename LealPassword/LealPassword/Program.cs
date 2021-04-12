using LealPassword.Data;
using LealPassword.Diagnostics;
using LealPassword.View;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LealPassword
{
    internal static class Program
    {
        internal const int WM_NCLBUTTONDOWN = 0xA1;
        internal const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        internal static extern bool ReleaseCapture();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        internal static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var input = args.Length > 0 ? args[0] : "";

            if (input.EndsWith(Configuration.extension) && File.Exists(input))
            {
                var dataBase = ReadController.ReadDataBase(input);

                Properties.Settings.Default.LastPath = input;
                Properties.Settings.Default.Save();

                Application.Run(new MainView(dataBase));
            }
            else
                Application.Run(new OCDataBaseView());
        }

        internal static void SwitchForms(Form origin, Form target)
        {
            origin.Hide();
            origin.Enabled = false;
            origin.ShowInTaskbar = false;
            origin.ShowIcon = false;

            target.Closed += (s, args) => origin.Close();
            target.ShowInTaskbar = true;
            target.Enabled = true;
            target.ShowIcon = true;
            target.Visible = true;
            target.Show();
        }

        #region Form methods
        internal static void DragAndDrop(MouseEventArgs e, IntPtr handle)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        internal static void ShowCredits()
        {
            var version = Properties.Settings.Default.Version;
            var credits = $"LealPassword - Gerenciador de senhas\n\n" +
                $"Versão {version}\n" +
                $"Copyright © 2021\n" +
                $"By: {Properties.Resources.MyFullName}\n" +
                $"Site: {Properties.Resources.MySite}.";

            MessageBox.Show(credits, "Créditos", MessageBoxButtons.OK);
        }

        internal static void SetDefaultSubFormConf(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.ShowInTaskbar = false; 
            form.TopLevel = false;
        }
        internal static void SetDefaultConf(Form form, string title)
        {
            form.Icon = Properties.Resources.icon_key;
            form.Text = title;
        }
        internal static void SetDefaultConf(Form form) => SetDefaultConf(form, "LealPassword");

        internal static void RestartProgram() => Application.Restart();
        internal static void QuitProgram() => Application.Exit();
        #endregion

        internal static void OpenSite(string url)
        {
            try
            {
                var info = new System.Diagnostics.ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = url,
                };
                System.Diagnostics.Process.Start(info);
                LogBag.AddNormalLog($"Site '{url}' aberto no navegador padrão.");
            } 
            catch
            {
                var erromsg = $"Não foi possível abrir o site {url}";
                MessageBox.Show(erromsg, "Erro", MessageBoxButtons.OK);
                LogBag.AddWarningLog(erromsg);
            }
        }
        internal static void CopyToClipBoard(string text) => Clipboard.SetText(text);

        internal static void OpenDataBase(OCDataBaseView oCDataBaseView, string pathToDatabase)
        {
            var dataBase = ReadController.ReadDataBase(pathToDatabase);
            SwitchForms(oCDataBaseView, new MainView(dataBase));
        }
    }
}
