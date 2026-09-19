namespace SteliaGUI
{
    partial class EmployeeDashboardForm
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
            this.lblEmployeeTag = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlTitleLine = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Text = "Stelia Fashion — Employee";
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

            this.lblEmployeeTag.Text = "EMPLOYEE PANEL";
            this.lblEmployeeTag.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblEmployeeTag.ForeColor = System.Drawing.Color.FromArgb(120, 100, 70);
            this.lblEmployeeTag.Location = new System.Drawing.Point(210, 25);
            this.lblEmployeeTag.Size = new System.Drawing.Size(150, 18);

            this.lblWelcome.Text = "Process & manage orders";
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

            // CONTENT PANEL
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.pnlContent.Location = new System.Drawing.Point(20, 85);
            this.pnlContent.Size = new System.Drawing.Size(1160, 645);

            // Title
            this.lblOrdersTitle.Text = "ORDER MANAGEMENT";
            this.lblOrdersTitle.Font = new System.Drawing.Font("Century Gothic", 16, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.lblOrdersTitle.Location = new System.Drawing.Point(0, 15);
            this.lblOrdersTitle.Size = new System.Drawing.Size(500, 35);

            this.pnlTitleLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlTitleLine.Location = new System.Drawing.Point(0, 55);
            this.pnlTitleLine.Size = new System.Drawing.Size(1160, 2);

            // Update button
            this.btnUpdateStatus.Text = "MARK AS PROCESSING  →";
            this.btnUpdateStatus.Location = new System.Drawing.Point(0, 68);
            this.btnUpdateStatus.Size = new System.Drawing.Size(250, 40);
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            // Orders grid
            this.dgvOrders.Location = new System.Drawing.Point(0, 120);
            this.dgvOrders.Size = new System.Drawing.Size(1160, 510);
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvOrders.RowTemplate.Height = 38;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(232, 224, 213);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvOrders.ColumnHeadersHeight = 40;
            this.dgvOrders.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 10);
            this.dgvOrders.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvOrders.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // ADD CONTROLS
            this.pnlHeader.Controls.Add(this.lblSteliaTop);
            this.pnlHeader.Controls.Add(this.lblEmployeeTag);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);

            this.pnlContent.Controls.Add(this.lblOrdersTitle);
            this.pnlContent.Controls.Add(this.pnlTitleLine);
            this.pnlContent.Controls.Add(this.btnUpdateStatus);
            this.pnlContent.Controls.Add(this.dgvOrders);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlContent);

            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTitleLine;
        private System.Windows.Forms.Label lblSteliaTop;
        private System.Windows.Forms.Label lblEmployeeTag;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}