using System;
using System.Windows.Forms;

namespace MessageBoxShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgBox msgBox = new MsgBox("Hello! I'm Message Box!");
            msgBox.Show(this);
        }
    }
}