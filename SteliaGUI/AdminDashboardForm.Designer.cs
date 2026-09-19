namespace SteliaGUI
{
    partial class AdminDashboardForm
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
            this.lblAdminTag = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.pnlSalesCard1 = new System.Windows.Forms.Panel();
            this.lblTotalOrdersTag = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.pnlSalesCard2 = new System.Windows.Forms.Panel();
            this.lblTotalSalesTag = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Text = "Stelia Fashion — Admin";
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

            this.lblAdminTag.Text = "ADMIN PANEL";
            this.lblAdminTag.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblAdminTag.ForeColor = System.Drawing.Color.FromArgb(120, 100, 70);
            this.lblAdminTag.Location = new System.Drawing.Point(210, 25);
            this.lblAdminTag.Size = new System.Drawing.Size(120, 18);

            this.lblWelcome.Text = "Welcome, Admin!";
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
            this.pnlHeaderLine.Location = new System.Drawing.Point(0, 65);

            // TAB CONTROL
            this.tabControl1.Location = new System.Drawing.Point(20, 80);
            this.tabControl1.Size = new System.Drawing.Size(1160, 650);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabSales);

            // PRODUCTS TAB
            this.tabProducts.Text = "  Manage Products  ";
            this.tabProducts.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);

            this.btnAddProduct.Text = "ADD PRODUCT  +";
            this.btnAddProduct.Location = new System.Drawing.Point(15, 13);
            this.btnAddProduct.Size = new System.Drawing.Size(160, 38);
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            this.btnRemoveProduct.Text = "REMOVE  −";
            this.btnRemoveProduct.Location = new System.Drawing.Point(190, 13);
            this.btnRemoveProduct.Size = new System.Drawing.Size(140, 38);
            this.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.btnRemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.FlatAppearance.BorderSize = 0;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);

            this.btnUpdateProduct.Text = "UPDATE  ✎";
            this.btnUpdateProduct.Location = new System.Drawing.Point(345, 13);
            this.btnUpdateProduct.Size = new System.Drawing.Size(140, 38);
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 1;
            this.btnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnUpdateProduct.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);

            this.dgvProducts.Location = new System.Drawing.Point(15, 62);
            this.dgvProducts.Size = new System.Drawing.Size(1125, 543);
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvProducts.RowTemplate.Height = 38;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(232, 224, 213);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 20, 10);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvProducts.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // USERS TAB
            this.tabUsers.Text = "  All Users  ";
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);

            this.dgvUsers.Location = new System.Drawing.Point(15, 15);
            this.dgvUsers.Size = new System.Drawing.Size(1125, 590);
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvUsers.RowTemplate.Height = 38;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvUsers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // ORDERS TAB
            this.tabOrders.Text = "  All Orders  ";
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);

            this.dgvOrders.Location = new System.Drawing.Point(15, 15);
            this.dgvOrders.Size = new System.Drawing.Size(1125, 590);
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvOrders.RowTemplate.Height = 38;
            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvOrders.ColumnHeadersHeight = 40;
            this.dgvOrders.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvOrders.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // STOCK TAB
            this.tabStock.Text = "  Manage Stock  ";
            this.tabStock.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);

            this.dgvStock.Location = new System.Drawing.Point(15, 15);
            this.dgvStock.Size = new System.Drawing.Size(1125, 590);
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Font = new System.Drawing.Font("Century Gothic", 9);
            this.dgvStock.RowTemplate.Height = 38;
            this.dgvStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.dgvStock.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.dgvStock.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);

            // SALES TAB
            this.tabSales.Text = "  Sales Report  ";
            this.tabSales.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);

            this.pnlSalesCard1.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.pnlSalesCard1.Location = new System.Drawing.Point(80, 80);
            this.pnlSalesCard1.Size = new System.Drawing.Size(400, 180);

            this.lblTotalOrdersTag.Text = "T O T A L  O R D E R S";
            this.lblTotalOrdersTag.Font = new System.Drawing.Font("Century Gothic", 9);
            this.lblTotalOrdersTag.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblTotalOrdersTag.Location = new System.Drawing.Point(30, 35);
            this.lblTotalOrdersTag.Size = new System.Drawing.Size(340, 20);

            this.lblTotalOrders.Text = "0";
            this.lblTotalOrders.Font = new System.Drawing.Font("Palatino Linotype", 48, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblTotalOrders.Location = new System.Drawing.Point(30, 65);
            this.lblTotalOrders.Size = new System.Drawing.Size(340, 90);

            this.pnlSalesCard2.BackColor = System.Drawing.Color.FromArgb(109, 43, 61);
            this.pnlSalesCard2.Location = new System.Drawing.Point(560, 80);
            this.pnlSalesCard2.Size = new System.Drawing.Size(400, 180);

            this.lblTotalSalesTag.Text = "T O T A L  S A L E S";
            this.lblTotalSalesTag.Font = new System.Drawing.Font("Century Gothic", 9);
            this.lblTotalSalesTag.ForeColor = System.Drawing.Color.FromArgb(220, 200, 170);
            this.lblTotalSalesTag.Location = new System.Drawing.Point(30, 35);
            this.lblTotalSalesTag.Size = new System.Drawing.Size(340, 20);

            this.lblTotalSales.Text = "Rs.0";
            this.lblTotalSales.Font = new System.Drawing.Font("Palatino Linotype", 40, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(30, 65);
            this.lblTotalSales.Size = new System.Drawing.Size(340, 90);

            // ADD CONTROLS
            this.pnlHeader.Controls.Add(this.lblSteliaTop);
            this.pnlHeader.Controls.Add(this.lblAdminTag);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);

            this.pnlSalesCard1.Controls.Add(this.lblTotalOrdersTag);
            this.pnlSalesCard1.Controls.Add(this.lblTotalOrders);
            this.pnlSalesCard2.Controls.Add(this.lblTotalSalesTag);
            this.pnlSalesCard2.Controls.Add(this.lblTotalSales);

            this.tabProducts.Controls.Add(this.btnAddProduct);
            this.tabProducts.Controls.Add(this.btnRemoveProduct);
            this.tabProducts.Controls.Add(this.btnUpdateProduct);
            this.tabProducts.Controls.Add(this.dgvProducts);

            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabStock.Controls.Add(this.dgvStock);
            this.tabSales.Controls.Add(this.pnlSalesCard1);
            this.tabSales.Controls.Add(this.pnlSalesCard2);

            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.tabControl1);

            this.pnlHeader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Label lblSteliaTop;
        private System.Windows.Forms.Label lblAdminTag;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnlSalesCard1;
        private System.Windows.Forms.Panel pnlSalesCard2;
        private System.Windows.Forms.Label lblTotalOrdersTag;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalSalesTag;
        private System.Windows.Forms.Label lblTotalSales;
    }
}