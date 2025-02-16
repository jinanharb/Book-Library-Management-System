namespace LoginRegistrationForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHomepage = new System.Windows.Forms.Panel();
            this.HomePageBtn = new System.Windows.Forms.Button();
            this.MySpaceCont = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MySpaceBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MyBooksBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FavBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.OverdueBtn = new System.Windows.Forms.Button();
            this.pnAuthors = new System.Windows.Forms.Panel();
            this.AuthorsBtn = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.MySpaceContainer = new System.Windows.Forms.Panel();
            this.MySpaceTransition = new System.Windows.Forms.Timer(this.components);
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnHomepage.SuspendLayout();
            this.MySpaceCont.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnAuthors.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Controls.Add(this.MySpaceContainer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1820, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 33);
            this.CloseBtn.TabIndex = 22;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.menuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBtn.BackgroundImage")));
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuBtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("menuBtn.InitialImage")));
            this.menuBtn.Location = new System.Drawing.Point(6, 16);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(54, 50);
            this.menuBtn.TabIndex = 21;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.sidebar.Controls.Add(this.pnHomepage);
            this.sidebar.Controls.Add(this.MySpaceCont);
            this.sidebar.Controls.Add(this.pnAuthors);
            this.sidebar.Controls.Add(this.pnAdmin);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 72);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(216, 1808);
            this.sidebar.TabIndex = 20;
            // 
            // pnHomepage
            // 
            this.pnHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(125)))), ((int)(((byte)(211)))));
            this.pnHomepage.Controls.Add(this.HomePageBtn);
            this.pnHomepage.Location = new System.Drawing.Point(3, 23);
            this.pnHomepage.Name = "pnHomepage";
            this.pnHomepage.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnHomepage.Size = new System.Drawing.Size(180, 55);
            this.pnHomepage.TabIndex = 1;
            // 
            // HomePageBtn
            // 
            this.HomePageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.HomePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomePageBtn.FlatAppearance.BorderSize = 2;
            this.HomePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageBtn.ForeColor = System.Drawing.Color.White;
            this.HomePageBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomePageBtn.Image")));
            this.HomePageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePageBtn.Location = new System.Drawing.Point(0, 0);
            this.HomePageBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomePageBtn.Name = "HomePageBtn";
            this.HomePageBtn.Size = new System.Drawing.Size(180, 55);
            this.HomePageBtn.TabIndex = 20;
            this.HomePageBtn.Text = "      HomePage";
            this.HomePageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePageBtn.UseVisualStyleBackColor = false;
            this.HomePageBtn.Click += new System.EventHandler(this.HomePageBtn_Click);
            // 
            // MySpaceCont
            // 
            this.MySpaceCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.MySpaceCont.Controls.Add(this.panel3);
            this.MySpaceCont.Controls.Add(this.panel2);
            this.MySpaceCont.Controls.Add(this.panel4);
            this.MySpaceCont.Controls.Add(this.panel7);
            this.MySpaceCont.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MySpaceCont.Location = new System.Drawing.Point(0, 81);
            this.MySpaceCont.Margin = new System.Windows.Forms.Padding(0);
            this.MySpaceCont.Name = "MySpaceCont";
            this.MySpaceCont.Size = new System.Drawing.Size(182, 56);
            this.MySpaceCont.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel3.Controls.Add(this.MySpaceBtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 55);
            this.panel3.TabIndex = 22;
            // 
            // MySpaceBtn
            // 
            this.MySpaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.MySpaceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MySpaceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MySpaceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MySpaceBtn.FlatAppearance.BorderSize = 2;
            this.MySpaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MySpaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySpaceBtn.ForeColor = System.Drawing.Color.White;
            this.MySpaceBtn.Image = ((System.Drawing.Image)(resources.GetObject("MySpaceBtn.Image")));
            this.MySpaceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MySpaceBtn.Location = new System.Drawing.Point(0, 0);
            this.MySpaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MySpaceBtn.Name = "MySpaceBtn";
            this.MySpaceBtn.Size = new System.Drawing.Size(180, 55);
            this.MySpaceBtn.TabIndex = 19;
            this.MySpaceBtn.Text = "       My Space";
            this.MySpaceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MySpaceBtn.UseVisualStyleBackColor = false;
            this.MySpaceBtn.Click += new System.EventHandler(this.MySpaceBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.MyBooksBtn);
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 55);
            this.panel2.TabIndex = 4;
            // 
            // MyBooksBtn
            // 
            this.MyBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.MyBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyBooksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyBooksBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MyBooksBtn.FlatAppearance.BorderSize = 2;
            this.MyBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyBooksBtn.ForeColor = System.Drawing.Color.White;
            this.MyBooksBtn.Image = ((System.Drawing.Image)(resources.GetObject("MyBooksBtn.Image")));
            this.MyBooksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyBooksBtn.Location = new System.Drawing.Point(0, 0);
            this.MyBooksBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MyBooksBtn.Name = "MyBooksBtn";
            this.MyBooksBtn.Size = new System.Drawing.Size(180, 55);
            this.MyBooksBtn.TabIndex = 30;
            this.MyBooksBtn.Text = "       MyBooks";
            this.MyBooksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyBooksBtn.UseVisualStyleBackColor = false;
            this.MyBooksBtn.Click += new System.EventHandler(this.MyBooksBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(360, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 55);
            this.panel4.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel6.Controls.Add(this.FavBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 55);
            this.panel6.TabIndex = 6;
            // 
            // FavBtn
            // 
            this.FavBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FavBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.FavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FavBtn.FlatAppearance.BorderSize = 2;
            this.FavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavBtn.ForeColor = System.Drawing.Color.White;
            this.FavBtn.Image = ((System.Drawing.Image)(resources.GetObject("FavBtn.Image")));
            this.FavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavBtn.Location = new System.Drawing.Point(0, 0);
            this.FavBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Size = new System.Drawing.Size(180, 55);
            this.FavBtn.TabIndex = 29;
            this.FavBtn.Text = "       Favorites";
            this.FavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavBtn.UseVisualStyleBackColor = false;
            this.FavBtn.Click += new System.EventHandler(this.FavBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.OverdueBtn);
            this.panel7.Location = new System.Drawing.Point(543, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 55);
            this.panel7.TabIndex = 5;
            // 
            // OverdueBtn
            // 
            this.OverdueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.OverdueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverdueBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverdueBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OverdueBtn.FlatAppearance.BorderSize = 2;
            this.OverdueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverdueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverdueBtn.ForeColor = System.Drawing.Color.White;
            this.OverdueBtn.Image = ((System.Drawing.Image)(resources.GetObject("OverdueBtn.Image")));
            this.OverdueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverdueBtn.Location = new System.Drawing.Point(0, 0);
            this.OverdueBtn.Margin = new System.Windows.Forms.Padding(0);
            this.OverdueBtn.Name = "OverdueBtn";
            this.OverdueBtn.Size = new System.Drawing.Size(180, 55);
            this.OverdueBtn.TabIndex = 30;
            this.OverdueBtn.Text = "       Overdue";
            this.OverdueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverdueBtn.UseVisualStyleBackColor = false;
            this.OverdueBtn.Click += new System.EventHandler(this.OverdueBtn_Click);
            // 
            // pnAuthors
            // 
            this.pnAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.pnAuthors.Controls.Add(this.AuthorsBtn);
            this.pnAuthors.Location = new System.Drawing.Point(3, 140);
            this.pnAuthors.Name = "pnAuthors";
            this.pnAuthors.Size = new System.Drawing.Size(180, 55);
            this.pnAuthors.TabIndex = 3;
            // 
            // AuthorsBtn
            // 
            this.AuthorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.AuthorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AuthorsBtn.FlatAppearance.BorderSize = 2;
            this.AuthorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorsBtn.ForeColor = System.Drawing.Color.White;
            this.AuthorsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AuthorsBtn.Image")));
            this.AuthorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthorsBtn.Location = new System.Drawing.Point(0, 0);
            this.AuthorsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AuthorsBtn.Name = "AuthorsBtn";
            this.AuthorsBtn.Size = new System.Drawing.Size(180, 55);
            this.AuthorsBtn.TabIndex = 19;
            this.AuthorsBtn.Text = "      Authors";
            this.AuthorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AuthorsBtn.UseVisualStyleBackColor = false;
            this.AuthorsBtn.Click += new System.EventHandler(this.AuthorsBtn_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.pnLogout.Controls.Add(this.LogoutBtn);
            this.pnLogout.Location = new System.Drawing.Point(3, 262);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(180, 55);
            this.pnLogout.TabIndex = 17;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogoutBtn.FlatAppearance.BorderSize = 2;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(180, 55);
            this.LogoutBtn.TabIndex = 20;
            this.LogoutBtn.Text = "      Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // pnAdmin
            // 
            this.pnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.pnAdmin.Controls.Add(this.adminBtn);
            this.pnAdmin.Location = new System.Drawing.Point(3, 201);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(180, 55);
            this.pnAdmin.TabIndex = 18;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminBtn.FlatAppearance.BorderSize = 2;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Image = ((System.Drawing.Image)(resources.GetObject("adminBtn.Image")));
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.Location = new System.Drawing.Point(0, 0);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(0);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(180, 55);
            this.adminBtn.TabIndex = 18;
            this.adminBtn.Text = "       Admin Panel";
            this.adminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // MySpaceContainer
            // 
            this.MySpaceContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.MySpaceContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySpaceContainer.Location = new System.Drawing.Point(243, 51);
            this.MySpaceContainer.Name = "MySpaceContainer";
            this.MySpaceContainer.Size = new System.Drawing.Size(1635, 1017);
            this.MySpaceContainer.TabIndex = 19;
            // 
            // MySpaceTransition
            // 
            this.MySpaceTransition.Interval = 10;
            this.MySpaceTransition.Tick += new System.EventHandler(this.MySpaceTransition_Tick);
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnHomepage.ResumeLayout(false);
            this.MySpaceCont.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnAuthors.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnAuthors;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Panel pnAdmin;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button AuthorsBtn;
        private System.Windows.Forms.Panel pnHomepage;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Panel MySpaceContainer;
        private System.Windows.Forms.Button HomePageBtn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer MySpaceTransition;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.FlowLayoutPanel MySpaceCont;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MySpaceBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MyBooksBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button FavBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button OverdueBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}