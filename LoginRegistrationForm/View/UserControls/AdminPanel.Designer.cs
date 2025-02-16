namespace LoginRegistrationForm.View.UserControls
{
    partial class AdminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BookImagePb = new System.Windows.Forms.PictureBox();
            this.AddImgBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IsbnTb = new System.Windows.Forms.TextBox();
            this.AuthorNameTb = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BookNameTb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImagePb)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1642, 1026);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BooksDGV);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 1080);
            this.panel2.TabIndex = 0;
            // 
            // BooksDGV
            // 
            this.BooksDGV.BackgroundColor = System.Drawing.Color.White;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Location = new System.Drawing.Point(56, 471);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.RowHeadersWidth = 62;
            this.BooksDGV.RowTemplate.Height = 28;
            this.BooksDGV.Size = new System.Drawing.Size(996, 484);
            this.BooksDGV.TabIndex = 20;
            this.BooksDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDGV_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(56, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 49);
            this.panel4.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Books List";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel6.Controls.Add(this.BookImagePb);
            this.panel6.Controls.Add(this.AddImgBtn);
            this.panel6.Controls.Add(this.DeleteBtn);
            this.panel6.Controls.Add(this.IsbnTb);
            this.panel6.Controls.Add(this.AuthorNameTb);
            this.panel6.Controls.Add(this.EditBtn);
            this.panel6.Controls.Add(this.BookNameTb);
            this.panel6.Controls.Add(this.SaveBtn);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(56, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1410, 271);
            this.panel6.TabIndex = 18;
            // 
            // BookImagePb
            // 
            this.BookImagePb.BackColor = System.Drawing.Color.White;
            this.BookImagePb.Location = new System.Drawing.Point(807, 13);
            this.BookImagePb.Name = "BookImagePb";
            this.BookImagePb.Size = new System.Drawing.Size(318, 182);
            this.BookImagePb.TabIndex = 28;
            this.BookImagePb.TabStop = false;
            // 
            // AddImgBtn
            // 
            this.AddImgBtn.BackColor = System.Drawing.Color.Silver;
            this.AddImgBtn.ForeColor = System.Drawing.Color.White;
            this.AddImgBtn.Location = new System.Drawing.Point(716, 22);
            this.AddImgBtn.Name = "AddImgBtn";
            this.AddImgBtn.Size = new System.Drawing.Size(67, 54);
            this.AddImgBtn.TabIndex = 27;
            this.AddImgBtn.Text = "Add Image";
            this.AddImgBtn.UseVisualStyleBackColor = false;
            this.AddImgBtn.Click += new System.EventHandler(this.AddImgBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Silver;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(1240, 214);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 44);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IsbnTb
            // 
            this.IsbnTb.Location = new System.Drawing.Point(499, 50);
            this.IsbnTb.Name = "IsbnTb";
            this.IsbnTb.Size = new System.Drawing.Size(165, 26);
            this.IsbnTb.TabIndex = 7;
            // 
            // AuthorNameTb
            // 
            this.AuthorNameTb.Location = new System.Drawing.Point(274, 52);
            this.AuthorNameTb.Name = "AuthorNameTb";
            this.AuthorNameTb.Size = new System.Drawing.Size(173, 26);
            this.AuthorNameTb.TabIndex = 6;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Silver;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(1077, 213);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(115, 44);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BookNameTb
            // 
            this.BookNameTb.Location = new System.Drawing.Point(50, 52);
            this.BookNameTb.Name = "BookNameTb";
            this.BookNameTb.Size = new System.Drawing.Size(173, 26);
            this.BookNameTb.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Silver;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(919, 213);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 44);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "ISBN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Author Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Title";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(56, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 136);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add Book";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1635, 1017);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImagePb)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox IsbnTb;
        private System.Windows.Forms.TextBox AuthorNameTb;
        private System.Windows.Forms.TextBox BookNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddImgBtn;
        private System.Windows.Forms.PictureBox BookImagePb;
    }
}
