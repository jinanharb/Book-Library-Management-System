namespace LoginRegistrationForm.View.UserControls
{
    partial class AuthorsInside
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsInside));
            this.panel8 = new System.Windows.Forms.Panel();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel8.Controls.Add(this.GoBackBtn);
            this.panel8.Controls.Add(this.panelContainer);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.AuthorName);
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1636, 1281);
            this.panel8.TabIndex = 6;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.GoBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.GoBackBtn.FlatAppearance.BorderSize = 0;
            this.GoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackBtn.ForeColor = System.Drawing.Color.Black;
            this.GoBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoBackBtn.Image")));
            this.GoBackBtn.Location = new System.Drawing.Point(12, 12);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(55, 47);
            this.GoBackBtn.TabIndex = 27;
            this.GoBackBtn.UseVisualStyleBackColor = false;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(90, 182);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1526, 802);
            this.panelContainer.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(83, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Books by the author";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.ForeColor = System.Drawing.Color.White;
            this.AuthorName.Location = new System.Drawing.Point(763, 24);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(162, 48);
            this.AuthorName.TabIndex = 14;
            this.AuthorName.Text = "Author1";
            // 
            // AuthorsInside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Name = "AuthorsInside";
            this.Size = new System.Drawing.Size(1635, 1017);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Button GoBackBtn;
    }
}
