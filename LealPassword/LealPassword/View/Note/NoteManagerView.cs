using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LealPassword.View.Note
{
    internal sealed partial class NoteManagerView : Form
    {
        internal NoteManagerView()
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
        }
    }
}
