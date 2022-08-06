using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT.Studio.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginGunaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void CloseFormGunaControlBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ForgotPasswordGunaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
