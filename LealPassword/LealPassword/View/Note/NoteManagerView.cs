using LealPassword.DataBases;
using System.Windows.Forms;

namespace LealPassword.View.Note
{
    internal sealed partial class NoteManagerView : Form, ISubForm
    {
        internal NoteManagerView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            UpdateColor();
        }

        public DataBase DataBase { get; }

        public void UpdateColor()
        {
            BackColor = DataBase.BackgroundColor;

            foreach (Control ctrol in Controls)
            {
                ctrol.ForeColor = DataBase.ForegroundColor;
            }
        }

    }
}
