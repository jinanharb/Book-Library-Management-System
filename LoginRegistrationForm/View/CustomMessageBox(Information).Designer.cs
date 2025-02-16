namespace LoginRegistrationForm.View
{
    partial class CustomMessageBox_Information_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox_Information_));
            this.MsgBox = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgBox
            // 
            this.MsgBox.BackColor = System.Drawing.SystemColors.Control;
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.Color.Black;
            this.MsgBox.Location = new System.Drawing.Point(19, 107);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(478, 34);
            this.MsgBox.TabIndex = 5;
            this.MsgBox.Text = "Message";
            this.MsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MsgBox.Click += new System.EventHandler(this.MsgBox_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(225, 154);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 49);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.InfoBtn);
            this.panel1.Location = new System.Drawing.Point(-12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 73);
            this.panel1.TabIndex = 3;
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.InfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InfoBtn.FlatAppearance.BorderSize = 2;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.ForeColor = System.Drawing.Color.Black;
            this.InfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("InfoBtn.Image")));
            this.InfoBtn.Location = new System.Drawing.Point(31, 24);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(36, 33);
            this.InfoBtn.TabIndex = 21;
            this.InfoBtn.UseVisualStyleBackColor = false;
            // 
            // CustomMessageBox_Information_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 215);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.panel1);
            this.Name = "CustomMessageBox_Information_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox_Information_";
            this.Load += new System.EventHandler(this.CustomMessageBox_Information__Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MsgBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InfoBtn;
    }
}