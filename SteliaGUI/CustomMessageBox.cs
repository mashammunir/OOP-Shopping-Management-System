using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title = "Stelia Fashion")
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
        }

        public static void Show(string message, string title = "Stelia Fashion")
        {
            CustomMessageBox box = new CustomMessageBox(message, title);
            box.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}