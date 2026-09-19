namespace SteliaGUI
{
    partial class DeliveryDashboardForm
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
            this.lblSteliaTop = new System.Windows.Forms.Label();
            this.lblDeliveryTag = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblDeliveryTitle = new System.Windows.Forms.Label();
            this.pnlTitleLine = new System.Windows.Forms.Panel();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.btnMarkDelivered = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Text = "Stelia Fashion — Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.Font = new System.Drawing.Font("Century Gothic", 9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // HEADER
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1200, 65);

            this.lblSteliaTop.Text = "S T E L I A";
            this.lblSteliaTop.Font = new System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold);
            this.lblSteliaTop.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblSteliaTop.Location = new System.Drawing.Point(30, 18);
            this.lblSteliaTop.Size = new System.Drawing.Size(180, 30);

            this.lblDeliveryTag.Text = "DELIVERY PANEL";
            this.lblDeliveryTag.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblDeliveryTag.ForeColor = System.Drawing.Color.FromArgb(120, 100, 70);
            this.lblDeliveryTag.Location = new System.Drawing.Point(210, 25);
            this.lblDeliveryTag.Size = new System.Drawing.Size(150, 18);

            this.lblWelcome.Text = "Manage & track deliveries";
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 11, System.Drawing.FontStyle.Italic);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(200, 185, 155);
            this.lblWelcome.Location = new System.Drawing.Point(450, 18);
            this.lblWelcome.Size = new System.Drawing.Size(400, 30);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnLogout.Text = "LOGOUT  →";
            this.btnLogout.Location = new System.Drawing.Point(1100, 15);
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Size = new System.Drawing.Size(1200, 2);

            // CONTENT
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.pnlContent.Location = new System.Drawing.Point(20, 85);
            this.pnlContent.Size = new System.Drawing.Size(1160, 645);

            this.lblDeliveryTitle.Text = "DELIVERY MANAGEMENT";
            this.lblDeliveryTitle.Font = new System.Drawing.Font("Century Gothic", 16, System.Drawing.FontStyle.Bold);
            this.lblDeliveryTitle.ForeColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.lblDeliveryTitle.Location = new System.Drawing.Point(0, 15);
            this.lblDeliveryTitle.Size = new System.Drawing.Size(500, 35);

            this.pnlTitleLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlTitleLine.Location = new System.Drawing.Point(0, 55);
            this.pnlTitleLine.Size = new System.Drawing.Size(1160, 2);

            this.btnMarkDelivered.Text = "MARK AS DELIVERED  ✓";
            this.btnMarkDelivered.Location = new System.Drawing.Point(0, 68);
            this.btnMarkDelivered.Size = new System.Drawing.Size(250, 40);
            this.btnMarkDelivered.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnMarkDelivered.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnMarkDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkDelivered.FlatAppearance.BorderSize = 0;
            this.btnMarkDelivered.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnMarkDelivered.Click += new System.EventHandler(this.btnMarkDelivered_Click);

            this.dgvDeliveries.Location = new System.Drawing.Point(0, 120);
            this.dgvDeliveries.Size = new System.Drawing.Size(1160, 510);
            this.dgvDeliveries.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeliveries.RowHeadersVisible = false;
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.ReadOnly = true;
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvDeliveries.RowTemplate.Height = 38;
            this.dgvDeliveries.GridColor = System.Drawing.Color.FromArgb(232, 224, 213);
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvDeliveries.ColumnHeadersHeight = 40;
            this.dgvDeliveries.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeliveries.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 10);
            this.dgvDeliveries.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvDeliveries.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDeliveries.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // ADD CONTROLS
            this.pnlHeader.Controls.Add(this.lblSteliaTop);
            this.pnlHeader.Controls.Add(this.lblDeliveryTag);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);

            this.pnlContent.Controls.Add(this.lblDeliveryTitle);
            this.pnlContent.Controls.Add(this.pnlTitleLine);
            this.pnlContent.Controls.Add(this.btnMarkDelivered);
            this.pnlContent.Controls.Add(this.dgvDeliveries);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlContent);

            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTitleLine;
        private System.Windows.Forms.Label lblSteliaTop;
        private System.Windows.Forms.Label lblDeliveryTag;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDeliveryTitle;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Button btnMarkDelivered;
    }
}