using LealPassword.DataBases;
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
    internal sealed partial class MainForm : Form
    {
        internal MainForm(DataBase dataBase)
        {
            InitializeComponent();
            DataBase = dataBase;
        }

        private DataBase DataBase { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogBag.AddNormalLog("MainForm loaded with success!");
        }
    }
}
