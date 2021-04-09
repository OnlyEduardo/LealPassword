using LealPassword.Data;
using LealPassword.Diagnostics;
using System;
using System.Windows.Forms;

namespace LealPassword.Exceptions
{
    internal sealed class ExceptionTreat : Exception
    { 
        internal ExceptionTreat(string message, Exception exception, bool noask = false) : base(message)
        {
            if (noask)
            {
                MessageBox.Show("Infelizmente não foi possível gerar o arquivo de diagnostico ", "Erro grave", MessageBoxButtons.YesNo);
                return;
            }

            var msg = $"Houve um erro grave ao {message}, por isso o programa vai desligar.\n\n" +
                $"Deseja gerar o arquivo de diagnostico na área de trabalho ?";
            LogBag.AddErrorLog(exception);
            MessageBox.Show(msg, "Erro grave", MessageBoxButtons.YesNo);

            WriteController.WriteLog();
        } 
    }
}
