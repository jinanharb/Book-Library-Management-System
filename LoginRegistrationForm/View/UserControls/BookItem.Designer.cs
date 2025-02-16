namespace LoginRegistrationForm.View
{
    partial class BookItem
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
            this.BookAuthName = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.LikeBtn = new System.Windows.Forms.PictureBox();
            this.BookImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LikeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BookAuthName
            // 
            this.BookAuthName.AutoSize = true;
            this.BookAuthName.BackColor = System.Drawing.SystemColors.Control;
            this.BookAuthName.Font = new System.Drawing.Font("Microsoft Uighur", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthName.ForeColor = System.Drawing.Color.DimGray;
            this.BookAuthName.Location = new System.Drawing.Point(53, 393);
            this.BookAuthName.Name = "BookAuthName";
            this.BookAuthName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BookAuthName.Size = new System.Drawing.Size(160, 48);
            this.BookAuthName.TabIndex = 5;
            this.BookAuthName.Text = "Auth Name";
            this.BookAuthName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.BackColor = System.Drawing.SystemColors.Control;
            this.BookTitle.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.ForeColor = System.Drawing.Color.DimGray;
            this.BookTitle.Location = new System.Drawing.Point(55, 337);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BookTitle.Size = new System.Drawing.Size(68, 31);
            this.BookTitle.TabIndex = 20;
            this.BookTitle.Text = "Title";
            this.BookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.BackColor = System.Drawing.Color.DarkGray;
            this.BorrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBtn.ForeColor = System.Drawing.Color.White;
            this.BorrowBtn.Location = new System.Drawing.Point(20, 450);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(182, 83);
            this.BorrowBtn.TabIndex = 22;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // LikeBtn
            // 
            this.LikeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.LikeBtn.Location = new System.Drawing.Point(278, 464);
            this.LikeBtn.Name = "LikeBtn";
            this.LikeBtn.Size = new System.Drawing.Size(50, 59);
            this.LikeBtn.TabIndex = 23;
            this.LikeBtn.TabStop = false;
            this.LikeBtn.Click += new System.EventHandler(this.LikeBtn_Click);
            // 
            // BookImg
            // 
            this.BookImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.BookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookImg.Location = new System.Drawing.Point(33, 25);
            this.BookImg.Name = "BookImg";
            this.BookImg.Size = new System.Drawing.Size(295, 255);
            this.BookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookImg.TabIndex = 4;
            this.BookImg.TabStop = false;
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LikeBtn);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.BookAuthName);
            this.Controls.Add(this.BookImg);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(362, 555);
            ((System.ComponentModel.ISupportInitialize)(this.LikeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BookAuthName;
        private System.Windows.Forms.PictureBox BookImg;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.PictureBox LikeBtn;
    }
}
