using LealPassword.DataBases;
using System.Windows.Forms;

namespace LealPassword.View
{
    internal sealed partial class CommingSoonView : Form, ISubView
    {
        internal CommingSoonView(DataBase dataBase)
        {
            InitializeComponent();
            Program.SetDefaultSubFormConf(this);
            DataBase = dataBase;
            UpdateColor();
        }

        private DataBase DataBase { get; }

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
