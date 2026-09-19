namespace SteliaGUI
{
    partial class SignUpForm
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
            this.lblHero1 = new System.Windows.Forms.Label();
            this.lblHero2 = new System.Windows.Forms.Label();
            this.lblHero3 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblBrands = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblJoinTop = new System.Windows.Forms.Label();
            this.pnlTopLine = new System.Windows.Forms.Panel();
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.pnlLine4 = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // MAIN FORM
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Text = "Stelia Fashion — Join Us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // LEFT PANEL
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Size = new System.Drawing.Size(720, 680);

            this.lblSteliaTop.Text = "S T E L I A";
            this.lblSteliaTop.Font = new System.Drawing.Font("Century Gothic", 11);
            this.lblSteliaTop.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblSteliaTop.Location = new System.Drawing.Point(50, 35);
            this.lblSteliaTop.Size = new System.Drawing.Size(200, 25);

            this.lblHero1.Text = "Join";
            this.lblHero1.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Regular);
            this.lblHero1.ForeColor = System.Drawing.Color.White;
            this.lblHero1.Location = new System.Drawing.Point(45, 185);
            this.lblHero1.Size = new System.Drawing.Size(400, 90);
            this.lblHero1.AutoSize = false;

            this.lblHero2.Text = "the";
            this.lblHero2.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Italic);
            this.lblHero2.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblHero2.Location = new System.Drawing.Point(45, 268);
            this.lblHero2.Size = new System.Drawing.Size(400, 90);
            this.lblHero2.AutoSize = false;

            this.lblHero3.Text = "elite.";
            this.lblHero3.Font = new System.Drawing.Font("Palatino Linotype", 52, System.Drawing.FontStyle.Regular);
            this.lblHero3.ForeColor = System.Drawing.Color.White;
            this.lblHero3.Location = new System.Drawing.Point(45, 348);
            this.lblHero3.Size = new System.Drawing.Size(450, 90);
            this.lblHero3.AutoSize = false;

            this.lblDesc.Text = "Create your account and discover\nexclusive fashion deals from Pakistan's\nmost coveted luxury brands.";
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(130, 115, 90);
            this.lblDesc.Location = new System.Drawing.Point(50, 470);
            this.lblDesc.Size = new System.Drawing.Size(380, 70);

            this.lblBrands.Text = "SAPPHIRE   ·   OUTFITTERS   ·   ZEEN   ·   ETHNIC   ·   CHARIZMA";
            this.lblBrands.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblBrands.ForeColor = System.Drawing.Color.FromArgb(100, 85, 60);
            this.lblBrands.Location = new System.Drawing.Point(50, 645);
            this.lblBrands.Size = new System.Drawing.Size(620, 20);

            // RIGHT PANEL
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.pnlRight.Location = new System.Drawing.Point(720, 0);
            this.pnlRight.Size = new System.Drawing.Size(380, 680);

            this.lblJoinTop.Text = "J O I N  U S";
            this.lblJoinTop.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblJoinTop.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblJoinTop.Location = new System.Drawing.Point(40, 38);
            this.lblJoinTop.Size = new System.Drawing.Size(100, 18);

            this.pnlTopLine.BackColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.pnlTopLine.Location = new System.Drawing.Point(130, 45);
            this.pnlTopLine.Size = new System.Drawing.Size(205, 1);

            this.lblWelcome1.Text = "Create your";
            this.lblWelcome1.Font = new System.Drawing.Font("Palatino Linotype", 24, System.Drawing.FontStyle.Regular);
            this.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.lblWelcome1.Location = new System.Drawing.Point(40, 70);
            this.lblWelcome1.Size = new System.Drawing.Size(300, 45);

            this.lblWelcome2.Text = "account.";
            this.lblWelcome2.Font = new System.Drawing.Font("Palatino Linotype", 24, System.Drawing.FontStyle.Italic);
            this.lblWelcome2.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.lblWelcome2.Location = new System.Drawing.Point(40, 110);
            this.lblWelcome2.Size = new System.Drawing.Size(300, 45);

            this.lblSubtitle.Text = "Join Stelia and find your shine";
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 7);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblSubtitle.Location = new System.Drawing.Point(40, 158);
            this.lblSubtitle.Size = new System.Drawing.Size(300, 16);

            // Username
            this.lblUsername.Text = "U S E R N A M E";
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblUsername.Location = new System.Drawing.Point(40, 190);
            this.lblUsername.Size = new System.Drawing.Size(300, 16);

            this.txtUsername.Location = new System.Drawing.Point(40, 210);
            this.txtUsername.Size = new System.Drawing.Size(300, 28);
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pnlLine1.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine1.Location = new System.Drawing.Point(40, 240);
            this.pnlLine1.Size = new System.Drawing.Size(300, 1);

            // Email
            this.lblEmail.Text = "E M A I L";
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblEmail.Location = new System.Drawing.Point(40, 255);
            this.lblEmail.Size = new System.Drawing.Size(300, 16);

            this.txtEmail.Location = new System.Drawing.Point(40, 275);
            this.txtEmail.Size = new System.Drawing.Size(300, 28);
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine2.Location = new System.Drawing.Point(40, 305);
            this.pnlLine2.Size = new System.Drawing.Size(300, 1);

            // Password
            this.lblPassword.Text = "P A S S W O R D";
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblPassword.Location = new System.Drawing.Point(40, 320);
            this.lblPassword.Size = new System.Drawing.Size(300, 16);

            this.txtPassword.Location = new System.Drawing.Point(40, 340);
            this.txtPassword.Size = new System.Drawing.Size(300, 28);
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(20, 15, 10);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.PasswordChar = '●';

            this.pnlLine3.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine3.Location = new System.Drawing.Point(40, 370);
            this.pnlLine3.Size = new System.Drawing.Size(300, 1);

            // Role
            this.lblRole.Text = "I  A M  A";
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 7, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(150, 130, 100);
            this.lblRole.Location = new System.Drawing.Point(40, 385);
            this.lblRole.Size = new System.Drawing.Size(300, 16);

            this.cmbRole.Location = new System.Drawing.Point(40, 405);
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

            this.pnlLine4.BackColor = System.Drawing.Color.FromArgb(180, 160, 120);
            this.pnlLine4.Location = new System.Drawing.Point(40, 435);
            this.pnlLine4.Size = new System.Drawing.Size(300, 1);

            // Create Account button
            this.btnSignUp.Text = "C R E A T E  A C C O U N T   →";
            this.btnSignUp.Location = new System.Drawing.Point(40, 460);
            this.btnSignUp.Size = new System.Drawing.Size(300, 52);
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            // Already have account
            this.lblHaveAccount.Text = "Already have an account?";
            this.lblHaveAccount.Font = new System.Drawing.Font("Century Gothic", 8);
            this.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(160, 140, 110);
            this.lblHaveAccount.Location = new System.Drawing.Point(40, 528);
            this.lblHaveAccount.Size = new System.Drawing.Size(170, 20);

            this.btnBack.Text = "Sign in";
            this.btnBack.Location = new System.Drawing.Point(208, 526);
            this.btnBack.Size = new System.Drawing.Size(80, 22);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(245, 241, 234);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(201, 168, 76);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Add to LEFT
            this.pnlLeft.Controls.Add(this.lblSteliaTop);
            this.pnlLeft.Controls.Add(this.lblHero1);
            this.pnlLeft.Controls.Add(this.lblHero2);
            this.pnlLeft.Controls.Add(this.lblHero3);
            this.pnlLeft.Controls.Add(this.lblDesc);
            this.pnlLeft.Controls.Add(this.lblBrands);

            // Add to RIGHT
            this.pnlRight.Controls.Add(this.lblJoinTop);
            this.pnlRight.Controls.Add(this.pnlTopLine);
            this.pnlRight.Controls.Add(this.lblWelcome1);
            this.pnlRight.Controls.Add(this.lblWelcome2);
            this.pnlRight.Controls.Add(this.lblSubtitle);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.pnlLine1);
            this.pnlRight.Controls.Add(this.lblEmail);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.pnlLine2);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.pnlLine3);
            this.pnlRight.Controls.Add(this.lblRole);
            this.pnlRight.Controls.Add(this.cmbRole);
            this.pnlRight.Controls.Add(this.pnlLine4);
            this.pnlRight.Controls.Add(this.btnSignUp);
            this.pnlRight.Controls.Add(this.lblHaveAccount);
            this.pnlRight.Controls.Add(this.btnBack);

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
        private System.Windows.Forms.Panel pnlLine4;
        private System.Windows.Forms.Label lblSteliaTop;
        private System.Windows.Forms.Label lblHero1;
        private System.Windows.Forms.Label lblHero2;
        private System.Windows.Forms.Label lblHero3;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Label lblJoinTop;
        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnBack;
    }
}