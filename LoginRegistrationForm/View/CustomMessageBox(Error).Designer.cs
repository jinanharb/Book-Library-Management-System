namespace LoginRegistrationForm.View
{
    partial class CustomMessageBox_Error_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox_Error_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.MsgBox = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.GoBackBtn);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 47);
            this.panel1.TabIndex = 0;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.BackColor = System.Drawing.Color.MistyRose;
            this.GoBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.GoBackBtn.FlatAppearance.BorderSize = 0;
            this.GoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackBtn.ForeColor = System.Drawing.Color.Black;
            this.GoBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("GoBackBtn.Image")));
            this.GoBackBtn.Location = new System.Drawing.Point(17, 6);
            this.GoBackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(29, 25);
            this.GoBackBtn.TabIndex = 21;
            this.GoBackBtn.UseVisualStyleBackColor = false;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.MistyRose;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(147, 110);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(50, 32);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // MsgBox
            // 
            this.MsgBox.AutoSize = true;
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.Color.Black;
            this.MsgBox.Location = new System.Drawing.Point(144, 71);
            this.MsgBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(65, 17);
            this.MsgBox.TabIndex = 2;
            this.MsgBox.Text = "Message";
            // 
            // CustomMessageBox_Error_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 157);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomMessageBox_Error_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox_Error_";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label MsgBox;
        private System.Windows.Forms.Button GoBackBtn;
    }
}