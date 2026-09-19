namespace SteliaGUI
{
    partial class LoginForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSteliaTop = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblFashionMarket = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.lblHero1 = new System.Windows.Forms.Label();
            this.lblHero2 = new System.Windows.Forms.Label();
            this.lblHero3 = new System.Windows.Forms.Label();
            this.lblHero4 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblBrands = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblSignInTop = new System.Windows.Forms.Label();
            this.pnlTopLine = new System.Windows.Forms.Panel();
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblRoleTag = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNewTo = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblSecure = new System.Windows.Forms.Label();
            this.lblBrands2 = new System.Windows.Forms.Label();
            this.lblDeals = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Text = "Stelia Fashion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // LEFT PANEL
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(720, 680);

            // Top left — STELIA
            this.lblSteliaTop.Text = "S T E L I A";
            this.lblSteliaTop.Font = new System.Drawing.Font("Century Gothic", 11, System.Drawing.FontStyle.Regular);
            this.lblSteliaTop.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblSteliaTop.Location = new System.Drawing.Point(50, 35);
            this.lblSteliaTop.Size = new System.Drawing.Size(200, 25);

            // Top right — SS · 2026
            this.lblSeason.Text = "S S  ·  2 0 2 6";
            this.lblSeason.Font = new System.Drawing.Font("Century Gothic", 9);
            this.lblSeason.ForeColor = System.Drawing.Color.FromArgb(120, 100, 70);
            this.lblSeason.Location = new System.Drawing.Point(580, 38);
            this.lblSeason.Size = new System.Drawing.Size(120, 20);

            // FASHION MARKETPLACE tag
            this.lblDash.Text = "——";
            this.lblDash.Font = new System.Drawing.Font("Century Gothic", 9);
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblDash.Location = new System.Drawing.Point(50, 155);
            this.lblDash.Size = new System.Drawing.Size(40, 20);

            this.lblFashionMarket.Text = "F A S H I O N   M A R K E T P L A C E";
            this.lblFashionMarket.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblFashionMarket.ForeColor = System.Drawing.Color.FromArgb(150, 130, 90);
            this.lblFashionMarket.Location = new System.Drawing.Point(100, 158);
            this.lblFashionMarket.Size = new System.Drawing.Size(400, 18);

            // Hero text — "Wear"
            this.lblHero1.Text = "Wear";
            this.lblHero1.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Regular);
            this.lblHero1.ForeColor = System.Drawing.Color.White;
            this.lblHero1.Location = new System.Drawing.Point(45, 185);
            this.lblHero1.Size = new System.Drawing.Size(400, 90);
            this.lblHero1.AutoSize = false;

            // Hero text — "what" in gold italic
            this.lblHero2.Text = "what";
            this.lblHero2.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Italic);
            this.lblHero2.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblHero2.Location = new System.Drawing.Point(45, 268);
            this.lblHero2.Size = new System.Drawing.Size(400, 90);
            this.lblHero2.AutoSize = false;

            // Hero text — "moves"
            this.lblHero3.Text = "moves";
            this.lblHero3.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Regular);
            this.lblHero3.ForeColor = System.Drawing.Color.White;
            this.lblHero3.Location = new System.Drawing.Point(45, 348);
            this.lblHero3.Size = new System.Drawing.Size(450, 90);
            this.lblHero3.AutoSize = false;

            // Hero text — "you." in gold italic
            this.lblHero4.Text = "you.";
            this.lblHero4.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Italic);
            this.lblHero4.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblHero4.Location = new System.Drawing.Point(45, 428);
            this.lblHero4.Size = new System.Drawing.Size(400, 90);
            this.lblHero4.AutoSize = false;

            // Description
            this.lblDesc.Text = "Pakistan's first curated multi-brand fashion\ndestination. Discover exclusive deals from the\ncountry's most coveted labels, all in one place.";
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Regular);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(130, 115, 90);
            this.lblDesc.Location = new System.Drawing.Point(50, 525);
            this.lblDesc.Size = new System.Drawing.Size(380, 70);

            // Bottom brands
            this.lblBrands.Text = "SAPPHIRE   ·   OUTFITTERS   ·   ZEEN   ·   ETHNIC   ·   CHARIZMA";
            this.lblBrands.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Regular);
            this.lblBrands.ForeColor = System.Drawing.Color.FromArgb(100, 85, 60);
            this.lblBrands.Location = new System.Drawing.Point(50, 645);
            this.lblBrands.Size = new System.Drawing.Size(620, 20);

            // RIGHT PANEL
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.pnlRight.Location = new System.Drawing.Point(720, 0);
            this.pnlRight.Size = new System.Drawing.Size(380, 680);

            // SIGN IN top label
            this.lblSignInTop.Text = "S I G N  I N";
            this.lblSignInTop.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblSignInTop.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblSignInTop.Location = new System.Drawing.Point(40, 38);
            this.lblSignInTop.Size = new System.Drawing.Size(100, 18);

            // Top line decoration
            this.pnlTopLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlTopLine.Location = new System.Drawing.Point(115, 45);
            this.pnlTopLine.Size = new System.Drawing.Size(220, 1);

            // Welcome
            this.lblWelcome1.Text = "Welcome";
            this.lblWelcome1.Font = new System.Drawing.Font("Palatino Linotype", 28, System.Drawing.FontStyle.Regular);
            this.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.lblWelcome1.Location = new System.Drawing.Point(40, 75);
            this.lblWelcome1.Size = new System.Drawing.Size(300, 50);

            // back. in gold italic
            this.lblWelcome2.Text = "back.";
            this.lblWelcome2.Font = new System.Drawing.Font("Palatino Linotype", 28, System.Drawing.FontStyle.Italic);
            this.lblWelcome2.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblWelcome2.Location = new System.Drawing.Point(40, 118);
            this.lblWelcome2.Size = new System.Drawing.Size(300, 50);

            // Subtitle
            this.lblSubtitle.Text = "Enter your details to access your account";
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblSubtitle.Location = new System.Drawing.Point(40, 168);
            this.lblSubtitle.Size = new System.Drawing.Size(320, 18);

            // I AM A label
            this.lblRoleTag.Text = "I  A M  A";
            this.lblRoleTag.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblRoleTag.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblRoleTag.Location = new System.Drawing.Point(40, 205);
            this.lblRoleTag.Size = new System.Drawing.Size(300, 16);

            // Role ComboBox — flat underline style
            this.cmbRole.Location = new System.Drawing.Point(40, 225);
            this.cmbRole.Size = new System.Drawing.Size(300, 28);
            this.cmbRole.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] {
                "Customer", "Admin", "Employee", "Delivery"
            });
            this.cmbRole.SelectedIndex = 0;

            // Role underline
            this.pnlLine1.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine1.Location = new System.Drawing.Point(40, 255);
            this.pnlLine1.Size = new System.Drawing.Size(300, 1);

            // Username label
            this.lblUsername.Text = "U S E R N A M E";
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblUsername.Location = new System.Drawing.Point(40, 272);
            this.lblUsername.Size = new System.Drawing.Size(300, 16);

            // Username textbox
            this.txtUsername.Location = new System.Drawing.Point(40, 292);
            this.txtUsername.Size = new System.Drawing.Size(300, 28);
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Username underline
            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine2.Location = new System.Drawing.Point(40, 322);
            this.pnlLine2.Size = new System.Drawing.Size(300, 1);

            // Password label
            this.lblPassword.Text = "P A S S W O R D";
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblPassword.Location = new System.Drawing.Point(40, 340);
            this.lblPassword.Size = new System.Drawing.Size(300, 16);

            // Password textbox
            this.txtPassword.Location = new System.Drawing.Point(40, 360);
            this.txtPassword.Size = new System.Drawing.Size(300, 28);
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.PasswordChar = '●';

            // Password underline
            this.pnlLine3.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine3.Location = new System.Drawing.Point(40, 390);
            this.pnlLine3.Size = new System.Drawing.Size(300, 1);

            // ENTER STELIA button
            this.btnLogin.Text = "E N T E R  S T E L I A   →";
            this.btnLogin.Location = new System.Drawing.Point(40, 420);
            this.btnLogin.Size = new System.Drawing.Size(300, 52);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9, System.Drawing.FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // New to Stelia?
            this.lblNewTo.Text = "New to Stelia?";
            this.lblNewTo.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblNewTo.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblNewTo.Location = new System.Drawing.Point(40, 490);
            this.lblNewTo.Size = new System.Drawing.Size(130, 20);

            // Create account link button
            this.btnSignUp.Text = "Create an account";
            this.btnSignUp.Location = new System.Drawing.Point(168, 488);
            this.btnSignUp.Size = new System.Drawing.Size(160, 22);
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            // Bottom stats
            this.lblSecure.Text = "SECURE";
            this.lblSecure.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblSecure.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblSecure.Location = new System.Drawing.Point(40, 645);
            this.lblSecure.Size = new System.Drawing.Size(70, 18);

            this.lblBrands2.Text = "5 BRANDS";
            this.lblBrands2.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblBrands2.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblBrands2.Location = new System.Drawing.Point(150, 645);
            this.lblBrands2.Size = new System.Drawing.Size(80, 18);

            this.lblDeals.Text = "LIVE DEALS";
            this.lblDeals.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblDeals.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblDeals.Location = new System.Drawing.Point(265, 645);
            this.lblDeals.Size = new System.Drawing.Size(80, 18);

            // Add to LEFT panel
            this.pnlLeft.Controls.Add(this.lblSteliaTop);
            this.pnlLeft.Controls.Add(this.lblSeason);
            this.pnlLeft.Controls.Add(this.lblDash);
            this.pnlLeft.Controls.Add(this.lblFashionMarket);
            this.pnlLeft.Controls.Add(this.lblHero1);
            this.pnlLeft.Controls.Add(this.lblHero2);
            this.pnlLeft.Controls.Add(this.lblHero3);
            this.pnlLeft.Controls.Add(this.lblHero4);
            this.pnlLeft.Controls.Add(this.lblDesc);
            this.pnlLeft.Controls.Add(this.lblBrands);

            // Add to RIGHT panel
            this.pnlRight.Controls.Add(this.lblSignInTop);
            this.pnlRight.Controls.Add(this.pnlTopLine);
            this.pnlRight.Controls.Add(this.lblWelcome1);
            this.pnlRight.Controls.Add(this.lblWelcome2);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblRoleTag);
            this.pnlRight.Controls.Add(this.cmbRole);
            this.pnlRight.Controls.Add(this.pnlLine1);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.pnlLine2);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.pnlLine3);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblNewTo);
            this.pnlRight.Controls.Add(this.btnSignUp);
            this.pnlRight.Controls.Add(this.lblSecure);
            this.pnlRight.Controls.Add(this.lblBrands2);
            this.pnlRight.Controls.Add(this.lblDeals);

            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);

            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTopLine;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.Label lblSteliaTop;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label lblFashionMarket;
        private System.Windows.Forms.Label lblHero1;
        private System.Windows.Forms.Label lblHero2;
        private System.Windows.Forms.Label lblHero3;
        private System.Windows.Forms.Label lblHero4;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Label lblSignInTop;
        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRoleTag;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNewTo;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblSecure;
        private System.Windows.Forms.Label lblBrands2;
        private System.Windows.Forms.Label lblDeals;
    }
}