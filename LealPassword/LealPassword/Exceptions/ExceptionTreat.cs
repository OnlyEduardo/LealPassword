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
                MessageBox.Show("Infelizmente não foi possível gerar o arquivo de diagnostico ", "Erro", MessageBoxButtons.OK);
                MessageBox.Show("Esse é pior erro possível para acontecer, tente desinstalar e instalar o LealPassword novamente.\n\n" +
                    "Caso o erro persista, entre em contato com o desenvolvedor relatando o que você fez para esse erro aparecer.", "Erro", MessageBoxButtons.OK);
                Program.QuitProgram();
                return;
            }

            var msg = $"Houve um erro grave ao {message}, por isso o programa vai desligar.\n\n" +
                $"Deseja gerar o arquivo de diagnostico na área de trabalho ?";
            LogBag.AddErrorLog(exception);

            if (MessageBox.Show(msg, "Erro grave", MessageBoxButtons.YesNo) == DialogResult.Yes)
                WriteController.WriteLog();
        } 
    }
}
