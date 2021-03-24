using LealPassword.View;
using System;
using System.Windows.Forms;

namespace LealPassword
{
    internal static class Program
    {
        internal const int WM_NCLBUTTONDOWN = 0xA1;
        internal const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern bool ReleaseCapture();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OCDataBaseView());
        }

        internal static void DragAndDrop(MouseEventArgs e, IntPtr handle)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        internal static void RestartProgram() => Application.Restart();
        internal static void QuitProgram() => Application.Restart();

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
            } catch
            {
                MessageBox.Show($"Não foi possível abrir o site {url}", "Erro desconhecido", MessageBoxButtons.OK);
            }
        }
        internal static void CopyToClipBoard(string text) => Clipboard.SetText(text);
    }
}
