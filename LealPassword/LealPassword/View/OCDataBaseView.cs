using LealPassword.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LealPassword.View
{
    internal sealed partial class OCDataBaseView : Form
    {

        internal OCDataBaseView()
        {
            InitializeComponent();
        }

        private void OCDataBaseView_Load(object sender, EventArgs e)
        {
            LogBag.AddNormalLog("OCDataBaseView loaded with success!");
        }

        private void MouseDownControl(object sender, MouseEventArgs e) => Program.DragAndDrop(e, Handle);

        private void LabelOpenLast_Click(object sender, EventArgs e)
        {

        }
    }
}
