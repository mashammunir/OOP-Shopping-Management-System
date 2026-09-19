using System;
using System.Windows.Forms;

namespace SteliaGUI
{
    public partial class CustomInputBox : Form
    {
        public string InputValue { get; private set; } = "";

        public CustomInputBox(string message, string title = "Stelia Fashion")
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
        }

        public static string Show(string message, string title = "Stelia Fashion")
        {
            CustomInputBox box = new CustomInputBox(message, title);
            box.ShowDialog();
            return box.InputValue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InputValue = txtInput.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InputValue = "";
            this.Close();
        }
    }
}