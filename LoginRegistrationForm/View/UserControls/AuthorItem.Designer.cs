namespace LoginRegistrationForm
{
    partial class AuthorItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorItem));
            this.authName = new System.Windows.Forms.Label();
            this.LoadBooks = new System.Windows.Forms.Button();
            this.BookCount = new System.Windows.Forms.Label();
            this.BookImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // authName
            // 
            this.authName.AutoSize = true;
            this.authName.BackColor = System.Drawing.SystemColors.Control;
            this.authName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authName.ForeColor = System.Drawing.Color.DimGray;
            this.authName.Location = new System.Drawing.Point(42, 127);
            this.authName.Name = "authName";
            this.authName.Size = new System.Drawing.Size(64, 25);
            this.authName.TabIndex = 24;
            this.authName.Text = "Name";
            // 
            // LoadBooks
            // 
            this.LoadBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.LoadBooks.ForeColor = System.Drawing.Color.White;
            this.LoadBooks.Location = new System.Drawing.Point(134, 155);
            this.LoadBooks.Name = "LoadBooks";
            this.LoadBooks.Size = new System.Drawing.Size(75, 78);
            this.LoadBooks.TabIndex = 23;
            this.LoadBooks.Text = "See All Books";
            this.LoadBooks.UseVisualStyleBackColor = false;
            this.LoadBooks.Click += new System.EventHandler(this.LoadBooks_Click);
            // 
            // BookCount
            // 
            this.BookCount.AutoSize = true;
            this.BookCount.BackColor = System.Drawing.SystemColors.Control;
            this.BookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCount.ForeColor = System.Drawing.Color.DimGray;
            this.BookCount.Location = new System.Drawing.Point(9, 197);
            this.BookCount.Name = "BookCount";
            this.BookCount.Size = new System.Drawing.Size(125, 25);
            this.BookCount.TabIndex = 22;
            this.BookCount.Text = "Books Count";
            // 
            // BookImg
            // 
            this.BookImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.BookImg.Image = ((System.Drawing.Image)(resources.GetObject("BookImg.Image")));
            this.BookImg.Location = new System.Drawing.Point(38, 3);
            this.BookImg.Name = "BookImg";
            this.BookImg.Size = new System.Drawing.Size(119, 112);
            this.BookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookImg.TabIndex = 21;
            this.BookImg.TabStop = false;
            // 
            // AuthorItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.authName);
            this.Controls.Add(this.LoadBooks);
            this.Controls.Add(this.BookCount);
            this.Controls.Add(this.BookImg);
            this.Name = "AuthorItem";
            this.Size = new System.Drawing.Size(210, 234);
            ((System.ComponentModel.ISupportInitialize)(this.BookImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authName;
        private System.Windows.Forms.Button LoadBooks;
        private System.Windows.Forms.Label BookCount;
        private System.Windows.Forms.PictureBox BookImg;
    }
}
