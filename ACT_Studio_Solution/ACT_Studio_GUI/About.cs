using System.Diagnostics;

namespace ACT.Studio.GUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            string command = "mailto:info[at]ivolt.io?subject=ACT Studio - Contact Request (About Page)";
            Process.Start(command);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https:/www.act-net.us/");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }
    }
}