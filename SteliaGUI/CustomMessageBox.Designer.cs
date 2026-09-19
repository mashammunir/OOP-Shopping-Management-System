namespace SteliaGUI
{
    partial class CustomMessageBox
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.ClientSize = new System.Drawing.Size(480, 250);
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
            this.pnlContent.Size = new System.Drawing.Size(480, 193);

            // Message
            this.lblMessage.Text = "";
            this.lblMessage.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(30, 20, 10);
            this.lblMessage.Location = new System.Drawing.Point(25, 25);
            this.lblMessage.Size = new System.Drawing.Size(430, 80);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // OK Button
            this.btnOk.Text = "O K";
            this.btnOk.Location = new System.Drawing.Point(175, 130);
            this.btnOk.Size = new System.Drawing.Size(130, 42);
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 10, System.Drawing.FontStyle.Bold);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // ADD CONTROLS
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.lblMessage);
            this.pnlContent.Controls.Add(this.btnOk);
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
        private System.Windows.Forms.Button btnOk;
    }
}