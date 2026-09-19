namespace SteliaGUI
{
    partial class CustomInputBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pnlInputLine = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Text = "";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // HEADER
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(480, 55);

            this.lblTitle.Text = "Stelia Fashion";
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(430, 25);

            // GOLD LINE
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Size = new System.Drawing.Size(480, 2);

            // CONTENT
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.pnlContent.Location = new System.Drawing.Point(0, 57);
            this.pnlContent.Size = new System.Drawing.Size(480, 223);

            // Message
            this.lblMessage.Text = "";
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblMessage.Location = new System.Drawing.Point(25, 20);
            this.lblMessage.Size = new System.Drawing.Size(430, 20);

            // Input
            this.txtInput.Location = new System.Drawing.Point(25, 48);
            this.txtInput.Size = new System.Drawing.Size(430, 28);
            this.txtInput.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Input line
            this.pnlInputLine.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlInputLine.Location = new System.Drawing.Point(25, 78);
            this.pnlInputLine.Size = new System.Drawing.Size(430, 1);

            // OK Button
            this.btnOk.Text = "C O N F I R M";
            this.btnOk.Location = new System.Drawing.Point(25, 120);
            this.btnOk.Size = new System.Drawing.Size(200, 45);
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // Cancel Button
            this.btnCancel.Text = "C A N C E L";
            this.btnCancel.Location = new System.Drawing.Point(255, 120);
            this.btnCancel.Size = new System.Drawing.Size(200, 45);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ADD CONTROLS
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.lblMessage);
            this.pnlContent.Controls.Add(this.txtInput);
            this.pnlContent.Controls.Add(this.pnlInputLine);
            this.pnlContent.Controls.Add(this.btnOk);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlContent);

            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel pnlInputLine;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}