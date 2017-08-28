using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if (newTextBox.Text == "")
            {
                return;
            }

            string newTeam = newTextBox.Text;
            currentTextBox.Text = nsSingleton.Singleton.getInstance(newTeam).getTeamName();
            leaveButton.Enabled = true;

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            nsSingleton.Singleton.getInstance("").delete();
            currentTextBox.Text = "";
            leaveButton.Enabled = false;
        }
    }
}
